using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Odev
{
    public class Tedarikci
    {
        public int id { get; set; }
        public string ad { get; set; }
        public Adres adres { get; set; }
        public Urun urun { get; set; }
        public Tedarikci()

        {
            this.adres = new Adres();
            this.urun = new Urun();

        }
        public Label TedarikciAdiYazdir(int top) 
        {
            FormClass sinif= new FormClass();
            return sinif.ClassLabel(40,top,150,ad);
        }
       public Label TedarikciAdresYazdir(int top)
        {
            FormClass sinif = new FormClass();
            string text = adres.il + adres.ilce + adres.mahalle + adres.acik_adres;
            return sinif.ClassLabel(220,top,250,text);
        }
        public Button TedarikciUrunButon(int top)
        {
            FormClass sinif = new FormClass();
            return sinif.ClassButton(490, top, 75, "ürünler","tedarikci",id);
        }
    }
    public class Urun
    {
        public int id { get; set; }
        public string ad { get; set; }
        public UrunDetay urunler { get; set; }
        public Urun()

        {
            this.urunler = new UrunDetay();

        }
        public Label UrunIdYazdir(int top)
        {
            FormClass sinif = new FormClass();
            return sinif.ClassLabel(40, top, 100, id.ToString());
        }
        public Label UrunAdiYazdir2(int top)
        {
            FormClass sinif = new FormClass();
            return sinif.ClassLabel(210, top, 150, ad);
        }
        public Label UrunAdiYazdir(int top)
        {
            FormClass sinif = new FormClass();
            return sinif.ClassLabel(40, top, 150, ad);
        }
        public Button UrunButon(int top,string mevki)
        {
            FormClass sinif = new FormClass();
            return sinif.ClassButton(620, top, 75, "düzenle_"+mevki,"ürün",id);
        }

    }
}
