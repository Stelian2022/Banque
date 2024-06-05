using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Modeles
{
    public class CompteCourant : Compte
    {
        public decimal Decouvert { get; set; }
    }
}
