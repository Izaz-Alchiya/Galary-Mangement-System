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
    public partial class Welcome : Form
    {
       
        public Welcome()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainPagePhoto m = new mainPagePhoto();
            m.Visible = true;
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            this.Hide();
            Viewpage v = new Viewpage();
            v.Visible = true;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Visible = true;
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
