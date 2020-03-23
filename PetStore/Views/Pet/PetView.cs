﻿using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace PetStore.Views.PetView{
    public partial class PetView : XtraUserControl {

        //Declare variables
        private string petID = "";

        #region Generate Component and Code
        public PetView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
            //Call PetCollectionViews Model
            PetCollectionView.PetCollectionView pcv = new PetCollectionView.PetCollectionView();
            //get data has been pass from PetCollectionViews
            pcv.trans = new PetCollectionView.PetCollectionView.delPassData(getID);
            //Run Timer
            timer1.Start();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.PetViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                petViewBindingSource, x => x.Entity, x => x.Update());
						#region BillDetails Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(BillDetailsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.PetBillDetailsDetails.SelectedEntity,
                    args => args.Row as PetStore.BillDetail,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						//We want to show PopupMenu when row clicked by right button
			BillDetailsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    BillDetailsPopUpMenu.ShowPopup(BillDetailsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the PetBillDetailsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(BillDetailsGridControl, g => g.DataSource, x => x.PetBillDetailsDetails.Entities);
				
														fluentAPI.BindCommand(bbiBillDetailsRefresh, x => x.PetBillDetailsDetails.Refresh());
																	#endregion
						#region Comments Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(CommentsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.PetCommentsDetails.SelectedEntity,
                    args => args.Row as PetStore.Comment,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						//We want to show PopupMenu when row clicked by right button
			CommentsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    CommentsPopUpMenu.ShowPopup(CommentsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the PetCommentsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(CommentsGridControl, g => g.DataSource, x => x.PetCommentsDetails.Entities);
				
														fluentAPI.BindCommand(bbiCommentsRefresh, x => x.PetCommentsDetails.Refresh());
																	#endregion
									// Binding for Type LookUp editor
			fluentAPI.SetBinding(TypeLookUpEdit.Properties, p => p.DataSource, x => x.LookUpTypes.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
        #endregion

        /// <summary>
        /// Open dialog and allow user choose image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void p_imageTextEdit_Click(object sender, EventArgs e)
        {
            opendialog.ShowDialog();
            String fileName = opendialog.FileName;
            p_imageTextEdit.Text = fileName;
        }

        /// <summary>
        /// Get Pet ID from Pet List in Pet Collection View Form
        /// </summary>
        /// <param name="text"></param>
        public void getID(string text) { petID = text; }

        /// <summary>
        /// Get current system time and set to PublishedDate EditText
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            p_publishedDateEdit.Text = System.DateTime.Now.ToString();
        }
    }
}
