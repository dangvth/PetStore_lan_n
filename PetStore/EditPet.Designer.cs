namespace PetStore
{
    partial class EditPet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPet));
            DevExpress.Utils.SuperToolTip superToolTip7 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem7 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip8 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem8 = new DevExpress.Utils.ToolTipItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.te_PSalePrice = new DevExpress.XtraEditors.TextEdit();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSaveEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnReset = new DevExpress.XtraBars.BarButtonItem();
            this.btnCloseEdit = new DevExpress.XtraBars.BarButtonItem();
            this.Tool = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.te_POriginPrice = new DevExpress.XtraEditors.TextEdit();
            this.te_PName = new DevExpress.XtraEditors.TextEdit();
            this.te_PID = new DevExpress.XtraEditors.TextEdit();
            this.te_PStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.te_PImage = new DevExpress.XtraEditors.ButtonEdit();
            this.cbx_Type = new DevExpress.XtraEditors.LookUpEdit();
            this.te_PDescription = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.openDialog = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_PSalePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_POriginPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_PName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_PID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_PStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_PImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_PDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.te_PSalePrice);
            this.layoutControl1.Controls.Add(this.te_POriginPrice);
            this.layoutControl1.Controls.Add(this.te_PName);
            this.layoutControl1.Controls.Add(this.te_PID);
            this.layoutControl1.Controls.Add(this.te_PStatus);
            this.layoutControl1.Controls.Add(this.te_PImage);
            this.layoutControl1.Controls.Add(this.cbx_Type);
            this.layoutControl1.Controls.Add(this.te_PDescription);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.layoutControl1.Location = new System.Drawing.Point(0, 176);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1083, 307);
            this.layoutControl1.TabIndex = 8;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // te_PSalePrice
            // 
            this.te_PSalePrice.Location = new System.Drawing.Point(79, 146);
            this.te_PSalePrice.MenuManager = this.ribbon;
            this.te_PSalePrice.Name = "te_PSalePrice";
            this.te_PSalePrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_PSalePrice.Properties.Appearance.Options.UseFont = true;
            this.te_PSalePrice.Size = new System.Drawing.Size(992, 30);
            this.te_PSalePrice.StyleController = this.layoutControl1;
            this.te_PSalePrice.TabIndex = 8;
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
            this.ribbon.Size = new System.Drawing.Size(1083, 176);
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
            toolTipItem7.Text = "Accept change Pet\'s food in selected";
            superToolTip7.Items.Add(toolTipItem7);
            this.btnSaveEdit.SuperTip = superToolTip7;
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
            toolTipItem8.Text = "Close Edit Pet\'s food form";
            superToolTip8.Items.Add(toolTipItem8);
            this.btnCloseEdit.SuperTip = superToolTip8;
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 484);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1083, 34);
            // 
            // te_POriginPrice
            // 
            this.te_POriginPrice.Location = new System.Drawing.Point(79, 112);
            this.te_POriginPrice.MenuManager = this.ribbon;
            this.te_POriginPrice.Name = "te_POriginPrice";
            this.te_POriginPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_POriginPrice.Properties.Appearance.Options.UseFont = true;
            this.te_POriginPrice.Size = new System.Drawing.Size(992, 30);
            this.te_POriginPrice.StyleController = this.layoutControl1;
            this.te_POriginPrice.TabIndex = 7;
            // 
            // te_PName
            // 
            this.te_PName.Location = new System.Drawing.Point(79, 46);
            this.te_PName.MenuManager = this.ribbon;
            this.te_PName.Name = "te_PName";
            this.te_PName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_PName.Properties.Appearance.Options.UseFont = true;
            this.te_PName.Size = new System.Drawing.Size(992, 30);
            this.te_PName.StyleController = this.layoutControl1;
            this.te_PName.TabIndex = 5;
            // 
            // te_PID
            // 
            this.te_PID.Location = new System.Drawing.Point(79, 12);
            this.te_PID.MenuManager = this.ribbon;
            this.te_PID.Name = "te_PID";
            this.te_PID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_PID.Properties.Appearance.Options.UseFont = true;
            this.te_PID.Properties.ReadOnly = true;
            this.te_PID.Size = new System.Drawing.Size(992, 30);
            this.te_PID.StyleController = this.layoutControl1;
            this.te_PID.TabIndex = 4;
            // 
            // te_PStatus
            // 
            this.te_PStatus.Location = new System.Drawing.Point(79, 214);
            this.te_PStatus.MenuManager = this.ribbon;
            this.te_PStatus.Name = "te_PStatus";
            this.te_PStatus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_PStatus.Properties.Appearance.Options.UseFont = true;
            this.te_PStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.te_PStatus.Properties.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.te_PStatus.Properties.ReadOnly = true;
            this.te_PStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.te_PStatus.Size = new System.Drawing.Size(992, 30);
            this.te_PStatus.StyleController = this.layoutControl1;
            this.te_PStatus.TabIndex = 11;
            // 
            // te_PImage
            // 
            this.te_PImage.Location = new System.Drawing.Point(79, 80);
            this.te_PImage.MenuManager = this.ribbon;
            this.te_PImage.Name = "te_PImage";
            this.te_PImage.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.te_PImage.Properties.Appearance.Options.UseFont = true;
            this.te_PImage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.te_PImage.Properties.ReadOnly = true;
            this.te_PImage.Size = new System.Drawing.Size(992, 28);
            this.te_PImage.StyleController = this.layoutControl1;
            this.te_PImage.TabIndex = 6;
            this.te_PImage.Click += new System.EventHandler(this.te_PImage_Click);
            // 
            // cbx_Type
            // 
            this.cbx_Type.EditValue = "";
            this.cbx_Type.Location = new System.Drawing.Point(79, 180);
            this.cbx_Type.MenuManager = this.ribbon;
            this.cbx_Type.Name = "cbx_Type";
            this.cbx_Type.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbx_Type.Properties.Appearance.Options.UseFont = true;
            this.cbx_Type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_Type.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("t_id", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("t_name", "Name")});
            this.cbx_Type.Properties.NullText = "";
            this.cbx_Type.Properties.PopupSizeable = false;
            this.cbx_Type.Size = new System.Drawing.Size(992, 30);
            this.cbx_Type.StyleController = this.layoutControl1;
            this.cbx_Type.TabIndex = 10;
            this.cbx_Type.EditValueChanged += new System.EventHandler(this.cbx_Type_EditValueChanged);
            // 
            // te_PDescription
            // 
            this.te_PDescription.EditValue = "";
            this.te_PDescription.Location = new System.Drawing.Point(79, 248);
            this.te_PDescription.Name = "te_PDescription";
            this.te_PDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_PDescription.Properties.Appearance.Options.UseFont = true;
            this.te_PDescription.Size = new System.Drawing.Size(992, 30);
            this.te_PDescription.StyleController = this.layoutControl1;
            this.te_PDescription.TabIndex = 10;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1083, 307);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.te_PID;
            this.layoutControlItem1.CustomizationFormText = "ID";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsPrint.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.layoutControlItem1.OptionsPrint.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Size = new System.Drawing.Size(1063, 34);
            this.layoutControlItem1.Text = "ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(64, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.te_PName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsPrint.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.layoutControlItem2.OptionsPrint.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Size = new System.Drawing.Size(1063, 34);
            this.layoutControlItem2.Text = "Food name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(64, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.te_PImage;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1063, 32);
            this.layoutControlItem3.Text = "Image";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(64, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.te_POriginPrice;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 100);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1063, 34);
            this.layoutControlItem4.Text = "Price";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(64, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.te_PSalePrice;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 134);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1063, 34);
            this.layoutControlItem5.Text = "Sale Price";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(64, 16);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cbx_Type;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(1063, 34);
            this.layoutControlItem7.Text = "Type";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(64, 16);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.te_PStatus;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 202);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(1063, 34);
            this.layoutControlItem8.Text = "Status";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(64, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.te_PDescription;
            this.layoutControlItem6.CustomizationFormText = "Description";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 236);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(1063, 51);
            this.layoutControlItem6.Text = "Description";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(64, 16);
            // 
            // EditPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 518);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "EditPet";
            this.Text = "EditPet";
            this.Load += new System.EventHandler(this.EditPet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.te_PSalePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_POriginPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_PName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_PID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_PStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_PImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_PDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        public DevExpress.XtraEditors.TextEdit te_PSalePrice;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btnSaveEdit;
        private DevExpress.XtraBars.BarButtonItem btnReset;
        private DevExpress.XtraBars.BarButtonItem btnCloseEdit;
        private DevExpress.XtraBars.Ribbon.RibbonPage Tool;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        public DevExpress.XtraEditors.TextEdit te_POriginPrice;
        public DevExpress.XtraEditors.TextEdit te_PName;
        public DevExpress.XtraEditors.TextEdit te_PID;
        public DevExpress.XtraEditors.ComboBoxEdit te_PStatus;
        public DevExpress.XtraEditors.ButtonEdit te_PImage;
        private DevExpress.XtraEditors.LookUpEdit cbx_Type;
        public DevExpress.XtraEditors.TextEdit te_PDescription;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.XtraOpenFileDialog openDialog;
    }
}