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
    public partial class form_giris : Form
    {
        public form_giris( )
        {
            InitializeComponent();
        }
        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (txt_sifre.Text=="" || cmb_mevki.SelectedItem==null) {
                MessageBox.Show("Boş bırakılan alanlar var!");
            }
            else
            {
                int secim = cmb_mevki.SelectedIndex, sifre=0;
                switch (secim) {
                    case 0:
                        Yonetici Personel_Yonetici = new Yonetici();
                        sifre = Personel_Yonetici.yonetici_sifre;
                        break;
                    case 1:
                        Mudur Personel_Mudur = new Mudur();
                        sifre = Personel_Mudur.mudur_sifre;
                        break;
                    case 2:
                        MudurYardimcisi Personel_MudurYardimcisi = new MudurYardimcisi();
                        sifre = Personel_MudurYardimcisi.muduryardimcisi_sifre;
                        break;
                    case 3:
                        Kasiyer Personel_Kasiyer = new Kasiyer();
                        sifre = Personel_Kasiyer.kasiyer_sifre;
                        break;
                }
                if (sifre.ToString() == txt_sifre.Text) 
                {
                    form_secim FormSecim = new form_secim();
                    FormSecim.mevki = cmb_mevki.SelectedItem.ToString();
                    FormSecim.Show();
                    this.Hide();
                }
                else
                {
                    cmb_mevki.SelectedIndex = -1;
                    txt_sifre.Text = "";
                    MessageBox.Show("Girilen Şifre Yanlış!!!");
                }
            }
        }

        private void form_giris_Load(object sender, EventArgs e)
        {

        }
    }
}
