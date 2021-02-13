using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Odev
{
    public partial class form_suebekle : Form
    {
        public form_suebekle()
        {
            InitializeComponent();
        }

        private void form_suebekle_Load(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_il.Text == "" && txt_ilce.Text == "" && txt_mahalle.Text == "" && txt_acikadres.Text == "")
            {
                MessageBox.Show("Ekleme İptal oldu!");
                this.Hide();
            }
            else
            {
                MySqlConnection baglanti = new MySqlConnection(@"Data Source=127.0.0.1; Database=stokatkip;User ID=root; Password=");
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("insert into subeler(S_ad,S_soyad,S_adresil,S_adresilce,S_adresmahalle,S_adresacikadres) values (" + txt_ad.Text + ",'" + txt_il.Text + "','" + txt_ilce.Text + "','" + txt_mahalle.Text + "','" + txt_acikadres.Text +"')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
        }
    }
}
