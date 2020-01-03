using SistemOrderMenuRestoran.Controller;
using SistemOrderMenuRestoran.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemOrderMenuRestoran.View
{
    //SAEFUL
    public partial class FormDapur : MetroFramework.Forms.MetroForm {
        TransaksiController controller;
        List<Pesanan> listAntrian;
        List<Pesanan> listDimasak;

        public FormDapur()
        {
            InitializeComponent();
            InisialisasiListView();
            controller = new TransaksiController(this);
            LoadData();
        }

        private void InisialisasiListView() {
            lv_antrian.View = System.Windows.Forms.View.Details;
            lv_antrian.Columns.Add("No. Pesanan", 100, HorizontalAlignment.Left);
            lv_antrian.Columns.Add("Jumlah Item", 100, HorizontalAlignment.Center);
            lv_antrian.Columns.Add("Note", 280, HorizontalAlignment.Center);

            lv_dimasak.View = System.Windows.Forms.View.Details;
            lv_dimasak.Columns.Add("No. Pesanan", 100, HorizontalAlignment.Left);
            lv_dimasak.Columns.Add("Jumlah Item", 100, HorizontalAlignment.Center);
            lv_dimasak.Columns.Add("Note", 280, HorizontalAlignment.Center);
        }

        void LoadData() {
            lv_antrian.Items.Clear();
            lv_dimasak.Items.Clear();

            listAntrian = controller.ReadDapur("DIBAYAR");
            listDimasak = controller.ReadDapur("DIMASAK");

            foreach (var antrian in listAntrian) {
                var item = new ListViewItem(antrian.id);
                item.SubItems.Add(antrian.item);
                item.SubItems.Add(antrian.note);
                lv_antrian.Items.Add(item);
            }

            foreach (var dimasak in listDimasak) {
                var item = new ListViewItem(dimasak.id);
                item.SubItems.Add(dimasak.item);
                item.SubItems.Add(dimasak.note);
                lv_dimasak.Items.Add(item);
            }
        }

        private void lv_antrian_Click(object sender, EventArgs e) {
            string id = listAntrian[lv_antrian.SelectedIndices[0]].id;
            string note = listAntrian[lv_antrian.SelectedIndices[0]].note;
            FormDapurDetail form = new FormDapurDetail(id, note, "ANTRIAN");
            form.onStatusChange += OnStatusChange;
            form.Show();
        }

        private void lv_dimasak_Click(object sender, EventArgs e) {
            string id = listDimasak[lv_dimasak.SelectedIndices[0]].id;
            string note = listDimasak[lv_dimasak.SelectedIndices[0]].note;
            FormDapurDetail form = new FormDapurDetail(id, note, "DIMASAK");
            form.onStatusChange += OnStatusChange;
            form.Show();
        }

        void OnStatusChange() {
            LoadData();
        }
    }
}
