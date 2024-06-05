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
       private List<Operation> Operations { get; } = new List<Operation>();
        public decimal Solde => CalculerSolde();

        private decimal CalculerSolde()
        {
            decimal solde = 0;
           
            foreach (var item in Operations)
            {
                if (item.Sens == Sens.Credit)
                {
                    solde += item.Montant;
                }
                else
                {
                    solde -= item.Montant;

                }
            }
            return solde;
        }

        public void Crediter(decimal montant)
        {
            Operation operation = new Operation(){ Montant = montant,  Sens = Sens.Credit  };
            Operations.Add(operation);
    }

        public void Debiter(decimal montant)
        {
            Operation operation = new Operation() { Montant = montant, Sens = Sens.Debit };
            Operations.Add(operation);

        }

        public void Debiter(decimal montant, Compte compte)
        {
            Debiter(montant);
            compte.Crediter(montant);
        }

        public void Crediter(decimal montant, Compte compte)
        {
            Crediter(montant);
            compte.Debiter(montant);
        }
    }
}
