using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required(ErrorMessage = "Enter a Postal Code")]
        public string P_code { get; set; }
        [Required]
        [RegularExpression(@"^\d{10,12}$", ErrorMessage = "10 or 12 digits!")]
        public string Mobile { get; set; }
        [Required]
        public bool IsAuthorized { get; set; }
    }
}
