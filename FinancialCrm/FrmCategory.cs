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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text;
            

            Categories categories = new Categories();
            categories.CategoryName = name;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Sisteme Eklendi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var removeValue = db.Categories.Find(id);
            db.Categories.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Silindi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text;
            int id = int.Parse(txtCategoryId.Text);

            var values = db.Categories.Find(id);


            values.CategoryName = name;
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Güncellendi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.Categories.ToList();
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


        private void btnBanksForm_Click(object sender, EventArgs e) => OpenForm(new FrmBanks());

        private void btnFaturaForm_Click(object sender, EventArgs e) => OpenForm(new FrmBilling());

        private void btnGiderForm_Click(object sender, EventArgs e) => OpenForm(new FrmSpending());

        private void btnBankaHareketleri_Click(object sender, EventArgs e) => OpenForm(new FrmBankProcesses());

        private void btnDashboard_Click(object sender, EventArgs e) => OpenForm(new FrmDashboard());

        private void btnSettings_Click(object sender, EventArgs e) => OpenForm(new FrmSettings());
    }
}
