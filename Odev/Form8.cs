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
    public partial class form_personel : Form
    {
        public string gelenyer;
        public int gelenid;
        MySqlConnection baglanti = new MySqlConnection(@"Data Source=127.0.0.1; Database=stokatkip;User ID=root; Password=");
        public form_personel()
        {
            InitializeComponent();
        }

        private void form_personel_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlDataAdapter komut = new MySqlDataAdapter("Select * from personel", baglanti);
            DataTable tablo = new DataTable();
            komut.Fill(tablo);
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                if ((int)tablo.Rows[i][0]==gelenid) {
                    string[] buguntarih, baslamatarihi;
                    string tarih = DateTime.Today.ToShortDateString();
                    buguntarih = tarih.Split('.');
                    string baslatarih = tablo.Rows[i][13].ToString().Split(' ')[0];
                    baslamatarihi = baslatarih.Split('.');
                    int yilaralik = Convert.ToInt32(buguntarih[2]) - Convert.ToInt32(baslamatarihi[2]);
                    int ayaralik = Convert.ToInt32(buguntarih[1]) - Convert.ToInt32(baslamatarihi[1]);
                    if (ayaralik < 0) { ayaralik = (12 - Convert.ToInt32(baslamatarihi[1])) + Convert.ToInt32(buguntarih[2]); }
                    lbl_personelad.Text= tablo.Rows[i][1].ToString();
                    lbl_personelsoyad.Text = tablo.Rows[i][2].ToString();
                    txt_numarası.Text = tablo.Rows[i][7].ToString();
                    txt_il.Text = tablo.Rows[i][3].ToString();
                    txt_ilce.Text = tablo.Rows[i][4].ToString();
                    txt_mahalle.Text= tablo.Rows[i][5].ToString();
                    txt_acikadres.Text = tablo.Rows[i][6].ToString();
                    txt_maas.Text= tablo.Rows[i][9].ToString();
                    txt_izingunu.Text= tablo.Rows[i][11].ToString();
                    txt_yillikizin.Text = tablo.Rows[i][12].ToString();
                    lbl_personelisbasla.Text =yilaralik+" yıl "+ayaralik+" ay" ;
                    cmb_sube.SelectedIndex = (int)tablo.Rows[i][8]-1;
                    cmb_mevki.SelectedItem= tablo.Rows[i][10].ToString();
                    
                }
            }
            komut.Dispose();
            baglanti.Close();
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlDataAdapter komutbak = new MySqlDataAdapter("Select * from personel where P_id="+gelenid, baglanti);
            DataTable tablo = new DataTable();
            komutbak.Fill(tablo);
            if(Convert.ToInt32(txt_maas.Text)<(int)tablo.Rows[0][9]) 
            {
                MessageBox.Show("Personel maaşını düşüremezsiniz!");
            }
            if (txt_il.Text=="" || txt_ilce.Text=="" || txt_mahalle.Text=="" || txt_acikadres.Text=="")
            {
                MessageBox.Show("Bu alan baş bırakılamaz!");
            }
            else
            {
                MySqlCommand komut = new MySqlCommand("UPDATE personel SET P_numara='" + txt_numarası.Text + "',P_adresil='" + txt_il.Text + "',P_adresilce='" + txt_ilce.Text + "',P_adresmahalle='" + txt_mahalle.Text + "',P_adresacikadres='" + txt_acikadres.Text + "',P_subeid=" + Convert.ToInt32(cmb_sube.SelectedIndex + 1) + ",P_maas=" + Convert.ToInt32(txt_maas.Text) + ",P_mevki='" + cmb_mevki.SelectedItem + "',P_izingunu='" + txt_izingunu.Text + "',P_yıllıkizin=" + Convert.ToInt32(txt_yillikizin.Text) + " where P_id=" + gelenid, baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Personel bilgileriniz güncellendi.");
            }
            this.Hide();
        }
    }
}
