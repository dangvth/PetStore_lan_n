using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Object
{
    class Account
    {
        //declare object variables 
        private int ac_id;              //Initialize ID Account
        private string ac_username;     //Initialize usernamme
        private string ac_pwd;          //Initialize password
        private string ac_status;       //Initialize account status: 0 - active, 1 - baned/deleted
        private int r_id;               //Initialize foreign key 
        private string r_name;          //Initialize role name

        /// <summary>
        /// Initialize object account
        /// </summary>
        /// <param name="ac_id"></param>
        /// <param name="ac_username"></param>
        /// <param name="ac_pwd"></param>
        /// <param name="r_id"></param>
        public Account(int ac_id, string ac_username, string ac_pwd, int r_id)
        {
            this.ac_id = ac_id;
            this.ac_username = ac_username;
            this.ac_pwd = ac_pwd;
            this.r_id = r_id;
        }

        /// <summary>
        /// Initialize object account
        /// </summary>
        /// <param name="ac_id"></param>
        /// <param name="ac_username"></param>
        /// <param name="r_name"></param>
        public Account(int ac_id, string ac_username, string r_name)
        {
            this.ac_id = ac_id;
            this.ac_username = ac_username;
            this.r_name = r_name;
        }

        #region Account Object Properties
        /// <summary>
        /// properties account id
        /// </summary>
        public int Ac_id
        {
            get
            {
                return ac_id;
            }
            set
            {
                ac_id = value;
            }
        }

        /// <summary>
        /// properties Account username
        /// </summary>
        public string Ac_username
        {
            get
            {
                return ac_username;
            }
            set
            {
                ac_username = value;
            }
        }

        /// <summary>
        /// Properties Account password
        /// </summary>
        public string Ac_pwd
        {
            get
            {
                return ac_pwd;
            }
            set
            {
                ac_pwd = value;
            }
        }

        /// <summary>
        /// Properties Account Status
        /// </summary>
        public string AC_STATUS
        {
            get
            {
                return ac_status;
            }

            set
            {
                ac_status = value;
            }
        }

        /// <summary>
        /// Properties Role Id
        /// </summary>
        public int R_id
        {
            get { return r_id; }
            set { r_id = value; }
        }

        /// <summary>
        /// Properties Role Name
        /// </summary>
        public string R_NAME
        {
            get
            {
                return r_name;
            }
            set
            {
                r_name = value;
            }
        }
        #endregion Create properties for account
    }
}
