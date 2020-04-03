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
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;

namespace PetStore
{
    public partial class OnlineOrder : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int selectedID = -1;
        public OnlineOrder()
        {
            InitializeComponent();
        }

        private void OnlineOrder_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            UserModel um = new UserModel();
            using (var db = new PetStoreEntities())
            {
                DataTable table = new DataTable();
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Order Date", typeof(DateTime));
                table.Columns.Add("Guest", typeof(string));
                table.Columns.Add("Address", typeof(string));

                var list = db.Bills.Where(x => x.b_status == "Processing");
                foreach (var b in list)
                {
                    table.Rows.Add(b.b_id, b.b_purchaseDate, um.getUName(b.u_id), b.b_address);
                }
                grvOrder.DataSource = table;
            }
        }

        private void bbiAccept_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (selectedID != -1)
            {
                Bill bill;
                SelectGift sg = new SelectGift();
                sg.ShowDialog(this);
                UserModel um = new UserModel();
                using (var db = new PetStoreEntities())
                {
                    var u = db.Bills.Find(selectedID);
                    bill = u;
                    u.g_id = sg.cbbGift.SelectedValue.ToString();
                    u.b_status = "Acitve";
                    db.SaveChanges();
                }
                DataGridView grvPrint = new DataGridView();
                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("Name", typeof(string)));
                dt.Columns.Add(new DataColumn("Price", typeof(int)));
                dt.Columns.Add(new DataColumn("Quantity", typeof(int)));
                using (var db = new PetStoreEntities())
                {
                    var list = db.BillDetails.Where(x => x.b_id == selectedID);
                    PetModel pm = new PetModel();
                    PetFoodModel pfm = new PetFoodModel();
                    PetMedicineModel pmm = new PetMedicineModel();
                    PetToyModel ptm = new PetToyModel();
                    PetAccessoryModel pam = new PetAccessoryModel();
                    int d = 0;
                    while (d != list.Count())
                    {
                        var bd = list.ToList()[d];
                        if (bd.p_id != null)
                        {
                            var p = pm.getPet(bd.p_id);
                            var qty = list.Where(x => x.p_id == bd.p_id).Count();
                            dt.Rows.Add(p.p_name, p.p_salePrice, qty);
                            d += qty;
                        }
                        else if (bd.pt_id != null)
                        {
                            var pt = ptm.getPetToy(bd.pt_id);
                            var qty = list.Where(x => x.pt_id == bd.pt_id).Count();
                            dt.Rows.Add(pt.pt_name, pt.pt_salePrice, qty);
                            d += qty;
                        }
                        else if (bd.pf_id != null)
                        {
                            var pf = pfm.getPetFood(bd.pf_id);
                            var qty = list.Where(x => x.pf_id == bd.pf_id).Count();
                            dt.Rows.Add(pf.pf_name, pf.pf_salePrice, qty);
                            d += qty;
                        }
                        else if (bd.pm_id != null)
                        {
                            var pmd = pmm.getPetMedicine(bd.pm_id);
                            var qty = list.Where(x => x.pm_id == bd.pm_id).Count();
                            dt.Rows.Add(pmd.pm_name, pmd.pm_salePrice, qty);
                            d += qty;
                        }
                        else if (bd.pa_id != null)
                        {
                            var pa = pam.getPetAccessory(bd.pa_id);
                            var qty = list.Where(x => x.pa_id == bd.pa_id).Count();
                            dt.Rows.Add(pa.pa_name, pa.pa_salePrice, qty);
                            d += qty;
                        }
                    }
                }
                grvPrint.DataSource = dt;
                GridControl gc = new GridControl();
                gc.DataSource = grvPrint.DataSource;
                BillReport report = new BillReport();
                report.Parameters["pGuest"].Value = um.getUName(bill.u_id);
                report.Parameters["pAddress"].Value = bill.b_address;
                report.Parameters["pDate"].Value = bill.b_purchaseDate;
                report.Parameters["pTotal"].Value = bill.b_total;
                report.Parameters["pID"].Value = bill.b_id;
                
                report.Parameters["pGift"].Value = sg.cbbGift.Text;
                report.GridControl = gc;
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.AutoShowParametersPanel = true;
                printTool.ShowPreviewDialog();
                load();
            }
        }

        private void grvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedID = int.Parse(grvOrder.CurrentRow.Cells[0].Value.ToString());
        }

        private void bbiCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (selectedID != -1)
            {
                using (var db = new PetStoreEntities())
                {
                    var u = db.Bills.Find(selectedID);
                    u.b_status = "Inactive";
                    db.SaveChanges();
                }
                load();
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            DataGridView grvPrint = new DataGridView();
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Price", typeof(int)));
            dt.Columns.Add(new DataColumn("Quantity", typeof(int)));
            using (var db = new PetStoreEntities())
            {
                var list = db.BillDetails.Where(x => x.b_id == selectedID);
                PetModel pm = new PetModel();
                PetFoodModel pfm = new PetFoodModel();
                PetMedicineModel pmm = new PetMedicineModel();
                PetToyModel ptm = new PetToyModel();
                PetAccessoryModel pam = new PetAccessoryModel();
                int d = 0;
                while (d != list.Count())
                {
                    var bd = list.ToList()[d];
                    if (bd.p_id != null)
                    {
                        var p = pm.getPet(bd.p_id);
                        var qty = list.Where(x => x.p_id == bd.p_id).Count();
                        dt.Rows.Add(p.p_name, p.p_salePrice, qty);
                        d += qty;
                    }
                    else if (bd.pt_id != null)
                    {
                        var pt = ptm.getPetToy(bd.pt_id);
                        var qty = list.Where(x => x.pt_id == bd.pt_id).Count();
                        dt.Rows.Add(pt.pt_name, pt.pt_salePrice, qty);
                        d += qty;
                    }
                    else if (bd.pf_id != null)
                    {
                        var pf = pfm.getPetFood(bd.pf_id);
                        var qty = list.Where(x => x.pf_id == bd.pf_id).Count();
                        dt.Rows.Add(pf.pf_name, pf.pf_salePrice, qty);
                        d += qty;
                    }
                    else if (bd.pm_id != null)
                    {
                        var pmd = pmm.getPetMedicine(bd.pm_id);
                        var qty = list.Where(x => x.pm_id == bd.pm_id).Count();
                        dt.Rows.Add(pmd.pm_name, pmd.pm_salePrice, qty);
                        d += qty;
                    }
                    else if (bd.pa_id != null)
                    {
                        var pa = pam.getPetAccessory(bd.pa_id);
                        var qty = list.Where(x => x.pa_id == bd.pa_id).Count();
                        dt.Rows.Add(pa.pa_name, pa.pa_salePrice, qty);
                        d += qty;
                    }
                }
            }
            DetailBill dbf = new DetailBill();
            dbf.grvDetail.DataSource = dt;
            dbf.ShowDialog(this);
        }
    }
}