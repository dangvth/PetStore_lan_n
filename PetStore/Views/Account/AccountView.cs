using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace PetStore.Views.AccountView{
    public partial class AccountView : XtraUserControl {
        //declare variables
        Model.AccountModel am = new Model.AccountModel();

        public AccountView() {
            InitializeComponent();
            timer1.Start();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
            var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.AccountViewModel>();
            fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                accountViewBindingSource, x => x.Entity, x => x.Update());
						#region Users Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(UsersGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.AccountUsersDetails.SelectedEntity,
                    args => args.Row as PetStore.User,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(UsersGridView, "RowClick")
						.EventToCommand(
						    x => x.AccountUsersDetails.Edit(null), x => x.AccountUsersDetails.SelectedEntity,
						    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			UsersGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    UsersPopUpMenu.ShowPopup(UsersGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the AccountUsersDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(UsersGridControl, g => g.DataSource, x => x.AccountUsersDetails.Entities);
				
														fluentAPI.BindCommand(bbiUsersNew, x => x.AccountUsersDetails.New());
																													fluentAPI.BindCommand(bbiUsersEdit,x => x.AccountUsersDetails.Edit(null), x=>x.AccountUsersDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiUsersDelete,x => x.AccountUsersDetails.Delete(null), x=>x.AccountUsersDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiUsersRefresh, x => x.AccountUsersDetails.Refresh());
																	#endregion
									// Binding for Role LookUp editor
			fluentAPI.SetBinding(RoleLookUpEdit.Properties, p => p.DataSource, x => x.LookUpRoles.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!txtAc_userName.Text.Equals(""))
            {
                txtAc_pwd.ReadOnly = true;
            }
            else
            {
                txtAc_pwd.ReadOnly = false;
            }
        }

        private void txtAc_userName_TextChanged(object sender, EventArgs e)
        {
            if (!txtAc_userName.Text.Equals(""))
            {
                txtAc_pwd.Text = "user@123";                
            } else
            {
                txtAc_pwd.Text = "";
            }
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtAc_pwd.Text = MyUtil.Encrypt.SHA256_Encrypt("user@123");
        }

        private void txtAc_userName_Leave(object sender, EventArgs e)
        {
            if (am.checkConcideUsername(txtAc_userName.Text))
            {
                MessageBox.Show("This username has already exist!", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
