using PetStoreWebClient.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetStoreWebClient.Commom;

namespace PetStoreWebClient.Commom
{
    public class AccountManagement
    {
        PetStoreOnlineDbContext db;

        public AccountManagement()
        {
            db = new PetStoreOnlineDbContext();
        }

        /// <summary>
        /// Insert Account
        /// </summary>
        /// <param name="ac"></param>
        /// <returns></returns>
        public int InsertAccount(Account ac)
        {
            db.Account.Add(ac);
            db.SaveChanges();
            return ac.ac_id;
        }

        /// <summary>
        /// get Account by username
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public Account getAccountByID(string userName)
        {
            return db.Account.SingleOrDefault(x => x.ac_userName == userName);
        }

        /// <summary>
        /// Get Account ID by username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public int getIDByUsername(string username)
        {
            Account ac = db.Account.Where(a => a.ac_userName == username).SingleOrDefault();
            return ac.ac_id;
        }

        /// <summary>
        /// Check Username and password is correct
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int Login(string userName, string password)
        {
            var result = db.Account.SingleOrDefault(x => x.ac_userName == userName);
            if (result == null)
            {
                return -1;
            }
            else
            {
                if (result.ac_status == "Banned/ Deleted")
                {
                    return 0;
                }
                else
                {
                    if (result.ac_pwd == password)
                    {
                        return 1;
                    }
                    else
                    {
                        return -2;
                    }
                }
            }
        }

        /// <summary>
        /// Check username is already exist or not
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool isAccountExists(string username)
        {
            var account = db.Account.FirstOrDefault(x => x.ac_userName == username);
            if (account != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Change Password of account
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="newPWD"></param>
        public void ChangePassword(string userName, string newPWD)
        {
            Account ac = db.Account.Where(p => p.ac_userName == userName).SingleOrDefault();
            ac.ac_pwd = Encryptor.SHA256_Encrypt(newPWD);
            db.SaveChanges();
        }

        /// <summary>
        /// Check old Password user input is correct or not
        /// </summary>
        /// <param name="id"></param>
        /// <param name="oldPassword"></param>
        /// <returns></returns>
        public bool isOldPassword(string username, string oldPassword)
        {
            int id = getIDByUsername(username);
            Account ac = db.Account.Where(x => x.ac_id == id).SingleOrDefault();
            if (ac.ac_pwd.Equals(Encryptor.SHA256_Encrypt(oldPassword)))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Account Status must is "Active" or "Banned".
        /// If difference them then send error message
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public bool isStatus(string status)
        {
            if (status.Equals("Active") || status.Equals("Banned"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}