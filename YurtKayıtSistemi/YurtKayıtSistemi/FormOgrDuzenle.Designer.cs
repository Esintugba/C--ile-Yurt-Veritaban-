namespace YurtKayıtSistemi
{
    partial class FormOgrDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOgrDuzenle));
            this.label1 = new System.Windows.Forms.Label();
            this.guncelle = new System.Windows.Forms.Button();
            this.richVeliAdres = new System.Windows.Forms.RichTextBox();
            this.textBoxVeliAd = new System.Windows.Forms.TextBox();
            this.maskedVeliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxOgrOdaNo = new System.Windows.Forms.ComboBox();
            this.comboBoxOgrBolum = new System.Windows.Forms.ComboBox();
            this.maskedOgrDogum = new System.Windows.Forms.MaskedTextBox();
            this.maskedOgrTelefon = new System.Windows.Forms.MaskedTextBox();
            this.maskedOgrTc = new System.Windows.Forms.MaskedTextBox();
            this.veliAdres = new System.Windows.Forms.Label();
            this.veliTelefon = new System.Windows.Forms.Label();
            this.veliAd = new System.Windows.Forms.Label();
            this.ogrOdaNo = new System.Windows.Forms.Label();
            this.ogrBolum = new System.Windows.Forms.Label();
            this.textBoxOgrMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ogrMail = new System.Windows.Forms.Label();
            this.ogrDogum = new System.Windows.Forms.Label();
            this.ogrtelefon = new System.Windows.Forms.Label();
            this.OgrTc = new System.Windows.Forms.Label();
            this.textBoxOgrSoyad = new System.Windows.Forms.TextBox();
            this.ogrSoyad = new System.Windows.Forms.Label();
            this.textBoxOgrAd = new System.Windows.Forms.TextBox();
            this.ogrAd = new System.Windows.Forms.Label();
            this.textOgrid = new System.Windows.Forms.TextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(147, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guncelle
            // 
            this.guncelle.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle.Location = new System.Drawing.Point(295, 500);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(90, 32);
            this.guncelle.TabIndex = 51;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // richVeliAdres
            // 
            this.richVeliAdres.BackColor = System.Drawing.SystemColors.MenuBar;
            this.richVeliAdres.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richVeliAdres.Location = new System.Drawing.Point(268, 398);
            this.richVeliAdres.Name = "richVeliAdres";
            this.richVeliAdres.Size = new System.Drawing.Size(251, 96);
            this.richVeliAdres.TabIndex = 50;
            this.richVeliAdres.Text = "";
            // 
            // textBoxVeliAd
            // 
            this.textBoxVeliAd.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxVeliAd.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxVeliAd.Location = new System.Drawing.Point(268, 324);
            this.textBoxVeliAd.Name = "textBoxVeliAd";
            this.textBoxVeliAd.Size = new System.Drawing.Size(251, 26);
            this.textBoxVeliAd.TabIndex = 49;
            // 
            // maskedVeliTelefon
            // 
            this.maskedVeliTelefon.BackColor = System.Drawing.SystemColors.MenuBar;
            this.maskedVeliTelefon.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedVeliTelefon.Location = new System.Drawing.Point(268, 362);
            this.maskedVeliTelefon.Mask = "(999) 000-0000";
            this.maskedVeliTelefon.Name = "maskedVeliTelefon";
            this.maskedVeliTelefon.Size = new System.Drawing.Size(251, 26);
            this.maskedVeliTelefon.TabIndex = 48;
            // 
            // comboBoxOgrOdaNo
            // 
            this.comboBoxOgrOdaNo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBoxOgrOdaNo.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxOgrOdaNo.FormattingEnabled = true;
            this.comboBoxOgrOdaNo.Location = new System.Drawing.Point(268, 288);
            this.comboBoxOgrOdaNo.Name = "comboBoxOgrOdaNo";
            this.comboBoxOgrOdaNo.Size = new System.Drawing.Size(251, 26);
            this.comboBoxOgrOdaNo.TabIndex = 47;
            // 
            // comboBoxOgrBolum
            // 
            this.comboBoxOgrBolum.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBoxOgrBolum.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxOgrBolum.FormattingEnabled = true;
            this.comboBoxOgrBolum.Location = new System.Drawing.Point(268, 252);
            this.comboBoxOgrBolum.Name = "comboBoxOgrBolum";
            this.comboBoxOgrBolum.Size = new System.Drawing.Size(251, 26);
            this.comboBoxOgrBolum.TabIndex = 46;
            // 
            // maskedOgrDogum
            // 
            this.maskedOgrDogum.BackColor = System.Drawing.SystemColors.MenuBar;
            this.maskedOgrDogum.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedOgrDogum.Location = new System.Drawing.Point(268, 185);
            this.maskedOgrDogum.Mask = "00/00/0000";
            this.maskedOgrDogum.Name = "maskedOgrDogum";
            this.maskedOgrDogum.Size = new System.Drawing.Size(251, 26);
            this.maskedOgrDogum.TabIndex = 45;
            this.maskedOgrDogum.ValidatingType = typeof(System.DateTime);
            // 
            // maskedOgrTelefon
            // 
            this.maskedOgrTelefon.BackColor = System.Drawing.SystemColors.MenuBar;
            this.maskedOgrTelefon.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedOgrTelefon.Location = new System.Drawing.Point(268, 152);
            this.maskedOgrTelefon.Mask = "(999) 000-0000";
            this.maskedOgrTelefon.Name = "maskedOgrTelefon";
            this.maskedOgrTelefon.Size = new System.Drawing.Size(251, 26);
            this.maskedOgrTelefon.TabIndex = 44;
            // 
            // maskedOgrTc
            // 
            this.maskedOgrTc.BackColor = System.Drawing.SystemColors.MenuBar;
            this.maskedOgrTc.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedOgrTc.Location = new System.Drawing.Point(268, 50);
            this.maskedOgrTc.Mask = "00000000000";
            this.maskedOgrTc.Name = "maskedOgrTc";
            this.maskedOgrTc.Size = new System.Drawing.Size(251, 26);
            this.maskedOgrTc.TabIndex = 43;
            this.maskedOgrTc.ValidatingType = typeof(int);
            // 
            // veliAdres
            // 
            this.veliAdres.AutoSize = true;
            this.veliAdres.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.veliAdres.Location = new System.Drawing.Point(149, 397);
            this.veliAdres.Name = "veliAdres";
            this.veliAdres.Size = new System.Drawing.Size(99, 18);
            this.veliAdres.TabIndex = 42;
            this.veliAdres.Text = "Veli Adres:";
            // 
            // veliTelefon
            // 
            this.veliTelefon.AutoSize = true;
            this.veliTelefon.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.veliTelefon.Location = new System.Drawing.Point(81, 362);
            this.veliTelefon.Name = "veliTelefon";
            this.veliTelefon.Size = new System.Drawing.Size(167, 18);
            this.veliTelefon.TabIndex = 41;
            this.veliTelefon.Text = "Veli Tel.Numarası:";
            // 
            // veliAd
            // 
            this.veliAd.AutoSize = true;
            this.veliAd.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.veliAd.Location = new System.Drawing.Point(113, 327);
            this.veliAd.Name = "veliAd";
            this.veliAd.Size = new System.Drawing.Size(135, 18);
            this.veliAd.TabIndex = 40;
            this.veliAd.Text = "Veli Ad-Soyad:";
            // 
            // ogrOdaNo
            // 
            this.ogrOdaNo.AutoSize = true;
            this.ogrOdaNo.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrOdaNo.Location = new System.Drawing.Point(113, 291);
            this.ogrOdaNo.Name = "ogrOdaNo";
            this.ogrOdaNo.Size = new System.Drawing.Size(137, 18);
            this.ogrOdaNo.TabIndex = 39;
            this.ogrOdaNo.Text = "Oda Numarası:";
            // 
            // ogrBolum
            // 
            this.ogrBolum.AutoSize = true;
            this.ogrBolum.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrBolum.Location = new System.Drawing.Point(101, 255);
            this.ogrBolum.Name = "ogrBolum";
            this.ogrBolum.Size = new System.Drawing.Size(150, 18);
            this.ogrBolum.TabIndex = 38;
            this.ogrBolum.Text = "Okuduğu Bölüm:";
            // 
            // textBoxOgrMail
            // 
            this.textBoxOgrMail.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxOgrMail.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOgrMail.Location = new System.Drawing.Point(268, 217);
            this.textBoxOgrMail.Name = "textBoxOgrMail";
            this.textBoxOgrMail.Size = new System.Drawing.Size(251, 26);
            this.textBoxOgrMail.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(194, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 18);
            this.label7.TabIndex = 36;
            // 
            // ogrMail
            // 
            this.ogrMail.AutoSize = true;
            this.ogrMail.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrMail.Location = new System.Drawing.Point(193, 220);
            this.ogrMail.Name = "ogrMail";
            this.ogrMail.Size = new System.Drawing.Size(57, 18);
            this.ogrMail.TabIndex = 35;
            this.ogrMail.Text = "Mail :";
            // 
            // ogrDogum
            // 
            this.ogrDogum.AutoSize = true;
            this.ogrDogum.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrDogum.Location = new System.Drawing.Point(119, 188);
            this.ogrDogum.Name = "ogrDogum";
            this.ogrDogum.Size = new System.Drawing.Size(131, 18);
            this.ogrDogum.TabIndex = 34;
            this.ogrDogum.Text = "Doğum Tarihi:";
            // 
            // ogrtelefon
            // 
            this.ogrtelefon.AutoSize = true;
            this.ogrtelefon.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrtelefon.Location = new System.Drawing.Point(86, 155);
            this.ogrtelefon.Name = "ogrtelefon";
            this.ogrtelefon.Size = new System.Drawing.Size(165, 18);
            this.ogrtelefon.TabIndex = 33;
            this.ogrtelefon.Text = "Telefon Numarası:";
            // 
            // OgrTc
            // 
            this.OgrTc.AutoSize = true;
            this.OgrTc.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrTc.Location = new System.Drawing.Point(208, 53);
            this.OgrTc.Name = "OgrTc";
            this.OgrTc.Size = new System.Drawing.Size(42, 18);
            this.OgrTc.TabIndex = 32;
            this.OgrTc.Text = "T.C:";
            // 
            // textBoxOgrSoyad
            // 
            this.textBoxOgrSoyad.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxOgrSoyad.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOgrSoyad.Location = new System.Drawing.Point(268, 117);
            this.textBoxOgrSoyad.Name = "textBoxOgrSoyad";
            this.textBoxOgrSoyad.Size = new System.Drawing.Size(251, 26);
            this.textBoxOgrSoyad.TabIndex = 31;
            // 
            // ogrSoyad
            // 
            this.ogrSoyad.AutoSize = true;
            this.ogrSoyad.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrSoyad.Location = new System.Drawing.Point(177, 120);
            this.ogrSoyad.Name = "ogrSoyad";
            this.ogrSoyad.Size = new System.Drawing.Size(74, 18);
            this.ogrSoyad.TabIndex = 30;
            this.ogrSoyad.Text = "Soyadı:";
            // 
            // textBoxOgrAd
            // 
            this.textBoxOgrAd.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxOgrAd.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOgrAd.Location = new System.Drawing.Point(268, 85);
            this.textBoxOgrAd.Name = "textBoxOgrAd";
            this.textBoxOgrAd.Size = new System.Drawing.Size(251, 26);
            this.textBoxOgrAd.TabIndex = 29;
            // 
            // ogrAd
            // 
            this.ogrAd.AutoSize = true;
            this.ogrAd.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrAd.Location = new System.Drawing.Point(208, 88);
            this.ogrAd.Name = "ogrAd";
            this.ogrAd.Size = new System.Drawing.Size(43, 18);
            this.ogrAd.TabIndex = 28;
            this.ogrAd.Text = "Adı:";
            // 
            // textOgrid
            // 
            this.textOgrid.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textOgrid.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textOgrid.Location = new System.Drawing.Point(268, 15);
            this.textOgrid.Name = "textOgrid";
            this.textOgrid.Size = new System.Drawing.Size(251, 26);
            this.textOgrid.TabIndex = 52;
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.Location = new System.Drawing.Point(410, 500);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(90, 32);
            this.buttonSil.TabIndex = 53;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // FormOgrDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(669, 544);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.textOgrid);
            this.Controls.Add(this.guncelle);
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
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOgrDuzenle";
            this.Text = "Öğrenci Bilgi Sistemi";
            this.Load += new System.EventHandler(this.FormOgrDuzenle_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormOgrDuzenle_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.RichTextBox richVeliAdres;
        private System.Windows.Forms.TextBox textBoxVeliAd;
        private System.Windows.Forms.MaskedTextBox maskedVeliTelefon;
        private System.Windows.Forms.ComboBox comboBoxOgrOdaNo;
        private System.Windows.Forms.ComboBox comboBoxOgrBolum;
        private System.Windows.Forms.MaskedTextBox maskedOgrDogum;
        private System.Windows.Forms.MaskedTextBox maskedOgrTelefon;
        private System.Windows.Forms.MaskedTextBox maskedOgrTc;
        private System.Windows.Forms.Label veliAdres;
        private System.Windows.Forms.Label veliTelefon;
        private System.Windows.Forms.Label veliAd;
        private System.Windows.Forms.Label ogrOdaNo;
        private System.Windows.Forms.Label ogrBolum;
        private System.Windows.Forms.TextBox textBoxOgrMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ogrMail;
        private System.Windows.Forms.Label ogrDogum;
        private System.Windows.Forms.Label ogrtelefon;
        private System.Windows.Forms.Label OgrTc;
        private System.Windows.Forms.TextBox textBoxOgrSoyad;
        private System.Windows.Forms.Label ogrSoyad;
        private System.Windows.Forms.TextBox textBoxOgrAd;
        private System.Windows.Forms.Label ogrAd;
        private System.Windows.Forms.TextBox textOgrid;
        private System.Windows.Forms.Button buttonSil;
    }
}