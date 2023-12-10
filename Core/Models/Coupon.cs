using Core.Models.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Coupon
    {
        public int id { get; set; }
        [Required]
        public String discoundCode { get; set; }
        [Required]
        public DiscoundType discoundType { get; set; }
        [Required]
        public int discoundValue { get; set; }
        [Required]
        public int requestNumber { get; set; }
        public int usage { get; set; }
        public bool active { get; set; }
    }
}
