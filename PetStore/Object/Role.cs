using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Object
{
    class Role
    {
        //declare object variables
        private int r_id;           // primary key role id
        private string r_name;      // role name
        private string r_status;    // role status: 0 - active, 1 - inactive

        /// <summary>
        /// Initialize object class Role
        /// </summary>
        /// <param name="r_id"></param>
        /// <param name="r_name"></param>
        public Role(int r_id, string r_name, string r_status)
        {
            this.r_id = r_id;
            this.r_name = r_name;
            this.r_status = r_status;
        }

        #region Object Properties 
        /// <summary>
        /// Propetties role id
        /// </summary>
        public int R_id
        {
            get { return r_id; }
            set { r_id = value; }
        }

        /// <summary>
        /// Propetties role name
        /// </summary>
        public string R_name
        {
            get { return r_name; }
            set { r_name = value; }
        }

        /// <summary>
        /// Propetties role status
        /// </summary>
        public string R_status
        {
            get
            {
                return r_status;
            }

            set
            {
                r_status = value;
            }
        }
        #endregion
    }
}
