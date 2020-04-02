namespace PetStore
{
    partial class PetToysStaff
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
            this.gcToys = new DevExpress.XtraGrid.GridControl();
            this.petStoreDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petStoreDataSet2 = new PetStore.PetStoreDataSet2();
            this.gridToys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btndetail = new DevExpress.XtraBars.BarButtonItem();
            this.btnrefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.gcToys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridToys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcToys
            // 
            this.gcToys.DataSource = this.petStoreDataSet2BindingSource;
            this.gcToys.Location = new System.Drawing.Point(0, 147);
            this.gcToys.MainView = this.gridToys;
            this.gcToys.MenuManager = this.ribbonControl1;
            this.gcToys.Name = "gcToys";
            this.gcToys.Size = new System.Drawing.Size(1255, 407);
            this.gcToys.TabIndex = 8;
            this.gcToys.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridToys});
            this.gcToys.Load += new System.EventHandler(this.gcToys_Load);
            // 
            // petStoreDataSet2BindingSource
            // 
            this.petStoreDataSet2BindingSource.DataSource = this.petStoreDataSet2;
            this.petStoreDataSet2BindingSource.Position = 0;
            // 
            // petStoreDataSet2
            // 
            this.petStoreDataSet2.DataSetName = "PetStoreDataSet2";
            this.petStoreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridToys
            // 
            this.gridToys.GridControl = this.gcToys;
            this.gridToys.Name = "gridToys";
            this.gridToys.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gcToys_RowClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btndetail,
            this.btnrefresh});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(1255, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btndetail
            // 
            this.btndetail.Caption = "Detail";
            this.btndetail.Id = 1;
            this.btndetail.ImageOptions.Image = global::PetStore.Properties.Resources.tải_xuống__7_;
            this.btndetail.Name = "btndetail";
            this.btndetail.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btndetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btndetail_ItemClick);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Caption = "Refresh";
            this.btnrefresh.Id = 2;
            this.btnrefresh.ImageOptions.Image = global::PetStore.Properties.Resources.refresh;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnrefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnrefresh_ItemClick);
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
            this.ribbonPageGroup2.ItemLinks.Add(this.btndetail);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnrefresh);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Tool Group";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 572);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1255, 31);
            // 
            // PetToysStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 603);
            this.Controls.Add(this.gcToys);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "PetToysStaff";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "PetToysStaff";
            ((System.ComponentModel.ISupportInitialize)(this.gcToys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridToys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gcToys;
        private DevExpress.XtraGrid.Views.Grid.GridView gridToys;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btndetail;
        private DevExpress.XtraBars.BarButtonItem btnrefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private System.Windows.Forms.BindingSource petStoreDataSet2BindingSource;
        private PetStoreDataSet2 petStoreDataSet2;
    }
}