namespace SistemOrderMenuRestoran.View
{
    partial class FormLoginRecord
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
            this.lv_loginRecord = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // lv_loginRecord
            // 
            this.lv_loginRecord.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lv_loginRecord.FullRowSelect = true;
            this.lv_loginRecord.Location = new System.Drawing.Point(24, 64);
            this.lv_loginRecord.Name = "lv_loginRecord";
            this.lv_loginRecord.OwnerDraw = true;
            this.lv_loginRecord.Size = new System.Drawing.Size(409, 331);
            this.lv_loginRecord.TabIndex = 0;
            this.lv_loginRecord.UseCompatibleStateImageBehavior = false;
            this.lv_loginRecord.UseSelectable = true;
            // 
            // FormLoginRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 418);
            this.Controls.Add(this.lv_loginRecord);
            this.Name = "FormLoginRecord";
            this.Text = "FormLoginRecord";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView lv_loginRecord;
    }
}