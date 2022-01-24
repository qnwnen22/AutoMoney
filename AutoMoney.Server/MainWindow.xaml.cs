using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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

namespace AutoMoney.Server
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private ServiceHost serviceHost;
        const string addres = "net.tcp://localhost:8080/AutoMoney";
        public MainWindow()
        {
            serviceHost = new ServiceHost(typeof(Service));
            var customNetTcpBinding = new CustomNetTcpBinding().GetNetTcpBinding();
            serviceHost.AddServiceEndpoint(typeof(IService), customNetTcpBinding, addres);
            serviceHost.Open();
            InitializeComponent();
        }
    }
}
