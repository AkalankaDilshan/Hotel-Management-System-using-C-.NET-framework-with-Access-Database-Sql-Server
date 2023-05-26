using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_user_name_TextChanged(object sender, EventArgs e)
        {
            
        }

         public string Check_user;
        //tempory user name and password
        /*
        string admin = "ADMIN";
        string admin_password = "admin";
        string user = "user001";
        string user_password = "0001";
        */
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            if (txt_user_name.Text == "admin" && txt_ps_wd.Text == "admin")
            {
                Check_user = "admin";
                Form3 form3 = new Form3();
                form3.ShowDialog();
                form3.Show();
                this.Hide();
            }

            else if (txt_user_name.Text == "user001" && txt_ps_wd.Text == "0001")
            {

                Form3 form3 = new Form3();
                form3.ShowDialog();
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect User Name or Password.!");
            }
             }
            

            public string TheValue
             {
            get { return Check_user; }
             }

    }
    
}
