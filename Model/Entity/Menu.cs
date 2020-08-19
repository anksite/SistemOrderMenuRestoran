using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemOrderMenuRestoran.Model.Entity {
    public class Menu {
        public string id { get; set; }
        public string nama { get; set; }
        public string jenis { get; set; }
        public int harga { get; set; }

        public String DcKategori(int index) {
            string ktg = "unknown";
            switch (index) {
                case 0:
                    ktg = "makan";
                    break;
                case 1:
                    ktg = "minum";
                    break;
                case 2:
                    ktg = "lain";
                    break;
            }
            return ktg;

        }

        public int EcKatagori(String ktg) {
            int result = 0;
            switch (ktg) {
                case "makan":
                    result = 0;
                    break;
                case "minum":
                    result = 1;
                    break;
                case "lain":
                    result = 2;
                    break;
            }
            return result;
        }


    }
}
