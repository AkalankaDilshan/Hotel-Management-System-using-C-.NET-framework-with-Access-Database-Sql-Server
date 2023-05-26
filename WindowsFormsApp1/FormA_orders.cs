using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Color = System.Drawing.Color;

namespace WindowsFormsApp1
{
    public partial class FormA_orders : Form
    {
        private IconButton currentBtn;
        public int final_price;
        public FormA_orders()
        {
            InitializeComponent();
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            
            currentBtn = (IconButton)senderBtn;
            currentBtn.ForeColor = color;
            currentBtn.IconColor = color;

        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, Color.FromArgb(194, 0, 0));
            int quantity = Convert.ToInt32(numericUpDown1.Value);
            int dish_price = 1450;
            final_price += dish_price * quantity;

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
           // ActivateButton(sender, Color.FromArgb(194, 0, 0));
            int quantity = Convert.ToInt32(numericUpDown3.Value);
            int dish_price = 1600;
            final_price += dish_price * quantity;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
           // ActivateButton(sender, Color.FromArgb(194, 0, 0));
            int quantity = Convert.ToInt32(numericUpDown2.Value);
            int dish_price = 1500;
            final_price += dish_price * quantity;
        }

        private void materialButtonplace_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("MM/d/yyyy");
            string time = DateTime.Now.ToString("HH:mm:ss");
            string discription = "Food Order";
            int income = final_price;

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-ASH9GI9;Initial Catalog=Account;Integrated Security=True");
            con.Open();
            string sqlQuery = "INSERT INTO Account VALUES('" + @date + "','" + @time + "','" + @discription + "','" + @income + "')";
            SqlCommand com = new SqlCommand(sqlQuery, con);
            adapter.InsertCommand = com;
            adapter.InsertCommand.ExecuteNonQuery();
          
            MessageBox.Show("ODER IS SUCCESSFUL \n NET  TOTAL : LKR" + final_price + " ");
            this.Close();

        }
    }
}
