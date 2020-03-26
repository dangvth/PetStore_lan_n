using PetStoreWebClient.ModelClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetStoreWebClient.Controllers
{
    public class PetController : Controller
    {
        // GET: Pet
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(String pID, int page = 1, int pageSize = 2)
        {
            var cmt = new CommentModel();
            var cmtd = new CommentDetailModel();
            var pet = new PetModel();

            var petDetail = pet.getPetByID(pID);
            ViewBag.relatedPet = pet.getPetRelated(petDetail.p_id);
            ViewBag.petDetail = petDetail;

            int totalRecord = 0;
            var allCmtOfPet = cmt.getAllCommentByPetFoodID(ref totalRecord, pID, page, pageSize);

            ViewBag.Total = totalRecord;
            ViewBag.Page = page;

            int maxPage = 5;//maximum page link display on website
            int totalPage = 0;
            totalPage = (int)Math.Ceiling((double)totalRecord / pageSize);

            ViewBag.totalPage = totalPage;
            ViewBag.maxPage = maxPage;
            ViewBag.first = 1;
            ViewBag.last = totalPage;
            ViewBag.next = page + 1;
            ViewBag.prev = page - 1;

            ViewBag.listAllCommentDetail = cmtd.getAllCommentDetail();
            return View(allCmtOfPet);
        }
    }
}