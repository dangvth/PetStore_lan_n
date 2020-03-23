namespace PetStore.Views.BillDetailCollectionView {
    partial class BillDetailCollectionView {
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
			this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
			this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
			this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            this.SuspendLayout();
			// 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.MaxItemId = 14;
            this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.bbiPrintPreview, this.bsiRecordsCount});
																DevExpress.XtraBars.BarButtonItem bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
			bbiRefresh.Caption = "Refresh";
			bbiRefresh.Name = "bbiRefresh";
			bbiRefresh.ImageUri.Uri = "Refresh";
						this.ribbonControl.Items.Add(bbiRefresh);
	
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
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "BillDetail Tasks";
								this.ribbonPageGroup1.ItemLinks.Add(bbiRefresh);
	
			// 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Print and Export";
			this.ribbonPageGroup2.AllowTextClipping = false;
			this.ribbonPageGroup2.ShowCaptionButton = false;
			// 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
			// 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
			// 
            // barStaticItem1
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 2";
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            this.bsiRecordsCount.TextAlignment = System.Drawing.StringAlignment.Near;
			// 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(5, 116);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(779, 311);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
			this.billDetailCollectionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.billDetailCollectionViewBindingSource.DataSource = typeof(PetStore.BillDetail);
			this.gridControl.DataSource = billDetailCollectionViewBindingSource;

			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters parameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
						//
			//Bill
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters BillPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            BillPopulateColumnParameters.FieldName = "Bill";
            BillPopulateColumnParameters.Path = "Bill.b_status";
			parameters.CustomColumnParameters.Add(BillPopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters BillPopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            BillPopulateColumnParameters_NotGenerate.FieldName = "b_id";
		    BillPopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(BillPopulateColumnParameters_NotGenerate);
									//
			//PetAccessory
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PetAccessoryPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PetAccessoryPopulateColumnParameters.FieldName = "PetAccessory";
            PetAccessoryPopulateColumnParameters.Path = "PetAccessory.pa_name";
			parameters.CustomColumnParameters.Add(PetAccessoryPopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters PetAccessoryPopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PetAccessoryPopulateColumnParameters_NotGenerate.FieldName = "pa_id";
		    PetAccessoryPopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(PetAccessoryPopulateColumnParameters_NotGenerate);
									//
			//PetFood
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PetFoodPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PetFoodPopulateColumnParameters.FieldName = "PetFood";
            PetFoodPopulateColumnParameters.Path = "PetFood.pf_name";
			parameters.CustomColumnParameters.Add(PetFoodPopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters PetFoodPopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PetFoodPopulateColumnParameters_NotGenerate.FieldName = "pf_id";
		    PetFoodPopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(PetFoodPopulateColumnParameters_NotGenerate);
									//
			//PetMedicine
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PetMedicinePopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PetMedicinePopulateColumnParameters.FieldName = "PetMedicine";
            PetMedicinePopulateColumnParameters.Path = "PetMedicine.pm_name";
			parameters.CustomColumnParameters.Add(PetMedicinePopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters PetMedicinePopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PetMedicinePopulateColumnParameters_NotGenerate.FieldName = "pm_id";
		    PetMedicinePopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(PetMedicinePopulateColumnParameters_NotGenerate);
									//
			//PetToy
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PetToyPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PetToyPopulateColumnParameters.FieldName = "PetToy";
            PetToyPopulateColumnParameters.Path = "PetToy.pt_name";
			parameters.CustomColumnParameters.Add(PetToyPopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters PetToyPopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PetToyPopulateColumnParameters_NotGenerate.FieldName = "pt_id";
		    PetToyPopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(PetToyPopulateColumnParameters_NotGenerate);
									//
			//Pet
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PetPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PetPopulateColumnParameters.FieldName = "Pet";
            PetPopulateColumnParameters.Path = "Pet.p_name";
			parameters.CustomColumnParameters.Add(PetPopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters PetPopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PetPopulateColumnParameters_NotGenerate.FieldName = "p_id";
		    PetPopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(PetPopulateColumnParameters_NotGenerate);
										
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters BillPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            BillPopulateColumnParameters_NotVisible.FieldName = "Bill";
		    BillPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(BillPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PetAccessoryPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PetAccessoryPopulateColumnParameters_NotVisible.FieldName = "PetAccessory";
		    PetAccessoryPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(PetAccessoryPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PetFoodPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PetFoodPopulateColumnParameters_NotVisible.FieldName = "PetFood";
		    PetFoodPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(PetFoodPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PetMedicinePopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PetMedicinePopulateColumnParameters_NotVisible.FieldName = "PetMedicine";
		    PetMedicinePopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(PetMedicinePopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PetToyPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PetToyPopulateColumnParameters_NotVisible.FieldName = "PetToy";
		    PetToyPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(PetToyPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PetPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PetPopulateColumnParameters_NotVisible.FieldName = "Pet";
		    PetPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(PetPopulateColumnParameters_NotVisible);
			 
			this.gridView.PopulateColumns(typeof(PetStore.BillDetail),parameters);
			// 
            // popupMenu1
            // 
								this.popupMenu.ItemLinks.Add(bbiRefresh);
	
            this.popupMenu.Name = "popupMenu";
            this.popupMenu.Ribbon = this.ribbonControl;
		    // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(PetStore.ViewModels.BillDetailCollectionViewModel);
								this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(PetStore.ViewModels.BillDetailCollectionViewModel), "Refresh", bbiRefresh));
	
			this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.Default, this.gridControl),
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterWindowedDocumentManagerService(null, false, this, DevExpress.Utils.MVVM.Services.DefaultWindowedDocumentManagerServiceType.XtraForm, null)});
			//
			//BillDetailCollectionView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
			this.Controls.Add(this.ribbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "BillDetailCollectionView";
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
		}
		
        #endregion

		private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private System.Windows.Forms.BindingSource billDetailCollectionViewBindingSource;
		private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
		private DevExpress.XtraBars.PopupMenu popupMenu;
	}
}
