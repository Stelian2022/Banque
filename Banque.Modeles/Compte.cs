using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Modeles
{
    public class Compte
    {
     
       public string Proprietaire { get; set; }

        public void Crediter(decimal montant)
        {          
        }

        public void Debiter(decimal montant)
        {
        }

        public void Debiter(decimal montant, Compte compte)
        {
            Debiter(montant);
            compte.Crediter(montant);
        }
    }
}
