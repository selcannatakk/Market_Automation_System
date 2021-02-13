using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Odev
{
     public class FormClass
    {
       public Label ClassLabel(int left,int top,int width, string label) {
            Label tedarikciadi = new Label();
            tedarikciadi.Name = "lbl_" + label;
            tedarikciadi.Text = label;
            tedarikciadi.Location = new Point(left, top);
            tedarikciadi.Font = new Font("Tahoma", 9);
            tedarikciadi.Width = width;
            return tedarikciadi;
        }
        public Button ClassButton(int left, int top, int width, string text,string yer,int id)
        {
            Button buton = new Button();
            buton.Name = yer +"_"+id;
            buton.Text = text;
            buton.Location = new Point(left, top);
            buton.Font = new Font("Tahoma", 9);
            buton.Width = width;
            buton.Height = 30;
            buton.BackColor = Color.Gainsboro;
            if (yer=="sube") {
                form_subeler form = new form_subeler();
                buton.Text = text.Split('_')[0];
                buton.Name = yer + "_" + id + "_" + text.Split('_')[1];
                buton.Click += form.ButonClick;
            }
            else if (yer=="tedarikci") { 
                form_tedarikciler form = new form_tedarikciler();
                buton.Click += form.ButonClick;
            }
            else if (yer== "ürün") { 
                form_urunler form = new form_urunler();
                buton.Text = text.Split('_')[0];
                buton.Name = yer + "_" + id + "_" + text.Split('_')[1];
                buton.Click += form.ButonClick;
            }
            else if (yer=="personel") { 
                form_personeller form = new form_personeller();
                buton.Text = text.Split('_')[0];
                buton.Name = yer + "_" + id + "_" + text.Split('_')[1];
                buton.Click += form.ButonClick;
            }
            return buton;
        }
    }
}
