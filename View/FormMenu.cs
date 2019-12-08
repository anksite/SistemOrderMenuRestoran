using SistemOrderMenuRestoran.Controller;
using SistemOrderMenuRestoran.Model.Entity;
using SistemOrderMenuRestoran.View;
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
using Menu = SistemOrderMenuRestoran.Model.Entity.Menu;

namespace SistemOrderMenuRestoran {
    //ADNAN
    public partial class FormMenu : MetroFramework.Forms.MetroForm {
        MenuController controller;

        List<Menu> listMakan = new List<Menu>();
        List<Menu> listMinum = new List<Menu>();
        List<Menu> listLain  = new List<Menu>();

        public FormMenu() {
            InitializeComponent();
            controller = new MenuController();
            InisialisasiListView();

            listMakan = controller.ReadMakanan();
            listMinum = controller.ReadMinum();
            listLain  = controller.ReadLain();

            LoadData(listMakan, lv_makan);
            LoadData(listMinum, lv_minum);
            LoadData(listLain, lv_lain);
        }

        private void tb_cari_TextChanged(object sender, EventArgs e) {
            listMakan = controller.CariMakanan(tb_cari.Text);
            listMinum = controller.CariMinum(tb_cari.Text);
            listLain  = controller.CariLain(tb_cari.Text);

            CariData(listMakan, lv_makan);
            CariData(listMinum, lv_minum);
            CariData(listLain, lv_lain);
        }

        private void InisialisasiListView() {
            lv_makan.View = System.Windows.Forms.View.Details;
            lv_makan.Columns.Add("", 154, HorizontalAlignment.Left);
            lv_makan.Columns.Add("", 70, HorizontalAlignment.Center);

            lv_minum.View = System.Windows.Forms.View.Details;
            lv_minum.Columns.Add("", 154, HorizontalAlignment.Left);
            lv_minum.Columns.Add("", 70, HorizontalAlignment.Center);

            lv_lain.View = System.Windows.Forms.View.Details;
            lv_lain.Columns.Add("", 154, HorizontalAlignment.Left);
            lv_lain.Columns.Add("", 70, HorizontalAlignment.Center);
        }

        private void LoadData(List<Menu> listMenu, ListView lv) {
            lv.Items.Clear();

            foreach (var menu in listMenu) {
                var item = new ListViewItem(menu.nama);
                item.SubItems.Add("Rp" + menu.harga.ToString("#,##0"));
                lv.Items.Add(item);
            }
        }

        private void CariData(List<Menu> listMenu, ListView lv) {
            lv.Items.Clear();

            foreach (var menu in listMenu) {
                var item = new ListViewItem(menu.nama);
                item.SubItems.Add("Rp" + menu.harga.ToString("#,##0"));
                lv.Items.Add(item);
            }
        }

        private void lv_makan_Click(object sender, EventArgs e) {
            string nama = listMakan[lv_makan.SelectedIndices[0]].nama;
            int harga = listMakan[lv_makan.SelectedIndices[0]].harga;
            new DialogIsiQty(nama, harga).ShowDialog();
        }
    }
}
