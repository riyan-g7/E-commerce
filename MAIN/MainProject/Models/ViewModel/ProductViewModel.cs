using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Models.ViewModel
{
    public class ProductViewModel
    {
        public Product product { get; set; }       
        public IEnumerable<SelectListItem> categories { get; set; }
        public IEnumerable<SelectListItem> covers { get; set; }
    }
}
