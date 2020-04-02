using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars;
using System.Windows.Forms;
using System.Data;
using PetStore.Model;

namespace PetStore.Views.BillCollectionView{
    public partial class BillCollectionView : XtraUserControl {
        int selectedID;
        public BillCollectionView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings() {
			mvvmContext.RegisterService(WindowedDocumentManagerService.Create(this));
            var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.BillCollectionViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            // We want to show the Entities collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(gridControl, gControl => gControl.DataSource, x => x.Entities);
			// We want to show loading-indicator when data is loading asynchronously
            fluentAPI.SetBinding(gridView, gView => gView.LoadingPanelVisible, x => x.IsLoading);
						// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(gridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity,
                    args => args.Row as PetStore.Bill,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
			//We want to show ribbon print preview when bbiPrintPreview clicked
			bbiPrintPreview.ItemClick += (s, e) => { gridControl.ShowRibbonPrintPreview(); };
			//We want to show RECORDS count on BarStaticItem
			fluentAPI.SetBinding(bsiRecordsCount, item => item.Caption,	x => x.Entities.Count, 
					count => string.Format("RECORDS : {0}", count));
			//We want to show PopupMenu when row clicked by right button
			gridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    popupMenu.ShowPopup(gridControl.PointToScreen(e.Location), s);
                }
            };
        }

        private void bbiDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            DataGridView grvPrint = new DataGridView();
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Price", typeof(int)));
            dt.Columns.Add(new DataColumn("Quantity", typeof(int)));
            using (var db = new PetStoreEntities())
            {
                var list = db.BillDetails.Where(x => x.b_id == selectedID);
                PetModel pm = new PetModel();
                PetFoodModel pfm = new PetFoodModel();
                PetMedicineModel pmm = new PetMedicineModel();
                PetToyModel ptm = new PetToyModel();
                PetAccessoryModel pam = new PetAccessoryModel();
                int d = 0;
                while (d != list.Count())
                {
                    var bd = list.ToList()[d];
                    if (bd.p_id != null)
                    {
                        var p = pm.getPet(bd.p_id);
                        var qty = list.Where(x => x.p_id == bd.p_id).Count();
                        dt.Rows.Add(p.p_name, p.p_salePrice, qty);
                        d += qty;
                    }
                    else if (bd.pt_id != null)
                    {
                        var pt = ptm.getPetToy(bd.pt_id);
                        var qty = list.Where(x => x.pt_id == bd.pt_id).Count();
                        dt.Rows.Add(pt.pt_name, pt.pt_salePrice, qty);
                        d += qty;
                    }
                    else if (bd.pf_id != null)
                    {
                        var pf = pfm.getPetFood(bd.pf_id);
                        var qty = list.Where(x => x.pf_id == bd.pf_id).Count();
                        dt.Rows.Add(pf.pf_name, pf.pf_salePrice, qty);
                        d += qty;
                    }
                    else if (bd.pm_id != null)
                    {
                        var pmd = pmm.getPetMedicine(bd.pm_id);
                        var qty = list.Where(x => x.pm_id == bd.pm_id).Count();
                        dt.Rows.Add(pmd.pm_name, pmd.pm_salePrice, qty);
                        d += qty;
                    }
                    else if (bd.pa_id != null)
                    {
                        var pa = pam.getPetAccessory(bd.pa_id);
                        var qty = list.Where(x => x.pa_id == bd.pa_id).Count();
                        dt.Rows.Add(pa.pa_name, pa.pa_salePrice, qty);
                        d += qty;
                    }
                }
            }
            DetailBill dbf = new DetailBill();
            dbf.grvDetail.DataSource = dt;
            dbf.ShowDialog(this);
        }

        private void gridView_RowClick(object sender, RowClickEventArgs e)
        {
            int idx = gridView.FocusedRowHandle;
            selectedID = int.Parse(gridView.GetRowCellValue(idx, "b_id").ToString());
            if (selectedID != -1)
            {
                bbiDetail.Enabled = true;
            }
        }
    }
}
