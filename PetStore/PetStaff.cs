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
    public partial class PetStaff : DevExpress.XtraEditors.XtraForm
    {
        //declare variable 
        string petID = "";

        public PetStaff()
        {
            WindowsFormsSettings.ScrollUIMode = ScrollUIMode.Touch;
            InitializeComponent();
        }

        private void PetStaff_Load(object sender, EventArgs e)
        {
            PetModel pm = new PetModel();
            bsPet.DataSource = pm.getAllPet();
            gcPet.DataSource = bsPet;
        }

        private void btnRefreshFood_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PetStaff_Load(sender, e);
        }

        private void btnViewDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (petID != "")
            {
                DetailPetForm dtPet = new DetailPetForm();
                PetModel pm = new PetModel();

                Pet p = pm.getPet(petID);

                dtPet.txt_pID.Text = p.p_id;
                dtPet.txt_pName.Text = p.p_name;
                dtPet.txt_pOriginPrice.Text = p.p_prices.ToString();
                dtPet.txt_pPriceSale.Text = p.p_salePrice.ToString();
                dtPet.txt_Type.Text = "";

                if (p.p_status == "Active") { dtPet.txt_pStatus.ForeColor = Color.Green; }
                else { dtPet.txt_pStatus.ForeColor = Color.Red; }

                dtPet.txt_pStatus.Text = p.p_status;
                dtPet.txt_pOriginPrice.Enabled = true;
                dtPet.lblTitle.Text = p.p_name;

                String projectPath = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\.."));
                String pathImage = projectPath + "\\img\\" + p.p_image;
                Image img = Image.FromFile(pathImage);
                dtPet.ptbImage.Image = pm.ResizeImage(img, 440, 440);

                dtPet.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose a food to view detail !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gvPet_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int idx = gvPet.FocusedRowHandle;
            if (gvPet.GetRowCellValue(idx, gvPet.Columns[0]) != null)
            {
                petID = gvPet.GetRowCellValue(idx, gvPet.Columns[0]).ToString();
            }
            //XtraMessageBox.Show(petID);
        }
    }
}