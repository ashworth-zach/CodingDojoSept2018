using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
namespace TheWall.Models
{
    [Table("like", Schema = "walldb")]

    public class Like
    {
        [Key]
        public int LikeId{get;set;}
        public int MessageId{get;set;}
        public Message message{get;set;}
        public int UserId{get;set;}
        public User user{get;set;}
    }
}