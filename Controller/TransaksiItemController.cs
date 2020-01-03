using MetroFramework;
using SistemOrderMenuRestoran.Model.Context;
using SistemOrderMenuRestoran.Model.Entity;
using SistemOrderMenuRestoran.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemOrderMenuRestoran.Controller
{
    class TransaksiItemController {
        TransaksiItemRepository repo;

        public int Create(int idTransaksi, string idMenu, int qty) {
            int result = 0;

            using (DbContext context = new DbContext()) {
                repo = new TransaksiItemRepository(context);
                result = repo.Create(idTransaksi, idMenu, qty);
            }
            return result;
        }

        public List<TransaksiItem> ReadById(string id) {
            List<TransaksiItem> listItem;

            using (DbContext context = new DbContext()) {
                repo = new TransaksiItemRepository(context);
                listItem = repo.ReadById(id);
            }

            return listItem;
        }
    }
}
