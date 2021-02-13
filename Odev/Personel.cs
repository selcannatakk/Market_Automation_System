using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public class Personel
    {
        public string per_ad { get; set; } 
        public string per_soyad { get; set; } 
        public int per_id { get; set; } 
        public Adres per_adres { get; set; } 
        public string per_numara { get; set; }
        public int per_sube_id { get; set; }
        public int per_maas { get; set; } 
        public string per_izin_günü { get; set; }
        public int per_yillik_izin { get; set; } 
        public string per_zaman { get; set; } 
        public string per_mevki { get; set; } 
        public Personel()
        {
            this.per_adres = new Adres();
        }
        public Label PersonelAdiYazdır(int top)
        {
            FormClass sinif = new FormClass();
            return sinif.ClassLabel(40, top, 50, per_ad);
        }
        public Label PersonelSoyadYazdır(int top)
        {
            FormClass sinif = new FormClass();
            return sinif.ClassLabel(100, top, 50, per_soyad);
        }
        public Label PersonelAdresYazdır(int top)
        {
            FormClass sinif = new FormClass();
            string text = per_adres.il + per_adres.ilce + per_adres.mahalle + per_adres.acik_adres;
            return sinif.ClassLabel(160, top, 250, text);
        }
        public Label PersonelNumaraYazdır(int top)
        {
            FormClass sinif = new FormClass();
            return sinif.ClassLabel(420, top, 75, per_numara.ToString());
        }
        public Label PersonelMevkiYazdır(int top)
        {
            FormClass sinif = new FormClass();
            return sinif.ClassLabel(505, top, 100, per_mevki);
        }
        public Label PersonelMaasYazdır(int top)
        {
            FormClass sinif = new FormClass();
            return sinif.ClassLabel(615, top, 75, per_maas.ToString());
        }
        public Label PersonelizinGunuYazdır(int top)
        {
            FormClass sinif = new FormClass();
            return sinif.ClassLabel(700, top, 75, per_izin_günü);
        }
        public Label PersonelYillikizinYazdır(int top)
        {
            FormClass sinif = new FormClass();
            return sinif.ClassLabel(785, top, 50, per_yillik_izin.ToString());
        }
        public Label PersonelBaslamaTarihYazdır(int top)
        {
            FormClass sinif = new FormClass();
            return sinif.ClassLabel(845, top, 100, per_zaman.ToString());
        }
        public Button PersonelDuzenButon(int top, string mevki)
        {
            FormClass sinif = new FormClass();
            return sinif.ClassButton(970, top, 75, "düzenle_"+mevki, "personel", per_id);
        }
    }

    public class Yonetici : Personel
    {
        public int yonetici_sifre = 12345;
    }
    public class Mudur : Personel
    {
        public int mudur_sifre = 23456;
    }
    public class MudurYardimcisi : Personel
    {
        public int muduryardimcisi_sifre = 56789;
    }
    public class Kasiyer : Personel
    {
        public int kasiyer_sifre = 34567;
    }
}
