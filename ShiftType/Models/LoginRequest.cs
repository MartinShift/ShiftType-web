﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ShiftType.Models
{
    public class LoginRequest
    {
        [Required]
        [Display(Name = "Login or Email")]
        public string LoginOrEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
