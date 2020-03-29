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
    class PetFoodModel
    {
        ArrayList pfList;

        public PetFoodModel()
        {

        }

        /// <summary>
        /// set status item to Inactive
        /// </summary>
        /// <param name="pf_id"></param>
        public void DeletePetFood(String pf_id)
        {
            using (var db = new PetStoreEntities())
            {
                var Petfood = db.PetFoods.Find(pf_id);
                Petfood.pf_status = "Inactive";
                db.SaveChanges();
            }
        }

        /// <summary>
        /// set status item to Active
        /// </summary>
        /// <param name="pf_id"></param>
        public void RestorePetFood(String pf_id)
        {
            using (var db = new PetStoreEntities())
            {
                var Petfood = db.PetFoods.Find(pf_id);
                Petfood.pf_status = "Active";
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
                var select = from s in db.PetFoods orderby s.pf_id descending select s;
                var selectOne = select.Take(1);
                foreach (var data in selectOne)
                {
                    lastID = data.pf_id.ToString();
                }
            }
            if (lastID == "") { return "PFD0000"; }
            else { return lastID; }
        }

        /// <summary>
        /// update food by food id
        /// </summary>
        /// <param name="pfID"></param>
        /// <param name="pfName"></param>
        /// <param name="pfPrice"></param>
        /// <param name="pfPriceSell"></param>
        /// <param name="pfAmount"></param>
        /// <param name="typeID"></param>
        public void UpdateFood(String pfID, String pfName, int pfPrice, int pfPriceSell, int pfAmount, int typeID, String pfStatus, String pfImage)
        {
            using (var db = new PetStoreEntities())
            {
                var Petfood = db.PetFoods.Find(pfID);
                Petfood.pf_name = pfName;
                Petfood.pf_prices = pfPrice;
                Petfood.pf_image = pfImage;
                Petfood.pf_salePrice = pfPriceSell;
                Petfood.pf_amount = pfAmount;
                Petfood.t_id = typeID;
                Petfood.pf_status = pfStatus;
                db.SaveChanges();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pfId"></param>
        /// <returns></returns>
        public PetFood getPetFood(String pfId)
        {
            var db = new PetStoreEntities();
            var Petfood = db.PetFoods.Find(pfId);
            return Petfood;
        }
        /// <summary>
        /// get next id of item
        /// </summary>
        /// <returns></returns>
        public String getNextID()
        {
            String dID = "";
            dID = getLastID().Remove(0, 3);
            int id = Convert.ToInt32(dID) + 1;
            if (id < 10)
            {
                return "PFD000" + id;
            }
            else if (id >= 10 && id < 100)
            {
                return "PFD00" + id;
            }
            else if (id >= 100 && id < 1000)
            {
                return "PFD0" + id;
            }
            else
            {
                return "PFD" + id;
            }
        }

        /// <summary>
        /// get all food to arraylist
        /// </summary>
        /// <returns></returns>
        public ArrayList GetAllPetFoodToArrayList()
        {
            pfList = new ArrayList();
            using (var db = new PetStoreEntities())
            {
                //command LINQ
                var selectStr = (from f in db.PetFoods
                                 join t in db.Types on f.t_id equals t.t_id
                                 select new
                                 {
                                     f.pf_id,
                                     f.pf_name,
                                     f.pf_salePrice,
                                     f.pf_amount,
                                     t.t_name,
                                     f.pf_status
                                 });
                //set data to ArrayList
                foreach (var data in selectStr)
                {
                    //if number of item <= 0 Status will set equal 'Inactive'
                    if (data.pf_amount > 0)
                    {
                        pfList.Add(new Object.Food(data.pf_id, data.pf_name, Convert.ToInt32(data.pf_salePrice),
                                                   Convert.ToInt32(data.pf_amount), data.t_name, "Active"));
                    }
                    else
                    {
                        pfList.Add(new Object.Food(data.pf_id, data.pf_name, Convert.ToInt32(data.pf_salePrice), 
                                                   Convert.ToInt32(data.pf_amount), data.t_name, "Inactive"));
                    }
                }
            }
            return pfList;
        }

        /// <summary>
        /// Resize Image
        /// </summary>
        /// <param name="image"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
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
