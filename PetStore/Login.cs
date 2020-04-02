using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetStore.MyUtil;

namespace PetStore
{
    public partial class Login : Form
    {
        private Model.AccountModel am;

        /// <summary>
        /// Initialize Login class
        /// </summary>
        public Login()
        {
            InitializeComponent();
            am = new Model.AccountModel();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Authentication Administrator or Employee when login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string pwd = txtPwd.Text;
            //get role of account
            int role = am.checkRole(userName);
            //if correct account then decentralization
            if (am.isCorrectAccount(userName, pwd))     
            {
                //check role if role = 1 then load form Administrator, 
                //role = 2 then load form Staff
                if (am.checkRole(userName) == 1)
                {
                    frmAdmin ad = new frmAdmin();
                    //send username to admin form
                    ad.SenderAD(txtUsername.Text);
                    ad.Show();
                    this.Hide();
                }
                else if (am.checkRole(userName) == 2)
                {
                    Staff s = new Staff();
                    //send username to Staff form
                    s.SenderStaffUser(txtUsername.Text);
                    s.Show();
                    this.Hide();
                }
            }
            else    //Send error message when enter wrong account
            {
                MessageBox.Show("Username or Password is not correct!", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
