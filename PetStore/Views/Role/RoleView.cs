using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace PetStore.Views.RoleView{
    public partial class RoleView : XtraUserControl {
        public RoleView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.RoleViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                roleViewBindingSource, x => x.Entity, x => x.Update());
						#region Accounts Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(AccountsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.RoleAccountsDetails.SelectedEntity,
                    args => args.Row as PetStore.Account,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(AccountsGridView, "RowClick")
						.EventToCommand(
						    x => x.RoleAccountsDetails.Edit(null), x => x.RoleAccountsDetails.SelectedEntity,
						    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			AccountsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    AccountsPopUpMenu.ShowPopup(AccountsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the RoleAccountsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(AccountsGridControl, g => g.DataSource, x => x.RoleAccountsDetails.Entities);
				
														fluentAPI.BindCommand(bbiAccountsNew, x => x.RoleAccountsDetails.New());
																													fluentAPI.BindCommand(bbiAccountsEdit,x => x.RoleAccountsDetails.Edit(null), x=>x.RoleAccountsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiAccountsDelete,x => x.RoleAccountsDetails.Delete(null), x=>x.RoleAccountsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiAccountsRefresh, x => x.RoleAccountsDetails.Refresh());
																	#endregion
						 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
