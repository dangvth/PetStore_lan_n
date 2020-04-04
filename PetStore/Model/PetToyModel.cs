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
    class PetToyModel
    {
        ArrayList ptList;

        public PetToyModel()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pt_id"></param>
        public void DeletePetToys(String pt_id)
        {
            using (var db = new PetStoreEntities())
            {
                var PetToys = db.PetToys.Find(pt_id);
                PetToys.pt_status = "Inactive";
                db.SaveChanges();
            }
        }

        public void RestorePetToys(String pt_id)
        {
            using (var db = new PetStoreEntities())
            {
                var PetToys = db.PetToys.Find(pt_id);
                PetToys.pt_status = "Active";
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
                var select = from s in db.PetToys orderby s.pt_id descending select s;
                var selectOne = select.Take(1);
                foreach (var data in selectOne)
                {
                    lastID = data.pt_id.ToString();
                }
            }
            if (lastID == "") { return "PTS0000"; }
            else { return lastID; }
        }

        /// <summary>
        /// update food by food id
        /// </summary>
        /// <param name="ptID"></param>
        /// <param name="ptName"></param>
        /// <param name="ptPrice"></param>
        /// <param name="ptPriceSell"></param>
        /// <param name="ptAmount"></param>

        public void UpdateToys(String ptID, String ptName, String ptImage, int ptPrice, int ptSalePrices, int ptAmount, String ptDescription, String ptStatus)
        {
            using (var db = new PetStoreEntities())
            {
                var PetToys = db.PetToys.Find(ptID);
                PetToys.pt_name = ptName;
                PetToys.pt_image = ptImage;
                PetToys.pt_prices = ptPrice;
                PetToys.pt_salePrice = ptSalePrices;
                PetToys.pt_amount = ptAmount;
                PetToys.pt_description = ptDescription;
                PetToys.pt_status = ptStatus;
                db.SaveChanges();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ptId"></param>
        /// <returns></returns>
        public PetToy getPetToy(String ptId)
        {
            var db = new PetStoreEntities();
            var PetToys = db.PetToys.Find(ptId);
            return PetToys;
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
                return "PTS000" + id;
            }
            else if (id >= 10 && id < 100)
            {
                return "PTS00" + id;
            }
            else if (id >= 100 && id < 1000)
            {
                return "PTS0" + id;
            }
            else
            {
                return "PTS" + id;
            }
        }

        /// <summary>
        /// get all food to arraylist
        /// </summary>
        /// <returns></returns>
        public ArrayList GetAllPetToysToArrayList()
        {
            ptList = new ArrayList();
            using (var db = new PetStoreEntities())
            {
                var selectStr = (from m in db.PetToys
                                 select new
                                 {
                                     m.pt_id,
                                     m.pt_name,
                                     m.pt_salePrice,
                                     m.pt_amount,
                                     m.pt_description,
                                     m.pt_status
                                 });

                foreach (var data in selectStr)
                {
                    if (data.pt_amount > 0)
                    {
                        ptList.Add(new Object.Toys(data.pt_id, data.pt_name, Convert.ToInt32(data.pt_salePrice),
                                                   Convert.ToInt32(data.pt_amount), data.pt_description, "Active"));
                    }
                    else
                    {
                        ptList.Add(new Object.Toys(data.pt_id, data.pt_name, Convert.ToInt32(data.pt_salePrice),
                                                   Convert.ToInt32(data.pt_amount), data.pt_description, "Inactive"));
                    }
                }
            }
            return ptList;
        }
        // resize image
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
