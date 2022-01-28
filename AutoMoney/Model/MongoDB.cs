using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMoney
{
    public class MongoDB
    {
        public readonly string _id;
        public string state;
        public readonly string registryDate;
        public string modifyDate;
        public MongoDB()
        {

            //this._id = Bson.GetID();
            this.state = State.Available.ToString();
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            this.registryDate = now;
            this.modifyDate = now;
        }
    }
}
