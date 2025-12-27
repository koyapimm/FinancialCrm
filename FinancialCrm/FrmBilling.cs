using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string Title = txtBillTitle.Text;
            decimal Amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;

            Bills bill = new Bills();
            bill.BillTitle = Title;
            bill.BillAmount = Amount;
            bill.BillPeriod = period;
            db.Bills.Add(bill);
            db.SaveChanges();
            MessageBox.Show("Fatura Oluşturuldu");
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBillId.Text);
            var bill = db.Bills.Find(id);
            db.Bills.Remove(bill);
            db.SaveChanges();
            MessageBox.Show("Fatura Silindi");
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBillId.Text);
            var bill = db.Bills.Find(id);
            bill.BillTitle = txtBillTitle.Text;
            bill.BillAmount = decimal.Parse(txtBillAmount.Text);
            bill.BillPeriod = txtBillPeriod.Text;
            db.SaveChanges();
            MessageBox.Show("Fatura Güncellendi");
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnBillings_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnBankProcesses_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frm = new FrmBankProcesses();
            frm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }
    }
}
