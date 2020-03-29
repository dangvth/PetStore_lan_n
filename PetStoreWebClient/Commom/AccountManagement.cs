using PetStoreWebClient.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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