using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Modeles
{
    public class CompteEpargne : Compte
    { 
        public decimal Taux { get; set; }
        public override decimal Solde => base.Solde* (1 + Taux);
    }
}
