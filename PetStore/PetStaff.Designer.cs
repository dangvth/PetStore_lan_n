namespace PetStore
{
    partial class PetStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetStaff));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnRefreshFood = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewDetail = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.bsPet = new System.Windows.Forms.BindingSource(this.components);
            this.gcPet = new DevExpress.XtraGrid.GridControl();
            this.gvPet = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPet)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnRefreshFood,
            this.btnViewDetail});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1052, 176);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnRefreshFood
            // 
            this.btnRefreshFood.Caption = "Refresh";
            this.btnRefreshFood.Id = 1;
            this.btnRefreshFood.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshFood.ImageOptions.Image")));
            this.btnRefreshFood.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshFood.ImageOptions.LargeImage")));
            this.btnRefreshFood.LargeWidth = 70;
            this.btnRefreshFood.Name = "btnRefreshFood";
            this.btnRefreshFood.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshFood_ItemClick);
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.Caption = "View detail";
            this.btnViewDetail.Id = 2;
            this.btnViewDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDetail.ImageOptions.Image")));
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnViewDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewDetail_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Tool";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefreshFood);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnViewDetail);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Pet Food";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 491);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1052, 34);
            // 
            // gcPet
            // 
            this.gcPet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPet.Location = new System.Drawing.Point(0, 176);
            this.gcPet.MainView = this.gvPet;
            this.gcPet.MenuManager = this.ribbon;
            this.gcPet.Name = "gcPet";
            this.gcPet.Size = new System.Drawing.Size(1052, 315);
            this.gcPet.TabIndex = 8;
            this.gcPet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPet});
            // 
            // gvPet
            // 
            this.gvPet.GridControl = this.gcPet;
            this.gvPet.Name = "gvPet";
            this.gvPet.OptionsBehavior.Editable = false;
            this.gvPet.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvPet.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvPet_RowClick);
            // 
            // PetStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 525);
            this.Controls.Add(this.gcPet);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PetStaff";
            this.Text = "Pet";
            this.Load += new System.EventHandler(this.PetStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btnRefreshFood;
        private DevExpress.XtraBars.BarButtonItem btnViewDetail;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private System.Windows.Forms.BindingSource bsPet;
        private DevExpress.XtraGrid.GridControl gcPet;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPet;
    }
}