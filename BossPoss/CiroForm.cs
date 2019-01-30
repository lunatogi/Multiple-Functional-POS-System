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
using System.Net.Mail;

namespace BossPoss
{
    public partial class CiroForm : Form
    {
        public CiroForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LUNATOGI\\KETO;Initial Catalog=BossPoss;Integrated Security=True");

        private void CiroForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (txtboxReceiptNote.Text != "özyeğin2019midnight")
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

        private void btnMail_Click(object sender, EventArgs e)
        {
            try
            {
                Send_Mail();
                MessageBox.Show("Mail gönderildi.", "Başarılı");
            }
            catch
            {
                MessageBox.Show("Mail gönderme başarısız. Lütfen internet bağlantısını kontrol edin.", "Başarısız");
            }
        }
        private void Send_Mail()
        {
            string[] ciros = new string[6]; // 0 --> dün , 1 --> geçen ay, 2 --> geçen yıl, 3 --> bugün, 4 --> bu ay, 5 --> bu yıl

            connection.Open();
            SqlCommand cmdTakeCiro = new SqlCommand("Select *from Ciro", connection);
            SqlDataReader reader = cmdTakeCiro.ExecuteReader();
            while (reader.Read())
            {
                DateTime dt = Convert.ToDateTime(reader["date"]);
                DateTime currentDt = DateTime.Today;
                DateTime lastDt = DateTime.Today.AddDays(-1);
                DateTime lastMt = DateTime.Today.AddMonths(-1);
                DateTime lastYr = DateTime.Today.AddYears(-1);
                string type = reader["type"].ToString();
                if (DateTime.Compare(dt, currentDt) == 0 && type == "d")
                {
                    ciros[3] = "Bugünkü ciro: " + reader["topCiro"].ToString() + " TL";
                }
                else if (dt.Year == lastDt.Year && dt.Month == lastDt.Month && dt.Day == lastDt.Day && type == "d")
                {
                    ciros[0] = "\nDünkü ciro: " + reader["topCiro"].ToString() + " TL";
                }
                else if (dt.Year == currentDt.Year && dt.Month == currentDt.Month && type == "m")
                {
                    ciros[4] = "\nBu ayki ciro: " + reader["topCiro"].ToString() + " TL";
                }
                else if (dt.Year == lastMt.Year && dt.Month == lastMt.Month && type == "m")
                {
                    ciros[1] = "\nGeçen ayki ciro: " + reader["topCiro"].ToString() + " TL";
                }
                else if (dt.Year == currentDt.Year && type == "y")
                {
                    ciros[5] = "\nBu yılki ciro: " + reader["topCiro"].ToString() + " TL";
                }
                else if (dt.Year == lastYr.Year && type == "y")
                {
                    ciros[2] = "\nGeçen yılki ciro: " + reader["topCiro"].ToString() + " TL";
                }
            }
            connection.Close();
            MessageBox.Show(ciros[3]);
            string message = ciros[3] + ciros[0] + ciros[4] + ciros[1] + ciros[5] + ciros[2];
            MessageBox.Show(message);
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;                   
            client.Credentials = new System.Net.NetworkCredential("ozu.midnightexpress1@gmail.com", "ozyegin2019midnight");

            MailMessage mm = new MailMessage("ozu.midnightexpress1@gmail.com", "ozu.midnightexpress3@gmail.com", "Midnight Express Ciro", message);
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.Send(mm);

            MailMessage mm2 = new MailMessage("ozu.midnightexpress1@gmail.com", "veyluna@outlook.com", "Midnight Express Ciro", message);
            mm2.BodyEncoding = UTF8Encoding.UTF8;
            mm2.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.Send(mm2);
        }
    }
}
