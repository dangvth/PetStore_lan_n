using PetStoreWebClient.ModelClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace PetStoreWebClient.Controllers

{
    public class PetToyController : Controller
    {
        // GET: PetToy
        public ActionResult Index(int page = 1, int pageSize = 12)
        {
            var productView = new ProductViewHome();
            int totalRecord = 0;
            // get list sale off pet toy
            ViewBag.viewPetToySaleOff = productView.getViewPeTToySaleOff();
            var allPettoy = new PetToyModel().getAllPetToys(ref totalRecord, page, pageSize);

            ViewBag.Total = totalRecord;
            ViewBag.Page = page;

            int maxPage = 5;//maximum page link display on website
            int totalPage = 0;
            //caculator total page 
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

            return View(allPettoy);
        }

        //search and paging
        public ActionResult Search(string keyword, int page = 1, int pageSize = 2)
        {
            var productView = new ProductViewHome();
            int totalRecord = 0;
            //get list pet toy sale off
            ViewBag.viewPetToySaleOff = productView.getViewPeTToySaleOff();
            //get list search
            var allPettoy = new PetToyModel().Search(keyword, ref totalRecord, page, pageSize);

            ViewBag.keyword = keyword;
            ViewBag.Total = totalRecord;
            ViewBag.Page = page;

            int maxPage = 5;//maximum page display on website
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

            return View(allPettoy);
        }

        //detail pet toy page
        public ActionResult Detail(String ptID)
        {
            var petToy = new PetToyModel();
            //get pet detail
            var pettoyDetail = petToy.getPetToyByID(ptID);
            //get list relative pet medicine
            ViewBag.relatedPetToy = petToy.getPetMedicineRelated(pettoyDetail.pt_id);
            ViewBag.pettoyDetail = pettoyDetail;
            return View();
        }

        /// <summary>
        /// get list name of pet toy have keyword search
        /// </summary>
        /// <param name="term"></param>
        /// <returns></returns>
        public JsonResult ListName(string term)
        {
            if (term != "") //check have enter input search 
            {
                //get list name
                var data = new PetMedicineModel().ListName(term);
                return Json(new
                {
                    data = data,
                    status = true
                }, JsonRequestBehavior.AllowGet);
            }
            else //input search is empty
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