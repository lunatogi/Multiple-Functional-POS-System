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
    public partial class StorageForm : Form
    {
        public StorageForm()
        {
            InitializeComponent();
        }
        int i = 0;  //Using to enter a data to grid
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=BossPoss;Integrated Security=True");
        private void StorageForm_Load(object sender, EventArgs e)
        {
            ListStorage();
        }

        private void ListStorage()
        {
            connection.Open();
            SqlCommand cmdTakingData = new SqlCommand("Select *from Depo", connection);
            SqlDataReader reader = cmdTakingData.ExecuteReader();
            while (reader.Read())
            {
                i = storageGridView.Rows.Add();
                storageGridView.Rows[i].Cells[0].Value = reader["barcode"].ToString();
                storageGridView.Rows[i].Cells[1].Value = reader["name"].ToString();
                storageGridView.Rows[i].Cells[2].Value = reader["piece"].ToString();
                storageGridView.Rows[i].Cells[3].Value = reader["price"].ToString();
                storageGridView.Rows[i].Cells[4].Value = reader["skt"].ToString();
            }
            connection.Close();
        }

        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            string barcode = "";
            try
            {
                DataGridViewRow gr = storageGridView.CurrentRow;
                barcode = gr.Cells[0].Value.ToString();
                storageGridView.Rows.Remove(gr);
            }
            catch { }
            connection.Open();
            SqlCommand cmdDeleteData = new SqlCommand("Delete From Depo where barcode = '" + barcode + "'", connection);
            cmdDeleteData.ExecuteNonQuery();
            connection.Close();
            storageGridView.Rows.Clear();
            ListStorage();
        }
        
        private void btnNewAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (txtboxSkt.Text != "" && txtboxSkt.Text != null)
            {
                string[] sktTimeDivider = txtboxSkt.Text.Split('-');
                int[] sktInt = new int[3];
                for (int k = 0; k < 3; k++)
                {
                    sktInt[k] = Convert.ToInt16(sktTimeDivider[k]);         // 0 --> Day, 1 --> Month,  2 --> Year
                }
                //MessageBox.Show(sktInt[0] + " " + sktInt[1] + " " + sktInt[2]);
                DateTime currentSkt = new DateTime(sktInt[2], sktInt[1], sktInt[0]);   //In C# third slot is day but in SQL's datetime it's month... datetime2 is as like as C#
                SqlCommand cmdAddItemToStorage = new SqlCommand("INSERT INTO Depo (name, price, piece, barcode, skt) Values ('" + txtboxName.Text + "' , '" + txtboxPrice.Text + "' , '" + txtboxPiece.Text + "' , '" + Convert.ToUInt64(txtboxBarcode.Text) + "' , '" + currentSkt.ToString("yyyy-MM-dd") + "')", connection);
                cmdAddItemToStorage.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmdAddItemToStorage = new SqlCommand("INSERT INTO Depo (name, price, piece, barcode) Values ('" + txtboxName.Text + "' , '" + txtboxPrice.Text + "' , '" + txtboxPiece.Text + "' , '" + Convert.ToUInt64(txtboxBarcode.Text) + "')", connection);
                cmdAddItemToStorage.ExecuteNonQuery();
            }
            connection.Close();
            txtboxName.Text = "";
            txtboxPrice.Text = "";
            txtboxPiece.Text = "";
            txtboxBarcode.Text = "";
            txtboxSkt.Text = "";
            storageGridView.Rows.Clear();
            ListStorage();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtboxSkt.Text != "" && txtboxSkt.Text != null)
                {

                }
                else
                {

                }
            }
            catch
            {
                MessageBox.Show("Depoda böyle bir ürün bulunmamakta!", "Hata");
            }
        }

        private void Update_Piece()
        {

        }

        private void Update_Price()
        {

        }

        private void Update_Skt()
        {

        }
    }
}
