using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        private Form currentChildForm;
        private IconButton currentBtn;
        public string result;
        public Form3()
        {
            InitializeComponent();



        }


        private void OpenChildForm(Form childForm)
        {
            
        if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Display.Controls.Add(childForm);
            panel_Display.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(10,25,47);
                currentBtn.ForeColor = Color.FromArgb(111,236,217);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(111, 236, 217);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
            }   
                currentBtn = (IconButton)senderBtn;
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
            
        }

        

        private void panel_Display_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton_Dashboard_Click(object sender, EventArgs e) 
        {
            ActivateButton(sender,Color.FromArgb(194,0,0));
            OpenChildForm(new FormA_Dashboard());
        }

        private void iconButton_rooms_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormA_rooms());
            ActivateButton(sender, Color.FromArgb(194, 0, 0));
        }

        private void iconButton_orders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormA_orders());
            ActivateButton(sender, Color.FromArgb(194, 0, 0));
        }

        private void iconButton_Events_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormA_event());
            ActivateButton(sender, Color.FromArgb(194, 0, 0));
        }

        private void iconButton_Vehicles_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FormA_vehicles());
            ActivateButton(sender, Color.FromArgb(194, 0, 0));
        }

        private void iconButton_Local_Guide_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormA_local_guide());
            ActivateButton(sender, Color.FromArgb(194, 0, 0));
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_mng_sys_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton_bell_Click(object sender, EventArgs e)
        {

            // Launch browser to email...
            System.Diagnostics.Process.Start("https://mail.google.com/");
        }

        private void iconButton_facebook_Click(object sender, EventArgs e)
        {
            // Launch browser to facebook...
            System.Diagnostics.Process.Start("http://www.facebook.com");
        }

        private void iconButtonWhatup_Click(object sender, EventArgs e)
        {
            // Launch browser to whatapp...
            System.Diagnostics.Process.Start("https://web.whatsapp.com/");
        }

        private void iconButton_inst_Click(object sender, EventArgs e)
        {
            // Launch browser to instargram...
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void iconButton_tweet_Click(object sender, EventArgs e)
        {
            // Launch browser to Twitter...
            System.Diagnostics.Process.Start("https://twitter.com/i/flow/login");
        }

        private void iconButton_settings_Click(object sender, EventArgs e)
        {
             
                OpenChildForm(new Form_admin());
                ActivateButton(sender, Color.FromArgb(194, 0, 0));
           
            
        }
    }
}
