using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMoney.Sourcing
{
    public interface ISourcing
    {
        string SiteName { get; set; }
        string SiteCode { get; set; }
        Product GetProduct(string html);
    }
}
