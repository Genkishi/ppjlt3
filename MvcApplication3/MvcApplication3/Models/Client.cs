using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Timers;
using System.Threading;


namespace MvcApplication3.Models
{
    public class Client
    {
        public string Nom { get; set; }
        public int Age { get; set; }
        public String Civilite { get; set; }
        public String Prenom { get; set; }
        public String Adresse { get; set; }
        public int CodePostal{ get; set; }
        public DateTime DateNaissance { get; set; }
        public String Mail { get; set; }
        public int Telephone { get; set; }
        public int NumSecu { get; set; }
        public int NumMutuelle { get; set; }
        public float Cotisation { get; set; }
        public String Statue { get; set; }
        public String TauxRemboursement { get; set; }
        public String Login { get; set; }
        public String MDP { get; set; }
         public List<String> Allergie { get; set; }

        





    }
}