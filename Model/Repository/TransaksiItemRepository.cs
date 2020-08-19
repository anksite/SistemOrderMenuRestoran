using SistemOrderMenuRestoran.Model.Context;
using SistemOrderMenuRestoran.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemOrderMenuRestoran.Model.Repository {
    class TransaksiItemRepository {
        SqlConnection conn;

        public TransaksiItemRepository(DbContext context) {
            conn = context.Conn;
        }

        public int Create(int idTransaksi, string idMenu, int qty) {
            int result = 0;

            string sql = "INSERT INTO transaksi_item VALUES(@idTransaksi, @idMenu, @qty)";

            using (SqlCommand cmd = new SqlCommand(sql, conn)) {
                cmd.Parameters.AddWithValue("@idTransaksi", idTransaksi);
                cmd.Parameters.AddWithValue("@idMenu", idMenu);
                cmd.Parameters.AddWithValue("@qty", qty);
                try {
                    result = cmd.ExecuteNonQuery();
                } catch (Exception ex) {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<TransaksiItem> ReadById(string id) {
            List<TransaksiItem> listItem = new List<TransaksiItem>();

            try {
                string sql = @"SELECT ti.id_transaksi, m.nama, m.harga, ti.qty 
                                FROM transaksi_item ti
                                JOIN menu m ON ti.id_menu = m.id
                                WHERE ti.id_transaksi = " + id;

                using (SqlCommand cmd = new SqlCommand(sql, conn)) {
                    using (SqlDataReader dtr = cmd.ExecuteReader()) {
                        while (dtr.Read()) {
                            TransaksiItem item = new TransaksiItem();
                            item.idTransaksi    = dtr["id_transaksi"].ToString();
                            item.namaMenu       = dtr["nama"].ToString();
                            item.harga          = Convert.ToInt32(dtr["harga"].ToString());
                            item.qty            = Convert.ToInt32(dtr["qty"].ToString());

                            listItem.Add(item);
                        }
                    }
                }
            } catch (Exception ex) {
                System.Diagnostics.Debug.Print("ReadById error: {0}", ex.Message);
            }

            return listItem;
        }
    }
}
