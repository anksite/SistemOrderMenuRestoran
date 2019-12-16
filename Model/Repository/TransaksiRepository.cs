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
    class TransaksiRepository {
        SqlConnection conn;

        public TransaksiRepository(DbContext context) {
            conn = context.Conn;
        }

        public int Create(string note, string status, string idPegawai) {
            int idTransaksi = 0;

            string sql = @"INSERT INTO transaksi OUTPUT Inserted.ID 
                           VALUES(CURRENT_TIMESTAMP, @note, @status, @idPegawai)";

            using (SqlCommand cmd = new SqlCommand(sql, conn)) {
                cmd.Parameters.AddWithValue("@note", note);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@idPegawai", idPegawai);

                try {
                    using (SqlDataReader sdr = cmd.ExecuteReader()) {
                        if (sdr.Read()) {
                            idTransaksi = Convert.ToInt32(sdr["ID"]);
                        }
                    }
                } catch (Exception e) {
                    Debug.Print("Create error: {0}", e.Message);
                }
            }
            return idTransaksi;
        }
    }
}
