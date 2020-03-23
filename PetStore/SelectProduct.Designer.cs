namespace PetStore
{
    partial class rbbSelectProduct
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bliProduct = new DevExpress.XtraBars.BarListItem();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbbpgSelectProduct = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbbpgTasks = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.grvProduct = new System.Windows.Forms.DataGridView();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.bliProduct,
            this.bbiAdd,
            this.bbiClose});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(820, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // bliProduct
            // 
            this.bliProduct.Caption = "Product";
            this.bliProduct.Id = 2;
            this.bliProduct.ImageOptions.ImageUri.Uri = "NavigationBar";
            this.bliProduct.Name = "bliProduct";
            this.bliProduct.Strings.AddRange(new object[] {
            "Pets",
            "Pet\'s Toys",
            "Pet\'s Foods",
            "Pet\'s Accessories",
            "Pet\'s Medicine"});
            this.bliProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bliProduct_ItemClick);
            // 
            // bbiAdd
            // 
            this.bbiAdd.Caption = "Add";
            this.bbiAdd.Enabled = false;
            this.bbiAdd.Id = 3;
            this.bbiAdd.ImageOptions.ImageUri.Uri = "Add";
            this.bbiAdd.Name = "bbiAdd";
            this.bbiAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAdd_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbbpgSelectProduct,
            this.rbbpgTasks});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // rbbpgSelectProduct
            // 
            this.rbbpgSelectProduct.AllowTextClipping = false;
            this.rbbpgSelectProduct.ItemLinks.Add(this.bliProduct);
            this.rbbpgSelectProduct.Name = "rbbpgSelectProduct";
            this.rbbpgSelectProduct.Text = "Pets";
            // 
            // rbbpgTasks
            // 
            this.rbbpgTasks.ItemLinks.Add(this.bbiAdd);
            this.rbbpgTasks.ItemLinks.Add(this.bbiClose);
            this.rbbpgTasks.Name = "rbbpgTasks";
            this.rbbpgTasks.Text = "Tasks";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 509);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(820, 31);
            // 
            // grvProduct
            // 
            this.grvProduct.AllowUserToAddRows = false;
            this.grvProduct.AllowUserToDeleteRows = false;
            this.grvProduct.AllowUserToResizeRows = false;
            this.grvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvProduct.Location = new System.Drawing.Point(0, 143);
            this.grvProduct.Name = "grvProduct";
            this.grvProduct.ReadOnly = true;
            this.grvProduct.Size = new System.Drawing.Size(820, 366);
            this.grvProduct.TabIndex = 5;
            this.grvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvProduct_CellClick);
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 4;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // rbbSelectProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 540);
            this.ControlBox = false;
            this.Controls.Add(this.grvProduct);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "rbbSelectProduct";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Select Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbbpgSelectProduct;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarListItem bliProduct;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbbpgTasks;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        public System.Windows.Forms.DataGridView grvProduct;
    }
}