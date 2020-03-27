namespace PetStore
{
    partial class DetailGift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailGift));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.btnChangeImage = new DevExpress.XtraEditors.SimpleButton();
            this.lctBox = new DevExpress.XtraLayout.LayoutControl();
            this.txt_gStatus = new DevExpress.XtraEditors.TextEdit();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.txt_gName = new DevExpress.XtraEditors.TextEdit();
            this.txt_pID = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtG_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.PFName = new DevExpress.XtraLayout.LayoutControlItem();
            this.PFStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbbPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ((System.ComponentModel.ISupportInitialize)(this.lctBox)).BeginInit();
            this.lctBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtG_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnChangeImage.Appearance.Options.UseFont = true;
            this.btnChangeImage.AutoSize = true;
            this.btnChangeImage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeImage.ImageOptions.Image")));
            this.btnChangeImage.Location = new System.Drawing.Point(350, 483);
            this.btnChangeImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnChangeImage.Size = new System.Drawing.Size(40, 38);
            toolTipItem1.Text = "Change Image of Pet\'s food";
            superToolTip1.Items.Add(toolTipItem1);
            this.btnChangeImage.SuperTip = superToolTip1;
            this.btnChangeImage.TabIndex = 20;
            // 
            // lctBox
            // 
            this.lctBox.Controls.Add(this.txt_gStatus);
            this.lctBox.Controls.Add(this.txt_gName);
            this.lctBox.Controls.Add(this.txt_pID);
            this.lctBox.Location = new System.Drawing.Point(350, 230);
            this.lctBox.Margin = new System.Windows.Forms.Padding(2);
            this.lctBox.Name = "lctBox";
            this.lctBox.Root = this.Root;
            this.lctBox.Size = new System.Drawing.Size(343, 220);
            this.lctBox.TabIndex = 19;
            this.lctBox.Text = "layoutControl1";
            // 
            // txt_gStatus
            // 
            this.txt_gStatus.Location = new System.Drawing.Point(58, 72);
            this.txt_gStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txt_gStatus.MenuManager = this.ribbonControl1;
            this.txt_gStatus.Name = "txt_gStatus";
            this.txt_gStatus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_gStatus.Properties.Appearance.Options.UseFont = true;
            this.txt_gStatus.Properties.ReadOnly = true;
            this.txt_gStatus.Size = new System.Drawing.Size(273, 26);
            this.txt_gStatus.StyleController = this.lctBox;
            this.txt_gStatus.TabIndex = 10;
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 528);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(740, 31);
            // 
            // txt_gName
            // 
            this.txt_gName.Location = new System.Drawing.Point(58, 42);
            this.txt_gName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_gName.MenuManager = this.ribbonControl1;
            this.txt_gName.Name = "txt_gName";
            this.txt_gName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_gName.Properties.Appearance.Options.UseFont = true;
            this.txt_gName.Properties.ReadOnly = true;
            this.txt_gName.Size = new System.Drawing.Size(273, 26);
            this.txt_gName.StyleController = this.lctBox;
            this.txt_gName.TabIndex = 5;
            // 
            // txt_pID
            // 
            this.txt_pID.Location = new System.Drawing.Point(58, 12);
            this.txt_pID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pID.MenuManager = this.ribbonControl1;
            this.txt_pID.Name = "txt_pID";
            this.txt_pID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_pID.Properties.Appearance.Options.UseFont = true;
            this.txt_pID.Properties.ReadOnly = true;
            this.txt_pID.Size = new System.Drawing.Size(273, 26);
            this.txt_pID.StyleController = this.lctBox;
            this.txt_pID.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.txtG_ID,
            this.PFName,
            this.PFStatus});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(343, 220);
            this.Root.TextVisible = false;
            // 
            // txtG_ID
            // 
            this.txtG_ID.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtG_ID.AppearanceItemCaption.Options.UseFont = true;
            this.txtG_ID.Control = this.txt_pID;
            this.txtG_ID.Location = new System.Drawing.Point(0, 0);
            this.txtG_ID.Name = "txtG_ID";
            this.txtG_ID.Size = new System.Drawing.Size(323, 30);
            this.txtG_ID.Text = "ID";
            this.txtG_ID.TextSize = new System.Drawing.Size(43, 19);
            // 
            // PFName
            // 
            this.PFName.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFName.AppearanceItemCaption.Options.UseFont = true;
            this.PFName.Control = this.txt_gName;
            this.PFName.Location = new System.Drawing.Point(0, 30);
            this.PFName.Name = "PFName";
            this.PFName.Size = new System.Drawing.Size(323, 30);
            this.PFName.Text = "Name";
            this.PFName.TextSize = new System.Drawing.Size(43, 19);
            // 
            // PFStatus
            // 
            this.PFStatus.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFStatus.AppearanceItemCaption.Options.UseFont = true;
            this.PFStatus.Control = this.txt_gStatus;
            this.PFStatus.Location = new System.Drawing.Point(0, 60);
            this.PFStatus.Name = "PFStatus";
            this.PFStatus.Size = new System.Drawing.Size(323, 140);
            this.PFStatus.Text = "Status";
            this.PFStatus.TextSize = new System.Drawing.Size(43, 19);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(355, 203);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(68, 24);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Name";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.Location = new System.Drawing.Point(352, 157);
            this.lblDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(112, 39);
            this.lblDetail.TabIndex = 18;
            this.lblDetail.Text = "Detail";
            // 
            // ptbImage
            // 
            this.ptbImage.Location = new System.Drawing.Point(9, 157);
            this.ptbImage.Margin = new System.Windows.Forms.Padding(2);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(330, 358);
            this.ptbImage.TabIndex = 16;
            this.ptbImage.TabStop = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbbPageGroup});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Tool";
            // 
            // rbbPageGroup
            // 
            this.rbbPageGroup.AllowTextClipping = false;
            this.rbbPageGroup.ItemLinks.Add(this.btnClose);
            this.rbbPageGroup.Name = "rbbPageGroup";
            this.rbbPageGroup.Text = "Detail Pet Food";
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Close";
            this.btnClose.Id = 1;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.LargeWidth = 70;
            this.btnClose.Name = "btnClose";
            toolTipItem2.Text = "Close view Pet\'s food detail";
            superToolTip2.Items.Add(toolTipItem2);
            this.btnClose.SuperTip = superToolTip2;
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnClose});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(740, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // DetailGift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 559);
            this.Controls.Add(this.btnChangeImage);
            this.Controls.Add(this.lctBox);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.ptbImage);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "DetailGift";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "DetailGift";
            ((System.ComponentModel.ISupportInitialize)(this.lctBox)).EndInit();
            this.lctBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_gStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtG_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnChangeImage;
        private DevExpress.XtraLayout.LayoutControl lctBox;
        public DevExpress.XtraEditors.TextEdit txt_gStatus;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbbPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        public DevExpress.XtraEditors.TextEdit txt_gName;
        public DevExpress.XtraEditors.TextEdit txt_pID;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem txtG_ID;
        private DevExpress.XtraLayout.LayoutControlItem PFName;
        private DevExpress.XtraLayout.LayoutControlItem PFStatus;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblDetail;
        public System.Windows.Forms.PictureBox ptbImage;
    }
}