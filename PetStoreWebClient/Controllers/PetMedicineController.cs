using PetStoreWebClient.ModelClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace PetStoreWebClient.Controllers
{
    public class PetMedicineController : Controller
    {
        // GET: PetMedicine
        public ActionResult Index(int page = 1, int pageSize = 12)
        {
            var productView = new ProductViewHome();
            int totalRecord = 0;
            // get list sale off pet medicine
            ViewBag.viewPetMedicineSaleOff = productView.getViewPetMedicineSaleOff();
            var allPetmedicine = new PetMedicineModel().getAllPetMedicine(ref totalRecord, page, pageSize);

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

            return View(allPetmedicine);
        }

        //search and paging
        public ActionResult Search(string keyword, int page = 1, int pageSize = 2)
        {
            var productView = new ProductViewHome();
            int totalRecord = 0;
            //get list pet medcine sale off
            ViewBag.viewPetMedicineSaleOff = productView.getViewPetMedicineSaleOff();
            //get list search
            var allPetmedicine = new PetMedicineModel().Search(keyword, ref totalRecord, page, pageSize);

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

            return View(allPetmedicine);
        }

        //detail pet medicine page
        public ActionResult Detail(String pmID)
        {
            var petMedicine = new PetMedicineModel();
            //get pet detail
            var petmedicineDetail = petMedicine.getPetMedicineByID(pmID);
            //get list relative pet medicine
            ViewBag.relatedPetMedicine = petMedicine.getPetMedicineRelated(petmedicineDetail.pm_id);
            ViewBag.petmedicineDetail = petmedicineDetail;
            return View();
        }

        /// <summary>
        /// get list name of pet medicine have keyword search
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