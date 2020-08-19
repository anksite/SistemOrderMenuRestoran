namespace SistemOrderMenuRestoran
{
    partial class FormCart
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
            this.b_order = new MetroFramework.Controls.MetroButton();
            this.l_total = new MetroFramework.Controls.MetroLabel();
            this.lv_order = new MetroFramework.Controls.MetroListView();
            this.tb_note = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // b_order
            // 
            this.b_order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_order.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.b_order.Location = new System.Drawing.Point(290, 436);
            this.b_order.Name = "b_order";
            this.b_order.Size = new System.Drawing.Size(152, 43);
            this.b_order.TabIndex = 10;
            this.b_order.Text = "ORDER";
            this.b_order.UseSelectable = true;
            this.b_order.Click += new System.EventHandler(this.b_order_Click);
            // 
            // l_total
            // 
            this.l_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_total.AutoSize = true;
            this.l_total.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.l_total.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.l_total.Location = new System.Drawing.Point(23, 446);
            this.l_total.Name = "l_total";
            this.l_total.Size = new System.Drawing.Size(142, 25);
            this.l_total.TabIndex = 9;
            this.l_total.Text = "Total: Rp54.000";
            // 
            // lv_order
            // 
            this.lv_order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lv_order.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lv_order.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lv_order.FullRowSelect = true;
            this.lv_order.Location = new System.Drawing.Point(23, 63);
            this.lv_order.Name = "lv_order";
            this.lv_order.OwnerDraw = true;
            this.lv_order.Size = new System.Drawing.Size(419, 253);
            this.lv_order.TabIndex = 8;
            this.lv_order.UseCompatibleStateImageBehavior = false;
            this.lv_order.UseSelectable = true;
            // 
            // tb_note
            // 
            this.tb_note.Location = new System.Drawing.Point(23, 355);
            this.tb_note.Multiline = true;
            this.tb_note.Name = "tb_note";
            this.tb_note.Size = new System.Drawing.Size(419, 61);
            this.tb_note.TabIndex = 11;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 327);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 25);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Beri Catatan";
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 502);
            this.Controls.Add(this.tb_note);
            this.Controls.Add(this.b_order);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.l_total);
            this.Controls.Add(this.lv_order);
            this.Name = "FormCart";
            this.Text = "Periksa Pesanan Anda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton b_order;
        private MetroFramework.Controls.MetroLabel l_total;
        private MetroFramework.Controls.MetroListView lv_order;
        private System.Windows.Forms.TextBox tb_note;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}