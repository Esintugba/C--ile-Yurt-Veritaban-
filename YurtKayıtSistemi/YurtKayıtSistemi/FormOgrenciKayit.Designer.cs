namespace YurtKayıtSistemi
{
    partial class FormOgrenciKayit
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOgrenciKayit));
            this.ogrAd = new System.Windows.Forms.Label();
            this.textBoxOgrAd = new System.Windows.Forms.TextBox();
            this.ogrSoyad = new System.Windows.Forms.Label();
            this.textBoxOgrSoyad = new System.Windows.Forms.TextBox();
            this.OgrTc = new System.Windows.Forms.Label();
            this.ogrtelefon = new System.Windows.Forms.Label();
            this.ogrDogum = new System.Windows.Forms.Label();
            this.ogrMail = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxOgrMail = new System.Windows.Forms.TextBox();
            this.ogrBolum = new System.Windows.Forms.Label();
            this.ogrOdaNo = new System.Windows.Forms.Label();
            this.veliAd = new System.Windows.Forms.Label();
            this.veliTelefon = new System.Windows.Forms.Label();
            this.veliAdres = new System.Windows.Forms.Label();
            this.maskedOgrTc = new System.Windows.Forms.MaskedTextBox();
            this.maskedOgrTelefon = new System.Windows.Forms.MaskedTextBox();
            this.maskedOgrDogum = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxOgrBolum = new System.Windows.Forms.ComboBox();
            this.comboBoxOgrOdaNo = new System.Windows.Forms.ComboBox();
            this.maskedVeliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.textBoxVeliAd = new System.Windows.Forms.TextBox();
            this.richVeliAdres = new System.Windows.Forms.RichTextBox();
            this.kayıt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ogrAd
            // 
            this.ogrAd.AutoSize = true;
            this.ogrAd.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrAd.Location = new System.Drawing.Point(198, 52);
            this.ogrAd.Name = "ogrAd";
            this.ogrAd.Size = new System.Drawing.Size(43, 18);
            this.ogrAd.TabIndex = 0;
            this.ogrAd.Text = "Adı:";
            // 
            // textBoxOgrAd
            // 
            this.textBoxOgrAd.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxOgrAd.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOgrAd.Location = new System.Drawing.Point(258, 49);
            this.textBoxOgrAd.Name = "textBoxOgrAd";
            this.textBoxOgrAd.Size = new System.Drawing.Size(251, 26);
            this.textBoxOgrAd.TabIndex = 1;
            // 
            // ogrSoyad
            // 
            this.ogrSoyad.AutoSize = true;
            this.ogrSoyad.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrSoyad.Location = new System.Drawing.Point(167, 84);
            this.ogrSoyad.Name = "ogrSoyad";
            this.ogrSoyad.Size = new System.Drawing.Size(74, 18);
            this.ogrSoyad.TabIndex = 2;
            this.ogrSoyad.Text = "Soyadı:";
            this.ogrSoyad.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxOgrSoyad
            // 
            this.textBoxOgrSoyad.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxOgrSoyad.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOgrSoyad.Location = new System.Drawing.Point(258, 81);
            this.textBoxOgrSoyad.Name = "textBoxOgrSoyad";
            this.textBoxOgrSoyad.Size = new System.Drawing.Size(251, 26);
            this.textBoxOgrSoyad.TabIndex = 3;
            // 
            // OgrTc
            // 
            this.OgrTc.AutoSize = true;
            this.OgrTc.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrTc.Location = new System.Drawing.Point(198, 17);
            this.OgrTc.Name = "OgrTc";
            this.OgrTc.Size = new System.Drawing.Size(42, 18);
            this.OgrTc.TabIndex = 4;
            this.OgrTc.Text = "T.C:";
            // 
            // ogrtelefon
            // 
            this.ogrtelefon.AutoSize = true;
            this.ogrtelefon.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrtelefon.Location = new System.Drawing.Point(76, 119);
            this.ogrtelefon.Name = "ogrtelefon";
            this.ogrtelefon.Size = new System.Drawing.Size(165, 18);
            this.ogrtelefon.TabIndex = 6;
            this.ogrtelefon.Text = "Telefon Numarası:";
            this.ogrtelefon.Click += new System.EventHandler(this.label4_Click);
            // 
            // ogrDogum
            // 
            this.ogrDogum.AutoSize = true;
            this.ogrDogum.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrDogum.Location = new System.Drawing.Point(109, 152);
            this.ogrDogum.Name = "ogrDogum";
            this.ogrDogum.Size = new System.Drawing.Size(131, 18);
            this.ogrDogum.TabIndex = 8;
            this.ogrDogum.Text = "Doğum Tarihi:";
            this.ogrDogum.Click += new System.EventHandler(this.label5_Click);
            // 
            // ogrMail
            // 
            this.ogrMail.AutoSize = true;
            this.ogrMail.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrMail.Location = new System.Drawing.Point(183, 184);
            this.ogrMail.Name = "ogrMail";
            this.ogrMail.Size = new System.Drawing.Size(57, 18);
            this.ogrMail.TabIndex = 10;
            this.ogrMail.Text = "Mail :";
            this.ogrMail.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(184, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 18);
            this.label7.TabIndex = 11;
            // 
            // textBoxOgrMail
            // 
            this.textBoxOgrMail.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxOgrMail.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOgrMail.Location = new System.Drawing.Point(258, 181);
            this.textBoxOgrMail.Name = "textBoxOgrMail";
            this.textBoxOgrMail.Size = new System.Drawing.Size(251, 26);
            this.textBoxOgrMail.TabIndex = 12;
            // 
            // ogrBolum
            // 
            this.ogrBolum.AutoSize = true;
            this.ogrBolum.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrBolum.Location = new System.Drawing.Point(91, 219);
            this.ogrBolum.Name = "ogrBolum";
            this.ogrBolum.Size = new System.Drawing.Size(150, 18);
            this.ogrBolum.TabIndex = 13;
            this.ogrBolum.Text = "Okuduğu Bölüm:";
            // 
            // ogrOdaNo
            // 
            this.ogrOdaNo.AutoSize = true;
            this.ogrOdaNo.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrOdaNo.Location = new System.Drawing.Point(103, 255);
            this.ogrOdaNo.Name = "ogrOdaNo";
            this.ogrOdaNo.Size = new System.Drawing.Size(137, 18);
            this.ogrOdaNo.TabIndex = 14;
            this.ogrOdaNo.Text = "Oda Numarası:";
            this.ogrOdaNo.Click += new System.EventHandler(this.label9_Click);
            // 
            // veliAd
            // 
            this.veliAd.AutoSize = true;
            this.veliAd.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.veliAd.Location = new System.Drawing.Point(103, 291);
            this.veliAd.Name = "veliAd";
            this.veliAd.Size = new System.Drawing.Size(135, 18);
            this.veliAd.TabIndex = 15;
            this.veliAd.Text = "Veli Ad-Soyad:";
            // 
            // veliTelefon
            // 
            this.veliTelefon.AutoSize = true;
            this.veliTelefon.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.veliTelefon.Location = new System.Drawing.Point(71, 326);
            this.veliTelefon.Name = "veliTelefon";
            this.veliTelefon.Size = new System.Drawing.Size(167, 18);
            this.veliTelefon.TabIndex = 16;
            this.veliTelefon.Text = "Veli Tel.Numarası:";
            this.veliTelefon.Click += new System.EventHandler(this.label11_Click);
            // 
            // veliAdres
            // 
            this.veliAdres.AutoSize = true;
            this.veliAdres.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.veliAdres.Location = new System.Drawing.Point(139, 361);
            this.veliAdres.Name = "veliAdres";
            this.veliAdres.Size = new System.Drawing.Size(99, 18);
            this.veliAdres.TabIndex = 17;
            this.veliAdres.Text = "Veli Adres:";
            // 
            // maskedOgrTc
            // 
            this.maskedOgrTc.BackColor = System.Drawing.SystemColors.MenuBar;
            this.maskedOgrTc.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedOgrTc.Location = new System.Drawing.Point(258, 14);
            this.maskedOgrTc.Mask = "00000000000";
            this.maskedOgrTc.Name = "maskedOgrTc";
            this.maskedOgrTc.Size = new System.Drawing.Size(251, 26);
            this.maskedOgrTc.TabIndex = 18;
            this.maskedOgrTc.ValidatingType = typeof(int);
            // 
            // maskedOgrTelefon
            // 
            this.maskedOgrTelefon.BackColor = System.Drawing.SystemColors.MenuBar;
            this.maskedOgrTelefon.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedOgrTelefon.Location = new System.Drawing.Point(258, 116);
            this.maskedOgrTelefon.Mask = "(999) 000-0000";
            this.maskedOgrTelefon.Name = "maskedOgrTelefon";
            this.maskedOgrTelefon.Size = new System.Drawing.Size(251, 26);
            this.maskedOgrTelefon.TabIndex = 19;
            // 
            // maskedOgrDogum
            // 
            this.maskedOgrDogum.BackColor = System.Drawing.SystemColors.MenuBar;
            this.maskedOgrDogum.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedOgrDogum.Location = new System.Drawing.Point(258, 149);
            this.maskedOgrDogum.Mask = "00/00/0000";
            this.maskedOgrDogum.Name = "maskedOgrDogum";
            this.maskedOgrDogum.Size = new System.Drawing.Size(251, 26);
            this.maskedOgrDogum.TabIndex = 20;
            this.maskedOgrDogum.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxOgrBolum
            // 
            this.comboBoxOgrBolum.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBoxOgrBolum.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxOgrBolum.FormattingEnabled = true;
            this.comboBoxOgrBolum.Location = new System.Drawing.Point(258, 216);
            this.comboBoxOgrBolum.Name = "comboBoxOgrBolum";
            this.comboBoxOgrBolum.Size = new System.Drawing.Size(251, 26);
            this.comboBoxOgrBolum.TabIndex = 21;
            // 
            // comboBoxOgrOdaNo
            // 
            this.comboBoxOgrOdaNo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBoxOgrOdaNo.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxOgrOdaNo.FormattingEnabled = true;
            this.comboBoxOgrOdaNo.Location = new System.Drawing.Point(258, 252);
            this.comboBoxOgrOdaNo.Name = "comboBoxOgrOdaNo";
            this.comboBoxOgrOdaNo.Size = new System.Drawing.Size(251, 26);
            this.comboBoxOgrOdaNo.TabIndex = 22;
            // 
            // maskedVeliTelefon
            // 
            this.maskedVeliTelefon.BackColor = System.Drawing.SystemColors.MenuBar;
            this.maskedVeliTelefon.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedVeliTelefon.Location = new System.Drawing.Point(258, 326);
            this.maskedVeliTelefon.Mask = "(999) 000-0000";
            this.maskedVeliTelefon.Name = "maskedVeliTelefon";
            this.maskedVeliTelefon.Size = new System.Drawing.Size(251, 26);
            this.maskedVeliTelefon.TabIndex = 23;
            // 
            // textBoxVeliAd
            // 
            this.textBoxVeliAd.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxVeliAd.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxVeliAd.Location = new System.Drawing.Point(258, 288);
            this.textBoxVeliAd.Name = "textBoxVeliAd";
            this.textBoxVeliAd.Size = new System.Drawing.Size(251, 26);
            this.textBoxVeliAd.TabIndex = 24;
            // 
            // richVeliAdres
            // 
            this.richVeliAdres.BackColor = System.Drawing.SystemColors.MenuBar;
            this.richVeliAdres.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richVeliAdres.Location = new System.Drawing.Point(258, 362);
            this.richVeliAdres.Name = "richVeliAdres";
            this.richVeliAdres.Size = new System.Drawing.Size(251, 96);
            this.richVeliAdres.TabIndex = 25;
            this.richVeliAdres.Text = "";
            // 
            // kayıt
            // 
            this.kayıt.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıt.Location = new System.Drawing.Point(419, 480);
            this.kayıt.Name = "kayıt";
            this.kayıt.Size = new System.Drawing.Size(90, 32);
            this.kayıt.TabIndex = 26;
            this.kayıt.Text = "Kaydet";
            this.kayıt.UseVisualStyleBackColor = true;
            this.kayıt.Click += new System.EventHandler(this.kayıt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FormOgrenciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(594, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kayıt);
            this.Controls.Add(this.richVeliAdres);
            this.Controls.Add(this.textBoxVeliAd);
            this.Controls.Add(this.maskedVeliTelefon);
            this.Controls.Add(this.comboBoxOgrOdaNo);
            this.Controls.Add(this.comboBoxOgrBolum);
            this.Controls.Add(this.maskedOgrDogum);
            this.Controls.Add(this.maskedOgrTelefon);
            this.Controls.Add(this.maskedOgrTc);
            this.Controls.Add(this.veliAdres);
            this.Controls.Add(this.veliTelefon);
            this.Controls.Add(this.veliAd);
            this.Controls.Add(this.ogrOdaNo);
            this.Controls.Add(this.ogrBolum);
            this.Controls.Add(this.textBoxOgrMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ogrMail);
            this.Controls.Add(this.ogrDogum);
            this.Controls.Add(this.ogrtelefon);
            this.Controls.Add(this.OgrTc);
            this.Controls.Add(this.textBoxOgrSoyad);
            this.Controls.Add(this.ogrSoyad);
            this.Controls.Add(this.textBoxOgrAd);
            this.Controls.Add(this.ogrAd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOgrenciKayit";
            this.Text = "Öğrenci Kayıt Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ogrAd;
        private System.Windows.Forms.TextBox textBoxOgrAd;
        private System.Windows.Forms.Label ogrSoyad;
        private System.Windows.Forms.TextBox textBoxOgrSoyad;
        private System.Windows.Forms.Label OgrTc;
        private System.Windows.Forms.Label ogrtelefon;
        private System.Windows.Forms.Label ogrDogum;
        private System.Windows.Forms.Label ogrMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxOgrMail;
        private System.Windows.Forms.Label ogrBolum;
        private System.Windows.Forms.Label ogrOdaNo;
        private System.Windows.Forms.Label veliAd;
        private System.Windows.Forms.Label veliTelefon;
        private System.Windows.Forms.Label veliAdres;
        private System.Windows.Forms.MaskedTextBox maskedOgrTc;
        private System.Windows.Forms.MaskedTextBox maskedOgrTelefon;
        private System.Windows.Forms.MaskedTextBox maskedOgrDogum;
        private System.Windows.Forms.ComboBox comboBoxOgrBolum;
        private System.Windows.Forms.ComboBox comboBoxOgrOdaNo;
        private System.Windows.Forms.MaskedTextBox maskedVeliTelefon;
        private System.Windows.Forms.TextBox textBoxVeliAd;
        private System.Windows.Forms.RichTextBox richVeliAdres;
        private System.Windows.Forms.Button kayıt;
        private System.Windows.Forms.Label label1;
    }
}

