using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Online_Galary_managment_system
{
    public partial class aboutus : Form
    {
        public aboutus()
        {
            InitializeComponent();
        }

        private void aboutus_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_home_abus_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Visible = true;
        }

        private void btn_feed_ab_Click(object sender, EventArgs e)
        {
            this.Hide();
            feedback abs = new feedback();
            abs.Visible = true;
        }
    }
}
