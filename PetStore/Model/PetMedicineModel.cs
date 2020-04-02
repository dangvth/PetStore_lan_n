using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Model
{
    class PetMedicineModel
    {
        ArrayList pmList;

        public PetMedicineModel()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pm_id"></param>
        public void DeletePetMedicine(String pm_id)
        {
            using (var db = new PetStoreEntities())
            {
                var PetMedicine = db.PetMedicines.Find(pm_id);
                PetMedicine.pm_status = "Inactive";
                db.SaveChanges();
            }
        }

        public void RestorePetMedicine(String pm_id)
        {
            using (var db = new PetStoreEntities())
            {
                var PetMedicine = db.PetMedicines.Find(pm_id);
                PetMedicine.pm_status = "Active";
                db.SaveChanges();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public String getLastID()
        {
            String lastID = "";
            using (var db = new PetStoreEntities())
            {
                var select = from s in db.PetMedicines orderby s.pm_id descending select s;
                var selectOne = select.Take(1);
                foreach (var data in selectOne)
                {
                    lastID = data.pm_id.ToString();
                }
            }
            if (lastID == "") { return "PMD0000"; }
            else { return lastID; }
        }

        /// <summary>
        /// update food by food id
        /// </summary>
        /// <param name="pmID"></param>
        /// <param name="pmName"></param>
        /// <param name="pmPrice"></param>
        /// <param name="pmPriceSell"></param>
        /// <param name="pmAmount"></param>

        public void UpdateMedicint(String pmID, String pmName, String pmImage, int pmPrice, int pmSalePrices, int pmAmount, String pmDescription, String pmStatus)
        {
            using (var db = new PetStoreEntities())
            {
                var PetMedicine = db.PetMedicines.Find(pmID);
                PetMedicine.pm_name = pmName;
                PetMedicine.pm_image = pmImage;
                PetMedicine.pm_prices = pmPrice;
                PetMedicine.pm_salePrice = pmSalePrices;
                PetMedicine.pm_amount = pmAmount;
                PetMedicine.pm_description = pmDescription;
                PetMedicine.pm_status = pmStatus;
                db.SaveChanges();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pmId"></param>
        /// <returns></returns>
        public PetMedicine getPetMedicine(String pmId)
        {
            var db = new PetStoreEntities();
            var PetMedicine = db.PetMedicines.Find(pmId);
            return PetMedicine;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public String getNextID()
        {
            String dID = "";
            dID = getLastID().Remove(0, 3);
            int id = Convert.ToInt32(dID) + 1;
            if (id < 10)
            {
                return "PMD000" + id;
            }
            else if (id >= 10 && id < 100)
            {
                return "PMD00" + id;
            }
            else if (id >= 100 && id < 1000)
            {
                return "PMD0" + id;
            }
            else
            {
                return "PMD" + id;
            }
        }

        /// <summary>
        /// get all food to arraylist
        /// </summary>
        /// <returns></returns>
        public ArrayList GetAllPetMedicineToArrayList()
        {
            pmList = new ArrayList();
            using (var db = new PetStoreEntities())
            {
                var selectStr = (from m in db.PetMedicines

                                 select new
                                 {
                                     m.pm_id,
                                     m.pm_name,
                                     m.pm_salePrice,
                                     m.pm_amount,
                                     m.pm_description,
                                     m.pm_status
                                 });

                foreach (var data in selectStr)
                {
                    if (data.pm_amount > 0)
                    {
                        pmList.Add(new Object.Medicine(data.pm_id, data.pm_name, Convert.ToInt32(data.pm_salePrice),
                                                   Convert.ToInt32(data.pm_amount), data.pm_description, "Active"));
                    }
                    else
                    {
                        pmList.Add(new Object.Medicine(data.pm_id, data.pm_name, Convert.ToInt32(data.pm_salePrice),
                                                   Convert.ToInt32(data.pm_amount), data.pm_description, "Inactive"));
                    }
                }
            }
            return pmList;
        }

        public Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }
    }
}

