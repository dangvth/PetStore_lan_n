using PetStoreWebClient.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStoreWebClient.ModelClass
{
    public class PetMedicineModel
    {
        PetStoreOnlineDbContext db = null;
        public PetMedicineModel()
        {
            db = new PetStoreOnlineDbContext();
        }

        /// <summary>
        /// get pet's food by id
        /// </summary>
        /// <param name="pfID"></param>
        /// <returns></returns>
        public PetFood getPetFoodByID(String pfID)
        {
            return db.PetFood.Find(pfID);
        }

        /// <summary>
        /// get Pet by ID
        /// </summary>
        /// <param name="pID"></param>
        /// <returns></returns>
        public Pet getPetByID(String pID)
        {
            return db.Pet.Find(pID);
        }

        /// <summary>
        /// get Pet medicine by ID
        /// </summary>
        /// <param name="pmID"></param>
        /// <returns></returns>
        public PetMedicine getPetMedicineByID(String pmID)
        {
            return db.PetMedicine.Find(pmID);
        }

        /// <summary>
        /// get Pet toys by ID
        /// </summary>
        /// <param name="ptID"></param>
        /// <returns></returns>
        public PetToys getPetToyByID(String ptID)
        {
            return db.PetToys.Find(ptID);
        }

        /// <summary>
        /// get related pet food in sale off
        /// </summary>
        /// <param name="pmID"></param>
        /// <returns></returns>
        public List<PetMedicine> getPetMedicineRelated(String pmID)
        {
            return db.PetMedicine.Where(x => x.pm_id != pmID).Take(4).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<PetMedicine> getAllPetMedicine(ref int totalRecord, int pageIndex = 1, int pageSize = 4)
        {
            totalRecord = db.PetMedicine.Where(x => x.pm_status == "Active").Count();
            var model = db.PetMedicine.Where(x => x.pm_status == "Active").OrderBy(x => x.pm_id).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return model;
        }

        /// <summary>
        /// get Pet food element show on website with paging and keyword search
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="totalRecord"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<PetMedicine> Search(string keyword, ref int totalRecord, int pageIndex = 1, int pageSize = 2)
        {
            totalRecord = db.PetMedicine.Where(x => x.pm_status == "Active" && x.pm_name.Contains(keyword)).Count();
            var model = db.PetMedicine.Where(x => x.pm_status == "Active" && x.pm_name.Contains(keyword)).OrderBy(x => x.pm_id).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return model;
        }

        /// <summary>
        /// list name of pet food like keyword
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<string> ListName(string keyword)
        {
            return db.PetMedicine.Where(x => x.pm_name.Contains(keyword)).Select(x => x.pm_name).ToList();
        }
    }
}
