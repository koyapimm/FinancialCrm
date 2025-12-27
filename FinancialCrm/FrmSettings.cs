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
    public partial class FrmSettings : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling frmBills = new FrmBilling();
            frmBills.Show();
            this.Hide();
        }

        private void btnBankProcesses_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frmBankProcesses = new FrmBankProcesses();
            frmBankProcesses.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            var oldPassword = txtOldPassword.Text;
            var newPassword = txtNewPassword.Text;
            var newPasswordRepeat = txtNewPasswordRepeat.Text;
            //sadece admin kullanıcı adlı kişinin şifresini değiştireceğiz
            var adminUser = db.Users.FirstOrDefault(u => u.Username == "admin");
            if (adminUser != null) {
                if (adminUser.Password == oldPassword)
                {
                    if (newPassword == newPasswordRepeat)
                    {
                        adminUser.Password = newPassword;
                        db.SaveChanges();
                        MessageBox.Show("Password updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("New passwords do not match.");
                    }
                }
                else
                {
                    MessageBox.Show("Old password is incorrect.");
                }
            }
            else
            {
                MessageBox.Show("Admin user not found.");
            }
        }


    }
}
