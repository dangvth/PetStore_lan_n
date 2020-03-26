using PetStoreWebClient.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStoreWebClient.ModelClass
{
    public class PetModel
    {
        PetStoreOnlineDbContext db = null;
        public PetModel()
        {
            db = new PetStoreOnlineDbContext();
        }

        public Pet getPetByID(String pID)
        {
            return db.Pet.Find(pID);
        }

        public List<Pet> getPetRelated(String pID)
        {
            return db.Pet.Where(x => x.p_id != pID).Take(4).ToList();
        }
    }
}