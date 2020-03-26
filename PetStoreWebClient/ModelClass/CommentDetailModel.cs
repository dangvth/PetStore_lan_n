using PetStoreWebClient.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStoreWebClient.ModelClass
{
    public class CommentDetailModel
    {
        PetStoreOnlineDbContext db = null;
        public CommentDetailModel()
        {
            db = new PetStoreOnlineDbContext();
        }

        /// <summary>
        /// get all comment detail
        /// </summary>
        /// <returns></returns>
        public List<CommentDetail> getAllCommentDetail()
        {
            return db.CommentDetail.Where(x => x.cmtd_status == "Active").ToList();
        }

        /// <summary>
        /// get comment detail by comment id
        /// </summary>
        /// <param name="cmtID"></param>
        /// <returns></returns>
        public List<CommentDetail> getCommentDetailByCmtID(int cmtID)
        {
            return db.CommentDetail.Where(x => x.cmtd_status == "Active" && x.cmt_id == cmtID).ToList();
        }
    }
}