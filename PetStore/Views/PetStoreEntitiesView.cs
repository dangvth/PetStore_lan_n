using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.Utils.MVVM.Services;
using DevExpress.Utils.MVVM;

namespace PetStore.Views.PetStoreEntitiesView{
    public partial class PetStoreEntitiesView : XtraUserControl {

        #region Initialize Admin View
        public PetStoreEntitiesView() {
			InitializeComponent();
            
			if(!mvvmContext.IsDesignMode)
                InitializeNavigation();
            ribbonControl.Merge += ribbonControl_Merge;
            ribbonControl.UnMerge += ribbonControl_UnMerge;
        }

        private void ribbonControl_UnMerge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e) {
            ribbonControl.SelectedPage = e.MergeOwner.SelectedPage;
            ribbonControl.StatusBar.UnMergeStatusBar();
        }

        void ribbonControl_Merge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e) {
            ribbonControl.SelectedPage = e.MergedChild.SelectedPage;
            ribbonControl.StatusBar.MergeStatusBar(e.MergedChild.StatusBar);
        }
        void InitializeNavigation() {
			DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
            DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = DevExpress.XtraEditors.ScrollUIMode.Touch;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013 Light Gray");	

            mvvmContext.RegisterService(DocumentManagerService.Create(navigationFrame));
            DevExpress.Utils.MVVM.MVVMContext.RegisterFlyoutDialogService();
            // We want to use buttons in Ribbon to show the specific modules
            var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.PetStoreEntitiesViewModel>();
			            fluentAPI.BindCommand(navigationBarItemAccountCollectionView, (x, m) => x.Show(m), x => x.Modules[0]);
			fluentAPI.BindCommand(barButtonItemAccountCollectionView, (x, m) => x.Show(m), x => x.Modules[0]);
			            fluentAPI.BindCommand(navigationBarItemBillCollectionView, (x, m) => x.Show(m), x => x.Modules[1]);
			fluentAPI.BindCommand(barButtonItemBillCollectionView, (x, m) => x.Show(m), x => x.Modules[1]);
			            fluentAPI.BindCommand(navigationBarItemBillDetailCollectionView, (x, m) => x.Show(m), x => x.Modules[2]);
			fluentAPI.BindCommand(barButtonItemBillDetailCollectionView, (x, m) => x.Show(m), x => x.Modules[2]);
			            fluentAPI.BindCommand(navigationBarItemCommentCollectionView, (x, m) => x.Show(m), x => x.Modules[3]);
			fluentAPI.BindCommand(barButtonItemCommentCollectionView, (x, m) => x.Show(m), x => x.Modules[3]);
			            fluentAPI.BindCommand(navigationBarItemCommentDetailCollectionView, (x, m) => x.Show(m), x => x.Modules[4]);
			fluentAPI.BindCommand(barButtonItemCommentDetailCollectionView, (x, m) => x.Show(m), x => x.Modules[4]);
			            fluentAPI.BindCommand(navigationBarItemGiftCollectionView, (x, m) => x.Show(m), x => x.Modules[5]);
			fluentAPI.BindCommand(barButtonItemGiftCollectionView, (x, m) => x.Show(m), x => x.Modules[5]);
			            fluentAPI.BindCommand(navigationBarItemOriginCollectionView, (x, m) => x.Show(m), x => x.Modules[6]);
			fluentAPI.BindCommand(barButtonItemOriginCollectionView, (x, m) => x.Show(m), x => x.Modules[6]);
			            fluentAPI.BindCommand(navigationBarItemPetCollectionView, (x, m) => x.Show(m), x => x.Modules[7]);
			fluentAPI.BindCommand(barButtonItemPetCollectionView, (x, m) => x.Show(m), x => x.Modules[7]);
			            fluentAPI.BindCommand(navigationBarItemPetAccessoryCollectionView, (x, m) => x.Show(m), x => x.Modules[8]);
			fluentAPI.BindCommand(barButtonItemPetAccessoryCollectionView, (x, m) => x.Show(m), x => x.Modules[8]);
			            fluentAPI.BindCommand(navigationBarItemPetFoodCollectionView, (x, m) => x.Show(m), x => x.Modules[9]);
			fluentAPI.BindCommand(barButtonItemPetFoodCollectionView, (x, m) => x.Show(m), x => x.Modules[9]);
			            fluentAPI.BindCommand(navigationBarItemPetMedicineCollectionView, (x, m) => x.Show(m), x => x.Modules[10]);
			fluentAPI.BindCommand(barButtonItemPetMedicineCollectionView, (x, m) => x.Show(m), x => x.Modules[10]);
			            fluentAPI.BindCommand(navigationBarItemPetToyCollectionView, (x, m) => x.Show(m), x => x.Modules[11]);
			fluentAPI.BindCommand(barButtonItemPetToyCollectionView, (x, m) => x.Show(m), x => x.Modules[11]);
			            fluentAPI.BindCommand(navigationBarItemRoleCollectionView, (x, m) => x.Show(m), x => x.Modules[12]);
			fluentAPI.BindCommand(barButtonItemRoleCollectionView, (x, m) => x.Show(m), x => x.Modules[12]);
			            fluentAPI.BindCommand(navigationBarItemTypeCollectionView, (x, m) => x.Show(m), x => x.Modules[13]);
			fluentAPI.BindCommand(barButtonItemTypeCollectionView, (x, m) => x.Show(m), x => x.Modules[13]);
			            fluentAPI.BindCommand(navigationBarItemUserCollectionView, (x, m) => x.Show(m), x => x.Modules[14]);
			fluentAPI.BindCommand(barButtonItemUserCollectionView, (x, m) => x.Show(m), x => x.Modules[14]);
						            // We want show the default module when our UserControl is loaded
            fluentAPI.WithEvent<EventArgs>(this, "Load")
                .EventToCommand(x => x.OnLoaded(null), x => x.DefaultModule);
        }
        #endregion

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void btnChangePwd_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }
    }
}
