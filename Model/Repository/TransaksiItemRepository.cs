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
    }
}
