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
    public partial class form_urunler : Form
    {
        public string gelenyer;
        public int gelenid;
        public string mevki;
        public form_urunler()
        {
            InitializeComponent();
        }
        private void form_urunler_Load(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection(@"Data Source=127.0.0.1; Database=stokatkip;User ID=root; Password=");
            baglanti.Open();
            MySqlDataAdapter komut = new MySqlDataAdapter("Select * from urun", baglanti);
            DataTable tablo = new DataTable();
            komut.Fill(tablo);
            MySqlDataAdapter komut1 = new MySqlDataAdapter("Select * from urundetay", baglanti);
            DataTable tablo1 = new DataTable();
            komut1.Fill(tablo1);
            int top = 155;
            Urun urun = new Urun();
            
            if (gelenyer=="tedarikci") {
                
                urun.id = (int)tablo.Rows[gelenid-1][0];
                urun.ad = tablo.Rows[gelenid-1][1].ToString();
                this.Controls.Add(urun.UrunAdiYazdir2(top));
                this.Controls.Add(urun.UrunIdYazdir(top));
                
            }
            else
            {
                for (int i = 0; i < tablo1.Rows.Count; i++)
                {
                    if (gelenid== (int)tablo1.Rows[i][1]) 
                    {
                        urun.id = (int)tablo1.Rows[i][0];
                        for (int x = 1; x <= tablo.Rows.Count; x++)
                        {
                            if ((int)tablo1.Rows[i][0] == x) { urun.ad = tablo.Rows[x - 1][1].ToString(); }
                        }
                        urun.urunler.sube_id = (int)tablo1.Rows[i][1];
                        urun.urunler.stok_miktari = (int)tablo1.Rows[i][2];
                        urun.urunler.fiyat = (int)tablo1.Rows[i][3];
                        urun.urunler.son_indirim_tarihi = Convert.ToDateTime(tablo1.Rows[i][4]);
                        this.Controls.Add(urun.UrunAdiYazdir(top));
                        this.Controls.Add(urun.urunler.UrunStokMiktariYazdir(top));
                        this.Controls.Add(urun.urunler.UrunFiyatYazdir(top));
                        this.Controls.Add(urun.urunler.UrunTarihYazdir(top));
                        this.Controls.Add(urun.UrunButon(top,this.mevki));
                        top += 30;
                    }
                }
            }
            komut.Dispose();
            baglanti.Close();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (gelenyer == "sube")
            {
                form_subeler geri = new form_subeler();
                geri.Show();
            }
            else
            {
                form_tedarikciler geri = new form_tedarikciler();
                geri.Show();
            }
            
        }
        public void ButonClick(object sender, EventArgs e)
        {
            Button dinamikButon = (sender as Button);
            string[] yer = dinamikButon.Name.Split('_');
            string text = dinamikButon.Text;
            if (yer[2]=="Yönetici" || yer[2] == "Müdür") {
                form_urun yeniform = new form_urun();
                yeniform.gelenyer = yer[0];
                yeniform.gelenid = Convert.ToInt32(yer[1]);
                yeniform.mevki = yer[2];
                yeniform.Show();
            }
            else
            {
                MessageBox.Show("Ürün düzenleme yetkiniz bulunmamaktadır!");
            }
        }
    }
}
