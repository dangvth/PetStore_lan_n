using PetStoreWebClient.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStoreWebClient.ModelClass
{
    public class ProductViewHome
    {
        PetStoreOnlineDbContext db = null;

        public ProductViewHome()
        {
            db = new PetStoreOnlineDbContext();
        }

        /// <summary>
        /// get top pet by published
        /// </summary>
        /// <param name="top"></param>
        /// <returns></returns>
        public List<Pet> getViewPet(int top)
        {
            return db.Pet.Where(x => x.p_status == "Active").
                OrderByDescending(x => x.p_published).Take(top).ToList();
        }

        /// <summary>
        /// get top pet's food by ID
        /// </summary>
        /// <param name="top"></param>
        /// <returns></returns>
        public List<PetFood> getViewPetFood(int top)
        {
            return db.PetFood.Where(x => x.pf_status == "Active").
                OrderByDescending(x => x.pf_id).Take(top).ToList();
        }

        /// <summary>
        /// get top pet's toys by published
        /// </summary>
        /// <param name="top"></param>
        /// <returns></returns>
        public List<PetToys> getViewPetToys(int top)
        {
            return db.PetToys.Where(x => x.pt_status == "Active").
                OrderByDescending(x => x.pt_published).Take(top).ToList();
        }

        /// <summary>
        /// get Pet Sale off
        /// </summary>
        /// <returns></returns>
        public List<Pet> getViewPetSaleOff()
        {
            return db.Pet.Where(x => x.p_status == "Active" && x.p_prices > x.p_salePrice).
                OrderByDescending(x => (x.p_prices - x.p_salePrice)).ToList();
        }

        /// <summary>
        /// get Pet's food sale off
        /// </summary>
        /// <returns></returns>
        public List<PetFood> getViewPetFoodSaleOff()
        {
            return db.PetFood.Where(x => x.pf_status == "Active" && x.pf_prices > x.pf_salePrice).
                OrderByDescending(x => (x.pf_prices - x.pf_salePrice)).ToList();
        }
    }
}