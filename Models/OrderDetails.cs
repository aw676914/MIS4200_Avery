using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avery_MIS4200.Models
{
    public class orderDetail
    {
        public int orderdetailID { get; set; }
        public int qtyOrdered { get; set; }
        public decimal price { get; set; }
        // the next two properties link the orderDetail to the Order
        public int orderID { get; set; }
        public virtual Order Order { get; set; }
        // the next two properties link the orderDetail to the Product
        public int productID { get; set; }
        public virtual Product { get; set; }
    }
}




