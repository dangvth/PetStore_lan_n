﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using PetStore.Model;
using System.IO;

namespace PetStore
{
    public partial class EditPetFood : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string selectedType = "";
        public EditPetFood()
        {
            InitializeComponent();
        }

        private void btnSaveEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (te_FoodName.Text != "" && te_FoodAmount.Text != "" 
                && te_FoodPrice.Text != "" && te_FoodSalePrice.Text != "")
            {
                PetFoodModel pfm = new PetFoodModel();
                String image = "";
                String oldImageName = pfm.getPetFood(te_FoodID.Text).pf_image;
                if (te_FoodImage.Text != "")
                {
                    //set text box image = ID + ".jpg" or ".png"
                    if (openDialog.FileName.EndsWith(".jpg")) { image = te_FoodID.Text + ".jpg"; }
                    else { image = te_FoodID.Text + ".png"; }

                    //get path app project
                    String projectPath = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\..")); 
                    //old image file path 
                    String oldFilePath = projectPath + "\\img\\" + oldImageName;
                    //delete old image file if exist
                    FileInfo f = new FileInfo(oldFilePath);
                    if (f.Exists)
                    {
                        File.Delete(oldFilePath);
                    }

                    //get solution path
                    String solutionPath = Directory.GetParent(projectPath).FullName;;
                    String oldWebFilePath = solutionPath + "\\PetStoreWebClient\\Assets\\images\\" + oldImageName;
                    //delete old image file if exist
                    FileInfo f2 = new FileInfo(oldWebFilePath);
                    if (f2.Exists)
                    {
                        File.Delete(oldWebFilePath);
                    }

                    //Get new image file path and copy it to image folder
                    String newFilepath = Path.GetFullPath(projectPath + "\\img\\" + image);
                    String newFileWebpath = Path.GetFullPath(solutionPath + "\\PetStoreWebClient\\Assets\\images\\" + image);
                    File.Copy(te_FoodImage.Text, newFileWebpath);
                    File.Copy(te_FoodImage.Text, newFilepath);
                }
                else
                {
                    //get old image if dont change image
                    image = oldImageName;
                }
                //update pet food on database
                var db = new PetStoreEntities();
                var typeID = (int)db.Types.FirstOrDefault(x => x.t_name == selectedType).t_id;
                pfm.UpdateFood(te_FoodID.Text, te_FoodName.Text, Convert.ToInt32(te_FoodPrice.Text),
                         Convert.ToInt32(te_FoodSalePrice.Text), Convert.ToInt32(te_FoodAmount.Text), typeID, te_FoodStatus.Text, image);
                //message success
                XtraMessageBox.Show("Edit successful !!!", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } else
            {
                XtraMessageBox.Show("Please fill in full information !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void te_FoodImage_Click(object sender, EventArgs e)
        {
            //set filter file choose - just show file image
            openDialog.Filter = "Image files (*.jpg)|*.jpg|Image files (*.png)|*.png|All files (*.*)|*.*";
            openDialog.ShowDialog();
            //check have choose file or not and file choose is a image file or not
            if (openDialog.FileName != "" && (openDialog.FileName.EndsWith(".jpg") || openDialog.FileName.EndsWith(".png")))
            {
                //set path file choose to text box
                te_FoodImage.Text = openDialog.FileName;
            }
            else
            {
                XtraMessageBox.Show("Please choose a image with (*.jpg)/(*.png) file !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_ItemClick(object sender, ItemClickEventArgs e)
        {
            var db = new PetStoreEntities();
            var pf = db.PetFoods.Find(te_FoodID.Text);
            //Reset old data to form
            te_FoodName.Text = pf.pf_name;
            te_FoodImage.Text = "";
            te_FoodPrice.Text = pf.pf_prices + "";
            te_FoodSalePrice.Text = pf.pf_salePrice + "";
            te_FoodStatus.SelectedItem = pf.pf_status;
            te_FoodAmount.Text = pf.pf_amount + "";
        }

        private void btnCloseEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void te_Type_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedType = te_Type.Text;
        }
    }
}