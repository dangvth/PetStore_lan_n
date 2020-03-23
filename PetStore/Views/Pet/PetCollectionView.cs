using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars;
using PetStore.Model;
using System.Drawing;
using System.IO;

namespace PetStore.Views.PetCollectionView{
    public partial class PetCollectionView : XtraUserControl {
        //declare Model using 
        Model.PetModel pm = new Model.PetModel();

        //declare variables
        string petID = "";
        
        //Init a delegate to pass data
        public delegate void delPassData(string text);
        public delPassData trans;

        #region Generate Component and Code
        public PetCollectionView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings() {
			mvvmContext.RegisterService(WindowedDocumentManagerService.Create(this));
            var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.PetCollectionViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            // We want to show the Entities collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(gridControl, gControl => gControl.DataSource, x => x.Entities);
			// We want to show loading-indicator when data is loading asynchronously
            fluentAPI.SetBinding(gridViewPet, gView => gView.LoadingPanelVisible, x => x.IsLoading);
						// We want to proceed the Edit command when row double-clicked
            fluentAPI.WithEvent<RowClickEventArgs>(gridViewPet, "RowClick").EventToCommand(
                    x => x.Edit(null),
					x => x.SelectedEntity,
                    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(gridViewPet, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity,
                    args => args.Row as PetStore.Pet,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
			//We want to show ribbon print preview when bbiPrintPreview clicked
			bbiPrintPreview.ItemClick += (s, e) => { gridControl.ShowRibbonPrintPreview(); };
			//We want to show RECORDS count on BarStaticItem
			fluentAPI.SetBinding(bsiRecordsCount, item => item.Caption,	x => x.Entities.Count, 
					count => string.Format("RECORDS : {0}", count));
			//We want to show PopupMenu when row clicked by right button
			gridViewPet.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    popupMenu.ShowPopup(gridControl.PointToScreen(e.Location), s);
                }
            };
        }
        #endregion

        private void btnTestEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (petID != "")
            {
                //EditPetFood epf = new EditPetFood();
                EditPet edp = new EditPet();
                var db = new PetStoreEntities();
                var p = db.Pets.Find(petID);
                edp.te_PID.Text = p.p_id;
                edp.te_PName.Text = p.p_name;
                //edp.te_FoodImage.Text = pf.pf_image;
                edp.te_POriginPrice.Text = p.p_prices + "";
                edp.te_PSalePrice.Text = p.p_salePrice + "";
                edp.te_PStatus.SelectedItem = p.p_status;
                edp.te_PDescription.Text = p.p_description;
                edp.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Please choose a food item to restore !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (petID != "")
            {
                DetailPetForm dtPet = new DetailPetForm();
                PetModel pm = new PetModel();

                Pet p = pm.getPet(petID);

                dtPet.txt_pID.Text = p.p_id;
                dtPet.txt_pName.Text = p.p_name;
                dtPet.txt_pOriginPrice.Text = p.p_prices.ToString();
                dtPet.txt_pPriceSale.Text = p.p_salePrice.ToString();
                dtPet.txt_Type.Text = "";

                if (p.p_status == "Active") { dtPet.txt_pStatus.ForeColor = Color.Green; }
                else { dtPet.txt_pStatus.ForeColor = Color.Red; }

                dtPet.txt_pStatus.Text = p.p_status;
                dtPet.txt_pOriginPrice.Enabled = true;
                dtPet.lblTitle.Text = p.p_name;

                String projectPath = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\.."));
                String pathImage = projectPath + "\\img\\" + p.p_image;
                Image img = Image.FromFile(pathImage);
                dtPet.ptbImage.Image = pm.ResizeImage(img, 440, 440);

                dtPet.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose a food to view detail !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (petID != null)
            {
                PetModel pm = new PetModel();
                pm.InactivePet(petID);
                XtraMessageBox.Show("Delete successful!!!", "Pet Shop", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Please select a Pet item to delete!!!", "Pet Shop", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void bbiRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (petID != null)
            {
                PetModel pm = new PetModel();
                pm.RestorePet(petID);
                XtraMessageBox.Show("Restore successful!!!", "Pet Shop", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Please select a Pet item to restore!!!", "Pet Shop", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void gridViewPet_RowClick(object sender, RowClickEventArgs e)
        {
            petID = gridViewPet.GetFocusedRowCellValue("p_id").ToString();
        }
    }
}
