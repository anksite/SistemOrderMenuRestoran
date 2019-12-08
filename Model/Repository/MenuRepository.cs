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
        SqlConnection conn;

        public MenuRepository(DbContext context) {
            conn = context.Conn;
        }

        public List<Menu> ReadMakanan() {
            List<Menu> listMenu = new List<Menu>();

            try {
                string sql = "SELECT * FROM menu WHERE jenis = 'makan'";

                using (SqlCommand cmd = new SqlCommand(sql, conn)) {
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

                using (SqlCommand cmd = new SqlCommand(sql, conn))
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

                using (SqlCommand cmd = new SqlCommand(sql, conn))
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

                using (SqlCommand cmd = new SqlCommand(sql, conn))
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

                using (SqlCommand cmd = new SqlCommand(sql, conn))
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

                using (SqlCommand cmd = new SqlCommand(sql, conn))
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
    }
}
