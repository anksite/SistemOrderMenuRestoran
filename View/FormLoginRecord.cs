using MetroFramework.Forms;
using SistemOrderMenuRestoran.Controller;
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

namespace SistemOrderMenuRestoran.View
{
    public partial class FormLoginRecord : MetroForm
    {
        public FormLoginRecord()
        {
            InitializeComponent();
            InisialisasiListView();
            LoadData();
        }

        private void InisialisasiListView() {
            lv_loginRecord.View = System.Windows.Forms.View.Details;
            lv_loginRecord.Columns.Add("ID Pegawai", 130, HorizontalAlignment.Left);
            lv_loginRecord.Columns.Add("Nama", 130, HorizontalAlignment.Center);
            lv_loginRecord.Columns.Add("Waktu Login", 130, HorizontalAlignment.Center);
        }

        private void LoadData() {
            lv_loginRecord.Items.Clear();

            List<LoginRecord> listLogin = new List<LoginRecord>();
            listLogin = new LoginRecordController().RealAll();

            int totalOmset = 0;

            foreach (var login in listLogin) {
                var item = new ListViewItem(login.idPegawai);
                item.SubItems.Add(login.nama);
                item.SubItems.Add(login.waktuLogin);
                lv_loginRecord.Items.Add(item);
            }
        }
    }
}
