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
    public partial class mainPagePhoto : Form
    {

        SqlConnection c = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Izaz\Desktop\Online Galary managment system\Database1.mdf;Integrated Security=True;User Instance=True"); 
        SqlCommand cmd;
        string imgloc = "";
        public mainPagePhoto()
        {
            InitializeComponent();
        }
        
        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            pic_load.Image = null;
            txt_imageid.Clear();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Visible = true;

        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Image Files(*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp";
                dlg.Title = "selcct any picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgloc = dlg.FileName.ToString();
                    pic_load.ImageLocation = imgloc;
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("YOU WOULD HAVE NOT SELECCTED THE PROPER FORMAT OF THE IMAGE PLEASE CHECK IT.",ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_category.SelectedItem == "HOME")
                {
                    
                    byte[] img = null;
                    FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    string sql = "insert into Home(hid,image1) values('" + txt_imageid.Text + "',@img)";
                    c.Open();
                    cmd = new SqlCommand(sql, c);
                    cmd.Parameters.Add(new SqlParameter("@img", img));
                    int x = cmd.ExecuteNonQuery();
                    c.Close();
                    MessageBox.Show(x.ToString() + " imaged Saved Sucessfully.");
                }
                else
                {
                    MessageBox.Show("PLEASE SELECT THE IMAGE TYPE FROM THE COMBO BOX OR INSERT AN IMAGE.");
                }
                
            }

            catch(Exception exc)
            {
                c.Close();
                MessageBox.Show("YOU HAVE MISSED SOMETHING OR NOT BROWSE THE PICTURE PLEASE CHECK IT.");
            }
        }

        private void mainPagePhoto_Load(object sender, EventArgs e)
        {
            txt_name.Text = Form1.name;
        }
    }
}
