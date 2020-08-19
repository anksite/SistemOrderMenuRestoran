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
    class LoginRecordRepository {
        SqlConnection conn;

        public LoginRecordRepository(DbContext context) {
            conn = context.Conn;
        }

        public int Create(string id) {
            int result = 0;
            
            string sql = "INSERT INTO login_record VALUES(@id, CURRENT_TIMESTAMP)";
           
            using (SqlCommand cmd = new SqlCommand(sql, conn)) {
                cmd.Parameters.AddWithValue("@id", id);

                try {
                    result = cmd.ExecuteNonQuery();
                } catch (Exception ex) {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<LoginRecord> RealAll() {
            List<LoginRecord> listLogin = new List<LoginRecord>();

            string sql = @"select lr.idPegawai, k.nama, lr.waktu 
                            from login_record lr
                            JOIN karyawan k ON k.id = lr.idPegawai
                            ORDER BY lr.waktu DESC";

            try {
                using (SqlCommand cmd = new SqlCommand(sql, conn)) {
                    using (SqlDataReader dtr = cmd.ExecuteReader()) {
                        while (dtr.Read()) {
                            LoginRecord login = new LoginRecord();
                            login.idPegawai = dtr["idPegawai"].ToString();
                            login.nama = dtr["nama"].ToString();
                            login.waktuLogin = dtr["waktu"].ToString();

                            listLogin.Add(login);
                        }
                    }
                }
            } catch (Exception ex) {
                Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return listLogin;
        }
    }
}
