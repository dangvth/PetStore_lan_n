using PetStoreWebClient.ModelClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetStoreWebClient.Controllers
{
    public class PetFoodController : Controller
    {
        // GET: PetFood
        public ActionResult Index(int page = 1, int pageSize = 1)
        {
            var productView = new ProductViewHome();
            int totalRecord = 0;
            ViewBag.viewPetFoodSaleOff = productView.getViewPetFoodSaleOff();
            var allPetfood = new PetFoodModel().getAllPetFood(ref totalRecord, page, pageSize);

            ViewBag.Total = totalRecord;
            ViewBag.Page = page;

            int maxPage = 5;//maximum page link display on website
            int totalPage = 0;
            totalPage = (int)Math.Ceiling((double) totalRecord / pageSize);

            ViewBag.totalPage = totalPage;
            ViewBag.maxPage = maxPage;
            ViewBag.first = 1;
            ViewBag.last = totalPage;
            ViewBag.next = page + 1;
            ViewBag.prev = page - 1;

            return View(allPetfood);
        }

        public ActionResult Detail(String pfID)
        {

            var petfoodDetail = new PetFoodModel().getPetFoodByID(pfID);
            ViewBag.relatedPetFood = new PetFoodModel().getPetFoodRelated(petfoodDetail.pf_id);
            return View(petfoodDetail);
        }
    }
}