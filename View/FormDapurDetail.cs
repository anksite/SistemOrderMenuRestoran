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

namespace SistemOrderMenuRestoran.View {
    public partial class FormDapurDetail : MetroFramework.Forms.MetroForm {

        public delegate void OnStatusChange();
        public event OnStatusChange onStatusChange;
        TransaksiItemController controllerTrxItem;
        TransaksiController controllerTrx;

        string mStatus = "";
        string mId = "";

        public FormDapurDetail() {
            InitializeComponent();
            controllerTrxItem = new TransaksiItemController();
            controllerTrx = new TransaksiController(this);
            rtb_pesanan.Text = "";
        }

        public FormDapurDetail(string id, string note, string status) : this(){
            mId = id;
            this.Text = "No. Pesanan " + mId;
            List<TransaksiItem> listItem = controllerTrxItem.ReadById(id);
            foreach (var item in listItem) {
                rtb_pesanan.Text += " "+item.qty+" "+item.namaMenu+Environment.NewLine;
            }

            rtb_pesanan.Text += Environment.NewLine+" Note: ";
            rtb_pesanan.Text += Environment.NewLine + " " + note;

            mStatus = status;
            l_status.Text = mStatus;
            if (mStatus == "DIMASAK") {
                l_status.ForeColor = Color.Green;
                b_action.Text = "SELESAI";
            }
        }

        private void b_action_Click(object sender, EventArgs e) {
            if (mStatus == "ANTRIAN") {
                mStatus = "DIMASAK";
                l_status.Text = mStatus;
                l_status.ForeColor = Color.Green;
                b_action.Text = "SELESAI";
                controllerTrx.Update("DIMASAK", mId);
            }else if (mStatus == "DIMASAK") {
                controllerTrx.Update("SELESAI", mId);
                this.Close();
            }
            onStatusChange();
        }
    }
}
