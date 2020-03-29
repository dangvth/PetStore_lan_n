using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using PetStore.Model;
using DevExpress.XtraEditors;

namespace PetStore
{
    public partial class CommentStaff : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        String IDSelected = "";

        public CommentStaff()
        {
            InitializeComponent();
        }

        private void btnViewCmtd_ItemClick(object sender, ItemClickEventArgs e)
        {
            //show comment detail form
            CommentDetailStaff cds = new CommentDetailStaff();
            cds.ShowDialog();
        }

        private void btnDeleteCmt_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IDSelected != "")
            {
                CommentModel cm = new CommentModel();
                //delete comment selected (set status to Inactive)
                cm.DeleteComment(Convert.ToInt32(IDSelected));
                XtraMessageBox.Show("Delete successful !!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CommentStaff_Load(sender, e);
            }
            else
            {
                XtraMessageBox.Show("Please choose a food item to 'Delete' !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRestoreCmt_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IDSelected != "")
            {
                CommentModel cm = new CommentModel();
                //Restore comment selected (set status to Active)
                cm.RestoreComment(Convert.ToInt32(IDSelected));
                XtraMessageBox.Show("Restore successful !!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CommentStaff_Load(sender, e);
            }
            else
            {
                XtraMessageBox.Show("Please choose a food item to 'restore' !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefreshCmt_ItemClick(object sender, ItemClickEventArgs e)
        {
            CommentStaff_Load(sender, e);
        }

        private void CommentStaff_Load(object sender, EventArgs e)
        {
            //load data to grid view
            CommentModel cm = new CommentModel();
            bindingSourceComment.DataSource = cm.GetAllDataToArrayList();
            gcComment.DataSource = bindingSourceComment;
        }

        private void gvComment_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //get index of comment on grid view
            int idx = gvComment.FocusedRowHandle;
            if (gvComment.GetRowCellValue(idx, gvComment.Columns[0]) != null)
            {
                //get id of comment
                IDSelected = gvComment.GetRowCellValue(idx, gvComment.Columns[0]).ToString();
            }
        }
    }
}