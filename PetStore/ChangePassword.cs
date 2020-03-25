using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetStore;


namespace PetStore
{
    public partial class ChangePassword : Form
    {
        //declare model
        Model.AccountModel am;

        //declare variables
        int acId = -1;
        string username = "";

        //Initialize a delegate to get username 
        public delegate void sendData(string data);
        public sendData SenderUser;
        int id = -1;

        public ChangePassword()
        {
            InitializeComponent();
            SenderUser = new sendData(getUserName); 
            am = new Model.AccountModel();
        }

        /// <summary>
        /// Get username by user pass from Staff form
        /// </summary>
        /// <param name="user"></param>
        public void getUserName(string user)
        {
            username = user;
        }

        /// <summary>
        /// Check new password is same to re-new password
        /// </summary>
        /// <param name="newPwd"></param>
        /// <param name="re_newPwd"></param>
        /// <returns></returns>
        public bool isSamePassword()
        {
            if (txtNewPassword.Text.Equals(txtRe_newPassword.Text))
            {
                return true;
            } else
            {
                return false;
            }
        }

        /// <summary>
        /// Change password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            //Get ID by username that user has been inputted
            id = am.getIDByUsername(username);

            //check Old Password of account
            //if true, continue processing
            //if not, send error message
            if (am.isOldPassword(id, txtOldPassword.Text))
            {
                //new password and re-new password 
                if (isSamePassword())
                {
                    //Change pasword
                    am.ChangePassword(username, txtNewPassword.Text);
                    //send notify the user
                    MessageBox.Show("Change password successfully!!!",
                    "Pet Shop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else  //send error message for user
            {
                MessageBox.Show("The Old Password is not correct!!!\n" + "Please enter again!!!",
                    "Pet Shop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
