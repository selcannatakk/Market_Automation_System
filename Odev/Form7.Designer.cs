
namespace Odev
{
    partial class form_urun
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
            this.grb_urun = new System.Windows.Forms.GroupBox();
            this.lbl_urun = new System.Windows.Forms.Label();
            this.lbl_urunad = new System.Windows.Forms.Label();
            this.lbl_urunstok = new System.Windows.Forms.Label();
            this.lbl_fiyat = new System.Windows.Forms.Label();
            this.lbl_sonindirim = new System.Windows.Forms.Label();
            this.text_stok = new System.Windows.Forms.TextBox();
            this.text_fiyat = new System.Windows.Forms.TextBox();
            this.btn_ozlbtn = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.dtp_sonindirim = new System.Windows.Forms.DateTimePicker();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.grb_urun.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_urun
            // 
            this.grb_urun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grb_urun.Controls.Add(this.lbl_urun);
            this.grb_urun.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grb_urun.Location = new System.Drawing.Point(50, 15);
            this.grb_urun.Name = "grb_urun";
            this.grb_urun.Size = new System.Drawing.Size(700, 100);
            this.grb_urun.TabIndex = 0;
            this.grb_urun.TabStop = false;
            // 
            // lbl_urun
            // 
            this.lbl_urun.AutoSize = true;
            this.lbl_urun.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urun.Location = new System.Drawing.Point(285, 23);
            this.lbl_urun.Name = "lbl_urun";
            this.lbl_urun.Size = new System.Drawing.Size(130, 52);
            this.lbl_urun.TabIndex = 0;
            this.lbl_urun.Text = "Ürün";
            // 
            // lbl_urunad
            // 
            this.lbl_urunad.AutoSize = true;
            this.lbl_urunad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urunad.Location = new System.Drawing.Point(304, 155);
            this.lbl_urunad.Name = "lbl_urunad";
            this.lbl_urunad.Size = new System.Drawing.Size(86, 24);
            this.lbl_urunad.TabIndex = 1;
            this.lbl_urunad.Text = "Ürün Adi";
            // 
            // lbl_urunstok
            // 
            this.lbl_urunstok.AutoSize = true;
            this.lbl_urunstok.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urunstok.Location = new System.Drawing.Point(293, 195);
            this.lbl_urunstok.Name = "lbl_urunstok";
            this.lbl_urunstok.Size = new System.Drawing.Size(97, 24);
            this.lbl_urunstok.TabIndex = 2;
            this.lbl_urunstok.Text = "Ürün Stok";
            // 
            // lbl_fiyat
            // 
            this.lbl_fiyat.AutoSize = true;
            this.lbl_fiyat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_fiyat.Location = new System.Drawing.Point(284, 235);
            this.lbl_fiyat.Name = "lbl_fiyat";
            this.lbl_fiyat.Size = new System.Drawing.Size(106, 24);
            this.lbl_fiyat.TabIndex = 3;
            this.lbl_fiyat.Text = "Ürün Fiyati";
            // 
            // lbl_sonindirim
            // 
            this.lbl_sonindirim.AutoSize = true;
            this.lbl_sonindirim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sonindirim.Location = new System.Drawing.Point(173, 275);
            this.lbl_sonindirim.Name = "lbl_sonindirim";
            this.lbl_sonindirim.Size = new System.Drawing.Size(217, 24);
            this.lbl_sonindirim.TabIndex = 4;
            this.lbl_sonindirim.Text = "Ürün Son İndirim Tarihi";
            // 
            // text_stok
            // 
            this.text_stok.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_stok.Location = new System.Drawing.Point(410, 195);
            this.text_stok.Name = "text_stok";
            this.text_stok.Size = new System.Drawing.Size(150, 32);
            this.text_stok.TabIndex = 6;
            // 
            // text_fiyat
            // 
            this.text_fiyat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_fiyat.Location = new System.Drawing.Point(410, 235);
            this.text_fiyat.Name = "text_fiyat";
            this.text_fiyat.Size = new System.Drawing.Size(150, 32);
            this.text_fiyat.TabIndex = 7;
            // 
            // btn_ozlbtn
            // 
            this.btn_ozlbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ozlbtn.Location = new System.Drawing.Point(240, 335);
            this.btn_ozlbtn.Name = "btn_ozlbtn";
            this.btn_ozlbtn.Size = new System.Drawing.Size(150, 40);
            this.btn_ozlbtn.TabIndex = 9;
            this.btn_ozlbtn.Text = "Düzenle";
            this.btn_ozlbtn.UseVisualStyleBackColor = true;
            this.btn_ozlbtn.Click += new System.EventHandler(this.btn_ozlbtn_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iptal.Location = new System.Drawing.Point(410, 335);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(150, 40);
            this.btn_iptal.TabIndex = 10;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // dtp_sonindirim
            // 
            this.dtp_sonindirim.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_sonindirim.Location = new System.Drawing.Point(410, 275);
            this.dtp_sonindirim.Name = "dtp_sonindirim";
            this.dtp_sonindirim.Size = new System.Drawing.Size(150, 22);
            this.dtp_sonindirim.TabIndex = 11;
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.Location = new System.Drawing.Point(410, 155);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(64, 24);
            this.lbl_ad.TabIndex = 12;
            this.lbl_ad.Text = "label1";
            // 
            // form_urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(799, 390);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.dtp_sonindirim);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_ozlbtn);
            this.Controls.Add(this.text_fiyat);
            this.Controls.Add(this.text_stok);
            this.Controls.Add(this.lbl_sonindirim);
            this.Controls.Add(this.lbl_fiyat);
            this.Controls.Add(this.lbl_urunstok);
            this.Controls.Add(this.lbl_urunad);
            this.Controls.Add(this.grb_urun);
            this.Name = "form_urun";
            this.Text = "Ürün";
            this.Load += new System.EventHandler(this.form_urun_Load);
            this.grb_urun.ResumeLayout(false);
            this.grb_urun.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_urun;
        private System.Windows.Forms.Label lbl_urun;
        private System.Windows.Forms.Label lbl_urunad;
        private System.Windows.Forms.Label lbl_urunstok;
        private System.Windows.Forms.Label lbl_fiyat;
        private System.Windows.Forms.Label lbl_sonindirim;
        private System.Windows.Forms.TextBox text_stok;
        private System.Windows.Forms.TextBox text_fiyat;
        private System.Windows.Forms.Button btn_ozlbtn;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.DateTimePicker dtp_sonindirim;
        private System.Windows.Forms.Label lbl_ad;
    }
}