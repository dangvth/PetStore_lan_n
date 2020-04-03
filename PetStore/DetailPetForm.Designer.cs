namespace PetStore
{
    partial class DetailPetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailPetForm));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.btnChangeImage = new DevExpress.XtraEditors.SimpleButton();
            this.lctBox = new DevExpress.XtraLayout.LayoutControl();
            this.txt_pStatus = new DevExpress.XtraEditors.TextEdit();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbbPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.txt_Type = new DevExpress.XtraEditors.TextEdit();
            this.txt_pPriceSale = new DevExpress.XtraEditors.TextEdit();
            this.txt_pOriginPrice = new DevExpress.XtraEditors.TextEdit();
            this.txt_pName = new DevExpress.XtraEditors.TextEdit();
            this.txt_pID = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.PFID = new DevExpress.XtraLayout.LayoutControlItem();
            this.PFName = new DevExpress.XtraLayout.LayoutControlItem();
            this.PFPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.PFPriceSale = new DevExpress.XtraLayout.LayoutControlItem();
            this.PFType = new DevExpress.XtraLayout.LayoutControlItem();
            this.PFStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblDetail = new System.Windows.Forms.Label();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lctBox)).BeginInit();
            this.lctBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pPriceSale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pOriginPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFPriceSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnChangeImage.Appearance.Options.UseFont = true;
            this.btnChangeImage.AutoSize = true;
            this.btnChangeImage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeImage.ImageOptions.Image")));
            this.btnChangeImage.Location = new System.Drawing.Point(350, 483);
            this.btnChangeImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnChangeImage.Size = new System.Drawing.Size(40, 38);
            toolTipItem1.Text = "Change Image of Pet\'s food";
            superToolTip1.Items.Add(toolTipItem1);
            this.btnChangeImage.SuperTip = superToolTip1;
            this.btnChangeImage.TabIndex = 13;
            // 
            // lctBox
            // 
            this.lctBox.Controls.Add(this.txt_pStatus);
            this.lctBox.Controls.Add(this.txt_Type);
            this.lctBox.Controls.Add(this.txt_pPriceSale);
            this.lctBox.Controls.Add(this.txt_pOriginPrice);
            this.lctBox.Controls.Add(this.txt_pName);
            this.lctBox.Controls.Add(this.txt_pID);
            this.lctBox.Location = new System.Drawing.Point(350, 230);
            this.lctBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lctBox.Name = "lctBox";
            this.lctBox.Root = this.Root;
            this.lctBox.Size = new System.Drawing.Size(343, 220);
            this.lctBox.TabIndex = 12;
            this.lctBox.Text = "layoutControl1";
            // 
            // txt_pStatus
            // 
            this.txt_pStatus.Location = new System.Drawing.Point(93, 160);
            this.txt_pStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_pStatus.MenuManager = this.ribbon;
            this.txt_pStatus.Name = "txt_pStatus";
            this.txt_pStatus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_pStatus.Properties.Appearance.Options.UseFont = true;
            this.txt_pStatus.Properties.ReadOnly = true;
            this.txt_pStatus.Size = new System.Drawing.Size(242, 26);
            this.txt_pStatus.StyleController = this.lctBox;
            this.txt_pStatus.TabIndex = 10;
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnClose});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(734, 141);
            this.ribbon.StatusBar = this.ribbonStatusBar;
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbbPageGroup});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Tool";
            // 
            // rbbPageGroup
            // 
            this.rbbPageGroup.AllowTextClipping = false;
            this.rbbPageGroup.ItemLinks.Add(this.btnClose);
            this.rbbPageGroup.Name = "rbbPageGroup";
            this.rbbPageGroup.Text = "Detail Pet Food";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 528);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(734, 27);
            // 
            // txt_Type
            // 
            this.txt_Type.Location = new System.Drawing.Point(93, 130);
            this.txt_Type.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Type.MenuManager = this.ribbon;
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_Type.Properties.Appearance.Options.UseFont = true;
            this.txt_Type.Properties.ReadOnly = true;
            this.txt_Type.Size = new System.Drawing.Size(242, 26);
            this.txt_Type.StyleController = this.lctBox;
            this.txt_Type.TabIndex = 9;
            // 
            // txt_pPriceSale
            // 
            this.txt_pPriceSale.Location = new System.Drawing.Point(93, 100);
            this.txt_pPriceSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_pPriceSale.MenuManager = this.ribbon;
            this.txt_pPriceSale.Name = "txt_pPriceSale";
            this.txt_pPriceSale.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_pPriceSale.Properties.Appearance.Options.UseFont = true;
            this.txt_pPriceSale.Properties.ReadOnly = true;
            this.txt_pPriceSale.Size = new System.Drawing.Size(242, 26);
            this.txt_pPriceSale.StyleController = this.lctBox;
            this.txt_pPriceSale.TabIndex = 7;
            // 
            // txt_pOriginPrice
            // 
            this.txt_pOriginPrice.Location = new System.Drawing.Point(93, 70);
            this.txt_pOriginPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_pOriginPrice.MenuManager = this.ribbon;
            this.txt_pOriginPrice.Name = "txt_pOriginPrice";
            this.txt_pOriginPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_pOriginPrice.Properties.Appearance.Options.UseFont = true;
            this.txt_pOriginPrice.Properties.ReadOnly = true;
            this.txt_pOriginPrice.Size = new System.Drawing.Size(242, 26);
            this.txt_pOriginPrice.StyleController = this.lctBox;
            this.txt_pOriginPrice.TabIndex = 6;
            // 
            // txt_pName
            // 
            this.txt_pName.Location = new System.Drawing.Point(93, 40);
            this.txt_pName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_pName.MenuManager = this.ribbon;
            this.txt_pName.Name = "txt_pName";
            this.txt_pName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_pName.Properties.Appearance.Options.UseFont = true;
            this.txt_pName.Properties.ReadOnly = true;
            this.txt_pName.Size = new System.Drawing.Size(242, 26);
            this.txt_pName.StyleController = this.lctBox;
            this.txt_pName.TabIndex = 5;
            // 
            // txt_pID
            // 
            this.txt_pID.Location = new System.Drawing.Point(93, 10);
            this.txt_pID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_pID.MenuManager = this.ribbon;
            this.txt_pID.Name = "txt_pID";
            this.txt_pID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_pID.Properties.Appearance.Options.UseFont = true;
            this.txt_pID.Properties.ReadOnly = true;
            this.txt_pID.Size = new System.Drawing.Size(242, 26);
            this.txt_pID.StyleController = this.lctBox;
            this.txt_pID.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.PFID,
            this.PFName,
            this.PFPrice,
            this.PFPriceSale,
            this.PFType,
            this.PFStatus});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(343, 220);
            this.Root.TextVisible = false;
            // 
            // PFID
            // 
            this.PFID.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFID.AppearanceItemCaption.Options.UseFont = true;
            this.PFID.Control = this.txt_pID;
            this.PFID.Location = new System.Drawing.Point(0, 0);
            this.PFID.Name = "PFID";
            this.PFID.Size = new System.Drawing.Size(329, 30);
            this.PFID.Text = "ID";
            this.PFID.TextSize = new System.Drawing.Size(83, 19);
            // 
            // PFName
            // 
            this.PFName.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFName.AppearanceItemCaption.Options.UseFont = true;
            this.PFName.Control = this.txt_pName;
            this.PFName.Location = new System.Drawing.Point(0, 30);
            this.PFName.Name = "PFName";
            this.PFName.Size = new System.Drawing.Size(329, 30);
            this.PFName.Text = "Name";
            this.PFName.TextSize = new System.Drawing.Size(83, 19);
            // 
            // PFPrice
            // 
            this.PFPrice.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFPrice.AppearanceItemCaption.Options.UseFont = true;
            this.PFPrice.Control = this.txt_pOriginPrice;
            this.PFPrice.Location = new System.Drawing.Point(0, 60);
            this.PFPrice.Name = "PFPrice";
            this.PFPrice.Size = new System.Drawing.Size(329, 30);
            this.PFPrice.Text = "Origin price";
            this.PFPrice.TextSize = new System.Drawing.Size(83, 19);
            // 
            // PFPriceSale
            // 
            this.PFPriceSale.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFPriceSale.AppearanceItemCaption.Options.UseFont = true;
            this.PFPriceSale.Control = this.txt_pPriceSale;
            this.PFPriceSale.Location = new System.Drawing.Point(0, 90);
            this.PFPriceSale.Name = "PFPriceSale";
            this.PFPriceSale.Size = new System.Drawing.Size(329, 30);
            this.PFPriceSale.Text = "Sell price";
            this.PFPriceSale.TextSize = new System.Drawing.Size(83, 19);
            // 
            // PFType
            // 
            this.PFType.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFType.AppearanceItemCaption.Options.UseFont = true;
            this.PFType.Control = this.txt_Type;
            this.PFType.Location = new System.Drawing.Point(0, 120);
            this.PFType.Name = "PFType";
            this.PFType.Size = new System.Drawing.Size(329, 30);
            this.PFType.Text = "Type";
            this.PFType.TextSize = new System.Drawing.Size(83, 19);
            // 
            // PFStatus
            // 
            this.PFStatus.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFStatus.AppearanceItemCaption.Options.UseFont = true;
            this.PFStatus.Control = this.txt_pStatus;
            this.PFStatus.Location = new System.Drawing.Point(0, 150);
            this.PFStatus.Name = "PFStatus";
            this.PFStatus.Size = new System.Drawing.Size(329, 54);
            this.PFStatus.Text = "Status";
            this.PFStatus.TextSize = new System.Drawing.Size(83, 19);
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.Location = new System.Drawing.Point(352, 157);
            this.lblDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(112, 39);
            this.lblDetail.TabIndex = 11;
            this.lblDetail.Text = "Detail";
            // 
            // ptbImage
            // 
            this.ptbImage.Location = new System.Drawing.Point(9, 157);
            this.ptbImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(330, 358);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbImage.TabIndex = 10;
            this.ptbImage.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(355, 203);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(68, 24);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Name";
            // 
            // DetailPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 555);
            this.Controls.Add(this.btnChangeImage);
            this.Controls.Add(this.lctBox);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.ptbImage);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DetailPetForm";
            this.Text = "Pet Detail";
            ((System.ComponentModel.ISupportInitialize)(this.lctBox)).EndInit();
            this.lctBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_pStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pPriceSale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pOriginPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFPriceSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnChangeImage;
        private DevExpress.XtraLayout.LayoutControl lctBox;
        public DevExpress.XtraEditors.TextEdit txt_pStatus;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbbPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        public DevExpress.XtraEditors.TextEdit txt_Type;
        public DevExpress.XtraEditors.TextEdit txt_pPriceSale;
        public DevExpress.XtraEditors.TextEdit txt_pOriginPrice;
        public DevExpress.XtraEditors.TextEdit txt_pName;
        public DevExpress.XtraEditors.TextEdit txt_pID;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem PFID;
        private DevExpress.XtraLayout.LayoutControlItem PFName;
        private DevExpress.XtraLayout.LayoutControlItem PFPrice;
        private DevExpress.XtraLayout.LayoutControlItem PFPriceSale;
        private DevExpress.XtraLayout.LayoutControlItem PFType;
        private DevExpress.XtraLayout.LayoutControlItem PFStatus;
        public System.Windows.Forms.Label lblDetail;
        public System.Windows.Forms.PictureBox ptbImage;
        public System.Windows.Forms.Label lblTitle;
    }
}