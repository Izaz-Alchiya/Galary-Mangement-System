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
        SqlConnection c = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Izaz\Desktop\Online Galary managment system\Database1.mdf;Integrated Security=True;User Instance=True");
        
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
            
            if (txt_username.Text == "admin" && txt_password.Text == "admin")
            {
                
                this.Close();
                AdminPage ad = new AdminPage();
                ad.Visible = true;
            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserData where Username='" + txt_username.Text + "' and Password = '" + txt_password.Text + "'", c);

                DataTable dt = new DataTable();
                sda.Fill(dt);


                if (dt.Rows[0][0].ToString() == "1")
                {
                    
                    this.Hide();
                    
                    Welcome w = new Welcome();
                    w.Show();
                     
                }
                else
                {
                    MessageBox.Show("YOUR USERNAME OR PASSWORD COULD BE WRONG! PLEASE TRY AGAIN.!");
                }
                c.Close();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        
    }
}
