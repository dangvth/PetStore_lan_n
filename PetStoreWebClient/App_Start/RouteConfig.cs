using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PetStoreWebClient
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Pet list",
                url: "pet/list",
                defaults: new { controller = "Pet", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Pet's food list",
                url: "petfood/list",
                defaults: new { controller = "PetFood", action = "Index", id = UrlParameter.Optional }
            );
            
            routes.MapRoute(
                name: "Pet Search",
                url: "pet/search",
                defaults: new { controller = "Pet", action = "Search", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Petfood Search",
                url: "Petfood/search",
                defaults: new { controller = "PetFood", action = "Search", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Pet's food Detail",
                url: "detail/petfood/{pfID}",
                defaults: new { controller = "PetFood", action = "Detail", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Pet's Detail",
                url: "detail/pet/{pID}",
                defaults: new { controller = "Pet", action = "Detail", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Add Cart",
                url: "add-to-cart",
                defaults: new { controller = "Cart", action = "AddItem", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Cart",
                url: "cart",
                defaults: new { controller = "Cart", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Empty Cart",
                url: "cart/empty-cart",
                defaults: new { controller = "Cart", action = "EmptyCart", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Delete Item",
                url: "cart/delete-item",
                defaults: new { controller = "Cart", action = "DeleteItem", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Payment",
                url: "payment",
                defaults: new { controller = "Cart", action = "Payment", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Payment Process",
                url: "payment-process",
                defaults: new { controller = "Cart", action = "PaymentProcess", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Payment success",
                url: "complete",
                defaults: new { controller = "Cart", action = "Success", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Login page",
                url: "login",
                defaults: new { controller = "Accounts", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "My Account",
                url: "my-account",
                defaults: new { controller = "Home", action = "MyAccount", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Home",
                url: "home",
                defaults: new { controller = "Home", action = "Indext", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Logout process",
                url: "logout-process",
                defaults: new { controller = "Accounts", action = "LogoutProcess", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Payment failure",
                url: "failure",
                defaults: new { controller = "Cart", action = "Failure", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
