using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMoney.Client.View.Main
{
    public interface ISettingCommand
    {
        Set OnSave();
    }
    public class Set
    {
        public string name;
        public Dictionary<string, string> dictionary;
        public Set(string name, Dictionary<string, string> dictionary)
        {
            this.name = name;
            this.dictionary = dictionary;
        }
    }
}
