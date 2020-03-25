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
    public partial class Staff : DevExpress.XtraEditors.XtraForm
    {
        //declare variables
        int acId = -1;
        string username = "";
        string password = "";
        //Initialize a delegate to get username 
        public delegate void sendDataStaff(string data);
        public sendDataStaff SenderStaff;

        public void getUserName(string user)
        {
            username = user;
        }

        public void getPassword(string pwd)
        {
            password = pwd;
        }

        public Staff()
        {
            
            InitializeComponent();
            SenderStaff = new sendDataStaff(getUserName);
            SenderStaff = new sendDataStaff(getPassword);
        }

        /// <summary>
        /// clear children form
        /// </summary>
        private void resetFormChildren()
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
        }

        private void btnPFood_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resetFormChildren();
            PetFoodStaff pfs = new PetFoodStaff();
            pfs.MdiParent = this;
            pfs.Dock = DockStyle.Fill;
            pfs.Show();
        }

        private void btnCmtList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resetFormChildren();
            CommentStaff cs = new CommentStaff();
            cs.MdiParent = this;
            cs.Dock = DockStyle.Fill;
            cs.Show();
        }

        private void btnSellProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resetFormChildren();
            rbbSell sp = new rbbSell();
            sp.MdiParent = this;
            sp.Dock = DockStyle.Fill;
            sp.Show();
        }

        private void btnPet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resetFormChildren();
            PetStaff ps = new PetStaff();
            ps.MdiParent = this;
            ps.Dock = DockStyle.Fill;
            ps.Show();
        }

        private void btnResetPassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(username);
        }
    }
}