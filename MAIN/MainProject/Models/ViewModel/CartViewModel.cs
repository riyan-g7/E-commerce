using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Models.ViewModel
{
    public class CartViewModel
    {
        public Order orders { get; set; }
        public IEnumerable<Cart> carts { get; set; }
    }
}
