using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
namespace bankaccounts.Models
{
    public class Transaction{
        public int TransactionId{get;set;}
        public float amount {get;set;}
        public DateTime created_at{get;set;}
        public DateTime updated_at{get;set;}
        public int UserId{get;set;}
        public User User{get;set;}
        public Transaction(){
            created_at=DateTime.Now;
            updated_at=DateTime.Now;
        }
    }
}