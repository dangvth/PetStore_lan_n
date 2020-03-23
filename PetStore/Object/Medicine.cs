using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Object
{
    class Medicine
    {
       
            private String pm_id;
            private String pm_name;
            private String pm_image;
            private int pm_prices;
            private int pm_salePrice;
            private int pm_amount;
            private String pm_description;
            private String pm_status;

            public string PetMedicineID
            {
                get
                {
                    return pm_id;
                }

                set
                {
                    pm_id = value;
                }
            }

            public string PetMedicineName
            {
                get
                {
                    return pm_name;
                }

                set
                {
                    pm_name = value;
                }
            }

            public int SalePrice
            {
                get
                {
                    return pm_salePrice;
                }

                set
                {
                    pm_salePrice = value;
                }
            }

            public int Amount
            {
                get
                {
                    return pm_amount;
                }

                set
                {
                    pm_amount = value;
                }
            }

            public string Description
            {
                get
                {
                    return pm_description;
                }

                set
                {
                    pm_description = value;
                }
            }

            public string PetMedicineStatus
            {
                get
                {
                    return pm_status;
                }

                set
                {
                    pm_status = value;
                }
            }

            public Medicine(String pmID, String pmName, int pmSalePrices, int pmAmount, String pmDescription, String pmStatus)
            {
                pm_id = pmID;
                pm_name = pmName;
                pm_salePrice = pmSalePrices;
                pm_amount = pmAmount;
                pm_description = pmDescription;
                pm_status = pmStatus;
            }
        }
    
}
