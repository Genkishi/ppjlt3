using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication3.Models;

namespace MvcApplication3.Controllers
{
    public class ClientController : Controller
    {
        //
        // GET: /Client/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Connexion()
        {
            return View();
        }

        public ActionResult Inscription(string nom)
        {
           
           
            
                ViewData["Nom"] = nom;
                return View();

            
        }
        public ActionResult Panier()
        {
            return View();
        }
        public ActionResult DetailCommande()
        {
            return View();
        }
        public ActionResult Historique()
        {
            return View();
        }
        public ActionResult ListeMedicament()
        {
            Produits produits = new Produits();
            ViewData["Produits"] = produits.ObtenirListeProduits();
            return View();
        }

        public ActionResult Ordonnance()
        {
            return View();
        }
        public ActionResult Question()
        {
            return View();
        }

    }
}
