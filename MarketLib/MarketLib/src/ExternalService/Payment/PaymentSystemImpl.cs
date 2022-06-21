using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLib.src.ExternalService.Payment
{

    //same as supply, this is a proxy class.
    public class PaymentSystemImpl : PaymentSystem
    {
        private PaymentSystem paymentSys;
        public PaymentSystemImpl(PaymentSystem paymentSys)
        {
            this.paymentSys = paymentSys;
        }
        public int cancelPayment(Dictionary<string, string> request)
        {
            //check the request.
            return paymentSys.cancelPayment(request);
        }

        public int pay(Dictionary<string, string> request)
        {
            if (request == null)
            {
                throw new Exception("Address not supplied");
            }
            //if (!data.legalAddress())
          //  {
             //   throw new Exception("Address details are illegal");
          //  }
            return paymentSys.pay(request);
        }

        //prepare payment request.
        private Dictionary<string, string> paymentRequest(CreditCard credit)
        {
            Dictionary<string, string> req = new Dictionary<string, string>();

            req.Add("action_type", "pay");
            req.Add("card_number", credit.number);
            req.Add("month", credit.month);
            req.Add("year", credit.year);
            req.Add("holder", credit.holder);
            req.Add("ccv", credit.cvv);
            req.Add("id", credit.id);
            return req;
        }

        private Dictionary<string, string> cancel_paymentRequest(int transactionId)
        {
            Dictionary<string, string> req = new Dictionary<string, string>();

            req.Add("action_type", "pay");
            req.Add("transaction_id", transactionId.ToString());

            return req;
        }
    }
}
