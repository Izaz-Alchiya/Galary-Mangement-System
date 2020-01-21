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
    public partial class Register : Form
    {
        SqlCommand cmd;
        SqlConnection c = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Izaz\Desktop\Online Galary managment system\Database1.mdf;Integrated Security=True;User Instance=True");
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
           
        }

       

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Visible = true;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
            cmb_month.Text = "Month";
            cmb_day.Text = "Day";
            cmb_year.Text = "year";
            txt_username.Text = "User Name";
            txt_fname.Text = "First Name";
            txt_lname.Text = "Last Name";
            txt_email.Text = "Email";
            txt_password.Text = "New Password";
        }
        void clear()
        {
            txt_username.Clear();
            txt_email.Clear();
            txt_password.Clear();
            txt_fname.Clear();
            txt_lname.Clear();
        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_username.Clear();
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_MouseClick(object sender, MouseEventArgs e)
        {
            txt_fname.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            c.Open();
            string date = cmb_month.Text + "/" + cmb_day.Text + "/" + cmb_year.Text;
            string q = "insert into UserData values('" + txt_username.Text + "','" + txt_fname.Text + "','"+txt_lname.Text+"','"+txt_email.Text+"','"+txt_password.Text+"','"+date+"')";
            cmd = new SqlCommand(q, c);
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

        private void txt_lname_MouseClick(object sender, MouseEventArgs e)
        {
            txt_lname.Clear();
        }

        private void txt_email_MouseClick(object sender, MouseEventArgs e)
        {
            txt_email.Clear();
        }

        private void txt_password_MouseClick(object sender, MouseEventArgs e)
        {
            txt_password.Clear();
        }

        private void txt_username_TabIndexChanged(object sender, EventArgs e)
        {
            txt_username.Clear();
        }

        private void cmb_month_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch))
            {
                e.Handled=true;
            }
        }

        private void cmb_day_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void cmb_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            cmb_year.MaxLength = 4;
            if (!char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }
    }
}
