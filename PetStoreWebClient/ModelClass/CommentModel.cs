using PetStoreWebClient.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStoreWebClient.ModelClass
{
    public class CommentModel
    {
        PetStoreOnlineDbContext db = null;
        public CommentModel()
        {
            db = new PetStoreOnlineDbContext();
        }

        /// <summary>
        /// get all comment with each page
        /// </summary>
        /// <param name="totalRecord"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Comment> getAllCommentByPetFoodID(ref int totalRecord, string pID, int pageIndex = 1, int pageSize = 2)
        {
            totalRecord = db.Comment.Where(x => x.cmt_status == "Active" && x.p_id == pID).Count();
            var model = db.Comment.Where(x => x.cmt_status == "Active" && x.p_id == pID).OrderByDescending(x => x.cmt_published).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return model;
        }

        /// <summary>
        /// add comment to db
        /// </summary>
        /// <param name="cm"></param>
        /// <returns></returns>
        public bool InsertComment(Comment cm)
        {
            try
            {
                db.Comment.Add(cm);
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