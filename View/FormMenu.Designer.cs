namespace SistemOrderMenuRestoran
{
    partial class FormMenu
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
            this.lv_makan = new MetroFramework.Controls.MetroListView();
            this.l_itemCount = new MetroFramework.Controls.MetroLabel();
            this.l_total = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tb_cari = new MetroFramework.Controls.MetroTextBox();
            this.lv_minum = new MetroFramework.Controls.MetroListView();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lv_lain = new MetroFramework.Controls.MetroListView();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.b_next = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lv_makan
            // 
            this.lv_makan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lv_makan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lv_makan.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lv_makan.FullRowSelect = true;
            this.lv_makan.Location = new System.Drawing.Point(38, 148);
            this.lv_makan.Name = "lv_makan";
            this.lv_makan.OwnerDraw = true;
            this.lv_makan.Size = new System.Drawing.Size(228, 304);
            this.lv_makan.TabIndex = 4;
            this.lv_makan.UseCompatibleStateImageBehavior = false;
            this.lv_makan.UseSelectable = true;
            this.lv_makan.Click += new System.EventHandler(this.lv_makan_Click);
            // 
            // l_itemCount
            // 
            this.l_itemCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_itemCount.AutoSize = true;
            this.l_itemCount.Location = new System.Drawing.Point(23, 474);
            this.l_itemCount.Name = "l_itemCount";
            this.l_itemCount.Size = new System.Drawing.Size(127, 19);
            this.l_itemCount.TabIndex = 5;
            this.l_itemCount.Text = "0 Item Ditambahkan";
            // 
            // l_total
            // 
            this.l_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_total.AutoSize = true;
            this.l_total.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.l_total.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.l_total.Location = new System.Drawing.Point(23, 493);
            this.l_total.Name = "l_total";
            this.l_total.Size = new System.Drawing.Size(97, 25);
            this.l_total.TabIndex = 5;
            this.l_total.Text = "Total: Rp0";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(38, 120);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Makanan";
            // 
            // tb_cari
            // 
            this.tb_cari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_cari.CustomButton.Image = null;
            this.tb_cari.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.tb_cari.CustomButton.Name = "";
            this.tb_cari.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_cari.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_cari.CustomButton.TabIndex = 1;
            this.tb_cari.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_cari.CustomButton.UseSelectable = true;
            this.tb_cari.CustomButton.Visible = false;
            this.tb_cari.Lines = new string[0];
            this.tb_cari.Location = new System.Drawing.Point(565, 82);
            this.tb_cari.MaxLength = 32767;
            this.tb_cari.Name = "tb_cari";
            this.tb_cari.PasswordChar = '\0';
            this.tb_cari.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_cari.SelectedText = "";
            this.tb_cari.SelectionLength = 0;
            this.tb_cari.SelectionStart = 0;
            this.tb_cari.ShortcutsEnabled = true;
            this.tb_cari.Size = new System.Drawing.Size(177, 23);
            this.tb_cari.TabIndex = 6;
            this.tb_cari.UseSelectable = true;
            this.tb_cari.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_cari.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_cari.TextChanged += new System.EventHandler(this.tb_cari_TextChanged);
            // 
            // lv_minum
            // 
            this.lv_minum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lv_minum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lv_minum.FullRowSelect = true;
            this.lv_minum.Location = new System.Drawing.Point(272, 148);
            this.lv_minum.Name = "lv_minum";
            this.lv_minum.OwnerDraw = true;
            this.lv_minum.Size = new System.Drawing.Size(228, 304);
            this.lv_minum.TabIndex = 4;
            this.lv_minum.UseCompatibleStateImageBehavior = false;
            this.lv_minum.UseSelectable = true;
            this.lv_minum.Click += new System.EventHandler(this.lv_minum_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(272, 120);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 25);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Minuman";
            // 
            // lv_lain
            // 
            this.lv_lain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lv_lain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lv_lain.FullRowSelect = true;
            this.lv_lain.Location = new System.Drawing.Point(506, 148);
            this.lv_lain.Name = "lv_lain";
            this.lv_lain.OwnerDraw = true;
            this.lv_lain.Size = new System.Drawing.Size(228, 304);
            this.lv_lain.TabIndex = 4;
            this.lv_lain.UseCompatibleStateImageBehavior = false;
            this.lv_lain.UseSelectable = true;
            this.lv_lain.Click += new System.EventHandler(this.lv_lain_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(506, 120);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 25);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Pelengkap";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel6.Location = new System.Drawing.Point(565, 60);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(127, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Cari Menu";
            // 
            // b_next
            // 
            this.b_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_next.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.b_next.Location = new System.Drawing.Point(590, 472);
            this.b_next.Name = "b_next";
            this.b_next.Size = new System.Drawing.Size(152, 43);
            this.b_next.TabIndex = 7;
            this.b_next.Text = "BERIKUTNYA";
            this.b_next.UseSelectable = true;
            this.b_next.Click += new System.EventHandler(this.b_next_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 538);
            this.Controls.Add(this.b_next);
            this.Controls.Add(this.tb_cari);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.l_total);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.l_itemCount);
            this.Controls.Add(this.lv_lain);
            this.Controls.Add(this.lv_minum);
            this.Controls.Add(this.lv_makan);
            this.Name = "FormMenu";
            this.Text = "Menu Restoran Kami";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroListView lv_makan;
        private MetroFramework.Controls.MetroLabel l_itemCount;
        private MetroFramework.Controls.MetroLabel l_total;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tb_cari;
        private MetroFramework.Controls.MetroListView lv_minum;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroListView lv_lain;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton b_next;
    }
}

