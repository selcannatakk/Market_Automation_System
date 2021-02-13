
namespace Odev
{
    partial class form_giris
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
            this.cmb_mevki = new System.Windows.Forms.ComboBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.lbl_giris = new System.Windows.Forms.Label();
            this.lbl_mevki = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.grb_giris = new System.Windows.Forms.GroupBox();
            this.grb_giris.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_mevki
            // 
            this.cmb_mevki.FormattingEnabled = true;
            this.cmb_mevki.Items.AddRange(new object[] {
            "Yönetici",
            "Müdür",
            "Müdür Yardımcısı",
            "Kasiyer"});
            this.cmb_mevki.Location = new System.Drawing.Point(316, 210);
            this.cmb_mevki.Name = "cmb_mevki";
            this.cmb_mevki.Size = new System.Drawing.Size(150, 24);
            this.cmb_mevki.TabIndex = 0;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(316, 250);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(150, 22);
            this.txt_sifre.TabIndex = 1;
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_giris.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Location = new System.Drawing.Point(266, 300);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(150, 40);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // lbl_giris
            // 
            this.lbl_giris.AutoSize = true;
            this.lbl_giris.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_giris.Location = new System.Drawing.Point(155, 49);
            this.lbl_giris.Name = "lbl_giris";
            this.lbl_giris.Size = new System.Drawing.Size(273, 52);
            this.lbl_giris.TabIndex = 3;
            this.lbl_giris.Text = "Giriş Ekranı";
            // 
            // lbl_mevki
            // 
            this.lbl_mevki.AutoSize = true;
            this.lbl_mevki.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mevki.Location = new System.Drawing.Point(216, 210);
            this.lbl_mevki.Name = "lbl_mevki";
            this.lbl_mevki.Size = new System.Drawing.Size(70, 24);
            this.lbl_mevki.TabIndex = 4;
            this.lbl_mevki.Text = "Mevki";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.Location = new System.Drawing.Point(216, 250);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(58, 24);
            this.lbl_sifre.TabIndex = 5;
            this.lbl_sifre.Text = "Şifre";
            // 
            // grb_giris
            // 
            this.grb_giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grb_giris.Controls.Add(this.lbl_giris);
            this.grb_giris.Location = new System.Drawing.Point(50, 15);
            this.grb_giris.Margin = new System.Windows.Forms.Padding(0);
            this.grb_giris.Name = "grb_giris";
            this.grb_giris.Size = new System.Drawing.Size(583, 150);
            this.grb_giris.TabIndex = 6;
            this.grb_giris.TabStop = false;
            // 
            // form_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.grb_giris);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_mevki);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.cmb_mevki);
            this.Name = "form_giris";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.form_giris_Load);
            this.grb_giris.ResumeLayout(false);
            this.grb_giris.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_mevki;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label lbl_giris;
        private System.Windows.Forms.Label lbl_mevki;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.GroupBox grb_giris;
    }
}

