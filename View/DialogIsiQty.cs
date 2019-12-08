using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemOrderMenuRestoran.View {
    public partial class DialogIsiQty : MetroFramework.Forms.MetroForm {
        int jumlah = 1;
        int mHarga = 0;
        public DialogIsiQty() {
            InitializeComponent();
        }

        public DialogIsiQty(string nama, int harga) : this() {
            mHarga = harga;
            l_menu.Text = nama;
            l_total.Text = countHarga();
        }

        private void b_plus_Click(object sender, EventArgs e) {
            l_jumlah.Text = "" + (++jumlah);
            l_total.Text = countHarga();
        }

        private void b_min_Click(object sender, EventArgs e) {
            l_jumlah.Text = "" + (--jumlah);
            l_total.Text = countHarga();
        }

        string countHarga() { 
            return "Rp"+((mHarga*jumlah).ToString("#,##0"));
        }
    }
}
