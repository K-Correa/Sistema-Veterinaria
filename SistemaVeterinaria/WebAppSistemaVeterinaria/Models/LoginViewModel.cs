﻿using System.ComponentModel.DataAnnotations;

namespace WebAppSistemaVeterinaria.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string UserName { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        public bool RemenberMe { get; set; }
    }
}
