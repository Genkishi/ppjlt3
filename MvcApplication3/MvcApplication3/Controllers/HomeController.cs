using MvcApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Default1/

        //public ActionResult Index(string id)
        //{
        //    if (string.IsNullOrWhiteSpace(id))
        //        return View("Error");
        //    else
        //    {
        //        ViewBag.Nom = id;
        //        return View();
        //    }
        //}

        /// <summary>
        /// test routes
        /// </summary>
    
        
            //public string Index(int id)
            //{
            //    return "HomeController.Index " + id;
            //}


            public string Index(int? id)
            {
                return "HomeController.Index " + id;
            }

        
        public ActionResult ListeClients()
        {
            Clients clients = new Clients();
            ViewData["Clients"] = clients.ObtenirListeClients();
            return View();
        }

        public ActionResult ListeMedicament()
        {
            Produits produits = new Produits();
            ViewData["Produits"] = produits.ObtenirListeProduits();
            return View();
        }
        public ActionResult ChercheClient(string id)
        {
            ViewData["Nom"] = id;
            Clients clients = new Clients();
            Client client = clients.ObtenirListeClients().FirstOrDefault(c => c.Nom == id);
            if (client != null)
            {
                ViewData["Age"] = client.Age;
                return View("Trouve");
            }
            return View("NonTrouve");
        }

        public ActionResult DetailMedicament()
        {
            Produits produits = new Produits();
            Produit produit = produits.Detail(1);
            ViewData["Produit"] = produit;
            return View();
        }
    }
}
