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
        private int p_price;            //Initialize pet origin price
        private int p_salePrice;        //Initialize pet sell price
        private string p_image;         //Initialize pet image
        private string p_description;   //Initialize pet description
        private string p_published;     //Initialize pet published date
        private string p_status;        //Initialize pet status: 0 - active, 1 - inactive
        private string t_id;            //Initialize type id
        private string t_name;          //Initialize type name

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
        public Pet(string p_id, string p_name, int p_salePrice, string p_description, 
            string p_status, string t_name)
        {
            this.ID = p_id;
            this.Name = p_name;
            this.Price = p_salePrice;
            this.Description = p_description;
            this.Status = p_status;
            this.Type = t_name;
        }

        #region Pet Object Properties
        /// <summary>
        /// Properties Pet ID
        /// </summary>
        public string ID
        {
            get { return p_id; }

            set { p_id = value; }
        }

        /// <summary>
        /// Properties Pet Name
        /// </summary>
        public string Name
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
        

        /// <summary>
        /// Properties Pet Sell Price
        /// </summary>
        public int Price
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
        

        /// <summary>
        /// Properties Pet Description
        /// </summary>
        public string Description
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
        

        /// <summary>
        /// Properties Pet Status
        /// </summary>
        public string Status
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
        
        /// <summary>
        /// Properties Type name
        /// </summary>
        public string Type
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
        #endregion
    }
}
