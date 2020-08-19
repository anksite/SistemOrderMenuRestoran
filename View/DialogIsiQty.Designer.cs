namespace SistemOrderMenuRestoran.View {
    partial class DialogIsiQty {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.l_menu = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.l_jumlah = new MetroFramework.Controls.MetroLabel();
            this.l_total = new MetroFramework.Controls.MetroLabel();
            this.b_plus = new MetroFramework.Controls.MetroButton();
            this.b_min = new MetroFramework.Controls.MetroButton();
            this.b_ok = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // l_menu
            // 
            this.l_menu.AutoSize = true;
            this.l_menu.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.l_menu.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.l_menu.Location = new System.Drawing.Point(30, 69);
            this.l_menu.MinimumSize = new System.Drawing.Size(350, 0);
            this.l_menu.Name = "l_menu";
            this.l_menu.Size = new System.Drawing.Size(350, 25);
            this.l_menu.TabIndex = 0;
            this.l_menu.Text = "Ayam Bakar";
            this.l_menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(181, 104);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Jumlah";
            // 
            // l_jumlah
            // 
            this.l_jumlah.AutoSize = true;
            this.l_jumlah.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.l_jumlah.Location = new System.Drawing.Point(196, 127);
            this.l_jumlah.Name = "l_jumlah";
            this.l_jumlah.Size = new System.Drawing.Size(17, 19);
            this.l_jumlah.TabIndex = 0;
            this.l_jumlah.Text = "1";
            // 
            // l_total
            // 
            this.l_total.AutoSize = true;
            this.l_total.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.l_total.Location = new System.Drawing.Point(55, 164);
            this.l_total.MinimumSize = new System.Drawing.Size(300, 0);
            this.l_total.Name = "l_total";
            this.l_total.Size = new System.Drawing.Size(300, 19);
            this.l_total.TabIndex = 0;
            this.l_total.Text = "Rp70.000.000.000";
            this.l_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_plus
            // 
            this.b_plus.Location = new System.Drawing.Point(226, 125);
            this.b_plus.Name = "b_plus";
            this.b_plus.Size = new System.Drawing.Size(31, 23);
            this.b_plus.TabIndex = 1;
            this.b_plus.Text = "+";
            this.b_plus.UseSelectable = true;
            this.b_plus.Click += new System.EventHandler(this.b_plus_Click);
            // 
            // b_min
            // 
            this.b_min.Location = new System.Drawing.Point(154, 125);
            this.b_min.Name = "b_min";
            this.b_min.Size = new System.Drawing.Size(31, 23);
            this.b_min.TabIndex = 1;
            this.b_min.Text = "-";
            this.b_min.UseSelectable = true;
            this.b_min.Click += new System.EventHandler(this.b_min_Click);
            // 
            // b_ok
            // 
            this.b_ok.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.b_ok.Location = new System.Drawing.Point(154, 186);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(103, 23);
            this.b_ok.TabIndex = 1;
            this.b_ok.Text = "Oke";
            this.b_ok.UseSelectable = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // DialogIsiQty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 221);
            this.Controls.Add(this.b_min);
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.b_plus);
            this.Controls.Add(this.l_jumlah);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.l_total);
            this.Controls.Add(this.l_menu);
            this.Name = "DialogIsiQty";
            this.Text = "Mau Pesan Berapa?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel l_jumlah;
        private MetroFramework.Controls.MetroLabel l_total;
        private MetroFramework.Controls.MetroButton b_plus;
        private MetroFramework.Controls.MetroButton b_min;
        private MetroFramework.Controls.MetroButton b_ok;
        private MetroFramework.Controls.MetroLabel l_menu;
    }
}