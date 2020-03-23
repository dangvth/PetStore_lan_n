using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Object
{
    class Comment
    {
        private int cmt_id;
        private String cmt_content;
        private String cmt_published;
        private String cmt_status;
        private String u_name;
        private String p_name;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmt_id"></param>
        /// <param name="cmt_content"></param>
        /// <param name="cmt_published"></param>
        /// <param name="cmt_Status"></param>
        /// <param name="p_id"></param>
        /// <param name="u_id"></param>
        public Comment(int cmt_id, String cmt_content, String cmt_published,
                       String p_name, String u_name, String cmt_Status)
        {
            this.cmt_id = cmt_id;
            this.cmt_content = cmt_content;
            this.cmt_published = cmt_published;
            this.cmt_status = cmt_Status;
            this.p_name = p_name;
            this.u_name = u_name;
        }

        public Comment()
        {

        }

        public int CommentID
        {
            set
            {
                this.cmt_id = value;
            }
            get
            {
                return cmt_id;
            }
        }

        public String CommentContent
        {
            set
            {
                this.cmt_content = value;
            }
            get
            {
                return cmt_content;
            }
        }

        public String CommentPublished
        {
            set
            {
                this.cmt_published = value;
            }
            get
            {
                return cmt_published;
            }
        }

        public String UserName
        {
            set
            {
                this.u_name = value;
            }
            get
            {
                return u_name;
            }
        }

        public String PetName
        {
            set
            {
                this.p_name = value;
            }
            get
            {
                return p_name;
            }
        }

        public String CommentStatus
        {
            set
            {
                this.cmt_status = value;
            }
            get
            {
                return cmt_status;
            }
        }
    }
}
