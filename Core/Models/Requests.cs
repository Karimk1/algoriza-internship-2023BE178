using Core.Models.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Requests
    {
        public int id { get; set; }
        [NotNull]
        public int doctorId { get; set; }
        [ForeignKey("doctorId")]
        public Doctor doctor { get; set; }
        [NotNull]
        public String pationtId { get; set; }
        [ForeignKey("pationtId")]
        public User pationt { get; set; }
        public RequestType requestType { get; set; }
        public DateTime requestDate { get; set; }
        public int timeId { get; set; }
        [ForeignKey("timeId")]
        public Time time { get; set; }
        public int? couponId { get; set; }
        [ForeignKey("couponId")]
        public Coupon? coupon { get; set; }
        public double finalPrice { get; set; }
    }
}
