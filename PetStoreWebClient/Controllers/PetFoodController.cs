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
        public ActionResult Index(int page = 1, int pageSize = 4)
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
            // first page
            ViewBag.first = 1;
            //last page
            ViewBag.last = totalPage;
            //next page
            ViewBag.next = page + 1;
            //prev page
            ViewBag.prev = page - 1;

            return View(allPetfood);
        }

        public ActionResult Search(string keyword, int page = 1, int pageSize = 2)
        {
            var productView = new ProductViewHome();
            int totalRecord = 0;
            ViewBag.viewPetFoodSaleOff = productView.getViewPetFoodSaleOff();
            var allPetfood = new PetFoodModel().Search(keyword, ref totalRecord, page, pageSize);

            ViewBag.keyword = keyword;
            ViewBag.Total = totalRecord;
            ViewBag.Page = page;

            int maxPage = 5;//maximum page link display on website
            int totalPage = 0;
            totalPage = (int)Math.Ceiling((double)totalRecord / pageSize);

            ViewBag.totalPage = totalPage;
            ViewBag.maxPage = maxPage;
            // first page
            ViewBag.first = 1;
            //last page
            ViewBag.last = totalPage;
            //next page
            ViewBag.next = page + 1;
            //prev page
            ViewBag.prev = page - 1;

            return View(allPetfood);
        }

        public ActionResult Detail(String pfID, int page = 1, int pageSize = 2)
        {
            var petFood = new PetFoodModel();

            var petfoodDetail = petFood.getPetFoodByID(pfID);
            ViewBag.relatedPetFood = petFood.getPetFoodRelated(petfoodDetail.pf_id);
            ViewBag.petfoodDetail = petfoodDetail;
            return View();
        }

        public JsonResult ListName(string term)
        {
            if (term != "")
            {
                var data = new PetFoodModel().ListName(term);
                return Json(new
                {
                    data = data,
                    status = true
                }, JsonRequestBehavior.AllowGet);
            } else
            {
                return Json(new
                {
                    data = "",
                    status = true
                }, JsonRequestBehavior.AllowGet);
            }
            
        }
    }
}