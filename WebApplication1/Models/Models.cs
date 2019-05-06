using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Models
    {
    }

    public class Merc
    {
        public string id { get; set; }

        public string regKey { get; set; }

        public int inType { get; set; }
    }

    public class Card
    {

        public string pan { get; set; }

        public string sec { get; set; }

        public string xprDt { get; set; }
    }

    public class PhoneItem
    {

        public int type { get; set; }

        public long nr { get; set; }
    }

    public class Contact
    {

        public string fullName { get; set; }

        public List<PhoneItem> phone { get; set; }

        public string addrLn1 { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public string zipCode { get; set; }

        public string email { get; set; }
    }

    public class Root
    {

        public Merc merc { get; set; }

        public int tranCode { get; set; }

        public Card card { get; set; }

        public Contact contact { get; set; }

        public string reqAmt { get; set; }

        public int indCode { get; set; }
    }
}