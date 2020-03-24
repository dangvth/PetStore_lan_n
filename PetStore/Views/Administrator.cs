using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PetStore
{
    public partial class frmAdmin : DevExpress.XtraEditors.XtraForm
    {
        //declare variables
        int acId = -1;
        string username = "";
        //Initialize a delegate to get username 
        public delegate void sendDataAD(string data);
        public sendDataAD SenderAD;

        public frmAdmin()
        {
            InitializeComponent();
           
        }
    }
}
