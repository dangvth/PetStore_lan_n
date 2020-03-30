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

        /// <summary>
        /// get all pet
        /// </summary>
        /// <param name="totalRecord">Number of page</param>
        /// <param name="pageIndex">Current page</param>
        /// <param name="pageSize">Number of product in each page</param>
        /// <returns></returns>
        public List<Pet> getAllPet(ref int totalRecord, int pageIndex = 1, int pageSize = 2)
        {
            //Count Pet with Status is "Active"
            totalRecord = db.Pet.Where(x => x.p_status == "Active").Count();
            //Get Pet to List
            //Skip(): Skip the product has been display on previous page based on pageSize
            //Take(): Take the product to display on current page based on pageSize 
            var model = db.Pet.Where(x => x.p_status == "Active").OrderBy(x => x.p_id).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return model;
        }

        /// <summary>
        /// Get Pet element show on website with paging and keyword search
        /// </summary>
        /// <param name="totalRecord">Number of page</param>
        /// <param name="pageIndex">Current page</param>
        /// <param name="pageSize">Number of product in each page</param>
        /// <returns></returns>
        public List<Pet> Search(string keyword, ref int totalRecord, int pageIndex = 1, int pageSize = 2)
        {
            //Count Pet with Status is "Active" and contain the keyword user inputted
            totalRecord = db.Pet.Where(x => x.p_status == "Active" && x.p_name.Contains(keyword)).Count();
            //Get Pet have contain the keyword to List
            //Skip(): Skip the product has been display on previous page based on pageSize
            //Take(): Take the product to display on current page based on pageSize 
            var model = db.Pet.Where(x => x.p_status == "Active" && x.p_name.Contains(keyword)).OrderBy(x => x.p_id).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return model;
        }

        /// <summary>
        /// Get list name of pet like keyword
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<string> ListName(string keyword)
        {
            return db.Pet.Where(x => x.p_name.Contains(keyword)).Select(x => x.p_name).ToList();
        }
    }
}