using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class Produits
    {


        public List<Produit> ObtenirListeProduits()
        {
            return new List<Produit>
        {
            new Produit { Stock = 33, Nom = "Nicolas"},
            new Produit { Stock= 30, Nom = "Delphine"},
            new Produit { Stock = 33, Nom = "Jérémie"},
            new Produit { Stock = 1, Nom = "Timéo"}
        };
        }
    }
}