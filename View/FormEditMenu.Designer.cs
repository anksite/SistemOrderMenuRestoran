namespace SistemOrderMenuRestoran.View
{
    partial class FormEditMenu
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.mBcreate = new MetroFramework.Controls.MetroButton();
            this.mBedit = new MetroFramework.Controls.MetroButton();
            this.mBdelete = new MetroFramework.Controls.MetroButton();
            this.mBdiscont = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mTBsearch = new MetroFramework.Controls.MetroTextBox();
            this.mBsearch = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mLVweditForm = new MetroFramework.Controls.MetroListView();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.Controls.Add(this.mBcreate, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.mBedit, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.mBdelete, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.mBdiscont, 6, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 337);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(760, 33);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // mBcreate
            // 
            this.mBcreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mBcreate.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBcreate.Location = new System.Drawing.Point(3, 3);
            this.mBcreate.Name = "mBcreate";
            this.mBcreate.Size = new System.Drawing.Size(94, 27);
            this.mBcreate.TabIndex = 0;
            this.mBcreate.Text = "CREATE";
            this.mBcreate.UseSelectable = true;
            this.mBcreate.Click += new System.EventHandler(this.mBcreate_Click);
            // 
            // mBedit
            // 
            this.mBedit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mBedit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBedit.Location = new System.Drawing.Point(113, 3);
            this.mBedit.Name = "mBedit";
            this.mBedit.Size = new System.Drawing.Size(94, 27);
            this.mBedit.TabIndex = 1;
            this.mBedit.Text = "EDIT";
            this.mBedit.UseSelectable = true;
            this.mBedit.Click += new System.EventHandler(this.mBedit_Click);
            // 
            // mBdelete
            // 
            this.mBdelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mBdelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBdelete.Location = new System.Drawing.Point(223, 3);
            this.mBdelete.Name = "mBdelete";
            this.mBdelete.Size = new System.Drawing.Size(94, 27);
            this.mBdelete.TabIndex = 2;
            this.mBdelete.Text = "DELETE";
            this.mBdelete.UseSelectable = true;
            this.mBdelete.Click += new System.EventHandler(this.mBdelete_Click);
            // 
            // mBdiscont
            // 
            this.mBdiscont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mBdiscont.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBdiscont.Location = new System.Drawing.Point(563, 3);
            this.mBdiscont.Name = "mBdiscont";
            this.mBdiscont.Size = new System.Drawing.Size(194, 27);
            this.mBdiscont.TabIndex = 3;
            this.mBdiscont.Text = "LAPORAN PENJUALAN";
            this.mBdiscont.UseSelectable = true;
            this.mBdiscont.Click += new System.EventHandler(this.mBdiscont_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.mTBsearch, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.mBsearch, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(760, 33);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // mTBsearch
            // 
            this.mTBsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.mTBsearch.CustomButton.Image = null;
            this.mTBsearch.CustomButton.Location = new System.Drawing.Point(598, 1);
            this.mTBsearch.CustomButton.Name = "";
            this.mTBsearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mTBsearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTBsearch.CustomButton.TabIndex = 1;
            this.mTBsearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTBsearch.CustomButton.UseSelectable = true;
            this.mTBsearch.CustomButton.Visible = false;
            this.mTBsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTBsearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTBsearch.Lines = new string[0];
            this.mTBsearch.Location = new System.Drawing.Point(3, 3);
            this.mTBsearch.MaxLength = 32767;
            this.mTBsearch.Name = "mTBsearch";
            this.mTBsearch.PasswordChar = '\0';
            this.mTBsearch.PromptText = "Search by name or ID item...";
            this.mTBsearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTBsearch.SelectedText = "";
            this.mTBsearch.SelectionLength = 0;
            this.mTBsearch.SelectionStart = 0;
            this.mTBsearch.ShortcutsEnabled = true;
            this.mTBsearch.Size = new System.Drawing.Size(624, 27);
            this.mTBsearch.Style = MetroFramework.MetroColorStyle.Silver;
            this.mTBsearch.TabIndex = 1;
            this.mTBsearch.UseSelectable = true;
            this.mTBsearch.WaterMark = "Search by name or ID item...";
            this.mTBsearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTBsearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mBsearch
            // 
            this.mBsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mBsearch.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBsearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mBsearch.Location = new System.Drawing.Point(633, 3);
            this.mBsearch.Name = "mBsearch";
            this.mBsearch.Size = new System.Drawing.Size(124, 27);
            this.mBsearch.TabIndex = 2;
            this.mBsearch.Text = "SEARCH";
            this.mBsearch.UseSelectable = true;
            this.mBsearch.Click += new System.EventHandler(this.mBsearch_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mLVweditForm, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 370);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mLVweditForm
            // 
            this.mLVweditForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mLVweditForm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mLVweditForm.FullRowSelect = true;
            this.mLVweditForm.Location = new System.Drawing.Point(3, 36);
            this.mLVweditForm.Name = "mLVweditForm";
            this.mLVweditForm.OwnerDraw = true;
            this.mLVweditForm.Size = new System.Drawing.Size(754, 298);
            this.mLVweditForm.TabIndex = 3;
            this.mLVweditForm.UseCompatibleStateImageBehavior = false;
            this.mLVweditForm.UseSelectable = true;
            // 
            // FormEditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormEditMenu";
            this.Text = "FormEditMenu";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroTextBox mTBsearch;
        private MetroFramework.Controls.MetroButton mBsearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton mBcreate;
        private MetroFramework.Controls.MetroButton mBedit;
        private MetroFramework.Controls.MetroButton mBdelete;
        private MetroFramework.Controls.MetroButton mBdiscont;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroListView mLVweditForm;
    }
}