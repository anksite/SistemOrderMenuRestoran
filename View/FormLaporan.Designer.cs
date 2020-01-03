namespace SistemOrderMenuRestoran.View {
    partial class FormLaporan {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lv_laporan = new MetroFramework.Controls.MetroListView();
            this.l_totalOmset = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lv_laporan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.l_totalOmset, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(588, 370);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lv_laporan
            // 
            this.lv_laporan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_laporan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lv_laporan.FullRowSelect = true;
            this.lv_laporan.Location = new System.Drawing.Point(3, 3);
            this.lv_laporan.Name = "lv_laporan";
            this.lv_laporan.OwnerDraw = true;
            this.lv_laporan.Size = new System.Drawing.Size(582, 290);
            this.lv_laporan.TabIndex = 0;
            this.lv_laporan.UseCompatibleStateImageBehavior = false;
            this.lv_laporan.UseSelectable = true;
            // 
            // l_totalOmset
            // 
            this.l_totalOmset.AutoSize = true;
            this.l_totalOmset.Dock = System.Windows.Forms.DockStyle.Left;
            this.l_totalOmset.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_totalOmset.Location = new System.Drawing.Point(3, 296);
            this.l_totalOmset.Name = "l_totalOmset";
            this.l_totalOmset.Size = new System.Drawing.Size(239, 74);
            this.l_totalOmset.TabIndex = 1;
            this.l_totalOmset.Text = "Total omset : Rp. ";
            this.l_totalOmset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_totalOmset.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormLaporan";
            this.Text = "Laporan Penjualan";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroListView lv_laporan;
        private System.Windows.Forms.Label l_totalOmset;
    }
}