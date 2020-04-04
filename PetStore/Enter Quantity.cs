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
        //Declare variables
        string id;
        int remain;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="remain"></param>
        public EnterQuantity(string id, int remain)
        {
            this.id = id;
            this.remain = remain;
            InitializeComponent();
        }
        /// <summary>
        /// Check quantity and hide form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Cancel enter quantity form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = "0";
            this.Hide();
        }
    }
}