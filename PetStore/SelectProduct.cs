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

namespace PetStore
{
    public partial class rbbSelectProduct : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //Declare variables
        public const int Row_Height = 100;
        public int status, qty;
        /// <summary>
        /// Constructor
        /// </summary>
        public rbbSelectProduct()
        {
            InitializeComponent();
            displayProduct("Pets");
        }
        /// <summary>
        /// Display product
        /// </summary>
        /// <param name="name"></param>
        public void displayProduct(string name)
        {
            if (name.Equals("Pets"))
            {
                grvProduct.DataSource = null;
                using (var db = new PetStoreEntities()) {
                    DataTable table = new DataTable();
                    table.Columns.Add(new DataColumn("ID", typeof(string)));
                    table.Columns.Add(new DataColumn("Name", typeof(string)));
                    table.Columns.Add(new DataColumn("Price", typeof(int)));
                    table.Columns.Add(new DataColumn("Picture", typeof(Image)));
                    var select = from s in db.Pets where s.p_status == "Active" select s;
                    foreach (var p in select)
                    {
                        table.Rows.Add(p.p_id, p.p_name, p.p_salePrice, p.Picture);
                    }
                    grvProduct.DataSource = table;
                    grvProduct.Columns["Price"].DefaultCellStyle.Format = "c";
                    grvProduct.RowTemplate.Height = Row_Height;
                    ((DataGridViewImageColumn)grvProduct.Columns["Picture"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
            else if (name.Equals("Pet's Toys"))
            {
                grvProduct.DataSource = null;
                using (var db = new PetStoreEntities())
                {
                    DataTable table = new DataTable();
                    table.Columns.Add(new DataColumn("ID", typeof(string)));
                    table.Columns.Add(new DataColumn("Name", typeof(string)));
                    table.Columns.Add(new DataColumn("Price", typeof(int)));
                    table.Columns.Add(new DataColumn("Remain", typeof(int)));
                    table.Columns.Add(new DataColumn("Picture", typeof(Image)));
                    var select = from s in db.PetToys where s.pt_status == "Active" && s.pt_amount > 0 select s;
                    int d = 0;
                    foreach (var pt in select)
                    {
                        table.Rows.Add(pt.pt_id, pt.pt_name, pt.pt_salePrice, pt.pt_amount, pt.Picture);
                    }
                    grvProduct.DataSource = table;
                    grvProduct.Columns["Price"].DefaultCellStyle.Format = "c";
                    grvProduct.RowTemplate.Height = Row_Height;
                    ((DataGridViewImageColumn)grvProduct.Columns["Picture"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
            else if (name.Equals("Pet's Foods"))
            {
                grvProduct.DataSource = null;
                using (var db = new PetStoreEntities())
                {
                    DataTable table = new DataTable();
                    table.Columns.Add(new DataColumn("ID", typeof(string)));
                    table.Columns.Add(new DataColumn("Name", typeof(string)));
                    table.Columns.Add(new DataColumn("Price", typeof(int)));
                    table.Columns.Add(new DataColumn("Remain", typeof(int)));
                    table.Columns.Add(new DataColumn("Picture", typeof(Image)));
                    var select = from s in db.PetFoods where s.pf_status == "Active" && s.pf_amount > 0 select s;
                    int d = 0;
                    foreach (var pf in select)
                    {
                        table.Rows.Add(pf.pf_id, pf.pf_name, pf.pf_salePrice, pf.pf_amount, pf.Picture);
                    }
                    grvProduct.DataSource = table;
                    grvProduct.Columns["Price"].DefaultCellStyle.Format = "c";
                    grvProduct.RowTemplate.Height = Row_Height;
                    ((DataGridViewImageColumn)grvProduct.Columns["Picture"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
            else if (name.Equals("Pet's Accessories"))
            {
                grvProduct.DataSource = null;
                using (var db = new PetStoreEntities())
                {
                    DataTable table = new DataTable();
                    table.Columns.Add(new DataColumn("ID", typeof(string)));
                    table.Columns.Add(new DataColumn("Name", typeof(string)));
                    table.Columns.Add(new DataColumn("Price", typeof(int)));
                    table.Columns.Add(new DataColumn("Remain", typeof(int)));
                    var select = from s in db.PetAccessories where s.pa_status == "Active" && s.pa_amount > 0 select s;
                    int d = 0;
                    foreach (var pa in select)
                    {
                        table.Rows.Add(pa.pa_id, pa.pa_name, pa.pa_salePrice, pa.pa_amount);
                    }
                    grvProduct.DataSource = table;
                    grvProduct.Columns["Price"].DefaultCellStyle.Format = "c";
                    //grvProduct.RowTemplate.Height = Row_Height;
                    //((DataGridViewImageColumn)grvProduct.Columns["Picture"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
            else if (name.Equals("Pet's Medicines"))
            {
                grvProduct.DataSource = null;
                using (var db = new PetStoreEntities())
                {
                    DataTable table = new DataTable();
                    table.Columns.Add(new DataColumn("ID", typeof(string)));
                    table.Columns.Add(new DataColumn("Name", typeof(string)));
                    table.Columns.Add(new DataColumn("Price", typeof(int)));
                    table.Columns.Add(new DataColumn("Remain", typeof(int)));
                    table.Columns.Add(new DataColumn("Picture", typeof(Image)));
                    var select = from s in db.PetMedicines where s.pm_status == "Active" && s.pm_amount > 0 select s;
                    int d = 0;
                    foreach (var pm in select)
                    {
                        table.Rows.Add(pm.pm_id, pm.pm_name, pm.pm_salePrice, pm.pm_amount, pm.Picture);
                    }
                    grvProduct.DataSource = table;
                    grvProduct.Columns["Price"].DefaultCellStyle.Format = "c";
                    grvProduct.RowTemplate.Height = Row_Height;
                    ((DataGridViewImageColumn)grvProduct.Columns["Picture"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
        }
        /// <summary>
        /// Display navagator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bliProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            switch (bliProduct.ItemIndex)
            {
                case 0:
                    this.displayProduct("Pets");
                    rbbpgSelectProduct.Text = "Pets";
                    checkBbiAddStatus();
                    break;
                case 1:
                    this.displayProduct("Pet's Toys");
                    rbbpgSelectProduct.Text = "Pet's Toys";
                    checkBbiAddStatus();
                    break;
                case 2:
                    this.displayProduct("Pet's Foods");
                    rbbpgSelectProduct.Text = "Pet's Foods";
                    checkBbiAddStatus();
                    break;
                case 3:
                    this.displayProduct("Pet's Accessories");
                    rbbpgSelectProduct.Text = "Pet's Accessories";
                    checkBbiAddStatus();
                    break;
                case 4:
                    this.displayProduct("Pet's Medicines");
                    rbbpgSelectProduct.Text = "Pet's Medicines";
                    checkBbiAddStatus();
                    break;
                default:
                    break;
        }
        }
        /// <summary>
        /// Enable, disable add button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checkBbiAddStatus();
        }
        /// <summary>
        /// Enable, disable add button
        /// </summary>
        private void checkBbiAddStatus()
        {
            bbiAdd.Enabled = false;
            int index = -1;
            try
            {
                index = grvProduct.CurrentRow.Index;
            }
            catch (Exception)
            {
            }
            if (index != -1)
            {
                bbiAdd.Enabled = true;
            }
        }
        /// <summary>
        /// Show enter quantity form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            int index = -1;
            try
            {
                index = grvProduct.CurrentRow.Index;
            }
            catch (Exception)
            {
                index = -1;
            }
            if (index != -1)
            {
                int remain = 0;
                string id = grvProduct.CurrentRow.Cells["ID"].Value.ToString();
                if (!id.StartsWith("PET"))
                {
                    remain = int.Parse(grvProduct.CurrentRow.Cells["Remain"].Value.ToString());
                }
                EnterQuantity eq = new EnterQuantity(id, remain);
                eq.ShowDialog(this);
                qty = int.Parse(eq.txtQuantity.Text);
                if (qty != 0)
                {
                    eq.Dispose();
                    using (var db = new PetStoreEntities())
                    {
                        switch (bliProduct.ItemIndex)
                        {
                            case 1:
                                db.PetToys.Find(id).pt_amount -= qty;
                                db.SaveChanges(); 
                                break;
                            case 2:
                                db.PetFoods.Find(id).pf_amount -= qty;
                                db.SaveChanges();
                                break;
                            case 3:
                                db.PetAccessories.Find(id).pa_amount -= qty;
                                db.SaveChanges();
                                break;
                            case 4:
                                db.PetMedicines.Find(id).pm_amount -= qty;
                                db.SaveChanges();
                                break;
                            default:
                                break;
                        }
                    }
                    status = grvProduct.CurrentRow.Index;
                    this.Hide();
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            status = -1;
            this.Hide();
        }
    }
}