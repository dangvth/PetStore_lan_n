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

namespace PetStore.Views.PetFoodView
{
    public partial class PetFoodView : XtraUserControl
    {
        public PetFoodView()
        {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings()
        {
            var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.PetFoodViewModel>();
            fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                petFoodViewBindingSource, x => x.Entity, x => x.Update());
            #region BillDetails Detail Collection
            // We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(BillDetailsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.PetFoodBillDetailsDetails.SelectedEntity,
                    args => args.Row as PetStore.BillDetail,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            //We want to show PopupMenu when row clicked by right button
            BillDetailsGridView.RowClick += (s, e) =>
            {
                if (e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    BillDetailsPopUpMenu.ShowPopup(BillDetailsGridControl.PointToScreen(e.Location), s);
                }
            };
            // We want to show the PetFoodBillDetailsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(BillDetailsGridControl, g => g.DataSource, x => x.PetFoodBillDetailsDetails.Entities);

            fluentAPI.BindCommand(bbiBillDetailsRefresh, x => x.PetFoodBillDetailsDetails.Refresh());
            #endregion
            // Binding for Type LookUp editor
            fluentAPI.SetBinding(TypeLookUpEdit.Properties, p => p.DataSource, x => x.LookUpTypes.Entities);

            bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
        }

        private void pf_imageTextEdit_Click(object sender, EventArgs e)
        {
            openDialog.Filter = "Image files (*.jpg)|*.jpg|Image files (*.png)|*.png|All files (*.*)|*.*";
            openDialog.ShowDialog();
            if (openDialog.FileName != "" && (openDialog.FileName.EndsWith(".jpg") || openDialog.FileName.EndsWith(".png")))
            {
                PetFoodModel pfm = new PetFoodModel();
                if (openDialog.FileName.EndsWith(".jpg")) { pf_imageTextEdit.Text = pfm.getNextID() + ".jpg"; }
                else { pf_imageTextEdit.Text = pfm.getNextID() + ".png"; }
            }
            else
            {
                XtraMessageBox.Show("Please choose a image with (*.jpg)/(*.png) file !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String oldPath = openDialog.FileName;
            String oldFilePath = @"../../img/" + pf_imageTextEdit.Text;
            FileInfo f = new FileInfo(oldFilePath);
            if (f.Exists)
            {
                File.Delete(oldFilePath);
            }
            File.Copy(oldPath, @"../../img/" + pf_imageTextEdit.Text);
            MessageBox.Show("Save food Successful !", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String oldPath = openDialog.FileName;
            String oldFilePath = @"../../img/" + pf_imageTextEdit.Text;
            FileInfo f = new FileInfo(oldFilePath);
            if (f.Exists)
            {
                File.Delete(oldFilePath);
            }
            File.Copy(oldPath, @"../../img/" + pf_imageTextEdit.Text);
            MessageBox.Show("Save food Successful !", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String oldPath = openDialog.FileName;
            String oldFilePath = @"../../img/" + pf_imageTextEdit.Text;
            FileInfo f = new FileInfo(oldFilePath);
            if (f.Exists)
            {
                File.Delete(oldFilePath);
            }
            File.Copy(oldPath, @"../../img/" + pf_imageTextEdit.Text);
            MessageBox.Show("Save food Successful !", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PetFoodView_Load(object sender, EventArgs e)
        {
            PetFoodModel pfm = new PetFoodModel();
            pf_idTextEdit.Text = pfm.getNextID();
            pf_statusTextEdit.SelectedItem = "Active";
        }

        private void pf_idTextEdit_Click(object sender, EventArgs e)
        {
            PetFoodModel pfm = new PetFoodModel();
            pf_idTextEdit.Text = pfm.getNextID();
        }
    }
}
