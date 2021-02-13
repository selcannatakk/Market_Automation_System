
namespace Odev
{
    partial class form_personel
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
            System.Windows.Forms.Label lbl_mevki;
            this.grb_personel = new System.Windows.Forms.GroupBox();
            this.lbl_personel = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_numara = new System.Windows.Forms.Label();
            this.lbl_il = new System.Windows.Forms.Label();
            this.lbl_ilce = new System.Windows.Forms.Label();
            this.lbl_mahalle = new System.Windows.Forms.Label();
            this.lbl_acikadres = new System.Windows.Forms.Label();
            this.lbl_maas = new System.Windows.Forms.Label();
            this.lbl_sube = new System.Windows.Forms.Label();
            this.lbl_izin = new System.Windows.Forms.Label();
            this.cmb_mevki = new System.Windows.Forms.ComboBox();
            this.txt_yillikizin = new System.Windows.Forms.TextBox();
            this.txt_numarası = new System.Windows.Forms.TextBox();
            this.txt_il = new System.Windows.Forms.TextBox();
            this.txt_ilce = new System.Windows.Forms.TextBox();
            this.txt_mahalle = new System.Windows.Forms.TextBox();
            this.txt_acikadres = new System.Windows.Forms.TextBox();
            this.txt_maas = new System.Windows.Forms.TextBox();
            this.txt_izingunu = new System.Windows.Forms.TextBox();
            this.lbl_yillikizin = new System.Windows.Forms.Label();
            this.lbl_btarih = new System.Windows.Forms.Label();
            this.cmb_sube = new System.Windows.Forms.ComboBox();
            this.lbl_personelad = new System.Windows.Forms.Label();
            this.lbl_personelsoyad = new System.Windows.Forms.Label();
            this.lbl_personelisbasla = new System.Windows.Forms.Label();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            lbl_mevki = new System.Windows.Forms.Label();
            this.grb_personel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_mevki
            // 
            lbl_mevki.AutoSize = true;
            lbl_mevki.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lbl_mevki.Location = new System.Drawing.Point(247, 155);
            lbl_mevki.Name = "lbl_mevki";
            lbl_mevki.Size = new System.Drawing.Size(143, 24);
            lbl_mevki.TabIndex = 3;
            lbl_mevki.Text = "Personel Mevki";
            // 
            // grb_personel
            // 
            this.grb_personel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grb_personel.Controls.Add(this.lbl_personel);
            this.grb_personel.Location = new System.Drawing.Point(50, 15);
            this.grb_personel.Name = "grb_personel";
            this.grb_personel.Size = new System.Drawing.Size(700, 100);
            this.grb_personel.TabIndex = 0;
            this.grb_personel.TabStop = false;
            // 
            // lbl_personel
            // 
            this.lbl_personel.AutoSize = true;
            this.lbl_personel.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_personel.Location = new System.Drawing.Point(243, 23);
            this.lbl_personel.Name = "lbl_personel";
            this.lbl_personel.Size = new System.Drawing.Size(212, 52);
            this.lbl_personel.TabIndex = 0;
            this.lbl_personel.Text = "Personel";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.Location = new System.Drawing.Point(270, 195);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(120, 24);
            this.lbl_ad.TabIndex = 1;
            this.lbl_ad.Text = "Personel Adı";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyad.Location = new System.Drawing.Point(239, 235);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(151, 24);
            this.lbl_soyad.TabIndex = 2;
            this.lbl_soyad.Text = "Personel Soyadı";
            // 
            // lbl_numara
            // 
            this.lbl_numara.AutoSize = true;
            this.lbl_numara.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_numara.Location = new System.Drawing.Point(214, 275);
            this.lbl_numara.Name = "lbl_numara";
            this.lbl_numara.Size = new System.Drawing.Size(176, 24);
            this.lbl_numara.TabIndex = 4;
            this.lbl_numara.Text = "Personel Numarası";
            // 
            // lbl_il
            // 
            this.lbl_il.AutoSize = true;
            this.lbl_il.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_il.Location = new System.Drawing.Point(286, 315);
            this.lbl_il.Name = "lbl_il";
            this.lbl_il.Size = new System.Drawing.Size(104, 24);
            this.lbl_il.TabIndex = 5;
            this.lbl_il.Text = "Personal İl";
            // 
            // lbl_ilce
            // 
            this.lbl_ilce.AutoSize = true;
            this.lbl_ilce.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ilce.Location = new System.Drawing.Point(266, 355);
            this.lbl_ilce.Name = "lbl_ilce";
            this.lbl_ilce.Size = new System.Drawing.Size(124, 24);
            this.lbl_ilce.TabIndex = 6;
            this.lbl_ilce.Text = "Personel İlçe";
            // 
            // lbl_mahalle
            // 
            this.lbl_mahalle.AutoSize = true;
            this.lbl_mahalle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mahalle.Location = new System.Drawing.Point(218, 395);
            this.lbl_mahalle.Name = "lbl_mahalle";
            this.lbl_mahalle.Size = new System.Drawing.Size(172, 24);
            this.lbl_mahalle.TabIndex = 7;
            this.lbl_mahalle.Text = "Personel Mahhalle";
            // 
            // lbl_acikadres
            // 
            this.lbl_acikadres.AutoSize = true;
            this.lbl_acikadres.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_acikadres.Location = new System.Drawing.Point(208, 435);
            this.lbl_acikadres.Name = "lbl_acikadres";
            this.lbl_acikadres.Size = new System.Drawing.Size(184, 24);
            this.lbl_acikadres.TabIndex = 8;
            this.lbl_acikadres.Text = "Personel Açık Adres";
            // 
            // lbl_maas
            // 
            this.lbl_maas.AutoSize = true;
            this.lbl_maas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_maas.Location = new System.Drawing.Point(247, 515);
            this.lbl_maas.Name = "lbl_maas";
            this.lbl_maas.Size = new System.Drawing.Size(143, 24);
            this.lbl_maas.TabIndex = 9;
            this.lbl_maas.Text = "Personel Maaşı";
            // 
            // lbl_sube
            // 
            this.lbl_sube.AutoSize = true;
            this.lbl_sube.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sube.Location = new System.Drawing.Point(224, 475);
            this.lbl_sube.Name = "lbl_sube";
            this.lbl_sube.Size = new System.Drawing.Size(166, 24);
            this.lbl_sube.TabIndex = 10;
            this.lbl_sube.Text = "Personelin Şubesi";
            // 
            // lbl_izin
            // 
            this.lbl_izin.AutoSize = true;
            this.lbl_izin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_izin.Location = new System.Drawing.Point(214, 555);
            this.lbl_izin.Name = "lbl_izin";
            this.lbl_izin.Size = new System.Drawing.Size(176, 24);
            this.lbl_izin.TabIndex = 11;
            this.lbl_izin.Text = "Personel İzin Günü";
            // 
            // cmb_mevki
            // 
            this.cmb_mevki.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_mevki.FormattingEnabled = true;
            this.cmb_mevki.Items.AddRange(new object[] {
            "Yönetici",
            "Müdür",
            "Müdür Yardımcısı",
            "Kasiyer"});
            this.cmb_mevki.Location = new System.Drawing.Point(410, 155);
            this.cmb_mevki.Name = "cmb_mevki";
            this.cmb_mevki.Size = new System.Drawing.Size(150, 32);
            this.cmb_mevki.TabIndex = 12;
            // 
            // txt_yillikizin
            // 
            this.txt_yillikizin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yillikizin.Location = new System.Drawing.Point(410, 595);
            this.txt_yillikizin.Name = "txt_yillikizin";
            this.txt_yillikizin.Size = new System.Drawing.Size(150, 32);
            this.txt_yillikizin.TabIndex = 13;
            // 
            // txt_numarası
            // 
            this.txt_numarası.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_numarası.Location = new System.Drawing.Point(410, 275);
            this.txt_numarası.Name = "txt_numarası";
            this.txt_numarası.Size = new System.Drawing.Size(150, 32);
            this.txt_numarası.TabIndex = 15;
            // 
            // txt_il
            // 
            this.txt_il.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_il.Location = new System.Drawing.Point(410, 315);
            this.txt_il.Name = "txt_il";
            this.txt_il.Size = new System.Drawing.Size(150, 32);
            this.txt_il.TabIndex = 16;
            // 
            // txt_ilce
            // 
            this.txt_ilce.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ilce.Location = new System.Drawing.Point(410, 355);
            this.txt_ilce.Name = "txt_ilce";
            this.txt_ilce.Size = new System.Drawing.Size(150, 32);
            this.txt_ilce.TabIndex = 17;
            // 
            // txt_mahalle
            // 
            this.txt_mahalle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_mahalle.Location = new System.Drawing.Point(410, 395);
            this.txt_mahalle.Name = "txt_mahalle";
            this.txt_mahalle.Size = new System.Drawing.Size(150, 32);
            this.txt_mahalle.TabIndex = 18;
            // 
            // txt_acikadres
            // 
            this.txt_acikadres.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_acikadres.Location = new System.Drawing.Point(410, 435);
            this.txt_acikadres.Name = "txt_acikadres";
            this.txt_acikadres.Size = new System.Drawing.Size(150, 32);
            this.txt_acikadres.TabIndex = 19;
            // 
            // txt_maas
            // 
            this.txt_maas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_maas.Location = new System.Drawing.Point(410, 515);
            this.txt_maas.Name = "txt_maas";
            this.txt_maas.Size = new System.Drawing.Size(150, 32);
            this.txt_maas.TabIndex = 21;
            // 
            // txt_izingunu
            // 
            this.txt_izingunu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_izingunu.Location = new System.Drawing.Point(410, 555);
            this.txt_izingunu.Name = "txt_izingunu";
            this.txt_izingunu.Size = new System.Drawing.Size(150, 32);
            this.txt_izingunu.TabIndex = 22;
            // 
            // lbl_yillikizin
            // 
            this.lbl_yillikizin.AutoSize = true;
            this.lbl_yillikizin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yillikizin.Location = new System.Drawing.Point(218, 595);
            this.lbl_yillikizin.Name = "lbl_yillikizin";
            this.lbl_yillikizin.Size = new System.Drawing.Size(172, 24);
            this.lbl_yillikizin.TabIndex = 23;
            this.lbl_yillikizin.Text = "Personel Yıllık İzin";
            // 
            // lbl_btarih
            // 
            this.lbl_btarih.AutoSize = true;
            this.lbl_btarih.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_btarih.Location = new System.Drawing.Point(132, 635);
            this.lbl_btarih.Name = "lbl_btarih";
            this.lbl_btarih.Size = new System.Drawing.Size(258, 24);
            this.lbl_btarih.TabIndex = 24;
            this.lbl_btarih.Text = "Personal İşe Başlama Tarihi";
            // 
            // cmb_sube
            // 
            this.cmb_sube.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_sube.FormattingEnabled = true;
            this.cmb_sube.Items.AddRange(new object[] {
            "İstanbul Beykoz Şubesi",
            "Konak İzmir Şubesi",
            "Çaykara Trabzon Şubesi",
            "Kahramanmaraş Şubesi"});
            this.cmb_sube.Location = new System.Drawing.Point(410, 475);
            this.cmb_sube.Name = "cmb_sube";
            this.cmb_sube.Size = new System.Drawing.Size(150, 32);
            this.cmb_sube.TabIndex = 25;
            // 
            // lbl_personelad
            // 
            this.lbl_personelad.AutoSize = true;
            this.lbl_personelad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_personelad.Location = new System.Drawing.Point(410, 195);
            this.lbl_personelad.Name = "lbl_personelad";
            this.lbl_personelad.Size = new System.Drawing.Size(64, 24);
            this.lbl_personelad.TabIndex = 26;
            this.lbl_personelad.Text = "label1";
            // 
            // lbl_personelsoyad
            // 
            this.lbl_personelsoyad.AutoSize = true;
            this.lbl_personelsoyad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_personelsoyad.Location = new System.Drawing.Point(410, 235);
            this.lbl_personelsoyad.Name = "lbl_personelsoyad";
            this.lbl_personelsoyad.Size = new System.Drawing.Size(64, 24);
            this.lbl_personelsoyad.TabIndex = 27;
            this.lbl_personelsoyad.Text = "label1";
            // 
            // lbl_personelisbasla
            // 
            this.lbl_personelisbasla.AutoSize = true;
            this.lbl_personelisbasla.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_personelisbasla.Location = new System.Drawing.Point(410, 635);
            this.lbl_personelisbasla.Name = "lbl_personelisbasla";
            this.lbl_personelisbasla.Size = new System.Drawing.Size(64, 24);
            this.lbl_personelisbasla.TabIndex = 28;
            this.lbl_personelisbasla.Text = "label1";
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_duzenle.Location = new System.Drawing.Point(240, 685);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(150, 40);
            this.btn_duzenle.TabIndex = 29;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iptal.Location = new System.Drawing.Point(410, 685);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(150, 40);
            this.btn_iptal.TabIndex = 30;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // form_personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(799, 748);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.lbl_personelisbasla);
            this.Controls.Add(this.lbl_personelsoyad);
            this.Controls.Add(this.lbl_personelad);
            this.Controls.Add(this.cmb_sube);
            this.Controls.Add(this.lbl_btarih);
            this.Controls.Add(this.lbl_yillikizin);
            this.Controls.Add(this.txt_izingunu);
            this.Controls.Add(this.txt_maas);
            this.Controls.Add(this.txt_acikadres);
            this.Controls.Add(this.txt_mahalle);
            this.Controls.Add(this.txt_ilce);
            this.Controls.Add(this.txt_il);
            this.Controls.Add(this.txt_numarası);
            this.Controls.Add(this.txt_yillikizin);
            this.Controls.Add(this.cmb_mevki);
            this.Controls.Add(this.lbl_izin);
            this.Controls.Add(this.lbl_sube);
            this.Controls.Add(this.lbl_maas);
            this.Controls.Add(this.lbl_acikadres);
            this.Controls.Add(this.lbl_mahalle);
            this.Controls.Add(this.lbl_ilce);
            this.Controls.Add(this.lbl_il);
            this.Controls.Add(this.lbl_numara);
            this.Controls.Add(lbl_mevki);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.grb_personel);
            this.Name = "form_personel";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.form_personel_Load);
            this.grb_personel.ResumeLayout(false);
            this.grb_personel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_personel;
        private System.Windows.Forms.Label lbl_personel;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_numara;
        private System.Windows.Forms.Label lbl_il;
        private System.Windows.Forms.Label lbl_ilce;
        private System.Windows.Forms.Label lbl_mahalle;
        private System.Windows.Forms.Label lbl_acikadres;
        private System.Windows.Forms.Label lbl_maas;
        private System.Windows.Forms.Label lbl_sube;
        private System.Windows.Forms.Label lbl_izin;
        private System.Windows.Forms.ComboBox cmb_mevki;
        private System.Windows.Forms.TextBox txt_yillikizin;
        private System.Windows.Forms.TextBox txt_numarası;
        private System.Windows.Forms.TextBox txt_il;
        private System.Windows.Forms.TextBox txt_ilce;
        private System.Windows.Forms.TextBox txt_mahalle;
        private System.Windows.Forms.TextBox txt_acikadres;
        private System.Windows.Forms.TextBox txt_maas;
        private System.Windows.Forms.TextBox txt_izingunu;
        private System.Windows.Forms.Label lbl_yillikizin;
        private System.Windows.Forms.Label lbl_btarih;
        private System.Windows.Forms.ComboBox cmb_sube;
        private System.Windows.Forms.Label lbl_personelad;
        private System.Windows.Forms.Label lbl_personelsoyad;
        private System.Windows.Forms.Label lbl_personelisbasla;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.Button btn_iptal;
    }
}