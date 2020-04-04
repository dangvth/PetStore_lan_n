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

namespace PetStore.Views.PetMedicineView{
    public partial class PetMedicineView : XtraUserControl {
        OpenFileDialog openDialog = new OpenFileDialog();

        public PetMedicineView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.PetMedicineViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                petMedicineViewBindingSource, x => x.Entity, x => x.Update());
						#region BillDetails Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(BillDetailsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.PetMedicineBillDetailsDetails.SelectedEntity,
                    args => args.Row as PetStore.BillDetail,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						//We want to show PopupMenu when row clicked by right button
			BillDetailsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    BillDetailsPopUpMenu.ShowPopup(BillDetailsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the PetMedicineBillDetailsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(BillDetailsGridControl, g => g.DataSource, x => x.PetMedicineBillDetailsDetails.Entities);
				
														fluentAPI.BindCommand(bbiBillDetailsRefresh, x => x.PetMedicineBillDetailsDetails.Refresh());
																	#endregion
						 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
        String solutionPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        //get path for image Text box, just accept image file
        private void pm_imageTextEdit_Properties_Click(object sender, EventArgs e)
        {
         
            openDialog.Filter = "Image files (*.jpg)|*.jpg|Image files (*.png)|*.png|All files (*.*)|*.*";
            openDialog.ShowDialog();
            if (openDialog.FileName != "" && (openDialog.FileName.EndsWith(".jpg") || openDialog.FileName.EndsWith(".png")))
            {
                PetMedicineModel pmm = new PetMedicineModel();
                if (openDialog.FileName.EndsWith(".jpg")) { pm_imageTextEdit.Text = pmm.getNextID() + ".jpg"; }
                else { pm_imageTextEdit.Text = pmm.getNextID() + ".png"; }
            }
            else
            {
                XtraMessageBox.Show("Please choose a image with (*.jpg)/(*.png) file !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //save product and copy image to img,image folder 
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String oldPath = openDialog.FileName;
            String oldFilePath = @"../../img/" + pm_imageTextEdit.Text;
            FileInfo f = new FileInfo(oldFilePath);
            if (f.Exists)
            {
                File.Delete(oldFilePath);
            }
            File.Copy(oldPath, solutionPath + "\\PetStoreWebClient\\Assets\\images\\" + pm_imageTextEdit.Text);
            File.Copy(oldPath, @"../../img/" + pm_imageTextEdit.Text);
            MessageBox.Show("Save medicine Successful !", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //save product and copy image to img,image folder 
        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String oldPath = openDialog.FileName;
            String oldFilePath = @"../../img/" + pm_imageTextEdit.Text;
            FileInfo f = new FileInfo(oldFilePath);
            if (f.Exists)
            {
                File.Delete(oldFilePath);
            }
            File.Copy(oldPath, solutionPath + "\\PetStoreWebClient\\Assets\\images\\" + pm_imageTextEdit.Text);
            File.Copy(oldPath, @"../../img/" + pm_imageTextEdit.Text);
            MessageBox.Show("Save medicine Successful !", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //save product and copy image to img,image folder 
        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String oldPath = openDialog.FileName;
            String oldFilePath = @"../../img/" + pm_imageTextEdit.Text;
            FileInfo f = new FileInfo(oldFilePath);
            if (f.Exists)
            {
                File.Delete(oldFilePath);
            }
            File.Copy(oldPath, solutionPath + "\\PetStoreWebClient\\Assets\\images\\" + pm_imageTextEdit.Text);
            File.Copy(oldPath, @"../../img/" + pm_imageTextEdit.Text);
            MessageBox.Show("Save medicine Successful !", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //load data to grid view
        private void PetMedicineView_Load(object sender, EventArgs e)
        {
            PetMedicineModel pmm = new PetMedicineModel();
            pm_idTextEdit.Text = pmm.getNextID();
            pm_statusTextEdit.SelectedItem = "Active";
        }
        //set id for nee product
        //private void pm_idTextEdit_Properties_Click(object sender, EventArgs e)
        //{
        //    PetMedicineModel pmm = new PetMedicineModel();
        //    pm_idTextEdit.Text = pmm.getNextID();
        //}
    }
    
}
