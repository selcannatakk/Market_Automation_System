using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class form_secim : Form
    {
        public string mevki;
        public form_secim()
        {
            InitializeComponent();
        }
        private void btn_sube_Click(object sender, EventArgs e)
        {
            form_subeler FormSubeler = new form_subeler();
            FormSubeler.mevki = this.mevki;
            FormSubeler.Show();
            this.Hide();
        }

        private void btn_tedarik_Click(object sender, EventArgs e)
        {
            form_tedarikciler FormTedarikciler = new form_tedarikciler();
            FormTedarikciler.Show();
            this.Hide();
        }

        private void form_secim_Load(object sender, EventArgs e)
        {
        }
    }
}
