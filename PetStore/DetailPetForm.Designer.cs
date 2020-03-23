﻿namespace PetStore
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
            this.txt_pfStatus = new DevExpress.XtraEditors.TextEdit();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbbPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.txt_Type = new DevExpress.XtraEditors.TextEdit();
            this.txt_pfAmount = new DevExpress.XtraEditors.TextEdit();
            this.txt_pfPriceSale = new DevExpress.XtraEditors.TextEdit();
            this.txt_pfPrice = new DevExpress.XtraEditors.TextEdit();
            this.txt_pfName = new DevExpress.XtraEditors.TextEdit();
            this.txt_pfID = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.PFID = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.PFName = new DevExpress.XtraLayout.LayoutControlItem();
            this.PFPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.PFPriceSale = new DevExpress.XtraLayout.LayoutControlItem();
            this.PFAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.PFType = new DevExpress.XtraLayout.LayoutControlItem();
            this.PFStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lctBox)).BeginInit();
            this.lctBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pfStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pfAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pfPriceSale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pfPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pfName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pfID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFPriceSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFAmount)).BeginInit();
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
            this.btnChangeImage.Location = new System.Drawing.Point(466, 595);
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
            this.lctBox.Controls.Add(this.txt_pfStatus);
            this.lctBox.Controls.Add(this.txt_Type);
            this.lctBox.Controls.Add(this.txt_pfAmount);
            this.lctBox.Controls.Add(this.txt_pfPriceSale);
            this.lctBox.Controls.Add(this.txt_pfPrice);
            this.lctBox.Controls.Add(this.txt_pfName);
            this.lctBox.Controls.Add(this.txt_pfID);
            this.lctBox.Location = new System.Drawing.Point(466, 283);
            this.lctBox.Name = "lctBox";
            this.lctBox.Root = this.Root;
            this.lctBox.Size = new System.Drawing.Size(457, 271);
            this.lctBox.TabIndex = 12;
            this.lctBox.Text = "layoutControl1";
            // 
            // txt_pfStatus
            // 
            this.txt_pfStatus.Location = new System.Drawing.Point(117, 216);
            this.txt_pfStatus.MenuManager = this.ribbon;
            this.txt_pfStatus.Name = "txt_pfStatus";
            this.txt_pfStatus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_pfStatus.Properties.Appearance.Options.UseFont = true;
            this.txt_pfStatus.Properties.ReadOnly = true;
            this.txt_pfStatus.Size = new System.Drawing.Size(328, 30);
            this.txt_pfStatus.StyleController = this.lctBox;
            this.txt_pfStatus.TabIndex = 10;
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
            this.ribbon.Size = new System.Drawing.Size(940, 176);
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 615);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(940, 34);
            // 
            // txt_Type
            // 
            this.txt_Type.Location = new System.Drawing.Point(117, 182);
            this.txt_Type.MenuManager = this.ribbon;
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_Type.Properties.Appearance.Options.UseFont = true;
            this.txt_Type.Properties.ReadOnly = true;
            this.txt_Type.Size = new System.Drawing.Size(328, 30);
            this.txt_Type.StyleController = this.lctBox;
            this.txt_Type.TabIndex = 9;
            // 
            // txt_pfAmount
            // 
            this.txt_pfAmount.Location = new System.Drawing.Point(117, 148);
            this.txt_pfAmount.MenuManager = this.ribbon;
            this.txt_pfAmount.Name = "txt_pfAmount";
            this.txt_pfAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_pfAmount.Properties.Appearance.Options.UseFont = true;
            this.txt_pfAmount.Properties.ReadOnly = true;
            this.txt_pfAmount.Size = new System.Drawing.Size(328, 30);
            this.txt_pfAmount.StyleController = this.lctBox;
            this.txt_pfAmount.TabIndex = 8;
            // 
            // txt_pfPriceSale
            // 
            this.txt_pfPriceSale.Location = new System.Drawing.Point(117, 114);
            this.txt_pfPriceSale.MenuManager = this.ribbon;
            this.txt_pfPriceSale.Name = "txt_pfPriceSale";
            this.txt_pfPriceSale.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_pfPriceSale.Properties.Appearance.Options.UseFont = true;
            this.txt_pfPriceSale.Properties.ReadOnly = true;
            this.txt_pfPriceSale.Size = new System.Drawing.Size(328, 30);
            this.txt_pfPriceSale.StyleController = this.lctBox;
            this.txt_pfPriceSale.TabIndex = 7;
            // 
            // txt_pfPrice
            // 
            this.txt_pfPrice.Location = new System.Drawing.Point(117, 80);
            this.txt_pfPrice.MenuManager = this.ribbon;
            this.txt_pfPrice.Name = "txt_pfPrice";
            this.txt_pfPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_pfPrice.Properties.Appearance.Options.UseFont = true;
            this.txt_pfPrice.Properties.ReadOnly = true;
            this.txt_pfPrice.Size = new System.Drawing.Size(328, 30);
            this.txt_pfPrice.StyleController = this.lctBox;
            this.txt_pfPrice.TabIndex = 6;
            // 
            // txt_pfName
            // 
            this.txt_pfName.Location = new System.Drawing.Point(117, 46);
            this.txt_pfName.MenuManager = this.ribbon;
            this.txt_pfName.Name = "txt_pfName";
            this.txt_pfName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_pfName.Properties.Appearance.Options.UseFont = true;
            this.txt_pfName.Properties.ReadOnly = true;
            this.txt_pfName.Size = new System.Drawing.Size(328, 30);
            this.txt_pfName.StyleController = this.lctBox;
            this.txt_pfName.TabIndex = 5;
            // 
            // txt_pfID
            // 
            this.txt_pfID.Location = new System.Drawing.Point(117, 12);
            this.txt_pfID.MenuManager = this.ribbon;
            this.txt_pfID.Name = "txt_pfID";
            this.txt_pfID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_pfID.Properties.Appearance.Options.UseFont = true;
            this.txt_pfID.Properties.ReadOnly = true;
            this.txt_pfID.Size = new System.Drawing.Size(328, 30);
            this.txt_pfID.StyleController = this.lctBox;
            this.txt_pfID.TabIndex = 4;
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
            this.Root.Size = new System.Drawing.Size(457, 271);
            this.Root.TextVisible = false;
            // 
            // PFID
            // 
            this.PFID.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFID.AppearanceItemCaption.Options.UseFont = true;
            this.PFID.Control = this.txt_pfID;
            this.PFID.Location = new System.Drawing.Point(0, 0);
            this.PFID.Name = "PFID";
            this.PFID.Size = new System.Drawing.Size(437, 34);
            this.PFID.Text = "ID";
            this.PFID.TextSize = new System.Drawing.Size(102, 24);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 238);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(437, 13);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // PFName
            // 
            this.PFName.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFName.AppearanceItemCaption.Options.UseFont = true;
            this.PFName.Control = this.txt_pfName;
            this.PFName.Location = new System.Drawing.Point(0, 34);
            this.PFName.Name = "PFName";
            this.PFName.Size = new System.Drawing.Size(437, 34);
            this.PFName.Text = "Name";
            this.PFName.TextSize = new System.Drawing.Size(102, 24);
            // 
            // PFPrice
            // 
            this.PFPrice.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFPrice.AppearanceItemCaption.Options.UseFont = true;
            this.PFPrice.Control = this.txt_pfPrice;
            this.PFPrice.Location = new System.Drawing.Point(0, 68);
            this.PFPrice.Name = "PFPrice";
            this.PFPrice.Size = new System.Drawing.Size(437, 34);
            this.PFPrice.Text = "Origin price";
            this.PFPrice.TextSize = new System.Drawing.Size(102, 24);
            // 
            // PFPriceSale
            // 
            this.PFPriceSale.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFPriceSale.AppearanceItemCaption.Options.UseFont = true;
            this.PFPriceSale.Control = this.txt_pfPriceSale;
            this.PFPriceSale.Location = new System.Drawing.Point(0, 102);
            this.PFPriceSale.Name = "PFPriceSale";
            this.PFPriceSale.Size = new System.Drawing.Size(437, 34);
            this.PFPriceSale.Text = "Sell price";
            this.PFPriceSale.TextSize = new System.Drawing.Size(102, 24);
            // 
            // PFAmount
            // 
            this.PFAmount.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFAmount.AppearanceItemCaption.Options.UseFont = true;
            this.PFAmount.Control = this.txt_pfAmount;
            this.PFAmount.Location = new System.Drawing.Point(0, 136);
            this.PFAmount.Name = "PFAmount";
            this.PFAmount.Size = new System.Drawing.Size(437, 34);
            this.PFAmount.Text = "Quantity";
            this.PFAmount.TextSize = new System.Drawing.Size(102, 24);
            // 
            // PFType
            // 
            this.PFType.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFType.AppearanceItemCaption.Options.UseFont = true;
            this.PFType.Control = this.txt_Type;
            this.PFType.Location = new System.Drawing.Point(0, 170);
            this.PFType.Name = "PFType";
            this.PFType.Size = new System.Drawing.Size(437, 34);
            this.PFType.Text = "Type";
            this.PFType.TextSize = new System.Drawing.Size(102, 24);
            // 
            // PFStatus
            // 
            this.PFStatus.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PFStatus.AppearanceItemCaption.Options.UseFont = true;
            this.PFStatus.Control = this.txt_pfStatus;
            this.PFStatus.Location = new System.Drawing.Point(0, 204);
            this.PFStatus.Name = "PFStatus";
            this.PFStatus.Size = new System.Drawing.Size(437, 34);
            this.PFStatus.Text = "Status";
            this.PFStatus.TextSize = new System.Drawing.Size(102, 24);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(471, 234);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(88, 30);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Detail";
            // 
            // ptbImage
            // 
            this.ptbImage.Location = new System.Drawing.Point(12, 193);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(440, 440);
            this.ptbImage.TabIndex = 10;
            this.ptbImage.TabStop = false;
            // 
            // DetailPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 649);
            this.Controls.Add(this.btnChangeImage);
            this.Controls.Add(this.lctBox);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ptbImage);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetailPetForm";
            this.Text = "Pet Detail";
            ((System.ComponentModel.ISupportInitialize)(this.lctBox)).EndInit();
            this.lctBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_pfStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pfAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pfPriceSale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pfPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pfName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pfID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFPriceSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnChangeImage;
        private DevExpress.XtraLayout.LayoutControl lctBox;
        public DevExpress.XtraEditors.TextEdit txt_pfStatus;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbbPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        public DevExpress.XtraEditors.TextEdit txt_Type;
        public DevExpress.XtraEditors.TextEdit txt_pfAmount;
        public DevExpress.XtraEditors.TextEdit txt_pfPriceSale;
        public DevExpress.XtraEditors.TextEdit txt_pfPrice;
        public DevExpress.XtraEditors.TextEdit txt_pfName;
        public DevExpress.XtraEditors.TextEdit txt_pfID;
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
        public System.Windows.Forms.PictureBox ptbImage;
    }
}