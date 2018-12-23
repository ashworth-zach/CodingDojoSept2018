using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
namespace bankaccounts.Models
{
    public abstract class BaseEntity { }
    public class User : BaseEntity
    {
        // auto-implemented properties need to match columns in your table
        [Key]
        public int UserId { get; set; }

        [Required]
        [MinLength(3)]
        public string firstname { get; set; }

        [Required]
        [MinLength(3)]
        public string lastname { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        public string password { get; set; }

        public DateTime created_at { get; set; }

        public DateTime updated_at { get; set; }

        [NotMapped]
        [Compare("password")]
        [DataType(DataType.Password)]
        public string Confirm { get; set; }
        public float Cash { get; set; }

        public List<Transaction> Transactions { get; set; }

        public User()
        {
            Transactions = new List<Transaction>();
            created_at = DateTime.Now;
            updated_at = DateTime.Now;
        }
        public class ReturningUser
        {
            [Required]
            [EmailAddress]
            public string email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string password { get; set; }
        }
        // public void Withdraw(float change)
        // {
        //     if (this.CheckBalance(this.Cash,change) == true){
        //         this.Cash-=change;
        //         return;
        //     }
        //     return;
        // }
        // public void Deposit(float change)
        // {
        //     this.Cash+=change;
        //     return;
        // }
        // public bool CheckBalance(float amount, float change)
        // {
        //     if ((amount - change) < 0)
        //     {
        //         return false;
        //     }
        //     else { return true; }
        // }
    }
}