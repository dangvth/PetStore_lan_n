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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetStaff));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcFood = new DevExpress.XtraGrid.GridControl();
            this.gvPet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnRefreshFood = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewDetail = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.p_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.p_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.p_salePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.p_description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.p_status = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcFood);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 176);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1171, 485);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcFood
            // 
            this.gcFood.Location = new System.Drawing.Point(12, 12);
            this.gcFood.MainView = this.gvPet;
            this.gcFood.MenuManager = this.ribbon;
            this.gcFood.Name = "gcFood";
            this.gcFood.Size = new System.Drawing.Size(1147, 461);
            this.gcFood.TabIndex = 4;
            this.gcFood.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPet});
            // 
            // gvPet
            // 
            this.gvPet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.p_id,
            this.p_name,
            this.p_salePrice,
            this.p_description,
            this.p_status});
            this.gvPet.GridControl = this.gcFood;
            this.gvPet.Name = "gvPet";
            this.gvPet.OptionsBehavior.Editable = false;
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
            this.ribbon.Size = new System.Drawing.Size(1171, 176);
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
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.Caption = "View detail";
            this.btnViewDetail.Id = 2;
            this.btnViewDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDetail.ImageOptions.Image")));
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 662);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1171, 34);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1171, 485);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcFood;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1151, 465);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // p_id
            // 
            this.p_id.Caption = "ID";
            this.p_id.MinWidth = 25;
            this.p_id.Name = "p_id";
            this.p_id.Visible = true;
            this.p_id.VisibleIndex = 0;
            this.p_id.Width = 94;
            // 
            // p_name
            // 
            this.p_name.Caption = "Name";
            this.p_name.MinWidth = 25;
            this.p_name.Name = "p_name";
            this.p_name.Visible = true;
            this.p_name.VisibleIndex = 1;
            this.p_name.Width = 94;
            // 
            // p_salePrice
            // 
            this.p_salePrice.Caption = "Prices";
            this.p_salePrice.MinWidth = 25;
            this.p_salePrice.Name = "p_salePrice";
            this.p_salePrice.Visible = true;
            this.p_salePrice.VisibleIndex = 2;
            this.p_salePrice.Width = 94;
            // 
            // p_description
            // 
            this.p_description.Caption = "Description";
            this.p_description.MinWidth = 25;
            this.p_description.Name = "p_description";
            this.p_description.Visible = true;
            this.p_description.VisibleIndex = 3;
            this.p_description.Width = 94;
            // 
            // p_status
            // 
            this.p_status.Caption = "Status";
            this.p_status.MinWidth = 25;
            this.p_status.Name = "p_status";
            this.p_status.Visible = true;
            this.p_status.VisibleIndex = 4;
            this.p_status.Width = 94;
            // 
            // PetStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 696);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PetStaff";
            this.Text = "Pet";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcFood;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPet;
        private DevExpress.XtraGrid.Columns.GridColumn p_id;
        private DevExpress.XtraGrid.Columns.GridColumn p_name;
        private DevExpress.XtraGrid.Columns.GridColumn p_salePrice;
        private DevExpress.XtraGrid.Columns.GridColumn p_description;
        private DevExpress.XtraGrid.Columns.GridColumn p_status;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btnRefreshFood;
        private DevExpress.XtraBars.BarButtonItem btnViewDetail;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}