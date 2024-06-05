using Banque.Modeles;

namespace Banque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compte compteCourantNicolas = new Compte();
            compteCourantNicolas.Proprietaire = "Nicolas";

            Compte compteEpargneNicolas = new Compte();
            compteEpargneNicolas.Proprietaire = "Nicolas";

            Compte compteCourantJeremy = new Compte();
            compteCourantJeremy.Proprietaire = "Jeremy";

            compteCourantNicolas.Crediter(100m);
            compteCourantNicolas.Debiter(50m);
            compteCourantNicolas.Debiter(20m, compteEpargneNicolas);

            Console.WriteLine($"Compte courant de  {compteCourantNicolas.Proprietaire}");
            Console.WriteLine($"Compte epargne de  {compteEpargneNicolas.Proprietaire}");
            Console.WriteLine($"Compte courant de  {compteCourantJeremy.Proprietaire}");

        }
    }
}
