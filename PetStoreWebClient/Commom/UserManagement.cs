using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetStoreWebClient.EF;

namespace PetStoreWebClient.Commom
{
    public class UserManagement
    {
        PetStoreOnlineDbContext db;

        public UserManagement()
        {
            db = new PetStoreOnlineDbContext();
        }

        public void InsertUser(string name, string gender, string email, string phone,
            string address, int ac_id)
        {
            var user = new User();
            user.u_name = name;
            user.u_gender = gender;
            user.u_email = email;
            user.u_phone = phone;
            user.u_address = address;
            user.u_status = "Active";
            user.ac_id = ac_id;

            using (var db = new PetStoreOnlineDbContext())
            {
                db.User.Add(user);
                db.SaveChanges();
            }
        }

        public int getUserIDByAccountID(int acID)
        {
            return db.User.SingleOrDefault(u => u.ac_id == acID).u_id;
        }
    }
}