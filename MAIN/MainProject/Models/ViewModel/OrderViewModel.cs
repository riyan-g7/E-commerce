using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Models.ViewModel
{
    public class OrderViewModel
    {
        public Order orders { get; set; }
        public IEnumerable<Order_items> order_items { get; set; }
    }
}
