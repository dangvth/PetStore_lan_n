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
            return View();
        }
    }
}