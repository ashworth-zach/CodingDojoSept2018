using System;
using System.ComponentModel.DataAnnotations;

namespace loginregistration.Models
{
    public class UserLogin : BaseEntity
    {
        [Required]
        [EmailAddress]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$")]
        public string email { get; set; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
