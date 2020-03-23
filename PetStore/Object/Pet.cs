using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Object
{
    class Pet
    {
        //declare Object variables
        private string p_id;            //Initialize pet id
        private string p_name;          //Initialize pet name
        private int p_price;              //Initialize pet origin price
        private int p_salePrice;          //Initialize pet sell price
        private string p_image;         //Initialize pet image
        private string p_description;   //Initialize pet description
        private string p_published;     //Initialize pet published date
        private string p_status;        //Initialize pet status: 0 - active, 1 - inactive
        private int t_id;               //Initialize type id

        /// <summary>
        /// Initialize Pet Object
        /// </summary>
        /// <param name="p_id"></param>
        /// <param name="p_name"></param>
        /// <param name="price"></param>
        /// <param name="salePrice"></param>
        /// <param name="p_image"></param>
        /// <param name="p_description"></param>
        /// <param name="p_published"></param>
        /// <param name="p_status"></param>
        /// <param name="t_id"></param>
        public Pet(string p_id, string p_name, int p_price, int p_salePrice, string p_image, string p_description, string p_published,
            string p_status, int t_id)
        {
            this.P_ID = p_id;
            this.P_NAME = p_name;
            this.P_PRICE = p_price;
            this.P_SALEPRICE = p_salePrice;
            this.P_IMAGE = p_image;
            this.P_DESCRIPTION = p_description;
            this.P_PUBLISHED = p_published;
            this.P_STATUS = p_status;
            this.T_ID = t_id;
        }

        #region Pet Object Properties
        /// <summary>
        /// Properties Pet ID
        /// </summary>
        public string P_ID
        {
            get { return p_id; }

            set { p_id = value; }
        }

        /// <summary>
        /// Properties Pet Name
        /// </summary>
        public string P_NAME
        {
            get
            {
                return p_name;
            }

            set
            {
                p_name = value;
            }
        }

        /// <summary>
        /// Properties Pet Origin Price
        /// </summary>
        public int P_PRICE
        {
            get
            {
                return p_price;
            }

            set
            {
                p_price = value;
            }
        }

        /// <summary>
        /// Properties Pet Sell Price
        /// </summary>
        public int P_SALEPRICE
        {
            get
            {
                return p_salePrice;
            }

            set
            {
                p_salePrice = value;
            }
        }

        /// <summary>
        /// Properties Pet Image
        /// </summary>
        public string P_IMAGE
        {
            get
            {
                return p_image;
            }

            set
            {
                p_image = value;
            }
        }

        /// <summary>
        /// Properties Pet Description
        /// </summary>
        public string P_DESCRIPTION
        {
            get
            {
                return p_description;
            }

            set
            {
                p_description = value;
            }
        }

        /// <summary>
        /// Properties Pet Published Date
        /// </summary>
        public string P_PUBLISHED
        {
            get
            {
                return p_published;
            }

            set
            {
                p_published = value;
            }
        }

        /// <summary>
        /// Properties Pet Status
        /// </summary>
        public string P_STATUS
        {
            get
            {
                return p_status;
            }

            set
            {
                p_status = value;
            }
        }

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
        #endregion
    }
}
