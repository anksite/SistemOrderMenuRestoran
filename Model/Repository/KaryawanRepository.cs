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
    class KaryawanRepository {
        SqlConnection conn;

        public KaryawanRepository(DbContext context) {
            conn = context.Conn;
        }

        public string ReadLogin(string id, string pass) {
            var role = "";
            try {
                string sql = "SELECT role FROM karyawan WHERE id='"+id+"' AND password = '"+pass+"'";

                using (SqlCommand cmd = new SqlCommand(sql, conn)) {
                    using (SqlDataReader dtr = cmd.ExecuteReader()) {
                        if (dtr.Read()) {
                            role = dtr["role"].ToString();
                        } 
                    }
                }
            } catch (Exception ex) {
                System.Diagnostics.Debug.Print("ReadLogin error: {0}", ex.Message);
            }

            return role;
        }
    }
}
