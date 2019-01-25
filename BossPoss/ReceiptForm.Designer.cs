namespace BossPoss
{
    partial class ReceiptForm
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
            this.storageGridView = new System.Windows.Forms.DataGridView();
            this.SKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.ReceiptGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.İsim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ödeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.storageGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // storageGridView
            // 
            this.storageGridView.AllowUserToAddRows = false;
            this.storageGridView.AllowUserToDeleteRows = false;
            this.storageGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storageGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SKT,
            this.ReceiptNo});
            this.storageGridView.Location = new System.Drawing.Point(12, 58);
            this.storageGridView.Name = "storageGridView";
            this.storageGridView.ReadOnly = true;
            this.storageGridView.RowTemplate.Height = 24;
            this.storageGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.storageGridView.Size = new System.Drawing.Size(929, 469);
            this.storageGridView.TabIndex = 21;
            this.storageGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.storageGridView_CellContentClick);
            // 
            // SKT
            // 
            this.SKT.HeaderText = "Tarih";
            this.SKT.Name = "SKT";
            this.SKT.ReadOnly = true;
            this.SKT.Width = 200;
            // 
            // ReceiptNo
            // 
            this.ReceiptNo.HeaderText = "Fiş Numarası";
            this.ReceiptNo.Name = "ReceiptNo";
            this.ReceiptNo.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 50);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ReceiptGridView
            // 
            this.ReceiptGridView.AllowUserToAddRows = false;
            this.ReceiptGridView.AllowUserToDeleteRows = false;
            this.ReceiptGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceiptGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReceiptGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.İsim,
            this.Miktar,
            this.Ödeme});
            this.ReceiptGridView.Location = new System.Drawing.Point(12, 58);
            this.ReceiptGridView.Name = "ReceiptGridView";
            this.ReceiptGridView.ReadOnly = true;
            this.ReceiptGridView.RowTemplate.Height = 24;
            this.ReceiptGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReceiptGridView.Size = new System.Drawing.Size(929, 469);
            this.ReceiptGridView.TabIndex = 23;
            this.ReceiptGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tarih";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fiş Numarası";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // İsim
            // 
            this.İsim.HeaderText = "Ürün Adı";
            this.İsim.Name = "İsim";
            this.İsim.ReadOnly = true;
            // 
            // Miktar
            // 
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.Name = "Miktar";
            this.Miktar.ReadOnly = true;
            // 
            // Ödeme
            // 
            this.Ödeme.HeaderText = "Ödenen Miktar";
            this.Ödeme.Name = "Ödeme";
            this.Ödeme.ReadOnly = true;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 539);
            this.Controls.Add(this.ReceiptGridView);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.storageGridView);
            this.Name = "ReceiptForm";
            this.Text = "ReceiptForm";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storageGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView storageGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptNo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView ReceiptGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn İsim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ödeme;
    }
}