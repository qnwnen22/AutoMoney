using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AutoMoney
{
    public class CustomNetTcpBinding
    {
        public NetTcpBinding GetNetTcpBinding()
        {
            var netTcpBinding = new NetTcpBinding();
            netTcpBinding.Security = new NetTcpSecurity();
            netTcpBinding.Security.Mode = SecurityMode.None;
            netTcpBinding.MaxConnections = 10000;
            netTcpBinding.MaxReceivedMessageSize = 2147483647;
            netTcpBinding.MaxBufferSize = 2147483647;
            netTcpBinding.MaxBufferPoolSize = 2147483647;
            var timeSpan = new TimeSpan(1, 0, 0);
            netTcpBinding.OpenTimeout = timeSpan;
            netTcpBinding.CloseTimeout = timeSpan;
            netTcpBinding.SendTimeout = timeSpan;
            netTcpBinding.ReceiveTimeout = timeSpan;
            return netTcpBinding;
        }
    }

}
