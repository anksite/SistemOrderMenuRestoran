using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MetroFramework;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Threading.Tasks;
using SistemOrderMenuRestoran.Model.Entity;
using SistemOrderMenuRestoran.Model.Repository;
using SistemOrderMenuRestoran.Model.Context;
using Menu = SistemOrderMenuRestoran.Model.Entity.Menu;

namespace SistemOrderMenuRestoran.Controller
{
    public class EditMenuController
    {
        private MenuRepository _repository;
        public string IDGenerate()
        {
            List<String> list = new List<string>();
            int length = 0;
            bool notsafe = true;
            string id = "";

            using (DbContext context = new DbContext())
            {
                _repository = new MenuRepository(context);

                length = _repository.Length() + 1;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new MenuRepository(context);

                list = _repository.IdChacker();
            }

            while (notsafe)
            {
                id = Encripcy(length);
                if (list == null)
                {
                    notsafe = false;
                }
                else
                {



                    foreach (string chack in list)
                    {
                        if (id.Equals(chack))
                        {
                            length++;
                            break;
                        }
                        else
                        {
                            Console.WriteLine(chack);
                            notsafe = false;
                        }
                    }
                }
            }

            return id;
        }

        private String Encripcy(int length)
        {
            String id ="";

            if (length < 10 && length != 0)
            {
                id = String.Format("M00" + length);
            }
            else if (length >= 10 && length < 100)
            {
                id = String.Format("M0" + length);
            }
            else if (length >= 100 && length < 1000)
            {
                id = String.Format("M" + length);
            }
            return id;
        }


       

        public int Create(Menu items, MetroForm ctx)
        {
            int result = 0; 
            if (string.IsNullOrEmpty(items.nama))
            {
                MetroMessageBox.Show(ctx, "\nNama tidak boleh kosong", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning, 180);
                return 0;
            }
            if (items.harga == 0)
            {
                MetroMessageBox.Show(ctx, "\nHarga tidak boleh kosong", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning, 180);
                return 0;
            }
            using(DbContext context = new DbContext())
            {
                _repository = new MenuRepository(context);

                result = _repository.Create(items);
            }

            return result;
        }

        public int Update(Menu items, MetroForm ctx )
        {
            int result = 0;
            if (string.IsNullOrEmpty(items.nama))
            {
                MetroMessageBox.Show(ctx, "\nNama tidak boleh kosong", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning, 180);
                return 0;
            }
            if (items.harga == 0)
            {
                MetroMessageBox.Show(ctx, "\nHarga tidak boleh kosong", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning, 180);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new MenuRepository(context);

                result = _repository.Update(items);
            }

            return result;
        }

        public int Delete(Menu items)
        {
            int result = 0;
            using (DbContext context = new DbContext())
            {
                _repository = new MenuRepository(context);

                result = _repository.Delete(items.id);
            }

            return result;
        }
        
        
        public List<ViewMenu> ReadAll()
        {
            List<ViewMenu> list = new List<ViewMenu>();
            using (DbContext context = new DbContext())
            {
                _repository = new MenuRepository(context);

                list = _repository.SelectAllEditMenu();
            }

            return list;
        }

        public List<ViewMenu> ReadByName(String nama, MetroForm ctx)
        {
            List<ViewMenu> list = new List<ViewMenu>();

            if (string.IsNullOrEmpty(nama))
            {
                MetroMessageBox.Show(ctx, "\nNama tidak boleh kosong", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning, 180);
            }
            else
            {
                using (DbContext context = new DbContext())
                {
                    _repository = new MenuRepository(context);

                    list = _repository.SelectAllByNameEditMenu(nama);
                }
            }

            return list;
        }

        public int GetDatajual(String id)
        {
            int result = 0;
            using (DbContext context = new DbContext())
            {
                _repository = new MenuRepository(context);

                result = _repository.JumlahTerjual(id);
            }
            
            return result;
        }
    }
}
