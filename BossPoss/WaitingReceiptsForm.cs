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

namespace BossPoss
{
    public partial class WaitingReceiptsForm : Form
    {
        public WaitingReceiptsForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LUNATOGI\\KETO;Initial Catalog=BossPoss;Integrated Security=True");
        private void WaitingReceiptsForm_Load(object sender, EventArgs e)
        {
            List_WaitingReceipts();
        }

        private void List_WaitingReceipts()
        {
            connection.Open();
            SqlCommand cmdDataCounter = new SqlCommand("SELECT *from WaitingReceipt", connection);
            SqlDataReader firstReader = cmdDataCounter.ExecuteReader();
            int counter = 0;
            while (firstReader.Read())
            {
                counter++;
            }
            string[] receiptNotes = new string[counter];
            int insert = 0;
            connection.Close();
            connection.Open();
            SqlCommand sqlTakeData = new SqlCommand("SELECT *from WaitingReceipt", connection);
            SqlDataReader sqlReader = sqlTakeData.ExecuteReader();
            while (sqlReader.Read())
            {
                bool include = false;
                string note = sqlReader["note"].ToString();
                for(int i = 0; i < counter; i++)
                {
                    if (receiptNotes[i] == note)
                        include = true;
                    else
                    {
                        receiptNotes[insert] = note;
                    }
                }
                if (!include)
                {
                    int c = WaitingReceiptDataGrid.Rows.Add();
                    WaitingReceiptDataGrid.Rows[c].Cells[0].Value = note;
                }
            }
            connection.Close();
        }

        private void WaitingReceiptDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string curReceiptNo = WaitingReceiptDataGrid.Rows[index].Cells[0].Value.ToString();
            SpesificReceiptDataGrid.Visible = true;
            connection.Open();
            SqlCommand cmdCurReceipt = new SqlCommand("Select *from WaitingReceipt", connection);
            SqlDataReader receiptReader = cmdCurReceipt.ExecuteReader();
            while (receiptReader.Read())
            {
                string receiptFromData = "";
                try
                {
                    receiptFromData = receiptReader["note"].ToString();
                }
                catch { }
                if (receiptFromData == curReceiptNo)
                {
                    int i = SpesificReceiptDataGrid.Rows.Add();
                    SpesificReceiptDataGrid.Rows[i].Cells[0].Value = receiptReader["note"].ToString();
                    SpesificReceiptDataGrid.Rows[i].Cells[1].Value = receiptReader["name"].ToString();
                    SpesificReceiptDataGrid.Rows[i].Cells[2].Value = receiptReader["piece"].ToString();
                    SpesificReceiptDataGrid.Rows[i].Cells[3].Value = receiptReader["sumPrice"].ToString();
                }
            }
            connection.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SpesificReceiptDataGrid.Visible = false;
            SpesificReceiptDataGrid.Rows.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SpesificReceiptDataGrid.Visible = false;
            Delete_Row(null);
        }

        private void Delete_Row(string note)
        {
            string deleteNote = "";
            if (note == "" || note == null)
            {
                try
                {
                    DataGridViewRow gr = WaitingReceiptDataGrid.CurrentRow;
                    deleteNote = gr.Cells[0].Value.ToString();
                    WaitingReceiptDataGrid.Rows.Remove(gr);
                }
                catch { }
            }
            else
            {
                deleteNote = note;
                for (int i = 0; i < WaitingReceiptDataGrid.RowCount; i++)
                {
                    if (WaitingReceiptDataGrid.Rows[i].Cells[0].Value.ToString() == note)
                    {
                        DataGridViewRow gr = WaitingReceiptDataGrid.Rows[i];
                        WaitingReceiptDataGrid.Rows.Remove(gr);
                    }
                }
            }
            connection.Open();
            SqlCommand cmdDeleteData = new SqlCommand("Delete From WaitingReceipt where note = '" + deleteNote + "'", connection);
            cmdDeleteData.ExecuteNonQuery();
            connection.Close();
            WaitingReceiptDataGrid.Rows.Clear();
            List_WaitingReceipts();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            string receiptNote = "";
            try
            {
                receiptNote = SpesificReceiptDataGrid.Rows[0].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Önce bir fişe girin", "Dikkat");
                return;
            }
            SpesificReceiptDataGrid.Rows.Clear();
            SpesificReceiptDataGrid.Visible = false;
            FrmSelling mainForm = new FrmSelling();
            var formCall = Application.OpenForms.OfType<FrmSelling>().Single();
            formCall.GetReceiptFromWaiting(receiptNote);
            Delete_Row(receiptNote);
        }
    }
}
