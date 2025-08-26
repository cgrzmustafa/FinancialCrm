namespace FinancialCrm
{
    partial class FrmSpending
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBankaHareketleri = new System.Windows.Forms.Button();
            this.btnGiderForm = new System.Windows.Forms.Button();
            this.btnFaturaForm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategoryForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSpendingDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSpendingAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateSpending = new System.Windows.Forms.Button();
            this.btnRemoveSpending = new System.Windows.Forms.Button();
            this.btnCreateSpending = new System.Windows.Forms.Button();
            this.btnSpendingList = new System.Windows.Forms.Button();
            this.txtSpendingName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpendingId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnOut);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnBankaHareketleri);
            this.panel1.Controls.Add(this.btnGiderForm);
            this.panel1.Controls.Add(this.btnFaturaForm);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnCategoryForm);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 610);
            this.panel1.TabIndex = 3;
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOut.ForeColor = System.Drawing.Color.White;
            this.btnOut.Location = new System.Drawing.Point(25, 366);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(170, 42);
            this.btnOut.TabIndex = 3;
            this.btnOut.Text = "Çıkış Yap";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(25, 318);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(170, 42);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(25, 270);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(170, 42);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnBankaHareketleri
            // 
            this.btnBankaHareketleri.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBankaHareketleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankaHareketleri.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankaHareketleri.ForeColor = System.Drawing.Color.White;
            this.btnBankaHareketleri.Location = new System.Drawing.Point(25, 222);
            this.btnBankaHareketleri.Name = "btnBankaHareketleri";
            this.btnBankaHareketleri.Size = new System.Drawing.Size(170, 42);
            this.btnBankaHareketleri.TabIndex = 2;
            this.btnBankaHareketleri.Text = "Banka Hareketleri";
            this.btnBankaHareketleri.UseVisualStyleBackColor = false;
            this.btnBankaHareketleri.Click += new System.EventHandler(this.btnBankaHareketleri_Click);
            // 
            // btnGiderForm
            // 
            this.btnGiderForm.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGiderForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiderForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiderForm.ForeColor = System.Drawing.Color.White;
            this.btnGiderForm.Location = new System.Drawing.Point(25, 174);
            this.btnGiderForm.Name = "btnGiderForm";
            this.btnGiderForm.Size = new System.Drawing.Size(170, 42);
            this.btnGiderForm.TabIndex = 2;
            this.btnGiderForm.Text = "Giderler";
            this.btnGiderForm.UseVisualStyleBackColor = false;
            // 
            // btnFaturaForm
            // 
            this.btnFaturaForm.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnFaturaForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturaForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaturaForm.ForeColor = System.Drawing.Color.White;
            this.btnFaturaForm.Location = new System.Drawing.Point(25, 126);
            this.btnFaturaForm.Name = "btnFaturaForm";
            this.btnFaturaForm.Size = new System.Drawing.Size(170, 42);
            this.btnFaturaForm.TabIndex = 2;
            this.btnFaturaForm.Text = "Faturalar";
            this.btnFaturaForm.UseVisualStyleBackColor = false;
            this.btnFaturaForm.Click += new System.EventHandler(this.btnFaturaForm_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.White;
            this.btnBanksForm.Location = new System.Drawing.Point(25, 78);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(170, 42);
            this.btnBanksForm.TabIndex = 2;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = false;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // btnCategoryForm
            // 
            this.btnCategoryForm.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCategoryForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryForm.ForeColor = System.Drawing.Color.White;
            this.btnCategoryForm.Location = new System.Drawing.Point(25, 30);
            this.btnCategoryForm.Name = "btnCategoryForm";
            this.btnCategoryForm.Size = new System.Drawing.Size(170, 42);
            this.btnCategoryForm.TabIndex = 1;
            this.btnCategoryForm.Text = "Kategoriler";
            this.btnCategoryForm.UseVisualStyleBackColor = false;
            this.btnCategoryForm.Click += new System.EventHandler(this.btnCategoryForm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCategoryId);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtSpendingDate);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSpendingAmount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnUpdateSpending);
            this.panel2.Controls.Add(this.btnRemoveSpending);
            this.panel2.Controls.Add(this.btnCreateSpending);
            this.panel2.Controls.Add(this.btnSpendingList);
            this.panel2.Controls.Add(this.txtSpendingName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSpendingId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(211, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 371);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.BackColor = System.Drawing.Color.Khaki;
            this.txtCategoryId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategoryId.Location = new System.Drawing.Point(118, 228);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(885, 32);
            this.txtCategoryId.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(2, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kategori Id:";
            // 
            // txtSpendingDate
            // 
            this.txtSpendingDate.BackColor = System.Drawing.Color.Khaki;
            this.txtSpendingDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingDate.Location = new System.Drawing.Point(118, 174);
            this.txtSpendingDate.Name = "txtSpendingDate";
            this.txtSpendingDate.Size = new System.Drawing.Size(885, 32);
            this.txtSpendingDate.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(31, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Zamanı:";
            // 
            // txtSpendingAmount
            // 
            this.txtSpendingAmount.BackColor = System.Drawing.Color.Khaki;
            this.txtSpendingAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingAmount.Location = new System.Drawing.Point(118, 126);
            this.txtSpendingAmount.Name = "txtSpendingAmount";
            this.txtSpendingAmount.Size = new System.Drawing.Size(885, 32);
            this.txtSpendingAmount.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Miktarı:";
            // 
            // btnUpdateSpending
            // 
            this.btnUpdateSpending.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdateSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSpending.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateSpending.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateSpending.Location = new System.Drawing.Point(802, 305);
            this.btnUpdateSpending.Name = "btnUpdateSpending";
            this.btnUpdateSpending.Size = new System.Drawing.Size(184, 42);
            this.btnUpdateSpending.TabIndex = 10;
            this.btnUpdateSpending.Text = "Gider Güncelle";
            this.btnUpdateSpending.UseVisualStyleBackColor = false;
            this.btnUpdateSpending.Click += new System.EventHandler(this.btnUpdateSpending_Click);
            // 
            // btnRemoveSpending
            // 
            this.btnRemoveSpending.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRemoveSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSpending.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveSpending.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveSpending.Location = new System.Drawing.Point(586, 305);
            this.btnRemoveSpending.Name = "btnRemoveSpending";
            this.btnRemoveSpending.Size = new System.Drawing.Size(172, 42);
            this.btnRemoveSpending.TabIndex = 9;
            this.btnRemoveSpending.Text = "Gider Sil";
            this.btnRemoveSpending.UseVisualStyleBackColor = false;
            this.btnRemoveSpending.Click += new System.EventHandler(this.btnRemoveSpending_Click);
            // 
            // btnCreateSpending
            // 
            this.btnCreateSpending.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCreateSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateSpending.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateSpending.ForeColor = System.Drawing.Color.Black;
            this.btnCreateSpending.Location = new System.Drawing.Point(351, 305);
            this.btnCreateSpending.Name = "btnCreateSpending";
            this.btnCreateSpending.Size = new System.Drawing.Size(168, 42);
            this.btnCreateSpending.TabIndex = 8;
            this.btnCreateSpending.Text = "Yeni Gider";
            this.btnCreateSpending.UseVisualStyleBackColor = false;
            this.btnCreateSpending.Click += new System.EventHandler(this.btnCreateSpending_Click);
            // 
            // btnSpendingList
            // 
            this.btnSpendingList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSpendingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendingList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingList.ForeColor = System.Drawing.Color.Black;
            this.btnSpendingList.Location = new System.Drawing.Point(118, 305);
            this.btnSpendingList.Name = "btnSpendingList";
            this.btnSpendingList.Size = new System.Drawing.Size(176, 42);
            this.btnSpendingList.TabIndex = 4;
            this.btnSpendingList.Text = "Gider Listesi";
            this.btnSpendingList.UseVisualStyleBackColor = false;
            this.btnSpendingList.Click += new System.EventHandler(this.btnCategoryList_Click);
            // 
            // txtSpendingName
            // 
            this.txtSpendingName.BackColor = System.Drawing.Color.Khaki;
            this.txtSpendingName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingName.Location = new System.Drawing.Point(118, 75);
            this.txtSpendingName.Name = "txtSpendingName";
            this.txtSpendingName.Size = new System.Drawing.Size(885, 32);
            this.txtSpendingName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gider Adı:";
            // 
            // txtSpendingId
            // 
            this.txtSpendingId.BackColor = System.Drawing.Color.Khaki;
            this.txtSpendingId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingId.Location = new System.Drawing.Point(118, 18);
            this.txtSpendingId.Name = "txtSpendingId";
            this.txtSpendingId.Size = new System.Drawing.Size(885, 32);
            this.txtSpendingId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gider Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(211, 367);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 252);
            this.dataGridView1.TabIndex = 5;
            // 
            // FrmSpending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1234, 612);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSpending";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gider Formu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBankaHareketleri;
        private System.Windows.Forms.Button btnGiderForm;
        private System.Windows.Forms.Button btnFaturaForm;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategoryForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdateSpending;
        private System.Windows.Forms.Button btnRemoveSpending;
        private System.Windows.Forms.Button btnCreateSpending;
        private System.Windows.Forms.Button btnSpendingList;
        private System.Windows.Forms.TextBox txtSpendingName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpendingId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSpendingDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSpendingAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}