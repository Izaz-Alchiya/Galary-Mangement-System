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
    public partial class Viewpage : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Izaz\Desktop\Online Galary managment system\Database1.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd;
        public Viewpage()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            try 
            {
                string sql = "select image1 from Home where hid="+txt_id.Text+"";
                c.Open();
                cmd = new SqlCommand(sql, c);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    byte[] img=(byte[])(reader[0]);
                    if (img == null)
                    {
                        pic_show.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pic_show.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    MessageBox.Show("THIS ID DOES NOT EXIST.");
                }

                c.Close();
            }
            catch(Exception ea)
            {
                c.Close();
                MessageBox.Show("PLEASE CHECK YOUR IMAGE ID!!",ea.Message);
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 fs = new Form1();
            fs.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pic_show.Image = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Viewpage_Load(object sender, EventArgs e)
        {

        }
    }
}
