using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PetStoreWebClient.EF;

namespace PetStoreWebClient.Controllers
{
    public class UsersController : Controller
    {
        private PetStoreOnlineDbContext db = new PetStoreOnlineDbContext();
        private const String userLogin = "userLogin";
        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.User.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            ViewBag.ac_id = new SelectList(db.Account, "ac_id", "ac_userName");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "u_id,u_name,u_gender,u_email,u_phone,u_address,u_status,ac_id")] User user)
        {
            if (ModelState.IsValid)
            {
                db.User.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ac_id = new SelectList(db.Account, "ac_id", "ac_userName", user.ac_id);
            return View(user);
        }

        // GET: Users/Edit/5
        public ActionResult Edit()
        {
            var sessLogin = (User) Session[userLogin];
            if (sessLogin == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.User.Find(sessLogin.u_id);
            if (user == null)
            {
                return HttpNotFound();
            }
            ViewBag.ac_id = new SelectList(db.Account, "ac_id", "ac_userName", user.ac_id);
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "u_id,u_name,u_gender,u_email,u_phone,u_address,u_status,ac_id")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details", new { id = user.u_id});
            }
            ViewBag.ac_id = new SelectList(db.Account, "ac_id", "ac_userName", user.ac_id);
            return View(user);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.User.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.User.Find(id);
            db.User.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
