using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace PetStore.Model
{
    class PetModel
    {
        //declare PET variables
        PetStoreEntities db = new PetStoreEntities();
        ArrayList pList;
        public PetModel() { }

        /// <summary>
        /// get number of Pets on database
        /// </summary>
        /// <returns></returns>
        public int getNumberOfPet()
        {
            //get number of pet on database
            var numOfPet = from p in db.Pets select p;
            return numOfPet.Count();
        }

        public ArrayList getAllPet()
        {
            pList = new ArrayList();
            using (PetStoreEntities db = new PetStoreEntities())
            {
                var query = (from p in db.Pets
                             join t in db.Types on p.t_id equals t.t_id
                             select new
                             {
                                 p.p_id,
                                 p.p_name,
                                 p.p_salePrice,
                                 p.p_description,
                                 p.p_status,
                                 t.t_name
                             });
                foreach (var item in query)
                {
                    pList.Add(new Object.Pet(item.p_id, item.p_name,
                        Convert.ToInt32(item.p_salePrice), item.p_description, item.p_status,
                        item.t_name));
                }
            }
            return pList;
        }

        /// <summary>
        /// Get Pets by ID
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public Pet getPet(String pId)
        {
            var db = new PetStoreEntities();
            var Pet = db.Pets.Find(pId);
            return Pet;
        }

        public void UpdatePet(string ID, string Name, int OPrice, int SPrice, string image,
            string description, string status, int tID)
        {
            using (var db = new PetStoreEntities())
            {
                var Pet = db.Pets.Find(ID);
                Pet.p_name = Name;
                Pet.p_prices = OPrice;
                Pet.p_image = image;
                Pet.p_salePrice = SPrice;
                Pet.t_id = tID;
                Pet.p_status = status;
                Pet.p_description = description;
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Delete - Inactive Pet
        /// </summary>
        /// <param name="id"></param>
        public void InactivePet(string id)
        {
            Pet p = db.Pets.Where(pet => pet.p_id == id).SingleOrDefault();
            p.p_status = "Inactive";
            db.SaveChanges();
        }

        /// <summary>
        /// Restore or active Pet
        /// </summary>
        /// <param name="id"></param>
        public void RestorePet(string id)
        {
            Pet p = db.Pets.Where(pet => pet.p_id == id).SingleOrDefault();
            p.p_status = "Active";
            db.SaveChanges();
        }

        /// <summary>
        /// Set Pet ID for text edit
        /// </summary>
        /// <param name="txtPetID"></param>
        public string SetPetID()
        {
            int numOfPet = getNumberOfPet();
            string id = "";
            if (numOfPet < 9)
            {
                id = "PET000" + (numOfPet + 1);
            }
            else if (numOfPet < 99)
            {
                id = "PET00" + (numOfPet + 1);
            }
            else if (numOfPet < 999)
            {
                id = "PET0" + (numOfPet + 1);
            }
            else
            {
                id = "PET" + (numOfPet + 1);
            }
            return id;
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
