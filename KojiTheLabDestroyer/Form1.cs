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
using System.Collections;

namespace KojiTheLabDestroyer
{

    public partial class Form1 : Form
    {
        private string conString = "Data Source=DESKTOP-HH4KBRC;Initial Catalog=KojimaTheConquerror;Integrated Security=True";
        private string usernamec = "";
        public Form1()
        {
            InitializeComponent();
        }
        public string getusr()
        {
            return this.usernamec;
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
                        int i = 0;
                        while (reader.Read())
                        {
                            i = 1;
                            string user = reader["Username"].ToString();
                            string psw = reader["Password"].ToString();
                            if (user.Trim() == username.Trim())
                            {
                                if(psw.Trim() == password.Trim())
                                {
                                    i = 0;
                                    this.usernamec = username.Trim();
                                    Form2 HomePage = new Form2(this);
                                    this.Hide();
                                    HomePage.Show();
                                    break;
                                }
                                else
                                {
                                    i = 0;
                                    MessageBox.Show("Şifre Hatalı");
                                    textBox1.Text = string.Empty;
                                    textBox2.Text = string.Empty;
                                    break;
                                }
                            }
                        }
                        if (i == 1) 
                        {
                            MessageBox.Show("Kullanıcı Bulunamadı");
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
            SqlConnection connection = new SqlConnection(conString);
            try
            {
                string username = textBox1.Text;
                string password = textBox2.Text;
                if (username == "")
                {
                    MessageBox.Show("Username Kısmını Boş bırakamazsın.");
                }
                else if(password == "")
                {
                    MessageBox.Show("Password Kısmını Boş bırakamazsın.");
                }
                else
                {
                    if(username.Contains("@") || username.Contains("!") || username.Contains("?") || username.Contains("*") 
                        || username.Contains("$") || username.Contains("&") || username.Contains("#") || username.Contains("%"))
                    {
                        MessageBox.Show("Username Özel Karakter içeremez (0-9)(a-z)(A-Z)");
                        textBox1.Text = string.Empty;
                        textBox2.Text = string.Empty;
                    }
                    else
                    {
                        {
                            //If you are reading this,
                            //you should know that this part is quite silly.
                            //Instead of repeatedly opening and closing the SQL connection in this way,
                            //it would be more sensible to write a method (for fetching and sending data).
                            //However, I forgot to write this part, and since I later remembered to write it, I did it like this.
                            //ı do not recommend doing it this way
                            using (SqlCommand cmd = new SqlCommand("Select Username,Password FROM Auth", connection))
                            {
                                connection.Open();
                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        string user = reader["Username"].ToString();
                                        //This password belongs to TrumpLoVeRxXxX
                                        //string psw = reader["Password"].ToString();
                                        if (user.Trim() == username.Trim())
                                        {
                                            MessageBox.Show("This username is already taken");
                                            textBox1.Text = string.Empty;
                                            textBox2.Text = string.Empty;
                                            connection.Close();
                                            return;
                                        }
                                    }

                                }
                                connection.Close();
                            }
                        }
                        foreach (char s in password)
                        {
                            if(!((s >= 65 &&  s <= 90) || (s >= 97 && s <= 122) || (s >= 48 && s <= 57 )))
                            {
                                MessageBox.Show("Password Özel Karakter içeremez (0-9)(a-z)(A-Z)");
                            }
                            else
                            {
                                string cmd = "insert into Auth(Username,Password) values(@Username,@Password)";

                                using(SqlCommand command = new SqlCommand(cmd,connection)) 
                                {
                                    command.Parameters.AddWithValue("@Username", username);
                                    command.Parameters.AddWithValue("@Password", password);
                                    connection.Open();
                                    int result = command.ExecuteNonQuery();
                                    if (result > 0)
                                    {
                                        MessageBox.Show("Kayıt Başarıyla Gerçekleşti");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Kayıt Gerçekleştirilemedi");
                                    }

                                }

                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something in Bad way uuuuuuuuuuuaaaaaaaaaaaaaa "+ex.Message);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }    
}
