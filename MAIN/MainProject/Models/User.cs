using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid name")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"\b[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}\b", ErrorMessage = "Invalid E-mail")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^\d{10,12}$", ErrorMessage = "10 or 12 digits!")]
        public string Phone { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required(ErrorMessage = "Enter a Postal Code")]
        public string P_Code{get;set;}
        [Required]
        public string Password { get; set; }
        [NotMapped]
        [Compare("Password",ErrorMessage ="Passwords do not match")]
        public string Confirm { get; set; }
    }
}
