using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
namespace TheWall.Models
{
    [Table("user", Schema = "walldb")]
    public class User
    {
        // auto-implemented properties need to match columns in your table
        [Key]
        public int UserId { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        [NotMapped]
        public List<Like> likes { get; set; }
        public List<Message> messages { get; set; }
        public User()
        {
            created_at = DateTime.Now;
            updated_at = DateTime.Now;
            likes = new List<Like>();
        }
    }
}