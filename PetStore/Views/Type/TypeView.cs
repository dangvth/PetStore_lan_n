using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace PetStore.Views.TypeView{
    public partial class TypeView : XtraUserControl {
        public TypeView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.TypeViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                typeViewBindingSource, x => x.Entity, x => x.Update());
						#region Pets Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(PetsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.TypePetsDetails.SelectedEntity,
                    args => args.Row as PetStore.Pet,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(PetsGridView, "RowClick")
						.EventToCommand(
						    x => x.TypePetsDetails.Edit(null), x => x.TypePetsDetails.SelectedEntity,
						    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			PetsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    PetsPopUpMenu.ShowPopup(PetsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the TypePetsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(PetsGridControl, g => g.DataSource, x => x.TypePetsDetails.Entities);
				
														fluentAPI.BindCommand(bbiPetsNew, x => x.TypePetsDetails.New());
																													fluentAPI.BindCommand(bbiPetsEdit,x => x.TypePetsDetails.Edit(null), x=>x.TypePetsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiPetsDelete,x => x.TypePetsDetails.Delete(null), x=>x.TypePetsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiPetsRefresh, x => x.TypePetsDetails.Refresh());
																	#endregion
						#region PetFoods Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(PetFoodsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.TypePetFoodsDetails.SelectedEntity,
                    args => args.Row as PetStore.PetFood,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(PetFoodsGridView, "RowClick")
						.EventToCommand(
						    x => x.TypePetFoodsDetails.Edit(null), x => x.TypePetFoodsDetails.SelectedEntity,
						    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			PetFoodsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    PetFoodsPopUpMenu.ShowPopup(PetFoodsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the TypePetFoodsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(PetFoodsGridControl, g => g.DataSource, x => x.TypePetFoodsDetails.Entities);
				
														fluentAPI.BindCommand(bbiPetFoodsNew, x => x.TypePetFoodsDetails.New());
																													fluentAPI.BindCommand(bbiPetFoodsEdit,x => x.TypePetFoodsDetails.Edit(null), x=>x.TypePetFoodsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiPetFoodsDelete,x => x.TypePetFoodsDetails.Delete(null), x=>x.TypePetFoodsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiPetFoodsRefresh, x => x.TypePetFoodsDetails.Refresh());
																	#endregion
									// Binding for Origin LookUp editor
			fluentAPI.SetBinding(OriginLookUpEdit.Properties, p => p.DataSource, x => x.LookUpOrigins.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
