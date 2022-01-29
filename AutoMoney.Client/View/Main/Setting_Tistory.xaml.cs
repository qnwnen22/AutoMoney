using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace AutoMoney.Client.View.Main
{
    /// <summary>
    /// Setting_Tistroy.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Setting_Tistory : Page, ISettingCommand
    {
        public Setting_Tistory()
        {
            InitializeComponent();
            this.TextBoxAppID.Text = Properties.Settings.Default.Tistory_AppID;
            this.TextBoxSecretKey.Text = Properties.Settings.Default.Tistory_SecretKey;
            this.TextBoxCallBack.Text = Properties.Settings.Default.Tistory_CallBack;
            this.TextBoxBlogName.Text = Properties.Settings.Default.Tistory_BlogName;
            this.TextBoxToken.Text = Properties.Settings.Default.Tistory_Token;
        }
        public Set OnSave()
        {
            string tistory_AppID = this.TextBoxAppID.Text;
            string tistory_SecretKey = this.TextBoxSecretKey.Text;
            string tistory_CallBack = this.TextBoxCallBack.Text;
            string tistory_BlogName = this.TextBoxBlogName.Text;
            string tistory_Token = this.TextBoxToken.Text;
            if (string.IsNullOrWhiteSpace(tistory_AppID) ||
                string.IsNullOrWhiteSpace(tistory_SecretKey))
            {
                MessageBox.Show("API키를 입력해주세요.");
            }
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("Tistory_AppID", tistory_AppID);
            dictionary.Add("Tistory_SecretKey", tistory_SecretKey);
            dictionary.Add("Tistory_CallBack", tistory_CallBack);
            dictionary.Add("Tistory_BlogName", tistory_BlogName);
            dictionary.Add("Tistory_Token", tistory_Token);
            var set = new Set("Tistory", dictionary);
            return set;
        }
        private void ButtonToken_Click(object sender, RoutedEventArgs e)
        {
            string tistory_AppID = this.TextBoxAppID.Text;
            string tistory_SecretKey = this.TextBoxSecretKey.Text;
            string tistory_CallBack = this.TextBoxCallBack.Text;
            string tistory_BlogName = this.TextBoxBlogName.Text;
            if (tistory_AppID.IsNullOrWhiteSpace() ||
                tistory_SecretKey.IsNullOrWhiteSpace() ||
                tistory_CallBack.IsNullOrWhiteSpace() ||
                tistory_BlogName.IsNullOrWhiteSpace())
            {
                MessageBox.Show("티스토리 API 설정이 필요합니다.");
                return;
            }
            Posting.Tistory.Api tistory = new Posting.Tistory.Api(tistory_AppID, tistory_SecretKey, tistory_CallBack, tistory_BlogName);
            var getAuthCodeUrl = tistory.GetAuthCodeUrl();
            var popup = new View.Chrome.PopUp(getAuthCodeUrl);
            popup.ShowDialog();
            string address = popup.Chrome.Address;
            var token = address.Truncate("code=", "&");
            if (token.IsNullOrWhiteSpace())
            {
                MessageBox.Show("토큰 생성에 실패했습니다.\n다시 시도해주세요.");
                return;
            }
            this.TextBoxToken.Text = token;
        }
    }
}
