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
    public partial class form_tedarikciler : Form
    {
        public form_tedarikciler()
        {
            InitializeComponent();
        }
        public void ButonClick(object sender, EventArgs e) {
            Button dinamikButon = (sender as Button);
            string[] yer = dinamikButon.Name.Split('_');
            string text = dinamikButon.Text;
            form_urunler yeniform = new form_urunler();
            yeniform.gelenyer = yer[0];
            yeniform.gelenid = Convert.ToInt32(yer[1]);
            yeniform.Show();
            this.Hide();
        }
        private void btn_geri_Click(object sender, EventArgs e)
        {
            form_secim FormSecim = new form_secim();
            FormSecim.Show();
            this.Hide();
        }

        private void form_tedarikciler_Load(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection(@"Data Source=127.0.0.1; Database=stokatkip;User ID=root; Password=");
            baglanti.Open();
            MySqlDataAdapter komut = new MySqlDataAdapter("Select * from tedarikci", baglanti);
            DataTable tablo = new DataTable();
            komut.Fill(tablo);

            int top = 155;
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                Tedarikci tedarikci = new Tedarikci();
                tedarikci.id = (int)tablo.Rows[i][0];
                tedarikci.ad = tablo.Rows[i][1].ToString();
                tedarikci.adres.il = tablo.Rows[i][4].ToString();
                tedarikci.adres.ilce = tablo.Rows[i][5].ToString();
                tedarikci.adres.mahalle = tablo.Rows[i][6].ToString();
                tedarikci.adres.acik_adres = tablo.Rows[i][7].ToString();
                tedarikci.urun.id = (int)tablo.Rows[i][2];
                tedarikci.urun.ad = tablo.Rows[i][3].ToString();
                this.Controls.Add(tedarikci.TedarikciAdiYazdir(top));
                this.Controls.Add(tedarikci.TedarikciAdresYazdir(top));
                this.Controls.Add(tedarikci.TedarikciUrunButon(top));
                top += 30;
;            }
            komut.Dispose();
            baglanti.Close();

        }
        // SqlConnection baglanti = new SqlConnection("Data Source=demet;Initial Catalog=MarketYonetimSistemi;Integrated Security=True");
        private void btn_tedarikciurunleri_Click(object sender, EventArgs e)
        {
        }
    }
}
