using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace PetStore.Views.UserView{
    public partial class UserView : XtraUserControl {
        public UserView() {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode)
                InitBindings();    
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.UserViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                userViewBindingSource, x => x.Entity, x => x.Update());
						#region Bills Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(BillsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UserBillsDetails.SelectedEntity,
                    args => args.Row as PetStore.Bill,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						//We want to show PopupMenu when row clicked by right button
			BillsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    BillsPopUpMenu.ShowPopup(BillsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UserBillsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(BillsGridControl, g => g.DataSource, x => x.UserBillsDetails.Entities);
				
														fluentAPI.BindCommand(bbiBillsRefresh, x => x.UserBillsDetails.Refresh());
																	#endregion
						#region Comments Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(CommentsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UserCommentsDetails.SelectedEntity,
                    args => args.Row as PetStore.Comment,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						//We want to show PopupMenu when row clicked by right button
			CommentsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    CommentsPopUpMenu.ShowPopup(CommentsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UserCommentsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(CommentsGridControl, g => g.DataSource, x => x.UserCommentsDetails.Entities);
				
														fluentAPI.BindCommand(bbiCommentsRefresh, x => x.UserCommentsDetails.Refresh());
																	#endregion
						#region CommentDetails Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(CommentDetailsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UserCommentDetailsDetails.SelectedEntity,
                    args => args.Row as PetStore.CommentDetail,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						//We want to show PopupMenu when row clicked by right button
			CommentDetailsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    CommentDetailsPopUpMenu.ShowPopup(CommentDetailsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UserCommentDetailsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(CommentDetailsGridControl, g => g.DataSource, x => x.UserCommentDetailsDetails.Entities);
				
														fluentAPI.BindCommand(bbiCommentDetailsRefresh, x => x.UserCommentDetailsDetails.Refresh());
																	#endregion
									// Binding for Account LookUp editor
			fluentAPI.SetBinding(AccountLookUpEdit.Properties, p => p.DataSource, x => x.LookUpAccounts.Entities);

            bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
            
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //using (var db = new PetStoreEntities())
            //{
            //    int index = AccountLookUpEditView.FocusedRowHandle;
            //    var ac = db.Accounts.Find(int.Parse(AccountLookUpEditView.GetDataRow(index)[0].ToString()));
            //    ac.ac_status = "Selected";
            //    db.SaveChanges();
            //}
        }

        private void UserView_Load(object sender, EventArgs e)
        {
            u_statusTextEdit.Text = "Active";
        }
    }
}
