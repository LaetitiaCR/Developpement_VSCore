using System;

namespace CompteBancaire
{

    
    class Program
    {
       static void Main(string[] args){
            //Console.WriteLine("Hello World!");
            //Compte c = new Compte();
            // numero de compte, intitulé, solde, découvert autorisé
            //Compte c1 = new Compte(12345, "toto", 1000, -500);
            Compte c1 = new Compte(12345, "toto", 3000, -500);
            Compte c2 = new Compte(45678, "titi", 1200, 1500);

            
            //ajouter 100
            //int montant = 100;
            c1.Crediter(100);
            Console.WriteLine(c1.ToString());
            //string msg = "Vous avez ajouté " + montant + " euros. Votre solde est à présent de : " + solde + " euros";

            //deduire 200
            if (c1.Debiter(200) == true)
            {
                Console.WriteLine(c1.ToString());
            }
            else
            {
                Console.WriteLine("Le retrait n'a pas été effectué");
            }

            if (c1.Superieur(c2) == true)
            {
                Console.WriteLine("Le solde du compte c1 est supérieur au solde du compte c2");
            }
            else {
                Console.WriteLine("Le solde du compte c1 est inférieur ou égale au solde du compte c2");
            }
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());

            c1.Transferer(3300, c2);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
        }
    }

}