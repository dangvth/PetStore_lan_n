using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Object
{
    class Food
    {
        private String pf_id;
        private String pf_name;
        private String pf_image;
        private int pf_prices;
        private int pf_salePrice;
        private int pf_amount;
        private int t_id;
        private String t_name;
        private String pf_status;

        public string PetFoodID
        {
            get
            {
                return pf_id;
            }

            set
            {
                pf_id = value;
            }
        }

        public string FoodName
        {
            get
            {
                return pf_name;
            }

            set
            {
                pf_name = value;
            }
        }

        public int SalePrice
        {
            get
            {
                return pf_salePrice;
            }

            set
            {
                pf_salePrice = value;
            }
        }

        public int Amount
        {
            get
            {
                return pf_amount;
            }

            set
            {
                pf_amount = value;
            }
        }

        public string TypeName
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

        public string PetFoodStatus
        {
            get
            {
                return pf_status;
            }

            set
            {
                pf_status = value;
            }
        }

        public Food(String pfID, String pfName, int pfSellPrices, int pfAmount, String tName, String pfStatus)
        {
            pf_id = pfID;
            pf_name = pfName;
            pf_salePrice = pfSellPrices;
            pf_amount = pfAmount;
            t_name = tName;
            pf_status = pfStatus;
        }
    }
}
