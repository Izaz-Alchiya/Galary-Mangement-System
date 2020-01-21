namespace Online_Galary_managment_system
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.cmb_month = new System.Windows.Forms.ComboBox();
            this.cmb_day = new System.Windows.Forms.ComboBox();
            this.cmb_year = new System.Windows.Forms.ComboBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.txt_lname = new System.Windows.Forms.RichTextBox();
            this.txt_fname = new System.Windows.Forms.RichTextBox();
            this.txt_username = new System.Windows.Forms.RichTextBox();
            this.txt_password = new System.Windows.Forms.RichTextBox();
            this.txt_email = new System.Windows.Forms.RichTextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_month
            // 
            this.cmb_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_month.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_month.ForeColor = System.Drawing.Color.DarkGray;
            this.cmb_month.FormattingEnabled = true;
            this.cmb_month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmb_month.Location = new System.Drawing.Point(35, 279);
            this.cmb_month.Name = "cmb_month";
            this.cmb_month.Size = new System.Drawing.Size(159, 35);
            this.cmb_month.TabIndex = 5;
            this.cmb_month.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmb_month.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_month_KeyPress);
            // 
            // cmb_day
            // 
            this.cmb_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_day.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_day.ForeColor = System.Drawing.Color.DarkGray;
            this.cmb_day.FormattingEnabled = true;
            this.cmb_day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmb_day.Location = new System.Drawing.Point(232, 279);
            this.cmb_day.Name = "cmb_day";
            this.cmb_day.Size = new System.Drawing.Size(159, 35);
            this.cmb_day.TabIndex = 6;
            this.cmb_day.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_day_KeyPress);
            // 
            // cmb_year
            // 
            this.cmb_year.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_year.ForeColor = System.Drawing.Color.DarkGray;
            this.cmb_year.FormattingEnabled = true;
            this.cmb_year.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            ""});
            this.cmb_year.Location = new System.Drawing.Point(426, 279);
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.Size = new System.Drawing.Size(159, 35);
            this.cmb_year.TabIndex = 7;
            this.cmb_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_year_KeyPress);
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.Black;
            this.btn_register.Location = new System.Drawing.Point(220, 332);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(188, 62);
            this.btn_register.TabIndex = 8;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(530, 351);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(96, 37);
            this.btn_home.TabIndex = 9;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // txt_lname
            // 
            this.txt_lname.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_lname.Location = new System.Drawing.Point(313, 74);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(289, 60);
            this.txt_lname.TabIndex = 4;
            this.txt_lname.Text = "  Last Name";
            this.txt_lname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_lname_MouseClick);
            // 
            // txt_fname
            // 
            this.txt_fname.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_fname.Location = new System.Drawing.Point(27, 74);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(280, 60);
            this.txt_fname.TabIndex = 3;
            this.txt_fname.Text = "  First name";
            this.txt_fname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox4_MouseClick);
            this.txt_fname.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_username.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_username.Location = new System.Drawing.Point(27, 13);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(575, 55);
            this.txt_username.TabIndex = 0;
            this.txt_username.Text = "  User Name";
            this.txt_username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseClick);
            this.txt_username.TabIndexChanged += new System.EventHandler(this.txt_username_TabIndexChanged);
            this.txt_username.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_password.Location = new System.Drawing.Point(27, 201);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(575, 59);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "  New Password";
            this.txt_password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_password_MouseClick);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_email.Location = new System.Drawing.Point(27, 140);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(575, 55);
            this.txt_email.TabIndex = 1;
            this.txt_email.Text = "  Email Id";
            this.txt_email.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_email_MouseClick);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(35, 348);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(96, 37);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(107, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(330, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Day";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.cmb_year);
            this.Controls.Add(this.cmb_day);
            this.Controls.Add(this.cmb_month);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_username);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_month;
        private System.Windows.Forms.ComboBox cmb_day;
        private System.Windows.Forms.ComboBox cmb_year;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.RichTextBox txt_lname;
        private System.Windows.Forms.RichTextBox txt_fname;
        private System.Windows.Forms.RichTextBox txt_username;
        private System.Windows.Forms.RichTextBox txt_password;
        private System.Windows.Forms.RichTextBox txt_email;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}