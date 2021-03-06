﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StackOverfaux.ViewModels
{
    public class RegisterViewModel
    {
        //[Required]
        //[Display(Name = "Display Name")]
        //public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email (required, but never shown)")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
