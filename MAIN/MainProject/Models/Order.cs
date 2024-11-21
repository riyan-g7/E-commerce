using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid name")]
        public string Name { get; set; }
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
        public string Zip_code { get; set; }
        [RegularExpression(@"\b[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}\b", ErrorMessage = "Invalid E-mail")]
        public string Email { get; set; }
        public string Order_date { get; set; }
        public string Carrier { get; set; }
        public string Tracking { get; set; }
        public string Shipping_Date { get; set; }
        public string TransactionID { get; set; }
        public string Payment_Due_Date { get; set; }
        public string Payment_Status { get; set; }
        public string SessionId { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User Users { get; set; }
        public string Order_status { get; set; }
        public int Order_total { get; set; }
    }
}
