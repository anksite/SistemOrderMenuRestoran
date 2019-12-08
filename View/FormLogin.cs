using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemOrderMenuRestoran.View
{
    //ADNAN
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void b_menu_Click(object sender, EventArgs e)
        {
            new FormMenu().Show();
        }

        private void l_record_Click(object sender, EventArgs e)
        {
            new FormLoginRecord().ShowDialog();
        }
    }
}
