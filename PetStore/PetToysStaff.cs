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
    public partial class PetToysStaff : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        String ptIDSelected = "";
        public PetToysStaff()
        {
            InitializeComponent();
        }

        private void PetToysStaff_Load(object sender, EventArgs e)
        {
            
        }

        private void btndetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ptIDSelected != "")
            {
                DetailToys dts = new DetailToys();
                PetToyModel ptm = new PetToyModel();

                PetToy toy = ptm.getPetToy(ptIDSelected);

                dts.txtToysId.Text = toy.pt_id;
                dts.txtToysName.Text = toy.pt_name;
                dts.txtToySaleprices.Text = toy.pt_salePrice.ToString();
                dts.txtAmount.Text = toy.pt_amount.ToString();
                dts.txtDescript.Text = toy.pt_description;

                if (toy.pt_status == "Active") { dts.txtstatus.ForeColor = Color.Green; }
                else { dts.txtstatus.ForeColor = Color.Red; }

                dts.txtstatus.Text = toy.pt_status;

                dts.lblDetail.Text = "Pet's Toys detail for '" + toy.pt_name + "'";

                String projectPath = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\.."));
                String pathImage = projectPath + "\\img\\" + toy.pt_image;
                Image img = Image.FromFile(pathImage);
                dts.ptbimage.Image = ptm.ResizeImage(img, 200, 200);

                dts.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose a Toys to view detail !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnrefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            PetToyModel ptm = new PetToyModel();

            petStoreDataSet2BindingSource.DataSource = ptm.GetAllPetToysToArrayList();
           gcToys.DataSource = petStoreDataSet2BindingSource;
        }

        private void gcToys_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int idx = gridToys.FocusedRowHandle;
            if (gridToys.GetRowCellValue(idx, gridToys.Columns[0]) != null)
            {
                ptIDSelected = gridToys.GetRowCellValue(idx, gridToys.Columns[0]).ToString();
            }
        }

        private void gcToys_Load(object sender, EventArgs e)
        {
            PetToyModel ptm = new PetToyModel();
            petStoreDataSet2BindingSource.DataSource = ptm.GetAllPetToysToArrayList();
            gcToys.DataSource = petStoreDataSet2BindingSource;
        }
    }
}