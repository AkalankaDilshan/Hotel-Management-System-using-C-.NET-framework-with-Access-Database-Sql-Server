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
    public partial class FormA_rooms : Form
    {
        public FormA_rooms()
        {
            InitializeComponent();
        }

       /* private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            wmPlayer.URL = @"E:\C#\Project\Resoucres\Template\room\hotel.mp4"; // This value comes from movie selection dialog
        }*/

       

        private void BTN_STANDARD_ROOM_Click_1(object sender, EventArgs e)
        {
            FormA_rooms_standardcs formA_Rooms_Standardcs = new FormA_rooms_standardcs();
            formA_Rooms_Standardcs.ShowDialog();
            formA_Rooms_Standardcs.Show();
        }

        private void btn_PREMIUM_ROOM_Click(object sender, EventArgs e)
        {
            FormA_Rooms_Premium formA_Rooms_Premium = new FormA_Rooms_Premium();    
            formA_Rooms_Premium.ShowDialog();
            formA_Rooms_Premium.Show();
        }

        private void btn_DELUXE_ROOM_Click(object sender, EventArgs e)
        {
            FormA_Rooms_deluxe_room formA_Rooms_Deluxe_Room = new FormA_Rooms_deluxe_room();
            formA_Rooms_Deluxe_Room.ShowDialog();
            formA_Rooms_Deluxe_Room.Show();
        }

        private void btn_MINI_SUITE_Click(object sender, EventArgs e)
        {
            FormA_rooms_Mini_suite formA_Rooms_Mini_Suite = new FormA_rooms_Mini_suite();   
            formA_Rooms_Mini_Suite.ShowDialog();
            formA_Rooms_Mini_Suite.Show();
        }

        private void BTN_STANDARD_ROOM_Click(object sender, EventArgs e)
        {

            FormA_rooms_standardcs formA_Rooms_Standardcs = new FormA_rooms_standardcs();
            formA_Rooms_Standardcs.ShowDialog();
            formA_Rooms_Standardcs.Show();
        }

        private void btn_PREMIUM_ROOM_Click_1(object sender, EventArgs e)
        {
            FormA_Rooms_Premium formA_Rooms_Premium = new FormA_Rooms_Premium();
            formA_Rooms_Premium.ShowDialog();
            formA_Rooms_Premium.Show();
        }

        private void btn_DELUXE_ROOM_Click_1(object sender, EventArgs e)
        {
            FormA_Rooms_deluxe_room formA_Rooms_Deluxe_Room = new FormA_Rooms_deluxe_room();
            formA_Rooms_Deluxe_Room.ShowDialog();
            formA_Rooms_Deluxe_Room.Show();
        }

        private void btn_MINI_SUITE_Click_1(object sender, EventArgs e)
        {
            FormA_rooms_Mini_suite formA_Rooms_Mini_Suite = new FormA_rooms_Mini_suite();
            formA_Rooms_Mini_Suite.ShowDialog();
            formA_Rooms_Mini_Suite.Show();
        }
    }
}
