using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMoney.Client.View.Chrome
{
    public class ContextMenuHandler : IContextMenuHandler
    {
        private readonly List<MenuModel> menuModelList;

        public ContextMenuHandler()
        {
        }
        public ContextMenuHandler(List<MenuModel> menuCommendList)
        {
            this.menuModelList = menuCommendList;
        }

        public void OnBeforeContextMenu(IWebBrowser browserControl, CefSharp.IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
        {
            model.Clear();
            this.menuModelList.ForEach(x =>
            {
                model.AddItem(x.commandId, x.label);
            });
        }

        public bool OnContextMenuCommand(IWebBrowser browserControl, CefSharp.IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
        {
            MenuModel find = this.menuModelList.Find(x => x.commandId == commandId);
            find.action();
            return true;
        }

        public void OnContextMenuDismissed(IWebBrowser browserControl, CefSharp.IBrowser browser, IFrame frame)
        {
        }

        public bool RunContextMenu(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
        {
            return false;
        }
    }

}
