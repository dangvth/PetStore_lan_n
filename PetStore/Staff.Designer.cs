namespace PetStore
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnOnlineOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnSellProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnPet = new DevExpress.XtraBars.BarButtonItem();
            this.btnPFood = new DevExpress.XtraBars.BarButtonItem();
            this.btnPAccessories = new DevExpress.XtraBars.BarButtonItem();
            this.btnPToy = new DevExpress.XtraBars.BarButtonItem();
            this.btnPMed = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiftList = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnResetPassword = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestoreCmt = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewCmtd = new DevExpress.XtraBars.BarButtonItem();
            this.btnCmtList = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.rbpSales = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpgBillSale = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpProduct = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpgPet = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgGift = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpComment = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbSystem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpgAccount = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonTheme = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.btnOnlineOrder,
            this.btnSellProduct,
            this.btnPet,
            this.btnPFood,
            this.btnPAccessories,
            this.btnPToy,
            this.btnPMed,
            this.barButtonItem2,
            this.btnGiftList,
            this.btnLogout,
            this.btnResetPassword,
            this.btnRestoreCmt,
            this.btnViewCmtd,
            this.btnCmtList,
            this.ribbonGalleryBarItem1,
            this.skinRibbonGalleryBarItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 23;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpSales,
            this.rbpProduct,
            this.rbpComment,
            this.rbSystem});
            this.ribbon.Size = new System.Drawing.Size(1125, 176);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnOnlineOrder
            // 
            this.btnOnlineOrder.Caption = "Online Order";
            this.btnOnlineOrder.Hint = "Show Bill Order Online";
            this.btnOnlineOrder.Id = 2;
            this.btnOnlineOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOnlineOrder.ImageOptions.Image")));
            this.btnOnlineOrder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOnlineOrder.ImageOptions.LargeImage")));
            this.btnOnlineOrder.LargeWidth = 75;
            this.btnOnlineOrder.Name = "btnOnlineOrder";
            // 
            // btnSellProduct
            // 
            this.btnSellProduct.Caption = "Sell Product";
            this.btnSellProduct.Id = 3;
            this.btnSellProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSellProduct.ImageOptions.Image")));
            this.btnSellProduct.Name = "btnSellProduct";
            this.btnSellProduct.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSellProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSellProduct_ItemClick);
            // 
            // btnPet
            // 
            this.btnPet.Caption = "Pet ";
            this.btnPet.Id = 4;
            this.btnPet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPet.ImageOptions.Image")));
            this.btnPet.Name = "btnPet";
            this.btnPet.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPet_ItemClick);
            // 
            // btnPFood
            // 
            this.btnPFood.Caption = "Food";
            this.btnPFood.Id = 7;
            this.btnPFood.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPFood.ImageOptions.Image")));
            this.btnPFood.LargeWidth = 65;
            this.btnPFood.Name = "btnPFood";
            this.btnPFood.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipItem3.Text = "Show Pet\'s food list";
            superToolTip3.Items.Add(toolTipItem3);
            this.btnPFood.SuperTip = superToolTip3;
            this.btnPFood.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPFood_ItemClick);
            // 
            // btnPAccessories
            // 
            this.btnPAccessories.Caption = "Accessories";
            this.btnPAccessories.Id = 8;
            this.btnPAccessories.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPAccessories.ImageOptions.Image")));
            this.btnPAccessories.Name = "btnPAccessories";
            this.btnPAccessories.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnPToy
            // 
            this.btnPToy.Caption = "Toys";
            this.btnPToy.Id = 9;
            this.btnPToy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPToy.ImageOptions.Image")));
            this.btnPToy.LargeWidth = 65;
            this.btnPToy.Name = "btnPToy";
            this.btnPToy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPToy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPToy_ItemClick);
            // 
            // btnPMed
            // 
            this.btnPMed.Caption = "Medicine";
            this.btnPMed.Id = 10;
            this.btnPMed.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPMed.ImageOptions.Image")));
            this.btnPMed.Name = "btnPMed";
            this.btnPMed.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPMed.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPMed_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 12;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnGiftList
            // 
            this.btnGiftList.Caption = "Gift List";
            this.btnGiftList.Id = 13;
            this.btnGiftList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiftList.ImageOptions.Image")));
            this.btnGiftList.LargeWidth = 75;
            this.btnGiftList.Name = "btnGiftList";
            this.btnGiftList.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Log out";
            this.btnLogout.Id = 14;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.LargeWidth = 60;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Caption = "Change password";
            this.btnResetPassword.Id = 15;
            this.btnResetPassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnResetPassword.ImageOptions.Image")));
            this.btnResetPassword.LargeWidth = 100;
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnResetPassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResetPassword_ItemClick);
            // 
            // btnRestoreCmt
            // 
            this.btnRestoreCmt.Caption = "Restore comment";
            this.btnRestoreCmt.Id = 16;
            this.btnRestoreCmt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestoreCmt.ImageOptions.Image")));
            this.btnRestoreCmt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRestoreCmt.ImageOptions.LargeImage")));
            this.btnRestoreCmt.LargeWidth = 60;
            this.btnRestoreCmt.Name = "btnRestoreCmt";
            // 
            // btnViewCmtd
            // 
            this.btnViewCmtd.Caption = "View comment detail";
            this.btnViewCmtd.Id = 19;
            this.btnViewCmtd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewCmtd.ImageOptions.Image")));
            this.btnViewCmtd.LargeWidth = 105;
            this.btnViewCmtd.Name = "btnViewCmtd";
            this.btnViewCmtd.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnCmtList
            // 
            this.btnCmtList.Caption = "Comment List";
            this.btnCmtList.Id = 20;
            this.btnCmtList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCmtList.ImageOptions.Image")));
            this.btnCmtList.LargeWidth = 70;
            this.btnCmtList.Name = "btnCmtList";
            this.btnCmtList.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipItem4.Text = "Show comment list of user";
            superToolTip4.Items.Add(toolTipItem4);
            this.btnCmtList.SuperTip = superToolTip4;
            this.btnCmtList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCmtList_ItemClick);
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            this.ribbonGalleryBarItem1.Id = 21;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // rbpSales
            // 
            this.rbpSales.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpgBillSale});
            this.rbpSales.Name = "rbpSales";
            this.rbpSales.Text = "Sales";
            // 
            // rbpgBillSale
            // 
            this.rbpgBillSale.ItemLinks.Add(this.btnSellProduct);
            this.rbpgBillSale.ItemLinks.Add(this.btnOnlineOrder);
            this.rbpgBillSale.Name = "rbpgBillSale";
            this.rbpgBillSale.Text = "Bill";
            // 
            // rbpProduct
            // 
            this.rbpProduct.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpgPet,
            this.rbpgGift});
            this.rbpProduct.KeyTip = "ABC";
            this.rbpProduct.Name = "rbpProduct";
            this.rbpProduct.Text = "Product";
            // 
            // rbpgPet
            // 
            this.rbpgPet.ItemLinks.Add(this.btnPet);
            this.rbpgPet.ItemLinks.Add(this.btnPFood);
            this.rbpgPet.ItemLinks.Add(this.btnPAccessories);
            this.rbpgPet.ItemLinks.Add(this.btnPToy);
            this.rbpgPet.ItemLinks.Add(this.btnPMed);
            this.rbpgPet.Name = "rbpgPet";
            this.rbpgPet.Text = "View";
            // 
            // rbpgGift
            // 
            this.rbpgGift.ItemLinks.Add(this.btnGiftList);
            this.rbpgGift.Name = "rbpgGift";
            this.rbpgGift.Text = "Gift";
            // 
            // rbpComment
            // 
            this.rbpComment.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbpComment.Name = "rbpComment";
            this.rbpComment.Text = "Comment Managment";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCmtList);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Comment";
            // 
            // rbSystem
            // 
            this.rbSystem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpgAccount,
            this.ribbonTheme});
            this.rbSystem.Name = "rbSystem";
            this.rbSystem.Text = "System";
            // 
            // rbpgAccount
            // 
            this.rbpgAccount.ItemLinks.Add(this.btnLogout);
            this.rbpgAccount.ItemLinks.Add(this.btnResetPassword);
            this.rbpgAccount.Name = "rbpgAccount";
            this.rbpgAccount.Text = "Account";
            // 
            // ribbonTheme
            // 
            this.ribbonTheme.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonTheme.Name = "ribbonTheme";
            this.ribbonTheme.Text = "Theme";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 22;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // Staff
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 756);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Staff_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnOnlineOrder;
        private DevExpress.XtraBars.BarButtonItem btnSellProduct;
        private DevExpress.XtraBars.BarButtonItem btnPet;
        private DevExpress.XtraBars.BarButtonItem btnPFood;
        private DevExpress.XtraBars.BarButtonItem btnPAccessories;
        private DevExpress.XtraBars.BarButtonItem btnPToy;
        private DevExpress.XtraBars.BarButtonItem btnPMed;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpSales;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgBillSale;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpProduct;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgPet;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpComment;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnGiftList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgGift;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnResetPassword;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgAccount;
        private DevExpress.XtraBars.BarButtonItem btnRestoreCmt;
        private DevExpress.XtraBars.BarButtonItem btnViewCmtd;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraBars.BarButtonItem btnCmtList;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonTheme;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
    }
}