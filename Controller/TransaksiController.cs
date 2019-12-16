using SistemOrderMenuRestoran.Model.Context;
using SistemOrderMenuRestoran.Model.Entity;
using SistemOrderMenuRestoran.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemOrderMenuRestoran.Controller
{
    class TransaksiController {
        TransaksiRepository repo;

        public int Create(string note, string status, string idPegawai) {
            int idTransaksi = 0;

            using (DbContext context = new DbContext()) {
                repo = new TransaksiRepository(context);
                idTransaksi = repo.Create(note, status, idPegawai);
            }
            return idTransaksi;
        }
    }
}
