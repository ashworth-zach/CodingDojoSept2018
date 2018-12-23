using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
namespace chefdishes.Models
{
    public class Dish
    {
        // auto-implemented properties need to match columns in your table
        [Key]
        public int Dishid { get; set; }

        [Required]
        [MinLength(3)]
        public string name { get; set; }

        [Required]
        [Range(1, 5)]
        public int tastiness { get; set; }
        [Required]
        [Range(1, 5000)]
        public int calories { get; set; }

        public DateTime created_at { get; set; }

        public DateTime updated_at { get; set; }
        public int Chefid { get; set; }
        public Chef Chef { get; set; }
        public Dish()
        {
            created_at = DateTime.Now;
            updated_at = DateTime.Now;
        }
    }
}