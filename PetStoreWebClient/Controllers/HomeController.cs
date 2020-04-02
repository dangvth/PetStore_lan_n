using PetStoreWebClient.EF;
using PetStoreWebClient.ModelClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetStoreWebClient.Controllers
{
    public class HomeController : Controller
    {
        private const String cartSession = "cartSession";
        private const String userLogin = "userLogin";
        // GET: Home
        public ActionResult Index()
        {
            var productView = new ProductViewHome();
            //get list view to ViewBag
            ViewBag.viewPet = productView.getViewPet(4);
            ViewBag.viewPetFood = productView.getViewPetFood(4);
            ViewBag.viewPetToy = productView.getViewPetToys(4);
            ViewBag.viewPetMedicine = productView.getViewPetMedicines(4);
            ViewBag.viewPetSaleOff = productView.getViewPetSaleOff();

            return View();
        }

        [ChildActionOnly]
        public PartialViewResult HeaderCart()
        {
            //get cart
            var cart = Session[cartSession];
            var list = new List<CartItem>();
            if (cart != null) // check cart is not null
            {
                //get list item cart
                list = (List<CartItem>)cart;
                ViewBag.ListItem = list;
            }
            return PartialView();
        }

        [ChildActionOnly]
        public PartialViewResult HeaderPage()
        {
            //get login session
            var sessLogin = Session[userLogin];
            return PartialView(sessLogin);
        }

        public ActionResult MyAccount()
        {
            var sessLogin = Session[userLogin];
            return View(sessLogin);
        }

        public ActionResult Manual()
        {
            return View();
        }

        public ActionResult RegisterGuide()
        {
            return View();
        }
    }
}