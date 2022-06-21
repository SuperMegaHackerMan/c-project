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
        private String msg; 

        public Notification(String msg)
        {
            this.msg = msg;
        }

        public String getMsg(Product p)
        {
            return msg;
        }

    }
}
