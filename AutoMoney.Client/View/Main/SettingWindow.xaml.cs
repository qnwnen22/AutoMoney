using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AutoMoney.Client.View.Main
{
    /// <summary>
    /// SettingWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SettingWindow : Window
    {
        public SettingWindow()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            ISettingCommand iSettingCommand = this.Content.Content as ISettingCommand;
            Set set = iSettingCommand.OnSave();
            switch (set.name)
            {
                case "Coupang":
                    Properties.Settings.Default.Coupang_AccessKey = set.dictionary["Coupang_AccessKey"];
                    Properties.Settings.Default.Coupang_SecretKey = set.dictionary["Coupang_SecretKey"];
                    break;
                case "Tistory":
                    Properties.Settings.Default.Tistory_AppID = set.dictionary["Tistory_AppID"];
                    Properties.Settings.Default.Tistory_SecretKey = set.dictionary["Tistory_SecretKey"];
                    Properties.Settings.Default.Tistory_CallBack= set.dictionary["Tistory_CallBack"];
                    Properties.Settings.Default.Tistory_BlogName = set.dictionary["Tistory_BlogName"];
                    Properties.Settings.Default.Tistory_Token= set.dictionary["Tistory_Token"];
                    break;
            }
            Properties.Settings.Default.Save();
            MessageBox.Show("저장 되었습니다.");
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void HyTistory_Click(object sender, RoutedEventArgs e)
        {
            LabelContent.Content = "티스토리API 설정";
            this.Content.NavigationService.Navigate(new Uri(@"\View\Main\Setting_Tistory.xaml", UriKind.Relative));
        }

        private void HyCoupang_Click(object sender, RoutedEventArgs e)
        {
            LabelContent.Content = "쿠팡API 설정";
            this.Content.NavigationService.Navigate(new Uri(@"\View\Main\Setting_Coupang.xaml", UriKind.Relative));
        }
    }
}
