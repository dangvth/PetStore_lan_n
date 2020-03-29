using PetStoreWebClient.Commom;
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
        public ActionResult Index(int page = 1, int pageSize = 4)
        {
            var productView = new ProductViewHome();
            //initialize 
            int totalRecord = 0;
            //Save Pet to pass data to another view
            ViewBag.viewPetSaleOff = productView.getViewPetSaleOff();
            //Get all pet
            var allPet = new PetModel().getAllPet(ref totalRecord, page, pageSize);

            //Save total page and page to pass data to another view
            ViewBag.Total = totalRecord;
            ViewBag.Page = page;

            //Paging
            int maxPage = 5;//maximum page link display on website
            int totalPage = 0;
            //Paging Algorithm
            totalPage = (int)Math.Ceiling((double)totalRecord / pageSize);

            //Save data page to pass data to another view
            ViewBag.totalPage = totalPage;
            ViewBag.maxPage = maxPage;
            ViewBag.first = 1;
            ViewBag.last = totalPage;
            ViewBag.next = page + 1;
            ViewBag.prev = page - 1;
            return View(allPet);
        }

        public ActionResult Search(string keyword, int page = 1, int pageSize = 4)
        {
            var productView = new ProductViewHome();
            //initialize 
            int totalRecord = 0;
            //Save Pet to pass data to another view
            ViewBag.viewPetSaleOff = productView.getViewPetSaleOff();
            //Get all pet
            var allPet = new PetModel().Search(keyword, ref totalRecord, page, pageSize);

            //Save total page, keyword and page to pass data to another view
            ViewBag.Total = totalRecord;
            ViewBag.keyword = keyword;
            ViewBag.Page = page;

            //Paging
            int maxPage = 5;//maximum page link display on website
            int totalPage = 0;
            //Paging Algorithm
            totalPage = (int)Math.Ceiling((double)totalRecord / pageSize);

            //Save data page to pass data to another view
            ViewBag.totalPage = totalPage;
            ViewBag.maxPage = maxPage;
            ViewBag.first = 1;
            ViewBag.last = totalPage;
            ViewBag.next = page + 1;
            ViewBag.prev = page - 1;
            return View(allPet);
        }

        public ActionResult Detail(String pID, int page = 1, int pageSize = 2)
        {
            var cmt = new CommentModel();
            var cmtd = new CommentDetailModel();
            var pet = new PetModel();

            var petDetail = pet.getPetByID(pID);
            var listAllUser = new UserManagement().getAllViewUser();
            ViewBag.relatedPet = pet.getPetRelated(petDetail.p_id);
            ViewBag.listUser = listAllUser;
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
            var loginSession = Session["userLogin"];
            if (loginSession != null)
            {
                var user = (PetStoreWebClient.EF.User)loginSession;
                Comment cm = new Comment();
                cm.cmt_published = DateTime.Now;
                cm.p_id = pID;
                cm.cmt_content = txtComment;
                cm.cmt_status = "Active";
                cm.u_id = user.u_id;
                var cmt = new CommentModel().InsertComment(cm);
                return Redirect("/detail/pet/" + pID);
            }
            else
            {
                return RedirectToAction("Index", "Accounts");
            }
        }

        [HttpPost]
        public ActionResult CommentDetail(int cmtID, int page, string txtCommentDetail, string pID)
        {
            var loginSession = Session["userLogin"];
            if (loginSession != null)
            {
                var user = (PetStoreWebClient.EF.User)loginSession;
                CommentDetail cmd = new CommentDetail();
                cmd.cmtd_published = DateTime.Now;
                cmd.cmtd_status = "Active";
                cmd.cmt_id = cmtID;
                cmd.cmtd_content = txtCommentDetail;
                cmd.u_id = user.u_id;
                var commentDetail = new CommentDetailModel().InsertCommentDetail(cmd);
                return Redirect("/detail/pet/" + pID + "?page=" + page);
            }
            else
            {
                return RedirectToAction("Index", "Accounts");
            }
        }

        /// <summary>
        /// Get list name of pet contains keyword search
        /// </summary>
        /// <param name="term"></param>
        /// <returns></returns>
        public JsonResult ListName(string p)
        {
            if (p != "") //check have enter input search 
            {
                //get list name
                var data = new PetFoodModel().ListName(p);
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