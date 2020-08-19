using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemOrderMenuRestoran.Model.Entity
{
    public class Order
    {
        public string idMenu { get; set; }
        public string nama { get; set; }
        public int harga { get; set; }
        public int qty { get; set; }
    }
}
