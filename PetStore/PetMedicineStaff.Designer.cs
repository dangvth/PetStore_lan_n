namespace PetStore
{
    partial class PetMedicineStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gcMedicine = new DevExpress.XtraGrid.GridControl();
            this.tblMed = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDetail = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.petStoreDataSet3 = new PetStore.PetStoreDataSet3();
            this.petStoreDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinedata = new PetStore.Medicinedata();
            this.medicinedataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinedata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinedataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 463);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Size = new System.Drawing.Size(1139, 20);
            // 
            // gcMedicine
            // 
            this.gcMedicine.DataSource = this.medicinedataBindingSource;
            this.gcMedicine.Location = new System.Drawing.Point(0, 147);
            this.gcMedicine.MainView = this.tblMed;
            this.gcMedicine.MenuManager = this.ribbonControl1;
            this.gcMedicine.Name = "gcMedicine";
            this.gcMedicine.Size = new System.Drawing.Size(1139, 239);
            this.gcMedicine.TabIndex = 5;
            this.gcMedicine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tblMed});
            // 
            // tblMed
            // 
            this.tblMed.GridControl = this.gcMedicine;
            this.tblMed.Name = "tblMed";
            this.tblMed.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.tblMed_RowClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDetail,
            this.btnRefresh});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(1139, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btnDetail
            // 
            this.btnDetail.Caption = "Detail";
            this.btnDetail.Id = 1;
            this.btnDetail.ImageOptions.Image = global::PetStore.Properties.Resources.tải_xuống__7_;
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetail_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 2;
            this.btnRefresh.ImageOptions.Image = global::PetStore.Properties.Resources.refresh;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Tool";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDetail);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Tool Group";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 436);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1139, 27);
            // 
            // petStoreDataSet3
            // 
            this.petStoreDataSet3.DataSetName = "PetStoreDataSet3";
            this.petStoreDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // petStoreDataSet3BindingSource
            // 
            this.petStoreDataSet3BindingSource.DataSource = this.petStoreDataSet3;
            this.petStoreDataSet3BindingSource.Position = 0;
            // 
            // medicinedata
            // 
            this.medicinedata.DataSetName = "Medicinedata";
            this.medicinedata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicinedataBindingSource
            // 
            this.medicinedataBindingSource.DataSource = this.medicinedata;
            this.medicinedataBindingSource.Position = 0;
            // 
            // PetMedicineStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 483);
            this.Controls.Add(this.gcMedicine);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "PetMedicineStaff";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "PetMedicineStaff";
            this.Load += new System.EventHandler(this.PetMedicineStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinedata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinedataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl gcMedicine;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnDetail;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private System.Windows.Forms.BindingSource petStoreDataSet3BindingSource;
        private PetStoreDataSet3 petStoreDataSet3;
        private System.Windows.Forms.BindingSource medicinedataBindingSource;
        private Medicinedata medicinedata;
        public DevExpress.XtraGrid.Views.Grid.GridView tblMed;
    }
}