using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AutoMoney
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        Member FindMember(Member member);
        [OperationContract]
        bool SignUp(Member member);
    }
}
