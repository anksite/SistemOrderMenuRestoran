namespace SistemOrderMenuRestoran.View
{
    partial class FormDapur
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
            this.lv_antrian = new MetroFramework.Controls.MetroListView();
            this.lv_dimasak = new MetroFramework.Controls.MetroListView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lv_antrian
            // 
            this.lv_antrian.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lv_antrian.FullRowSelect = true;
            this.lv_antrian.Location = new System.Drawing.Point(23, 101);
            this.lv_antrian.Name = "lv_antrian";
            this.lv_antrian.OwnerDraw = true;
            this.lv_antrian.Size = new System.Drawing.Size(493, 183);
            this.lv_antrian.TabIndex = 0;
            this.lv_antrian.UseCompatibleStateImageBehavior = false;
            this.lv_antrian.UseSelectable = true;
            this.lv_antrian.Click += new System.EventHandler(this.lv_antrian_Click);
            // 
            // lv_dimasak
            // 
            this.lv_dimasak.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lv_dimasak.FullRowSelect = true;
            this.lv_dimasak.Location = new System.Drawing.Point(24, 341);
            this.lv_dimasak.Name = "lv_dimasak";
            this.lv_dimasak.OwnerDraw = true;
            this.lv_dimasak.Size = new System.Drawing.Size(492, 186);
            this.lv_dimasak.TabIndex = 1;
            this.lv_dimasak.UseCompatibleStateImageBehavior = false;
            this.lv_dimasak.UseSelectable = true;
            this.lv_dimasak.Click += new System.EventHandler(this.lv_dimasak_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(174, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Menunggu Antrian";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(23, 313);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(152, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Sedang Dimasak";
            // 
            // FormDapur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 550);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lv_dimasak);
            this.Controls.Add(this.lv_antrian);
            this.Name = "FormDapur";
            this.Text = "FormDapur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView lv_antrian;
        private MetroFramework.Controls.MetroListView lv_dimasak;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}