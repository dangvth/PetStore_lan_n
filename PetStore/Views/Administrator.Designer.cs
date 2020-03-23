namespace PetStore
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.petStoreEntitiesView1 = new PetStore.Views.PetStoreEntitiesView.PetStoreEntitiesView();
            this.SuspendLayout();
            // 
            // petStoreEntitiesView1
            // 
            this.petStoreEntitiesView1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.petStoreEntitiesView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.petStoreEntitiesView1.Location = new System.Drawing.Point(0, 0);
            this.petStoreEntitiesView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.petStoreEntitiesView1.Name = "petStoreEntitiesView1";
            this.petStoreEntitiesView1.Size = new System.Drawing.Size(1118, 668);
            this.petStoreEntitiesView1.TabIndex = 0;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 668);
            this.Controls.Add(this.petStoreEntitiesView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Views.PetStoreEntitiesView.PetStoreEntitiesView mainView;
        private Views.PetStoreEntitiesView.PetStoreEntitiesView petStoreEntitiesView1;
    }
}

