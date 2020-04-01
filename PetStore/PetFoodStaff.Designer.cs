namespace PetStore
{
    partial class PetFoodStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetFoodStaff));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnRefreshFood = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewDetail = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bindingSourceFood = new System.Windows.Forms.BindingSource(this.components);
            this.gcFood = new DevExpress.XtraGrid.GridControl();
            this.gvFood = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFood)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(1106, 178);
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
            // gcFood
            // 
            this.gcFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFood.Location = new System.Drawing.Point(0, 178);
            this.gcFood.MainView = this.gvFood;
            this.gcFood.MenuManager = this.ribbon;
            this.gcFood.Name = "gcFood";
            this.gcFood.Size = new System.Drawing.Size(1106, 526);
            this.gcFood.TabIndex = 8;
            this.gcFood.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFood});
            // 
            // gvFood
            // 
            this.gvFood.GridControl = this.gcFood;
            this.gvFood.Name = "gvFood";
            this.gvFood.OptionsBehavior.Editable = false;
            this.gvFood.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvFood_RowClick);
            // 
            // PetFoodStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 704);
            this.Controls.Add(this.gcFood);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "PetFoodStaff";
            this.Ribbon = this.ribbon;
            this.Text = "PetFoodStaff";
            this.Load += new System.EventHandler(this.PetFoodStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnRefreshFood;
        private System.Windows.Forms.BindingSource bindingSourceFood;
        private DevExpress.XtraBars.BarButtonItem btnViewDetail;
        private DevExpress.XtraGrid.GridControl gcFood;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFood;
    }
}