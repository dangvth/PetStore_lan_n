
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

        public int InsertAccount(Account ac)
        {
            db.Account.Add(ac);
            db.SaveChanges();
            return ac.ac_id;
        }
    }
}