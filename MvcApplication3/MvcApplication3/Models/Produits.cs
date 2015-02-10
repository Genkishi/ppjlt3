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
            new Produit { Stock = 33, Nom = "Nicolas", Prix = 20},
            new Produit { Stock= 30, Nom = "Delphine", Prix = 20},
            new Produit { Stock = 33, Nom = "Jérémie", Prix = 20},
            new Produit { Stock = 1, Nom = "Timéo", Prix = 20}
        };
        }

        public Produit Detail(int ID_Produit)
        {
            return new Produit { Stock = 33, Nom = "Nicolas", Prix = 20 };
                            
        }
    }
}