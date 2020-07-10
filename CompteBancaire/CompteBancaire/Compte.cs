using Microsoft.VisualBasic;
using System;
using System.Net.Security;

namespace CompteBancaire
{
    class Compte
    {

        private int decouvertAutorise;
        private string name;
        private int numero;
        private int solde;
        private int v1;
        private string v2;
        private int v3;
        private int v4;
        private string msg;

       

        public Compte()
        {

        }
        public Compte(int _numero, string _name, int _solde, int _decouvertAutorise)
        {
            numero = _numero;
            name = _name;
            solde = _solde;
            decouvertAutorise = _decouvertAutorise;
        }

     

        public void Crediter(int _montant)
        {
            if (decouvertAutorise < 0 && decouvertAutorise + _montant < 0) {
                msg = "Le retrait ne peut être effectuer";
           
            }
            else{
                solde = solde - _montant; 
                msg = "Vous avez retiré " + _montant + " euros et votre nouveau solde est : " + solde;
                
                //Console.WriteLine(msg);
            }
            //ToString(msg);

        }
        public bool Debiter(int _montant)
        {
            solde = solde + _montant;
            msg = "Vous avez ajouté " + _montant + " euros. Votre solde est à présent de : " + solde + " euros";
           // ToString(msg);
            return true;
        }
        
        public Boolean Superieur(Compte _autreCompte)
        {
            if (_autreCompte.solde < solde) {
                msg = "Le solde du compte passé en paramètre est inférieur";
               
            }
            else if (_autreCompte.solde == solde){
                msg = "Les soldes des deux comptes sont identiques";
            }
            else
            {
                msg = "Le solde du compte passé en paramètre est supérieur";
            }

            return true;
        }

        public override string ToString()
        { 
            return msg;
        }
        
        public Boolean Transferer(int _montant, Compte _compteDestinataire)
        {
            _compteDestinataire.Crediter(_montant);
            solde = solde + _montant;
            msg = "Bonjour M ou Mme " + name + " Suite à votre transfert, le solde de votre compte est à présent de : " + solde;
            return true;
        }
    }
}

