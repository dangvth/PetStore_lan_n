namespace PetStore
{
    partial class EditGift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGift));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txt_gName = new DevExpress.XtraEditors.TextEdit();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSaveEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnReset = new DevExpress.XtraBars.BarButtonItem();
            this.btnCloseEdit = new DevExpress.XtraBars.BarButtonItem();
            this.Tool = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.txt_gID = new DevExpress.XtraEditors.TextEdit();
            this.txt_gStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_gImage = new DevExpress.XtraEditors.ButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txt_gName);
            this.layoutControl1.Controls.Add(this.txt_gID);
            this.layoutControl1.Controls.Add(this.txt_gStatus);
            this.layoutControl1.Controls.Add(this.txt_gImage);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.layoutControl1.Location = new System.Drawing.Point(0, 141);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(686, 249);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txt_gName
            // 
            this.txt_gName.Location = new System.Drawing.Point(46, 42);
            this.txt_gName.MenuManager = this.ribbon;
            this.txt_gName.Name = "txt_gName";
            this.txt_gName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_gName.Properties.Appearance.Options.UseFont = true;
            this.txt_gName.Size = new System.Drawing.Size(628, 26);
            this.txt_gName.StyleController = this.layoutControl1;
            this.txt_gName.TabIndex = 5;
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
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Tool});
            this.ribbon.Size = new System.Drawing.Size(686, 141);
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
            this.ribbonPageGroup1.Text = "Edit Gift";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 366);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(686, 27);
            // 
            // txt_gID
            // 
            this.txt_gID.Location = new System.Drawing.Point(46, 12);
            this.txt_gID.MenuManager = this.ribbon;
            this.txt_gID.Name = "txt_gID";
            this.txt_gID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_gID.Properties.Appearance.Options.UseFont = true;
            this.txt_gID.Properties.ReadOnly = true;
            this.txt_gID.Size = new System.Drawing.Size(628, 26);
            this.txt_gID.StyleController = this.layoutControl1;
            this.txt_gID.TabIndex = 4;
            // 
            // txt_gStatus
            // 
            this.txt_gStatus.Location = new System.Drawing.Point(46, 98);
            this.txt_gStatus.MenuManager = this.ribbon;
            this.txt_gStatus.Name = "txt_gStatus";
            this.txt_gStatus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_gStatus.Properties.Appearance.Options.UseFont = true;
            this.txt_gStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_gStatus.Properties.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.txt_gStatus.Properties.ReadOnly = true;
            this.txt_gStatus.Size = new System.Drawing.Size(628, 26);
            this.txt_gStatus.StyleController = this.layoutControl1;
            this.txt_gStatus.TabIndex = 11;
            // 
            // txt_gImage
            // 
            this.txt_gImage.Location = new System.Drawing.Point(46, 72);
            this.txt_gImage.MenuManager = this.ribbon;
            this.txt_gImage.Name = "txt_gImage";
            this.txt_gImage.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_gImage.Properties.Appearance.Options.UseFont = true;
            this.txt_gImage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_gImage.Properties.ReadOnly = true;
            this.txt_gImage.Size = new System.Drawing.Size(628, 22);
            this.txt_gImage.StyleController = this.layoutControl1;
            this.txt_gImage.TabIndex = 6;
            this.txt_gImage.Click += new System.EventHandler(this.txt_gImage_Click);
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
            this.layoutControlItem8});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(686, 249);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txt_gID;
            this.layoutControlItem1.CustomizationFormText = "Food ID";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsPrint.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.layoutControlItem1.OptionsPrint.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Size = new System.Drawing.Size(666, 30);
            this.layoutControlItem1.Text = "ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(31, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 116);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(666, 113);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txt_gName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsPrint.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.layoutControlItem2.OptionsPrint.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Size = new System.Drawing.Size(666, 30);
            this.layoutControlItem2.Text = "Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(31, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txt_gImage;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(666, 26);
            this.layoutControlItem3.Text = "Image";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(31, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txt_gStatus;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 86);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(666, 30);
            this.layoutControlItem8.Text = "Status";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(31, 13);
            // 
            // openDialog
            // 
            this.openDialog.FileName = "openDialog";
            // 
            // EditGift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 393);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "EditGift";
            this.Text = "EditGift";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_gName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btnSaveEdit;
        private DevExpress.XtraBars.BarButtonItem btnReset;
        private DevExpress.XtraBars.BarButtonItem btnCloseEdit;
        private DevExpress.XtraBars.Ribbon.RibbonPage Tool;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        public DevExpress.XtraEditors.TextEdit txt_gName;
        public DevExpress.XtraEditors.TextEdit txt_gID;
        public DevExpress.XtraEditors.ButtonEdit txt_gImage;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        public DevExpress.XtraEditors.ComboBoxEdit txt_gStatus;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private System.Windows.Forms.OpenFileDialog openDialog;
    }
}