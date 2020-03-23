using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars;

namespace PetStore.Views.AccountCollectionView{
    public partial class AccountCollectionView : XtraUserControl {
        //declare variables
        Model.AccountModel am = new Model.AccountModel();
        int RowID = -1;

        public AccountCollectionView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings() {
			mvvmContext.RegisterService(WindowedDocumentManagerService.Create(this));
            var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.AccountCollectionViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            // We want to show the Entities collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(gridControlAccount, gControl => gControl.DataSource, x => x.Entities);
			// We want to show loading-indicator when data is loading asynchronously
            fluentAPI.SetBinding(gridViewAccount, gView => gView.LoadingPanelVisible, x => x.IsLoading);
						// We want to proceed the Edit command when row double-clicked
            fluentAPI.WithEvent<RowClickEventArgs>(gridViewAccount, "RowClick").EventToCommand(
                    x => x.Edit(null),
					x => x.SelectedEntity,
                    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(gridViewAccount, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity,
                    args => args.Row as PetStore.Account,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
			//We want to show ribbon print preview when bbiPrintPreview clicked
			bbiPrintPreview.ItemClick += (s, e) => { gridControlAccount.ShowRibbonPrintPreview(); };
			//We want to show RECORDS count on BarStaticItem
			fluentAPI.SetBinding(bsiRecordsCount, item => item.Caption,	x => x.Entities.Count, 
					count => string.Format("RECORDS : {0}", count));
			//We want to show PopupMenu when row clicked by right button
			gridViewAccount.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    popupMenu.ShowPopup(gridControlAccount.PointToScreen(e.Location), s);
                }
            };
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void btnBan_DeleteAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            am.Ban_DeleteAccount(RowID);
            XtraMessageBox.Show("Banned", "Pet Shop", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void gridViewAccount_RowClick(object sender, RowClickEventArgs e)
        {
            RowID = Convert.ToInt32(gridViewAccount.GetFocusedRowCellValue("ac_id"));
            MessageBox.Show(RowID.ToString());
        }

        private void bbiRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            am.RestoreAccount(RowID);
            XtraMessageBox.Show("Restored", "Pet Shop", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnResetPwd_ItemClick(object sender, ItemClickEventArgs e)
        {
            am.ResetPassword(RowID);
            XtraMessageBox.Show("Reset Password Done!", "Pet Shop", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
