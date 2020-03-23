using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace PetStore.Views.OriginView{
    public partial class OriginView : XtraUserControl {
        public OriginView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.OriginViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                originViewBindingSource, x => x.Entity, x => x.Update());
						#region Types Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(TypesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.OriginTypesDetails.SelectedEntity,
                    args => args.Row as PetStore.Type,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(TypesGridView, "RowClick")
						.EventToCommand(
						    x => x.OriginTypesDetails.Edit(null), x => x.OriginTypesDetails.SelectedEntity,
						    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			TypesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    TypesPopUpMenu.ShowPopup(TypesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the OriginTypesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(TypesGridControl, g => g.DataSource, x => x.OriginTypesDetails.Entities);
				
														fluentAPI.BindCommand(bbiTypesNew, x => x.OriginTypesDetails.New());
																													fluentAPI.BindCommand(bbiTypesEdit,x => x.OriginTypesDetails.Edit(null), x=>x.OriginTypesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiTypesDelete,x => x.OriginTypesDetails.Delete(null), x=>x.OriginTypesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiTypesRefresh, x => x.OriginTypesDetails.Refresh());
																	#endregion
						 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
