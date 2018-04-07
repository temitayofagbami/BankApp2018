﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Account
    { 
        public int AccountNumber { get; set; }
        public string AccountName  { get; set; }
        public string AccountType { get; set; }
        public decimal Balance  { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
