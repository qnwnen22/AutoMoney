using CefSharp;
using CefSharp.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AutoMoney.Client
{
    class Program
    {
        [STAThread]
        public static void Main(string[] arg)
        {
            var cefSettings = new CefSettings
            {
                Locale = "ko",
                LogSeverity = LogSeverity.Disable
            };
            Cef.Initialize(cefSettings);
            System.Windows.Application.LoadComponent(new Uri("/AutoMoney.Client;component/app.xaml", UriKind.Relative));
            System.Windows.Application.Current.ShutdownMode = System.Windows.ShutdownMode.OnExplicitShutdown;
            var mainWindow1 = new View.MainWindow(null,null);
            mainWindow1.ShowDialog();
            var channelFactory = new ChannelFactory<IService>();
            channelFactory.Endpoint.Address = new EndpointAddress("net.tcp://localhost:8080/AutoMoney");
            channelFactory.Endpoint.Binding = new CustomNetTcpBinding().GetNetTcpBinding();
            channelFactory.Endpoint.Contract.ContractType = typeof(IService);
            IService iService = channelFactory.CreateChannel();
            do
            {
                var loginWindow = new View.LoginWindow(iService);
                bool? isLogin = loginWindow.ShowDialog();
                if (isLogin == true)
                {
                    var mainWindow = new View.MainWindow(iService, loginWindow.member);
                    bool? isClose = mainWindow.ShowDialog();
                    if (isClose == true)
                    {
                        continue;
                    }
                    break;
                }
                else
                {
                    break;
                }
            }
            while (true);
        }
    }
}
