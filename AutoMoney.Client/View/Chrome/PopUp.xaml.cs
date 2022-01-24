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

namespace AutoMoney.Client.View.Chrome
{
    /// <summary>
    /// PopUp.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PopUp : Window
    {
        public string CurrentAddress
        {
            get
            {
                return this.Chrome.Address;
            }
        }
        public PopUp(string address)
        {
            InitializeComponent();
            this.Chrome.Address = address;
        }

        private void btnAuthCode_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
