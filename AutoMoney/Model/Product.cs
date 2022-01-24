using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMoney
{
    public class Product : MongoDB
    {
        public Category category;
        public string code;
        public string title;
        public string originalUrl;
        public string shortUrl;
        public string thumbnail;
        public string price;
        public string html;
    }
}
