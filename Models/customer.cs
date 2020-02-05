using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avery_MIS4200.Models
{
    public class customer
    {
        public string customerID { get; set; }
        public string CustomerLastName { get; set; }
        public string customerFirstName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime CustomerSince { get; set; }

        public String FullName => CustomerLastName + "," + customerFirstName;
    }
}

    
