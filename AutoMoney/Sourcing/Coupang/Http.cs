using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMoney.Sourcing.Coupang
{
    public class Http : ISourcing
    {
        public string SiteName { get; set; } = "Coupang";
        public string SiteCode { get; set; }

        private string createHTML(SDP spd)
        {
            var sb = new StringBuilder();
            sb.Append("");
            sb.Append("");
            sb.Append("");
            sb.Append("");
            sb.Append("");
            sb.Append("");
            sb.Append("");
            sb.Append("");
            sb.Append("");
            sb.Append("");
            sb.Append("");
            sb.Append("");
            sb.Append("");


            return null;
        }

        public Product GetProduct(string html)
        {
            string address = html.GetHtmlNodeAttributeValue("//meta[@property='og:url']", "content");
            if (address.IsNullOrWhiteSpace()) { throw new Exception("상품 주소를 찾을 수 없습니다."); }
            string image = html.GetHtmlNodeAttributeValue("//img[@class='prod-image__detail']", "src");
            if (image.IsNullOrWhiteSpace()) { throw new Exception("이미지를 찾을 수 없습니다."); }
            string sdpJson = html.Truncate("exports.sdp = ", ";");
            SDP spd = sdpJson.ToClass<SDP>();
            if (spd is null) { throw new Exception("상품정보를 찾을 수 없습니다."); }
            Product product = new Product()
            {
                title = spd.itemName,
                code = spd.itemId,
                thumbnail = image,
                originalUrl = address,
                price = null,
            };
            return product;
        }
    }
}
