using System;
using System.ComponentModel.DataAnnotations;

namespace formsubmit.Models
{
    public class Form
    {
        [Required]
        [MinLength(4)]
        public string firstname { get; set; }
        [Required]
        [MinLength(4)]
        public string lastname { get; set; }
        [Required]
        [RegularExpression("[0-9]{1,}")]

        public Int32 age { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string password { get; set; }
        public Form(string first, string last, string emailaddress, string pswd, int old){
            age=old;
            firstname=first;
            lastname=last;
            email=emailaddress;
            password=pswd;
        }
    }
}