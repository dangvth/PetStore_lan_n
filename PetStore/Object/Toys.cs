using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Object
{
    class Toys
    {

        private String pt_id;
        private String pt_name;
        private String pt_image;
        private int pt_prices;
        private int pt_salePrice;
        private int pt_amount;
        private String pt_description;
        private String pt_status;

        public string PetToysID
        {
            get
            {
                return pt_id;
            }

            set
            {
                pt_id = value;
            }
        }

        public string PetToysName
        {
            get
            {
                return pt_name;
            }

            set
            {
                pt_name = value;
            }
        }

        public int SalePrice
        {
            get
            {
                return pt_salePrice;
            }

            set
            {
                pt_salePrice = value;
            }
        }

        public int Amount
        {
            get
            {
                return pt_amount;
            }

            set
            {
                pt_amount = value;
            }
        }

        public string Description
        {
            get
            {
                return pt_description;
            }

            set
            {
                pt_description = value;
            }
        }

        public string PetToysStatus
        {
            get
            {
                return pt_status;
            }

            set
            {
                pt_status = value;
            }
        }

        public Toys(String ptID, String ptName, int ptSalePrices, int ptAmount, String ptDescription, String ptStatus)
        {
            pt_id = ptID;
            pt_name = ptName;
            pt_salePrice = ptSalePrices;
            pt_amount = ptAmount;
            pt_description = ptDescription;
            pt_status = ptStatus;
        }
    }
}
