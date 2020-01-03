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

namespace SistemOrderMenuRestoran.View
{
    //DZAKI
    public partial class FormKasir : MetroFramework.Forms.MetroForm {
        int mTotal = 0;
        TransaksiController controllerTrx;
        TransaksiItemController controllerTrxItem;
        public FormKasir()
        {
            InitializeComponent();
            InisialisasiListView();
            resetForm();
            controllerTrxItem = new TransaksiItemController();
            controllerTrx = new TransaksiController(this);
        }

        private void b_cek_Click(object sender, EventArgs e) {
            lv_order.Items.Clear();
            mTotal = 0;
            string status = controllerTrx.ReadStatus(tb_noPesan.Text);
            if (status == "DIPESAN") {
                List<TransaksiItem> listItem = controllerTrxItem.ReadById(tb_noPesan.Text);
                foreach (var trxItem in listItem) {
                    int subTotal = trxItem.harga * trxItem.qty;
                    mTotal += subTotal;

                    var item = new ListViewItem(trxItem.namaMenu);
                    item.SubItems.Add(trxItem.qty.ToString());
                    item.SubItems.Add("Rp" + subTotal.ToString("#,##0"));
                    lv_order.Items.Add(item);
                }
                l_total.Text = "Rp" + mTotal.ToString("#,##0");
            }
        }

        private void b_selesai_Click(object sender, EventArgs e) {
            int result = controllerTrx.Update("DIBAYAR", tb_noPesan.Text);
            if (result == 1) {
                MetroMessageBox.Show(this, "Transaksi Sukses!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetForm();
                lv_order.Items.Clear();
            }
        }

        void resetForm() {
            tb_noPesan.Text = "0";
            l_total.Text = "Rp0";
            tb_dibayar.Text = "";
            l_kembali.Text = "Rp0";
            tb_noPesan.Focus();
        }

        private void tb_dibayar_TextChanged(object sender, EventArgs e) {
            if (tb_dibayar.Text.Length > 0) { 
                int dibayar = Convert.ToInt32(tb_dibayar.Text);
                l_kembali.Text = "Rp" + (dibayar - mTotal).ToString("#,##0");
            }
        }

        private void InisialisasiListView() {
            lv_order.View = System.Windows.Forms.View.Details;
            lv_order.Columns.Add("Nama", 250, HorizontalAlignment.Left);
            lv_order.Columns.Add("Jumlah", 70, HorizontalAlignment.Center);
            lv_order.Columns.Add("Harga", 95, HorizontalAlignment.Right);
        }
    }
}
