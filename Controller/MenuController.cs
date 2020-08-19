using SistemOrderMenuRestoran.Model.Context;
using SistemOrderMenuRestoran.Model.Entity;
using SistemOrderMenuRestoran.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemOrderMenuRestoran.Controller
{
    public class MenuController
    {
        MenuRepository repo;
        public List<Menu> ReadMakanan(){
            List<Menu> listMenu = new List<Menu>();

            using (DbContext context = new DbContext()){
                repo = new MenuRepository(context);
                listMenu = repo.ReadMakanan();
            }

            return listMenu;
        }

        public List<Menu> ReadMinum()
        {
            List<Menu> listMenu = new List<Menu>();

            using (DbContext context = new DbContext())
            {
                repo = new MenuRepository(context);
                listMenu = repo.ReadMinum();
            }

            return listMenu;
        }

        public List<Menu> ReadLain()
        {
            List<Menu> listMenu = new List<Menu>();

            using (DbContext context = new DbContext())
            {
                repo = new MenuRepository(context);
                listMenu = repo.ReadLain();
            }

            return listMenu;
        }

        public List<Menu> CariMakanan(string key)
        {
            List<Menu> listMenu = new List<Menu>();

            using (DbContext context = new DbContext())
            {
                repo = new MenuRepository(context);
                listMenu = repo.CariMakanan(key);
            }

            return listMenu;
        }

        public List<Menu> CariMinum(string key)
        {
            List<Menu> listMenu = new List<Menu>();

            using (DbContext context = new DbContext())
            {
                repo = new MenuRepository(context);
                listMenu = repo.CariMinum(key);
            }

            return listMenu;
        }

        public List<Menu> CariLain(string key)
        {
            List<Menu> listMenu = new List<Menu>();

            using (DbContext context = new DbContext())
            {
                repo = new MenuRepository(context);
                listMenu = repo.CariLain(key);
            }

            return listMenu;
        }

        public List<LaporanOmset> ReadLaporanOmset() {
            List<LaporanOmset> listMenu = new List<LaporanOmset>();
            using (DbContext context = new DbContext()) {
                repo = new MenuRepository(context);
                return repo.ReadLaporanOmset();
            }
        }
    }
}
