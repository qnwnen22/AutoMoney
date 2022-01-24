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

namespace AutoMoney.Client.View.Login
{
    /// <summary>
    /// SignInPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SignInPage : Page
    {
        public string Pwd { get; set; }
        public Window BaseWindow { get; set; }
        public SignInPage()
        {
            InitializeComponent();
            this.DataContext = new ViewModel.LoginViewModel();
        }

        public bool IsLogin()
        {
            return true;
        }
    }
}
