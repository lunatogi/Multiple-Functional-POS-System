namespace BossPoss
{
    partial class CiroForm
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtboxReceiptNote = new System.Windows.Forms.TextBox();
            this.btnPassword = new System.Windows.Forms.Button();
            this.YearGridView = new System.Windows.Forms.DataGridView();
            this.MonthGridView = new System.Windows.Forms.DataGridView();
            this.SKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nakit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.top = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nakitt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.DayGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.YearGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(12, 9);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(170, 29);
            this.lblPassword.TabIndex = 75;
            this.lblPassword.Text = "Şifreyi Giriniz:";
            // 
            // txtboxReceiptNote
            // 
            this.txtboxReceiptNote.Location = new System.Drawing.Point(188, 9);
            this.txtboxReceiptNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxReceiptNote.Multiline = true;
            this.txtboxReceiptNote.Name = "txtboxReceiptNote";
            this.txtboxReceiptNote.PasswordChar = '*';
            this.txtboxReceiptNote.Size = new System.Drawing.Size(149, 40);
            this.txtboxReceiptNote.TabIndex = 74;
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(343, 9);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(141, 40);
            this.btnPassword.TabIndex = 76;
            this.btnPassword.Text = "Giriş";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // YearGridView
            // 
            this.YearGridView.AllowUserToAddRows = false;
            this.YearGridView.AllowUserToDeleteRows = false;
            this.YearGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YearGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YearGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SKT,
            this.ReceiptNo,
            this.nakit,
            this.top});
            this.YearGridView.Location = new System.Drawing.Point(70, 76);
            this.YearGridView.Name = "YearGridView";
            this.YearGridView.ReadOnly = true;
            this.YearGridView.RowTemplate.Height = 24;
            this.YearGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.YearGridView.Size = new System.Drawing.Size(929, 469);
            this.YearGridView.TabIndex = 77;
            this.YearGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.YearGridView_CellContentClick);
            // 
            // MonthGridView
            // 
            this.MonthGridView.AllowUserToAddRows = false;
            this.MonthGridView.AllowUserToDeleteRows = false;
            this.MonthGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonthGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MonthGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.nakitt,
            this.topp});
            this.MonthGridView.Location = new System.Drawing.Point(70, 76);
            this.MonthGridView.Name = "MonthGridView";
            this.MonthGridView.ReadOnly = true;
            this.MonthGridView.RowTemplate.Height = 24;
            this.MonthGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MonthGridView.Size = new System.Drawing.Size(929, 469);
            this.MonthGridView.TabIndex = 78;
            this.MonthGridView.Visible = false;
            this.MonthGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MonthGridView_CellContentClick);
            // 
            // SKT
            // 
            this.SKT.HeaderText = "Tarih (Yıllık)";
            this.SKT.Name = "SKT";
            this.SKT.ReadOnly = true;
            this.SKT.Width = 200;
            // 
            // ReceiptNo
            // 
            this.ReceiptNo.HeaderText = "Visa";
            this.ReceiptNo.Name = "ReceiptNo";
            this.ReceiptNo.ReadOnly = true;
            // 
            // nakit
            // 
            this.nakit.HeaderText = "Nakit";
            this.nakit.Name = "nakit";
            this.nakit.ReadOnly = true;
            // 
            // top
            // 
            this.top.HeaderText = "Toplam";
            this.top.Name = "top";
            this.top.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tarih (Aylık)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Visa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nakitt
            // 
            this.nakitt.HeaderText = "Nakit";
            this.nakitt.Name = "nakitt";
            this.nakitt.ReadOnly = true;
            // 
            // topp
            // 
            this.topp.HeaderText = "Toplam";
            this.topp.Name = "topp";
            this.topp.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(852, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 49);
            this.btnBack.TabIndex = 80;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DayGridView
            // 
            this.DayGridView.AllowUserToAddRows = false;
            this.DayGridView.AllowUserToDeleteRows = false;
            this.DayGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DayGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DayGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.DayGridView.Location = new System.Drawing.Point(70, 76);
            this.DayGridView.Name = "DayGridView";
            this.DayGridView.ReadOnly = true;
            this.DayGridView.RowTemplate.Height = 24;
            this.DayGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DayGridView.Size = new System.Drawing.Size(929, 469);
            this.DayGridView.TabIndex = 81;
            this.DayGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Tarih (Günlük)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Visa";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Nakit";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Toplam";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // CiroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 567);
            this.Controls.Add(this.DayGridView);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.MonthGridView);
            this.Controls.Add(this.YearGridView);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtboxReceiptNote);
            this.Name = "CiroForm";
            this.Text = "CiroForm";
            this.Load += new System.EventHandler(this.CiroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YearGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtboxReceiptNote;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.DataGridView YearGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nakit;
        private System.Windows.Forms.DataGridViewTextBoxColumn top;
        private System.Windows.Forms.DataGridView MonthGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nakitt;
        private System.Windows.Forms.DataGridViewTextBoxColumn topp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView DayGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}