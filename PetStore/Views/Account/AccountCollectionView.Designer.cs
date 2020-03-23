namespace PetStore.Views.AccountCollectionView {
    partial class AccountCollectionView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		 #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountCollectionView));
            this.gridControlAccount = new DevExpress.XtraGrid.GridControl();
            this.accountCollectionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewAccount = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.acID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRestore = new DevExpress.XtraBars.BarButtonItem();
            this.btnResetPwd = new DevExpress.XtraBars.BarButtonItem();
            this.btnBan_DeleteAccount = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountCollectionViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlAccount
            // 
            this.gridControlAccount.DataSource = this.accountCollectionViewBindingSource;
            this.gridControlAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAccount.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlAccount.Location = new System.Drawing.Point(0, 145);
            this.gridControlAccount.MainView = this.gridViewAccount;
            this.gridControlAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlAccount.MenuManager = this.ribbonControl;
            this.gridControlAccount.Name = "gridControlAccount";
            this.gridControlAccount.Size = new System.Drawing.Size(1195, 800);
            this.gridControlAccount.TabIndex = 2;
            this.gridControlAccount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAccount});
            // 
            // accountCollectionViewBindingSource
            // 
            this.accountCollectionViewBindingSource.DataSource = typeof(PetStore.Account);
            // 
            // gridViewAccount
            // 
            this.gridViewAccount.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridViewAccount.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.acID,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridViewAccount.DetailHeight = 431;
            this.gridViewAccount.GridControl = this.gridControlAccount;
            this.gridViewAccount.Name = "gridViewAccount";
            this.gridViewAccount.OptionsBehavior.Editable = false;
            this.gridViewAccount.OptionsBehavior.ReadOnly = true;
            this.gridViewAccount.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewAccount_RowClick);
            // 
            // acID
            // 
            this.acID.Caption = "ID";
            this.acID.FieldName = "ac_id";
            this.acID.MinWidth = 23;
            this.acID.Name = "acID";
            this.acID.Visible = true;
            this.acID.VisibleIndex = 0;
            this.acID.Width = 87;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Username";
            this.gridColumn2.FieldName = "ac_userName";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 87;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Status";
            this.gridColumn4.FieldName = "ac_status";
            this.gridColumn4.MinWidth = 23;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 87;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "r_id";
            this.gridColumn5.MinWidth = 23;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Width = 87;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Role";
            this.gridColumn6.FieldName = "Role.r_name";
            this.gridColumn6.MinWidth = 23;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 87;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "Users";
            this.gridColumn7.MinWidth = 23;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Width = 87;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiNew,
            this.bbiEdit,
            this.bbiRefresh,
            this.bbiDelete,
            this.bbiRestore,
            this.btnResetPwd,
            this.btnBan_DeleteAccount});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl.MaxItemId = 3;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1195, 145);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 2";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "New";
            this.bbiNew.Id = 16;
            this.bbiNew.ImageOptions.ImageUri.Uri = "Add";
            this.bbiNew.Name = "bbiNew";
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 20;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiRestore
            // 
            this.bbiRestore.Caption = "Restore";
            this.bbiRestore.Id = 21;
            this.bbiRestore.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiRestore.ImageOptions.LargeImage")));
            this.bbiRestore.Name = "bbiRestore";
            this.bbiRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRestore_ItemClick);
            // 
            // btnResetPwd
            // 
            this.btnResetPwd.Caption = "Reset Password";
            this.btnResetPwd.Id = 1;
            this.btnResetPwd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnResetPwd.ImageOptions.Image")));
            this.btnResetPwd.Name = "btnResetPwd";
            this.btnResetPwd.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnResetPwd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResetPwd_ItemClick);
            // 
            // btnBan_DeleteAccount
            // 
            this.btnBan_DeleteAccount.Caption = "Ban - Delete";
            this.btnBan_DeleteAccount.Id = 2;
            this.btnBan_DeleteAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBan_DeleteAccount.ImageOptions.Image")));
            this.btnBan_DeleteAccount.LargeWidth = 75;
            this.btnBan_DeleteAccount.Name = "btnBan_DeleteAccount";
            this.btnBan_DeleteAccount.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBan_DeleteAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBan_DeleteAccount_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBan_DeleteAccount);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRestore);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnResetPwd);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Account Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Print and Export";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 911);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1195, 34);
            // 
            // mvvmContext
            // 
            this.mvvmContext.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(PetStore.ViewModels.AccountCollectionViewModel), "New", this.bbiNew),
            DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(typeof(PetStore.ViewModels.AccountCollectionViewModel), "Edit", "SelectedEntity", this.bbiEdit),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(PetStore.ViewModels.AccountCollectionViewModel), "Refresh", this.bbiRefresh)});
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.Default, this.gridControlAccount),
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterWindowedDocumentManagerService(null, false, this, DevExpress.Utils.MVVM.Services.DefaultWindowedDocumentManagerServiceType.XtraForm, null)});
            this.mvvmContext.ViewModelType = typeof(PetStore.ViewModels.AccountCollectionViewModel);
            // 
            // popupMenu
            // 
            this.popupMenu.ItemLinks.Add(this.bbiNew);
            this.popupMenu.ItemLinks.Add(this.bbiEdit);
            this.popupMenu.ItemLinks.Add(this.bbiRefresh);
            this.popupMenu.Name = "popupMenu";
            this.popupMenu.Ribbon = this.ribbonControl;
            // 
            // AccountCollectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControlAccount);
            this.Controls.Add(this.ribbonControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AccountCollectionView";
            this.Size = new System.Drawing.Size(1195, 945);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountCollectionViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
        #endregion

		private DevExpress.XtraGrid.GridControl gridControlAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAccount;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private System.Windows.Forms.BindingSource accountCollectionViewBindingSource;
		private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
		private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraGrid.Columns.GridColumn acID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRestore;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem btnResetPwd;
        private DevExpress.XtraBars.BarButtonItem btnBan_DeleteAccount;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}
