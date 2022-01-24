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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutoMoney.Client.View.Main
{
    /// <summary>
    /// Setting_Coupang.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Setting_Coupang : Page, ISettingCommand
    {
        public Setting_Coupang()
        {
            InitializeComponent();
            this.TextBoxAccessKey.Text = Properties.Settings.Default.Coupang_AccessKey;
            this.TextBoxSecretKey.Text = Properties.Settings.Default.Coupang_SecretKey;
        }
        public Set OnSave()
        {
            string accessKey = this.TextBoxAccessKey.Text;
            string secretKey = this.TextBoxSecretKey.Text;
            if (string.IsNullOrWhiteSpace(accessKey) || string.IsNullOrWhiteSpace(secretKey))
            {
                MessageBox.Show("API키를 입력해주세요.");
            }
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("Coupang_AccessKey", accessKey);
            dictionary.Add("Coupang_SecretKey", secretKey);
            var set = new Set("Coupang", dictionary);
            return set;
        }
    }
}
