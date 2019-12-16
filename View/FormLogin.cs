using SistemOrderMenuRestoran.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemOrderMenuRestoran.View {
    //ADNAN
    public partial class FormLogin : MetroFramework.Forms.MetroForm {
        KaryawanController controller;
        LoginRecordController controllerLoginRec;

        public FormLogin() {
            InitializeComponent();
            controller = new KaryawanController();
            controllerLoginRec = new LoginRecordController();
        }

        private void b_menu_Click(object sender, EventArgs e) {
            new FormMenu().Show();
        }

        private void l_record_Click(object sender, EventArgs e) {
            new FormLoginRecord().ShowDialog();
        }

        private void b_login_Click(object sender, EventArgs e) {
            string id = tb_id.Text;
            string pass = tb_pass.Text;

            string role = controller.ReadLogin(id, pass);
            if (role.Length > 0) {
                controllerLoginRec.Create(id);
                switch (role) {
                    case "KASIR": new FormKasir().Show(); break;
                    case "DAPUR": new FormDapur().Show(); break;
                    case "ADMIN": new FormEditMenu().Show(); break;
                }
            } else {
                MessageBox.Show("Ups, Username atau Password salah!", "Perhatian!",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
