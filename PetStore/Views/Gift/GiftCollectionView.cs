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

namespace PetStore.Views.GiftCollectionView{
    public partial class GiftCollectionView : XtraUserControl {
        private String gIDSelected = "";
        public GiftCollectionView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings() {
			mvvmContext.RegisterService(WindowedDocumentManagerService.Create(this));
            var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.GiftCollectionViewModel>();
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
                    args => args.Row as PetStore.Gift,
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

        private void bbiDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gIDSelected != "")
            {
                DetailGift dg = new DetailGift();
                GiftModel gm = new GiftModel();

                Gift g = gm.getGift(gIDSelected);

                dg.txt_pID.Text = g.g_id;
                dg.txt_gName.Text = g.g_name;
                dg.txt_gStatus.Text = g.g_status;

                if (g.g_status == "Active")
                {
                    dg.txt_gStatus.ForeColor = Color.Green;
                    dg.txt_gStatus.Text = g.g_status;
                }
                else
                {
                    dg.txt_gStatus.ForeColor = Color.Red;
                    dg.txt_gStatus.Text = g.g_status;
                }

                dg.lblTitle.Text = g.g_name;

                String projectPath = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\.."));
                String pathImage = projectPath + "\\img\\" + g.g_image;
                Image img = Image.FromFile(pathImage);
                dg.ptbImage.Image = gm.ResizeImage(img, 440, 440);

                dg.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose a gift to view detail !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView_RowClick(object sender, RowClickEventArgs e)
        {
            int idx = gridView.FocusedRowHandle;
            gIDSelected = gridView.GetRowCellValue(idx, "g_id").ToString();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gIDSelected != "")
            {
                EditGift eg = new EditGift();
                var db = new PetStoreEntities();
                var g = db.Gifts.Find(gIDSelected);
                eg.txt_gID.Text = g.g_id;
                eg.txt_gName.Text = g.g_name;
                eg.txt_gStatus.Text = g.g_status;
                //epf.te_FoodImage.Text = pf.pf_image;
                eg.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Please choose a gift item to restore !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gIDSelected != "")
            {
                GiftModel gm = new GiftModel();
                gm.DeleteGift(gIDSelected);
                XtraMessageBox.Show("Delete successful !!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Please choose a gift item to delete !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bbiRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gIDSelected != "")
            {
                GiftModel gm = new GiftModel();
                gm.RestoreGift(gIDSelected);
                XtraMessageBox.Show("Restore successful !!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Please choose a gift item to restore !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
