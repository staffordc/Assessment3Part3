using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment3Part3.CustomerVM
{
    public class OrdersVM
    {
        public int OrderID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public string ShipCity { get; set; }
    }
}