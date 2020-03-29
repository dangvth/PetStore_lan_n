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
using System.Collections;
using DevExpress.XtraEditors;

namespace PetStore
{
    public partial class CommentDetailStaff : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        String cmtdIDSelected = "";
        public CommentDetailStaff()
        {
            InitializeComponent();
        }

        private void CommentDetailStaff_Load(object sender, EventArgs e)
        {
            //load data to grid view
            CommentDetailModel cmtdm = new CommentDetailModel();
            ArrayList cmtdList = cmtdm.GetAllDataToArrayList();
            commentDetailBindingSource.DataSource = cmtdList;
            gcCmtDetail.DataSource = commentDetailBindingSource;
        }

        private void btnRemove_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (cmtdIDSelected != "")
            {
                //remove item (set status Inactive)
                CommentDetailModel cmtd = new CommentDetailModel();
                cmtd.DeleteCommentDetail(Convert.ToInt32(cmtdIDSelected));
                XtraMessageBox.Show("Reomve successful !!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CommentDetailStaff_Load(sender, e);
            }
            else
            {
                XtraMessageBox.Show("Please choose a food item to 'Remove' !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (cmtdIDSelected != "")
            {
                //restore item (set status Active)
                CommentDetailModel cmtd = new CommentDetailModel();
                cmtd.RestoreCommentDetail(Convert.ToInt32(cmtdIDSelected));
                XtraMessageBox.Show("Restore successful !!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CommentDetailStaff_Load(sender, e);
            }
            else
            {
                XtraMessageBox.Show("Please choose a food item to 'restore' !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            CommentDetailStaff_Load(sender, e);
        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvCommentDetail_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //get index of item select on grid view
            int idx = gvCommentDetail.FocusedRowHandle;
            if (gvCommentDetail.GetRowCellValue(idx, gvCommentDetail.Columns[0]) != null)
            {
                //get id of item
                cmtdIDSelected = gvCommentDetail.GetRowCellValue(idx, gvCommentDetail.Columns[0]).ToString();
            }
        }
    }
}