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
            this.malcins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnNakitBuy = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.btnBSpace = new System.Windows.Forms.Button();
            this.btnStorage = new System.Windows.Forms.Button();
            this.btnWastage = new System.Windows.Forms.Button();
            this.txtboxFire = new System.Windows.Forms.TextBox();
            this.lblFire = new System.Windows.Forms.Label();
            this.btnFireCancel = new System.Windows.Forms.Button();
            this.btnKey0 = new System.Windows.Forms.Button();
            this.lblMultiX = new System.Windows.Forms.Label();
            this.btnVisaBuy = new System.Windows.Forms.Button();
            this.btnDateControl = new System.Windows.Forms.Button();
            this.btnDivideMoney = new System.Windows.Forms.Button();
            this.txtboxDivideVisa = new System.Windows.Forms.TextBox();
            this.lblDivideVisa = new System.Windows.Forms.Label();
            this.btnDivideEnd = new System.Windows.Forms.Button();
            this.btnCust1 = new System.Windows.Forms.Button();
            this.btnCust6 = new System.Windows.Forms.Button();
            this.btnCust5 = new System.Windows.Forms.Button();
            this.btnCust3 = new System.Windows.Forms.Button();
            this.btnCust4 = new System.Windows.Forms.Button();
            this.btnCust2 = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.btnWaitReceipt = new System.Windows.Forms.Button();
            this.btnWaitingReceipts = new System.Windows.Forms.Button();
            this.txtboxReceiptNote = new System.Windows.Forms.TextBox();
            this.lblReceiptNote = new System.Windows.Forms.Label();
            this.btnDivideCancel = new System.Windows.Forms.Button();
            this.btnCiro = new System.Windows.Forms.Button();
            this.btnTakeDataViaMail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGridView
            // 
            this.mainGridView.AllowUserToAddRows = false;
            this.mainGridView.AllowUserToDeleteRows = false;
            this.mainGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.mainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malcins,
            this.miktar,
            this.tutar,
            this.devTutar,
            this.devBarcode});
            this.mainGridView.Location = new System.Drawing.Point(9, 77);
            this.mainGridView.Margin = new System.Windows.Forms.Padding(2);
            this.mainGridView.MultiSelect = false;
            this.mainGridView.Name = "mainGridView";
            this.mainGridView.ReadOnly = true;
            this.mainGridView.RowTemplate.Height = 24;
            this.mainGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainGridView.Size = new System.Drawing.Size(705, 464);
            this.mainGridView.TabIndex = 0;
            // 
            // malcins
            // 
            this.malcins.DataPropertyName = "deneme";
            dataGridViewCellStyle1.NullValue = "asdfdsaf";
            this.malcins.DefaultCellStyle = dataGridViewCellStyle1;
            this.malcins.HeaderText = "Malın Cinsi";
            this.malcins.Name = "malcins";
            this.malcins.ReadOnly = true;
            this.malcins.Width = 200;
            // 
            // miktar
            // 
            this.miktar.HeaderText = "Miktar";
            this.miktar.Name = "miktar";
            this.miktar.ReadOnly = true;
            this.miktar.Width = 200;
            // 
            // tutar
            // 
            this.tutar.HeaderText = "Tutar";
            this.tutar.Name = "tutar";
            this.tutar.ReadOnly = true;
            this.tutar.Width = 300;
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
            this.devBarcode.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(480, 22);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 51);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtboxBarcode
            // 
            this.txtboxBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxBarcode.Location = new System.Drawing.Point(130, 33);
            this.txtboxBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxBarcode.Multiline = true;
            this.txtboxBarcode.Name = "txtboxBarcode";
            this.txtboxBarcode.Size = new System.Drawing.Size(337, 27);
            this.txtboxBarcode.TabIndex = 2;
            this.txtboxBarcode.Click += new System.EventHandler(this.txtboxBarcode_Click);
            this.txtboxBarcode.TextChanged += new System.EventHandler(this.txtboxBarcode_TextChanged);
            // 
            // btnKey1
            // 
            this.btnKey1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKey1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKey1.Location = new System.Drawing.Point(718, 93);
            this.btnKey1.Margin = new System.Windows.Forms.Padding(2);
            this.btnKey1.Name = "btnKey1";
            this.btnKey1.Size = new System.Drawing.Size(64, 67);
            this.btnKey1.TabIndex = 3;
            this.btnKey1.Text = "1";
            this.btnKey1.UseVisualStyleBackColor = false;
            this.btnKey1.Click += new System.EventHandler(this.btnKey1_Click);
            // 
            // btnKey2
            // 
            this.btnKey2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKey2.Location = new System.Drawing.Point(785, 93);
            this.btnKey2.Margin = new System.Windows.Forms.Padding(2);
            this.btnKey2.Name = "btnKey2";
            this.btnKey2.Size = new System.Drawing.Size(62, 67);
            this.btnKey2.TabIndex = 4;
            this.btnKey2.Text = "2";
            this.btnKey2.UseVisualStyleBackColor = false;
            this.btnKey2.Click += new System.EventHandler(this.btnKey2_Click);
            // 
            // btnKey3
            // 
            this.btnKey3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKey3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKey3.Location = new System.Drawing.Point(850, 93);
            this.btnKey3.Margin = new System.Windows.Forms.Padding(2);
            this.btnKey3.Name = "btnKey3";
            this.btnKey3.Size = new System.Drawing.Size(61, 67);
            this.btnKey3.TabIndex = 5;
            this.btnKey3.Text = "3";
            this.btnKey3.UseVisualStyleBackColor = false;
            this.btnKey3.Click += new System.EventHandler(this.btnKey3_Click);
            // 
            // btnKey4
            // 
            this.btnKey4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKey4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKey4.Location = new System.Drawing.Point(718, 163);
            this.btnKey4.Margin = new System.Windows.Forms.Padding(2);
            this.btnKey4.Name = "btnKey4";
            this.btnKey4.Size = new System.Drawing.Size(64, 68);
            this.btnKey4.TabIndex = 6;
            this.btnKey4.Text = "4";
            this.btnKey4.UseVisualStyleBackColor = false;
            this.btnKey4.Click += new System.EventHandler(this.btnKey4_Click);
            // 
            // btnKey5
            // 
            this.btnKey5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKey5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKey5.Location = new System.Drawing.Point(785, 163);
            this.btnKey5.Margin = new System.Windows.Forms.Padding(2);
            this.btnKey5.Name = "btnKey5";
            this.btnKey5.Size = new System.Drawing.Size(62, 68);
            this.btnKey5.TabIndex = 7;
            this.btnKey5.Text = "5";
            this.btnKey5.UseVisualStyleBackColor = false;
            this.btnKey5.Click += new System.EventHandler(this.btnKey5_Click);
            // 
            // btnKey6
            // 
            this.btnKey6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKey6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKey6.Location = new System.Drawing.Point(850, 163);
            this.btnKey6.Margin = new System.Windows.Forms.Padding(2);
            this.btnKey6.Name = "btnKey6";
            this.btnKey6.Size = new System.Drawing.Size(61, 68);
            this.btnKey6.TabIndex = 8;
            this.btnKey6.Text = "6";
            this.btnKey6.UseVisualStyleBackColor = false;
            this.btnKey6.Click += new System.EventHandler(this.btnKey6_Click);
            // 
            // btnKey7
            // 
            this.btnKey7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKey7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKey7.Location = new System.Drawing.Point(718, 235);
            this.btnKey7.Margin = new System.Windows.Forms.Padding(2);
            this.btnKey7.Name = "btnKey7";
            this.btnKey7.Size = new System.Drawing.Size(64, 66);
            this.btnKey7.TabIndex = 9;
            this.btnKey7.Text = "7";
            this.btnKey7.UseVisualStyleBackColor = false;
            this.btnKey7.Click += new System.EventHandler(this.btnKey7_Click);
            // 
            // btnKey8
            // 
            this.btnKey8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKey8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKey8.Location = new System.Drawing.Point(785, 235);
            this.btnKey8.Margin = new System.Windows.Forms.Padding(2);
            this.btnKey8.Name = "btnKey8";
            this.btnKey8.Size = new System.Drawing.Size(62, 66);
            this.btnKey8.TabIndex = 10;
            this.btnKey8.Text = "8";
            this.btnKey8.UseVisualStyleBackColor = false;
            this.btnKey8.Click += new System.EventHandler(this.btnKey8_Click);
            // 
            // btnKey9
            // 
            this.btnKey9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKey9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKey9.Location = new System.Drawing.Point(850, 235);
            this.btnKey9.Margin = new System.Windows.Forms.Padding(2);
            this.btnKey9.Name = "btnKey9";
            this.btnKey9.Size = new System.Drawing.Size(61, 66);
            this.btnKey9.TabIndex = 11;
            this.btnKey9.Text = "9";
            this.btnKey9.UseVisualStyleBackColor = false;
            this.btnKey9.Click += new System.EventHandler(this.btnKey9_Click);
            // 
            // btnKeyMulti
            // 
            this.btnKeyMulti.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKeyMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKeyMulti.Location = new System.Drawing.Point(719, 21);
            this.btnKeyMulti.Margin = new System.Windows.Forms.Padding(2);
            this.btnKeyMulti.Name = "btnKeyMulti";
            this.btnKeyMulti.Size = new System.Drawing.Size(61, 66);
            this.btnKeyMulti.TabIndex = 12;
            this.btnKeyMulti.Text = "X";
            this.btnKeyMulti.UseVisualStyleBackColor = false;
            this.btnKeyMulti.Click += new System.EventHandler(this.btnKeyMulti_Click);
            // 
            // lblMultiplayer
            // 
            this.lblMultiplayer.AutoSize = true;
            this.lblMultiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMultiplayer.Location = new System.Drawing.Point(806, 57);
            this.lblMultiplayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMultiplayer.Name = "lblMultiplayer";
            this.lblMultiplayer.Size = new System.Drawing.Size(0, 31);
            this.lblMultiplayer.TabIndex = 13;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(605, 22);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 51);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Ürün Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNakitBuy
            // 
            this.btnNakitBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNakitBuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNakitBuy.Location = new System.Drawing.Point(605, 553);
            this.btnNakitBuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnNakitBuy.Name = "btnNakitBuy";
            this.btnNakitBuy.Size = new System.Drawing.Size(110, 54);
            this.btnNakitBuy.TabIndex = 15;
            this.btnNakitBuy.Text = "NAKİT";
            this.btnNakitBuy.UseVisualStyleBackColor = false;
            this.btnNakitBuy.Click += new System.EventHandler(this.btnNakitBuy_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSum.Location = new System.Drawing.Point(500, 619);
            this.lblSum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(215, 39);
            this.lblSum.TabIndex = 16;
            this.lblSum.Text = "Toplam: 0.00";
            // 
            // btnBSpace
            // 
            this.btnBSpace.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBSpace.Location = new System.Drawing.Point(914, 93);
            this.btnBSpace.Margin = new System.Windows.Forms.Padding(2);
            this.btnBSpace.Name = "btnBSpace";
            this.btnBSpace.Size = new System.Drawing.Size(62, 67);
            this.btnBSpace.TabIndex = 18;
            this.btnBSpace.Text = "<-";
            this.btnBSpace.UseVisualStyleBackColor = false;
            this.btnBSpace.Click += new System.EventHandler(this.btnBSpace_Click);
            // 
            // btnStorage
            // 
            this.btnStorage.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStorage.Location = new System.Drawing.Point(914, 163);
            this.btnStorage.Margin = new System.Windows.Forms.Padding(2);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(62, 68);
            this.btnStorage.TabIndex = 19;
            this.btnStorage.Text = "DEPO";
            this.btnStorage.UseVisualStyleBackColor = false;
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            // 
            // btnWastage
            // 
            this.btnWastage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWastage.Location = new System.Drawing.Point(1025, 588);
            this.btnWastage.Margin = new System.Windows.Forms.Padding(2);
            this.btnWastage.Name = "btnWastage";
            this.btnWastage.Size = new System.Drawing.Size(191, 48);
            this.btnWastage.TabIndex = 21;
            this.btnWastage.Text = "Promosyon";
            this.btnWastage.UseVisualStyleBackColor = true;
            this.btnWastage.Click += new System.EventHandler(this.btnWastage_Click);
            // 
            // txtboxFire
            // 
            this.txtboxFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxFire.Location = new System.Drawing.Point(1026, 646);
            this.txtboxFire.Multiline = true;
            this.txtboxFire.Name = "txtboxFire";
            this.txtboxFire.Size = new System.Drawing.Size(139, 34);
            this.txtboxFire.TabIndex = 22;
            this.txtboxFire.Visible = false;
            // 
            // lblFire
            // 
            this.lblFire.AutoSize = true;
            this.lblFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFire.Location = new System.Drawing.Point(1169, 646);
            this.lblFire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFire.Name = "lblFire";
            this.lblFire.Size = new System.Drawing.Size(140, 31);
            this.lblFire.TabIndex = 23;
            this.lblFire.Text = "TL Ödendi";
            this.lblFire.Visible = false;
            // 
            // btnFireCancel
            // 
            this.btnFireCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFireCancel.Location = new System.Drawing.Point(1219, 591);
            this.btnFireCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnFireCancel.Name = "btnFireCancel";
            this.btnFireCancel.Size = new System.Drawing.Size(94, 48);
            this.btnFireCancel.TabIndex = 24;
            this.btnFireCancel.Text = "Promosyon İptal";
            this.btnFireCancel.UseVisualStyleBackColor = true;
            this.btnFireCancel.Visible = false;
            this.btnFireCancel.Click += new System.EventHandler(this.btnFireCancel_Click);
            // 
            // btnKey0
            // 
            this.btnKey0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKey0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKey0.Location = new System.Drawing.Point(914, 235);
            this.btnKey0.Margin = new System.Windows.Forms.Padding(2);
            this.btnKey0.Name = "btnKey0";
            this.btnKey0.Size = new System.Drawing.Size(62, 66);
            this.btnKey0.TabIndex = 25;
            this.btnKey0.Text = "0";
            this.btnKey0.UseVisualStyleBackColor = false;
            this.btnKey0.Click += new System.EventHandler(this.btnKey0_Click);
            // 
            // lblMultiX
            // 
            this.lblMultiX.AutoSize = true;
            this.lblMultiX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMultiX.Location = new System.Drawing.Point(779, 57);
            this.lblMultiX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMultiX.Name = "lblMultiX";
            this.lblMultiX.Size = new System.Drawing.Size(27, 31);
            this.lblMultiX.TabIndex = 26;
            this.lblMultiX.Text = "x";
            this.lblMultiX.Visible = false;
            // 
            // btnVisaBuy
            // 
            this.btnVisaBuy.BackColor = System.Drawing.Color.White;
            this.btnVisaBuy.Location = new System.Drawing.Point(468, 553);
            this.btnVisaBuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisaBuy.Name = "btnVisaBuy";
            this.btnVisaBuy.Size = new System.Drawing.Size(117, 54);
            this.btnVisaBuy.TabIndex = 27;
            this.btnVisaBuy.Text = "VISA";
            this.btnVisaBuy.UseVisualStyleBackColor = false;
            this.btnVisaBuy.Click += new System.EventHandler(this.btnVisaBuy_Click);
            // 
            // btnDateControl
            // 
            this.btnDateControl.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDateControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDateControl.Location = new System.Drawing.Point(878, 588);
            this.btnDateControl.Margin = new System.Windows.Forms.Padding(2);
            this.btnDateControl.Name = "btnDateControl";
            this.btnDateControl.Size = new System.Drawing.Size(140, 48);
            this.btnDateControl.TabIndex = 28;
            this.btnDateControl.Text = " TARİH KONTROL";
            this.btnDateControl.UseVisualStyleBackColor = false;
            this.btnDateControl.Click += new System.EventHandler(this.btnDateControl_Click);
            // 
            // btnDivideMoney
            // 
            this.btnDivideMoney.Location = new System.Drawing.Point(9, 553);
            this.btnDivideMoney.Margin = new System.Windows.Forms.Padding(2);
            this.btnDivideMoney.Name = "btnDivideMoney";
            this.btnDivideMoney.Size = new System.Drawing.Size(115, 54);
            this.btnDivideMoney.TabIndex = 29;
            this.btnDivideMoney.Text = "Parayı Böl";
            this.btnDivideMoney.UseVisualStyleBackColor = true;
            this.btnDivideMoney.Click += new System.EventHandler(this.btnDivideMoney_Click);
            // 
            // txtboxDivideVisa
            // 
            this.txtboxDivideVisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxDivideVisa.Location = new System.Drawing.Point(9, 613);
            this.txtboxDivideVisa.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxDivideVisa.Multiline = true;
            this.txtboxDivideVisa.Name = "txtboxDivideVisa";
            this.txtboxDivideVisa.Size = new System.Drawing.Size(95, 33);
            this.txtboxDivideVisa.TabIndex = 30;
            this.txtboxDivideVisa.Visible = false;
            // 
            // lblDivideVisa
            // 
            this.lblDivideVisa.AutoSize = true;
            this.lblDivideVisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDivideVisa.Location = new System.Drawing.Point(106, 612);
            this.lblDivideVisa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDivideVisa.Name = "lblDivideVisa";
            this.lblDivideVisa.Size = new System.Drawing.Size(106, 31);
            this.lblDivideVisa.TabIndex = 31;
            this.lblDivideVisa.Text = "TL Visa";
            this.lblDivideVisa.Visible = false;
            // 
            // btnDivideEnd
            // 
            this.btnDivideEnd.Location = new System.Drawing.Point(9, 653);
            this.btnDivideEnd.Margin = new System.Windows.Forms.Padding(2);
            this.btnDivideEnd.Name = "btnDivideEnd";
            this.btnDivideEnd.Size = new System.Drawing.Size(94, 33);
            this.btnDivideEnd.TabIndex = 32;
            this.btnDivideEnd.Text = "Böl";
            this.btnDivideEnd.UseVisualStyleBackColor = true;
            this.btnDivideEnd.Visible = false;
            this.btnDivideEnd.Click += new System.EventHandler(this.btnDivideEnd_Click);
            // 
            // btnCust1
            // 
            this.btnCust1.BackColor = System.Drawing.Color.Silver;
            this.btnCust1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCust1.Location = new System.Drawing.Point(719, 445);
            this.btnCust1.Margin = new System.Windows.Forms.Padding(2);
            this.btnCust1.Name = "btnCust1";
            this.btnCust1.Size = new System.Drawing.Size(89, 66);
            this.btnCust1.TabIndex = 33;
            this.btnCust1.Text = "Negro";
            this.btnCust1.UseVisualStyleBackColor = false;
            this.btnCust1.Click += new System.EventHandler(this.btnCust1_Click);
            // 
            // btnCust6
            // 
            this.btnCust6.BackColor = System.Drawing.Color.DimGray;
            this.btnCust6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCust6.ForeColor = System.Drawing.Color.Black;
            this.btnCust6.Location = new System.Drawing.Point(812, 307);
            this.btnCust6.Margin = new System.Windows.Forms.Padding(2);
            this.btnCust6.Name = "btnCust6";
            this.btnCust6.Size = new System.Drawing.Size(80, 66);
            this.btnCust6.TabIndex = 34;
            this.btnCust6.Text = "Item6";
            this.btnCust6.UseVisualStyleBackColor = false;
            // 
            // btnCust5
            // 
            this.btnCust5.BackColor = System.Drawing.Color.Silver;
            this.btnCust5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCust5.Location = new System.Drawing.Point(812, 514);
            this.btnCust5.Margin = new System.Windows.Forms.Padding(2);
            this.btnCust5.Name = "btnCust5";
            this.btnCust5.Size = new System.Drawing.Size(80, 66);
            this.btnCust5.TabIndex = 35;
            this.btnCust5.Text = "Item5";
            this.btnCust5.UseVisualStyleBackColor = false;
            // 
            // btnCust3
            // 
            this.btnCust3.BackColor = System.Drawing.Color.DimGray;
            this.btnCust3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCust3.ForeColor = System.Drawing.Color.Black;
            this.btnCust3.Location = new System.Drawing.Point(719, 307);
            this.btnCust3.Margin = new System.Windows.Forms.Padding(2);
            this.btnCust3.Name = "btnCust3";
            this.btnCust3.Size = new System.Drawing.Size(89, 66);
            this.btnCust3.TabIndex = 36;
            this.btnCust3.Text = "Item3";
            this.btnCust3.UseVisualStyleBackColor = false;
            // 
            // btnCust4
            // 
            this.btnCust4.BackColor = System.Drawing.Color.Silver;
            this.btnCust4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCust4.Location = new System.Drawing.Point(812, 445);
            this.btnCust4.Margin = new System.Windows.Forms.Padding(2);
            this.btnCust4.Name = "btnCust4";
            this.btnCust4.Size = new System.Drawing.Size(80, 66);
            this.btnCust4.TabIndex = 37;
            this.btnCust4.Text = "Item4";
            this.btnCust4.UseVisualStyleBackColor = false;
            // 
            // btnCust2
            // 
            this.btnCust2.BackColor = System.Drawing.Color.Silver;
            this.btnCust2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCust2.Location = new System.Drawing.Point(719, 514);
            this.btnCust2.Margin = new System.Windows.Forms.Padding(2);
            this.btnCust2.Name = "btnCust2";
            this.btnCust2.Size = new System.Drawing.Size(89, 66);
            this.btnCust2.TabIndex = 38;
            this.btnCust2.Text = "Pepsi Max";
            this.btnCust2.UseVisualStyleBackColor = false;
            this.btnCust2.Click += new System.EventHandler(this.btnCust2_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReceipt.Location = new System.Drawing.Point(731, 589);
            this.btnReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(140, 47);
            this.btnReceipt.TabIndex = 39;
            this.btnReceipt.Text = "Geçmiş Fişler";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(719, 374);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 67);
            this.button1.TabIndex = 40;
            this.button1.Text = "Item6";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(812, 374);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 67);
            this.button2.TabIndex = 41;
            this.button2.Text = "Item6";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(894, 445);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 66);
            this.button3.TabIndex = 42;
            this.button3.Text = "Item6";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(894, 514);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 65);
            this.button4.TabIndex = 43;
            this.button4.Text = "Item6";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(894, 307);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 66);
            this.button5.TabIndex = 44;
            this.button5.Text = "Item6";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DimGray;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(894, 374);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 67);
            this.button6.TabIndex = 45;
            this.button6.Text = "Item6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DimGray;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(1154, 374);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 67);
            this.button7.TabIndex = 57;
            this.button7.Text = "Item6";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DimGray;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(1154, 307);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 66);
            this.button8.TabIndex = 56;
            this.button8.Text = "Item6";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Silver;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(1154, 514);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 65);
            this.button9.TabIndex = 55;
            this.button9.Text = "Item6";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Silver;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Location = new System.Drawing.Point(1154, 445);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(82, 66);
            this.button10.TabIndex = 54;
            this.button10.Text = "Item6";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DimGray;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Location = new System.Drawing.Point(1071, 374);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(80, 67);
            this.button11.TabIndex = 53;
            this.button11.Text = "Item6";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.DimGray;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.ForeColor = System.Drawing.Color.Black;
            this.button12.Location = new System.Drawing.Point(979, 374);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(89, 67);
            this.button12.TabIndex = 52;
            this.button12.Text = "Item6";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Silver;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button13.Location = new System.Drawing.Point(979, 514);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(89, 66);
            this.button13.TabIndex = 51;
            this.button13.Text = "Pepsi Max";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Silver;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button14.Location = new System.Drawing.Point(1071, 445);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(80, 66);
            this.button14.TabIndex = 50;
            this.button14.Text = "Item4";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.DimGray;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15.ForeColor = System.Drawing.Color.Black;
            this.button15.Location = new System.Drawing.Point(979, 307);
            this.button15.Margin = new System.Windows.Forms.Padding(2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(89, 66);
            this.button15.TabIndex = 49;
            this.button15.Text = "Item3";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Silver;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button16.Location = new System.Drawing.Point(1071, 514);
            this.button16.Margin = new System.Windows.Forms.Padding(2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(80, 66);
            this.button16.TabIndex = 48;
            this.button16.Text = "Item5";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.DimGray;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button17.ForeColor = System.Drawing.Color.Black;
            this.button17.Location = new System.Drawing.Point(1071, 307);
            this.button17.Margin = new System.Windows.Forms.Padding(2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(80, 66);
            this.button17.TabIndex = 47;
            this.button17.Text = "Item6";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Silver;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button18.Location = new System.Drawing.Point(979, 445);
            this.button18.Margin = new System.Windows.Forms.Padding(2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(89, 66);
            this.button18.TabIndex = 46;
            this.button18.Text = "Negro";
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.DimGray;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button19.ForeColor = System.Drawing.Color.Black;
            this.button19.Location = new System.Drawing.Point(1240, 374);
            this.button19.Margin = new System.Windows.Forms.Padding(2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(82, 67);
            this.button19.TabIndex = 69;
            this.button19.Text = "Item6";
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.DimGray;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button20.ForeColor = System.Drawing.Color.Black;
            this.button20.Location = new System.Drawing.Point(1240, 307);
            this.button20.Margin = new System.Windows.Forms.Padding(2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(82, 66);
            this.button20.TabIndex = 68;
            this.button20.Text = "Item6";
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Silver;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button21.Location = new System.Drawing.Point(1240, 514);
            this.button21.Margin = new System.Windows.Forms.Padding(2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(82, 65);
            this.button21.TabIndex = 67;
            this.button21.Text = "Item6";
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Silver;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button22.Location = new System.Drawing.Point(1240, 445);
            this.button22.Margin = new System.Windows.Forms.Padding(2);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(82, 66);
            this.button22.TabIndex = 66;
            this.button22.Text = "Item6";
            this.button22.UseVisualStyleBackColor = false;
            // 
            // btnWaitReceipt
            // 
            this.btnWaitReceipt.BackColor = System.Drawing.Color.LightBlue;
            this.btnWaitReceipt.Location = new System.Drawing.Point(1072, 105);
            this.btnWaitReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.btnWaitReceipt.Name = "btnWaitReceipt";
            this.btnWaitReceipt.Size = new System.Drawing.Size(112, 41);
            this.btnWaitReceipt.TabIndex = 70;
            this.btnWaitReceipt.Text = "Fişi Beklet";
            this.btnWaitReceipt.UseVisualStyleBackColor = false;
            this.btnWaitReceipt.Click += new System.EventHandler(this.btnWaitReceipt_Click);
            // 
            // btnWaitingReceipts
            // 
            this.btnWaitingReceipts.BackColor = System.Drawing.Color.LightBlue;
            this.btnWaitingReceipts.Location = new System.Drawing.Point(1072, 150);
            this.btnWaitingReceipts.Margin = new System.Windows.Forms.Padding(2);
            this.btnWaitingReceipts.Name = "btnWaitingReceipts";
            this.btnWaitingReceipts.Size = new System.Drawing.Size(112, 41);
            this.btnWaitingReceipts.TabIndex = 71;
            this.btnWaitingReceipts.Text = "Bekleyen Fişler";
            this.btnWaitingReceipts.UseVisualStyleBackColor = false;
            this.btnWaitingReceipts.Click += new System.EventHandler(this.btnWaitingReceipts_Click);
            // 
            // txtboxReceiptNote
            // 
            this.txtboxReceiptNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxReceiptNote.Location = new System.Drawing.Point(1071, 68);
            this.txtboxReceiptNote.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxReceiptNote.Multiline = true;
            this.txtboxReceiptNote.Name = "txtboxReceiptNote";
            this.txtboxReceiptNote.Size = new System.Drawing.Size(113, 33);
            this.txtboxReceiptNote.TabIndex = 72;
            // 
            // lblReceiptNote
            // 
            this.lblReceiptNote.AutoSize = true;
            this.lblReceiptNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReceiptNote.Location = new System.Drawing.Point(981, 70);
            this.lblReceiptNote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReceiptNote.Name = "lblReceiptNote";
            this.lblReceiptNote.Size = new System.Drawing.Size(90, 25);
            this.lblReceiptNote.TabIndex = 73;
            this.lblReceiptNote.Text = "Fiş Notu:";
            // 
            // btnDivideCancel
            // 
            this.btnDivideCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDivideCancel.Location = new System.Drawing.Point(107, 653);
            this.btnDivideCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDivideCancel.Name = "btnDivideCancel";
            this.btnDivideCancel.Size = new System.Drawing.Size(94, 33);
            this.btnDivideCancel.TabIndex = 74;
            this.btnDivideCancel.Text = "İptal";
            this.btnDivideCancel.UseVisualStyleBackColor = false;
            this.btnDivideCancel.Visible = false;
            this.btnDivideCancel.Click += new System.EventHandler(this.btnDivideCancel_Click);
            // 
            // btnCiro
            // 
            this.btnCiro.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCiro.Location = new System.Drawing.Point(1072, 195);
            this.btnCiro.Margin = new System.Windows.Forms.Padding(2);
            this.btnCiro.Name = "btnCiro";
            this.btnCiro.Size = new System.Drawing.Size(112, 41);
            this.btnCiro.TabIndex = 75;
            this.btnCiro.Text = "Ciro Göstergesi";
            this.btnCiro.UseVisualStyleBackColor = false;
            this.btnCiro.Click += new System.EventHandler(this.btnCiro_Click);
            // 
            // btnTakeDataViaMail
            // 
            this.btnTakeDataViaMail.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTakeDataViaMail.Location = new System.Drawing.Point(1072, 240);
            this.btnTakeDataViaMail.Margin = new System.Windows.Forms.Padding(2);
            this.btnTakeDataViaMail.Name = "btnTakeDataViaMail";
            this.btnTakeDataViaMail.Size = new System.Drawing.Size(112, 41);
            this.btnTakeDataViaMail.TabIndex = 76;
            this.btnTakeDataViaMail.Text = "Depoyu Optimize Et";
            this.btnTakeDataViaMail.UseVisualStyleBackColor = false;
            this.btnTakeDataViaMail.Click += new System.EventHandler(this.btnTakeDataViaMail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 77;
            this.label1.Text = "Barkod No :";
            // 
            // FrmSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 765);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTakeDataViaMail);
            this.Controls.Add(this.btnCiro);
            this.Controls.Add(this.btnDivideCancel);
            this.Controls.Add(this.lblReceiptNote);
            this.Controls.Add(this.txtboxReceiptNote);
            this.Controls.Add(this.btnWaitingReceipts);
            this.Controls.Add(this.btnWaitReceipt);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.btnCust2);
            this.Controls.Add(this.btnCust4);
            this.Controls.Add(this.btnCust3);
            this.Controls.Add(this.btnCust5);
            this.Controls.Add(this.btnCust6);
            this.Controls.Add(this.btnCust1);
            this.Controls.Add(this.btnDivideEnd);
            this.Controls.Add(this.lblDivideVisa);
            this.Controls.Add(this.txtboxDivideVisa);
            this.Controls.Add(this.btnDivideMoney);
            this.Controls.Add(this.btnDateControl);
            this.Controls.Add(this.btnVisaBuy);
            this.Controls.Add(this.lblMultiX);
            this.Controls.Add(this.btnKey0);
            this.Controls.Add(this.btnFireCancel);
            this.Controls.Add(this.lblFire);
            this.Controls.Add(this.txtboxFire);
            this.Controls.Add(this.btnWastage);
            this.Controls.Add(this.btnStorage);
            this.Controls.Add(this.btnBSpace);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.btnNakitBuy);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnNakitBuy;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Button btnBSpace;
        private System.Windows.Forms.Button btnStorage;
        private System.Windows.Forms.Button btnWastage;
        private System.Windows.Forms.TextBox txtboxFire;
        private System.Windows.Forms.Label lblFire;
        private System.Windows.Forms.Button btnFireCancel;
        private System.Windows.Forms.Button btnKey0;
        private System.Windows.Forms.Label lblMultiX;
        private System.Windows.Forms.Button btnVisaBuy;
        private System.Windows.Forms.Button btnDateControl;
        private System.Windows.Forms.Button btnDivideMoney;
        private System.Windows.Forms.TextBox txtboxDivideVisa;
        private System.Windows.Forms.Label lblDivideVisa;
        private System.Windows.Forms.Button btnDivideEnd;
        private System.Windows.Forms.Button btnCust1;
        private System.Windows.Forms.Button btnCust6;
        private System.Windows.Forms.Button btnCust5;
        private System.Windows.Forms.Button btnCust3;
        private System.Windows.Forms.Button btnCust4;
        private System.Windows.Forms.Button btnCust2;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button btnWaitReceipt;
        private System.Windows.Forms.Button btnWaitingReceipts;
        private System.Windows.Forms.TextBox txtboxReceiptNote;
        private System.Windows.Forms.Label lblReceiptNote;
        private System.Windows.Forms.Button btnDivideCancel;
        private System.Windows.Forms.Button btnCiro;
        private System.Windows.Forms.Button btnTakeDataViaMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn malcins;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn devTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn devBarcode;
    }
}

