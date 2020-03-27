using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars;
using System.Windows.Forms;

namespace PetStore.Views.UserCollectionView{
    public partial class UserCollectionView : XtraUserControl {
        private String uIDSelected = "";
        public UserCollectionView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings() {
			mvvmContext.RegisterService(WindowedDocumentManagerService.Create(this));
            var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.UserCollectionViewModel>();
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
                    args => args.Row as PetStore.User,
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

        private void gridView_RowClick(object sender, RowClickEventArgs e)
        {
            int index = gridView.FocusedRowHandle;
            uIDSelected = gridView.GetRowCellValue(index, "u_id").ToString();
            string status = gridView.GetRowCellValue(index, "u_status").ToString();
            if (status.Equals("Active"))
            {
                bbiDelete.Enabled = true;
                bbiRestore.Enabled = false;
            }
            else
            {
                bbiDelete.Enabled = false;
                bbiRestore.Enabled = true;
            }
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            int index = gridView.FocusedRowHandle;
            int id = int.Parse(gridView.GetRowCellValue(index, "u_id").ToString());
            using (var db = new PetStoreEntities())
            {
                var update = (from u in db.Users where u.u_id == id select u).Single();
                update.u_status = "Inactive";
                db.SaveChanges();
            }
            bbiDelete.Enabled = false;
            
        }

        private void bbiRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            int index = gridView.FocusedRowHandle;
            int id = int.Parse(gridView.GetRowCellValue(index, "u_id").ToString());
            using (var db = new PetStoreEntities())
            {
                var update = (from u in db.Users where u.u_id == id select u).Single();
                update.u_status = "Active";
                db.SaveChanges();
            }
            bbiRestore.Enabled = false;
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (uIDSelected != "")
            {
                EditUser eu = new EditUser();
                var db = new PetStoreEntities();
                var u = db.Users.Find(int.Parse(uIDSelected));
                eu.txt_uID.Text = u.u_id.ToString();
                eu.txt_uName.Text = u.u_name;
                eu.txt_uGender.Text = u.u_gender;
                eu.txt_uMail.Text = u.u_email;
                eu.txt_uPhone.Text = u.u_phone;
                eu.txt_uAddress.Text = u.u_address;
                eu.txt_uStatus.Text = u.u_status;
                //epf.te_FoodImage.Text = pf.pf_image;
                eu.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Please choose an user item to edit !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
