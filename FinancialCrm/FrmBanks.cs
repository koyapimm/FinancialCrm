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
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //BANKA BAKİYELERİ
            var ziraatBankBalance =db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(b => b.BankBalance).FirstOrDefault();
            var vakifbankBalance = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(b => b.BankBalance).FirstOrDefault();
            var isbankasiBalance = db.Banks.Where(x => x.BankTitle == "İşbank").Select(b => b.BankBalance).FirstOrDefault();

            lblIsBankBalance.Text = isbankasiBalance.ToString() + " ₺";
            lblVakifbankBalance.Text = vakifbankBalance.ToString() + " ₺";
            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + " ₺";

            //SON 5 HAREKET
            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + " - " + bankProcess1.Amount + " - " + bankProcess1.ProcessDate;
            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Skip(1).Take(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " - " + bankProcess2.Amount + " - " + bankProcess2.ProcessDate;
            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Skip(2).Take(1).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " - " + bankProcess3.Amount + " - " + bankProcess3.ProcessDate;
            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Skip(3).Take(1).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " - " + bankProcess4.Amount + " - " + bankProcess4.ProcessDate;
            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Skip(4).Take(1).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " - " + bankProcess5.Amount + " - " + bankProcess5.ProcessDate;
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
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
