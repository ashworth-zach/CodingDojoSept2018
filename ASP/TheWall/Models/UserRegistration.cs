using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
namespace TheWall.Models
{
    public class UserRegistration
    {

        [Required]
        [MinLength(3)]
        [MaxLength(55)]
        public string firstname { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(55)]

        public string lastname { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(90)]

        public string email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [MaxLength(55)]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        public string password { get; set; }
                [NotMapped]
        [Compare("password")]
        [DataType(DataType.Password)]
        [MaxLength(55)]

        public string Confirm { get; set; }
    }
}