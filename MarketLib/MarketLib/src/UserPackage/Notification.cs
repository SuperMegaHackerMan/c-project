using MarketLib.src.StoreNS;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLib.src.UserP
{
    public class Notification
    {
        private string msg; 

        public Notification(string msg)
        {
            this.msg = msg;
        }

        public string getMsg(Product p)
        {
            return msg;
        }

    }
}
