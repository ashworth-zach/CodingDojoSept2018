using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
namespace TheWall.Models
{
    [Table("comment", Schema = "walldb")]

    public class Comment
    {
        [Key]
        public int CommentId{get;set;}
        public int MessageId{get;set;}
        public int UserId{get;set;}
        public User user {get;set;}
        [Required]
        [MinLength(5)]
        [MaxLength(200)]
        public string content{get;set;}
        public DateTime created_at {get;set;}
        public DateTime updated_at {get;set;}
        public Comment(){
            created_at=DateTime.Now;
            updated_at=DateTime.Now;
        }
    }
}