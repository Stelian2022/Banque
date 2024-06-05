using Banque.Modeles;

namespace Banque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compte compteCourantNicolas = new CompteCourant() { Proprietaire= "Nicolas", Decouvert=2000 };
            //compteCourantNicolas.Proprietaire = "Nicolas";

            Compte compteEpargneNicolas = new CompteEpargne() { Proprietaire = "Nicolas", Taux = 0.02m };
           // compteEpargneNicolas.Proprietaire = "Nicolas";

            Compte compteCourantJeremy = new CompteCourant() { Proprietaire = "Jeremy" , Decouvert = 500};
            //compteCourantJeremy.Proprietaire = "Jeremy";

            compteCourantNicolas.Crediter(100m);
            compteCourantNicolas.Debiter(50m);
            compteCourantNicolas.Debiter(20m, compteEpargneNicolas);
            compteEpargneNicolas.Crediter(100m);
            compteCourantNicolas.Crediter(20m, compteEpargneNicolas);
            compteCourantJeremy.Debiter(500m);
            compteCourantJeremy.Debiter(200m, compteCourantNicolas);


            Console.WriteLine($"Compte courant de {compteCourantNicolas.Proprietaire} Solde = {compteCourantNicolas.Solde}");
            Console.WriteLine($"Compte epargne de {compteEpargneNicolas.Proprietaire} Solde = {compteEpargneNicolas.Solde}");
            Console.WriteLine($"Compte courant de {compteCourantJeremy.Proprietaire} Solde = {compteCourantJeremy.Solde}");

            Console.WriteLine("\n");

        }
    }
}
