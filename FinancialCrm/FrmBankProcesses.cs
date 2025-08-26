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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBankProcessList_Click(object sender, EventArgs e)
        {
            var values = db.BankProcesses
    .Select(x => new
    {
        x.BankProcessId,
        x.Description,
        x.ProcessDate,
        x.ProcessType,
        x.Amount,
        x.BankId,
        BankTitle = x.Banks.BankTitle
    })
    .ToList();

            dataGridView1.DataSource = values;
        }

        private void btnCreateBankProcess_Click(object sender, EventArgs e)
        {
            string description = txtBankProcessDescription.Text;
            DateTime date = DateTime.Parse(txtBankProcessDate.Text);
            string type = txtBankProcessType.Text;
            decimal amount = decimal.Parse(txtBankProcessAmount.Text);
            int bankId = int.Parse(txtBankId.Text);

            BankProcesses bankProcesses = new BankProcesses();
            bankProcesses.Description = description;
            bankProcesses.ProcessDate = date;
            bankProcesses.ProcessType = type;
            bankProcesses.Amount = amount;
            bankProcesses.BankId = bankId;
            db.BankProcesses.Add(bankProcesses);
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı Bir Şekilde Sisteme Eklendi", "Banka İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnRemoveBankProcess_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBankProcessId.Text);
            var removeValue = db.BankProcesses.Find(id);
            db.BankProcesses.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı Bir Şekilde Silindi", "Banka İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateBankProcess_Click(object sender, EventArgs e)
        {
            string description = txtBankProcessDescription.Text;
            DateTime date = DateTime.Parse(txtBankProcessDate.Text);
            string type = txtBankProcessType.Text;
            decimal amount = decimal.Parse(txtBankProcessAmount.Text);
            int bankId = int.Parse(txtBankId.Text);

            int id = int.Parse(txtBankProcessId.Text);

            var values = db.BankProcesses.Find(id);


            values.Description = description;
            values.ProcessDate = date;
            values.ProcessType = type;
            values.Amount = amount;
            values.BankId = bankId;
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı Bir Şekilde Güncellendi", "İşlemler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.BankProcesses.ToList();
            dataGridView1.DataSource = values2;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            
            var result = MessageBox.Show("Uygulamadan çıkmak istediğinizden emin misiniz?",
                                         "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void OpenForm(Form frm)
        {
            frm.Show();
            this.Hide();
        }

        private void btnCategoryForm_Click(object sender, EventArgs e) => OpenForm(new FrmCategory());

        private void btnBanksForm_Click(object sender, EventArgs e) => OpenForm(new FrmBanks());

        private void btnFaturaForm_Click(object sender, EventArgs e) => OpenForm(new FrmBilling());

        private void btnGiderForm_Click(object sender, EventArgs e) => OpenForm(new FrmSpending());

        private void btnDashboard_Click(object sender, EventArgs e) => OpenForm(new FrmDashboard());

        private void btnSettings_Click(object sender, EventArgs e) => OpenForm(new FrmSettings());


    }
}
