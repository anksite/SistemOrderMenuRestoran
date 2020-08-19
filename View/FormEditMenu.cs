using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using SistemOrderMenuRestoran.Controller;
using SistemOrderMenuRestoran.Model.Entity;
using Menu = SistemOrderMenuRestoran.Model.Entity.Menu;

namespace SistemOrderMenuRestoran.View
{
    //HADI
    public partial class FormEditMenu : MetroForm
    {
        private List<ViewMenu> listOfMenu = new List<ViewMenu>();
        private EditMenuController controller;
        public FormEditMenu()
        {
            InitializeComponent();
            InitializenLVEditForm();
            controller = new EditMenuController();
            LoadDataMenu();
        }

        private void InitializenLVEditForm()
        {
            mLVweditForm.View = System.Windows.Forms.View.Details;
            mLVweditForm.FullRowSelect = true;
            mLVweditForm.MultiSelect = false;
            mLVweditForm.GridLines = true;

            mLVweditForm.Columns.Add("ID", 125, HorizontalAlignment.Center);
            mLVweditForm.Columns.Add("Nama", 425, HorizontalAlignment.Center);
            mLVweditForm.Columns.Add("Harga", 130, HorizontalAlignment.Center);
            mLVweditForm.Columns.Add("Terjual", 80, HorizontalAlignment.Center);
        }


        private void LoadDataMenu()
        {
            mLVweditForm.Items.Clear();

            listOfMenu = controller.ReadAll();

            foreach(var items in listOfMenu)
            {
                
                items.totalJual = controller.GetDatajual(items.id);

                ListViewItem list = new ListViewItem(items.id);
                list.SubItems.Add(items.nama);
                list.SubItems.Add(items.harga.ToString());
                list.SubItems.Add(items.totalJual.ToString());

                mLVweditForm.Items.Add(list);
            }
        }

        private void mBdiscont_Click(object sender, EventArgs e)
        {
            new FormLaporan().ShowDialog();
        }

        private void mBcreate_Click(object sender, EventArgs e)
        {
            TambahMenu tambahMenu = new TambahMenu("Tambah Menu", controller);

            tambahMenu.OnCreate += OnCreateEventHandler;

            tambahMenu.ShowDialog();
        }

        private void mBedit_Click(object sender, EventArgs e)
        {
            if (mLVweditForm.SelectedItems.Count > 0)
            {
                ViewMenu menu = listOfMenu[mLVweditForm.SelectedIndices[0]];

                TambahMenu tambahMenu = new TambahMenu("Edit Menu", menu, controller);

                tambahMenu.OnEdit += OnEditEventHandler;

                tambahMenu.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "\nData Belum dipilih", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning, 180);
            }
        }

        private void mBdelete_Click(object sender, EventArgs e)
        {
            if (mLVweditForm.SelectedItems.Count > 0)
            {

                Menu menu = listOfMenu[mLVweditForm.SelectedIndices[0]];
                var kofirmasi = MetroMessageBox.Show(this, String.Format("\nApa anda Menu berikut ingin dihapus:\n" + "\nNama:"+ menu.nama +"\n" + menu.harga), "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 180);

                if( kofirmasi == DialogResult.Yes)
                {
                    Menu items = listOfMenu[mLVweditForm.SelectedIndices[0]];

                    int result = controller.Delete(items);
                    if (result > 0)  LoadDataMenu();
                }
            }
            else
            {
                MetroMessageBox.Show(this, "\nData Belum dipilih", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning, 180);
            }
           
        }

        private void OnCreateEventHandler(Menu items)
        {


            //int index = mLVweditForm.Items.Count + 1;

            //ListViewItem list = new ListViewItem(index.ToString());
            //list.SubItems.Add(items.id);
            //list.SubItems.Add(items.nama);
            //list.SubItems.Add(items.harga.ToString());
            //list.SubItems.Add("Empty");
            //list.SubItems.Add("Empty");

            LoadDataMenu();
          
        }

        private void OnEditEventHandler(Menu items)
        {
            /*int index = mLVweditForm.SelectedIndices[0];

            ListViewItem list = mLVweditForm.Items[index];

            list.SubItems[1].Text = items.id;
            list.SubItems[2].Text = items.nama;
            list.SubItems[3].Text = items.harga.ToString();
            list.SubItems[4].Text = "Update";
            list.SubItems[5].Text = "UPdate";*/
            LoadDataMenu();


        }

        private void LoadDataMenuByName()
        {
            mLVweditForm.Items.Clear();
            listOfMenu = controller.ReadByName(mTBsearch.Text, this);

            Console.WriteLine(mTBsearch.Text);

            foreach (var items in listOfMenu) {

                items.totalJual = controller.GetDatajual(items.id);

                ListViewItem list = new ListViewItem(items.id);
                list.SubItems.Add(items.nama);
                list.SubItems.Add(items.harga.ToString());
                list.SubItems.Add(items.totalJual.ToString());

                mLVweditForm.Items.Add(list);
            }

        }

        private void mBsearch_Click(object sender, EventArgs e)
        {
            mLVweditForm.Items.Clear();

            if (string.IsNullOrEmpty(mTBsearch.Text))
            {
                LoadDataMenu();
            }
            else
            {
                LoadDataMenuByName();
            }
            
        }

      
    }
}
