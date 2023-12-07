using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KojiTheLabDestroyer
{

    public partial class Form1 : Form
    {
        private string conString = "Data Source=DESKTOP-HH4KBRC;Initial Catalog=KojimaTheConquerror;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);
            try
            {
                string username = textBox1.Text;
                string password = textBox2.Text;
                connection.Open();
                string query = "Select Username,Password FROM Auth";
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        string user = reader.GetString(0);
                        string psw = reader.GetString(1);
                        if(user.Trim() == username.Trim() && psw.Trim() == password.Trim())
                        {
                            Form2 HomePage = new Form2(this);
                            this.Hide();
                            HomePage.Show();
                        }
                        else
                        {
                            MessageBox.Show("Sifre Hatalı");
                            textBox1.Text = string.Empty;
                            textBox2.Text = string.Empty;
                        }
                    }
                }
                connection.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Daha Sonra Tekrar Deneyiniz("+ex.Message+")");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }    
}
