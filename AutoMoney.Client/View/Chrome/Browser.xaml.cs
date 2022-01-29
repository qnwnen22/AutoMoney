using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutoMoney.Client.View.Chrome
{
    /// <summary>
    /// Browser.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Browser : UserControl
    {
        public MainWindow MainWindow { get; set; }
        public CookieContainer CookieContainer { get; set; } = new CookieContainer() { MaxCookieSize = 2000, PerDomainCapacity = 300, };
        public Browser()
        {
            InitializeComponent();
            ChromiumBrowser.LifeSpanHandler = new LifeSpanHandler();
            List<MenuModel> menuModel = new List<MenuModel>();
            menuModel.Add(new MenuModel((CefMenuCommand)30001, "포스팅", Posting));
            ChromiumBrowser.MenuHandler = new ContextMenuHandler(menuModel);
        }
        private async void Posting()
        {
            try
            {
                IFrame iFrame = this.ChromiumBrowser.GetMainFrame();
                string getSourceAsync = await iFrame.GetSourceAsync();
                var http = new Sourcing.Coupang.Http();
                Product product = http.GetProduct(getSourceAsync);
                var api = new Sourcing.Coupang.Api(Properties.Settings.Default.Coupang_AccessKey,
                                          Properties.Settings.Default.Coupang_SecretKey);
                Sourcing.Coupang.Model.ShortUrlResult shortUrlResult = api.GetShortUrlResult(product.originalUrl);
                string shortenUrl = shortUrlResult.data?.First().shortenUrl;
                if (shortenUrl.IsNullOrWhiteSpace())
                {
                    throw new Exception("포스팅이 불가능한 상품입니다.");
                }
                product.shortUrl = shortenUrl;
                try
                {
                    var uri = new Uri(product.thumbnail);
                    if (uri.IsFile)
                    {
                        product.thumbnail = "https:" + product.thumbnail;
                    }
                }
                catch
                {
                    throw new Exception("이미지를 찾을 수 없습니다.");
                }
                //Tistory.ImageResult imageResult = MainWindow.TistoryApi.UploadImage(product.thumbnail, this.CookieContainer);
                //string thum = "<p>[##_Image|kage@"+imageResult.key + "/"+ imageResult.filename+"_##]</p>";
                //sb.AppendLine(thum);
                var stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("<div align='center'>");
                stringBuilder.AppendLine("<meta http-equiv='Content-Type' content='text/html;charset=UTF-8'>");
                stringBuilder.AppendLine($"{product.title}");
                stringBuilder.AppendLine($"<br>");
                stringBuilder.AppendLine($"<br>");
                stringBuilder.AppendLine($"<br>");
                stringBuilder.AppendLine($"<a href='{product.shortUrl}'>");
                stringBuilder.AppendLine($"<img src='{product.thumbnail}'>");
                stringBuilder.AppendLine("</a>");
                stringBuilder.AppendLine($"<br>");
                stringBuilder.AppendLine($"<br>");
                stringBuilder.Append("</div>");
                product.html = stringBuilder.ToString();

                this.MainWindow.Dispatcher.Invoke(() =>
                {
                    var htmlWindow = new Main.HtmlWindow(product.html);
                    htmlWindow.ShowDialog();
                });


                Posting.Tistory.Model.PostResult writePost = MainWindow.TistoryApi.WritePost(product);
                if (writePost.tistory.status == "200")
                {
                    this.Dispatcher.Invoke(() => { MessageBox.Show("True"); });
                }
                else
                {
                    MainWindow.TistoryApi.SetAccessToken(Properties.Settings.Default.Tistory_Token);
                    this.Dispatcher.Invoke(() => { MessageBox.Show("토큰 최신화"); });
                }
            }
            catch (Exception exception)
            {
                this.Dispatcher.Invoke(() => { MessageBox.Show(exception.Message); });
            }
        }
        private void TextBoxAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string inputText = TextBoxAddress.Text;
                try
                {
                    var uri = new Uri(inputText);
                }
                catch
                {
                    inputText = "https://www.google.com/search?q=" + inputText;
                }
                ChromiumBrowser.Load(inputText);
            }
        }
        private void ChromiumBrowser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            CookieContainer = new CookieVisitor().CookieContainer;
        }
    }
}
