using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class DoctorViewModel
    {
        public string image { get; set; }
        public string name { get; set; }
        public String email { get; set; }

        public string phone { get; set; }
        public string specialize { get; set; }
        public String gander { get; set; }
        public string dateOfBirth { get; set; }
    }
}
