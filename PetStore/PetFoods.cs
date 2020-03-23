using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    class PetFoods
    {
        private String pf_id;
        private String pf_name;
        private String pf_image;
        private int pf_price;
        private int pf_sellPrice;
        private int pf_amount;
        private String pf_status;
        private int t_id;

        public string Pf_id
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

        public string Pf_name
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

        public string Pf_image
        {
            get
            {
                return pf_image;
            }

            set
            {
                pf_image = value;
            }
        }

        public int Pf_price
        {
            get
            {
                return pf_price;
            }

            set
            {
                pf_price = value;
            }
        }

        public int Pf_sellPrice
        {
            get
            {
                return pf_sellPrice;
            }

            set
            {
                pf_sellPrice = value;
            }
        }

        public int Pf_amount
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

        public string Pf_status
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

        public int T_id
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

        public PetFoods(String pfId, String pfName, String pfImage, int pfPrice, int pfsellPrice, int pfAmount, String pfStatus, int tId)
        {
            Pf_id = pfId;
            Pf_name = pfName;
            Pf_image = pfImage;
            Pf_price = pfPrice;
            Pf_sellPrice = pfsellPrice;
            Pf_amount = pfAmount;
            Pf_status = pfStatus;
            T_id = tId;
        }
    }
}
