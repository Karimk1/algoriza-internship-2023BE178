using Core.Models.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class DoctorUpdateModel
    {
        
            [Required]
            public int Id { get; set; }
            [Required]
            public String image { get; set; }
            [Required]

            public string firstname { get; set; }
            [Required]

            public string lastname { get; set; }
            [Required]

            public String phone { get; set; }
            [Required]

            public string email { get; set; }
            [Required]
            public string password { get; set; }
            [Required]
            public int specialize { get; set; }
            [Required]
            public Gender gender { get; set; }
            [Required]
            public int price { get; set; }
            public DateTime DateOfbirth { get; set; }

        }
    }

