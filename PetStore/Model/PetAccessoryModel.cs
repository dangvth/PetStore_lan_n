using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Model
{
    class PetAccessoryModel
    {
        PetStoreEntities db = new PetStoreEntities();
        public PetAccessoryModel()
        {

        }
        public PetAccessory getPetAccessory(String pa_id)
        {
            var db = new PetStoreEntities();
            var pa = db.PetAccessories.Find(pa_id);
            return pa;
        }
    }
}
