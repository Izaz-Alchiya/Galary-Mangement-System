using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Online_Galary_managment_system
{
    public partial class feedback : Form
    {

        SqlConnection c = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Izaz\Desktop\Online Galary managment system\Database1.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd;
        public feedback()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radio_good_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_excellent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_ok_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_bad_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_exe1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_goo1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_ok1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_bad1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void feedback_Load(object sender, EventArgs e)
        {

        }

        private void btn_sub_feed_Click(object sender, EventArgs e)
        {
            string service1;
            if(radio_excellent.Checked==true)
            {
                service1="5 Start";
            }
            else if(radio_good.Checked==true)
            {
                service1="4 star.";
            }
            else if(radio_ok.Checked==true)
            {
                service1="3 Star.";
            }
            else
            {
                service1="2 star.";
            }

            string  comfort;
           
            if(radio_exe1.Checked==true)
            {
                comfort="5 Start";
            }
            else if(radio_good1.Checked==true)
            {
                comfort="4 star.";
            }
            else if(radio_Ok1.Checked==true)
            {
                comfort="3 Star.";
            }
            else
            {
                comfort="2 star.";
            }
 

            c.Open();
            cmd = new SqlCommand("insert into feedback values('"+textBox1.Text+"','"+service1+"','"+comfort+"','"+richTxt_feed.Text+"')",c);

            int i=cmd.ExecuteNonQuery();

            if (i > 0)
            {
                MessageBox.Show("Feedback sumited successfully.");
            }
            else {
                MessageBox.Show("THERE IS AN ERROR IN SUBMITTING!! PLEASE CHECK.");
            }

            c.Close();
        }

        private void btn_home_feed_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Visible = true;
        }

        private void btn_clear_feed_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            
            radio_bad.Checked = false;
            radio_bad1.Checked = false;
            radio_excellent.Checked = false;
            radio_exe1.Checked = false;
            radio_good.Checked = false;
            radio_good1.Checked = false;
            radio_ok.Checked = false;
            radio_Ok1.Checked = false;
        }
    }
}
