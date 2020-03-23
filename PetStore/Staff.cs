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
        public Staff()
        {
            InitializeComponent();
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
    }
}