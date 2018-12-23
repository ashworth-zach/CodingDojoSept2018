using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace TheWall.Models
{
        public class WallViewModel
        {
        public Message message{get; set;}
        public Comment comment{get; set;}
        }
}