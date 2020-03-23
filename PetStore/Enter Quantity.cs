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
    public partial class EnterQuantity : DevExpress.XtraEditors.XtraForm
    {
        string id;
        int remain;
        public EnterQuantity(string id, int remain)
        {
            this.id = id;
            this.remain = remain;
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (!id.StartsWith("PET"))
            {
                int qty = int.Parse(txtQuantity.Text);
                if (qty > remain)
                {
                    MessageBox.Show("This product is not sufficient quantity!", "Message");
                }
                else
                {
                    this.Hide();
                }
            } else
            {
                this.Hide();
            }
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = "0";
            this.Hide();
        }
    }
}