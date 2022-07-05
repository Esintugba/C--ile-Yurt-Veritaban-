namespace YurtKayıtSistemi
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.AdminAd = new System.Windows.Forms.Label();
            this.ogrenciTableAdapter1 = new YurtKayıtSistemi.YurtOtomasyonuDataSet1TableAdapters.OgrenciTableAdapter();
            this.AdminSifre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textAdminAd = new System.Windows.Forms.TextBox();
            this.textAdminSifre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminAd
            // 
            this.AdminAd.AutoSize = true;
            this.AdminAd.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminAd.Location = new System.Drawing.Point(40, 127);
            this.AdminAd.Name = "AdminAd";
            this.AdminAd.Size = new System.Drawing.Size(125, 18);
            this.AdminAd.TabIndex = 6;
            this.AdminAd.Text = "Kullanıcı Adı:";
            // 
            // ogrenciTableAdapter1
            // 
            this.ogrenciTableAdapter1.ClearBeforeFill = true;
            // 
            // AdminSifre
            // 
            this.AdminSifre.AutoSize = true;
            this.AdminSifre.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminSifre.Location = new System.Drawing.Point(111, 162);
            this.AdminSifre.Name = "AdminSifre";
            this.AdminSifre.Size = new System.Drawing.Size(54, 18);
            this.AdminSifre.TabIndex = 8;
            this.AdminSifre.Text = "Şifre:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(265, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Öğrenci Yurt Kayıt Sistemi";
            // 
            // textAdminAd
            // 
            this.textAdminAd.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAdminAd.Location = new System.Drawing.Point(171, 119);
            this.textAdminAd.Name = "textAdminAd";
            this.textAdminAd.Size = new System.Drawing.Size(204, 26);
            this.textAdminAd.TabIndex = 12;
            // 
            // textAdminSifre
            // 
            this.textAdminSifre.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAdminSifre.Location = new System.Drawing.Point(171, 154);
            this.textAdminSifre.Name = "textAdminSifre";
            this.textAdminSifre.Size = new System.Drawing.Size(204, 26);
            this.textAdminSifre.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 66);
            this.panel1.TabIndex = 14;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(444, 301);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textAdminSifre);
            this.Controls.Add(this.textAdminAd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AdminSifre);
            this.Controls.Add(this.AdminAd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.Text = "Yönetici Giriş Ekranı";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AdminAd;
        private YurtOtomasyonuDataSet1TableAdapters.OgrenciTableAdapter ogrenciTableAdapter1;
        private System.Windows.Forms.Label AdminSifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAdminAd;
        private System.Windows.Forms.TextBox textAdminSifre;
        private System.Windows.Forms.Panel panel1;
    }
}