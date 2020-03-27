using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using PetStore.Model;
using System.Windows.Forms;
using System.IO;

namespace PetStore.Views.GiftView{
    public partial class GiftView : XtraUserControl {
        public GiftView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.GiftViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                giftViewBindingSource, x => x.Entity, x => x.Update());
						#region Bills Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(BillsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.GiftBillsDetails.SelectedEntity,
                    args => args.Row as PetStore.Bill,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						//We want to show PopupMenu when row clicked by right button
			BillsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    BillsPopUpMenu.ShowPopup(BillsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the GiftBillsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(BillsGridControl, g => g.DataSource, x => x.GiftBillsDetails.Entities);
				
														fluentAPI.BindCommand(bbiBillsRefresh, x => x.GiftBillsDetails.Refresh());
																	#endregion
						 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }

        private void g_imageTextEdit_Click(object sender, EventArgs e)
        {
            openDialog.Filter = "Image files (*.jpg)|*.jpg|Image files (*.png)|*.png|All files (*.*)|*.*";
            openDialog.ShowDialog();
            if (openDialog.FileName != "" && (openDialog.FileName.EndsWith(".jpg") || openDialog.FileName.EndsWith(".png")))
            {
                GiftModel gm = new GiftModel();
                if (openDialog.FileName.EndsWith(".jpg")) { g_imageTextEdit.Text = gm.getNextID() + ".jpg"; }
                else { g_imageTextEdit.Text = gm.getNextID() + ".png"; }
            }
            else
            {
                XtraMessageBox.Show("Please choose a image with (*.jpg)/(*.png) file !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String oldPath = openDialog.FileName;
            //get solution path
            String solutionPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            //copy file to image folder
            if (oldPath.Equals("openFileDialog1"))
            {
                MessageBox.Show("Please choose a image with (*.jpg)/(*.png) file !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                File.Copy(oldPath, solutionPath + "\\PetStoreWebClient\\Assets\\images\\" + g_imageTextEdit.Text);
                File.Copy(oldPath, @"../../img/" + g_imageTextEdit.Text);
                MessageBox.Show("Save gift Successful !", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String oldPath = openDialog.FileName;
            //get solution path
            String solutionPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            //copy file to image folder
            if (oldPath.Equals("openFileDialog1"))
            {
                MessageBox.Show("Please choose a image with (*.jpg)/(*.png) file !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                File.Copy(oldPath, solutionPath + "\\PetStoreWebClient\\Assets\\images\\" + g_imageTextEdit.Text);
                File.Copy(oldPath, @"../../img/" + g_imageTextEdit.Text);
                MessageBox.Show("Save gift Successful !", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String oldPath = openDialog.FileName;
            //get solution path
            String solutionPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            //copy file to image folder
            if (oldPath.Equals("openFileDialog1"))
            {
                MessageBox.Show("Please choose a image with (*.jpg)/(*.png) file !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                File.Copy(oldPath, solutionPath + "\\PetStoreWebClient\\Assets\\images\\" + g_imageTextEdit.Text);
                File.Copy(oldPath, @"../../img/" + g_imageTextEdit.Text);
                MessageBox.Show("Save gift Successful !", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GiftView_Load(object sender, EventArgs e)
        {
            GiftModel gm = new GiftModel();
            g_idTextEdit.Text = gm.getNextID();
            g_statusTextEdit.SelectedItem = "Active";
        }

        private void g_idTextEdit_Click(object sender, EventArgs e)
        {
            GiftModel gm = new GiftModel();
            g_idTextEdit.Text = gm.getNextID();
        }
    }
}
