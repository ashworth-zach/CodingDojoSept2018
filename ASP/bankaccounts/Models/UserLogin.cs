
using System;
using System.ComponentModel.DataAnnotations;

namespace bankaccounts.Models
{
    public class UserLogin : BaseEntity
    {
        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
