using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Model
{
    class GiftModel
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public GiftModel()
        {

        }
        /// <summary>
        /// Get gift by ID
        /// </summary>
        /// <param name="gId"></param>
        /// <returns></returns>
        public Gift getGift(String gId)
        {
            var db = new PetStoreEntities();
            var Gift = db.Gifts.Find(gId);
            return Gift;
        }
        /// <summary>
        /// Resize image
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
        /// <summary>
        /// Gets last ID of gift list
        /// </summary>
        /// <returns></returns>
        public String getLastID()
        {
            String lastID = "";
            using (var db = new PetStoreEntities())
            {
                var select = from s in db.Gifts orderby s.g_id descending select s;
                var selectOne = select.Take(1);
                foreach (var data in selectOne)
                {
                    lastID = data.g_id.ToString();
                }
            }
            if (lastID == "") { return "GIF0000"; }
            else { return lastID; }
        }
        /// <summary>
        /// Gets next ID of gift list
        /// </summary>
        /// <returns></returns>
        public String getNextID()
        {
            String dID = "";
            dID = getLastID().Remove(0, 3);
            int id = Convert.ToInt32(dID) + 1;
            if (id < 10)
            {
                return "GIF000" + id;
            }
            else if (id >= 10 && id < 100)
            {
                return "GIF00" + id;
            }
            else if (id >= 100 && id < 1000)
            {
                return "GIF0" + id;
            }
            else
            {
                return "GIF" + id;
            }
        }
        /// <summary>
        /// Update gift
        /// </summary>
        /// <param name="gID"></param>
        /// <param name="gName"></param>
        /// <param name="gStatus"></param>
        /// <param name="gImage"></param>
        public void UpdateGift(String gID, String gName, String gStatus, String gImage)
        {
            using (var db = new PetStoreEntities())
            {
                var Gift = db.Gifts.Find(gID);
                Gift.g_name = gName;
                Gift.g_image = gImage;
                Gift.g_status = gStatus;
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Delete gift
        /// </summary>
        /// <param name="g_id"></param>
        public void DeleteGift(String g_id)
        {
            using (var db = new PetStoreEntities())
            {
                var Gift = db.Gifts.Find(g_id);
                Gift.g_status = "Inactive";
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Restore gift
        /// </summary>
        /// <param name="g_id"></param>
        public void RestoreGift(String g_id)
        {
            using (var db = new PetStoreEntities())
            {
                var Gift = db.Gifts.Find(g_id);
                Gift.g_status = "Active";
                db.SaveChanges();
            }
        }
    }

}
