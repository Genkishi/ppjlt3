using MvcApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    public class FournisseurController : Controller
    {
        //
        // GET: /Fournisseur/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Connexion()
        {
            return View();
        }

        public ActionResult DetailCommande()
        {
            Produits produits = new Produits();
            Commandes commande = new Commandes();
            ViewData["Produits"] = produits.ObtenirListeProduits();
            ViewData["Commande"] = commande.Détail(1);
            return View();
        }

        public ActionResult ListeCommande()
        {
            Commandes commande = new Commandes();
            ViewData["Commandes"] = commande.ListeCommande(1);
            return View();
            return View();
        }
    }
}
