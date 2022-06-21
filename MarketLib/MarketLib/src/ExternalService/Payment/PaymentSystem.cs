using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLib.src.ExternalService.Payment
{
    public interface PaymentSystem
    {
        int pay(Dictionary<string, string> request);
        int cancelPayment(Dictionary<string, string> request);
    }
}
