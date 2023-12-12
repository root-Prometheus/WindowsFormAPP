using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KojiTheLabDestroyer
{
    public partial class Form3 : Form
    {
        private string conString = "Data Source=DESKTOP-HH4KBRC;Initial Catalog=KojimaTheConquerror;Integrated Security=True";
        public Form2 c;
        public Form3(Form2 x)
        {
            InitializeComponent();
            this.c = x;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);
            try
            {
                
                string UpdateQuerry = "UPDATE Auth SET Name = @NewName," +
                    "Surname = @NewSurname," +
                    "Gender = @NewGender," +
                    "Age = @NewAge " +
                    "WHERE Username = @Username ";
                using(SqlCommand cmd = new SqlCommand(UpdateQuerry, connection)) 
                {
                    cmd.Parameters.AddWithValue("@NewName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@NewSurname",textBox2.Text);
                    cmd.Parameters.AddWithValue("@NewGender",textBox3.Text);
                    cmd.Parameters.AddWithValue("@NewAge", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Username", c.GetUsr());
                    connection.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Kayıt Başarıyla Gerçekleşti");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Gerçekleştirilemedi");
                    }
                }
                connection.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Something in Bad way uuuuuuuuuuuaaaaaaaaaaaaaa " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
