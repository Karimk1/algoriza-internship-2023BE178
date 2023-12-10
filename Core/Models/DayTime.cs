using Core.Models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class DayTime
    {
        public Days days {  get; set; }
        public List<double> times { get; set; }
    }
}
