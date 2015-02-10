using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class Fournisseurs
    {
        public String Connexion(String Login, String MDP)
        {
            return "toto";
        }

        public List<Fournisseur> ListeCommandeF()
        {
                return new List<Fournisseur>
            {
                new Fournisseur { ID_Fournisseur = 33, Nom = "Nicolas"},
                new Fournisseur { ID_Fournisseur = 30, Nom = "Delphine"},
                new Fournisseur { ID_Fournisseur = 33, Nom = "Jérémie"},
                new Fournisseur { ID_Fournisseur = 1, Nom = "Timéo"}
            };
        }
        public List<Fournisseur> Valider_commande ( int ID_commande_fournisseur)
        {
                return new List<Fournisseur>
            {
                new Fournisseur { ID_Fournisseur = 33, Nom = "Nicolas"},
                new Fournisseur { ID_Fournisseur = 30, Nom = "Delphine"},
                new Fournisseur { ID_Fournisseur = 33, Nom = "Jérémie"},
                new Fournisseur { ID_Fournisseur = 1, Nom = "Timéo"}
            };
        }

            
    }
}