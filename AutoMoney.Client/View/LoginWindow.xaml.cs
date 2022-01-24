using AutoMoney.Client.View.Login;
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

namespace AutoMoney.Client.View
{
    /// <summary>
    /// LoginWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LoginWindow : Window
    {
        public IService iService;
        public Member member;
        public LoginWindow(IService iService)
        {
            InitializeComponent();
            this.iService = iService;
        }

        public void IsLogin()
        {

        }

        private void Login()
        {
            var member = new Member()
            {
                account = this.Account.Text,
                password = this.Password.Password,
            };
            Member findMember = iService.FindMember(member);
            if (findMember is null)
            {
                MessageBox.Show("아이디 혹은 비밀번호를 확인해주세요.");
            }
            else
            {
                this.member = findMember;
                this.DialogResult = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login();
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Login();
            }
        }
    }
}
