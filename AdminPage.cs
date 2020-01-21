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
    public partial class AdminPage : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Izaz\Desktop\Online Galary managment system\Database1.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd;
        private string sendtext;
        public AdminPage()
        {
            InitializeComponent();
        }

        public AdminPage(string sendtext)
        {
            // TODO: Complete member initialization
            this.sendtext = sendtext;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Visible = true;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                c.Open();
                cmd = new SqlCommand("delete from UserData where username='" + txt_name.Text + "'", c);
                int i =cmd.ExecuteNonQuery();
                c.Close();
                if (i > 0)
                {
                    MessageBox.Show("SUCCESSFULLY DELETED..");
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("THERE IS AN ERROR IN DELETING THE USER NAME! USERNAME MIGHT NOT BE EXIST..",es.Message);

            }
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btn_feed_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
    }
}
