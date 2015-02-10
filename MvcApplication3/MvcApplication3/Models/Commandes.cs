using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class Commandes
    {
        
                public List<Commande> ListeTerminer()
        {
            return new List<Commande>
            {
                new Commande { ID_Etat = 33, Nom_Etat = "Nicolas"},
                new Commande { ID_Etat = 30, Nom_Etat = "Delphine"},
                new Commande { ID_Etat = 33, Nom_Etat = "Jérémie"},
                new Commande { ID_Etat = 1, Nom_Etat = "Timéo"}
            };
         }

                public List<Commande> ListeEnCours()
        {
            return new List<Commande>
            {
                new Commande { ID_Etat = 33, Nom_Etat = "Nicolas"},
                new Commande { ID_Etat = 30, Nom_Etat = "Delphine"},
                new Commande { ID_Etat = 33, Nom_Etat = "Jérémie"},
                new Commande { ID_Etat = 1, Nom_Etat = "Timéo"}
            };

         }


             public List<Commande> ListeCommande(int Get_ID_Commande)
        {
            return new List<Commande>
        {
            new Commande { ID_Etat = 33, Nom_Etat = "Nicolas"},
            new Commande { ID_Etat = 30, Nom_Etat = "Delphine"},
            new Commande { ID_Etat = 33, Nom_Etat = "Jérémie"},
            new Commande { ID_Etat = 1, Nom_Etat = "Timéo"}
        };
         }
            public List<Commande> Ajouter()
        {
                return new List<Commande>
            {
                new Commande { ID_Etat = 33, Nom_Etat = "Nicolas"},
                new Commande { ID_Etat = 30, Nom_Etat = "Delphine"},
                new Commande { ID_Etat = 33, Nom_Etat = "Jérémie"},
                new Commande { ID_Etat = 1, Nom_Etat = "Timéo"}
            };
        }


           public List<Commande> Modifier(int ID_Commande, int ID_Etat)
        {
                return new List<Commande>
            {
                new Commande { ID_Etat = 33, Nom_Etat = "Nicolas"},
                new Commande { ID_Etat = 30, Nom_Etat = "Delphine"},
                new Commande { ID_Etat = 33, Nom_Etat = "Jérémie"},
                new Commande { ID_Etat = 1, Nom_Etat = "Timéo"}
            };
        }

          public List<Commande> Détail(int ID_Commande)
        {
            return new List<Commande>
            {
                new Commande { ID_Etat = 33, Nom_Etat = "Nicolas"},
                new Commande { ID_Etat = 30, Nom_Etat = "Delphine"},
                new Commande { ID_Etat = 33, Nom_Etat = "Jérémie"},
                new Commande { ID_Etat = 1, Nom_Etat = "Timéo"}
            };
                                  }
          public List<Commande> EnvoieReponse(int ID_Commande)
        {
                return new List<Commande>
            {
                new Commande { ID_Etat = 33, Nom_Etat = "Nicolas"},
                new Commande { ID_Etat = 30, Nom_Etat = "Delphine"},
                new Commande { ID_Etat = 33, Nom_Etat = "Jérémie"},
                new Commande { ID_Etat = 1, Nom_Etat = "Timéo"}
            };
                             }
          public List<Commande> EnvoieQuestion(int ID_Commande)
        {
            return new List<Commande>
        {
            new Commande { ID_Etat = 33, Nom_Etat = "Nicolas"},
            new Commande { ID_Etat = 30, Nom_Etat = "Delphine"},
            new Commande { ID_Etat = 33, Nom_Etat = "Jérémie"},
            new Commande { ID_Etat = 1, Nom_Etat = "Timéo"}
        };
        }


    }
}