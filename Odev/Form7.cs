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
    public partial class form_urun : Form
    {
        public string gelenyer;
        public int gelenid;
        public int gelensubeid;
        public string mevki;
        MySqlConnection baglanti = new MySqlConnection(@"Data Source=127.0.0.1; Database=stokatkip;User ID=root; Password=");
        
        public form_urun()
        {
            InitializeComponent();
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            form_urunler urunler = new form_urunler();
            urunler.Show();
            this.Hide();
        }

        private void form_urun_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlDataAdapter komut = new MySqlDataAdapter("Select * from urun", baglanti);
            DataTable tablo = new DataTable();
            komut.Fill(tablo);
            MySqlDataAdapter komut1 = new MySqlDataAdapter("Select * from urundetay", baglanti);
            DataTable tablo1 = new DataTable();
            komut1.Fill(tablo1);
            MySqlDataAdapter skomut = new MySqlDataAdapter("Select * from sonsube", baglanti);
            DataTable subeid = new DataTable();
            skomut.Fill(subeid);
            for (int i = 0; i < tablo1.Rows.Count; i++)
            {
                if (gelenid == (int)tablo1.Rows[i][0] && (int)subeid.Rows[0][0] == (int)tablo1.Rows[i][1]) 
                {
                    for (int x = 1; x <= tablo.Rows.Count; x++)
                    {
                        if ((int)tablo1.Rows[i][0] == x) { lbl_ad.Text = tablo.Rows[x - 1][1].ToString(); }
                    }
                    text_stok.Text = tablo1.Rows[i][2].ToString();
                    text_fiyat.Text = tablo1.Rows[i][3].ToString();
                    dtp_sonindirim.Text = tablo1.Rows[i][4].ToString();
                    break;
                }
            }
            komut.Dispose();
            baglanti.Close();
        }

        private void btn_ozlbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlDataAdapter skomut = new MySqlDataAdapter("Select * from sonsube", baglanti);
            DataTable subeid = new DataTable();
            skomut.Fill(subeid);
            MySqlDataAdapter urun = new MySqlDataAdapter("Select * from urundetay  where U_id=" + gelenid + " and U_subeid=" + (int)subeid.Rows[0][0],baglanti);
            DataTable surun = new DataTable();
            string[] tarih = dtp_sonindirim.Value.ToString().Split(' ');
            string[] tarihdetay = tarih[0].Split('.');
            string sontarih = tarihdetay[2] + "-" + tarihdetay[1] + "-" + tarihdetay[0] + " " + tarih[1];
            urun.Fill(surun);
            if (this.mevki=="Müdür" && this.gelenid!=3) {
                if (text_fiyat.Text== surun.Rows[0][3].ToString() && dtp_sonindirim.Text==sontarih) {
                    MySqlCommand komut = new MySqlCommand("UPDATE urundetay SET UD_stokmiktari=" + Convert.ToInt32(text_stok.Text) + "' where U_id=" + gelenid + " and U_subeid=" + (int)subeid.Rows[0][0], baglanti);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Fiyat düzenleme yetkiniz bulunmamaktadır!");
                }
            }
            else
            {
                MySqlCommand komut = new MySqlCommand("UPDATE urundetay SET UD_stokmiktari=" + Convert.ToInt32(text_stok.Text) + ",UD_fiyat=" + Convert.ToInt32(text_fiyat.Text) + ",UD_sonindirimtarihi='" + sontarih + "' where U_id=" + gelenid + " and U_subeid=" + (int)subeid.Rows[0][0], baglanti);
                komut.ExecuteNonQuery();
                this.Hide();
            }
        }
    }
}
