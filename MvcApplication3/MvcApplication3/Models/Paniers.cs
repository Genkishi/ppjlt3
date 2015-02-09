using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class Paniers
    {



        +CompteurArticle()
+IsVerrouiller()
+ViderPanier()
+Montant(Int Quantite_Produit)
+Montant_Global()
+Supprimer_Article(String Nom_Produit)
+ModifierQuantiterArticle(String Nom_Produit, Int Quantiter_Produit)
+AjouterArticle(String Nom_Produit, Int Quantiter_Produit, Float Prix_Produit)
+CreationPanier()
+ValiderPanier()
+AjoutCommande(Date Date_Commande
Date Date_Echeance, Float Montant_Total, Float Montant_Secu, Float Montant_Mutuelle, Float Remboursement_Total, Bool Paiement, String Question, String Reponse, Int ID_Etat)
+AfficherPanierSite()
+ModifierPanier()
+ProduitIndisponible(String Nom_Produit, Int Quantite_Produit)

+DecrementerProduit()



    }
}