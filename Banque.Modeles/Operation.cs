using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Modeles

{
    public enum Sens
    {
        Credit,
        Debit
    }
    public class Operation
    {
        public decimal Montant { get; set; }
        public Sens Sens { get; set; }

        
    }
}
