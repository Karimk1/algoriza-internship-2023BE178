using Core.Models.enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class PationtRegisterModel
    {
        public IFormFile image { get; set; }
        [Required]
        public String firstname { get; set; }
        [Required]
        public String lastname { get; set; }
        [Required]
        public String phone { get; set; }
        [Required]
        [EmailAddress]
        public String email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public String password { get; set; }
        [Required]
        public Gender gender { get; set; }
        [Required]
        public DateTime dateOfBirth { get; set; }
    }
}
