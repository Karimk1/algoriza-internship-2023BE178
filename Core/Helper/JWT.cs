using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helper
{
    public class JWT
    {
        public String Key { get; set; }
        public String Issuer { get; set; }
        public String Audience { get; set; }
        public double DurationInDays { get; set; }
    }
}
