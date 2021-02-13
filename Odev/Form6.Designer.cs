
namespace Odev
{
    partial class form_personeller
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
            this.grb_personel = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.grb_personel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_personel
            // 
            this.grb_personel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grb_personel.Controls.Add(this.label1);
            this.grb_personel.Location = new System.Drawing.Point(50, 55);
            this.grb_personel.Name = "grb_personel";
            this.grb_personel.Size = new System.Drawing.Size(1350, 100);
            this.grb_personel.TabIndex = 0;
            this.grb_personel.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(540, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personeller";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(1250, 15);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(150, 30);
            this.btn_ekle.TabIndex = 1;
            this.btn_ekle.Text = "Personel Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // form_personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1449, 450);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.grb_personel);
            this.Name = "form_personeller";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.form_personeller_Load);
            this.grb_personel.ResumeLayout(false);
            this.grb_personel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_personel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ekle;
    }
}