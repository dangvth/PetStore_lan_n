using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetStoreWebClient.EF;
using PetStoreWebClient.Commom;

namespace PetStoreWebClient.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(Account model)
        {
            if (ModelState.IsValid)
            {
                AccountManagement am = new AccountManagement();
                //Check user enter username & password is correct or not
                int result = am.Login(model.ac_userName, Encryptor.SHA256_Encrypt(model.ac_pwd));

                //If is correct => get account and create session for that account
                if (result == 1)
                {
                    //Get the Account based on username has been inputted  
                    var account = am.getAccountByID(model.ac_userName);
                    ////Initialize User Sesstion
                    //var userSession = new UserSession();
                    ////Assign username and account id into UserSession 
                    //userSession.userName = account.ac_userName;
                    //userSession.accountID = account.ac_id;

                    ////Create session "USER_SESSION" contain username and account ID of account
                    //Session.Add(CommonConstant.USER_SESSION, userSession);
                    UserManagement um = new UserManagement();
                    int userID = um.getUserIDByAccountID(account.ac_id);
                    Session["username"] = account.ac_userName;
                    Session["userID"] = userID;

                    //Redirect to action "Index" on "AccountsControllers"
                    return RedirectToAction("Index", "Home");
                }
                else if (result == -1)  //Account is not exist
                {
                    ModelState.AddModelError("", "The username is not exist!!!");
                }
                else if (result == -2)  //Password is not correct
                {
                    ModelState.AddModelError("", "Password is not correct!!!");
                }
                else if (result == 0)    //Account has been banned
                {
                    ModelState.AddModelError("", "The username has been banned!!!");
                }
            }
            return View("Index");
        }

        //public ActionResult Create()
        //{

        //}
    } 
}