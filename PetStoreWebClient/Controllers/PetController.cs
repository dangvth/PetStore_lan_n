using PetStoreWebClient.EF;
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

        [HttpPost]
        public ActionResult Comment(string pID, string txtComment)
        {
            Comment cm = new Comment();
            cm.cmt_published = DateTime.Now;
            cm.p_id = pID;
            cm.cmt_content = txtComment;
            cm.cmt_status = "Active";
            cm.u_id = 1;
            var cmt = new CommentModel().InsertComment(cm);
            return Redirect("/detail/pet/" + pID);
        }

        [HttpPost]
        public ActionResult CommentDetail(int cmtID, int page, string txtCommentDetail, string pID)
        {
            CommentDetail cmd = new CommentDetail();
            cmd.cmtd_published = DateTime.Now;
            cmd.cmtd_status = "Active";
            cmd.cmt_id = cmtID;
            cmd.cmtd_content = txtCommentDetail;
            cmd.u_id = 1;
            var commentDetail = new CommentDetailModel().InsertCommentDetail(cmd);
            return Redirect("/detail/pet/" + pID + "?page=" + page);
        }
    }
}