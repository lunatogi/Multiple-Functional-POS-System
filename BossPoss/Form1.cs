using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BossPoss
{
    public partial class FrmSelling : Form
    {
        
        public FrmSelling()
        {
            InitializeComponent();
        }
        int i = 0;

        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=BossPoss;Integrated Security=True");
        int multiplyer = 1;                         
        bool boolMultiplayer = false;
        bool boolDivide = false;
        double divideVisa = 0;
        double sum = 0;
        int receiptNo = 1;
        bool fire = false;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Scanned(null);
        }

        string converter = "";      //Kaçla çarpılacağını belirlemek ve aynı zamanda ekrana yazmak için var
        private void btnKeyMulti_Click(object sender, EventArgs e)
        {
            boolMultiplayer = true;
            lblMultiX.Visible = true;
        }

        private void btnKey1_Click(object sender, EventArgs e)
        {
            KeyButtons(1);
        }

        private void btnKey2_Click(object sender, EventArgs e)
        {
            KeyButtons(2);
        }

        private void btnKey3_Click(object sender, EventArgs e)
        {
            KeyButtons(3);
        }

        private void btnKey4_Click(object sender, EventArgs e)
        {
            KeyButtons(4);
        }

        private void btnKey5_Click(object sender, EventArgs e)
        {
            KeyButtons(5);
        }

        private void btnKey6_Click(object sender, EventArgs e)
        {
            KeyButtons(6);
        }

        private void btnKey7_Click(object sender, EventArgs e)
        {
            KeyButtons(7);
        }

        private void btnKey8_Click(object sender, EventArgs e)
        {
            KeyButtons(8);
        }

        private void btnKey9_Click(object sender, EventArgs e)
        {
            KeyButtons(9);
        }
        
        private void btnKey0_Click(object sender, EventArgs e)
        {
            KeyButtons(0);
        }

        private void KeyButtons(int number)
        {
            if (boolMultiplayer)
            {
                converter += number.ToString();
                lblMultiplayer.Text = converter;
            }else if (fire)
            {
                txtboxFire.Text += number.ToString();
            }
            else
            {
                txtboxBarcode.Text += number.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow gr = mainGridView.CurrentRow;
                sum -= Convert.ToDouble(gr.Cells[3].Value);
                lblSum.Text = "Toplam: " + sum.ToString() + "TL";
                mainGridView.Rows.Remove(gr);
            }
            catch { }
        }

        private void btnBuy(string vn, bool divided)
        {
            AddToLog(vn, divided);
            sum = 0;
            lblMultiplayer.Text = "";
            lblMultiX.Visible = false;
            mainGridView.Rows.Clear();
            lblSum.Text = "Toplam: 0.00";
            btnFireCancel.Visible = false;
            txtboxFire.Text = "";
            txtboxFire.Visible = false;
            lblFire.Visible = false;
        }

        private void Scanned(string comingBarcode)  //happens when barcode is read
        {
            string barcode = "";
            if (comingBarcode == null)
                barcode = txtboxBarcode.Text;
            else
                barcode = comingBarcode;
            connection.Open();
            SqlCommand cmdTakingData = new SqlCommand("Select *from Depo", connection);

            SqlDataReader reader = cmdTakingData.ExecuteReader();
            int executedItemCount = 0;
            int leftItemCount = 0;
            
            while (reader.Read())       
            {
                if (barcode == reader["barcode"].ToString())
                {
                    if (converter != "" && converter != null)
                        multiplyer = Convert.ToInt32(converter);
                    barcode = reader["barcode"].ToString();
                    i = mainGridView.Rows.Add();
                    MessageBox.Show("Ürün girdi");
                    mainGridView.Rows[i].Cells[0].Value = reader["name"].ToString();
                    mainGridView.Rows[i].Cells[1].Value = (multiplyer).ToString();
                    executedItemCount = 1 * multiplyer;
                    leftItemCount = (Convert.ToInt32(reader["piece"])) - executedItemCount;
                    mainGridView.Rows[i].Cells[2].Value = (executedItemCount * Convert.ToDouble(reader["price"])).ToString() +" TL";
                    mainGridView.Rows[i].Cells[3].Value = (executedItemCount * Convert.ToDouble(reader["price"])).ToString();
                    mainGridView.Rows[i].Cells[4].Value = barcode;
                }
            }
            connection.Close();
            //connection.Open();
            //SqlCommand cmdUpdate = new SqlCommand("Update Depo set piece='" + leftItemCount + "' where barcode= " + barcode + "", connection);
            //cmdUpdate.ExecuteNonQuery();
            //connection.Close();
            multiplyer = 1;
            txtboxBarcode.Text = "";
            lblMultiplayer.Text = "";
            converter = "";
            sum += Convert.ToDouble(mainGridView.Rows[mainGridView.RowCount - 1].Cells[3].Value);
            lblSum.Text = "Toplam: " + sum.ToString() + " TL";
        }
        
        private void AddToLog(string vn, bool divided)     //After pressing "buy" data will be stored at the database
        {
            connection.Open();
            string itemName = "";
            double sumPrice = 0;
            int piece = 0;
            int oldPiece = 0;
            int newPiece = 0;
            string barcode = "";
            string vnForLog = "";
            for (int t = 0; t < mainGridView.RowCount; t++)
            {
                barcode = mainGridView.Rows[t].Cells[4].Value.ToString();
                itemName = mainGridView.Rows[t].Cells[0].Value.ToString();
                if (!fire)
                {
                    sumPrice = Convert.ToDouble(mainGridView.Rows[t].Cells[3].Value);
                    piece = Convert.ToInt32(mainGridView.Rows[t].Cells[1].Value);       //Because date-time insertation is different in the foreign countries we need to change month and day's places with the code below
                    DateTime currenDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                    if (!divided)
                        vnForLog = vn;
                    else
                        vnForLog = "Visa-Nakit";
                    SqlCommand cmdInsert = new SqlCommand("INSERT INTO Log (item, sumPrice, piece, date, receipt, vn) Values ('" + itemName + "' , '" + sumPrice.ToString() + "' , '" + piece.ToString() + "' , '" + currenDateTime.ToString("yyyy-MM-dd") + "' , '" + receiptNo.ToString() + "' , '" + vnForLog + "')", connection);
                    cmdInsert.ExecuteNonQuery();
                    //connection.Close();
                    //connection.Open();
                    if (!boolDivide)
                    {
                        SqlCommand cmdVnInsert = new SqlCommand("INSERT INTO Vn (vn, quantity) Values ('" + vn.ToString() + "', '" + sumPrice.ToString() + "')", connection);
                        cmdVnInsert.ExecuteNonQuery();
                    }
                    else if (boolDivide)
                    {
                        double leftDivide = 0;
                        divideVisa = Convert.ToDouble(txtboxDivideVisa.Text);
                        leftDivide = sumPrice - divideVisa;
                        MessageBox.Show(divideVisa.ToString());
                        SqlCommand cmdVnInsert = new SqlCommand("INSERT INTO Vn (vn, quantity) Values ('" + vn.ToString() + "', '" + divideVisa.ToString() + "')", connection);
                        cmdVnInsert.ExecuteNonQuery();
                        connection.Close();
                        connection.Open();
                        MessageBox.Show(leftDivide.ToString());
                        SqlCommand cmdVnInsert2 = new SqlCommand("INSERT INTO Vn (vn, quantity) Values ('" + "Nakit" + "', '" + leftDivide.ToString() + "')", connection);
                        cmdVnInsert2.ExecuteNonQuery();
                        txtboxDivideVisa.Text = "";
                        txtboxDivideVisa.Visible = false;
                        lblDivideVisa.Visible = false;
                        btnDivideEnd.Visible = false;
                        boolDivide = false;
                    }
                }
                else
                {
                    try { 
                        sumPrice = Convert.ToDouble(txtboxFire.Text);
                    }
                    catch
                    {
                        sumPrice = 0;
                    }
                    piece = Convert.ToInt32(mainGridView.Rows[t].Cells[1].Value);       //Because date-time insertation is different in the foreign countries we need to change month and day's places with the code below
                    DateTime currenDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                    SqlCommand cmdInsert = new SqlCommand("INSERT INTO Log (item, sumPrice, piece, date, receipt) Values ('" + itemName + "' , '" + "*" + sumPrice.ToString() + "' , '" + piece.ToString() + "' , '" + currenDateTime.ToString("yyyy-MM-dd") + "' , '" + receiptNo.ToString() + "')", connection);
                    cmdInsert.ExecuteNonQuery();
                    SqlCommand cmdVnInsert = new SqlCommand("INSERT INTO Vn (vn, quantity) Values ('" + vn.ToString() + "', '" + sumPrice.ToString() + "')", connection);
                    cmdVnInsert.ExecuteNonQuery();
                }
                connection.Close();
                connection.Open();
                SqlCommand cmdTakingData = new SqlCommand("Select *from Depo", connection);
                SqlDataReader reader = cmdTakingData.ExecuteReader();
                while (reader.Read())
                {
                    if (barcode == reader["barcode"].ToString())
                        oldPiece = Convert.ToInt32(reader["piece"]);
                }
                MessageBox.Show(barcode.ToString());
                newPiece = oldPiece - piece;
                connection.Close();
                connection.Open();
                SqlCommand cmdMinuesPiece = new SqlCommand("Update Depo set piece='" + newPiece.ToString() + "' where barcode= " + Convert.ToUInt64(barcode) + "", connection);
                cmdMinuesPiece.ExecuteNonQuery();
            }
            connection.Close();
            MessageBox.Show(boolDivide.ToString());
        }

        private void btnBSpace_Click(object sender, EventArgs e)
        {
            try
            {
                if (boolMultiplayer)
                {
                    converter = converter.Remove(converter.Length - 1);
                    lblMultiplayer.Text = converter;
                }else if (fire)
                {
                    txtboxFire.Text = txtboxFire.Text.Remove(txtboxFire.Text.Length - 1);
                }
                else 
                {
                    txtboxBarcode.Text = txtboxBarcode.Text.Remove(txtboxBarcode.Text.Length - 1);
                }
            }
            catch {  }
        }

        private void txtboxBarcode_Click(object sender, EventArgs e)
        {
            boolMultiplayer = false;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand takeLog = new SqlCommand("Select * from Log", connection);
            SqlDataReader reader = takeLog.ExecuteReader();
            while (reader.Read())
            {
                Console.Write("girdi");
                DateTime lol = new DateTime();
                lol = Convert.ToDateTime(reader["date"]);
                MessageBox.Show(lol.Day.ToString(),DateTime.Now.Day.ToString());
                /*if (lol.Day == DateTime.Now.Day)
                {
                    MessageBox.Show("loool", "lol");
                }*/
            }
            connection.Close();
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            StorageForm stForm = new StorageForm();
            stForm.Show();
        }
        
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            ev.Graphics.DrawString("Made By Murat Utku Keti", new System.Drawing.Font("Times New Roman", 14, System.Drawing.FontStyle.Bold), Brushes.Black, 20, 20);
        }

        private void btnSlip_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.PaperSize = new PaperSize("A6", 413, 517);
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            pd.Print();
        }

        private void btnWastage_Click(object sender, EventArgs e)
        {
            fire = true;
            txtboxFire.Visible = true;
            lblFire.Visible = true;
            btnFireCancel.Visible = true;
        }

        private void btnFireCancel_Click(object sender, EventArgs e)
        {
            fire = false;
            txtboxFire.Text = "";
            txtboxFire.Visible = false;
            lblFire.Visible = false;
            btnFireCancel.Visible = false;
        }

        private void FrmSelling_Load(object sender, EventArgs e)
        {

        }

        private void btnVisaBuy_Click(object sender, EventArgs e)
        {
            ReceiptNoChecker();
            boolDivide = false;
            txtboxDivideVisa.Text = "";
            txtboxDivideVisa.Visible = false;
            lblDivideVisa.Visible = false;
            btnDivideEnd.Visible = false;
            btnBuy("Visa", false);
        }

        private void btnNakitBuy_Click(object sender, EventArgs e)
        {
            ReceiptNoChecker();
            boolDivide = false;
            txtboxDivideVisa.Text = "";
            txtboxDivideVisa.Visible = false;
            lblDivideVisa.Visible = false;
            btnDivideEnd.Visible = false;
            btnBuy("Nakit", false);
        }

        private void btnDateControl_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmdCheckDate = new SqlCommand("SELECT *from Depo", connection);
            SqlDataReader reader = cmdCheckDate.ExecuteReader();

            int expiredItemCount = 0;
            while (reader.Read())
            {
                DateTime currentTime = DateTime.Today;
                DateTime itemTime = Convert.ToDateTime(reader["skt"]);
                TimeSpan timeDifference = itemTime - currentTime;
                int difference = Convert.ToInt32(timeDifference.Days);
                if (difference <= 365)
                {
                   expiredItemCount++;
                }
            }
            connection.Close();

            connection.Open();
            SqlCommand cmdCheckDate2 = new SqlCommand("SELECT *from Depo", connection);
            SqlDataReader reader2 = cmdCheckDate2.ExecuteReader();
            MessageBox.Show(expiredItemCount.ToString());
            string[] expireDangers = new string[expiredItemCount + 1];
            expireDangers[0] = "Son kullanma tarihi yaklaşan ürünler: ";
            int i = 1;
            while (reader2.Read())
            {
                DateTime currentTime = DateTime.Today;
                DateTime itemTime = Convert.ToDateTime(reader2["skt"]);
                TimeSpan timeDifference = itemTime - currentTime;
                int difference = Convert.ToInt32(timeDifference.Days);
                if (difference <= 365)
                {
                    expireDangers[i] = "- " + reader2["name"].ToString();
                    i++;
                }
            }
            connection.Close();
            string allItems = string.Join(Environment.NewLine, expireDangers);
            MessageBox.Show(allItems);
        }

        private void btnDivideMoney_Click(object sender, EventArgs e)
        {
            boolDivide = true;
            btnDivideEnd.Visible = true;
            txtboxDivideVisa.Visible = true;
            lblDivideVisa.Visible = true;
            MessageBox.Show(boolDivide.ToString());
        }

        private void btnDivideEnd_Click(object sender, EventArgs e)
        {
            ReceiptNoChecker();
            btnBuy("Visa", true);
        }

        private void ReceiptNoChecker()
        {
            connection.Open();
            SqlCommand cmdCheckDatabse = new SqlCommand("SELECT *from Log", connection);
            SqlDataReader reader = cmdCheckDatabse.ExecuteReader();
            int receiptNoFromLog = 0;
            while (reader.Read())
            {
                try
                {
                    receiptNoFromLog = Convert.ToInt32(reader["receipt"]) + 1;
                    if (receiptNoFromLog > receiptNo)
                        receiptNo = receiptNoFromLog;
                }
                catch { }
            }
            connection.Close();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            ReceiptForm rcForm = new ReceiptForm();
            rcForm.Show();
        }

        private void btnCust1_Click(object sender, EventArgs e)
        {
            Scanned("4739363848686");
        }

        private void btnCust2_Click(object sender, EventArgs e)
        {
            Scanned("8690574105144");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnWaitReceipt_Click(object sender, EventArgs e)
        {
            int rowCounter = mainGridView.Rows.Count;
            string[] datas = new string[6];
            connection.Open();
            for (int i = 0; i < rowCounter; i++)
            {
                datas[0] = mainGridView.Rows[i].Cells[0].Value.ToString();
                datas[1] = mainGridView.Rows[i].Cells[1].Value.ToString();
                datas[2] = mainGridView.Rows[i].Cells[2].Value.ToString();
                datas[3] = mainGridView.Rows[i].Cells[3].Value.ToString();
                datas[4] = mainGridView.Rows[i].Cells[4].Value.ToString();
                if (lblReceiptNote.Text == "" || lblReceiptNote == null)
                    datas[5] = "Yok";
                else
                    datas[5] = txtboxReceiptNote.Text;
                SqlCommand cmdWaitReceipt = new SqlCommand("INSERT INTO WaitingReceipt (name, piece, sumPrice, devSumPrice, devBarcode, note) Values ('" + datas[0] + "' , '" + datas[1] + "' ,'" + datas[2] + "' ,'" + datas[3] + "' ,'" + datas[4] + "' , '" + datas[5] + "')", connection);
                cmdWaitReceipt.ExecuteNonQuery();
            }
            mainGridView.Rows.Clear();
            txtboxReceiptNote.Text = "";
            lblSum.Text = "Toplam: 0.00";
            sum = 0;
            connection.Close();
            
        }

        private void btnWaitingReceipts_Click(object sender, EventArgs e)
        {
            WaitingReceiptsForm wrForm = new WaitingReceiptsForm();
            wrForm.Show();
        }

        public void GetReceiptFromWaiting(string note)
        {
            mainGridView.Rows.Clear();
            connection.Open();
            SqlCommand cmdRecoverReceipt = new SqlCommand("SELECT *from WaitingReceipt", connection);
            SqlDataReader reader = cmdRecoverReceipt.ExecuteReader();
            while (reader.Read())
            {
                if (reader["note"].ToString() == note)
                {
                    int z = mainGridView.Rows.Add();
                    mainGridView.Rows[z].Cells[0].Value = reader["name"].ToString();
                    mainGridView.Rows[z].Cells[1].Value = reader["piece"].ToString();
                    mainGridView.Rows[z].Cells[2].Value = reader["sumPrice"].ToString();
                    mainGridView.Rows[z].Cells[3].Value = reader["devSumPrice"].ToString();
                    mainGridView.Rows[z].Cells[4].Value = reader["devBarcode"].ToString();
                }
            }
            connection.Close();
            double recoverSum = 0;
            for(int l = 0; l < mainGridView.RowCount; l++)
            {
                recoverSum += Convert.ToDouble(mainGridView.Rows[l].Cells[3].Value);
            }
            sum = recoverSum;
            lblSum.Text = "Toplam: " + recoverSum;
        }
    }
}
