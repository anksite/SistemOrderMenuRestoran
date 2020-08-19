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
    class MenuRepository {
        SqlConnection _conn;

        public MenuRepository(DbContext context) {
            _conn = context.Conn;
        }

        public int Create(Menu items) {
            int result = 0;

            string sql = @"insert into menu(id, nama, harga, jenis) values(@id_menu, @nama, @harga, @jenis)";

            using (SqlCommand cmd = new SqlCommand(sql, _conn)) {
                cmd.Parameters.AddWithValue("@id_menu", items.id);
                cmd.Parameters.AddWithValue("@nama", items.nama);
                cmd.Parameters.AddWithValue("@harga", items.harga);
                cmd.Parameters.AddWithValue("@jenis", items.jenis);
                //cmd.Parameters.AddWithValue("@deskripsi", items.keterangan);

                try {
                    result = cmd.ExecuteNonQuery();
                } catch (Exception ex) {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;
        }
        public int Update(Menu items) {
            int result = 0;

            string sql = @"update menu set nama = @nama , harga = @harga, jenis = @jenis where id = @id_menu";

            using (SqlCommand cmd = new SqlCommand(sql, _conn)) {
                cmd.Parameters.AddWithValue("@id_menu", items.id);
                cmd.Parameters.AddWithValue("@nama", items.nama);
                cmd.Parameters.AddWithValue("@harga", items.harga);
                cmd.Parameters.AddWithValue("@jenis", items.jenis);
                //cmd.Parameters.AddWithValue("@deskripsi", items.keterangan);

                try {
                    result = cmd.ExecuteNonQuery();
                } catch (Exception ex) {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result;
        }


        public int Delete(String id) {
            int result = 0;

            string sql = @"delete from menu where id = @id_menu";

            using (SqlCommand cmd = new SqlCommand(sql, _conn)) {
                cmd.Parameters.AddWithValue("@id_menu", id);
                try {
                    result = cmd.ExecuteNonQuery();
                } catch (Exception ex) {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<ViewMenu> SelectAllEditMenu() {
            List<ViewMenu> list = new List<ViewMenu>();

            try {
                string sql = @"select * from menu";

                using (SqlCommand cmd = new SqlCommand(sql, _conn)) {
                    using (SqlDataReader dta = cmd.ExecuteReader()) {
                        while (dta.Read()) {
                            ViewMenu items = new ViewMenu();

                            items.id = dta["id"].ToString();
                            items.nama = dta["nama"].ToString();
                            items.harga = Convert.ToInt32(dta["harga"]);
                            items.jenis = (dta["jenis"].ToString());
                            //items.keterangan = dta["deskripsi"].ToString();
                            //tems.totalJual = JumlahTerjual(dta["id"].ToString());

                            list.Add(items);
                        }
                    }
                }

            } catch (Exception ex) {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }
            return list;
        }

        public int JumlahTerjual(String idMenu) {
            int total = 0;

            try {
                string sql = @"select sum(qty) as [jumlah] from transaksi_item where id_menu = @id_menu";

                using (SqlCommand cmd = new SqlCommand(sql, _conn)) {
                    cmd.Parameters.AddWithValue("@id_menu", idMenu);
                    using (SqlDataReader dta = cmd.ExecuteReader()) {
                        while (dta.Read()) {
                            total += Convert.ToInt32(dta["jumlah"].ToString());

                        }
                    }
                }

            } catch (Exception ex) {
                System.Diagnostics.Debug.Print("Jumlah Jual error: {0}", ex.Message);
            }
            return total;
        }

        public List<ViewMenu> SelectAllByNameEditMenu(String nama) {
            List<ViewMenu> list = new List<ViewMenu>();

            try {
                string sql = @"select * from menu where nama like '%"+nama+"%'";

                using (SqlCommand cmd = new SqlCommand(sql, _conn)) {
                    using (SqlDataReader dta = cmd.ExecuteReader()) {
                        while (dta.Read()) {
                            ViewMenu items = new ViewMenu();

                            items.id = dta["id"].ToString();
                            items.nama = dta["nama"].ToString();
                            items.harga = Convert.ToInt32(dta["harga"]);
                            items.jenis = (dta["jenis"].ToString());
                            //items.keterangan = dta["deskripsi"].ToString();


                            list.Add(items);
                        }
                    }
                }

            } catch (Exception ex) {
                System.Diagnostics.Debug.Print("ReadbyName error: {0}", ex.Message);
            }
            return list;
        }

        public int Length() {
            int result = 0;

            try {
                string sql = @"select count(*) as [jumlah] from menu";

                using (SqlCommand cmd = new SqlCommand(sql, _conn)) {
                    using (SqlDataReader dta = cmd.ExecuteReader()) {
                        while (dta.Read())
                            result = Convert.ToInt32(dta["jumlah"].ToString());
                    }
                }

            } catch (Exception ex) {
                System.Diagnostics.Debug.Print("length error: {0}", ex.Message);
            }
            return result;
        }

        public List<String> IdChacker() {
            List<String> list = new List<String>();

            try {
                string sql = @"select id from menu";

                using (SqlCommand cmd = new SqlCommand(sql, _conn)) {

                    using (SqlDataReader dta = cmd.ExecuteReader()) {
                        while (dta.Read()) {


                            String id = dta["id"].ToString();



                            list.Add(id);
                        }
                    }
                }

            } catch (Exception ex) {
                System.Diagnostics.Debug.Print("IdChack error: {0}", ex.Message);
            }
            return list;
        }

        public List<Menu> ReadMakanan() {
            List<Menu> listMenu = new List<Menu>();

            try {
                string sql = "SELECT * FROM menu WHERE jenis = 'makan'";

                using (SqlCommand cmd = new SqlCommand(sql, _conn)) {
                    using (SqlDataReader dtr = cmd.ExecuteReader()) {
                        while (dtr.Read()) {
                            Menu menu = new Menu();
                            menu.id     = dtr["id"].ToString();
                            menu.nama   = dtr["nama"].ToString();
                            menu.jenis  = dtr["jenis"].ToString();
                            menu.harga  = Convert.ToInt32(dtr["harga"].ToString());

                            listMenu.Add(menu);
                        }
                    }
                }
            } catch (Exception ex) {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return listMenu;
        }

        public List<Menu> ReadMinum()
        {
            List<Menu> listMenu = new List<Menu>();

            try
            {
                string sql = "SELECT * FROM menu WHERE jenis = 'minum'";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Menu menu = new Menu();
                            menu.id = dtr["id"].ToString();
                            menu.nama = dtr["nama"].ToString();
                            menu.jenis = dtr["jenis"].ToString();
                            menu.harga = Convert.ToInt32(dtr["harga"].ToString());

                            listMenu.Add(menu);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return listMenu;
        }

        public List<Menu> ReadLain()
        {
            List<Menu> listMenu = new List<Menu>();

            try
            {
                string sql = "SELECT * FROM menu WHERE jenis = 'lain'";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Menu menu = new Menu();
                            menu.id = dtr["id"].ToString();
                            menu.nama = dtr["nama"].ToString();
                            menu.jenis = dtr["jenis"].ToString();
                            menu.harga = Convert.ToInt32(dtr["harga"].ToString());

                            listMenu.Add(menu);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return listMenu;
        }

        public List<Menu> CariMakanan(string key)
        {
            List<Menu> listMenu = new List<Menu>();

            try
            {
                string sql = "SELECT * FROM menu WHERE jenis = 'makan' AND nama LIKE '%" + key+ "%'";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Menu menu = new Menu();
                            menu.id = dtr["id"].ToString();
                            menu.nama = dtr["nama"].ToString();
                            menu.jenis = dtr["jenis"].ToString();
                            menu.harga = Convert.ToInt32(dtr["harga"].ToString());

                            listMenu.Add(menu);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return listMenu;
        }

        public List<Menu> CariMinum(string key)
        {
            List<Menu> listMenu = new List<Menu>();

            try
            {
                string sql = "SELECT * FROM menu WHERE jenis = 'minum' AND nama LIKE '%" + key + "%'";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Menu menu = new Menu();
                            menu.id = dtr["id"].ToString();
                            menu.nama = dtr["nama"].ToString();
                            menu.jenis = dtr["jenis"].ToString();
                            menu.harga = Convert.ToInt32(dtr["harga"].ToString());

                            listMenu.Add(menu);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return listMenu;
        }

        public List<Menu> CariLain(string key)
        {
            List<Menu> listMenu = new List<Menu>();

            try
            {
                string sql = "SELECT * FROM menu WHERE jenis = 'lain' AND nama LIKE '%" + key + "%'";
                Debug.Print(sql);

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Menu menu = new Menu();
                            menu.id = dtr["id"].ToString();
                            menu.nama = dtr["nama"].ToString();
                            menu.jenis = dtr["jenis"].ToString();
                            menu.harga = Convert.ToInt32(dtr["harga"].ToString());

                            listMenu.Add(menu);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return listMenu;
        }

        public List<LaporanOmset> ReadLaporanOmset() {
            List<LaporanOmset> listMenu = new List<LaporanOmset>();
            try {
                string sql = @"select menu.*, jual.terjual ,menu.harga*jual.terjual as omset from menu
                                JOIN (select ti.id_menu, SUM(ti.qty) terjual  
                                from transaksi_item ti
                                GROUP BY id_menu) jual ON jual.id_menu = menu.id";
                Debug.Print(sql);

                using (SqlCommand cmd = new SqlCommand(sql, _conn)) {
                    using (SqlDataReader dtr = cmd.ExecuteReader()) {
                        while (dtr.Read()) {
                            LaporanOmset menu = new LaporanOmset();
                            menu.id = dtr["id"].ToString();
                            menu.nama = dtr["nama"].ToString();
                            menu.jenis = dtr["jenis"].ToString();
                            menu.harga = Convert.ToInt32(dtr["harga"].ToString());
                            menu.terjual = Convert.ToInt32(dtr["terjual"].ToString());
                            menu.omset = Convert.ToInt32(dtr["omset"].ToString());

                            listMenu.Add(menu);
                        }
                    }
                }
            } catch (Exception ex) {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return listMenu;
        }
    }
}
