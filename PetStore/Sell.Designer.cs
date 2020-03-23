namespace PetStore
{
    partial class rbbSell
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
            this.rbbSale = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrint = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.rbbiSale = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbbpgTasks = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblGuest = new System.Windows.Forms.Label();
            this.lblGift = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtGuest = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.cbbGift = new System.Windows.Forms.ComboBox();
            this.giftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petStoreDataSet1 = new PetStore.PetStoreDataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.giftTableAdapter = new PetStore.PetStoreDataSet1TableAdapters.GiftTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rbbSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGuest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbbSale
            // 
            this.rbbSale.ExpandCollapseItem.Id = 0;
            this.rbbSale.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbbSale.ExpandCollapseItem,
            this.rbbSale.SearchEditItem,
            this.bbiAdd,
            this.bbiDelete,
            this.bbiPrint,
            this.bbiReset});
            this.rbbSale.Location = new System.Drawing.Point(0, 0);
            this.rbbSale.MaxItemId = 5;
            this.rbbSale.Name = "rbbSale";
            this.rbbSale.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbbiSale});
            this.rbbSale.Size = new System.Drawing.Size(881, 143);
            this.rbbSale.StatusBar = this.ribbonStatusBar;
            // 
            // bbiAdd
            // 
            this.bbiAdd.Caption = "Add";
            this.bbiAdd.Id = 1;
            this.bbiAdd.ImageOptions.ImageUri.Uri = "Add";
            this.bbiAdd.Name = "bbiAdd";
            this.bbiAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAdd_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Enabled = false;
            this.bbiDelete.Id = 2;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiPrint
            // 
            this.bbiPrint.Caption = "Generate bill and Preview";
            this.bbiPrint.Id = 3;
            this.bbiPrint.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrint.Name = "bbiPrint";
            this.bbiPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrint_ItemClick);
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset";
            this.bbiReset.Id = 4;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiReset.Name = "bbiReset";
            this.bbiReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReset_ItemClick);
            // 
            // rbbiSale
            // 
            this.rbbiSale.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbbpgTasks});
            this.rbbiSale.Name = "rbbiSale";
            this.rbbiSale.Text = "Sell";
            // 
            // rbbpgTasks
            // 
            this.rbbpgTasks.ItemLinks.Add(this.bbiAdd);
            this.rbbpgTasks.ItemLinks.Add(this.bbiDelete);
            this.rbbpgTasks.ItemLinks.Add(this.bbiReset);
            this.rbbpgTasks.ItemLinks.Add(this.bbiPrint);
            this.rbbpgTasks.Name = "rbbpgTasks";
            this.rbbpgTasks.Text = "Tasks";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 519);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.rbbSale;
            this.ribbonStatusBar.Size = new System.Drawing.Size(881, 31);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tblLayout);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 425);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(881, 94);
            this.panelControl1.TabIndex = 2;
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 5;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.91157F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.08844F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.tblLayout.Controls.Add(this.lblTotalPrice, 0, 0);
            this.tblLayout.Controls.Add(this.lblGuest, 1, 0);
            this.tblLayout.Controls.Add(this.lblGift, 1, 1);
            this.tblLayout.Controls.Add(this.lblAddress, 3, 0);
            this.tblLayout.Controls.Add(this.txtGuest, 2, 0);
            this.tblLayout.Controls.Add(this.txtAddress, 4, 0);
            this.tblLayout.Controls.Add(this.cbbGift, 2, 1);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblLayout.Location = new System.Drawing.Point(2, 2);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 2;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tblLayout.Size = new System.Drawing.Size(877, 90);
            this.tblLayout.TabIndex = 0;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(3, 12);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(51, 19);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "label1";
            // 
            // lblGuest
            // 
            this.lblGuest.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGuest.AutoSize = true;
            this.lblGuest.Location = new System.Drawing.Point(246, 12);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(49, 19);
            this.lblGuest.TabIndex = 1;
            this.lblGuest.Text = "Guest";
            // 
            // lblGift
            // 
            this.lblGift.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGift.AutoSize = true;
            this.lblGift.Location = new System.Drawing.Point(261, 57);
            this.lblGift.Name = "lblGift";
            this.lblGift.Size = new System.Drawing.Size(34, 19);
            this.lblGift.TabIndex = 2;
            this.lblGift.Text = "Gift";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(544, 12);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(66, 19);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // txtGuest
            // 
            this.txtGuest.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGuest.Location = new System.Drawing.Point(301, 9);
            this.txtGuest.MenuManager = this.rbbSale;
            this.txtGuest.Name = "txtGuest";
            this.txtGuest.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuest.Properties.Appearance.Options.UseFont = true;
            this.txtGuest.Properties.Mask.EditMask = "[a-zA-Z]+[a-zA-Z ]+";
            this.txtGuest.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtGuest.Properties.Mask.ShowPlaceHolders = false;
            this.txtGuest.Size = new System.Drawing.Size(234, 26);
            this.txtGuest.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAddress.Location = new System.Drawing.Point(616, 9);
            this.txtAddress.MenuManager = this.rbbSale;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Properties.Mask.EditMask = "[a-zA-Z]+[a-zA-Z ]+";
            this.txtAddress.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtAddress.Size = new System.Drawing.Size(250, 26);
            this.txtAddress.TabIndex = 5;
            // 
            // cbbGift
            // 
            this.cbbGift.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbGift.DataSource = this.giftBindingSource;
            this.cbbGift.DisplayMember = "g_name";
            this.cbbGift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGift.FormattingEnabled = true;
            this.cbbGift.Location = new System.Drawing.Point(301, 53);
            this.cbbGift.Name = "cbbGift";
            this.cbbGift.Size = new System.Drawing.Size(234, 27);
            this.cbbGift.TabIndex = 6;
            this.cbbGift.ValueMember = "g_id";
            // 
            // giftBindingSource
            // 
            this.giftBindingSource.DataMember = "Gift";
            this.giftBindingSource.DataSource = this.petStoreDataSet1;
            // 
            // petStoreDataSet1
            // 
            this.petStoreDataSet1.DataSetName = "PetStoreDataSet1";
            this.petStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(881, 282);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // giftTableAdapter
            // 
            this.giftTableAdapter.ClearBeforeFill = true;
            // 
            // rbbSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 550);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.rbbSale);
            this.Name = "rbbSell";
            this.Ribbon = this.rbbSale;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Sell";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.rbbSell_FormClosing);
            this.Load += new System.EventHandler(this.rbbSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rbbSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGuest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rbbSale;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbbiSale;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbbpgTasks;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiPrint;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private System.Windows.Forms.Label lblGuest;
        private System.Windows.Forms.Label lblGift;
        private System.Windows.Forms.Label lblAddress;
        private DevExpress.XtraEditors.TextEdit txtGuest;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private System.Windows.Forms.ComboBox cbbGift;
        private PetStoreDataSet1 petStoreDataSet1;
        private System.Windows.Forms.BindingSource giftBindingSource;
        private PetStoreDataSet1TableAdapters.GiftTableAdapter giftTableAdapter;
    }
}