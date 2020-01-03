using MetroFramework;
using SistemOrderMenuRestoran.Controller;
using SistemOrderMenuRestoran.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemOrderMenuRestoran {
    //ADNAN
    public partial class FormCart : MetroFramework.Forms.MetroForm {
        TransaksiController controllerTrx;
        TransaksiItemController controllerTrxItem;
        List<Order> mListOrder;

        public delegate void OnFinishOrder();
        public event OnFinishOrder onFinishOrder;

        public FormCart() {
            InitializeComponent();
            InisialisasiListView();
            controllerTrx = new TransaksiController(this);
            controllerTrxItem = new TransaksiItemController();
        }

        public FormCart(List<Order> listOrder):this() {
            mListOrder = listOrder;
            int total = 0;
            foreach (var order in mListOrder) {
                int subTotal = order.harga * order.qty;
                total += subTotal;

                var item = new ListViewItem(order.nama);
                item.SubItems.Add(order.qty.ToString());
                item.SubItems.Add("Rp" + subTotal.ToString("#,##0"));
                lv_order.Items.Add(item);
            }
            l_total.Text = "Total: Rp" + total.ToString("#,##0");
        }

        private void InisialisasiListView() {
            lv_order.View = System.Windows.Forms.View.Details;
            lv_order.Columns.Add("Nama", 250, HorizontalAlignment.Left);
            lv_order.Columns.Add("Jumlah", 70, HorizontalAlignment.Center);
            lv_order.Columns.Add("Harga", 95, HorizontalAlignment.Right);
        }

        private void b_order_Click(object sender, EventArgs e) {
            int idTransaksi = controllerTrx.Create(tb_note.Text, "DIPESAN", "NULL");

            foreach (var order in mListOrder) {
               controllerTrxItem.Create(idTransaksi, order.idMenu, order.qty);
            }

            var response = MetroMessageBox.Show(this, "Silahkan ke kasir untuk melakukan pembayaran", "Nomor Pesanan anda "+idTransaksi , MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (""+response == "OK") {
                onFinishOrder();
                this.Close();
            }
        }
    }
}
