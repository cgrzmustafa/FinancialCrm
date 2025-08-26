using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "Dark")
                radioButtonDark.Checked = true;
            else
                radioButtonLight.Checked = true;

            ApplyTheme();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (radioButtonDark.Checked)
                Properties.Settings.Default.Theme = "Dark";
            else
                Properties.Settings.Default.Theme = "Light";

            Properties.Settings.Default.Save();
            ApplyTheme();
            MessageBox.Show("Tema ayarı kaydedildi. Uygulamayı yeniden başlatın.",
                "Tema Ayarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ApplyTheme()
        {
            if (Properties.Settings.Default.Theme == "Dark")
            {
                this.BackColor = Color.FromArgb(45, 45, 48); 
                foreach (Control ctrl in this.Controls)
                {
                    ctrl.ForeColor = Color.White;
                    if (ctrl is Button || ctrl is GroupBox)
                        ctrl.BackColor = Color.Gray;
                }
            }
            else 
            {
                this.BackColor = Color.Gray;
                foreach (Control ctrl in this.Controls)
                {
                    ctrl.ForeColor = Color.Black;
                    if (ctrl is Button || ctrl is GroupBox)
                        ctrl.BackColor = Color.LightGray;
                }
            }
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

        private void btnBankaHareketleri_Click(object sender, EventArgs e) => OpenForm(new FrmBankProcesses());

        private void btnDashboard_Click(object sender, EventArgs e) => OpenForm(new FrmDashboard());
    }
}
