using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMoney.Client.View.Chrome
{
    public class MenuModel
    {
        public CefMenuCommand commandId;
        public string label;
        public Action action;
        public MenuModel(CefMenuCommand commandId, string label, Action action)
        {
            this.commandId = commandId;
            this.label = label;
            this.action = action;
        }
    }
}
