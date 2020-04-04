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

namespace PetStore
{
    public partial class SelectGift : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SelectGift()
        {
            InitializeComponent();
        }
        /// <summary>
        /// load gift
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectGift_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petStoreDataSet1.Gift' table. You can move, or remove it, as needed.
            this.giftTableAdapter.Fill(this.petStoreDataSet1.Gift);

        }
        /// <summary>
        /// Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// Hide form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}