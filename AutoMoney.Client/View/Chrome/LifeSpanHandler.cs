using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMoney.Client.View.Chrome
{
    public class LifeSpanHandler : ILifeSpanHandler
    {
        public bool DoClose(IWebBrowser chromiumWebBrowser, IBrowser browser) { return true; }

        public void OnAfterCreated(IWebBrowser chromiumWebBrowser, IBrowser browser) { }

        public void OnBeforeClose(IWebBrowser chromiumWebBrowser, IBrowser browser) { }

        public bool OnBeforePopup(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, string targetUrl, string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
        {
            newBrowser = null;
            chromiumWebBrowser.Load(targetUrl);
            return true;
        }
    }
}
