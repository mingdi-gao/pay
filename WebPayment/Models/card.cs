using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPayment.Models
{
    public class card
    {
        public string CardNumber { get; set; }
        public string HolderName { get; set; }
        public int cvv { get; set; }
    }
}