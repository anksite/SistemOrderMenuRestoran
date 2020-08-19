using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemOrderMenuRestoran.Model.Entity {
    class Transaksi {
        public string id { get; set; }
        public string tanggal { get; set; }
        public string status { get; set; }
        public string note { get; set; }
        public string idPegawai { get; set; }
    }
}
