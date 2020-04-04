using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PetStore.Model;

namespace PetStore
{
    public partial class EditUser : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public EditUser()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Save user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_uName.Text != "" && txt_uMail.Text != "" && txt_uPhone.Text != "")
            {
                UserModel um = new UserModel();
                um.UpdateUser(int.Parse(txt_uID.Text), txt_uName.Text, txt_uGender.Text, txt_uMail.Text, txt_uPhone.Text, txt_uAddress.Text);
                XtraMessageBox.Show("Edit successful !!!", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Please fill in full information !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Reset change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var db = new PetStoreEntities();
            var u = db.Users.Find(int.Parse(txt_uID.Text));
            txt_uName.Text = u.u_name;
            txt_uGender.Text = u.u_gender;
            txt_uMail.Text = u.u_email;
            txt_uPhone.Text = u.u_phone;
            txt_uAddress.Text = u.u_address;
        }
        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}