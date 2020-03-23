using PetStoreWebClient.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStoreWebClient.ModelClass
{
    public class BillModel
    {
        PetStoreOnlineDbContext db = null;
        public BillModel()
        {
            db = new PetStoreOnlineDbContext();
        }

        /// <summary>
        /// insert bill
        /// </summary>
        /// <param name="bill"></param>
        /// <returns></returns>
        public int InsertBill(Bill bill)
        {
            db.Bill.Add(bill);
            db.SaveChanges();
            return bill.b_id;
        }
    }
}