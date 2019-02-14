using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace atmproject.Models
{
    public class BankAccount
    {
        public int ID { get; set; }
        public int accountNumber { get; set; }
        public string Name { get; set; }
        public int Pin { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal Balance { get; set; }



    }
}