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
        }
    }
}
