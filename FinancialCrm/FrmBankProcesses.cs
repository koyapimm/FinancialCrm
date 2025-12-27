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
    public partial class FrmBankProcesses : Form
    {
        public FrmBankProcesses()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnBills_Click(object sender, EventArgs e)
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

        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            var bankProcess = db.BankProcesses.ToList();
            dataGridView1.DataSource = bankProcess;
            //bankid kolonunu kaldırıp banka adını göstermek için combobox kolonu ekliyoruz
            // kaldır
            dataGridView1.Columns.Remove("BankId");
            dataGridView1.Columns.Remove("Banks");
            //ekle
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "Banka Adı";
            cmb.DataSource = db.Banks.ToList();
            cmb.DisplayMember = "BankTitle";
            cmb.ValueMember = "BankId";
            cmb.DataPropertyName = "BankId";
            dataGridView1.Columns.Add(cmb);

            //ziraat bankası son işlem tutarı
            lblZiraatLastProcess.Text = db.BankProcesses.Where(x => x.Banks.BankTitle == "Ziraat Bankası").OrderByDescending(y => y.BankProcessId).Select(z => z.Amount).FirstOrDefault().ToString() + " ₺";
            //iş bankası son işlem tutarı
            lblIsBankasiLastProcess.Text = db.BankProcesses.Where(x => x.Banks.BankTitle == "İşbank").OrderByDescending(y => y.BankProcessId).Select(z => z.Amount).FirstOrDefault().ToString() + " ₺";
            //vakifbank son işlem tutarı
            lblVakifbankLastProcess.Text = db.BankProcesses.Where(x => x.Banks.BankTitle == "Vakıfbank").OrderByDescending(y => y.BankProcessId).Select(z => z.Amount).FirstOrDefault().ToString() + " ₺";


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }
    }
}
