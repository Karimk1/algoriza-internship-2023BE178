using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Doctor
    {
        public int id { get; set; }
        public int specializeId { get; set; }
        [ForeignKey("specializeId")]
        [Required]
        public Specialize specialize { get; set; }
        [Required]
        public double price { get; set; }
        public String userId { get; set; }
        [ForeignKey("userId")]
        public User user { get; set; }
        public int numberOfRequests { get; set; }
    }
}
