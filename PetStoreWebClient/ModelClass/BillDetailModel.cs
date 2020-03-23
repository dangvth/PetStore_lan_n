using PetStoreWebClient.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStoreWebClient.ModelClass
{
    public class BillDetailModel
    {
        PetStoreOnlineDbContext db = null;
        public BillDetailModel()
        {
            db = new PetStoreOnlineDbContext();
        }

        /// <summary>
        /// insert bill detail
        /// </summary>
        /// <param name="billdetai"></param>
        /// <returns></returns>
        public bool InsertBillDetail(BillDetail billdetai)
        {
            try
            {
                db.BillDetail.Add(billdetai);
                db.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }
            
        }
    }
}