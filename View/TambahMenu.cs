using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemOrderMenuRestoran.Model.Entity;
using MetroFramework.Forms;
using System.Windows.Forms;
using MetroFramework;
using SistemOrderMenuRestoran.Controller;
using Menu = SistemOrderMenuRestoran.Model.Entity.Menu;

namespace SistemOrderMenuRestoran.View
{
    public partial class TambahMenu : MetroForm
    {
        public delegate void CreateEditEventHandler(Menu menu);
        public event CreateEditEventHandler OnCreate;
        public event CreateEditEventHandler OnEdit;
        private EditMenuController controller;
        private bool isNewData = true;
        private Menu items;

        public TambahMenu()
        {
            InitializeComponent();
            InitializeKatagori();
        }

        public TambahMenu(string title, EditMenuController controller) : this()
        {
            this.Text = title;
            this.controller = controller;
            this.mTBNama.Focus();
            System.Console.Write( controller.IDGenerate());
        }

        public TambahMenu(string title, Menu menu, EditMenuController controller) : this()
        {
            this.Text = title;
            this.controller = controller;
            this.isNewData = false;
            this.mTBNama.Focus();

            items = menu;

            mTBNama.Text = items.nama;
            mTBHarga.Text = String.Format("" + items.harga);
            System.Console.WriteLine(menu.EcKatagori(menu.jenis).ToString());

            mCBKategori.SelectedIndex = items.EcKatagori(menu.jenis);

        }


        private void InitializeKatagori()
        {
            mCBKategori.Items.Add("Makanan");
            mCBKategori.Items.Add("Minuman");
            mCBKategori.Items.Add("Lain-lain");

            mCBKategori.SelectedIndex = 0;

        }

        private void mBSimpan_Click(object sender, EventArgs e)
        {
            if (isNewData) items = new Menu();


            int result = 0;

            if (isNewData)
            {
                items.id = controller.IDGenerate();
                items.nama = mTBNama.Text;
                if (String.IsNullOrEmpty(mTBHarga.Text)) {
                    items.harga = 0;
                } else {
                    items.harga = Convert.ToInt32(mTBHarga.Text);
                }
                items.jenis = items.DcKategori(mCBKategori.SelectedIndex);
                result = controller.Create(items, this);

                if (result > 0)
                {
                    OnCreate(items);
                    mTBNama.Clear();
                    mTBHarga.Clear();
                    mCBKategori.SelectedIndex = 0;
                    mTBNama.Focus();
                }
                else
                {
                    MetroMessageBox.Show(this, "\nData gagal disimpan", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning, 180);
                }
            }
            else
            {
                items.nama = mTBNama.Text;
                items.harga = Convert.ToInt32(mTBHarga.Text);
                items.jenis = items.DcKategori(mCBKategori.SelectedIndex);
                result = controller.Update(items, this);

                if(result> 0)
                {
                    OnEdit(items);
                    this.Close();
                }
            }


        }
    }
}
