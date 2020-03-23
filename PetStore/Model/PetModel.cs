using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PetStore.Model
{
    class PetModel
    {
        //declare PET variables
        PetStoreEntities db = new PetStoreEntities();
        List<PetStore.Pet> pList;
        public PetModel() { }
        
        /// <summary>
        /// get number of Pets on database
        /// </summary>
        /// <returns></returns>
        public int getNumberOfPet()
        {
            //get number of pet on database
            var numOfPet = from p in db.Pets select p;
            return numOfPet.Count(); 
        }

        /// <summary>
        /// Delete - Inactive Pet
        /// </summary>
        /// <param name="id"></param>
        public void InactivePet(string id)
        {
            Pet p = db.Pets.Where(pet => pet.p_id == id).SingleOrDefault();
            p.p_status = "Inactive";
            db.SaveChanges();
        }

        /// <summary>
        /// Restore or active Pet
        /// </summary>
        /// <param name="id"></param>
        public void RestorePet(string id)
        {
            Pet p = db.Pets.Where(pet => pet.p_id == id).SingleOrDefault();
            p.p_status = "Active";
            db.SaveChanges();
        }

        /// <summary>
        /// Set Pet ID for text edit
        /// </summary>
        /// <param name="txtPetID"></param>
        public string SetPetID()
        {
            int numOfPet = getNumberOfPet();
            string id = "";
            if (numOfPet < 10)
            {
                id = "PET000" + numOfPet + 1;
            }
            return id;
        }
    }
}
