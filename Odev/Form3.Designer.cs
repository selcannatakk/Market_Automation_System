
namespace Odev
{
    partial class form_subeler
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
            this.grb_subeler = new System.Windows.Forms.GroupBox();
            this.lbl_subeler = new System.Windows.Forms.Label();
            this.btn_geri = new System.Windows.Forms.Button();
            this.stoktakipDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stoktakipDataSet = new Odev.stokuntakibiDataSet();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.grb_subeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stoktakipDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoktakipDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_subeler
            // 
            this.grb_subeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grb_subeler.Controls.Add(this.lbl_subeler);
            this.grb_subeler.Location = new System.Drawing.Point(50, 55);
            this.grb_subeler.Name = "grb_subeler";
            this.grb_subeler.Size = new System.Drawing.Size(805, 100);
            this.grb_subeler.TabIndex = 3;
            this.grb_subeler.TabStop = false;
            // 
            // lbl_subeler
            // 
            this.lbl_subeler.AutoSize = true;
            this.lbl_subeler.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_subeler.Location = new System.Drawing.Point(300, 28);
            this.lbl_subeler.Name = "lbl_subeler";
            this.lbl_subeler.Size = new System.Drawing.Size(189, 52);
            this.lbl_subeler.TabIndex = 4;
            this.lbl_subeler.Text = "Şubeler";
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_geri.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(50, 15);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(100, 30);
            this.btn_geri.TabIndex = 5;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // subelerBindingSource
            // 
            this.subelerBindingSource.DataMember = "subeler";
            // 
            // stoktakipDataSet
            // 
            this.stoktakipDataSet.DataSetName = "stoktakipDataSet";
            this.stoktakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(755, 15);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(100, 30);
            this.btn_ekle.TabIndex = 6;
            this.btn_ekle.Text = "Şube Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // form_subeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.grb_subeler);
            this.Name = "form_subeler";
            this.Text = "Şubeler";
            this.Load += new System.EventHandler(this.form_subeler_Load);
            this.grb_subeler.ResumeLayout(false);
            this.grb_subeler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stoktakipDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoktakipDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grb_subeler;
        private System.Windows.Forms.Label lbl_subeler;
        private System.Windows.Forms.Button btn_geri;
     //   private MarketYonetimSistemiDataSet marketYonetimSistemiDataSet;
        private System.Windows.Forms.BindingSource subelerBindingSource;
      //  private MarketYonetimSistemiDataSetTableAdapters.subelerTableAdapter subelerTableAdapter;
        private System.Windows.Forms.BindingSource stoktakipDataSetBindingSource;
        private stokuntakibiDataSet stoktakipDataSet;
        private System.Windows.Forms.Button btn_ekle;
    }
}