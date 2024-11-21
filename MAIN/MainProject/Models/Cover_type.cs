using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Models
{
    public class Cover_type
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Ctname { get; set; }
    }
}
