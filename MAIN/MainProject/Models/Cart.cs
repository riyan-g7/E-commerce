using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name="Product")]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Products { get; set; }
        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User Users { get; set; }
        [Required]
        [Range(0,1000,ErrorMessage ="Too much quantity entered!")]
        public int Count { get; set; }
        [Required]
        public int Rate { get; set; }
    }
}
