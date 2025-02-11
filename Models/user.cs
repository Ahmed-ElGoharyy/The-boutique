﻿using System.ComponentModel.DataAnnotations;

namespace trefle888.Models
{
    public class Users
    {
        public Users(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public int Id { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "Username must be at least 3 characters long.")]
        [MaxLength(10, ErrorMessage = "Username must be at most 20 characters long.")]
        public string username { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).+$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character.")]
        public string password { get; set; }
    }
}