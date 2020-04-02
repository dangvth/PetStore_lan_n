namespace PetStore
{
    partial class DetailMedicine
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
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ptbimage = new System.Windows.Forms.PictureBox();
            this.lbldetail = new System.Windows.Forms.Label();
            this.petStoreDataSet1 = new PetStore.PetStoreDataSet();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtPmdId = new DevExpress.XtraEditors.TextEdit();
            this.txtPmdName = new DevExpress.XtraEditors.TextEdit();
            this.txtPmdSaleprices = new DevExpress.XtraEditors.TextEdit();
            this.txtPmdAmount = new DevExpress.XtraEditors.TextEdit();
            this.txtPmdDescript = new DevExpress.XtraEditors.TextEdit();
            this.txtPmdStatus = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator3 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator4 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator5 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator6 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPmdId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPmdName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPmdSaleprices.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPmdAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPmdDescript.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPmdStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(776, 178);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Close";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = global::PetStore.Properties.Resources.tải_xuống__8_;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            this.ribbonPageGroup1.Text = "Tool Group";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 668);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(776, 37);
            // 
            // ptbimage
            // 
            this.ptbimage.Location = new System.Drawing.Point(14, 219);
            this.ptbimage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbimage.Name = "ptbimage";
            this.ptbimage.Size = new System.Drawing.Size(297, 385);
            this.ptbimage.TabIndex = 2;
            this.ptbimage.TabStop = false;
            // 
            // lbldetail
            // 
            this.lbldetail.AutoSize = true;
            this.lbldetail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetail.Location = new System.Drawing.Point(355, 219);
            this.lbldetail.Name = "lbldetail";
            this.lbldetail.Size = new System.Drawing.Size(69, 24);
            this.lbldetail.TabIndex = 3;
            this.lbldetail.Text = "Detail";
            // 
            // petStoreDataSet1
            // 
            this.petStoreDataSet1.DataSetName = "PetStoreDataSet";
            this.petStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtPmdId);
            this.layoutControl1.Controls.Add(this.txtPmdName);
            this.layoutControl1.Controls.Add(this.txtPmdSaleprices);
            this.layoutControl1.Controls.Add(this.txtPmdAmount);
            this.layoutControl1.Controls.Add(this.txtPmdDescript);
            this.layoutControl1.Controls.Add(this.txtPmdStatus);
            this.layoutControl1.Location = new System.Drawing.Point(315, 284);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(637, 110, 690, 504);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(444, 222);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtPmdId
            // 
            this.txtPmdId.Location = new System.Drawing.Point(156, 14);
            this.txtPmdId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPmdId.MenuManager = this.ribbon;
            this.txtPmdId.Name = "txtPmdId";
            this.txtPmdId.Properties.ReadOnly = true;
            this.txtPmdId.Size = new System.Drawing.Size(274, 22);
            this.txtPmdId.StyleController = this.layoutControl1;
            this.txtPmdId.TabIndex = 4;
            // 
            // txtPmdName
            // 
            this.txtPmdName.EditValue = "";
            this.txtPmdName.Location = new System.Drawing.Point(156, 42);
            this.txtPmdName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPmdName.MenuManager = this.ribbon;
            this.txtPmdName.Name = "txtPmdName";
            this.txtPmdName.Properties.AutoHeight = false;
            this.txtPmdName.Properties.ReadOnly = true;
            this.txtPmdName.Size = new System.Drawing.Size(274, 52);
            this.txtPmdName.StyleController = this.layoutControl1;
            this.txtPmdName.TabIndex = 5;
            // 
            // txtPmdSaleprices
            // 
            this.txtPmdSaleprices.Location = new System.Drawing.Point(156, 100);
            this.txtPmdSaleprices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPmdSaleprices.MenuManager = this.ribbon;
            this.txtPmdSaleprices.Name = "txtPmdSaleprices";
            this.txtPmdSaleprices.Properties.ReadOnly = true;
            this.txtPmdSaleprices.Size = new System.Drawing.Size(274, 22);
            this.txtPmdSaleprices.StyleController = this.layoutControl1;
            this.txtPmdSaleprices.TabIndex = 6;
            // 
            // txtPmdAmount
            // 
            this.txtPmdAmount.Location = new System.Drawing.Point(156, 128);
            this.txtPmdAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPmdAmount.MenuManager = this.ribbon;
            this.txtPmdAmount.Name = "txtPmdAmount";
            this.txtPmdAmount.Properties.ReadOnly = true;
            this.txtPmdAmount.Size = new System.Drawing.Size(274, 22);
            this.txtPmdAmount.StyleController = this.layoutControl1;
            this.txtPmdAmount.TabIndex = 7;
            // 
            // txtPmdDescript
            // 
            this.txtPmdDescript.Location = new System.Drawing.Point(156, 156);
            this.txtPmdDescript.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPmdDescript.MenuManager = this.ribbon;
            this.txtPmdDescript.Name = "txtPmdDescript";
            this.txtPmdDescript.Properties.ReadOnly = true;
            this.txtPmdDescript.Size = new System.Drawing.Size(274, 22);
            this.txtPmdDescript.StyleController = this.layoutControl1;
            this.txtPmdDescript.TabIndex = 8;
            // 
            // txtPmdStatus
            // 
            this.txtPmdStatus.Location = new System.Drawing.Point(156, 182);
            this.txtPmdStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPmdStatus.MenuManager = this.ribbon;
            this.txtPmdStatus.Name = "txtPmdStatus";
            this.txtPmdStatus.Properties.ReadOnly = true;
            this.txtPmdStatus.Size = new System.Drawing.Size(274, 22);
            this.txtPmdStatus.StyleController = this.layoutControl1;
            this.txtPmdStatus.TabIndex = 9;
            // 
            // Root
            // 
            this.Root.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Root.AppearanceItemCaption.Options.UseFont = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.simpleSeparator3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.simpleSeparator4,
            this.simpleSeparator1,
            this.simpleSeparator2,
            this.simpleSeparator5,
            this.simpleSeparator6,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(444, 222);
            this.Root.Text = "Layout";
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtPmdId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(420, 26);
            this.layoutControlItem1.Text = "PMD_ID:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(139, 19);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtPmdName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(194, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(420, 56);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "PMD_Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(139, 19);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtPmdSaleprices;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 86);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(420, 26);
            this.layoutControlItem3.Text = "PMD_SalePrices";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(139, 19);
            // 
            // simpleSeparator3
            // 
            this.simpleSeparator3.AllowHotTrack = false;
            this.simpleSeparator3.Location = new System.Drawing.Point(0, 112);
            this.simpleSeparator3.Name = "simpleSeparator3";
            this.simpleSeparator3.Size = new System.Drawing.Size(420, 2);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtPmdAmount;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 114);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(420, 26);
            this.layoutControlItem4.Text = "PMD_Amount";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(139, 19);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtPmdDescript;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 142);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(420, 26);
            this.layoutControlItem5.Text = "PMD_Description";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(139, 19);
            // 
            // simpleSeparator4
            // 
            this.simpleSeparator4.AllowHotTrack = false;
            this.simpleSeparator4.Location = new System.Drawing.Point(0, 84);
            this.simpleSeparator4.Name = "simpleSeparator4";
            this.simpleSeparator4.Size = new System.Drawing.Size(420, 2);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 26);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(420, 2);
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.Location = new System.Drawing.Point(0, 140);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(420, 2);
            // 
            // simpleSeparator5
            // 
            this.simpleSeparator5.AllowHotTrack = false;
            this.simpleSeparator5.Location = new System.Drawing.Point(0, 196);
            this.simpleSeparator5.Name = "simpleSeparator5";
            this.simpleSeparator5.Size = new System.Drawing.Size(420, 2);
            // 
            // simpleSeparator6
            // 
            this.simpleSeparator6.AllowHotTrack = false;
            this.simpleSeparator6.Location = new System.Drawing.Point(0, 194);
            this.simpleSeparator6.Name = "simpleSeparator6";
            this.simpleSeparator6.Size = new System.Drawing.Size(420, 2);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtPmdStatus;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(420, 26);
            this.layoutControlItem6.Text = "PMD_Status";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(139, 19);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 7;
            // 
            // DetailMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 705);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.lbldetail);
            this.Controls.Add(this.ptbimage);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DetailMedicine";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "DetailMedicine";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPmdId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPmdName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPmdSaleprices.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPmdAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPmdDescript.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPmdStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private PetStoreDataSet petStoreDataSet1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator4;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator5;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        public DevExpress.XtraLayout.LayoutControlGroup Root;
        public DevExpress.XtraEditors.TextEdit txtPmdId;
        public DevExpress.XtraEditors.TextEdit txtPmdName;
        public DevExpress.XtraEditors.TextEdit txtPmdSaleprices;
        public DevExpress.XtraEditors.TextEdit txtPmdAmount;
        public DevExpress.XtraEditors.TextEdit txtPmdDescript;
        public DevExpress.XtraEditors.TextEdit txtPmdStatus;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbldetail;
        public System.Windows.Forms.PictureBox ptbimage;
    }
}