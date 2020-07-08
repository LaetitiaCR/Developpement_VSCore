using Microsoft.VisualBasic;
using System;
using System.Net.Security;

namespace CompteBancaire
{
    class Compte
    {

        private int decouvertAutorise;
        private string nom;
        private int numero;
        private int solde;
        private int v1;
        private string v2;
        private int v3;
        private int v4;
        private String msg;

       

        public Compte()
        {

        }
        public Compte(int _numero, string _nom, int _solde, int _decouvertAutorise)
        {
            numero = _numero;
            nom = _nom;
            solde = _solde;
            decouvertAutorise = _decouvertAutorise;
        }

        public void Crediter(int _montant)
        {
            if (decouvertAutorise < 0 && decouvertAutorise + _montant < 0) {
                msg = "Le retrait ne peut être effectuer";
                //ToString(msg); 
            }
            else{
                msg = "Vous avez retiré " + _montant + " euros et votre nouveau solde est : " + solde;
                //Console.WriteLine(msg);
            }
        }
        public bool Debiter(int _montant)
        {
           solde = solde + _montant;
           return true;
        }
        //public Boolean Superieur(Compte _autreCompte)
        //{

        //}
        public string ToString()
        {
            return msg;
        }
        //public Boolean transferer(int _montant, Compte _compteDestinataire)
        //{

        //}
    }
}

