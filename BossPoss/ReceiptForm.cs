using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace BossPoss
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm()
        {
            InitializeComponent();
        }
        int i = 0;  //Using to enter a data to grid
        SqlConnection connection = new SqlConnection("Data Source=LUNATOGI\\KETO;Initial Catalog=BossPoss;Integrated Security=True");
        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            ListReceipts();
        }

        private void ListReceipts()
        {
            connection.Open();
            int counter = 0;
            SqlCommand cmdCounter = new SqlCommand("Select *from Log", connection);
            SqlDataReader countReader = cmdCounter.ExecuteReader();
            while (countReader.Read())
            {
                counter++;
            }
            connection.Close();
            int[] checker = new int[counter + 1];
            int a = 0;
            int receiptNo = 0;
            bool contain = false;
            connection.Open();
            SqlCommand cmdTakingData = new SqlCommand("Select *from Log", connection);
            SqlDataReader reader = cmdTakingData.ExecuteReader();
            while (reader.Read())
            {
                if (reader["receipt"] != null)
                {
                    try
                    {
                        receiptNo = Convert.ToInt32(reader["receipt"]);
                    }
                    catch { }
                    for(int c = 0; c < counter; c++)
                    {
                        if (receiptNo == checker[c])
                        {
                            //MessageBox.Show("break");
                            contain = true;
                        }
                    }
                    if (!contain)
                    {
                        i = storageGridView.Rows.Add();
                        storageGridView.Rows[i].Cells[0].Value = reader["date"].ToString();
                        storageGridView.Rows[i].Cells[1].Value = reader["receipt"].ToString();
                        checker[a] = receiptNo;
                        a++;
                    }else if (contain)
                    {
                        contain = false;
                    }
                }
            }
            connection.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ReceiptGridView.Visible = false;
            ReceiptGridView.Rows.Clear();
        }

        private void storageGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int curReceiptNo = Convert.ToInt32(storageGridView.Rows[index].Cells[1].Value);
            ReceiptGridView.Visible = true;
            connection.Open();
            SqlCommand cmdCurReceipt = new SqlCommand("Select *from Log", connection);
            SqlDataReader receiptReader = cmdCurReceipt.ExecuteReader();
            while (receiptReader.Read())
            {
                int receiptFromData = 0;
                try
                {
                    receiptFromData = Convert.ToInt32(receiptReader["receipt"]);
                }
                catch {  }
                if (receiptFromData == curReceiptNo)
                {
                    int i = ReceiptGridView.Rows.Add();
                    ReceiptGridView.Rows[i].Cells[0].Value = receiptReader["date"].ToString();
                    ReceiptGridView.Rows[i].Cells[1].Value = receiptReader["receipt"].ToString();
                    ReceiptGridView.Rows[i].Cells[2].Value = receiptReader["item"].ToString();
                    ReceiptGridView.Rows[i].Cells[3].Value = receiptReader["piece"].ToString();
                    ReceiptGridView.Rows[i].Cells[4].Value = receiptReader["sumPrice"].ToString() + " TL";
                    ReceiptGridView.Rows[i].Cells[5].Value = receiptReader["vn"].ToString();
                }
            }
            connection.Close();
        }


        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            if(ReceiptGridView.Visible == false)
            {
                MessageBox.Show("Önce bir fişe giriniz", "Uyarı!");
                return;
            }
            else
            {
                int rowCount = ReceiptGridView.RowCount;
                string date = ReceiptGridView.Rows[0].Cells[0].Value.ToString();
                ev.Graphics.DrawString("Tarih : " + date, new System.Drawing.Font("Times New Roman", 14, System.Drawing.FontStyle.Regular), Brushes.Black, 20, 20);
                string[] datas = new string[4];
                for (int i = 0; i < rowCount; i++)
                {
                    datas[0] = ReceiptGridView.Rows[i].Cells[2].Value.ToString();   //İsim
                    datas[1] = ReceiptGridView.Rows[i].Cells[3].Value.ToString();   //Adet
                    datas[2] = ReceiptGridView.Rows[i].Cells[4].Value.ToString();   //Ödenen Tutar
                    datas[3] = ReceiptGridView.Rows[i].Cells[5].Value.ToString();   //Ödeme türü
                    ev.Graphics.DrawString("---------------------------", new System.Drawing.Font("Times New Roman", 14, System.Drawing.FontStyle.Regular), Brushes.Black, 10, 20);
                    ev.Graphics.DrawString(datas[0], new System.Drawing.Font("Times New Roman", 14, System.Drawing.FontStyle.Regular), Brushes.Black, 10, 20);
                    ev.Graphics.DrawString("Adet : " + datas[1] + " , " + "Tutar : " + datas[2] + " , " + "Ödeme Türü : " + datas[3], new System.Drawing.Font("Times New Roman", 10, System.Drawing.FontStyle.Regular), Brushes.Black, 10, 20);
                }
                ev.Graphics.DrawString("-                         -", new System.Drawing.Font("Times New Roman", 14, System.Drawing.FontStyle.Regular), Brushes.Black, 10, 20);
                ev.Graphics.DrawString("-                         -", new System.Drawing.Font("Times New Roman", 14, System.Drawing.FontStyle.Regular), Brushes.Black, 10, 20);
                ev.Graphics.DrawString("-                         -", new System.Drawing.Font("Times New Roman", 14, System.Drawing.FontStyle.Regular), Brushes.Black, 10, 20);
                ev.Graphics.DrawString("-                         -", new System.Drawing.Font("Times New Roman", 14, System.Drawing.FontStyle.Regular), Brushes.Black, 10, 20);
            }
            
        }

        private void btnSlip_Click(object sender, EventArgs e)
        {
            if (ReceiptGridView.Visible == false)
            {
                MessageBox.Show("Önce bir fişe giriniz", "Uyarı!");
                return;
            }
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.PaperSize = new PaperSize("A6", 413, 517);
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            pd.Print();
        }


    }
}
