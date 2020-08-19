using MetroFramework;
using SistemOrderMenuRestoran.Model.Context;
using SistemOrderMenuRestoran.Model.Entity;
using SistemOrderMenuRestoran.Model.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemOrderMenuRestoran.Controller
{
    class TransaksiController {
        TransaksiRepository repo;
        IWin32Window mContext;

        public TransaksiController(IWin32Window context) {
            mContext = context;
        }

        public int Create(string note, string status, string idPegawai) {
            int idTransaksi = 0;

            using (DbContext context = new DbContext()) {
                repo = new TransaksiRepository(context);
                idTransaksi = repo.Create(note, status, idPegawai);
            }
            return idTransaksi;
        }

        public string ReadStatus(string id) {
            string status = "";

            using (DbContext context = new DbContext()) {
                repo = new TransaksiRepository(context);
                status = repo.ReadStatus(id);
            }

            if (status == "NULL") {
                MetroMessageBox.Show(mContext, "Pesanan tidak ditemukan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else if (status != "DIPESAN") {
                MetroMessageBox.Show(mContext, "Pesanan sudah dibayar!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return status;
        }

        public List<Pesanan> ReadDapur(string status) {
            using (DbContext context = new DbContext()) {
                repo = new TransaksiRepository(context);
                return repo.ReadDapur(status);
            }
        }

        public int Update(string status, string id) {
            int idTransaksi = 0;

            using (DbContext context = new DbContext()) {
                repo = new TransaksiRepository(context);
                idTransaksi = repo.Update(status, id);
            }
            return idTransaksi;
        }
    }
}
