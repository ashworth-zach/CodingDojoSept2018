using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
namespace brightideas.Models
{
    [Table("like", Schema = "ideasdb")]

    public class Like
    {
        [Key]
        public int LikeId{get;set;}
        public int IdeaId{get;set;}
        public Idea idea{get;set;}
        public int UserId{get;set;}
        public User user{get;set;}
    }
}