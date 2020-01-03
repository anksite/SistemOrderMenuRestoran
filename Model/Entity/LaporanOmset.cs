using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemOrderMenuRestoran.Model.Entity {
    public class LaporanOmset {
        public string id { get; set; }
        public string nama { get; set; }
        public string jenis { get; set; }
        public int harga { get; set; }
        public int terjual { get; set; }
        public int omset { get; set; }
    }
}
