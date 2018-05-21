using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Models
{
    public class Order
    {
        public string OrderID { get; set; }
        public int ProductID { get; set; }
        public string Email { get; set; }
        public int Quantity { get; set; }
        
    }
}
