using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class Ordonnance
    {
        public int ID_Ordonnance { get; set; }
        public int Nbr_Renouvellement { get; set; }
        public int compteur { get; set; }
        public string image { get; set; }
        public DateTime Date_Upload { get; set; }
        public int ID_Medecin { get; set; }
        public string Nom_Medecin { get; set; }
        public string Prenom_Medecin { get; set; }
    }
}