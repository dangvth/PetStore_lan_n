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
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using PetStore.Model;

namespace PetStore
{
    public partial class rbbSell : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //declare variables
        List<string> list;
        DataTable table;
        string username = "";
        User u;
        int total = 0;
        //Initialize a delegate to get username 
        public delegate void sendDataSell(string data);
        public sendDataSell SenderSellUser;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="user"></param>
        public rbbSell(string user)
        {
            InitializeComponent();

            username = user;
            //get username from staff
            using (var db = new PetStoreEntities())
            {
                var list = db.Accounts;
                Account ac = null;
                foreach (var a in list)
                {
                    if (a.ac_userName == user)
                    {
                        ac = a;
                        break;
                    }
                }
                var uList = db.Users;
                foreach (var uItem in uList)
                {
                    if (uItem.ac_id == ac.ac_id)
                    {
                        u = uItem;
                        break;
                    }
                }
            }
            //Display gift combobox
            foreach (var gift in this.petStoreDataSet1.Gift)
            {
                cbbGift.SelectedText = gift.g_name;
                break;
            }
            //Init data grid view
            resetTable();
        }
       /// <summary>
       /// Reset data grid view
       /// </summary>
        private void resetTable()
        {
            //Init data table
            table = new DataTable();
            //Init item list
            list = new List<string>();
            //Add column to data table
            table.Columns.Add(new DataColumn("Name", typeof(string)));
            table.Columns.Add(new DataColumn("Price", typeof(int)));
            table.Columns.Add(new DataColumn("Quantity", typeof(int)));
            //Set data source for data grid view
            dataGridView1.DataSource = table;
            //Format display format
            dataGridView1.Columns["Price"].DefaultCellStyle.Format = "c";
            total = 0;
            lblTotalPrice.Text = "Total: " + total;
        }
        /// <summary>
        /// Add item into bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Init and show select prodcut form
            rbbSelectProduct slp = new rbbSelectProduct();
            slp.ShowDialog(this);
            //Refresh data grid view
            if (slp.status != -1)
            {
                DataGridViewRow row = slp.grvProduct.Rows[slp.status];
                table.Rows.Add(row.Cells["Name"].Value.ToString(), row.Cells["Price"].Value.ToString(), slp.qty);
                list.Add(row.Cells["ID"].Value.ToString());
                total += (int.Parse(row.Cells["Price"].Value.ToString()) * slp.qty);
                lblTotalPrice.Text = "Total: " + total;
            }
            slp.Dispose();
        }
        /// <summary>
        /// Enable or disable detele button
        /// </summary>
        private void checkDelete()
        {
            bbiDelete.Enabled = false;
            int index = -1;
            try
            {
                index = dataGridView1.CurrentRow.Index;
            }
            catch (Exception)
            {
            }
            if (index != -1)
            {
                bbiDelete.Enabled = true;
            }
        }
        /// <summary>
        /// Enable or disable detele button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checkDelete();
        }
        /// <summary>
        /// Get index, delete item, and return quantity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            int index = -1;
            try
            {
                index = dataGridView1.CurrentRow.Index;
            }
            catch (Exception)
            {
                index = -1;
            }
            if (index != -1)
            {
                using (var db = new PetStoreEntities())
                {
                    string id = list[index];
                    if (id.StartsWith("PTS"))
                    {
                        db.PetToys.Find(id).pt_amount += int.Parse(dataGridView1.CurrentRow.Cells["Quantity"].Value.ToString());
                        db.SaveChanges();
                        list.RemoveAt(index);
                    }
                    else if (id.StartsWith("PFD"))
                    {
                        db.PetFoods.Find(id).pf_amount += int.Parse(dataGridView1.CurrentRow.Cells["Quantity"].Value.ToString());
                        db.SaveChanges();
                        list.RemoveAt(index);
                    }
                    else if (id.StartsWith("PAS"))
                    {
                        db.PetAccessories.Find(id).pa_amount += int.Parse(dataGridView1.CurrentRow.Cells["Quantity"].Value.ToString());
                        db.SaveChanges();
                        list.RemoveAt(index);
                    }
                    else if (id.StartsWith("PMD"))
                    {
                        db.PetMedicines.Find(id).pm_amount += int.Parse(dataGridView1.CurrentRow.Cells["Quantity"].Value.ToString());
                        db.SaveChanges();
                        list.RemoveAt(index);
                    }
                    else
                    {
                        list.RemoveAt(index);
                    }
                    
                }
                total -= (int.Parse(table.Rows[index]["Price"].ToString()) * int.Parse(table.Rows[index]["Quantity"].ToString()));
                table.Rows[index].Delete();
                dataGridView1.DataSource = table;
                lblTotalPrice.Text = "Total: " + total;
            }
        }
        /// <summary>
        /// Reset data grid view event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiReset_ItemClick(object sender, ItemClickEventArgs e)
        {
            resetDataGridView();
        }
        /// <summary>
        /// Reset data grid view and return quantity
        /// </summary>
        private void resetDataGridView()
        {
            if (list.Count != 0)
            {
                int i = list.Count;
                while (i != 0)
                {
                    using (var db = new PetStoreEntities())
                    {
                        string id = list[i-1];
                        if (id.StartsWith("PTS"))
                        {
                            db.PetToys.Find(id).pt_amount += int.Parse(dataGridView1.Rows[i-1].Cells["Quantity"].Value.ToString());
                            list.RemoveAt(i-1);
                        }
                        else if (id.StartsWith("PFD"))
                        {
                            db.PetFoods.Find(id).pf_amount += int.Parse(dataGridView1.Rows[i-1].Cells["Quantity"].Value.ToString());
                            list.RemoveAt(i-1);
                        }
                        else if (id.StartsWith("PAS"))
                        {
                            db.PetAccessories.Find(id).pa_amount += int.Parse(dataGridView1.Rows[i-1].Cells["Quantity"].Value.ToString());
                            list.RemoveAt(i-1);
                        }
                        else if (id.StartsWith("PMD"))
                        {
                            db.PetMedicines.Find(id).pm_amount += int.Parse(dataGridView1.Rows[i-1].Cells["Quantity"].Value.ToString());
                            list.RemoveAt(i-1);
                        }
                        db.SaveChanges();
                    }
                    i--;
                }
                resetTable();
                checkDelete();
            }
        }
        /// <summary>
        /// Reset data grid view and return quantity after close sell form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbbSell_FormClosing(object sender, FormClosingEventArgs e)
        {
            resetDataGridView();
        }
        /// <summary>
        /// Print bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtGuest.Text.Equals(""))
            {
                MessageBox.Show("Please input guest name!","Message");
            }
            else if (txtAddress.Text.Equals(""))
            {
                MessageBox.Show("Please input address!", "Message");
            } else
            {
                int id;
                GridControl gc = new GridControl();
                gc.DataSource = dataGridView1.DataSource;
                BillReport report = new BillReport();
                report.Parameters["pGuest"].Value = txtGuest.Text;
                report.Parameters["pAddress"].Value = txtAddress.Text;
                report.Parameters["pDate"].Value = System.DateTime.Now;
                report.Parameters["pTotal"].Value = total;
                report.Parameters["pGift"].Value = cbbGift.Text;
                using (var db = new PetStoreEntities())
                {
                    var bill = new Bill();
                    bill.b_purchaseDate = System.DateTime.Now;
                    bill.b_address = txtAddress.Text;
                    bill.b_total = total;
                    bill.u_id = u.u_id;
                    bill.g_id = cbbGift.SelectedValue.ToString();
                    bill.b_status = "Active";
                    db.Bills.Add(bill);
                    db.SaveChanges();
                }
                using (var db = new PetStoreEntities())
                {
                    var bill = from s in db.Bills orderby s.b_id descending select s;
                    id = 0;
                    foreach (var b in bill)
                    {
                        id = b.b_id;
                        break;
                    }
                    int index = 0;
                    foreach (var bd in list)
                    {
                        var billDetail = new BillDetail();
                        billDetail.b_id = id;
                        if (bd.StartsWith("PET"))
                        {
                            billDetail.p_id = bd;
                        }
                        else if (bd.StartsWith("PTS"))
                        {
                            billDetail.pt_id = bd;
                        }
                        else if (bd.StartsWith("PFD"))
                        {
                            billDetail.pf_id = bd;
                        }
                        else if (bd.StartsWith("PAS"))
                        {
                            billDetail.pa_id = bd;
                        }
                        else if (bd.StartsWith("PMD"))
                        {
                            billDetail.pm_id = bd;
                        }
                        int qty = int.Parse(dataGridView1.Rows[index].Cells["Quantity"].Value.ToString());
                        for (int i = 0; i < qty; i++)
                        {
                            db.BillDetails.Add(billDetail);
                            db.SaveChanges();
                        }
                        index++;
                    }
                }
                report.Parameters["pID"].Value = id;
                report.GridControl = gc;
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.AutoShowParametersPanel = true;
                printTool.ShowPreviewDialog();
                resetTable();
            }
        }
        /// <summary>
        /// Load data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbbSell_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petStoreDataSet1.Gift' table. You can move, or remove it, as needed.
            this.giftTableAdapter.Fill(this.petStoreDataSet1.Gift);
        }
    }
}