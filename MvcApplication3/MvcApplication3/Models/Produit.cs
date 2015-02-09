using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class Produit
    {
        public int ID_Produit { get; set; }
        public String Nom { get; set; }
        public String Nom_Farbcant { get; set; }
        public bool Remboursement { get; set; }
        public String Description { get; set; }
        public String Notice { get; set; }
        public String Image { get; set; }
        public float Prix { get; set; }
        public int Seuil { get; set; }
        public int Quantité_retirer { get; set; }
        public int Stock { get; set; }
        public int Num_lot { get; set; }
        public String Classe_Pharma { get; set; }
        public int ID_Categorie { get; set; }
        public String Categorie { get; set; }
    }
}