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
        // GET: Home
        public ActionResult Index()
        {
            var productView = new ProductViewHome();
            ViewBag.viewPet = productView.getViewPet(4);
            ViewBag.viewPetFood = productView.getViewPetFood(4);
            ViewBag.viewPetToy = productView.getViewPetToys(4);
            ViewBag.viewPetSaleOff = productView.getViewPetSaleOff();
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult HeaderCart()
        {
            var cart = Session[cartSession];
            var list = new List<CartItem>();

            var listCartPetFood = new List<CartPetFoodItem>();
            var listCartPet = new List<CartPetItem>();
            var listCartPetToy = new List<CartPetToyItem>();
            var listCartPetMedicine = new List<CartPetMedicineItem>();

            if (cart != null)
            {
                list = (List<CartItem>)cart;
                PetFoodModel pfm = new PetFoodModel();
                foreach (var item in list)
                {
                    //product is pet's food
                    if (item.productID.StartsWith("PFD"))
                    {
                        PetFood pf = pfm.getPetFoodByID(item.productID);
                        CartPetFoodItem cpfi = new CartPetFoodItem();
                        cpfi.Petfood = pf;
                        cpfi.Quantity = item.Quantity;
                        listCartPetFood.Add(cpfi);
                    }
                    //product is pet
                    if (item.productID.StartsWith("PET"))
                    {
                        Pet p = pfm.getPetByID(item.productID);
                        CartPetItem cpi = new CartPetItem();
                        cpi.pet = p;
                        cpi.Quantity = item.Quantity;
                        listCartPet.Add(cpi);
                    }
                    //product os pet's medicine
                    if (item.productID.StartsWith("PMD"))
                    {
                        PetMedicine pm = pfm.getPetMedicineByID(item.productID);
                        CartPetMedicineItem cpmi = new CartPetMedicineItem();
                        cpmi.petMedicine = pm;
                        cpmi.Quantity = item.Quantity;
                        listCartPetMedicine.Add(cpmi);
                    }
                    //Product is Pet's toys
                    if (item.productID.StartsWith("PTS"))
                    {
                        PetToys pt = pfm.getPetToyByID(item.productID);
                        CartPetToyItem cpti = new CartPetToyItem();
                        cpti.petToy = pt;
                        cpti.Quantity = item.Quantity;
                        listCartPetToy.Add(cpti);
                    }
                }
                ViewBag.listCartP = listCartPet;
                ViewBag.listCartPT = listCartPetToy;
                ViewBag.listCartPM = listCartPetMedicine;
                ViewBag.ListItem = list;
            }
            return PartialView(listCartPetFood);
        }
    }
}