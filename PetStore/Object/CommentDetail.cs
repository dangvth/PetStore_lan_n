using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Object
{
    class CommentDetail
    {
        private int cmtd_id;
        private String cmt_Content;
        private String cmtd_content;
        private String cmtd_published;
        private String cmtd_status;
        private String uName;

        public int ID
        {
            get
            {
                return cmtd_id;
            }

            set
            {
                cmtd_id = value;
            }
        }

        public string ReplyContent
        {
            get
            {
                return cmtd_content;
            }

            set
            {
                cmtd_content = value;
            }
        }

        public string Published
        {
            get
            {
                return cmtd_published;
            }

            set
            {
                cmtd_published = value;
            }
        }

        public string NameOfUser
        {
            get
            {
                return uName;
            }

            set
            {
                uName = value;
            }
        }

        public string Comment
        {
            get
            {
                return cmt_Content;
            }

            set
            {
                cmt_Content = value;
            }
        }

        public String Status
        {
            get
            {
                return cmtd_status;
            }

            set
            {
                cmtd_status = value;
            }
        }

        public CommentDetail(int cmtdID, String cmtContent, String cmtdContent,
                                  String cmtdPublished, String userName, String cmtdStatus)
        {
            this.cmtd_id = cmtdID;
            this.uName = userName;
            this.cmtd_content = cmtdContent;
            this.cmtd_published = cmtdPublished;
            this.cmtd_status = cmtdStatus;
            this.cmt_Content = cmtContent;
        }

    }
}
