namespace PetStore
{
    partial class CommentStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentStaff));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDeleteCmt = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestoreCmt = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshCmt = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewCmtd = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcComment = new DevExpress.XtraGrid.GridControl();
            this.gvComment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bindingSourceComment = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComment)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnDeleteCmt,
            this.btnRestoreCmt,
            this.btnRefreshCmt,
            this.btnViewCmtd});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1084, 178);
            // 
            // btnDeleteCmt
            // 
            this.btnDeleteCmt.Caption = "Delete comment";
            this.btnDeleteCmt.Id = 1;
            this.btnDeleteCmt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCmt.ImageOptions.Image")));
            this.btnDeleteCmt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteCmt.ImageOptions.LargeImage")));
            this.btnDeleteCmt.LargeWidth = 60;
            this.btnDeleteCmt.Name = "btnDeleteCmt";
            toolTipItem1.Text = "Delete comment of user";
            superToolTip1.Items.Add(toolTipItem1);
            this.btnDeleteCmt.SuperTip = superToolTip1;
            this.btnDeleteCmt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteCmt_ItemClick);
            // 
            // btnRestoreCmt
            // 
            this.btnRestoreCmt.Caption = "Restore comment";
            this.btnRestoreCmt.Id = 2;
            this.btnRestoreCmt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestoreCmt.ImageOptions.Image")));
            this.btnRestoreCmt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRestoreCmt.ImageOptions.LargeImage")));
            this.btnRestoreCmt.LargeWidth = 60;
            this.btnRestoreCmt.Name = "btnRestoreCmt";
            toolTipItem2.Text = "Restore comment of user";
            superToolTip2.Items.Add(toolTipItem2);
            this.btnRestoreCmt.SuperTip = superToolTip2;
            this.btnRestoreCmt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestoreCmt_ItemClick);
            // 
            // btnRefreshCmt
            // 
            this.btnRefreshCmt.Caption = "Refresh comment";
            this.btnRefreshCmt.Id = 3;
            this.btnRefreshCmt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshCmt.ImageOptions.Image")));
            this.btnRefreshCmt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshCmt.ImageOptions.LargeImage")));
            this.btnRefreshCmt.LargeWidth = 70;
            this.btnRefreshCmt.Name = "btnRefreshCmt";
            toolTipItem3.Text = "Refresh comment";
            superToolTip3.Items.Add(toolTipItem3);
            this.btnRefreshCmt.SuperTip = superToolTip3;
            this.btnRefreshCmt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshCmt_ItemClick);
            // 
            // btnViewCmtd
            // 
            this.btnViewCmtd.Caption = "View comment detail";
            this.btnViewCmtd.Id = 4;
            this.btnViewCmtd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewCmtd.ImageOptions.Image")));
            this.btnViewCmtd.LargeWidth = 105;
            this.btnViewCmtd.Name = "btnViewCmtd";
            this.btnViewCmtd.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipItem4.Text = "Open comment reply list management ";
            superToolTip4.Items.Add(toolTipItem4);
            this.btnViewCmtd.SuperTip = superToolTip4;
            this.btnViewCmtd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewCmtd_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Tool";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDeleteCmt);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRestoreCmt);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefreshCmt);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Comment Management";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnViewCmtd);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Comment Detail";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcComment);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 178);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1084, 578);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcComment
            // 
            this.gcComment.Location = new System.Drawing.Point(12, 12);
            this.gcComment.MainView = this.gvComment;
            this.gcComment.MenuManager = this.ribbon;
            this.gcComment.Name = "gcComment";
            this.gcComment.Size = new System.Drawing.Size(1060, 554);
            this.gcComment.TabIndex = 4;
            this.gcComment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvComment});
            // 
            // gvComment
            // 
            this.gvComment.GridControl = this.gcComment;
            this.gvComment.Name = "gvComment";
            this.gvComment.OptionsBehavior.Editable = false;
            this.gvComment.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvComment_RowClick);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1084, 578);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcComment;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1064, 558);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // CommentStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 755);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbon);
            this.Name = "CommentStaff";
            this.Ribbon = this.ribbon;
            this.Text = "CommentStaff";
            this.Load += new System.EventHandler(this.CommentStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDeleteCmt;
        private DevExpress.XtraBars.BarButtonItem btnRestoreCmt;
        private DevExpress.XtraBars.BarButtonItem btnRefreshCmt;
        private DevExpress.XtraBars.BarButtonItem btnViewCmtd;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcComment;
        private DevExpress.XtraGrid.Views.Grid.GridView gvComment;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bindingSourceComment;
    }
}