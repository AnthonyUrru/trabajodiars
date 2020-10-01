using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancistoCloneWeb.Models
{
    public class Transaction
    {
        
        public int Id { get; set; }
        public int CuentaId { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }
        public decimal Monto { get; set; }
        public Account Account { get; set; }
        //public List<Account> Accounts { get; set; }        
    }
}
