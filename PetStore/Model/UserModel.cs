using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Model
{
    class UserModel
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public UserModel()
        {

        }
        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="uID"></param>
        /// <param name="uName"></param>
        /// <param name="uGender"></param>
        /// <param name="uMail"></param>
        /// <param name="uPhone"></param>
        /// <param name="uAddress"></param>
        public void UpdateUser(int uID, string uName, string uGender, string uMail, string uPhone, string uAddress)
        {
            using (var db = new PetStoreEntities())
            {
                var User = db.Users.Find(uID);
                User.u_name = uName;
                User.u_gender = uGender;
                User.u_email = uMail;
                User.u_phone = uPhone;
                User.u_address = uAddress;
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Get username by ID
        /// </summary>
        /// <param name="uID"></param>
        /// <returns></returns>
        public string getUName(int? uID)
        {
            using (var db = new PetStoreEntities())
            {
                var User = db.Users.Find(uID);
                return User.u_name;
            }
            return null;
        }
    }
}
