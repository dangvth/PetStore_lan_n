using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Model
{
    class CommentDetailModel
    {
        ArrayList cmtdList;

        //constructor
        public CommentDetailModel()
        {

        }

        /// <summary>
        /// delete comment reply by id
        /// </summary>
        /// <param name="cmtd_id"></param>
        public void DeleteCommentDetail(int cmtd_id)
        {
            using (var db = new PetStoreEntities())
            {
                var cmtd = db.CommentDetails.Find(cmtd_id);
                cmtd.cmtd_status = "Inactive";
                db.SaveChanges();
            }
        }

        /// <summary>
        /// delete comment reply by id
        /// </summary>
        /// <param name="cmtd_id"></param>
        public void RestoreCommentDetail(int cmtd_id)
        {
            using (var db = new PetStoreEntities())
            {
                var cmt = db.CommentDetails.Find(cmtd_id);
                cmt.cmtd_status = "Active";
                db.SaveChanges();
            }
        }

        /// <summary>
        /// get all data comment reply
        /// </summary>
        /// <returns>comment detail list</returns>
        public ArrayList GetAllDataToArrayList()
        {
            cmtdList = new ArrayList();
            using (var db = new PetStoreEntities())
            {
                var selectStr = (from cmtd in db.CommentDetails
                                 join u in db.Users on cmtd.u_id equals u.u_id
                                 join cmt in db.Comments on cmtd.cmt_id equals cmt.cmt_id
                                 select new
                                 {
                                     cmtd.cmtd_id,
                                     cmt.cmt_content,
                                     cmtd.cmtd_content,
                                     cmtd.cmtd_published,
                                     u.u_name,
                                     cmtd.cmtd_status
                                 });

                foreach (var data in selectStr)
                {
                    cmtdList.Add(new Object.CommentDetail(data.cmtd_id, data.cmt_content, data.cmtd_content, data.cmtd_published.ToString(), data.u_name, data.cmtd_status));
                }
            }
            return cmtdList;
        }
    }
}
