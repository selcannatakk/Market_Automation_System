using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Odev
{
    public class Sube
    {
        public int id { get; set; }
        public string ad { get; set; } 
        public Adres adres { get; set; } 
        public UrunDetay urundetay { get; set; }
        public List<Personel> personel { get; set; }
        public Sube()

        {
            this.adres = new Adres();
            this.urundetay = new UrunDetay();

        }
        public Label SubeAdiYazdir(int top)
        {
            FormClass sinif = new FormClass();
            return sinif.ClassLabel(40, top, 150, ad);
        }
        public Label SubeAdresYazdir(int top)
        {
            FormClass sinif = new FormClass();
            string text = adres.il + adres.ilce + adres.mahalle + adres.acik_adres;
            return sinif.ClassLabel(220, top, 250, text);
        }
        public Button SubeUrunButon(int top,string mevki)
        {
            FormClass sinif = new FormClass();
            return sinif.ClassButton(490, top, 75, "ürünler_"+mevki,"sube",id);
        }
        public Button SubeCalisanButon(int top, string mevki)
        {
            FormClass sinif = new FormClass();
            return sinif.ClassButton(575, top, 70, "çalışanlar_"+mevki, "sube", id);
        }
    }
    public class UrunDetay
    {
        public Urun urun { get; set; }
        public int sube_id { get; set; }
        public int stok_miktari { get; set; }
        public int fiyat { get; set; }
        public DateTime son_indirim_tarihi { get; set; }
        public Label UrunStokMiktariYazdir(int top)
        {
            FormClass sinif = new FormClass();
            return sinif.ClassLabel(210, top, 100, stok_miktari.ToString());
        }
        public Label UrunFiyatYazdir(int top)
        {
            FormClass sinif = new FormClass();
            return sinif.ClassLabel(330, top, 100, fiyat.ToString());
        }
        public Label UrunTarihYazdir(int top)
        {
            FormClass sinif = new FormClass();
            return sinif.ClassLabel(450, top, 100, son_indirim_tarihi.ToString());
        }
    }
}
