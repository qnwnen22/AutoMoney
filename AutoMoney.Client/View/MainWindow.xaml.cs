using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AutoMoney.Client.View
{
    public partial class MainWindow : Window
    {
        private IService iService;
        private Member member;
        public Tistory.Api TistoryApi;
        public MainWindow(IService iService, Member member)
        {
            this.iService = iService;
            this.member = member;
            InitializeComponent();
            this.TistoryApi = new Tistory.Api(Properties.Settings.Default.Tistory_AppID,
                                           Properties.Settings.Default.Tistory_SecretKey,
                                           Properties.Settings.Default.Tistory_CallBack,
                                           Properties.Settings.Default.Tistory_BlogName
                                           );
            Properties.Settings.Default.Tistory_Token = null;
            Properties.Settings.Default.Save();
            this.Browser.MainWindow = this;
        }

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
            this.TistoryApi.SetAccessToken(Properties.Settings.Default.Tistory_Token);
        }
    }
}
