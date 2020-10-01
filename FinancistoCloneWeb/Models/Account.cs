using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinancistoCloneWeb.Models
{
    public class Account
    {
        public int Id { get; set; }        
        public int TypeId { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public string ImagePath { get; set; }
        public int UserId { get; set; }
        public int transactionId { get; set; }

        // relaciones
        public Type Type { get; set; }
        
        public Transaction transaction { get; set; }
    }
}
