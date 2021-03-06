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
using BossPoss.IMAP;
using System.Net.Mail;

namespace BossPoss
{
    public partial class StorageForm : Form
    {
        public StorageForm()
        {
            InitializeComponent();
        }
        int i = 0;  //Using to enter a data to grid
        SqlConnection connection = new SqlConnection("Data Source=LUNATOGI\\KETO;Initial Catalog=BossPoss;Integrated Security=True");
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
                try
                {
                    DateTime dt = Convert.ToDateTime(reader["skt"]);
                    i = storageGridView.Rows.Add();
                    storageGridView.Rows[i].Cells[0].Value = reader["barcode"].ToString();
                    storageGridView.Rows[i].Cells[1].Value = reader["name"].ToString();
                    storageGridView.Rows[i].Cells[2].Value = reader["piece"].ToString();
                    storageGridView.Rows[i].Cells[3].Value = reader["price"].ToString();
                    storageGridView.Rows[i].Cells[4].Value = dt.ToString("yyyy-MM-dd");
                }
                catch
                {
                    i = storageGridView.Rows.Add();
                    storageGridView.Rows[i].Cells[0].Value = reader["barcode"].ToString();
                    storageGridView.Rows[i].Cells[1].Value = reader["name"].ToString();
                    storageGridView.Rows[i].Cells[2].Value = reader["piece"].ToString();
                    storageGridView.Rows[i].Cells[3].Value = reader["price"].ToString();
                }
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
            if(txtboxBarcode.Text == "" || txtboxName.Text == "" || txtboxPiece.Text == "" || txtboxPrice.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun. (Son kullanma tarihi boş kalabilir)", "Hata!");
                return;
            }
            string barcodeCheck = "";
            barcodeCheck = txtboxBarcode.Text;
            connection.Open();
            SqlCommand cmdBarcodeChecker = new SqlCommand("Select *from Depo", connection);
            SqlDataReader reader = cmdBarcodeChecker.ExecuteReader();
            while (reader.Read())
            {
                if(reader["barcode"].ToString() == barcodeCheck)
                {
                    MessageBox.Show("Bu barkodlu bir ürün zaten bulunmakta.", "Uyarı!");
                    return;
                }
            }
            connection.Close();
            string mesaj = "";
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
                mesaj += txtboxName.Text + "+" + txtboxPrice.Text + "+" + txtboxPiece.Text + "+" + txtboxBarcode.Text + "+" + currentSkt.ToString();
                Send_Email("Add", mesaj);
            }
            else
            {
                SqlCommand cmdAddItemToStorage = new SqlCommand("INSERT INTO Depo (name, price, piece, barcode) Values ('" + txtboxName.Text + "' , '" + txtboxPrice.Text + "' , '" + txtboxPiece.Text + "' , '" + Convert.ToUInt64(txtboxBarcode.Text) + "')", connection);
                cmdAddItemToStorage.ExecuteNonQuery();
                mesaj += txtboxName.Text + "+" + txtboxPrice.Text + "+" + txtboxPiece.Text + "+" + txtboxBarcode.Text;
                Send_Email("Add", mesaj);
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
                    Update_Skt();
                }
                else if(txtboxPiece.Text != "" && txtboxPiece.Text != null)
                {
                    Update_Piece();
                }else if(txtboxPrice.Text != "" && txtboxPrice.Text != null)
                {
                    Update_Price();
                }
                txtboxBarcode.Text = "";
                txtboxName.Text = "";
                txtboxPiece.Text = "";
                txtboxPrice.Text = "";
                txtboxSkt.Text = "";
            }
            catch
            {
                MessageBox.Show("Depoda böyle bir ürün bulunmamakta veya sayı girilmesi gereken yere yazı girdiniz.", "Hata");
            }
            
        }

        private void Update_Piece()
        {
            string mesaj = "";
            string barcode = txtboxBarcode.Text;
            int oldPiece = 0;
            int newPiece = 0;
            connection.Open();
            SqlCommand cmdTakeOldData = new SqlCommand("Select *from Depo", connection);
            SqlDataReader reader = cmdTakeOldData.ExecuteReader();
            while (reader.Read())
            {
                if(reader["barcode"].ToString() == txtboxBarcode.Text)
                    oldPiece = Convert.ToInt32(reader["piece"]);
            }
            int fromText = Convert.ToInt32(txtboxPiece.Text);
            newPiece = oldPiece + fromText;
            connection.Close();
            connection.Open();
            SqlCommand cmdUpdateDatabase = new SqlCommand("Update Depo set piece = '" + newPiece.ToString() + "' where barcode = " + barcode + "", connection);
            cmdUpdateDatabase.ExecuteNonQuery();
            connection.Close();
            storageGridView.Rows.Clear();
            ListStorage();
            oldPiece = 0;
            mesaj += barcode + "+" + newPiece.ToString();
            MessageBox.Show(mesaj);
        }

        private void Update_Price()
        {
            string mesaj = "";
            string barcode = txtboxBarcode.Text;
            connection.Open();
            SqlCommand cmdUpdateDatabase = new SqlCommand("Update Depo set price = '" + txtboxPrice.Text + "' where barcode = " + barcode + "", connection);
            cmdUpdateDatabase.ExecuteNonQuery();
            connection.Close();
            storageGridView.Rows.Clear();
            ListStorage();
            mesaj += barcode + "+" + txtboxPrice.Text;
            Send_Email("UpdatePrice", mesaj);
            MessageBox.Show(mesaj);
        }

        private void Update_Skt()
        {
            string mesaj = "";
            string barcode = txtboxBarcode.Text;
            string[] sktTimeDivider = txtboxSkt.Text.Split('-');
            int[] sktInt = new int[3];
            for (int k = 0; k < 3; k++)
            {
                sktInt[k] = Convert.ToInt16(sktTimeDivider[k]);         // 0 --> Day, 1 --> Month,  2 --> Year
            }
            DateTime currentSkt = new DateTime(sktInt[2], sktInt[1], sktInt[0]);
            connection.Open();
            SqlCommand cmdUpdateDatabase = new SqlCommand("Update Depo set skt = '" + currentSkt.ToString("yyyy-MM-dd") + "' where barcode = " + barcode + "", connection);
            cmdUpdateDatabase.ExecuteNonQuery();
            connection.Close();
            storageGridView.Rows.Clear();
            ListStorage();
            mesaj += barcode + "+" + currentSkt.ToString();
            Send_Email("UpdateSkt", mesaj);
            MessageBox.Show(mesaj);
        }

        private void Send_Email(string subject, string message)
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("ozu.midnightexpress1@gmail.com", "ozyegin2019midnight");

            MailMessage mm = new MailMessage("ozu.midnightexpress1@gmail.com", "ozu.midnightexpress2@gmail.com", subject, message);
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.Send(mm);

            MailMessage mm2 = new MailMessage("ozu.midnightexpress1@gmail.com", "ozu.midnightexpress3@gmail.com", subject, message);
            mm2.BodyEncoding = UTF8Encoding.UTF8;
            mm2.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.Send(mm2);
        }
    }
}
