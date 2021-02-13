
namespace Odev
{
    partial class form_secim
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
            this.btn_tedarik = new System.Windows.Forms.Button();
            this.btn_sube = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_tedarik
            // 
            this.btn_tedarik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_tedarik.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tedarik.Location = new System.Drawing.Point(50, 50);
            this.btn_tedarik.Name = "btn_tedarik";
            this.btn_tedarik.Size = new System.Drawing.Size(175, 50);
            this.btn_tedarik.TabIndex = 0;
            this.btn_tedarik.Text = "Tedarikçiler";
            this.btn_tedarik.UseVisualStyleBackColor = false;
            this.btn_tedarik.Click += new System.EventHandler(this.btn_tedarik_Click);
            // 
            // btn_sube
            // 
            this.btn_sube.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_sube.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sube.Location = new System.Drawing.Point(250, 50);
            this.btn_sube.Name = "btn_sube";
            this.btn_sube.Size = new System.Drawing.Size(175, 50);
            this.btn_sube.TabIndex = 1;
            this.btn_sube.Text = "Şubeler";
            this.btn_sube.UseVisualStyleBackColor = false;
            this.btn_sube.Click += new System.EventHandler(this.btn_sube_Click);
            // 
            // form_secim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(474, 153);
            this.Controls.Add(this.btn_sube);
            this.Controls.Add(this.btn_tedarik);
            this.Name = "form_secim";
            this.Text = "Seçim";
            this.Load += new System.EventHandler(this.form_secim_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_tedarik;
        private System.Windows.Forms.Button btn_sube;
    }
}