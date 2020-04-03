namespace PetStore
{
    partial class EditPetFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPetFood));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSaveEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnReset = new DevExpress.XtraBars.BarButtonItem();
            this.btnCloseEdit = new DevExpress.XtraBars.BarButtonItem();
            this.Tool = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.te_FoodAmount = new DevExpress.XtraEditors.TextEdit();
            this.te_FoodSalePrice = new DevExpress.XtraEditors.TextEdit();
            this.te_FoodPrice = new DevExpress.XtraEditors.TextEdit();
            this.te_FoodName = new DevExpress.XtraEditors.TextEdit();
            this.te_FoodID = new DevExpress.XtraEditors.TextEdit();
            this.te_FoodStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.te_FoodImage = new DevExpress.XtraEditors.ButtonEdit();
            this.te_Type = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.openDialog = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_FoodAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_FoodSalePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_FoodPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_FoodName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_FoodID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_FoodStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_FoodImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnSaveEdit,
            this.btnReset,
            this.btnCloseEdit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Tool});
            this.ribbon.Size = new System.Drawing.Size(800, 178);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Caption = "Save";
            this.btnSaveEdit.Id = 1;
            this.btnSaveEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveEdit.ImageOptions.Image")));
            this.btnSaveEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaveEdit.ImageOptions.LargeImage")));
            this.btnSaveEdit.LargeWidth = 60;
            this.btnSaveEdit.Name = "btnSaveEdit";
            toolTipItem1.Text = "Accept change Pet\'s food in selected";
            superToolTip1.Items.Add(toolTipItem1);
            this.btnSaveEdit.SuperTip = superToolTip1;
            this.btnSaveEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveEdit_ItemClick);
            // 
            // btnReset
            // 
            this.btnReset.Caption = "Reset change";
            this.btnReset.Id = 2;
            this.btnReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.ImageOptions.Image")));
            this.btnReset.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReset.ImageOptions.LargeImage")));
            this.btnReset.LargeWidth = 75;
            this.btnReset.Name = "btnReset";
            this.btnReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReset_ItemClick);
            // 
            // btnCloseEdit
            // 
            this.btnCloseEdit.Caption = "Close";
            this.btnCloseEdit.Id = 3;
            this.btnCloseEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseEdit.ImageOptions.Image")));
            this.btnCloseEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCloseEdit.ImageOptions.LargeImage")));
            this.btnCloseEdit.LargeWidth = 60;
            this.btnCloseEdit.Name = "btnCloseEdit";
            toolTipItem2.Text = "Close Edit Pet\'s food form";
            superToolTip2.Items.Add(toolTipItem2);
            this.btnCloseEdit.SuperTip = superToolTip2;
            this.btnCloseEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCloseEdit_ItemClick);
            // 
            // Tool
            // 
            this.Tool.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.Tool.Name = "Tool";
            this.Tool.Text = "Tool";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSaveEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnReset);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCloseEdit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Edit Pet\'s Food";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 485);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(800, 37);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.te_FoodAmount);
            this.layoutControl1.Controls.Add(this.te_FoodSalePrice);
            this.layoutControl1.Controls.Add(this.te_FoodPrice);
            this.layoutControl1.Controls.Add(this.te_FoodName);
            this.layoutControl1.Controls.Add(this.te_FoodID);
            this.layoutControl1.Controls.Add(this.te_FoodStatus);
            this.layoutControl1.Controls.Add(this.te_FoodImage);
            this.layoutControl1.Controls.Add(this.te_Type);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.layoutControl1.Location = new System.Drawing.Point(0, 178);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 307);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // te_FoodAmount
            // 
            this.te_FoodAmount.Location = new System.Drawing.Point(79, 180);
            this.te_FoodAmount.MenuManager = this.ribbon;
            this.te_FoodAmount.Name = "te_FoodAmount";
            this.te_FoodAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_FoodAmount.Properties.Appearance.Options.UseFont = true;
            this.te_FoodAmount.Size = new System.Drawing.Size(709, 30);
            this.te_FoodAmount.StyleController = this.layoutControl1;
            this.te_FoodAmount.TabIndex = 9;
            // 
            // te_FoodSalePrice
            // 
            this.te_FoodSalePrice.Location = new System.Drawing.Point(79, 146);
            this.te_FoodSalePrice.MenuManager = this.ribbon;
            this.te_FoodSalePrice.Name = "te_FoodSalePrice";
            this.te_FoodSalePrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_FoodSalePrice.Properties.Appearance.Options.UseFont = true;
            this.te_FoodSalePrice.Size = new System.Drawing.Size(709, 30);
            this.te_FoodSalePrice.StyleController = this.layoutControl1;
            this.te_FoodSalePrice.TabIndex = 8;
            // 
            // te_FoodPrice
            // 
            this.te_FoodPrice.Location = new System.Drawing.Point(79, 112);
            this.te_FoodPrice.MenuManager = this.ribbon;
            this.te_FoodPrice.Name = "te_FoodPrice";
            this.te_FoodPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_FoodPrice.Properties.Appearance.Options.UseFont = true;
            this.te_FoodPrice.Size = new System.Drawing.Size(709, 30);
            this.te_FoodPrice.StyleController = this.layoutControl1;
            this.te_FoodPrice.TabIndex = 7;
            // 
            // te_FoodName
            // 
            this.te_FoodName.Location = new System.Drawing.Point(79, 46);
            this.te_FoodName.MenuManager = this.ribbon;
            this.te_FoodName.Name = "te_FoodName";
            this.te_FoodName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_FoodName.Properties.Appearance.Options.UseFont = true;
            this.te_FoodName.Size = new System.Drawing.Size(709, 30);
            this.te_FoodName.StyleController = this.layoutControl1;
            this.te_FoodName.TabIndex = 5;
            // 
            // te_FoodID
            // 
            this.te_FoodID.Location = new System.Drawing.Point(79, 12);
            this.te_FoodID.MenuManager = this.ribbon;
            this.te_FoodID.Name = "te_FoodID";
            this.te_FoodID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_FoodID.Properties.Appearance.Options.UseFont = true;
            this.te_FoodID.Properties.ReadOnly = true;
            this.te_FoodID.Size = new System.Drawing.Size(709, 30);
            this.te_FoodID.StyleController = this.layoutControl1;
            this.te_FoodID.TabIndex = 4;
            // 
            // te_FoodStatus
            // 
            this.te_FoodStatus.Location = new System.Drawing.Point(79, 248);
            this.te_FoodStatus.MenuManager = this.ribbon;
            this.te_FoodStatus.Name = "te_FoodStatus";
            this.te_FoodStatus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_FoodStatus.Properties.Appearance.Options.UseFont = true;
            this.te_FoodStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.te_FoodStatus.Properties.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.te_FoodStatus.Properties.ReadOnly = true;
            this.te_FoodStatus.Size = new System.Drawing.Size(709, 30);
            this.te_FoodStatus.StyleController = this.layoutControl1;
            this.te_FoodStatus.TabIndex = 11;
            // 
            // te_FoodImage
            // 
            this.te_FoodImage.Location = new System.Drawing.Point(79, 80);
            this.te_FoodImage.MenuManager = this.ribbon;
            this.te_FoodImage.Name = "te_FoodImage";
            this.te_FoodImage.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.te_FoodImage.Properties.Appearance.Options.UseFont = true;
            this.te_FoodImage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.te_FoodImage.Properties.ReadOnly = true;
            this.te_FoodImage.Size = new System.Drawing.Size(709, 28);
            this.te_FoodImage.StyleController = this.layoutControl1;
            this.te_FoodImage.TabIndex = 6;
            this.te_FoodImage.Click += new System.EventHandler(this.te_FoodImage_Click);
            // 
            // te_Type
            // 
            this.te_Type.EditValue = "";
            this.te_Type.Location = new System.Drawing.Point(79, 214);
            this.te_Type.MenuManager = this.ribbon;
            this.te_Type.Name = "te_Type";
            this.te_Type.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_Type.Properties.Appearance.Options.UseFont = true;
            this.te_Type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.te_Type.Properties.DropDownRows = 5;
            this.te_Type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.te_Type.Size = new System.Drawing.Size(709, 30);
            this.te_Type.StyleController = this.layoutControl1;
            this.te_Type.TabIndex = 10;
            this.te_Type.SelectedValueChanged += new System.EventHandler(this.te_Type_SelectedValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 307);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.te_FoodID;
            this.layoutControlItem1.CustomizationFormText = "Food ID";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsPrint.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.layoutControlItem1.OptionsPrint.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 34);
            this.layoutControlItem1.Text = "Food ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(64, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 270);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(780, 17);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.te_FoodName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsPrint.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.layoutControlItem2.OptionsPrint.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Size = new System.Drawing.Size(780, 34);
            this.layoutControlItem2.Text = "Food name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(64, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.te_FoodImage;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(780, 32);
            this.layoutControlItem3.Text = "Image";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(64, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.te_FoodPrice;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 100);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(780, 34);
            this.layoutControlItem4.Text = "Price";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(64, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.te_FoodSalePrice;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 134);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(780, 34);
            this.layoutControlItem5.Text = "Sale Price";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(64, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.te_FoodAmount;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(780, 34);
            this.layoutControlItem6.Text = "Amount";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(64, 16);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.te_Type;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 202);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(780, 34);
            this.layoutControlItem7.Text = "Type";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(64, 16);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.te_FoodStatus;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 236);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(780, 34);
            this.layoutControlItem8.Text = "Status";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(64, 16);
            // 
            // EditPetFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "EditPetFood";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "EditPetFood";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.te_FoodAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_FoodSalePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_FoodPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_FoodName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_FoodID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_FoodStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_FoodImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage Tool;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnSaveEdit;
        private DevExpress.XtraBars.BarButtonItem btnReset;
        private DevExpress.XtraBars.BarButtonItem btnCloseEdit;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        public DevExpress.XtraEditors.TextEdit te_FoodAmount;
        public DevExpress.XtraEditors.TextEdit te_FoodSalePrice;
        public DevExpress.XtraEditors.TextEdit te_FoodPrice;
        public DevExpress.XtraEditors.TextEdit te_FoodName;
        public DevExpress.XtraEditors.TextEdit te_FoodID;
        public DevExpress.XtraEditors.ComboBoxEdit te_FoodStatus;
        public DevExpress.XtraEditors.ButtonEdit te_FoodImage;
        private DevExpress.XtraEditors.XtraOpenFileDialog openDialog;
        public DevExpress.XtraEditors.ComboBoxEdit te_Type;
    }
}