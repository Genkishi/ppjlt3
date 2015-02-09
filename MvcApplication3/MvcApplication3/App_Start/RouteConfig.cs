using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcApplication3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            ///Creation d'une route calculer
    //        routes.MapRoute(
    //name: "Default",
    //url: "{action}/{valeur1}/{valeur2}",
    //defaults: new { controller = "Calculateur", action = "Ajouter", valeur1 = 0, valeur2 = 0 });

            // Creation d'une route pour calculer avec personalisation de l'url
    //        routes.MapRoute(
    //name: "Default",
    //url: "Calculatrice-{action}/{valeur1}-{valeur2}",
    //defaults: new { controller = "Calculateur", action = "Ajouter", valeur1 = 0, valeur2 = 0 });

            ///Creation de la route MAP  <<< Faire la route la plus spécialisé a la route la plus général
            routes.MapRoute(
                name: "Ajouter",
                url: "Ajouter/{valeur1}/{valeur2}",
                defaults: new { controller = "Calculateur", action = "Ajouter" });
           
            // ROUTE METEO EXEMPLE
            routes.MapRoute(
                name: "Meteo",
                url: "{jour}/{mois}/{annee}",
                defaults: new { controller = "Meteo", action = "Afficher" });

            //ROUTE DEFAULT
            routes.MapRoute(
                name: "default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "home", action = "index", id = UrlParameter.Optional }
            );
        }
    }
}