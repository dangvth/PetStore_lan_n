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
        public GiftModel()
        {

        }
        public Gift getGift(String gId)
        {
            var db = new PetStoreEntities();
            var Gift = db.Gifts.Find(gId);
            return Gift;
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
        public void DeleteGift(String g_id)
        {
            using (var db = new PetStoreEntities())
            {
                var Gift = db.Gifts.Find(g_id);
                Gift.g_status = "Inactive";
                db.SaveChanges();
            }
        }
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
