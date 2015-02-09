using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class Commande
    {

        public int Id_Commande;
        public DateTime Date_Commande;
        public DateTime Date_Echeance;
        public float Montant_Total;
        public float Montant_Secu;
        public float Montant_Mutuelle;
        public float Remboursement_Total;
        public bool Paiement;
        public string Question;
        public string Reponse;
        public int ID_Etat;
        public string Nom_Etat;
    }
}