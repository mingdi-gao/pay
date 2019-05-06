using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebPayment.Models;

namespace WebPayment.Controllers
{
    public class cardController : ApiController
    {
        // GET api/values/5
        public card GetCard(int id)
        {
            var sampleCard = new card()
            {
                CardNumber = "123456",
                HolderName = "Mingd",
                cvv = 123
            };
            return sampleCard;
        }

        // POST api/values
        public string Post([FromBody]card requestCard)
        {
            if (requestCard.CardNumber == "12345")
            {
                return "valid card";
            }

            return "Not valid";
        }
    }
}
