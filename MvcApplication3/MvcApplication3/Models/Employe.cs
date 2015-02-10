using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication3.Models
{
    public class Employe
    {
        public int ID_Employer;
        public string Nom;
        public string Prenom;
        public string Mail;
        public string Poste;
        public int ID_Pharmacie;
        public string Nom_Pharmacie;

        public string Login;
        public string MDP;
    }
}