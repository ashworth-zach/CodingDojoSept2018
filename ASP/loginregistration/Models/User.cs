using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System;
namespace loginregistration.Models
{
    public class User
    {
        // auto-implemented properties need to match columns in your table
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string firstname { get; set; }

        [Required]
        [MinLength(3)]
        public string lastname { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        public string password { get; set; }

        public DateTime created_at { get; set; }

        public DateTime updated_at { get; set; }

        [NotMapped]
        [Compare("password")]
        [DataType(DataType.Password)]
        public string Confirm { get; set; }

        public User()
        {
            created_at = DateTime.Now;
            updated_at = DateTime.Now;
        }

    }
}