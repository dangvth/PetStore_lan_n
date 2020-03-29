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
        public SelectGift()
        {
            InitializeComponent();
        }

        private void SelectGift_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petStoreDataSet1.Gift' table. You can move, or remove it, as needed.
            this.giftTableAdapter.Fill(this.petStoreDataSet1.Gift);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}