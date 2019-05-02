﻿using System.ComponentModel.DataAnnotations;

namespace ClassTest.Models
{
    public class Login
    {
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
