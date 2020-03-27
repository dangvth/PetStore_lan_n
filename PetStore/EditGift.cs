using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PetStore.Model;
using System.IO;

namespace PetStore
{
    public partial class EditGift : DevExpress.XtraEditors.XtraForm
    {
        public EditGift()
        {
            InitializeComponent();
        }

        private void btnSaveEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_gName.Text != "")
            {
                GiftModel gm = new GiftModel();
                String image = "";
                String oldImageName = gm.getGift(txt_gID.Text).g_image;
                if (txt_gImage.Text != "")
                {
                    if (openDialog.FileName.EndsWith(".jpg")) { image = txt_gID.Text + ".jpg"; }
                    else { image = txt_gID.Text + ".png"; }

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
                    String solutionPath = Directory.GetParent(projectPath).FullName; ;
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
                    File.Copy(txt_gImage.Text, newFileWebpath);
                    File.Copy(txt_gImage.Text, newFilepath);
                }
                else
                {
                    image = oldImageName;
                }
                gm.UpdateGift(txt_gID.Text, txt_gName.Text, txt_gStatus.Text, image);
                XtraMessageBox.Show("Edit successful !!!", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Please fill in full information !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_gImage_Click(object sender, EventArgs e)
        {
            openDialog.Filter = "Image files (*.jpg)|*.jpg|Image files (*.png)|*.png|All files (*.*)|*.*";
            openDialog.ShowDialog();
            if (openDialog.FileName != "" && (openDialog.FileName.EndsWith(".jpg") || openDialog.FileName.EndsWith(".png")))
            {
                txt_gImage.Text = openDialog.FileName;
            }
            else
            {
                XtraMessageBox.Show("Please choose a image with (*.jpg)/(*.png) file !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var db = new PetStoreEntities();
            var g = db.Gifts.Find(txt_gID.Text);
            txt_gName.Text = g.g_name;
            txt_gImage.Text = "";
            txt_gStatus.SelectedItem = g.g_status;
        }

        private void btnCloseEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}