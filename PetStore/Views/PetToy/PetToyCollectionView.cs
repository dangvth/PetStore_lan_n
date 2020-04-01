using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars;
using PetStore.Model;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PetStore.Views.PetToyCollectionView{
    public partial class PetToyCollectionView : XtraUserControl {
        private String ptIDSelected = "";
        public PetToyCollectionView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings() {
			mvvmContext.RegisterService(WindowedDocumentManagerService.Create(this));
            var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.PetToyCollectionViewModel>();
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
                    args => args.Row as PetStore.PetToy,
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
            if (ptIDSelected != "")
            {
                PetToysModel ptm = new PetToysModel();
                ptm.DeletePetToys(ptIDSelected);
                XtraMessageBox.Show("Delete successful !!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Please choose  Toys item to delete !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bbiRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ptIDSelected != "")
            {
                PetToysModel ptm = new PetToysModel();
                ptm.RestorePetToys(ptIDSelected);
                XtraMessageBox.Show("Restore successful !!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Please choose Toys item to restore !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ptIDSelected != "")
            {
                DetailToys dts = new DetailToys();
                PetToysModel ptm = new PetToysModel();

                PetToy toy = ptm.getPetToys(ptIDSelected);

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
                dts.ptbimage.Image = ptm.ResizeImage(img, 440, 440);

                dts.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose a Toys to view detail !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView_RowClick(object sender, RowClickEventArgs e)
        {
            int idx = gridView.FocusedRowHandle;
            ptIDSelected = gridView.GetRowCellValue(idx, "pt_id").ToString();
        }
    }
}
