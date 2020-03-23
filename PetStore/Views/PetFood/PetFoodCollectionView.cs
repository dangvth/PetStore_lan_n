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

namespace PetStore.Views.PetFoodCollectionView{
    public partial class PetFoodCollectionView : XtraUserControl {
        private String pfIDSelected = "";
        public PetFoodCollectionView() {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings() {
			mvvmContext.RegisterService(WindowedDocumentManagerService.Create(this));
            var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.PetFoodCollectionViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            // We want to show the Entities collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(gridControl, gControl => gControl.DataSource, x => x.Entities);
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
                    args => args.Row as PetStore.PetFood,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
			//We want to show ribbon print preview when bbiPrintPreview clicked
			bbiPrintPreview.ItemClick += (s, e) => { gridControl.ShowRibbonPrintPreview(); };
			//We want to show RECORDS count on BarStaticItem
			fluentAPI.SetBinding(bsiRecordsCount, item => item.Caption,	x => x.Entities.Count, 
					count => string.Format("RECORDS : {0}", count));
			//We want to show PopupMenu when row clicked by right button
			gridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    popupMenu.ShowPopup(gridControl.PointToScreen(e.Location), s);
                }
            };
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (pfIDSelected != "")
            {
                PetFoodModel pfm = new PetFoodModel();
                pfm.DeletePetFood(pfIDSelected);
                XtraMessageBox.Show("Delete successful !!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                XtraMessageBox.Show("Please choose a food item to delete !!!", "Warning",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView_RowClick(object sender, RowClickEventArgs e)
        {
            int idx = gridView.FocusedRowHandle;
            pfIDSelected = gridView.GetRowCellValue(idx, "pf_id").ToString();
        }

        private void bbiRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (pfIDSelected != "")
            {
                PetFoodModel pfm = new PetFoodModel();
                pfm.RestorePetFood(pfIDSelected);
                XtraMessageBox.Show("Restore successful !!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Please choose a food item to restore !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (pfIDSelected != "")
            {
                EditPetFood epf = new EditPetFood();
                var db = new PetStoreEntities();
                var pf = db.PetFoods.Find(pfIDSelected);
                epf.te_FoodID.Text = pf.pf_id;
                epf.te_FoodName.Text = pf.pf_name;
                //epf.te_FoodImage.Text = pf.pf_image;
                epf.te_FoodPrice.Text = pf.pf_prices + "";
                epf.te_FoodSalePrice.Text = pf.pf_salePrice + "";
                epf.te_FoodStatus.SelectedItem = pf.pf_status;
                epf.te_FoodAmount.Text = pf.pf_amount + "";
                epf.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Please choose a food item to restore !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (pfIDSelected != "")
            {
                DetailPetFoodForm vdf = new DetailPetFoodForm();
                PetFoodModel pfm = new PetFoodModel();

                PetFood f = pfm.getPetFood(pfIDSelected);

                vdf.te_pfID.Text = f.pf_id;
                vdf.te_pfName.Text = f.pf_name;
                vdf.te_pfPriceSale.Text = f.pf_salePrice.ToString();
                vdf.te_pfAmount.Text = f.pf_amount.ToString();
                vdf.te_Type.Text = "Pet's Food";

                if (f.pf_status == "Active") { vdf.te_pfStatus.ForeColor = Color.Green; }
                else { vdf.te_pfStatus.ForeColor = Color.Red; }

                vdf.te_pfStatus.Text = f.pf_status;
                vdf.te_pfPrice.Enabled = true;
                vdf.te_pfPrice.Text = f.pf_prices.ToString();
                vdf.lblTitle.Text = "Pet's Food detail for '" + f.pf_name + "'";

                String projectPath = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\.."));
                String pathImage = projectPath + "\\img\\" + f.pf_image;
                Image img = Image.FromFile(pathImage);
                vdf.ptbImage.Image = pfm.ResizeImage(img, 440, 440);

                vdf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose a food to view detail !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
