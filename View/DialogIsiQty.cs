using SistemOrderMenuRestoran.Model.Entity;
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
        int mQty = 1;
        int mHarga = 0;
        string mIdMenu = "";

        public delegate void OnOkeClick(Order order);
        public event OnOkeClick OnOke;

        public DialogIsiQty() {
            InitializeComponent();
        }

        public DialogIsiQty(string idMenu, string nama, int harga) : this() {
            mIdMenu = idMenu;
            mHarga = harga;
            l_menu.Text = nama;
            l_total.Text = countHarga();
        }

        private void b_plus_Click(object sender, EventArgs e) {
            l_jumlah.Text = "" + (++mQty);
            l_total.Text = countHarga();
        }

        private void b_min_Click(object sender, EventArgs e) {
            l_jumlah.Text = "" + (--mQty);
            l_total.Text = countHarga();
        }

        string countHarga() { 
            return "Rp"+((mHarga*mQty).ToString("#,##0"));
        }

        private void b_ok_Click(object sender, EventArgs e) {
            Order order = new Order();
            order.idMenu = mIdMenu;
            order.nama = l_menu.Text;
            order.harga = mHarga;
            order.qty = mQty;
            OnOke(order);
            Close();
        }
    }
}
