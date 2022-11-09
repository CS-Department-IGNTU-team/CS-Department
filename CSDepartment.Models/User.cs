using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CSDepartment.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
