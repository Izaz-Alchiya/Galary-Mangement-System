using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Online_Galary_managment_system
{
    public partial class Login : Form
    {
        SqlCommand cmd;
        SqlConnection c = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\vrund\Desktop\Online Galary managment system\Online Galary managment system\Database1.mdf;Integrated Security=True;User Instance=True");

        public Login()
        {
            InitializeComponent();
        }

        private void btn_alrreg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Visible = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_sumit_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register r = new Register();
            r.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Visible = true;
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            c.Open();
            
            string q = "insert into UserData values(            cmd = new SqlCommand(q, c);
            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                MessageBox.Show("Succesfully Registered.");
            }
            else
            {
                MessageBox.Show("UnSuccesfully Registered");
            }
            c.Close();
        }
    }
}
