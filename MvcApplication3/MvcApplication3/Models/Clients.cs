using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication3.Models;
namespace MvcApplication3.Models
{
    public class Clients
    { string connexion ;
        String CodePostal;
       String DateNaissance;
        String ID_Client;
        public List<Client> ObtenirListeClients()
        {
            return new List<Client>
        {
            new Client { Age = 33, Nom = "Nicolas"},
            new Client { Age = 30, Nom = "Delphine"},
            new Client { Age = 33, Nom = "Jérémie"},
            new Client { Age = 1, Nom = "Timéo"}
        };



    
        }        
        public  String Connexion (String Login, String MDP)
        {
        return "toto";
        }
        public  String Inscription(String Civilite, String Nom , String Prenom, String Adresse, String CodePostal, String DateNaissance, 
            String Mail, String Telephone, String NumSecu, String NumMutuelle, String Statue,String Login, String MDP, List<String> Allergie)
        {
        return "toto";
        }
       public  String ModifProfil (String ID_Client ,String Civilite, String Nom , String Prenom, String Adresse, int CodePostal, DateTime   DateNaissance,
           String Mail, int Telephone, String NumSecu, String NumMutuelle, String Statue,String Login, String MDP, List<String> Allergie)
        {
        return "toto";
        }
        public  int Suppression (int ID_Client)
        {
        return 1;
        }
        




    }
}