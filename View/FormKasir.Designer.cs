namespace SistemOrderMenuRestoran.View
{
    partial class FormKasir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv_order = new MetroFramework.Controls.MetroListView();
            this.tb_noPesan = new MetroFramework.Controls.MetroTextBox();
            this.b_cek = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.l_total = new System.Windows.Forms.Label();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.l_kembali = new System.Windows.Forms.Label();
            this.b_selesai = new MetroFramework.Controls.MetroButton();
            this.tb_dibayar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lv_order
            // 
            this.lv_order.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lv_order.FullRowSelect = true;
            this.lv_order.Location = new System.Drawing.Point(24, 102);
            this.lv_order.Name = "lv_order";
            this.lv_order.OwnerDraw = true;
            this.lv_order.Size = new System.Drawing.Size(420, 325);
            this.lv_order.TabIndex = 0;
            this.lv_order.UseCompatibleStateImageBehavior = false;
            this.lv_order.UseSelectable = true;
            // 
            // tb_noPesan
            // 
            // 
            // 
            // 
            this.tb_noPesan.CustomButton.Image = null;
            this.tb_noPesan.CustomButton.Location = new System.Drawing.Point(28, 1);
            this.tb_noPesan.CustomButton.Name = "";
            this.tb_noPesan.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.tb_noPesan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_noPesan.CustomButton.TabIndex = 1;
            this.tb_noPesan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_noPesan.CustomButton.UseSelectable = true;
            this.tb_noPesan.CustomButton.Visible = false;
            this.tb_noPesan.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tb_noPesan.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tb_noPesan.Lines = new string[] {
        "1999"};
            this.tb_noPesan.Location = new System.Drawing.Point(116, 63);
            this.tb_noPesan.MaxLength = 32767;
            this.tb_noPesan.Name = "tb_noPesan";
            this.tb_noPesan.PasswordChar = '\0';
            this.tb_noPesan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_noPesan.SelectedText = "";
            this.tb_noPesan.SelectionLength = 0;
            this.tb_noPesan.SelectionStart = 0;
            this.tb_noPesan.ShortcutsEnabled = true;
            this.tb_noPesan.Size = new System.Drawing.Size(60, 33);
            this.tb_noPesan.TabIndex = 1;
            this.tb_noPesan.Text = "1999";
            this.tb_noPesan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_noPesan.UseSelectable = true;
            this.tb_noPesan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_noPesan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // b_cek
            // 
            this.b_cek.Location = new System.Drawing.Point(356, 63);
            this.b_cek.Name = "b_cek";
            this.b_cek.Size = new System.Drawing.Size(88, 33);
            this.b_cek.TabIndex = 2;
            this.b_cek.Text = "CEK PESANAN";
            this.b_cek.UseSelectable = true;
            this.b_cek.Click += new System.EventHandler(this.b_cek_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "No. Pesanan";
            // 
            // l_total
            // 
            this.l_total.AutoSize = true;
            this.l_total.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_total.Location = new System.Drawing.Point(467, 83);
            this.l_total.Name = "l_total";
            this.l_total.Size = new System.Drawing.Size(200, 54);
            this.l_total.TabIndex = 11;
            this.l_total.Text = "Rp54.000";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(472, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 25);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Total";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(472, 159);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(78, 25);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Dibayar";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(472, 270);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(81, 25);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Kembali";
            // 
            // l_kembali
            // 
            this.l_kembali.AutoSize = true;
            this.l_kembali.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_kembali.Location = new System.Drawing.Point(465, 288);
            this.l_kembali.Name = "l_kembali";
            this.l_kembali.Size = new System.Drawing.Size(177, 54);
            this.l_kembali.TabIndex = 11;
            this.l_kembali.Text = "Rp6.000";
            // 
            // b_selesai
            // 
            this.b_selesai.Location = new System.Drawing.Point(469, 394);
            this.b_selesai.Name = "b_selesai";
            this.b_selesai.Size = new System.Drawing.Size(250, 33);
            this.b_selesai.TabIndex = 4;
            this.b_selesai.Text = "SELESAI";
            this.b_selesai.UseSelectable = true;
            this.b_selesai.Click += new System.EventHandler(this.b_selesai_Click);
            // 
            // tb_dibayar
            // 
            this.tb_dibayar.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dibayar.Location = new System.Drawing.Point(476, 187);
            this.tb_dibayar.Name = "tb_dibayar";
            this.tb_dibayar.Size = new System.Drawing.Size(243, 61);
            this.tb_dibayar.TabIndex = 3;
            this.tb_dibayar.TextChanged += new System.EventHandler(this.tb_dibayar_TextChanged);
            // 
            // FormKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.tb_dibayar);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.l_kembali);
            this.Controls.Add(this.l_total);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.b_selesai);
            this.Controls.Add(this.b_cek);
            this.Controls.Add(this.tb_noPesan);
            this.Controls.Add(this.lv_order);
            this.Name = "FormKasir";
            this.Text = "FormKasir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView lv_order;
        private MetroFramework.Controls.MetroTextBox tb_noPesan;
        private MetroFramework.Controls.MetroButton b_cek;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label l_total;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Label l_kembali;
        private MetroFramework.Controls.MetroButton b_selesai;
        private System.Windows.Forms.TextBox tb_dibayar;
    }
}