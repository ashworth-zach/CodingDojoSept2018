using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
namespace brightideas.Models
{
    [Table("idea", Schema = "ideasdb")]

    public class Idea
    {
        [Key]
        public int IdeaId{get;set;}
        public int UserId{get;set;}
        public User user{get;set;}
        [Required]
        [MinLength(5)]
        [MaxLength(400)]
        public string content{get;set;}
        public DateTime created_at {get;set;}
        public DateTime updated_at {get;set;}
        public List<Like> likes {get;set;}
        public Idea(){
            created_at=DateTime.Now;
            updated_at=DateTime.Now;
        }
    }
}