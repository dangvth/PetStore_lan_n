using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars;
using PetStore.Model;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace PetStore.Views.PetMedicineCollectionView{
    public partial class PetMedicineCollectionView : XtraUserControl {
        private String pmIDSelected = "";
        public PetMedicineCollectionView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings() {
			mvvmContext.RegisterService(WindowedDocumentManagerService.Create(this));
            var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.PetMedicineCollectionViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            // We want to show the Entities collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(W, gControl => gControl.DataSource, x => x.Entities);
			// We want to show loading-indicator when data is loading asynchronously
            fluentAPI.SetBinding(gridView, gView => gView.LoadingPanelVisible, x => x.IsLoading);
						// We want to proceed the Edit command when row double-clicked
            fluentAPI.WithEvent<RowClickEventArgs>(gridView, "RowClick").EventToCommand(
                    x => x.Edit(null),
					x => x.SelectedEntity,
                    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(gridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity,
                    args => args.Row as PetStore.PetMedicine,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
			//We want to show ribbon print preview when bbiPrintPreview clicked
			bbiPrintPreview.ItemClick += (s, e) => { W.ShowRibbonPrintPreview(); };
			//We want to show RECORDS count on BarStaticItem
			fluentAPI.SetBinding(bsiRecordsCount, item => item.Caption,	x => x.Entities.Count, 
					count => string.Format("RECORDS : {0}", count));
			//We want to show PopupMenu when row clicked by right button
			gridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    popupMenu.ShowPopup(W.PointToScreen(e.Location), s);
                }
            };
        }
        //Button delete, Set status to inactive 
        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (pmIDSelected != "")
            {
                PetMedicineModel pmm = new PetMedicineModel();
                pmm.DeletePetMedicine(pmIDSelected);
                XtraMessageBox.Show("Delete successful !!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Please choose  Medicine item to delete !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //grid view rowclick
        private void gridView_RowClick(object sender, RowClickEventArgs e)
        {
            int idx = gridView.FocusedRowHandle;
            pmIDSelected = gridView.GetRowCellValue(idx, "pm_id").ToString();
        }
        //button restore set status to active
        private void bbiRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (pmIDSelected != "")
            {
                PetFoodModel pfm = new PetFoodModel();
                pfm.RestorePetFood(pmIDSelected);
                XtraMessageBox.Show("Restore successful !!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Please choose Medicine item to restore !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //button detail product
        private void btndetail_ItemClick(object sender, ItemClickEventArgs e)
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

        //private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    if (pmIDSelected != "")
        //    {
        //        EditMedicine edm = new EditMedicine();
        //        var db = new PetStoreEntities();
        //        var pm = db.PetMedicines.Find(pmIDSelected);
        //        edm.txtPmdId.Text = pm.pm_id;
        //        edm.txtPmdname.Text = pm.pm_name;
                
        //        edm.txtPmdprices.Text = pm.pm_prices + "";
        //        edm.txtPmdsaleprices.Text = pm.pm_salePrice + "";
        //        edm.txtPmdDescript.Text = pm.pm_description ;
        //        edm.cbbstatus.SelectedItem = pm.pm_status;
        //        edm.txtPmdamount.Text = pm.pm_amount + "";
        //        edm.ShowDialog();
        //    }
        //    else
        //    {
        //        XtraMessageBox.Show("Please choose a Medicine item to Edit !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}
    }
}
