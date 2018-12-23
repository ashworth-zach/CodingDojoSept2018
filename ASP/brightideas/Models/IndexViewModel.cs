using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace brightideas.Models
{
        public class IndexViewModel
        {
        public UserRegistration UserReg{get; set;}
        public UserLogin UserLog{get; set;}
        }
}
