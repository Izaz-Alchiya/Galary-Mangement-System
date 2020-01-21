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
    public partial class Form1 : Form
    {
        public static string sendtext;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Want Some help or have Any Query about Online Gallary system then you can Contact Us on\n \t\"f201506100110121@gmail.com\" \n\t\tor on \n \t\"f201506100110074@gmail.com\"\n\nThankYou");
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            feedback abs = new feedback();
            abs.Visible = true;
            //MessageBox.Show("Want to give Suggestion Or Feedback Aboout Online Gallary system then you can Mail Us on\n \t\"f201506100110121@gmail.com\" \n\t\tor on \n \t\"f201506100110074@gmail.com\"\n\nThankYou");
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            aboutus abs = new aboutus();
            abs.Visible = true;
            //MessageBox.Show("You Can Store all your Photos In Online Gallery Mangament System And This Will be Secured In All Ways\n\t ThankYou");
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form1 f = new Form1();
            //f.Hide();
            Login lg = new Login();
            lg.Visible = true;
        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register r = new Register();
            r.Visible = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login ls = new Login();
            ls.Visible = true;
        }





        public static string name { get; set; }
    }
}
