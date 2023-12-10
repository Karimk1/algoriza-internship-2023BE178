using Core.Models.enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class User : IdentityUser
    { 
        public String? image { get; set; }
        [Required]
        public Gender gender { get; set; }
        [Required]
        public DateTime dateOfBirth { get; set; }
        public Role role { get; set; }
    }
}
