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

                    //Initialize User Management
                    UserManagement um = new UserManagement();
                    //Get User by Account ID
                    var user = um.getUserByAccountID(account.ac_id);
                    //Create Session to store username and ID of user
                    Session["username"] = account.ac_userName;
                    Session["userLogin"] = user;

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

        //[HttpGet]
        //public ActionResult Create()
        //{
        //    return View("Index");
        //}

        public ActionResult Create(Account account, FormCollection Fields)
        {
            //declare variables and get value from Sign Up form
            string fullname = Fields["fullName"];
            string addr = Fields["address"];
            string email = Fields["email"];
            string phone = Fields["phone"];
            string gender = Fields["gender"];
            string username = account.ac_userName.ToString();
            string password = account.ac_pwd.ToString();

            //Check validation format
            if (!ValidationFormat.isEmailFormat(email)) //Check email format 
            {
                //send error message
                ModelState.AddModelError("", "Email is not correct format!!!!");
                return View("Index");
            }
            else if (!ValidationFormat.isPhoneFormat(phone)) //Check phone format
            {
                //send error message
                ModelState.AddModelError("", "Phone number must be 10 digits!!!!");
                return View("Index");
            }
            else if (!ValidationFormat.isPasswordFormat(password)) //Check password format
            {
                //send error message
                ModelState.AddModelError("", "Password must be between 4 to 20 characters!!!!");
                return View("Index");
            }
            else if (!(fullname.Equals("") || addr.Equals("") || email.Equals("") || phone.Equals("")
                || username.Equals("") || password.Equals(""))) //Check all fields has been fill
            {
                //Insert Account and return account ID
                AccountManagement am = new AccountManagement();
                var pwdEncrypt = Encryptor.SHA256_Encrypt(account.ac_pwd);
                account.ac_pwd = pwdEncrypt;
                account.ac_status = "Active";
                account.r_id = 3;
                int acID = am.InsertAccount(account);
                //If insert Account successful then insert User
                if (acID > 0)
                {
                    //Insert User
                    UserManagement um = new UserManagement();
                    um.InsertUser(fullname, gender, email, phone, addr, acID);
                    //Create session 
                    Session["username"] = account.ac_userName;
                    //Session["userID"] = user;
                    //Redirect to Action Index on HomeController
                    return RedirectToAction("Index", "Home");
                }
            }
            else    //If has field is blank 
            {
                //send error message
                ModelState.AddModelError("", "Any fields can not be blank!!!!");
                return View("Index");
            }
            return View("Index");
        }

        public ActionResult LogoutProcess()
        {
            Session["userLogin"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}