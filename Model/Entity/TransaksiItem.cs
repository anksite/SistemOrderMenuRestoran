using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemOrderMenuRestoran.Model.Entity {
    class TransaksiItem {
        public string idTransaksi { get; set; }
        public string namaMenu { get; set; }
        public string harga { get; set; }
        public string qty { get; set; }
    }
}
