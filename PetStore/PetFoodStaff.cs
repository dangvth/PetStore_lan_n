using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using PetStore.Model;
using System.IO;

namespace PetStore
{
    public partial class PetFoodStaff : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        String IDSelected = "";

        public PetFoodStaff()
        {
            InitializeComponent();
        }

        private void PetFoodStaff_Load(object sender, EventArgs e)
        {
            PetFoodModel pfm = new PetFoodModel();
            bindingSourceFood.DataSource = pfm.GetAllPetFoodToArrayList();
            gcFood.DataSource = bindingSourceFood;
        }

        private void btnRefreshFood_ItemClick(object sender, ItemClickEventArgs e)
        {
            PetFoodStaff_Load(sender, e);
        }

        private void btnViewDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IDSelected != "")
            {
                DetailPetFoodForm vdf = new DetailPetFoodForm();
                PetFoodModel pfm = new PetFoodModel();
                PetFood f = pfm.getPetFood(IDSelected);
                vdf.te_pfID.Text = f.pf_id;
                vdf.te_pfName.Text = f.pf_name;
                vdf.te_pfPriceSale.Text = f.pf_salePrice.ToString();
                vdf.te_pfAmount.Text = f.pf_amount.ToString();
                vdf.te_Type.Text = "Pet's Food";
                if (f.pf_status == "Active") { vdf.te_pfStatus.ForeColor = Color.Green; }
                else { vdf.te_pfStatus.ForeColor = Color.Red; }
                vdf.te_pfStatus.Text = f.pf_status;
                vdf.te_pfPrice.Enabled = false;
                vdf.lblTitle.Text = f.pf_name;
                String projectPath = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\.."));
                String pathImage = projectPath + "\\img\\" + f.pf_image;
                Image img = Image.FromFile(pathImage);
                vdf.ptbImage.Image = pfm.ResizeImage(img, 440, 440);
                vdf.ShowDialog();
            } else
            {
                MessageBox.Show("Please choose a food to view detail !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void gvFood_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int idx = gvFood.FocusedRowHandle;
            if (gvFood.GetRowCellValue(idx, gvFood.Columns[0]) != null)
            {
                IDSelected = gvFood.GetRowCellValue(idx, gvFood.Columns[0]).ToString();
            }
        }
    }
}