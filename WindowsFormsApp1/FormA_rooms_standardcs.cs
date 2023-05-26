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
    public partial class FormA_rooms_standardcs : Form
    {
        public FormA_rooms_standardcs()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel_standard_room_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void btn_booking_Click(object sender, EventArgs e)
        {
            string fname = textBox_NAME.Text;
            string mobile_number = textBox_MOBILE_NO.Text;
            string email = textBox_EMAIL_ADDRESS.Text;
            string theDate_arrival = dateTimePicker_arrival.Value.ToString("yyyy-MM-dd");
            string theDate_derature = dateTimePicker_Derarture.Value.ToString("yyyy-MM-dd");
            string room_type = comboBox_ROOM_TYPE.Text;
            int room_type_cal = comboBox_ROOM_TYPE.SelectedIndex + 1;
            string room_option = comboBox__ROOM_OPTIONS.Text;
            int room_option_cal = comboBox__ROOM_OPTIONS.SelectedIndex + 1;
            string room_id = comboBox__ROOM_ID.Text;
            int days;
            // dates differance

            DateTime arrival = Convert.ToDateTime(dateTimePicker_arrival.Text);
            DateTime derature = Convert.ToDateTime(dateTimePicker_Derarture.Text);
            days = int.Parse(derature.Subtract(arrival).Days.ToString());

            //price = full price * (room_option/4) * room_type * days
            int full_price = 40000;
            string price =(full_price * room_option_cal  * room_type_cal * days / 4).ToString();


            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-ASH9GI9;Initial Catalog=rooms;Integrated Security=True");
            con.Open();

            string sqlQuery = "INSERT INTO table_room VALUES('"+@fname+"','"+@mobile_number+"','"+@email+"','"+@theDate_arrival+"','"+@theDate_derature+"','"+@room_type+"','"+@room_option+"','"+@room_id+"','"+@days+"','"+@price+"')";
            SqlCommand com = new SqlCommand(sqlQuery, con);

            adapter.InsertCommand = com;
            adapter.InsertCommand.ExecuteNonQuery();
            this.Close();

        }

        private void sqlDataAdapter1_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            
        }
    }
}
