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
    public partial class EditPet : DevExpress.XtraEditors.XtraForm
    {
        //Declare variables
        TypeModel tm = new TypeModel();
        List<PetStore.Type> tList = new List<Type>();
        string Status = "";

        public EditPet()
        {
            InitializeComponent();
        }

        public void loadComboBox()
        {
            tList = tm.getAllType();
            cbx_Type.Properties.DataSource = tList;
            cbx_Type.Properties.DisplayMember = "t_name";
        }

        private void btnSaveEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (te_PName.Text != "" && te_POriginPrice.Text != "" && te_PSalePrice.Text != ""
                && Status != "")
            {
                PetModel pm = new PetModel();
                TypeModel tm = new TypeModel();
                int pStatus = tm.getIDByTName(Status);
                String image = "";
                String oldImageName = pm.getPet(te_PID.Text).p_image;
                if (te_PImage.Text != "")
                {
                    if (openDialog.FileName.EndsWith(".jpg")) { image = te_PID.Text + ".jpg"; }
                    else { image = te_PID.Text + ".png"; }

                    //get solution Apps path
                    String projectPath = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\.."));
                    String oldAppFilePath = projectPath + "\\img\\" + oldImageName;
                    //delete old image file if exist
                    FileInfo fiApps = new FileInfo(oldAppFilePath);
                    if (fiApps.Exists)
                    {
                        File.Delete(oldAppFilePath);
                    }

                    //get solution path
                    String solutionPath = Directory.GetParent(projectPath).FullName; ;
                    String oldWebFilePath = solutionPath + "\\PetStoreWebClient\\Assets\\images\\" + oldImageName;
                    //delete old image file if exist
                    FileInfo fiWeb = new FileInfo(oldWebFilePath);
                    if (fiWeb.Exists)
                    {
                        File.Delete(oldWebFilePath);
                    }

                    //get image folder on Apps and Web
                    String newFileAppPath = Path.GetFullPath(projectPath + "\\img\\" + image);
                    String newFileWebPath = Path.GetFullPath(solutionPath + "\\PetStoreWebClient\\Assets\\images\\" + image);
                    //Copy image to 2 image folder
                    File.Copy(te_PImage.Text, newFileAppPath);
                    File.Copy(te_PImage.Text, newFileWebPath);
                }
                else
                {
                    image = oldImageName; //if no new image is seleted then don't change image file
                }

                //Update Pet on database
                pm.UpdatePet(te_PID.Text, te_PName.Text, Convert.ToInt32(te_POriginPrice.Text),
                         Convert.ToInt32(te_PSalePrice.Text), image, te_PDescription.Text,
                         te_PStatus.Text, pStatus);
                //Notify to user
                XtraMessageBox.Show("Edit successful !!!", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else    //send error message
            {
                XtraMessageBox.Show("Please fill in full information !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var db = new PetStoreEntities();
            var p = db.Pets.Find(te_PID.Text);
            te_PName.Text = p.p_name;
            te_PImage.Text = "";
            te_POriginPrice.Text = p.p_prices + "";
            te_PSalePrice.Text = p.p_salePrice + "";
            te_PStatus.SelectedItem = p.p_status;
            te_PDescription.Text = p.p_description;
        }

        private void btnCloseEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void EditPet_Load(object sender, EventArgs e)
        {
            loadComboBox();
        }

        private void cbx_Type_EditValueChanged(object sender, EventArgs e)
        {
            Status = cbx_Type.Text;
        }

        private void te_PImage_Click(object sender, EventArgs e)
        {
            openDialog.Filter = "Image files (*.jpg)|*.jpg|Image files (*.png)|*.png|All files (*.*)|*.*";
            openDialog.ShowDialog();
            if (openDialog.FileName != "" && (openDialog.FileName.EndsWith(".jpg") || openDialog.FileName.EndsWith(".png")))
            {
                te_PImage.Text = openDialog.FileName;
            }
            else
            {
                XtraMessageBox.Show("Please choose a image with (*.jpg)/(*.png) file !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}