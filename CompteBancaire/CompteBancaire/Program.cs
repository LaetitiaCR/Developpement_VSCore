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
            
            //deduire 100
            c1.Crediter(100);
            Console.WriteLine(c1.ToString());
            //ajouter 200
            if (c1.Debiter(200) == true)
            {
                Console.WriteLine(c1.ToString());
            };



            c1.Transferer(3300, c2);
            Console.WriteLine(c1.ToString());
        }
    }

}