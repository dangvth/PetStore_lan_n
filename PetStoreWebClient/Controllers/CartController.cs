using PetStoreWebClient.EF;
using PetStoreWebClient.ModelClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace PetStoreWebClient.Controllers
{
    public class CartController : Controller
    {
        private const String cartSession = "cartSession";

        // GET: Cart
        public ActionResult Index()
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
                    else if (item.productID.StartsWith("PET"))
                    {
                        Pet p = pfm.getPetByID(item.productID);
                        CartPetItem cpi = new CartPetItem();
                        cpi.pet = p;
                        cpi.Quantity = item.Quantity;
                        listCartPet.Add(cpi);
                    }
                    //product os pet's medicine
                    else if (item.productID.StartsWith("PMD"))
                    {
                        PetMedicine pm = pfm.getPetMedicineByID(item.productID);
                        CartPetMedicineItem cpmi = new CartPetMedicineItem();
                        cpmi.petMedicine = pm;
                        cpmi.Quantity = item.Quantity;
                        listCartPetMedicine.Add(cpmi);
                    }
                    //Product is Pet's toys
                    else
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
            }
            return View(listCartPetFood);
        }

        public JsonResult DeleteAll()
        {
            Session[cartSession] = null;
            return Json(new
            {
                status = true
            });
        }

        /// <summary>
        /// delete all item in cart
        /// </summary>
        /// <returns></returns>
        public ActionResult EmptyCart()
        {
            Session[cartSession] = null;
            return RedirectToAction("Index");
        }

        /// <summary>
        /// delete item single
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult DeleteItem(String id)
        {
            var sessionCart = (List<CartItem>)Session[cartSession];
            sessionCart.RemoveAll(x => x.productID == id);
            if (sessionCart.Count <= 0)
            {
                sessionCart = null;
            }
            Session[cartSession] = sessionCart;
            return RedirectToAction("Index");
        }

        /// <summary>
        /// update quantity of item edit in cart
        /// </summary>
        /// <param name="cartModel"></param>
        /// <returns></returns>
        public JsonResult Update(String cartModel)
        {
            var Jsoncart = new JavaScriptSerializer().Deserialize<List<CartPetFoodItem>>(cartModel);
            var sessionCart = (List<CartItem>)Session[cartSession];
            foreach (var item in sessionCart)
            {
                var JsonItem = Jsoncart.SingleOrDefault(x => x.Petfood.pf_id == item.productID);
                if (JsonItem != null)
                {
                    item.Quantity = JsonItem.Quantity;
                }
            }
            return Json(new {
                status = true
            });
        }

        /// <summary>
        /// add item to cart
        /// </summary>
        /// <param name="productID"></param>
        /// <param name="Quantity"></param>
        /// <returns></returns>
        public ActionResult AddItem(String productID, int Quantity)
        {
            var cart = Session[cartSession];
            if (cart != null)
            {
                var list = (List<CartItem>)cart;
                if (list.Exists(x => x.productID == productID))
                {
                    foreach (var item in list)
                    {
                        if (item.productID == productID)
                        {
                            item.Quantity += Quantity;
                        }
                    }
                }else
                {
                    //create Cart item object
                    var item = new CartItem();
                    item.productID = productID;
                    item.Quantity = Quantity;
                    list.Add(item);
                }

                //get to session
                Session[cartSession] = list;
            }
            else
            {
                //create Cart item object
                var item = new CartItem();
                item.productID = productID;
                item.Quantity = Quantity;
                var list = new List<CartItem>();
                list.Add(item);

                //get to session
                Session[cartSession] = list;
            }
            return RedirectToAction("Index");
        }

        public ActionResult Payment()
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
                    else if (item.productID.StartsWith("PET"))
                    {
                        Pet p = pfm.getPetByID(item.productID);
                        CartPetItem cpi = new CartPetItem();
                        cpi.pet = p;
                        cpi.Quantity = item.Quantity;
                        listCartPet.Add(cpi);
                    }
                    //product os pet's medicine
                    else if (item.productID.StartsWith("PMD"))
                    {
                        PetMedicine pm = pfm.getPetMedicineByID(item.productID);
                        CartPetMedicineItem cpmi = new CartPetMedicineItem();
                        cpmi.petMedicine = pm;
                        cpmi.Quantity = item.Quantity;
                        listCartPetMedicine.Add(cpmi);
                    }
                    //Product is Pet's toys
                    else
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
            }
            return View(listCartPetFood);
        }

        public ActionResult PaymentProcess(int totalPay)
        {
            Bill b = new Bill();
            b.b_purchaseDate = DateTime.Now;
            b.b_status = "Processing";
            b.b_total = totalPay;

            try
            {
                var billID = new BillModel().InsertBill(b);
                var cart = (List<CartItem>)Session[cartSession];
                foreach (var item in cart)
                {
                    var billDetail = new BillDetail();
                    billDetail.b_id = billID;
                    var bdm = new BillDetailModel();
                    if (item.productID.StartsWith("PFD"))
                    {
                        billDetail.pf_id = item.productID;
                        bdm.InsertBillDetail(billDetail);
                    }
                    if (item.productID.StartsWith("PET"))
                    {
                        billDetail.p_id = item.productID;
                        bdm.InsertBillDetail(billDetail);
                    }
                    if (item.productID.StartsWith("PMD"))
                    {
                        billDetail.pm_id = item.productID;
                        bdm.InsertBillDetail(billDetail);
                    }
                    if (item.productID.StartsWith("PTS"))
                    {
                        billDetail.pt_id = item.productID;
                        bdm.InsertBillDetail(billDetail);
                    }
                }
                Session[cartSession] = null;
            }
            catch
            {
                return Redirect("/failure");
            }
            return Redirect("/complete");
        }

        public ActionResult Success()
        {
            return View();
        }

        public ActionResult Failure()
        {
            return View();
        }
    }
}