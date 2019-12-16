namespace SistemOrderMenuRestoran.View
{
    partial class FormLogin
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tb_id = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tb_pass = new MetroFramework.Controls.MetroTextBox();
            this.b_login = new MetroFramework.Controls.MetroButton();
            this.l_record = new MetroFramework.Controls.MetroLink();
            this.b_menu = new MetroFramework.Controls.MetroButton();
            this.User = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.User.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(51, 40);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID Pegawai";
            // 
            // tb_id
            // 
            this.tb_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.tb_id.CustomButton.Image = null;
            this.tb_id.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.tb_id.CustomButton.Name = "";
            this.tb_id.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_id.CustomButton.TabIndex = 1;
            this.tb_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_id.CustomButton.UseSelectable = true;
            this.tb_id.CustomButton.Visible = false;
            this.tb_id.Lines = new string[0];
            this.tb_id.Location = new System.Drawing.Point(130, 40);
            this.tb_id.MaxLength = 32767;
            this.tb_id.Name = "tb_id";
            this.tb_id.PasswordChar = '\0';
            this.tb_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_id.SelectedText = "";
            this.tb_id.SelectionLength = 0;
            this.tb_id.SelectionStart = 0;
            this.tb_id.ShortcutsEnabled = true;
            this.tb_id.Size = new System.Drawing.Size(202, 23);
            this.tb_id.TabIndex = 1;
            this.tb_id.UseSelectable = true;
            this.tb_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(51, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Password";
            // 
            // tb_pass
            // 
            this.tb_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.tb_pass.CustomButton.Image = null;
            this.tb_pass.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.tb_pass.CustomButton.Name = "";
            this.tb_pass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_pass.CustomButton.TabIndex = 1;
            this.tb_pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_pass.CustomButton.UseSelectable = true;
            this.tb_pass.CustomButton.Visible = false;
            this.tb_pass.Lines = new string[0];
            this.tb_pass.Location = new System.Drawing.Point(130, 69);
            this.tb_pass.MaxLength = 32767;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_pass.SelectedText = "";
            this.tb_pass.SelectionLength = 0;
            this.tb_pass.SelectionStart = 0;
            this.tb_pass.ShortcutsEnabled = true;
            this.tb_pass.Size = new System.Drawing.Size(202, 23);
            this.tb_pass.TabIndex = 1;
            this.tb_pass.UseSelectable = true;
            this.tb_pass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_pass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // b_login
            // 
            this.b_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_login.Location = new System.Drawing.Point(215, 98);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(117, 23);
            this.b_login.TabIndex = 2;
            this.b_login.Text = "LOGIN";
            this.b_login.UseSelectable = true;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // l_record
            // 
            this.l_record.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.l_record.Location = new System.Drawing.Point(301, 151);
            this.l_record.Name = "l_record";
            this.l_record.Size = new System.Drawing.Size(95, 23);
            this.l_record.TabIndex = 3;
            this.l_record.Text = "Login Record";
            this.l_record.UseSelectable = true;
            this.l_record.Click += new System.EventHandler(this.l_record_Click);
            // 
            // b_menu
            // 
            this.b_menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_menu.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.b_menu.Location = new System.Drawing.Point(125, 51);
            this.b_menu.Name = "b_menu";
            this.b_menu.Size = new System.Drawing.Size(152, 43);
            this.b_menu.TabIndex = 2;
            this.b_menu.Text = "TAMPILKAN MENU";
            this.b_menu.UseSelectable = true;
            this.b_menu.Click += new System.EventHandler(this.b_menu_Click);
            // 
            // User
            // 
            this.User.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.User.Controls.Add(this.metroTabPage1);
            this.User.Controls.Add(this.metroTabPage2);
            this.User.Location = new System.Drawing.Point(23, 64);
            this.User.Name = "User";
            this.User.SelectedIndex = 1;
            this.User.Size = new System.Drawing.Size(407, 219);
            this.User.TabIndex = 0;
            this.User.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.b_menu);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(399, 177);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Pelanggan";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.l_record);
            this.metroTabPage2.Controls.Add(this.b_login);
            this.metroTabPage2.Controls.Add(this.tb_pass);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.tb_id);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(399, 177);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Karyawan";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 306);
            this.Controls.Add(this.User);
            this.Name = "FormLogin";
            this.Text = "Mode";
            this.User.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tb_id;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tb_pass;
        private MetroFramework.Controls.MetroButton b_login;
        private MetroFramework.Controls.MetroLink l_record;
        private MetroFramework.Controls.MetroButton b_menu;
        private MetroFramework.Controls.MetroTabControl User;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
    }
}