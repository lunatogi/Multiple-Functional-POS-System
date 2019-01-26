namespace BossPoss
{
    partial class WaitingReceiptsForm
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
            this.SpesificReceiptDataGrid = new System.Windows.Forms.DataGridView();
            this.notee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaitingReceiptDataGrid = new System.Windows.Forms.DataGridView();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SpesificReceiptDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitingReceiptDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SpesificReceiptDataGrid
            // 
            this.SpesificReceiptDataGrid.AllowUserToAddRows = false;
            this.SpesificReceiptDataGrid.AllowUserToDeleteRows = false;
            this.SpesificReceiptDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpesificReceiptDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpesificReceiptDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.notee,
            this.Vn,
            this.adet,
            this.fiyatt});
            this.SpesificReceiptDataGrid.Location = new System.Drawing.Point(12, 65);
            this.SpesificReceiptDataGrid.Name = "SpesificReceiptDataGrid";
            this.SpesificReceiptDataGrid.ReadOnly = true;
            this.SpesificReceiptDataGrid.RowTemplate.Height = 24;
            this.SpesificReceiptDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SpesificReceiptDataGrid.Size = new System.Drawing.Size(977, 469);
            this.SpesificReceiptDataGrid.TabIndex = 25;
            this.SpesificReceiptDataGrid.Visible = false;
            // 
            // notee
            // 
            this.notee.HeaderText = "Ürün Notu";
            this.notee.Name = "notee";
            this.notee.ReadOnly = true;
            // 
            // Vn
            // 
            this.Vn.HeaderText = "Ürün";
            this.Vn.Name = "Vn";
            this.Vn.ReadOnly = true;
            this.Vn.Width = 200;
            // 
            // adet
            // 
            this.adet.HeaderText = "Adet";
            this.adet.Name = "adet";
            this.adet.ReadOnly = true;
            // 
            // fiyatt
            // 
            this.fiyatt.HeaderText = "Fiyat";
            this.fiyatt.Name = "fiyatt";
            this.fiyatt.ReadOnly = true;
            // 
            // WaitingReceiptDataGrid
            // 
            this.WaitingReceiptDataGrid.AllowUserToAddRows = false;
            this.WaitingReceiptDataGrid.AllowUserToDeleteRows = false;
            this.WaitingReceiptDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WaitingReceiptDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WaitingReceiptDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Note});
            this.WaitingReceiptDataGrid.Location = new System.Drawing.Point(12, 65);
            this.WaitingReceiptDataGrid.Name = "WaitingReceiptDataGrid";
            this.WaitingReceiptDataGrid.ReadOnly = true;
            this.WaitingReceiptDataGrid.RowTemplate.Height = 24;
            this.WaitingReceiptDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WaitingReceiptDataGrid.Size = new System.Drawing.Size(977, 469);
            this.WaitingReceiptDataGrid.TabIndex = 24;
            this.WaitingReceiptDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WaitingReceiptDataGrid_CellContentClick);
            // 
            // Note
            // 
            this.Note.HeaderText = "Fiş Notu";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 1000;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 50);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(840, 9);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(149, 50);
            this.btnActivate.TabIndex = 27;
            this.btnActivate.Text = "Fişi Seç";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(685, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 50);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Fişi Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // WaitingReceiptsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 546);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.SpesificReceiptDataGrid);
            this.Controls.Add(this.WaitingReceiptDataGrid);
            this.Name = "WaitingReceiptsForm";
            this.Text = "WaitingReceiptsForm";
            this.Load += new System.EventHandler(this.WaitingReceiptsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpesificReceiptDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitingReceiptDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SpesificReceiptDataGrid;
        private System.Windows.Forms.DataGridView WaitingReceiptDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn notee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatt;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnDelete;
    }
}