using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PaymentPageController : Controller
    {
        // GET: PaymentPage
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult TestPage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TestPage(string CardNumber, string GateWayID, string RegKey)
        {
            Root somepayment = new Root();
            somepayment.merc = new Merc()
            {
                id = GateWayID,
                regKey = RegKey,
                inType = 1
            };
            somepayment.tranCode = 1;
            somepayment.card = new Card
            {
                pan = "4485896261017708",
                sec = "999",
                xprDt = "2012"
            };
            somepayment.contact = new Contact
            {
                fullName = "Michelle Garrity",
                phone = new List<PhoneItem>()
                {
                    new PhoneItem
                    {
                        type = 3,
                        nr = 5551114444
                    }
                },
                addrLn1 = "123 Test ST",
                city = "Denver",
                state = "CO",
                zipCode = "80021",
                email = "info@email.com"
            };
            somepayment.reqAmt = "01000";
            somepayment.indCode = 1;

            var content = postRequest(somepayment);
            
            return View("Success", content);
        }

        private async Task<string> postRequest(Root root)
        {
            using (HttpClient client = new HttpClient())
            {
                // https://cert.web.transaction.transactionexpress.com/TransFirst.Transaction.Web/api/SendTran
                //client.BaseAddress = new Uri("https://cert.web.transaction.transactionexpress.com");
                var content = JsonConvert.SerializeObject(root);
                var httpContent = new StringContent(content, Encoding.UTF8);
                var result = client.PostAsync("https://cert.web.transaction.transactionexpress.com/TransFirst.Transaction.Web/api/SendTran", httpContent).Result;
                var resultContent = await result.Content.ReadAsStringAsync();
                return resultContent;              
            }
        }
    }
}