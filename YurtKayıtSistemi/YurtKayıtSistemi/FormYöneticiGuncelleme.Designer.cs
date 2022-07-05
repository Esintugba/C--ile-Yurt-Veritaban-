namespace YurtKayıtSistemi
{
    partial class FormYöneticiDuzenle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYöneticiDuzenle));
            this.textYoneticiİD = new System.Windows.Forms.TextBox();
            this.YoneticiİD = new System.Windows.Forms.Label();
            this.textKullanıcıAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textYöneticiSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonYöneticiKaydet = new System.Windows.Forms.Button();
            this.buttonYöneticiSil = new System.Windows.Forms.Button();
            this.buttonYöneticiGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yoneticiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet7 = new YurtKayıtSistemi.YurtOtomasyonuDataSet7();
            this.adminTableAdapter = new YurtKayıtSistemi.YurtOtomasyonuDataSet7TableAdapters.AdminTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // textYoneticiİD
            // 
            this.textYoneticiİD.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textYoneticiİD.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textYoneticiİD.Location = new System.Drawing.Point(155, 12);
            this.textYoneticiİD.Name = "textYoneticiİD";
            this.textYoneticiİD.Size = new System.Drawing.Size(237, 26);
            this.textYoneticiİD.TabIndex = 3;
            // 
            // YoneticiİD
            // 
            this.YoneticiİD.AutoSize = true;
            this.YoneticiİD.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YoneticiİD.Location = new System.Drawing.Point(32, 20);
            this.YoneticiİD.Name = "YoneticiİD";
            this.YoneticiİD.Size = new System.Drawing.Size(108, 18);
            this.YoneticiİD.TabIndex = 2;
            this.YoneticiİD.Text = "Yönetici İD:";
            // 
            // textKullanıcıAd
            // 
            this.textKullanıcıAd.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textKullanıcıAd.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKullanıcıAd.Location = new System.Drawing.Point(155, 62);
            this.textKullanıcıAd.Name = "textKullanıcıAd";
            this.textKullanıcıAd.Size = new System.Drawing.Size(237, 26);
            this.textKullanıcıAd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // textYöneticiSifre
            // 
            this.textYöneticiSifre.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textYöneticiSifre.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textYöneticiSifre.Location = new System.Drawing.Point(155, 110);
            this.textYöneticiSifre.Name = "textYöneticiSifre";
            this.textYöneticiSifre.Size = new System.Drawing.Size(237, 26);
            this.textYöneticiSifre.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(95, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre:";
            // 
            // buttonYöneticiKaydet
            // 
            this.buttonYöneticiKaydet.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYöneticiKaydet.Location = new System.Drawing.Point(65, 155);
            this.buttonYöneticiKaydet.Name = "buttonYöneticiKaydet";
            this.buttonYöneticiKaydet.Size = new System.Drawing.Size(105, 32);
            this.buttonYöneticiKaydet.TabIndex = 8;
            this.buttonYöneticiKaydet.Text = "Kaydet";
            this.buttonYöneticiKaydet.UseVisualStyleBackColor = true;
            this.buttonYöneticiKaydet.Click += new System.EventHandler(this.buttonYöneticiKaydet_Click);
            // 
            // buttonYöneticiSil
            // 
            this.buttonYöneticiSil.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYöneticiSil.Location = new System.Drawing.Point(176, 155);
            this.buttonYöneticiSil.Name = "buttonYöneticiSil";
            this.buttonYöneticiSil.Size = new System.Drawing.Size(105, 32);
            this.buttonYöneticiSil.TabIndex = 9;
            this.buttonYöneticiSil.Text = "Sil";
            this.buttonYöneticiSil.UseVisualStyleBackColor = true;
            this.buttonYöneticiSil.Click += new System.EventHandler(this.buttonYöneticiSil_Click);
            // 
            // buttonYöneticiGuncelle
            // 
            this.buttonYöneticiGuncelle.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYöneticiGuncelle.Location = new System.Drawing.Point(287, 155);
            this.buttonYöneticiGuncelle.Name = "buttonYöneticiGuncelle";
            this.buttonYöneticiGuncelle.Size = new System.Drawing.Size(105, 32);
            this.buttonYöneticiGuncelle.TabIndex = 10;
            this.buttonYöneticiGuncelle.Text = "Güncelle";
            this.buttonYöneticiGuncelle.UseVisualStyleBackColor = true;
            this.buttonYöneticiGuncelle.Click += new System.EventHandler(this.buttonYöneticiGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yoneticiidDataGridViewTextBoxColumn,
            this.yoneticiAdDataGridViewTextBoxColumn,
            this.yoneticiSifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adminBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 176);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // yoneticiidDataGridViewTextBoxColumn
            // 
            this.yoneticiidDataGridViewTextBoxColumn.DataPropertyName = "Yoneticiid";
            this.yoneticiidDataGridViewTextBoxColumn.HeaderText = "Yoneticiid";
            this.yoneticiidDataGridViewTextBoxColumn.Name = "yoneticiidDataGridViewTextBoxColumn";
            this.yoneticiidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yoneticiAdDataGridViewTextBoxColumn
            // 
            this.yoneticiAdDataGridViewTextBoxColumn.DataPropertyName = "YoneticiAd";
            this.yoneticiAdDataGridViewTextBoxColumn.HeaderText = "YoneticiAd";
            this.yoneticiAdDataGridViewTextBoxColumn.Name = "yoneticiAdDataGridViewTextBoxColumn";
            // 
            // yoneticiSifreDataGridViewTextBoxColumn
            // 
            this.yoneticiSifreDataGridViewTextBoxColumn.DataPropertyName = "YoneticiSifre";
            this.yoneticiSifreDataGridViewTextBoxColumn.HeaderText = "YoneticiSifre";
            this.yoneticiSifreDataGridViewTextBoxColumn.Name = "yoneticiSifreDataGridViewTextBoxColumn";
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.yurtOtomasyonuDataSet7;
            // 
            // yurtOtomasyonuDataSet7
            // 
            this.yurtOtomasyonuDataSet7.DataSetName = "YurtOtomasyonuDataSet7";
            this.yurtOtomasyonuDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // FormYöneticiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(425, 397);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonYöneticiGuncelle);
            this.Controls.Add(this.buttonYöneticiSil);
            this.Controls.Add(this.buttonYöneticiKaydet);
            this.Controls.Add(this.textYöneticiSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textKullanıcıAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textYoneticiİD);
            this.Controls.Add(this.YoneticiİD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormYöneticiDuzenle";
            this.Text = "Yönetici İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textYoneticiİD;
        private System.Windows.Forms.Label YoneticiİD;
        private System.Windows.Forms.TextBox textKullanıcıAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textYöneticiSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonYöneticiKaydet;
        private System.Windows.Forms.Button buttonYöneticiSil;
        private System.Windows.Forms.Button buttonYöneticiGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet7 yurtOtomasyonuDataSet7;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private YurtOtomasyonuDataSet7TableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiSifreDataGridViewTextBoxColumn;
    }
}