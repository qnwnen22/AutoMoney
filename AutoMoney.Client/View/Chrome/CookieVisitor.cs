using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMoney.Client.View.Chrome
{
    public class CookieVisitor : System.Net.CookieContainer, CefSharp.ICookieVisitor
    {
        private System.Net.CookieContainer cookieContainer = new System.Net.CookieContainer();
        public System.Net.CookieContainer CookieContainer
        {
            get
            {
                CefSharp.ICookieManager globalCookieManager = CefSharp.Cef.GetGlobalCookieManager();
                globalCookieManager.VisitAllCookies(this);
                return cookieContainer;
            }
        }
        public void Dispose()
        {
            this.cookieContainer = null;
        }

        public bool Visit(CefSharp.Cookie cookie, int count, int total, ref bool deleteCookie)
        {
            try
            {
                var cefCookie = new System.Net.Cookie(cookie.Name, cookie.Value, cookie.Path, cookie.Domain);
                this.cookieContainer.Add(cefCookie);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
