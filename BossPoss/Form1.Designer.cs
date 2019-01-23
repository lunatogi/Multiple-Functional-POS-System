namespace BossPoss
{
    partial class FrmSelling
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainGridView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtboxBarcode = new System.Windows.Forms.TextBox();
            this.btnKey1 = new System.Windows.Forms.Button();
            this.btnKey2 = new System.Windows.Forms.Button();
            this.btnKey3 = new System.Windows.Forms.Button();
            this.btnKey4 = new System.Windows.Forms.Button();
            this.btnKey5 = new System.Windows.Forms.Button();
            this.btnKey6 = new System.Windows.Forms.Button();
            this.btnKey7 = new System.Windows.Forms.Button();
            this.btnKey8 = new System.Windows.Forms.Button();
            this.btnKey9 = new System.Windows.Forms.Button();
            this.btnKeyMulti = new System.Windows.Forms.Button();
            this.lblMultiplayer = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnBSpace = new System.Windows.Forms.Button();
            this.btnStorage = new System.Windows.Forms.Button();
            this.btnSlip = new System.Windows.Forms.Button();
            this.malcins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGridView
            // 
            this.mainGridView.AllowUserToAddRows = false;
            this.mainGridView.AllowUserToDeleteRows = false;
            this.mainGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malcins,
            this.miktar,
            this.tutar,
            this.devTutar,
            this.devBarcode});
            this.mainGridView.Location = new System.Drawing.Point(12, 138);
            this.mainGridView.Name = "mainGridView";
            this.mainGridView.ReadOnly = true;
            this.mainGridView.RowTemplate.Height = 24;
            this.mainGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainGridView.Size = new System.Drawing.Size(487, 334);
            this.mainGridView.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(350, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtboxBarcode
            // 
            this.txtboxBarcode.Location = new System.Drawing.Point(22, 71);
            this.txtboxBarcode.Name = "txtboxBarcode";
            this.txtboxBarcode.Size = new System.Drawing.Size(322, 22);
            this.txtboxBarcode.TabIndex = 2;
            this.txtboxBarcode.Click += new System.EventHandler(this.txtboxBarcode_Click);
            // 
            // btnKey1
            // 
            this.btnKey1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKey1.Location = new System.Drawing.Point(595, 138);
            this.btnKey1.Name = "btnKey1";
            this.btnKey1.Size = new System.Drawing.Size(81, 81);
            this.btnKey1.TabIndex = 3;
            this.btnKey1.Text = "1";
            this.btnKey1.UseVisualStyleBackColor = true;
            this.btnKey1.Click += new System.EventHandler(this.btnKey1_Click);
            // 
            // btnKey2
            // 
            this.btnKey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKey2.Location = new System.Drawing.Point(682, 138);
            this.btnKey2.Name = "btnKey2";
            this.btnKey2.Size = new System.Drawing.Size(81, 81);
            this.btnKey2.TabIndex = 4;
            this.btnKey2.Text = "2";
            this.btnKey2.UseVisualStyleBackColor = true;
            this.btnKey2.Click += new System.EventHandler(this.btnKey2_Click);
            // 
            // btnKey3
            // 
            this.btnKey3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKey3.Location = new System.Drawing.Point(769, 138);
            this.btnKey3.Name = "btnKey3";
            this.btnKey3.Size = new System.Drawing.Size(81, 81);
            this.btnKey3.TabIndex = 5;
            this.btnKey3.Text = "3";
            this.btnKey3.UseVisualStyleBackColor = true;
            this.btnKey3.Click += new System.EventHandler(this.btnKey3_Click);
            // 
            // btnKey4
            // 
            this.btnKey4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKey4.Location = new System.Drawing.Point(595, 225);
            this.btnKey4.Name = "btnKey4";
            this.btnKey4.Size = new System.Drawing.Size(81, 81);
            this.btnKey4.TabIndex = 6;
            this.btnKey4.Text = "4";
            this.btnKey4.UseVisualStyleBackColor = true;
            this.btnKey4.Click += new System.EventHandler(this.btnKey4_Click);
            // 
            // btnKey5
            // 
            this.btnKey5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKey5.Location = new System.Drawing.Point(682, 225);
            this.btnKey5.Name = "btnKey5";
            this.btnKey5.Size = new System.Drawing.Size(81, 81);
            this.btnKey5.TabIndex = 7;
            this.btnKey5.Text = "5";
            this.btnKey5.UseVisualStyleBackColor = true;
            this.btnKey5.Click += new System.EventHandler(this.btnKey5_Click);
            // 
            // btnKey6
            // 
            this.btnKey6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKey6.Location = new System.Drawing.Point(769, 225);
            this.btnKey6.Name = "btnKey6";
            this.btnKey6.Size = new System.Drawing.Size(81, 81);
            this.btnKey6.TabIndex = 8;
            this.btnKey6.Text = "6";
            this.btnKey6.UseVisualStyleBackColor = true;
            this.btnKey6.Click += new System.EventHandler(this.btnKey6_Click);
            // 
            // btnKey7
            // 
            this.btnKey7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKey7.Location = new System.Drawing.Point(595, 312);
            this.btnKey7.Name = "btnKey7";
            this.btnKey7.Size = new System.Drawing.Size(81, 81);
            this.btnKey7.TabIndex = 9;
            this.btnKey7.Text = "7";
            this.btnKey7.UseVisualStyleBackColor = true;
            this.btnKey7.Click += new System.EventHandler(this.btnKey7_Click);
            // 
            // btnKey8
            // 
            this.btnKey8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKey8.Location = new System.Drawing.Point(682, 312);
            this.btnKey8.Name = "btnKey8";
            this.btnKey8.Size = new System.Drawing.Size(81, 81);
            this.btnKey8.TabIndex = 10;
            this.btnKey8.Text = "8";
            this.btnKey8.UseVisualStyleBackColor = true;
            this.btnKey8.Click += new System.EventHandler(this.btnKey8_Click);
            // 
            // btnKey9
            // 
            this.btnKey9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKey9.Location = new System.Drawing.Point(769, 312);
            this.btnKey9.Name = "btnKey9";
            this.btnKey9.Size = new System.Drawing.Size(81, 81);
            this.btnKey9.TabIndex = 11;
            this.btnKey9.Text = "9";
            this.btnKey9.UseVisualStyleBackColor = true;
            this.btnKey9.Click += new System.EventHandler(this.btnKey9_Click);
            // 
            // btnKeyMulti
            // 
            this.btnKeyMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKeyMulti.Location = new System.Drawing.Point(595, 51);
            this.btnKeyMulti.Name = "btnKeyMulti";
            this.btnKeyMulti.Size = new System.Drawing.Size(81, 81);
            this.btnKeyMulti.TabIndex = 12;
            this.btnKeyMulti.Text = "X";
            this.btnKeyMulti.UseVisualStyleBackColor = true;
            this.btnKeyMulti.Click += new System.EventHandler(this.btnKeyMulti_Click);
            // 
            // lblMultiplayer
            // 
            this.lblMultiplayer.AutoSize = true;
            this.lblMultiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMultiplayer.Location = new System.Drawing.Point(682, 93);
            this.lblMultiplayer.Name = "lblMultiplayer";
            this.lblMultiplayer.Size = new System.Drawing.Size(34, 39);
            this.lblMultiplayer.TabIndex = 13;
            this.lblMultiplayer.Text = "x";
            this.lblMultiplayer.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 500);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(374, 491);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(125, 41);
            this.btnBuy.TabIndex = 15;
            this.btnBuy.Text = "SATIN AL";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSum.Location = new System.Drawing.Point(240, 570);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(215, 39);
            this.lblSum.TabIndex = 16;
            this.lblSum.Text = "Toplam: 0.00";
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLog.Location = new System.Drawing.Point(595, 413);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(255, 59);
            this.btnLog.TabIndex = 17;
            this.btnLog.Text = "LOG";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnBSpace
            // 
            this.btnBSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBSpace.Location = new System.Drawing.Point(856, 138);
            this.btnBSpace.Name = "btnBSpace";
            this.btnBSpace.Size = new System.Drawing.Size(81, 81);
            this.btnBSpace.TabIndex = 18;
            this.btnBSpace.Text = "<-";
            this.btnBSpace.UseVisualStyleBackColor = true;
            this.btnBSpace.Click += new System.EventHandler(this.btnBSpace_Click);
            // 
            // btnStorage
            // 
            this.btnStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStorage.Location = new System.Drawing.Point(856, 225);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(81, 81);
            this.btnStorage.TabIndex = 19;
            this.btnStorage.Text = "DEPO";
            this.btnStorage.UseVisualStyleBackColor = true;
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            // 
            // btnSlip
            // 
            this.btnSlip.Location = new System.Drawing.Point(788, 51);
            this.btnSlip.Name = "btnSlip";
            this.btnSlip.Size = new System.Drawing.Size(149, 81);
            this.btnSlip.TabIndex = 20;
            this.btnSlip.Text = "slip bas";
            this.btnSlip.UseVisualStyleBackColor = true;
            this.btnSlip.Click += new System.EventHandler(this.btnSlip_Click);
            // 
            // malcins
            // 
            this.malcins.DataPropertyName = "deneme";
            dataGridViewCellStyle1.NullValue = "asdfdsaf";
            this.malcins.DefaultCellStyle = dataGridViewCellStyle1;
            this.malcins.HeaderText = "Malın Cinsi";
            this.malcins.Name = "malcins";
            this.malcins.ReadOnly = true;
            // 
            // miktar
            // 
            this.miktar.HeaderText = "Miktar";
            this.miktar.Name = "miktar";
            this.miktar.ReadOnly = true;
            // 
            // tutar
            // 
            this.tutar.HeaderText = "Tutar";
            this.tutar.Name = "tutar";
            this.tutar.ReadOnly = true;
            // 
            // devTutar
            // 
            this.devTutar.HeaderText = "devTutar";
            this.devTutar.Name = "devTutar";
            this.devTutar.ReadOnly = true;
            this.devTutar.Visible = false;
            // 
            // devBarcode
            // 
            this.devBarcode.HeaderText = "devBarcode";
            this.devBarcode.Name = "devBarcode";
            this.devBarcode.ReadOnly = true;
            // 
            // FrmSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 679);
            this.Controls.Add(this.btnSlip);
            this.Controls.Add(this.btnStorage);
            this.Controls.Add(this.btnBSpace);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblMultiplayer);
            this.Controls.Add(this.btnKeyMulti);
            this.Controls.Add(this.btnKey9);
            this.Controls.Add(this.btnKey8);
            this.Controls.Add(this.btnKey7);
            this.Controls.Add(this.btnKey6);
            this.Controls.Add(this.btnKey5);
            this.Controls.Add(this.btnKey4);
            this.Controls.Add(this.btnKey3);
            this.Controls.Add(this.btnKey2);
            this.Controls.Add(this.btnKey1);
            this.Controls.Add(this.txtboxBarcode);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.mainGridView);
            this.Name = "FrmSelling";
            this.Text = "Sleepless";
            this.Load += new System.EventHandler(this.FrmSelling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mainGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtboxBarcode;
        private System.Windows.Forms.Button btnKey1;
        private System.Windows.Forms.Button btnKey2;
        private System.Windows.Forms.Button btnKey3;
        private System.Windows.Forms.Button btnKey4;
        private System.Windows.Forms.Button btnKey5;
        private System.Windows.Forms.Button btnKey6;
        private System.Windows.Forms.Button btnKey7;
        private System.Windows.Forms.Button btnKey8;
        private System.Windows.Forms.Button btnKey9;
        private System.Windows.Forms.Button btnKeyMulti;
        private System.Windows.Forms.Label lblMultiplayer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnBSpace;
        private System.Windows.Forms.Button btnStorage;
        private System.Windows.Forms.Button btnSlip;
        private System.Windows.Forms.DataGridViewTextBoxColumn malcins;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn devTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn devBarcode;
    }
}

