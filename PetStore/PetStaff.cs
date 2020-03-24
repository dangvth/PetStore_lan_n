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
    public partial class PetStaff : DevExpress.XtraEditors.XtraForm
    {
        public PetStaff()
        {
            InitializeComponent();
        }

        private void PetStaff_Load(object sender, EventArgs e)
        {
            PetModel pm = new PetModel();
            bsPet.DataSource = pm.getAllPet();
            gcPet.DataSource = bsPet;
        }

        private void btnRefreshFood_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PetStaff_Load(sender, e);
        }
    }
}