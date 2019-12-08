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
            this.listView1 = new System.Windows.Forms.ListView();
            this.b_lanjut = new System.Windows.Forms.Button();
            this.l_total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(445, 360);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // b_lanjut
            // 
            this.b_lanjut.Location = new System.Drawing.Point(276, 378);
            this.b_lanjut.Name = "b_lanjut";
            this.b_lanjut.Size = new System.Drawing.Size(181, 40);
            this.b_lanjut.TabIndex = 4;
            this.b_lanjut.Text = "BAYAR";
            this.b_lanjut.UseVisualStyleBackColor = true;
            // 
            // l_total
            // 
            this.l_total.AutoSize = true;
            this.l_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_total.Location = new System.Drawing.Point(12, 386);
            this.l_total.Name = "l_total";
            this.l_total.Size = new System.Drawing.Size(165, 25);
            this.l_total.TabIndex = 3;
            this.l_total.Text = "Total: Rp54.000";
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 431);
            this.Controls.Add(this.b_lanjut);
            this.Controls.Add(this.l_total);
            this.Controls.Add(this.listView1);
            this.Name = "FormCart";
            this.Text = "FormCart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button b_lanjut;
        private System.Windows.Forms.Label l_total;
    }
}