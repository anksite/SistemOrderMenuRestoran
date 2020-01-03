using SistemOrderMenuRestoran.Model.Context;
using SistemOrderMenuRestoran.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public string ReadStatus(string id) {
            string status = "";
            string sql = "SELECT status FROM transaksi WHERE id = " + id;

            using (SqlCommand cmd = new SqlCommand(sql, conn)) {
                using (SqlDataReader dtr = cmd.ExecuteReader()) {
                    status = dtr.Read() ? dtr["status"].ToString() : "NULL";
                }
            }

            return status;
        }

        public List<Pesanan> ReadDapur(string status) {
            List<Pesanan> listPesanan = new List<Pesanan>();

            string sql = @"SELECT id, item.item, note
                            FROM transaksi
                            JOIN (SELECT id_transaksi,SUM(qty) item
	                            FROM transaksi_item 
	                            GROUP BY id_transaksi) item ON item.id_transaksi = transaksi.id  
                            WHERE status = @status";

            try {
                using (SqlCommand cmd = new SqlCommand(sql, conn)) {
                    cmd.Parameters.AddWithValue("status", status);

                    using (SqlDataReader dtr = cmd.ExecuteReader()) {
                        while (dtr.Read()) {
                            Pesanan pesanan = new Pesanan();
                            pesanan.id = dtr["id"].ToString();
                            pesanan.item = dtr["item"].ToString();
                            pesanan.note = dtr["note"].ToString();

                            listPesanan.Add(pesanan);
                        }
                    }
                       
                }
            } catch (Exception e) {
                Debug.Print("ReadDapur error: {0}", e.Message);
            }

            return listPesanan;
        }


        public int Update(string status, string id) {
            int result = 0;

            string sql = @"UPDATE transaksi SET status = @status
                            WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(sql, conn)) {
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", id);

                try {
                    result = cmd.ExecuteNonQuery();
                } catch (Exception ex) {
                   Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result;
        }

    }
}
