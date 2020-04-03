namespace PetStore
{
    partial class OnlineOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlineOrder));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiAccept = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.grvOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.bbiAccept,
            this.bbiCancel,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(827, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // bbiAccept
            // 
            this.bbiAccept.Caption = "Accept";
            this.bbiAccept.Id = 1;
            this.bbiAccept.ImageOptions.ImageUri.Uri = "Apply";
            this.bbiAccept.Name = "bbiAccept";
            this.bbiAccept.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAccept_ItemClick);
            // 
            // bbiCancel
            // 
            this.bbiCancel.Caption = "Cancel";
            this.bbiCancel.Id = 2;
            this.bbiCancel.ImageOptions.ImageUri.Uri = "Cancel";
            this.bbiCancel.Name = "bbiCancel";
            this.bbiCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancel_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Detail";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Online Order";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAccept);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancel);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 526);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(827, 31);
            // 
            // grvOrder
            // 
            this.grvOrder.AllowUserToAddRows = false;
            this.grvOrder.AllowUserToDeleteRows = false;
            this.grvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvOrder.Location = new System.Drawing.Point(0, 143);
            this.grvOrder.Name = "grvOrder";
            this.grvOrder.ReadOnly = true;
            this.grvOrder.Size = new System.Drawing.Size(827, 383);
            this.grvOrder.TabIndex = 2;
            this.grvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvOrder_CellClick);
            // 
            // OnlineOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 557);
            this.ControlBox = false;
            this.Controls.Add(this.grvOrder);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "OnlineOrder";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "OnlineOrder";
            this.Load += new System.EventHandler(this.OnlineOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bbiAccept;
        private DevExpress.XtraBars.BarButtonItem bbiCancel;
        private System.Windows.Forms.DataGridView grvOrder;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}