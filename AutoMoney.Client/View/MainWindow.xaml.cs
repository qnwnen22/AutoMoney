using System;
using System.Threading.Tasks;
using System.Windows;

namespace AutoMoney.Client.View
{
    public partial class MainWindow : Window
    {
        #region Field
        private IService iService;
        private Member member;
        public Posting.Tistory.Api TistoryApi;
        #endregion
        public MainWindow(IService iService, Member member)
        {
            this.iService = iService;
            this.member = member;
            InitializeComponent();
            WindowState state = Properties.Settings.Default.Window_State;
            this.WindowState = state;
            var size = Properties.Settings.Default.Window_Size;
            if (size.Width <= 0) size.Width = 800;
            if (size.Height <= 0) size.Height = 400;
            this.Width = size.Width;
            this.Height = size.Height;
            Point point = Properties.Settings.Default.Window_Point;
            if (point.X <= 0 || point.Y <= 0)
            {
                this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            }
            else
            {
                this.Left = point.X;
                this.Top = point.Y;
            }
            try
            {
                this.TistoryApi = new Posting.Tistory.Api(Properties.Settings.Default.Tistory_AppID,
                                               Properties.Settings.Default.Tistory_SecretKey,
                                               Properties.Settings.Default.Tistory_CallBack,
                                               Properties.Settings.Default.Tistory_BlogName
                                               );
                Properties.Settings.Default.Tistory_Token = null;
                Properties.Settings.Default.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            this.Browser.MainWindow = this;
        }
        #region Event
        private void UrlCoupang_Click(object sender, RoutedEventArgs e)
        {
            this.Browser.ChromiumBrowser.Load("https://www.coupang.com/");
        }

        private void UrlTistroy_Click(object sender, RoutedEventArgs e)
        {
            this.Browser.ChromiumBrowser.Load("https://www.tistory.com/");

        }
        private void UrlNaver_Click(object sender, RoutedEventArgs e)
        {
            this.Browser.ChromiumBrowser.Load("https://www.naver.com/");
        }

        private void MenuItemSetting_Click(object sender, RoutedEventArgs e)
        {
            var settingWindow = new Main.SettingWindow();
            settingWindow.ShowDialog();
            try
            {
                this.TistoryApi.SetAccessToken(Properties.Settings.Default.Tistory_Token);
            }
            catch (Exception exception)
            {

            }
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            WindowState windowState = this.WindowState;
            Properties.Settings.Default.Window_State = windowState;

            var size = new Size(this.Width, this.Height);
            Properties.Settings.Default.Window_Size = size;

            var point = new Point(this.Left, this.Top);
            Properties.Settings.Default.Window_Point = point;

            Properties.Settings.Default.Save();
        }
        #endregion

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
            }
            catch (NullReferenceException nullReferenceException)
            {

            }
            catch (Exception exception)
            {

            }
        }
    }
}
