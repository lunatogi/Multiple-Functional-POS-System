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
    public partial class CiroForm : Form
    {
        public CiroForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=BossPoss;Integrated Security=True");

        private void CiroForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (txtboxReceiptNote.Text != "özyeğins2019midnight")
            {
                MessageBox.Show("Şifre yanlış!", "Uyarı!");
                return;
            }
            connection.Open();
            SqlCommand cmdTakeData = new SqlCommand("Select *from Ciro", connection);
            SqlDataReader reader = cmdTakeData.ExecuteReader();
            while (reader.Read())
            {
                if (reader["type"].ToString() == "y")
                {
                    int i = YearGridView.Rows.Add();
                    DateTime yearDate = Convert.ToDateTime(reader["date"]);
                    string yearString = yearDate.Year.ToString();
                    YearGridView.Rows[i].Cells[0].Value = yearString;
                    YearGridView.Rows[i].Cells[1].Value = reader["visa"].ToString() + " TL";
                    YearGridView.Rows[i].Cells[2].Value = reader["nakit"].ToString() + " TL";
                    YearGridView.Rows[i].Cells[3].Value = reader["topCiro"].ToString() + " TL";
                }
            }
            connection.Close();
        }
        private void YearGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            double year = Convert.ToDouble(YearGridView.Rows[index].Cells[0].Value);
            DateTime date1 = new DateTime(Convert.ToInt32(year), 1, 1);
            DateTime date2 = new DateTime(Convert.ToInt32(year), 12, 31);
            connection.Open();
            SqlCommand cmdTakeData = new SqlCommand("Select *from Ciro", connection);
            SqlDataReader reader = cmdTakeData.ExecuteReader();
            while (reader.Read())
            {
                DateTime dataDate = Convert.ToDateTime(reader["date"]);
                if (DateTime.Compare(dataDate, date1) >= 0 && DateTime.Compare(dataDate, date2) <= 0)
                {
                    if (reader["type"].ToString() == "m")
                    {
                        int i = MonthGridView.Rows.Add();
                        DateTime monthDate = Convert.ToDateTime(reader["date"]);
                        string yearForFuture = monthDate.Year.ToString();
                        string monthForFuture = monthDate.Month.ToString();
                        string monthString = "" + monthDate.Month + "." + monthDate.Year;
                        MonthGridView.Rows[i].Cells[0].Value = monthString;
                        MonthGridView.Rows[i].Cells[1].Value = reader["visa"].ToString() + " TL";
                        MonthGridView.Rows[i].Cells[2].Value = reader["nakit"].ToString() + " TL";
                        MonthGridView.Rows[i].Cells[3].Value = reader["topCiro"].ToString() + " TL";
                    }
                }
            }
            connection.Close();
            MonthGridView.Visible = true;
        }

        private void MonthGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string dayDate1 = MonthGridView.Rows[index].Cells[0].Value.ToString();
            string[] dividedDate = new string[2];
            dividedDate = dayDate1.Split('.');
            DateTime date1 = new DateTime(Convert.ToInt32(dividedDate[1]), Convert.ToInt32(dividedDate[0]), 1);
            DateTime date2 = date1.AddMonths(1);
            DateTime realDate2 = date2.AddDays(-1);
            connection.Open();
            SqlCommand cmdTakeData = new SqlCommand("Select *from Ciro", connection);
            SqlDataReader reader = cmdTakeData.ExecuteReader();
            while (reader.Read())
            {
                DateTime dataDate = Convert.ToDateTime(reader["date"]);
                if (DateTime.Compare(dataDate, date1) >= 0 && DateTime.Compare(dataDate, realDate2) <= 0)
                {
                    if (reader["type"].ToString() == "d")
                    {
                        int i = DayGridView.Rows.Add();
                        DateTime dayDate = Convert.ToDateTime(reader["date"]);
                        string dayString = dayDate.Day + "." + dayDate.Month + "." + dayDate.Year;
                        DayGridView.Rows[i].Cells[0].Value = dayString;
                        DayGridView.Rows[i].Cells[1].Value = reader["visa"].ToString() + " TL";
                        DayGridView.Rows[i].Cells[2].Value = reader["nakit"].ToString() + " TL";
                        DayGridView.Rows[i].Cells[3].Value = reader["topCiro"].ToString() + " TL";
                    }
                }
            }
            connection.Close();
            DayGridView.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(DayGridView.Visible == true)
            {
                DayGridView.Visible = false;
                DayGridView.Rows.Clear();
            }else if(MonthGridView.Visible == true)
            {
                MonthGridView.Visible = false;
                MonthGridView.Rows.Clear();
                
            }
        }
    }
}
