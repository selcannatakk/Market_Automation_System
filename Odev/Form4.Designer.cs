
namespace Odev
{
    partial class form_tedarikciler
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
            this.btn_geri = new System.Windows.Forms.Button();
            this.grb_tedarikciler = new System.Windows.Forms.GroupBox();
            this.lbl_tedarikciler = new System.Windows.Forms.Label();
            this.stoktakipDataSet = new Odev.stokuntakibiDataSet();
            this.stoktakipDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tedarikciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grb_tedarikciler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stoktakipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoktakipDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_geri.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(50, 15);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(100, 30);
            this.btn_geri.TabIndex = 4;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // grb_tedarikciler
            // 
            this.grb_tedarikciler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grb_tedarikciler.Controls.Add(this.lbl_tedarikciler);
            this.grb_tedarikciler.Location = new System.Drawing.Point(50, 55);
            this.grb_tedarikciler.Name = "grb_tedarikciler";
            this.grb_tedarikciler.Size = new System.Drawing.Size(705, 100);
            this.grb_tedarikciler.TabIndex = 5;
            this.grb_tedarikciler.TabStop = false;
            // 
            // lbl_tedarikciler
            // 
            this.lbl_tedarikciler.AutoSize = true;
            this.lbl_tedarikciler.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tedarikciler.Location = new System.Drawing.Point(204, 23);
            this.lbl_tedarikciler.Name = "lbl_tedarikciler";
            this.lbl_tedarikciler.Size = new System.Drawing.Size(280, 52);
            this.lbl_tedarikciler.TabIndex = 0;
            this.lbl_tedarikciler.Text = "Tedarikçiler";
            // 
            // stoktakipDataSet
            // 
            this.stoktakipDataSet.DataSetName = "stoktakipDataSet";
            this.stoktakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tedarikciBindingSource
            // 
            this.tedarikciBindingSource.DataMember = "tedarikci";
            // 
            // form_tedarikciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.grb_tedarikciler);
            this.Controls.Add(this.btn_geri);
            this.Name = "form_tedarikciler";
            this.Text = "Tedarikçiler";
            this.Load += new System.EventHandler(this.form_tedarikciler_Load);
            this.grb_tedarikciler.ResumeLayout(false);
            this.grb_tedarikciler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stoktakipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoktakipDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.GroupBox grb_tedarikciler;
        private System.Windows.Forms.Label lbl_tedarikciler;
      //  private MarketYonetimSistemiDataSet marketYonetimSistemiDataSet;
        private System.Windows.Forms.BindingSource tedarikciBindingSource;
    //    private MarketYonetimSistemiDataSetTableAdapters.tedarikciTableAdapter tedarikciTableAdapter;
        private System.Windows.Forms.BindingSource stoktakipDataSetBindingSource;
        private stokuntakibiDataSet stoktakipDataSet;
    }
}