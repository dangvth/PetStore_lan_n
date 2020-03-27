using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Model
{
    class UserModel
    {
        public UserModel()
        {

        }
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
    }
}
