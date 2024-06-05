using Banque.Modeles;

namespace Banque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compte compteCourantNicolas = new Compte() { Proprietaire= "Nicolas" };
            //compteCourantNicolas.Proprietaire = "Nicolas";

            Compte compteEpargneNicolas = new Compte() { Proprietaire = "Nicolas"};
           // compteEpargneNicolas.Proprietaire = "Nicolas";

            Compte compteCourantJeremy = new Compte() { Proprietaire = "Jeremy"};
            //compteCourantJeremy.Proprietaire = "Jeremy";

            compteCourantNicolas.Crediter(100m);
            compteCourantNicolas.Debiter(50m);
            compteCourantNicolas.Debiter(20m, compteEpargneNicolas);
            compteEpargneNicolas.Crediter(100m);
            compteCourantNicolas.Crediter(20m, compteEpargneNicolas);
            compteCourantJeremy.Debiter(500m);
            compteCourantJeremy.Debiter(200m, compteCourantNicolas);


            Console.WriteLine($"Compte courant de {compteCourantNicolas.Proprietaire}");
          
          

            Console.WriteLine($"Compte epargne de {compteEpargneNicolas.Proprietaire}");
            Console.WriteLine($"Compte courant de {compteCourantJeremy.Proprietaire}");

        }
    }
}
