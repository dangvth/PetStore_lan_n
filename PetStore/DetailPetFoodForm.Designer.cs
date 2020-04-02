namespace PetStore
{
    partial class DetailPetFoodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailPetFoodForm));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbbPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lctBox = new DevExpress.XtraLayout.LayoutControl();
            this.te_pfStatus = new DevExpress.XtraEditors.TextEdit();
            this.te_Type = new DevExpress.XtraEditors.TextEdit();
            this.te_pfAmount = new DevExpress.XtraEditors.TextEdit();
            this.te_pfPriceSale = new DevExpress.XtraEditors.TextEdit();
            this.te_pfPrice = new DevExpress.XtraEditors.TextEdit();
            this.te_pfName = new DevExpress.XtraEditors.TextEdit();
            this.te_pfID = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.PFID = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.PFName = new DevExpress.XtraLayout.LayoutControlItem();
            this.PFPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.PFPriceSale = new DevExpress.XtraLayout.LayoutControlItem();
            this.PFAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.PFType = new DevExpress.XtraLayout.LayoutControlItem();
            this.PFStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnChangeImage = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lctBox)).BeginInit();
            this.lctBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_pfStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_pfAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_pfPriceSale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_pfPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_pfName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_pfID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFPriceSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnClose});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(922, 178);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Close";
            this.btnClose.Id = 1;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.LargeWidth = 70;
            this.btnClose.Name = "btnClose";
            toolTipItem1.Text = "Close view Pet\'s food detail";
            superToolTip1.Items.Add(toolTipItem1);
            this.btnClose.SuperTip = superToolTip1;
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 645);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(922, 37);
            // 
            // ptbImage
            // 
            this.ptbImage.Location = new System.Drawing.Point(12, 193);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(440, 440);
            this.ptbImage.TabIndex = 2;
            this.ptbImage.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(471, 211);
            this.lblTitle.MaximumSize = new System.Drawing.Size(440, 70);
            this.lblTitle.MinimumSize = new System.Drawing.Size(440, 70);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(440, 70);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Detail";
            // 
            // lctBox
            // 
            this.lctBox.AutoSize = true;
            this.lctBox.Controls.Add(this.te_pfStatus);
            this.lctBox.Controls.Add(this.te_Type);
            this.lctBox.Controls.Add(this.te_pfAmount);
            this.lctBox.Controls.Add(this.te_pfPriceSale);
            this.lctBox.Controls.Add(this.te_pfPrice);
            this.lctBox.Controls.Add(this.te_pfName);
            this.lctBox.Controls.Add(this.te_pfID);
            this.lctBox.Location = new System.Drawing.Point(466, 278);
            this.lctBox.Name = "lctBox";
            this.lctBox.Root = this.Root;
            this.lctBox.Size = new System.Drawing.Size(457, 312);
            this.lctBox.TabIndex = 4;
            this.lctBox.Text = "layoutControl1";
            // 
            // te_pfStatus
            // 
            this.te_pfStatus.Location = new System.Drawing.Point(117, 260);
            this.te_pfStatus.MenuManager = this.ribbon;
            this.te_pfStatus.Name = "te_pfStatus";
            this.te_pfStatus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_pfStatus.Properties.Appearance.Options.UseFont = true;
            this.te_pfStatus.Properties.ReadOnly = true;
            this.te_pfStatus.Size = new System.Drawing.Size(328, 30);
            this.te_pfStatus.StyleController = this.lctBox;
            this.te_pfStatus.TabIndex = 10;
            // 
            // te_Type
            // 
            this.te_Type.Location = new System.Drawing.Point(117, 226);
            this.te_Type.MenuManager = this.ribbon;
            this.te_Type.Name = "te_Type";
            this.te_Type.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_Type.Properties.Appearance.Options.UseFont = true;
            this.te_Type.Properties.ReadOnly = true;
            this.te_Type.Size = new System.Drawing.Size(328, 30);
            this.te_Type.StyleController = this.lctBox;
            this.te_Type.TabIndex = 9;
            // 
            // te_pfAmount
            // 
            this.te_pfAmount.Location = new System.Drawing.Point(117, 192);
            this.te_pfAmount.MenuManager = this.ribbon;
            this.te_pfAmount.Name = "te_pfAmount";
            this.te_pfAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_pfAmount.Properties.Appearance.Options.UseFont = true;
            this.te_pfAmount.Properties.ReadOnly = true;
            this.te_pfAmount.Size = new System.Drawing.Size(328, 30);
            this.te_pfAmount.StyleController = this.lctBox;
            this.te_pfAmount.TabIndex = 8;
            // 
            // te_pfPriceSale
            // 
            this.te_pfPriceSale.Location = new System.Drawing.Point(117, 158);
            this.te_pfPriceSale.MenuManager = this.ribbon;
            this.te_pfPriceSale.Name = "te_pfPriceSale";
            this.te_pfPriceSale.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_pfPriceSale.Properties.Appearance.Options.UseFont = true;
            this.te_pfPriceSale.Properties.ReadOnly = true;
            this.te_pfPriceSale.Size = new System.Drawing.Size(328, 30);
            this.te_pfPriceSale.StyleController = this.lctBox;
            this.te_pfPriceSale.TabIndex = 7;
            // 
            // te_pfPrice
            // 
            this.te_pfPrice.Location = new System.Drawing.Point(117, 124);
            this.te_pfPrice.MenuManager = this.ribbon;
            this.te_pfPrice.Name = "te_pfPrice";
            this.te_pfPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_pfPrice.Properties.Appearance.Options.UseFont = true;
            this.te_pfPrice.Properties.ReadOnly = true;
            this.te_pfPrice.Size = new System.Drawing.Size(328, 30);
            this.te_pfPrice.StyleController = this.lctBox;
            this.te_pfPrice.TabIndex = 6;
            // 
            // te_pfName
            // 
            this.te_pfName.AllowDrop = true;
            this.te_pfName.EditValue = "Text By Nguyen Minh Thao CE130353 SE1302";
            this.te_pfName.Location = new System.Drawing.Point(117, 46);
            this.te_pfName.MaximumSize = new System.Drawing.Size(328, 80);
            this.te_pfName.MenuManager = this.ribbon;
            this.te_pfName.MinimumSize = new System.Drawing.Size(328, 70);
            this.te_pfName.Name = "te_pfName";
            this.te_pfName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_pfName.Properties.Appearance.Options.UseFont = true;
            this.te_pfName.Properties.ReadOnly = true;
            this.te_pfName.Size = new System.Drawing.Size(328, 70);
            this.te_pfName.StyleController = this.lctBox;
            this.te_pfName.TabIndex = 5;
            // 
            // te_pfID
            // 
            this.te_pfID.Location = new System.Drawing.Point(117, 12);
            this.te_pfID.MenuManager = this.ribbon;
            this.te_pfID.Name = "te_pfID";
            this.te_pfID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.te_pfID.Properties.Appearance.Options.UseFont = true;
            this.te_pfID.Properties.ReadOnly = true;
            this.te_pfID.Size = new System.Drawing.Size(328, 30);
            this.te_pfID.StyleController = this.lctBox;
            this.te_pfID.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.PFID,
            this.emptySpaceItem1,
            this.PFName,
            this.PFPrice,
            this.PFPriceSale,
            this.PFAmount,
            this.PFType,
            this.PFStatus});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(457, 312);
            this.Root.TextVisible = false;
            // 
            // PFID
            // 
            this.PFID.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFID.AppearanceItemCaption.Options.UseFont = true;
            this.PFID.Control = this.te_pfID;
            this.PFID.Location = new System.Drawing.Point(0, 0);
            this.PFID.Name = "PFID";
            this.PFID.Size = new System.Drawing.Size(437, 34);
            this.PFID.TextSize = new System.Drawing.Size(102, 24);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 282);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(437, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // PFName
            // 
            this.PFName.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFName.AppearanceItemCaption.Options.UseFont = true;
            this.PFName.Control = this.te_pfName;
            this.PFName.Location = new System.Drawing.Point(0, 34);
            this.PFName.MaxSize = new System.Drawing.Size(437, 78);
            this.PFName.MinSize = new System.Drawing.Size(437, 78);
            this.PFName.Name = "PFName";
            this.PFName.OptionsCustomization.AllowDrop = DevExpress.XtraLayout.ItemDragDropMode.UseParentOptions;
            this.PFName.Size = new System.Drawing.Size(437, 78);
            this.PFName.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.PFName.TextSize = new System.Drawing.Size(102, 24);
            // 
            // PFPrice
            // 
            this.PFPrice.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFPrice.AppearanceItemCaption.Options.UseFont = true;
            this.PFPrice.Control = this.te_pfPrice;
            this.PFPrice.Location = new System.Drawing.Point(0, 112);
            this.PFPrice.Name = "PFPrice";
            this.PFPrice.Size = new System.Drawing.Size(437, 34);
            this.PFPrice.TextSize = new System.Drawing.Size(102, 24);
            // 
            // PFPriceSale
            // 
            this.PFPriceSale.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFPriceSale.AppearanceItemCaption.Options.UseFont = true;
            this.PFPriceSale.Control = this.te_pfPriceSale;
            this.PFPriceSale.Location = new System.Drawing.Point(0, 146);
            this.PFPriceSale.Name = "PFPriceSale";
            this.PFPriceSale.Size = new System.Drawing.Size(437, 34);
            this.PFPriceSale.TextSize = new System.Drawing.Size(102, 24);
            // 
            // PFAmount
            // 
            this.PFAmount.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFAmount.AppearanceItemCaption.Options.UseFont = true;
            this.PFAmount.Control = this.te_pfAmount;
            this.PFAmount.Location = new System.Drawing.Point(0, 180);
            this.PFAmount.Name = "PFAmount";
            this.PFAmount.Size = new System.Drawing.Size(437, 34);
            this.PFAmount.TextSize = new System.Drawing.Size(102, 24);
            // 
            // PFType
            // 
            this.PFType.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFType.AppearanceItemCaption.Options.UseFont = true;
            this.PFType.Control = this.te_Type;
            this.PFType.Location = new System.Drawing.Point(0, 214);
            this.PFType.Name = "PFType";
            this.PFType.Size = new System.Drawing.Size(437, 34);
            this.PFType.TextSize = new System.Drawing.Size(102, 24);
            // 
            // PFStatus
            // 
            this.PFStatus.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFStatus.AppearanceItemCaption.Options.UseFont = true;
            this.PFStatus.Control = this.te_pfStatus;
            this.PFStatus.Location = new System.Drawing.Point(0, 248);
            this.PFStatus.Name = "PFStatus";
            this.PFStatus.Size = new System.Drawing.Size(437, 34);
            this.PFStatus.TextSize = new System.Drawing.Size(102, 24);
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnChangeImage.Appearance.Options.UseFont = true;
            this.btnChangeImage.AutoSize = true;
            this.btnChangeImage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeImage.ImageOptions.Image")));
            this.btnChangeImage.Location = new System.Drawing.Point(466, 595);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnChangeImage.Size = new System.Drawing.Size(40, 38);
            toolTipItem2.Text = "Change Image of Pet\'s food";
            superToolTip2.Items.Add(toolTipItem2);
            this.btnChangeImage.SuperTip = superToolTip2;
            this.btnChangeImage.TabIndex = 7;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // DetailPetFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 682);
            this.Controls.Add(this.btnChangeImage);
            this.Controls.Add(this.lctBox);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ptbImage);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailPetFoodForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Detail Pet Food";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lctBox)).EndInit();
            this.lctBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.te_pfStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_pfAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_pfPriceSale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_pfPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_pfName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_pfID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFPriceSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbbPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        public System.Windows.Forms.PictureBox ptbImage;
        private DevExpress.XtraLayout.LayoutControl lctBox;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem PFID;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem PFName;
        private DevExpress.XtraLayout.LayoutControlItem PFPrice;
        private DevExpress.XtraLayout.LayoutControlItem PFPriceSale;
        private DevExpress.XtraLayout.LayoutControlItem PFAmount;
        private DevExpress.XtraLayout.LayoutControlItem PFType;
        private DevExpress.XtraLayout.LayoutControlItem PFStatus;
        public System.Windows.Forms.Label lblTitle;
        public DevExpress.XtraEditors.TextEdit te_pfAmount;
        public DevExpress.XtraEditors.TextEdit te_pfPriceSale;
        public DevExpress.XtraEditors.TextEdit te_pfPrice;
        public DevExpress.XtraEditors.TextEdit te_pfName;
        public DevExpress.XtraEditors.TextEdit te_pfID;
        public DevExpress.XtraEditors.TextEdit te_pfStatus;
        public DevExpress.XtraEditors.TextEdit te_Type;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraEditors.SimpleButton btnChangeImage;
    }
}