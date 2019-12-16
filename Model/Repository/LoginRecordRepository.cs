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
    }
}
