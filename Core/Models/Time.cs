using Core.Models.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Time
    {
        public int id { get; set; }
        public int appointmentId { get; set; }
        [ForeignKey("appointmentId")]
        public Appointment appointment { get; set; }
        public double time { get; set; }
        public bool status { get; set; }

    }
}
