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
    public partial class PetMedicineStaff : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        String pmIDSelected = "";
        public PetMedicineStaff()
        {
            InitializeComponent();
        }

        private void PetMedicineStaff_Load(object sender, EventArgs e)
        {
            PetMedicineModel pmm = new PetMedicineModel();
            medicinedataBindingSource.DataSource = pmm.GetAllPetMedicineToArrayList();
            gcMedicine.DataSource = medicinedataBindingSource;
        }

        private void btnDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (pmIDSelected != "")
            {
                DetailMedicine dmd = new DetailMedicine();
                PetMedicineModel pmm = new PetMedicineModel();

                PetMedicine med = pmm.getPetMedicine(pmIDSelected);

                dmd.txtPmdId.Text = med.pm_id;
                dmd.txtPmdName.Text = med.pm_name;
                dmd.txtPmdSaleprices.Text = med.pm_salePrice.ToString();
                dmd.txtPmdAmount.Text = med.pm_amount.ToString();
                dmd.txtPmdDescript.Text = med.pm_description;

                if (med.pm_status == "Active") { dmd.txtPmdStatus.ForeColor = Color.Green; }
                else { dmd.txtPmdStatus.ForeColor = Color.Red; }

                dmd.txtPmdStatus.Text = med.pm_status;

                dmd.lbldetail.Text = "Pet's Medicine detail for '" + med.pm_name + "'";

                String projectPath = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\.."));
                String pathImage = projectPath + "\\img\\" + med.pm_image;
                Image img = Image.FromFile(pathImage);
                dmd.ptbimage.Image = pmm.ResizeImage(img, 200, 200);

                dmd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose a Medicine to view detail !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            PetMedicineModel pmm = new PetMedicineModel();

            petStoreDataSet3BindingSource.DataSource = pmm.GetAllPetMedicineToArrayList();
            gcMedicine.DataSource = petStoreDataSet3BindingSource;
        }

        private void gcMedicine_Click(object sender, EventArgs e)
        {
            int idx = tblMed.FocusedRowHandle;
            if (tblMed.GetRowCellValue(idx, tblMed.Columns[0]) != null)
            {
                pmIDSelected = tblMed.GetRowCellValue(idx, tblMed.Columns[0]).ToString();
            }
        }
    }

   
}