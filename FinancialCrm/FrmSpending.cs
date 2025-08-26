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
    public partial class FrmSpending : Form
    {
        public FrmSpending()
        {
            InitializeComponent();
        }
        
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            var values = db.Spendings
    .Select(x => new
    {
        x.SpendingId,
        x.SpendingTitle,
        x.SpendingAmount,
        x.SpendingDate,
        CategoryName = x.Categories.CategoryName
    })
    .ToList();

            dataGridView1.DataSource = values;

        }

        private void btnCreateSpending_Click(object sender, EventArgs e)
        {
            string title = txtSpendingName.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            DateTime date = DateTime.Parse(txtSpendingDate.Text);
            int categoryId = int.Parse(txtCategoryId.Text);

            Spendings spendings = new Spendings();
            spendings.SpendingTitle = title;
            spendings.SpendingAmount = amount;
            spendings.SpendingDate = date;
            spendings.CategoryId = categoryId;
            db.Spendings.Add(spendings);
            db.SaveChanges();
            MessageBox.Show("Gider Başarılı Bir Şekilde Sisteme Eklendi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnRemoveSpending_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            var removeValue = db.Spendings.Find(id);
            db.Spendings.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Gider Başarılı Bir Şekilde Silindi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateSpending_Click(object sender, EventArgs e)
        {
            string title = txtSpendingName.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            DateTime date = DateTime.Parse(txtSpendingDate.Text);
            int categoryId = int.Parse(txtCategoryId.Text);

            int id = int.Parse(txtSpendingId.Text);

            var values = db.Spendings.Find(id);


            values.SpendingTitle = title;
            values.SpendingAmount = amount;
            values.SpendingDate = date;
            values.CategoryId = categoryId;
            db.SaveChanges();
            MessageBox.Show("Gider Başarılı Bir Şekilde Güncellendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.Spendings.ToList();
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

        private void btnBankaHareketleri_Click(object sender, EventArgs e) => OpenForm(new FrmBankProcesses());

        private void btnDashboard_Click(object sender, EventArgs e) => OpenForm(new FrmDashboard());

        private void btnSettings_Click(object sender, EventArgs e) => OpenForm(new FrmSettings());
    }
}
