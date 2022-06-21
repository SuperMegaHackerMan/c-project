using MarketLib.src.StoreNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLib.src.StorePermission
{
    public class AbsStorePermission
    {
        protected Store store;

        protected AbsStorePermission(Store store)
        {
            this.store = store;
        }

        public Store getStore()
        {
            return store;
        }

        public string toString()
        {
            return GetType().ToString() + "{" +
                    "store=" + (store == null ? null : store.getName()) +
                    '}';
        }
    }
}
