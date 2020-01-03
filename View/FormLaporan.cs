using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using SistemOrderMenuRestoran.Controller;
using SistemOrderMenuRestoran.Model.Entity;

namespace SistemOrderMenuRestoran.View {
    public partial class FormLaporan : MetroForm {
        public FormLaporan() {
            InitializeComponent();
            InisialisasiListView();
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void InisialisasiListView() {
            lv_laporan.View = System.Windows.Forms.View.Details;
            lv_laporan.Columns.Add("ID Menu", 130, HorizontalAlignment.Left);
            lv_laporan.Columns.Add("Nama", 130, HorizontalAlignment.Center);
            lv_laporan.Columns.Add("Jenis", 80, HorizontalAlignment.Center);
            lv_laporan.Columns.Add("Harga", 80, HorizontalAlignment.Center);
            lv_laporan.Columns.Add("Terjual", 80, HorizontalAlignment.Center);
            lv_laporan.Columns.Add("Omset", 80, HorizontalAlignment.Center);
        }

        private void LoadData() {
            lv_laporan.Items.Clear();

            List<LaporanOmset> lo = new List<LaporanOmset>();
            lo = new MenuController().ReadLaporanOmset();

            int totalOmset = 0;

            foreach (var omset in lo) {
                var item = new ListViewItem(omset.id);
                item.SubItems.Add(omset.nama);
                item.SubItems.Add(omset.jenis);
                item.SubItems.Add(""+omset.harga);
                item.SubItems.Add(""+omset.terjual);
                item.SubItems.Add(""+omset.omset);
                lv_laporan.Items.Add(item);

                totalOmset += omset.omset;
            }

            l_totalOmset.Text = "Total Omset: Rp" + totalOmset.ToString("#,##0");
        }

    }
}
