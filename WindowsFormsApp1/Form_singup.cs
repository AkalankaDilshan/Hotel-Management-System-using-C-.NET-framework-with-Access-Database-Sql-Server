using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form_singup : Form
    {
        public Form_singup()
        {
            InitializeComponent();
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            string First_name = txt_fname.Text;
            string Last_name = txt_fname.Text;
            string userID = txt_userID.Text;
            string email = txt_email.Text;
            string password = txt_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-ASH9GI9;Initial Catalog=Signup_used;Integrated Security=True");
            con.Open();

            string sqlQuery = "INSERT INTO mytable VALUES(@First_name,@Last_name,@userID,@email,@password)";
            SqlCommand com = new SqlCommand(sqlQuery,con);

            adapter.InsertCommand = com;
            adapter.InsertCommand.ExecuteNonQuery();

            //com.ExecuteNonQuery();


            MessageBox.Show("added");

        }
    }
}
