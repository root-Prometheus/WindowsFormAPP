using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KojiTheLabDestroyer
{
    public partial class Form2 : Form
    {
        public Form1 c;
        private string username = "";
        public Form2(Form1 x)
        {
            InitializeComponent();
            this.c = x;
            username = c.getusr();
            label1.Text = username;
            darkside.Text = username;
        }
        public string GetUsr() { return username; }
        private void button1_Click(object sender, EventArgs e)
        {
            c.Show();
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            username = c.getusr();
            MessageBox.Show(username);
        }

        private void darkside_Click(object sender, EventArgs e)
        {
            Form3 EditProfile= new Form3(this);
            this.Hide();
            EditProfile.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
