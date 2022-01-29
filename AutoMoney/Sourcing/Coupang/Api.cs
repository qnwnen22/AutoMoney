using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutoMoney.Sourcing.Coupang
{
    public class Api
    {
        private class Request
        {
            public List<string> coupangUrls { get; set; }
        }

        public readonly string AccessKey;
        public readonly string SecretKey;
        private readonly string REQUEST_METHOD = "POST";
        private readonly string DOMAIN = "https://api-gateway.coupang.com";
        private readonly string URL = "/v2/providers/affiliate_open_api/apis/openapi/deeplink";

        public Api(string accessKey, string secretKey)
        {
            this.AccessKey = accessKey;
            this.SecretKey = secretKey;
        }
        public Model.ShortUrlResult GetShortUrlResult(string url)
        {
            return this.GetShortUrlResult(new List<string>() { url });
        }
        public Model.ShortUrlResult GetShortUrlResult(List<string> urlList)
        {
            if (string.IsNullOrWhiteSpace(this.AccessKey) || string.IsNullOrWhiteSpace(this.SecretKey))
            {
                throw new Exception("쿠팡 API키 설정이 필요합니다.");
            }
            if (urlList.Count > 20)
            {
                throw new Exception("한번에 생성할 수 있는 URL은 최대 20개입니다.");
            }
            Model.ShortUrlResult result = null;

            var post = new Request()
            {
                coupangUrls = urlList
            };
            var signature = new HmacGenerator().GenerateHmac(REQUEST_METHOD, URL, this.AccessKey, this.SecretKey);
            var postBytes = UTF8Encoding.Default.GetBytes(post.ToJson());
            var apiUrl = string.Format("{0}{1}", DOMAIN, URL);
            var request = HttpWebRequest.Create(apiUrl);
            request.Method = REQUEST_METHOD;
            request.ContentType = "application/json";
            request.Headers.Add("Authorization", signature);
            request.ContentLength = postBytes.Length;
            using (var requestStream = request.GetRequestStream())
            {
                requestStream.Write(postBytes, 0, postBytes.Length);
            }
            using (var response = request.GetResponse() as HttpWebResponse)
            {
                using (var responseStream = response.GetResponseStream())
                {
                    var reader = new StreamReader(responseStream);
                    var respText = reader.ReadToEnd();
                    result = respText.ToClass<Model.ShortUrlResult>();
                }
            }
            return result;
        }

    }
}
