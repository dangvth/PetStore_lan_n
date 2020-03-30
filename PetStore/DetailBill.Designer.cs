namespace PetStore
{
    partial class DetailBill
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
            this.grvDetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // grvDetail
            // 
            this.grvDetail.AllowUserToAddRows = false;
            this.grvDetail.AllowUserToDeleteRows = false;
            this.grvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDetail.Location = new System.Drawing.Point(0, 0);
            this.grvDetail.Name = "grvDetail";
            this.grvDetail.ReadOnly = true;
            this.grvDetail.Size = new System.Drawing.Size(560, 342);
            this.grvDetail.TabIndex = 0;
            // 
            // DetailBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 342);
            this.Controls.Add(this.grvDetail);
            this.Name = "DetailBill";
            this.Text = "Detail Bill";
            ((System.ComponentModel.ISupportInitialize)(this.grvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView grvDetail;
    }
}