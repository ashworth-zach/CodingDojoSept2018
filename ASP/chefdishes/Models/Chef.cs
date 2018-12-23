using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
namespace chefdishes.Models
{
    public class CurrentDateAttribute : ValidationAttribute
    {
        public CurrentDateAttribute()
        {
        }

        public override bool IsValid(object value)
        {
            var dt = (DateTime)value;
            if(dt <= DateTime.Now)
            {
                return true;
            }
            return false;
        }
    }
    public class Chef
    {
        // auto-implemented properties need to match columns in your table
        [Key]
        public int Chefid { get; set; }
        [Required]
        [MinLength(3)]
        public string firstname { get; set; }

        [Required]
        [MinLength(3)]
        public string lastname { get; set; }
        [CurrentDate]
        public DateTime dob { get; set; }


        public DateTime created_at { get; set; }

        public DateTime updated_at { get; set; }
        public List<Dish> Dish { get; set; }
        [NotMapped]
        public int total{get;set;}
        public static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }
        public Chef()
        {
            created_at = DateTime.Now;
            updated_at = DateTime.Now;
        }
    }
}