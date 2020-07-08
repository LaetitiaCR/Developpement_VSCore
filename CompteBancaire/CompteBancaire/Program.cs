using System;

namespace CompteBancaire
{
    class Program
    {
       static void Main(string[] args){
            Console.WriteLine("Hello World!");
            //Compte c = new Compte();
            //Compte c1 = new Compte(12345, "toto", 1000, -500);
            Compte c1 = new Compte(12345, "toto", 3000, -500);
            //Console.WriteLine(c.ToString());
            c1.Crediter(100);
            Console.WriteLine(c1.ToString());
        }
    }

}