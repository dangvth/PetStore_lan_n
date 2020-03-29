namespace PetStore
{
    partial class SelectGift
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
            this.lblGift = new System.Windows.Forms.Label();
            this.cbbGift = new System.Windows.Forms.ComboBox();
            this.petStoreDataSet1 = new PetStore.PetStoreDataSet1();
            this.giftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giftTableAdapter = new PetStore.PetStoreDataSet1TableAdapters.GiftTableAdapter();
            this.btnContinue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGift
            // 
            this.lblGift.AutoSize = true;
            this.lblGift.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGift.Location = new System.Drawing.Point(42, 53);
            this.lblGift.Name = "lblGift";
            this.lblGift.Size = new System.Drawing.Size(34, 19);
            this.lblGift.TabIndex = 0;
            this.lblGift.Text = "Gift";
            // 
            // cbbGift
            // 
            this.cbbGift.DataSource = this.giftBindingSource;
            this.cbbGift.DisplayMember = "g_name";
            this.cbbGift.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGift.FormattingEnabled = true;
            this.cbbGift.Location = new System.Drawing.Point(82, 50);
            this.cbbGift.Name = "cbbGift";
            this.cbbGift.Size = new System.Drawing.Size(270, 27);
            this.cbbGift.TabIndex = 1;
            this.cbbGift.ValueMember = "g_id";
            // 
            // petStoreDataSet1
            // 
            this.petStoreDataSet1.DataSetName = "PetStoreDataSet1";
            this.petStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giftBindingSource
            // 
            this.giftBindingSource.DataMember = "Gift";
            this.giftBindingSource.DataSource = this.petStoreDataSet1;
            // 
            // giftTableAdapter
            // 
            this.giftTableAdapter.ClearBeforeFill = true;
            // 
            // btnContinue
            // 
            this.btnContinue.AutoSize = true;
            this.btnContinue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(162, 129);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(82, 29);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // SelectGift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 213);
            this.ControlBox = false;
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.cbbGift);
            this.Controls.Add(this.lblGift);
            this.MaximizeBox = false;
            this.Name = "SelectGift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Gift";
            this.Load += new System.EventHandler(this.SelectGift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGift;
        private PetStoreDataSet1 petStoreDataSet1;
        private System.Windows.Forms.BindingSource giftBindingSource;
        private PetStoreDataSet1TableAdapters.GiftTableAdapter giftTableAdapter;
        private System.Windows.Forms.Button btnContinue;
        public System.Windows.Forms.ComboBox cbbGift;
    }
}