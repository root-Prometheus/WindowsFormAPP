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

        public Form2(Form1 x)
        {
            InitializeComponent();
            this.c = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Show();
            this.Close();

        }
    }
}
