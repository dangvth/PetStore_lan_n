﻿namespace PetStore
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
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblChangePwd = new System.Windows.Forms.Label();
            this.pnlChangePwd = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.petStoreEntitiesView1 = new PetStore.Views.PetStoreEntitiesView.PetStoreEntitiesView();
            this.pnlChangePwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.BackgroundImage")));
            this.btnChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChangePassword.ForeColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.Location = new System.Drawing.Point(25, 2);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(77, 59);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblChangePwd
            // 
            this.lblChangePwd.AutoSize = true;
            this.lblChangePwd.Location = new System.Drawing.Point(10, 75);
            this.lblChangePwd.Name = "lblChangePwd";
            this.lblChangePwd.Size = new System.Drawing.Size(117, 17);
            this.lblChangePwd.TabIndex = 2;
            this.lblChangePwd.Text = "Change password";
            // 
            // pnlChangePwd
            // 
            this.pnlChangePwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChangePwd.BackColor = System.Drawing.Color.Transparent;
            this.pnlChangePwd.Controls.Add(this.lblLogout);
            this.pnlChangePwd.Controls.Add(this.btnLogout);
            this.pnlChangePwd.Controls.Add(this.btnChangePassword);
            this.pnlChangePwd.Controls.Add(this.lblChangePwd);
            this.pnlChangePwd.Location = new System.Drawing.Point(903, 32);
            this.pnlChangePwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlChangePwd.Name = "pnlChangePwd";
            this.pnlChangePwd.Size = new System.Drawing.Size(215, 103);
            this.pnlChangePwd.TabIndex = 3;
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Location = new System.Drawing.Point(133, 75);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(52, 17);
            this.lblLogout.TabIndex = 4;
            this.lblLogout.Text = "Logout";
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Location = new System.Drawing.Point(124, 2);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(77, 59);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // petStoreEntitiesView1
            // 
            this.petStoreEntitiesView1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.petStoreEntitiesView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.petStoreEntitiesView1.Location = new System.Drawing.Point(0, 0);
            this.petStoreEntitiesView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.petStoreEntitiesView1.Name = "petStoreEntitiesView1";
            this.petStoreEntitiesView1.Size = new System.Drawing.Size(1118, 668);
            this.petStoreEntitiesView1.TabIndex = 0;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 668);
            this.Controls.Add(this.pnlChangePwd);
            this.Controls.Add(this.petStoreEntitiesView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlChangePwd.ResumeLayout(false);
            this.pnlChangePwd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Views.PetStoreEntitiesView.PetStoreEntitiesView mainView;
        private Views.PetStoreEntitiesView.PetStoreEntitiesView petStoreEntitiesView1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblChangePwd;
        private System.Windows.Forms.Panel pnlChangePwd;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Button btnLogout;
    }
}

