using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
namespace TheWall.Models
{
    [Table("message", Schema = "walldb")]

    public class Message
    {
        [Key]
        public int MessageId{get;set;}
        public int UserId{get;set;}
        [Required]
        [MinLength(5)]
        [MaxLength(200)]
        public string content{get;set;}
        public DateTime created_at {get;set;}
        public DateTime updated_at {get;set;}
        public List<Comment> comments {get;set;}
        public List<Like> likes {get;set;}
        public Message(){
            created_at=DateTime.Now;
            updated_at=DateTime.Now;
        }
    }
}