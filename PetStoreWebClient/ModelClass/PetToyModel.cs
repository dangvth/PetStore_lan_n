using PetStoreWebClient.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStoreWebClient.ModelClass
{
    public class PetToyModel
    {
        PetStoreOnlineDbContext db = null;
        public PetToyModel()
        {
            db = new PetStoreOnlineDbContext();
        }

        /// <summary>
        /// get pet's Toy by id
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
        /// get Pet Toy by ID
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
        /// get related pet Toy in sale off
        /// </summary>
        /// <param name="pmID"></param>
        /// <returns></returns>
        public List<PetToys> getPetMedicineRelated(String ptID)
        {
            return db.PetToys.Where(x => x.pt_id != ptID).Take(4).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<PetToys> getAllPetToys(ref int totalRecord, int pageIndex = 1, int pageSize = 4)
        {
            totalRecord = db.PetToys.Where(x => x.pt_status == "Active").Count();
            var model = db.PetToys.Where(x => x.pt_status == "Active").OrderBy(x => x.pt_id).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return model;
        }

        /// <summary>
        /// get Pet Toy element show on website with paging and keyword search
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="totalRecord"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<PetToys> Search(string keyword, ref int totalRecord, int pageIndex = 1, int pageSize = 2)
        {
            totalRecord = db.PetToys.Where(x => x.pt_status == "Active" && x.pt_name.Contains(keyword)).Count();
            var model = db.PetToys.Where(x => x.pt_status == "Active" && x.pt_name.Contains(keyword)).OrderBy(x => x.pt_id).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return model;
        }

        /// <summary>
        /// list name of pet Toy like keyword
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<string> ListName(string keyword)
        {
            return db.PetToys.Where(x => x.pt_name.Contains(keyword)).Select(x => x.pt_name).ToList();
        }
    }
}
