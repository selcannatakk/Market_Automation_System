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
    public partial class form_personelekle : Form
    {
        public form_personelekle()
        {
            InitializeComponent();
        }

        private void form_personelekle_Load(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_il.Text=="" && txt_ilce.Text=="" && txt_mahalle.Text=="" && txt_acikadres.Text=="") {
                MessageBox.Show("Ekleme İptal oldu!");
                this.Hide();
            }
            else
            {
                MySqlConnection baglanti = new MySqlConnection(@"Data Source=127.0.0.1; Database=stokatkip;User ID=root; Password=");
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("insert into personel(P_ad,P_soyad,P_adresil,P_adresilce,P_adresmahalle,P_adresacikadres,,P_numara,P_subeid,P_maas,P_mevki,P_izingunu,P_yıllıkizin,P_baslamatarihi) values (" + txt_ad.Text+ ",'" + txt_soyad.Text + "','" + txt_il.Text + "','" + txt_ilce.Text + "','" + txt_mahalle.Text + "','"+ txt_acikadres.Text + "','" + txt_numarası.Text + "','" + cmb_sube.SelectedIndex + "','" + txt_maas.Text + "','" + cmb_mevki.SelectedItem + "','" + txt_izingunu.Text + "','" + txt_yillikizin.Text + "','" + txt_tarih.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
        }
    }
}
