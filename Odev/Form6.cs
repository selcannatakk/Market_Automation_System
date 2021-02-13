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
    public partial class form_personeller : Form
    {
        public string gelenyer;
        public int gelenid;
        public string mevki;
        public form_personeller()
        {
            InitializeComponent();
        }
        public void ButonClick(object sender, EventArgs e) {
            Button dinamikButon = (sender as Button);
            string[] yer = dinamikButon.Name.Split('_');
            string text = dinamikButon.Text;
            if (yer[2] == "Yönetici")
            {
                form_personel yeniform = new form_personel();
                yeniform.gelenyer = yer[0];
                yeniform.gelenid = Convert.ToInt32(yer[1]);
                yeniform.Show();
            }
            else
            {
                MessageBox.Show("Personel  düzenleme yetkiniz bulunmamaktadır!");
            }
        }
        private void form_personeller_Load(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection(@"Data Source=127.0.0.1; Database=stokatkip;User ID=root; Password=");
            baglanti.Open();
            MySqlDataAdapter komut = new MySqlDataAdapter("Select * from personel", baglanti);
            DataTable tablo = new DataTable();
            komut.Fill(tablo);
            int top = 155;
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                string[] buguntarih, baslamatarihi;
                string tarih = DateTime.Today.ToShortDateString();
                buguntarih = tarih.Split('.');
                string baslatarih = tablo.Rows[i][13].ToString().Split(' ')[0];
                baslamatarihi = baslatarih.Split('.');
                int yilaralik = Convert.ToInt32(buguntarih[2]) - Convert.ToInt32(baslamatarihi[2]);
                int ayaralik = Convert.ToInt32(buguntarih[1]) - Convert.ToInt32(baslamatarihi[1]);
                if (ayaralik < 0) { ayaralik = (12 - Convert.ToInt32(baslamatarihi[1])) + Convert.ToInt32(buguntarih[2]); }
                Personel per = new Personel();
                per.per_ad = tablo.Rows[i][1].ToString();
                per.per_soyad = tablo.Rows[i][2].ToString();
                per.per_id = (int)tablo.Rows[i][0];
                per.per_adres.il = tablo.Rows[i][3].ToString();
                per.per_adres.ilce = tablo.Rows[i][4].ToString();
                per.per_adres.mahalle = tablo.Rows[i][5].ToString();
                per.per_adres.acik_adres = tablo.Rows[i][6].ToString();
                per.per_sube_id = (int)tablo.Rows[i][8];
                per.per_numara = tablo.Rows[i][7].ToString();
                per.per_maas = (int)tablo.Rows[i][9];
                per.per_izin_günü = tablo.Rows[i][11].ToString();
                per.per_yillik_izin = (int)tablo.Rows[i][12];
                per.per_zaman = yilaralik + " yıl " + ayaralik + " ay";
                per.per_mevki = tablo.Rows[i][10].ToString();
                if (this.gelenid == Convert.ToInt32(tablo.Rows[i][8])) {
                    this.Controls.Add(per.PersonelAdiYazdır(top));
                    this.Controls.Add(per.PersonelSoyadYazdır(top));
                    this.Controls.Add(per.PersonelAdresYazdır(top));
                    this.Controls.Add(per.PersonelNumaraYazdır(top));
                    this.Controls.Add(per.PersonelMaasYazdır(top));
                    this.Controls.Add(per.PersonelizinGunuYazdır(top));
                    this.Controls.Add(per.PersonelYillikizinYazdır(top));
                    this.Controls.Add(per.PersonelBaslamaTarihYazdır(top));
                    this.Controls.Add(per.PersonelMevkiYazdır(top));
                    this.Controls.Add(per.PersonelDuzenButon(top,this.mevki));
                    top += 30;
                }
            }
            komut.Dispose();
            baglanti.Close();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            form_subeler geri = new form_subeler();
            geri.Show();
            this.Hide();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            form_personelekle personel = new form_personelekle();
            personel.Show();
        }
    }
}
