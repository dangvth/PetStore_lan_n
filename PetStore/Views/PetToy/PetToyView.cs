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
namespace PetStore.Views.PetToyView{
    public partial class PetToyView : XtraUserControl {
        OpenFileDialog openDialog = new OpenFileDialog();
        public PetToyView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
            timer.Start();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.PetToyViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                petToyViewBindingSource, x => x.Entity, x => x.Update());
						#region BillDetails Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(BillDetailsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.PetToyBillDetailsDetails.SelectedEntity,
                    args => args.Row as PetStore.BillDetail,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						//We want to show PopupMenu when row clicked by right button
			BillDetailsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    BillDetailsPopUpMenu.ShowPopup(BillDetailsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the PetToyBillDetailsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(BillDetailsGridControl, g => g.DataSource, x => x.PetToyBillDetailsDetails.Entities);
				
														fluentAPI.BindCommand(bbiBillDetailsRefresh, x => x.PetToyBillDetailsDetails.Refresh());
																	#endregion
						 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
        String solutionPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        private void pt_idTextEdit_Properties_Click(object sender, EventArgs e)
        {
            PetToyModel ptm = new PetToyModel();
            pt_idTextEdit.Text = ptm.getNextID();
        }
        //get path of image, just accept image file
        private void pt_imageTextEdit_Properties_Click(object sender, EventArgs e)
        {
            openDialog.Filter = "Image files (*.jpg)|*.jpg|Image files (*.png)|*.png|All files (*.*)|*.*";
            openDialog.ShowDialog();
            if (openDialog.FileName != "" && (openDialog.FileName.EndsWith(".jpg") || openDialog.FileName.EndsWith(".png")))
            {
                PetToyModel ptm = new PetToyModel();
                if (openDialog.FileName.EndsWith(".jpg")) { pt_imageTextEdit.Text = ptm.getNextID() + ".jpg"; }
                else { pt_imageTextEdit.Text = ptm.getNextID() + ".png"; }
            }
            else
            {
                XtraMessageBox.Show("Please choose a image with (*.jpg)/(*.png) file !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //save and copy image to img, image folder
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String oldPath = openDialog.FileName;
            String oldFilePath = @"../../img/" + pt_imageTextEdit.Text;
            FileInfo f = new FileInfo(oldFilePath);
            if (f.Exists)
            {
                File.Delete(oldFilePath);
            }
            File.Copy(oldPath, solutionPath + "\\PetStoreWebClient\\Assets\\images\\" + pt_imageTextEdit.Text);
            File.Copy(oldPath, @"../../img/" + pt_imageTextEdit.Text);
            MessageBox.Show("Save Toys Successful !", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //save and copy image to img, image folder
        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String oldPath = openDialog.FileName;
            String oldFilePath = @"../../img/" + pt_imageTextEdit.Text;
            FileInfo f = new FileInfo(oldFilePath);
            if (f.Exists)
            {
                File.Delete(oldFilePath);
            }
            File.Copy(oldPath, solutionPath + "\\PetStoreWebClient\\Assets\\images\\" + pt_imageTextEdit.Text);
            File.Copy(oldPath, @"../../img/" + pt_imageTextEdit.Text);
            MessageBox.Show("Save Toys Successful !", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //save and copy image to img, image folder
        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String oldPath = openDialog.FileName;
            String oldFilePath = @"../../img/" + pt_imageTextEdit.Text;
            FileInfo f = new FileInfo(oldFilePath);
            if (f.Exists)
            {
                File.Delete(oldFilePath);
            }
            File.Copy(oldPath, solutionPath + "\\PetStoreWebClient\\Assets\\images\\" + pt_imageTextEdit.Text);
            File.Copy(oldPath, @"../../img/" + pt_imageTextEdit.Text);
            MessageBox.Show("Save Toys Successful !", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //set timer for time add product
        private void timer_Tick(object sender, EventArgs e)
        {
            pt_publishedDateEdit.Text = System.DateTime.Now.ToString();
        }
    }
}
