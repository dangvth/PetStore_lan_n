using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Object
{
    class Type
    {
        //declare object variables
        private int t_id;           //Initialize Type ID
        private string t_name;      //Initialize Type Name
        private string t_status;    //Initialize Type Status: 0 - active, 1 - inactive
        private int org_id;         //Initialize Origin ID

        /// <summary>
        /// Initialize object Type class
        /// </summary>
        /// <param name="t_id"></param>
        /// <param name="t_name"></param>
        /// <param name="t_status"></param>
        /// <param name="org_id"></param>
        public Type(int t_id, string t_name, string t_status, int org_id)
        {
            this.t_id = t_id;
            this.t_name = t_name;
            this.t_status = t_status;
            this.org_id = org_id;
        }

        #region * Properties Type Object *
        /// <summary>
        /// Properties Type ID
        /// </summary>
        public int T_ID
        {
            get
            {
                return t_id;
            }

            set
            {
                t_id = value;
            }
        }

        /// <summary>
        /// Properties Type NAME
        /// </summary>
        public string T_NAME
        {
            get
            {
                return t_name;
            }

            set
            {
                t_name = value;
            }
        }

        /// <summary>
        /// Properties Type Status
        /// </summary>
        public string T_STATUS
        {
            get
            {
                return t_status;
            }

            set
            {
                t_status = value;
            }
        }

        /// <summary>
        /// Properties Origin ID
        /// </summary>
        public int ORG_ID
        {
            get
            {
                return org_id;
            }

            set
            {
                org_id = value;
            }
        }
        #endregion
    }
}
