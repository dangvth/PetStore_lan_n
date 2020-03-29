using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Model
{
    class PetToyModel
    {
        PetStoreEntities db = new PetStoreEntities();
        public PetToyModel() {

        }
        public PetToy getPetToy(String pt_id)
        {
            var db = new PetStoreEntities();
            var pt = db.PetToys.Find(pt_id);
            return pt;
        }
    }
}
