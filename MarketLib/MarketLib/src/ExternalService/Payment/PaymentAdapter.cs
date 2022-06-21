using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MarketLib.src.ExternalService.Payment
{
    public class PaymentAdapter : PaymentSystem
    {
        public int cancelPayment(Dictionary<string, string> request)
        {
           
        }

        public int pay(Dictionary<string, string> request)
        {
            throw new NotImplementedException();
        }

        //POST REQUEST ASYNC 
        async public Task<int> sendRequest(Dictionary<string, string> request)
        {

            try
            {
                var content = new FormUrlEncodedContent(request);
                var response = await client.PostAsync(url, content);
                return int.Parse(await response.Content.ReadAsStringAsync());
            }
            catch (Exception e)
            {
                throw new Exception("Error0");
            }
        }
    }
}
