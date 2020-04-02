using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PetStore
{
    public partial class frmAdmin : DevExpress.XtraEditors.XtraForm
    {
        //declare variables
        string username = "";
        //Initialize a delegate to get username 
        public delegate void sendDataAD(string data);
        public sendDataAD SenderAD;

        /// <summary>
        /// Get username by user pass from Login form
        /// </summary>
        /// <param name="user"></param>
        public void getUserName(string user)
        {
            username = user;
        }

        /// <summary>
        /// Initialize Admin Form
        /// </summary>
        public frmAdmin()
        {
            InitializeComponent();
            SenderAD = new sendDataAD(getUserName);           
        }

        /// <summary>
        /// Open ChangePassword form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(username);
            ChangePassword cpw = new ChangePassword();
            cpw.SenderUser(username);
            cpw.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {            
            Login lg = new Login();
            lg.Show();
            this.Dispose();
        }

        /// <summary>
        /// Exit app when click closing form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
