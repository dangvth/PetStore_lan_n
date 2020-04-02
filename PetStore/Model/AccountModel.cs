using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetStore;
using PetStore.MyUtil;

namespace PetStore.Model
{
    class AccountModel
    {
        //declare variables
        PetStoreEntities db;
        List<PetStore.Account> acList;

        //Initialize Model class for Account
        public AccountModel()
        {
            db = new PetStoreEntities();
        }

        /// <summary>
        /// Get all account in database 
        /// </summary>
        /// <returns></returns>
        public List<PetStore.Account> getAccount()
        {
            acList = new List<PetStore.Account>();
            acList = (from ac in db.Accounts select ac).ToList();
            return acList;
        }

        /// <summary>
        /// check username and password user inputted is correct or not
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool isCorrectAccount(string username, string pwd)
        {
            getAccount();
            foreach (Account a in acList)
            {
                //if username is correct then check password
                if (a.ac_userName.Equals(username))
                {
                    //encrypt and check match with password on database
                    if (a.ac_pwd.Equals(MyUtil.Encryptor.SHA256_Encrypt(pwd)))
                    {
                        //return true if match
                        return true;
                    }
                }
            }
            //if not match, return false
            return false;
        }

        /// <summary>
        /// Get Account ID by username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public int getIDByUsername(string username)
        {
            Account ac = db.Accounts.Where(a => a.ac_userName == username).SingleOrDefault();
            return ac.ac_id;
        }

        /// <summary>
        /// Change Password of account
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="newPWD"></param>
        public void ChangePassword(string userName, string newPWD)
        {
            Account ac = db.Accounts.Where(p => p.ac_userName == userName).SingleOrDefault();
            ac.ac_pwd = MyUtil.Encryptor.SHA256_Encrypt(newPWD);
            db.SaveChanges();
        }

        /// <summary>
        /// Reset password of account has been chosen
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newPWD"></param>
        public void ResetPassword(int id)
        {
            Account ac = db.Accounts.Where(p => p.ac_id == id).SingleOrDefault();
            ac.ac_pwd = MyUtil.Encryptor.SHA256_Encrypt("user@123");
            db.SaveChanges();
        }

        /// <summary>
        /// Ban or Delete account
        /// </summary>
        /// <param name="id"></param>
        public void Ban_DeleteAccount(int id)
        {
            Account ac = db.Accounts.Where(p => p.ac_id == id).SingleOrDefault();
            ac.ac_status = "Baned/ Deleted";
            db.SaveChanges();
        }

        /// <summary>
        /// Restore or active account
        /// </summary>
        /// <param name="id"></param>
        public void RestoreAccount(int id)
        {
            Account ac = db.Accounts.Where(p => p.ac_id == id).SingleOrDefault();
            ac.ac_status = "Active";
            db.SaveChanges();
        }

        /// <summary>
        /// Check userName has already exist or not
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool checkConcideUsername(string userName)
        {
            getAccount();
            foreach (Account a in acList)
            {
                if (a.ac_userName.Equals(userName))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Check old Password user input is correct or not
        /// </summary>
        /// <param name="id"></param>
        /// <param name="oldPassword"></param>
        /// <returns></returns>
        public bool isOldPassword(int id, string oldPassword)
        {
            //get account based on account id
            Account ac = db.Accounts.Where(x => x.ac_id == id).SingleOrDefault();
            //check password user inputted and password in database
            //if same, return true
            if (ac.ac_pwd.Equals(Encryptor.SHA256_Encrypt(oldPassword)))
            {
                return true;
            }
            //if not same, return false
            return false;
        }

        /// <summary>
        /// check role of account
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        public int checkRole(string userInput)
        {
            //get account list
            getAccount();
            //get role id
            foreach (Account a in acList)
            {
                if (a.ac_userName.Equals(userInput))
                {
                    return Convert.ToInt32(a.r_id);
                }
            }
            return -1;
        }
    }
}
