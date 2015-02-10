﻿using MvcApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    public class PharmacienController : Controller
    {
        //
        // GET: /Pharmacien/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AjoutProduit()
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

        public ActionResult DetailMedicament()
        {
            Produits produits = new Produits();
            Produit produit = produits.Detail(1);
            ViewData["Produit"] = produit;
            return View();
        }

        public ActionResult DetailOrdonnance()
        {
            return View();
        }

        public ActionResult ListeCommande()
        {
            Commandes commande = new Commandes();
            ViewData["Commandes"] = commande.ListeCommande(1);
            return View();
        }

        public ActionResult ListeMedicament()
        {
            Produits produits = new Produits();
            ViewData["Produits"] = produits.ObtenirListeProduits();
            return View();
        }

        public ActionResult ListeOrdonnance()
        {
            return View();
        }

        public ActionResult Panier()
        {
            return View();
        }

    }
}
