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

//using System.Data.SqlClient;

namespace Odev
{
    public partial class form_subeler : Form
    {
        public string mevki;
        public form_subeler()
        {
            InitializeComponent();
        }
        private void btn_geri_Click(object sender, EventArgs e)
        {
            form_secim FormSecim = new form_secim();
            FormSecim.Show();
            this.Hide();
        }

        private void form_subeler_Load(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection(@"Data Source=127.0.0.1; Database=stokatkip;User ID=root; Password=");
            baglanti.Open();
            MySqlDataAdapter komut = new MySqlDataAdapter("Select * from subeler", baglanti);
            DataTable tablo = new DataTable();
            komut.Fill(tablo);
            int top = 155;
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                Sube sube = new Sube();
                sube.id = (int)tablo.Rows[i][0];
                sube.ad = tablo.Rows[i][1].ToString();
                sube.adres.il = tablo.Rows[i][2].ToString();
                sube.adres.ilce = tablo.Rows[i][3].ToString();
                sube.adres.mahalle = tablo.Rows[i][4].ToString();
                sube.adres.acik_adres = tablo.Rows[i][5].ToString();
                this.Controls.Add(sube.SubeAdiYazdir(top));
                this.Controls.Add(sube.SubeAdresYazdir(top));
                this.Controls.Add(sube.SubeUrunButon(top,this.mevki));
                this.Controls.Add(sube.SubeCalisanButon(top,this.mevki));
                top += 30;

            }
            komut.Dispose();
            baglanti.Close();

        }
        public void ButonClick(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection(@"Data Source=127.0.0.1; Database=stokatkip;User ID=root; Password=");
            baglanti.Open();
            Button dinamikButon = (sender as Button);
            string[] yer = dinamikButon.Name.Split('_');
            string text = dinamikButon.Text;
            if (text == "ürünler")
            {
                form_urunler yeniform = new form_urunler();
                yeniform.gelenyer = yer[0];
                yeniform.gelenid = Convert.ToInt32(yer[1]);
                yeniform.mevki = yer[2];
                yeniform.Show();
                MySqlCommand komut = new MySqlCommand("UPDATE sonsube SET SS_id='" + yer[1] + "'", baglanti);
                komut.ExecuteNonQuery();
            }
            else if (text == "çalışanlar")
            {
                form_personeller yeniform = new form_personeller();
                yeniform.gelenyer = yer[0];
                yeniform.gelenid = Convert.ToInt32(yer[1]);
                yeniform.mevki = yer[2];
                yeniform.Show();
                this.Hide();
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            form_suebekle sube = new form_suebekle();
            sube.Show();
        }
    }
}
