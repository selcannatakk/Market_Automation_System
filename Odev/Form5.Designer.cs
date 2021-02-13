
namespace Odev
{
    partial class form_urunler
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
            this.grb_urunler = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_urunler.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_urunler
            // 
            this.grb_urunler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grb_urunler.Controls.Add(this.label1);
            this.grb_urunler.Location = new System.Drawing.Point(50, 55);
            this.grb_urunler.Name = "grb_urunler";
            this.grb_urunler.Size = new System.Drawing.Size(900, 100);
            this.grb_urunler.TabIndex = 0;
            this.grb_urunler.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(355, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürünler";
            // 
            // form_urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.grb_urunler);
            this.Name = "form_urunler";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.form_urunler_Load);
            this.grb_urunler.ResumeLayout(false);
            this.grb_urunler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_urunler;
        private System.Windows.Forms.Label label1;
    }
}