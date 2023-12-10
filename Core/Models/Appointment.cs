using Core.Models.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Appointment
    {
        [Required]
        public int id { get; set; }
        [Required]
        public Days day { get; set; }
        public List<Time> times { get; set; }
        public int doctorId { get; set; }
        [ForeignKey("doctorId")]
        public Doctor doctor { get; set; }
    }
}
