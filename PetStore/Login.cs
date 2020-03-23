using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStore
{
    public partial class Login : Form
    {
        private Model.AccountModel am = new Model.AccountModel();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string pwd = txtPwd.Text;
            int role = am.checkRole(userName);
            if (am.isCorrectAccount(userName, pwd))
            {
                //check role if role = 1 then load form Administrator, role = 2 then load form Staff
                if (am.checkRole(userName) == 1)
                {
                    frmAdmin ad = new frmAdmin();
                    this.Hide();
                    ad.Show();

                }
                else if (am.checkRole(userName) == 2)
                {
                    Staff s = new Staff();
                    //delPassData trans = new delPassData(s.getUserName);
                    //trans(this.txtUsername);
                    s.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Username or Password is not correct!", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
