using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int ListPrice { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Price50 { get; set; }
        [Required]
        public int Price100 { get; set; }
        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Categories { get; set; }
        [Required]
        [Display(Name = "Cover type")]
        public int CoverId { get; set; }
        [ForeignKey("CoverId")]
        public virtual Cover_type Cover_Types { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [NotMapped]
        public IFormFile Img { get; set; }
    }
}
