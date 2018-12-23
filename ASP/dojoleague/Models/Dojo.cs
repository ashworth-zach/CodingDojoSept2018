using System.ComponentModel.DataAnnotations;
namespace dojoleague.Models
{
    public class Dojo
    {
        [Required]
        [MinLength(2)]
        public string firstname { get; set; }
        
        [MinLength(4)]
        [MaxLength(20)]

        public string lastname { get; set; }
        [Required]

        public string location { get; set; }
        [Required]

        public string language { get; set; }
        public Dojo(string name, string lang, string place, string msg)
        {
            firstname = name;
            language = lang;
            location = place;
            message = msg;
        }
    }
}