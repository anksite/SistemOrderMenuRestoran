namespace SistemOrderMenuRestoran.View {
    partial class FormDapurDetail {
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
            this.b_action = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.l_status = new System.Windows.Forms.Label();
            this.rtb_pesanan = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // b_action
            // 
            this.b_action.Location = new System.Drawing.Point(333, 491);
            this.b_action.Name = "b_action";
            this.b_action.Size = new System.Drawing.Size(113, 34);
            this.b_action.TabIndex = 5;
            this.b_action.Text = "MULAI MEMASAK";
            this.b_action.UseSelectable = true;
            this.b_action.Click += new System.EventHandler(this.b_action_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 483);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Status";
            // 
            // l_status
            // 
            this.l_status.AutoSize = true;
            this.l_status.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.l_status.Location = new System.Drawing.Point(23, 500);
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(95, 25);
            this.l_status.TabIndex = 2;
            this.l_status.Text = "ANTRIAN";
            // 
            // rtb_pesanan
            // 
            this.rtb_pesanan.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_pesanan.Location = new System.Drawing.Point(28, 63);
            this.rtb_pesanan.Name = "rtb_pesanan";
            this.rtb_pesanan.ReadOnly = true;
            this.rtb_pesanan.Size = new System.Drawing.Size(418, 417);
            this.rtb_pesanan.TabIndex = 0;
            this.rtb_pesanan.Text = "2 Ayam Geprek\n3 Ayam Bakar\n\nNote:\nJangan pedes\n";
            // 
            // FormDapurDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 547);
            this.Controls.Add(this.rtb_pesanan);
            this.Controls.Add(this.l_status);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.b_action);
            this.Name = "FormDapurDetail";
            this.Text = "No. Pesanan 10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton b_action;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label l_status;
        private System.Windows.Forms.RichTextBox rtb_pesanan;
    }
}