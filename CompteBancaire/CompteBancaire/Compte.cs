using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Security;

namespace CompteBancaire
{
    class Compte
    {

        private int decouvertAutorise;
        private string name;
        private int numero;
        private int solde;
        //private string msg;

       

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

     
        //ajouter de l'argent sur son compte
        public void Crediter(int _montant)
        {
            solde = solde + _montant;
              

        }

        //enlever de l'argent sur son compte
        public bool Debiter(int _montant)
        {
            if (decouvertAutorise < 0 && decouvertAutorise + _montant < 0)
            {
                //msg = "Le retrait ne peut être effectuer";
                return false;
            }
            else
            {
                solde = solde - _montant;
                return true;
                //msg = "Vous avez retiré " + _montant + " euros et votre nouveau solde est : " + solde;

               
            }
           
        }

        public Boolean Superieur(Compte _autreCompte)
        {
            if (_autreCompte.solde < solde) {
                // msg = "Le solde du compte passé en paramètre est inférieur";
                return false;
               
            }
            else if (_autreCompte.solde == solde){
                //msg = "Les soldes des deux comptes sont identiques";
                return false;
            }
            else
            {
                //msg = "Le solde du compte passé en paramètre est supérieur";
                return true;
            }

         
        }

        public override string ToString()
        { 
            return "Le numero de compte est " + numero + " de M. ou Mme " + name + " avec un solde de : " + solde;
        }
        
        public Boolean Transferer(int _montant, Compte _compteDestinataire)
        {
            _compteDestinataire.Crediter(_montant);
            solde = solde + _montant;
           // msg = "Bonjour M ou Mme " + name + " Suite à votre transfert, le solde de votre compte est à présent de : " + solde;
            return true;
        }
    }
}

