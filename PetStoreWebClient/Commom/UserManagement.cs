using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetStoreWebClient.EF;
using PetStoreWebClient.ModelClass;

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

        /// <summary>
        /// Get User by Account ID
        /// </summary>
        /// <param name="acID"></param>
        /// <returns></returns>
        public User getUserByAccountID(int acID)
        {
            return db.User.SingleOrDefault(u => u.ac_id == acID);
        }

        /// <summary>
        /// get all user
        /// </summary>
        /// <returns></returns>
        public List<User> getAllUser()
        {
            return db.User.Where(x => x.u_status == "Active").ToList();
        }

        /// <summary>
        /// get view comment
        /// </summary>
        /// <returns></returns>
        public List<CommentViewUser> getAllViewUser()
        {
            var model = from u in db.User
                        join a in db.Account
                        on u.ac_id equals a.ac_id
                        join r in db.Role 
                        on a.r_id equals r.r_id
                        select new CommentViewUser()
                        {
                            u_id = u.u_id,
                            u_name = u.u_name,
                            r_name = r.r_name
                        };
            return model.ToList();
        }
    }
}