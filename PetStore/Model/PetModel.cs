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

        /// <summary>
        /// Init class
        /// </summary>
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

        /// <summary>
        /// Get Pet and type add to list
        /// </summary>
        /// <returns></returns>
        public ArrayList getAllPet()
        {
            pList = new ArrayList();
            using (PetStoreEntities db = new PetStoreEntities())
            {
                //join 2 table Pets and Type on database and retrieve specific fields 
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

                //Add each result on query to list
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

        /// <summary>
        /// Update Pet
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Name"></param>
        /// <param name="OPrice"></param>
        /// <param name="SPrice"></param>
        /// <param name="image"></param>
        /// <param name="description"></param>
        /// <param name="status"></param>
        /// <param name="tID"></param>
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
            //get number of Pets on database
            int numOfPet = getNumberOfPet();
            string id = "";

            //ID = PET000x
            if (numOfPet < 9)
            {
                id = "PET000" + (numOfPet + 1);
            }
            else if (numOfPet < 99)     //ID = PET00xx
            {
                id = "PET00" + (numOfPet + 1);
            }
            else if (numOfPet < 999)    //ID = PET0xxx
            {
                id = "PET0" + (numOfPet + 1);
            }
            else    //ID = PETxxxx
            {
                id = "PET" + (numOfPet + 1);
            }
            return id;
        }

        /// <summary>
        /// Resize image based on specific width and height  
        /// </summary>
        /// <param name="image"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public Bitmap ResizeImage(Image image, int width, int height)
        {
            //Initializes a new frame Rectangle with specified location and size
            var destRect = new Rectangle(0, 0, width, height);
            //Initializes a new instance image with specificed size
            var destImage = new Bitmap(width, height);

            //set the resolution for new image
            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))    //Create new Image is destImage
            {
                //When a color is rendered, it overwrites the background color.
                graphics.CompositingMode = CompositingMode.SourceCopy;
                //Set image is high quality but low speed compositing
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
