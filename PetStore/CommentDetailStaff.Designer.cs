namespace PetStore
{
    partial class CommentDetailStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentDetailStaff));
            DevExpress.Utils.SuperToolTip superToolTip9 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem9 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip10 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem10 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip11 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem11 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip12 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem12 = new DevExpress.Utils.ToolTipItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnRemove = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.commentDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colcmtd_published = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcmtd_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCmtDetail = new DevExpress.XtraGrid.GridControl();
            this.gvCommentDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCmtDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCommentDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnRemove,
            this.btnRestore,
            this.btnRefresh,
            this.btnClose});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1144, 178);
            // 
            // btnRemove
            // 
            this.btnRemove.Caption = "Remove";
            this.btnRemove.Id = 1;
            this.btnRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.ImageOptions.Image")));
            this.btnRemove.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.ImageOptions.LargeImage")));
            this.btnRemove.LargeWidth = 60;
            this.btnRemove.Name = "btnRemove";
            toolTipItem9.Text = "Remove comment reply of user";
            superToolTip9.Items.Add(toolTipItem9);
            this.btnRemove.SuperTip = superToolTip9;
            this.btnRemove.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemove_ItemClick);
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Restore";
            this.btnRestore.Id = 2;
            this.btnRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.Image")));
            this.btnRestore.LargeWidth = 60;
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipItem10.Text = "Restore comment reply of user";
            superToolTip10.Items.Add(toolTipItem10);
            this.btnRestore.SuperTip = superToolTip10;
            this.btnRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestore_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 3;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.LargeWidth = 60;
            this.btnRefresh.Name = "btnRefresh";
            toolTipItem11.Text = "Refresh comment reply";
            superToolTip11.Items.Add(toolTipItem11);
            this.btnRefresh.SuperTip = superToolTip11;
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Close";
            this.btnClose.Id = 4;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.LargeImage")));
            this.btnClose.LargeWidth = 60;
            this.btnClose.Name = "btnClose";
            toolTipItem12.Text = "Close comment reply management";
            superToolTip12.Items.Add(toolTipItem12);
            this.btnClose.SuperTip = superToolTip12;
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRemove);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRestore);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Comment detail management";
            // 
            // colcmtd_published
            // 
            this.colcmtd_published.Caption = "Published";
            this.colcmtd_published.FieldName = "cmtd_published";
            this.colcmtd_published.MinWidth = 25;
            this.colcmtd_published.Name = "colcmtd_published";
            this.colcmtd_published.Visible = true;
            this.colcmtd_published.VisibleIndex = 0;
            this.colcmtd_published.Width = 94;
            // 
            // colcmtd_status
            // 
            this.colcmtd_status.Caption = "Status";
            this.colcmtd_status.FieldName = "cmtd_status";
            this.colcmtd_status.MinWidth = 25;
            this.colcmtd_status.Name = "colcmtd_status";
            this.colcmtd_status.Visible = true;
            this.colcmtd_status.VisibleIndex = 2;
            this.colcmtd_status.Width = 94;
            // 
            // UserID
            // 
            this.UserID.Caption = "User ID";
            this.UserID.FieldName = "u_name";
            this.UserID.MinWidth = 25;
            this.UserID.Name = "UserID";
            this.UserID.Visible = true;
            this.UserID.VisibleIndex = 1;
            this.UserID.Width = 94;
            // 
            // gcCmtDetail
            // 
            this.gcCmtDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCmtDetail.Location = new System.Drawing.Point(0, 178);
            this.gcCmtDetail.MainView = this.gvCommentDetail;
            this.gcCmtDetail.MenuManager = this.ribbon;
            this.gcCmtDetail.Name = "gcCmtDetail";
            this.gcCmtDetail.Size = new System.Drawing.Size(1144, 528);
            this.gcCmtDetail.TabIndex = 6;
            this.gcCmtDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCommentDetail});
            // 
            // gvCommentDetail
            // 
            this.gvCommentDetail.GridControl = this.gcCmtDetail;
            this.gvCommentDetail.Name = "gvCommentDetail";
            this.gvCommentDetail.OptionsBehavior.Editable = false;
            this.gvCommentDetail.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvCommentDetail_RowClick);
            // 
            // CommentDetailStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 706);
            this.Controls.Add(this.gcCmtDetail);
            this.Controls.Add(this.ribbon);
            this.Name = "CommentDetailStaff";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommentDetailStaff";
            this.Load += new System.EventHandler(this.CommentDetailStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCmtDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCommentDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnRemove;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private System.Windows.Forms.BindingSource commentDetailBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colcmtd_published;
        private DevExpress.XtraGrid.Columns.GridColumn colcmtd_status;
        private DevExpress.XtraGrid.Columns.GridColumn UserID;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraGrid.GridControl gcCmtDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCommentDetail;
    }
}