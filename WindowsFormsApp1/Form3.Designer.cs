namespace WindowsFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //create functions
        




          


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel_left = new System.Windows.Forms.Panel();
            this.iconButton_tweet = new FontAwesome.Sharp.IconButton();
            this.iconButton_inst = new FontAwesome.Sharp.IconButton();
            this.iconButtonWhatup = new FontAwesome.Sharp.IconButton();
            this.iconButton_Local_Guide = new FontAwesome.Sharp.IconButton();
            this.iconButton_facebook = new FontAwesome.Sharp.IconButton();
            this.iconButton_Vehicles = new FontAwesome.Sharp.IconButton();
            this.iconButton_Events = new FontAwesome.Sharp.IconButton();
            this.iconButton_orders = new FontAwesome.Sharp.IconButton();
            this.iconButton_rooms = new FontAwesome.Sharp.IconButton();
            this.iconButton_Dashboard = new FontAwesome.Sharp.IconButton();
            this.panel_titel = new System.Windows.Forms.Panel();
            this.PIC_BOX_USER_DP = new System.Windows.Forms.PictureBox();
            this.lbl_user_name = new System.Windows.Forms.Label();
            this.lbl_hi = new System.Windows.Forms.Label();
            this.iconButton_settings = new FontAwesome.Sharp.IconButton();
            this.iconButton_bell = new FontAwesome.Sharp.IconButton();
            this.label_mng_sys = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Display = new System.Windows.Forms.Panel();
            this.base_panel = new System.Windows.Forms.Panel();
            this.pictureBox_main_log = new System.Windows.Forms.PictureBox();
            this.panel_left.SuspendLayout();
            this.panel_titel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_BOX_USER_DP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Display.SuspendLayout();
            this.base_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main_log)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.panel_left.Controls.Add(this.iconButton_tweet);
            this.panel_left.Controls.Add(this.iconButton_inst);
            this.panel_left.Controls.Add(this.iconButtonWhatup);
            this.panel_left.Controls.Add(this.iconButton_Local_Guide);
            this.panel_left.Controls.Add(this.iconButton_facebook);
            this.panel_left.Controls.Add(this.iconButton_Vehicles);
            this.panel_left.Controls.Add(this.iconButton_Events);
            this.panel_left.Controls.Add(this.iconButton_orders);
            this.panel_left.Controls.Add(this.iconButton_rooms);
            this.panel_left.Controls.Add(this.iconButton_Dashboard);
            this.panel_left.Location = new System.Drawing.Point(0, 71);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(245, 665);
            this.panel_left.TabIndex = 0;
            // 
            // iconButton_tweet
            // 
            this.iconButton_tweet.FlatAppearance.BorderSize = 0;
            this.iconButton_tweet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_tweet.IconChar = FontAwesome.Sharp.IconChar.Twitter;
            this.iconButton_tweet.IconColor = System.Drawing.Color.White;
            this.iconButton_tweet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_tweet.IconSize = 40;
            this.iconButton_tweet.Location = new System.Drawing.Point(166, 606);
            this.iconButton_tweet.Name = "iconButton_tweet";
            this.iconButton_tweet.Size = new System.Drawing.Size(52, 45);
            this.iconButton_tweet.TabIndex = 2;
            this.iconButton_tweet.UseVisualStyleBackColor = true;
            this.iconButton_tweet.Click += new System.EventHandler(this.iconButton_tweet_Click);
            // 
            // iconButton_inst
            // 
            this.iconButton_inst.FlatAppearance.BorderSize = 0;
            this.iconButton_inst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_inst.IconChar = FontAwesome.Sharp.IconChar.Instagram;
            this.iconButton_inst.IconColor = System.Drawing.Color.White;
            this.iconButton_inst.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_inst.IconSize = 40;
            this.iconButton_inst.Location = new System.Drawing.Point(112, 606);
            this.iconButton_inst.Name = "iconButton_inst";
            this.iconButton_inst.Size = new System.Drawing.Size(52, 45);
            this.iconButton_inst.TabIndex = 1;
            this.iconButton_inst.UseVisualStyleBackColor = true;
            this.iconButton_inst.Click += new System.EventHandler(this.iconButton_inst_Click);
            // 
            // iconButtonWhatup
            // 
            this.iconButtonWhatup.FlatAppearance.BorderSize = 0;
            this.iconButtonWhatup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonWhatup.ForeColor = System.Drawing.Color.Transparent;
            this.iconButtonWhatup.IconChar = FontAwesome.Sharp.IconChar.Whatsapp;
            this.iconButtonWhatup.IconColor = System.Drawing.Color.White;
            this.iconButtonWhatup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonWhatup.IconSize = 40;
            this.iconButtonWhatup.Location = new System.Drawing.Point(58, 606);
            this.iconButtonWhatup.Name = "iconButtonWhatup";
            this.iconButtonWhatup.Size = new System.Drawing.Size(60, 45);
            this.iconButtonWhatup.TabIndex = 3;
            this.iconButtonWhatup.UseVisualStyleBackColor = true;
            this.iconButtonWhatup.Click += new System.EventHandler(this.iconButtonWhatup_Click);
            // 
            // iconButton_Local_Guide
            // 
            this.iconButton_Local_Guide.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_Local_Guide.FlatAppearance.BorderSize = 0;
            this.iconButton_Local_Guide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Local_Guide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_Local_Guide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(236)))), ((int)(((byte)(217)))));
            this.iconButton_Local_Guide.IconChar = FontAwesome.Sharp.IconChar.StreetView;
            this.iconButton_Local_Guide.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(236)))), ((int)(((byte)(217)))));
            this.iconButton_Local_Guide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Local_Guide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Local_Guide.Location = new System.Drawing.Point(0, 400);
            this.iconButton_Local_Guide.Name = "iconButton_Local_Guide";
            this.iconButton_Local_Guide.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton_Local_Guide.Size = new System.Drawing.Size(245, 80);
            this.iconButton_Local_Guide.TabIndex = 6;
            this.iconButton_Local_Guide.Text = "    Local Guide";
            this.iconButton_Local_Guide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_Local_Guide.UseVisualStyleBackColor = true;
            this.iconButton_Local_Guide.Click += new System.EventHandler(this.iconButton_Local_Guide_Click);
            // 
            // iconButton_facebook
            // 
            this.iconButton_facebook.FlatAppearance.BorderSize = 0;
            this.iconButton_facebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_facebook.ForeColor = System.Drawing.Color.White;
            this.iconButton_facebook.IconChar = FontAwesome.Sharp.IconChar.Facebook;
            this.iconButton_facebook.IconColor = System.Drawing.Color.White;
            this.iconButton_facebook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_facebook.IconSize = 40;
            this.iconButton_facebook.Location = new System.Drawing.Point(12, 603);
            this.iconButton_facebook.Name = "iconButton_facebook";
            this.iconButton_facebook.Size = new System.Drawing.Size(52, 50);
            this.iconButton_facebook.TabIndex = 0;
            this.iconButton_facebook.UseVisualStyleBackColor = true;
            this.iconButton_facebook.Click += new System.EventHandler(this.iconButton_facebook_Click);
            // 
            // iconButton_Vehicles
            // 
            this.iconButton_Vehicles.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_Vehicles.FlatAppearance.BorderSize = 0;
            this.iconButton_Vehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Vehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_Vehicles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(236)))), ((int)(((byte)(217)))));
            this.iconButton_Vehicles.IconChar = FontAwesome.Sharp.IconChar.TruckMonster;
            this.iconButton_Vehicles.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(236)))), ((int)(((byte)(217)))));
            this.iconButton_Vehicles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Vehicles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Vehicles.Location = new System.Drawing.Point(0, 320);
            this.iconButton_Vehicles.Name = "iconButton_Vehicles";
            this.iconButton_Vehicles.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton_Vehicles.Size = new System.Drawing.Size(245, 80);
            this.iconButton_Vehicles.TabIndex = 5;
            this.iconButton_Vehicles.Text = "    Vehicles";
            this.iconButton_Vehicles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_Vehicles.UseVisualStyleBackColor = true;
            this.iconButton_Vehicles.Click += new System.EventHandler(this.iconButton_Vehicles_Click);
            // 
            // iconButton_Events
            // 
            this.iconButton_Events.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_Events.FlatAppearance.BorderSize = 0;
            this.iconButton_Events.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Events.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_Events.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(236)))), ((int)(((byte)(217)))));
            this.iconButton_Events.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.iconButton_Events.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(236)))), ((int)(((byte)(217)))));
            this.iconButton_Events.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Events.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Events.Location = new System.Drawing.Point(0, 240);
            this.iconButton_Events.Name = "iconButton_Events";
            this.iconButton_Events.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton_Events.Size = new System.Drawing.Size(245, 80);
            this.iconButton_Events.TabIndex = 4;
            this.iconButton_Events.Text = "    Events";
            this.iconButton_Events.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_Events.UseVisualStyleBackColor = true;
            this.iconButton_Events.Click += new System.EventHandler(this.iconButton_Events_Click);
            // 
            // iconButton_orders
            // 
            this.iconButton_orders.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_orders.FlatAppearance.BorderSize = 0;
            this.iconButton_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_orders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(236)))), ((int)(((byte)(217)))));
            this.iconButton_orders.IconChar = FontAwesome.Sharp.IconChar.AppleAlt;
            this.iconButton_orders.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(236)))), ((int)(((byte)(217)))));
            this.iconButton_orders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_orders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_orders.Location = new System.Drawing.Point(0, 160);
            this.iconButton_orders.Name = "iconButton_orders";
            this.iconButton_orders.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton_orders.Size = new System.Drawing.Size(245, 80);
            this.iconButton_orders.TabIndex = 3;
            this.iconButton_orders.Text = "    Order";
            this.iconButton_orders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_orders.UseVisualStyleBackColor = true;
            this.iconButton_orders.Click += new System.EventHandler(this.iconButton_orders_Click);
            // 
            // iconButton_rooms
            // 
            this.iconButton_rooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_rooms.FlatAppearance.BorderSize = 0;
            this.iconButton_rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_rooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(236)))), ((int)(((byte)(217)))));
            this.iconButton_rooms.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.iconButton_rooms.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(236)))), ((int)(((byte)(217)))));
            this.iconButton_rooms.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_rooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_rooms.Location = new System.Drawing.Point(0, 80);
            this.iconButton_rooms.Name = "iconButton_rooms";
            this.iconButton_rooms.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton_rooms.Size = new System.Drawing.Size(245, 80);
            this.iconButton_rooms.TabIndex = 2;
            this.iconButton_rooms.Text = "    Rooms";
            this.iconButton_rooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_rooms.UseVisualStyleBackColor = true;
            this.iconButton_rooms.Click += new System.EventHandler(this.iconButton_rooms_Click);
            // 
            // iconButton_Dashboard
            // 
            this.iconButton_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.iconButton_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_Dashboard.FlatAppearance.BorderSize = 0;
            this.iconButton_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(236)))), ((int)(((byte)(217)))));
            this.iconButton_Dashboard.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.iconButton_Dashboard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(236)))), ((int)(((byte)(217)))));
            this.iconButton_Dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.iconButton_Dashboard.Name = "iconButton_Dashboard";
            this.iconButton_Dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton_Dashboard.Size = new System.Drawing.Size(245, 80);
            this.iconButton_Dashboard.TabIndex = 1;
            this.iconButton_Dashboard.Text = "    Dashboard";
            this.iconButton_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_Dashboard.UseVisualStyleBackColor = false;
            this.iconButton_Dashboard.Click += new System.EventHandler(this.iconButton_Dashboard_Click);
            // 
            // panel_titel
            // 
            this.panel_titel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.panel_titel.Controls.Add(this.PIC_BOX_USER_DP);
            this.panel_titel.Controls.Add(this.lbl_user_name);
            this.panel_titel.Controls.Add(this.lbl_hi);
            this.panel_titel.Controls.Add(this.iconButton_settings);
            this.panel_titel.Controls.Add(this.iconButton_bell);
            this.panel_titel.Controls.Add(this.label_mng_sys);
            this.panel_titel.Controls.Add(this.pictureBox2);
            this.panel_titel.Controls.Add(this.label1);
            this.panel_titel.Controls.Add(this.pictureBox1);
            this.panel_titel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titel.Location = new System.Drawing.Point(0, 0);
            this.panel_titel.Name = "panel_titel";
            this.panel_titel.Size = new System.Drawing.Size(1310, 74);
            this.panel_titel.TabIndex = 3;
            // 
            // PIC_BOX_USER_DP
            // 
            this.PIC_BOX_USER_DP.Image = ((System.Drawing.Image)(resources.GetObject("PIC_BOX_USER_DP.Image")));
            this.PIC_BOX_USER_DP.Location = new System.Drawing.Point(1239, 4);
            this.PIC_BOX_USER_DP.Name = "PIC_BOX_USER_DP";
            this.PIC_BOX_USER_DP.Size = new System.Drawing.Size(63, 67);
            this.PIC_BOX_USER_DP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_BOX_USER_DP.TabIndex = 0;
            this.PIC_BOX_USER_DP.TabStop = false;
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.ForeColor = System.Drawing.Color.Chartreuse;
            this.lbl_user_name.Location = new System.Drawing.Point(1115, 35);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(102, 16);
            this.lbl_user_name.TabIndex = 0;
            this.lbl_user_name.Text = "M.K.A.DILSHAN";
            // 
            // lbl_hi
            // 
            this.lbl_hi.AutoSize = true;
            this.lbl_hi.ForeColor = System.Drawing.Color.Chartreuse;
            this.lbl_hi.Location = new System.Drawing.Point(1090, 36);
            this.lbl_hi.Name = "lbl_hi";
            this.lbl_hi.Size = new System.Drawing.Size(29, 16);
            this.lbl_hi.TabIndex = 0;
            this.lbl_hi.Text = "Hi.. ";
            // 
            // iconButton_settings
            // 
            this.iconButton_settings.FlatAppearance.BorderSize = 0;
            this.iconButton_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_settings.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            this.iconButton_settings.IconColor = System.Drawing.Color.White;
            this.iconButton_settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_settings.IconSize = 30;
            this.iconButton_settings.Location = new System.Drawing.Point(1029, 21);
            this.iconButton_settings.Name = "iconButton_settings";
            this.iconButton_settings.Size = new System.Drawing.Size(55, 46);
            this.iconButton_settings.TabIndex = 6;
            this.iconButton_settings.UseVisualStyleBackColor = true;
            this.iconButton_settings.Click += new System.EventHandler(this.iconButton_settings_Click);
            // 
            // iconButton_bell
            // 
            this.iconButton_bell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.iconButton_bell.FlatAppearance.BorderSize = 0;
            this.iconButton_bell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_bell.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton_bell.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.iconButton_bell.IconColor = System.Drawing.Color.White;
            this.iconButton_bell.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_bell.IconSize = 30;
            this.iconButton_bell.Location = new System.Drawing.Point(987, 19);
            this.iconButton_bell.Name = "iconButton_bell";
            this.iconButton_bell.Size = new System.Drawing.Size(36, 48);
            this.iconButton_bell.TabIndex = 5;
            this.iconButton_bell.UseVisualStyleBackColor = false;
            this.iconButton_bell.Click += new System.EventHandler(this.iconButton_bell_Click);
            // 
            // label_mng_sys
            // 
            this.label_mng_sys.AutoSize = true;
            this.label_mng_sys.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mng_sys.ForeColor = System.Drawing.Color.White;
            this.label_mng_sys.Location = new System.Drawing.Point(336, 19);
            this.label_mng_sys.Name = "label_mng_sys";
            this.label_mng_sys.Size = new System.Drawing.Size(359, 37);
            this.label_mng_sys.TabIndex = 4;
            this.label_mng_sys.Text = "MANAGEMENT SYSTEM";
            this.label_mng_sys.Click += new System.EventHandler(this.label_mng_sys_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(244, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(227, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "|";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_Display
            // 
            this.panel_Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.panel_Display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Display.Controls.Add(this.base_panel);
            this.panel_Display.Location = new System.Drawing.Point(244, 71);
            this.panel_Display.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Display.Name = "panel_Display";
            this.panel_Display.Size = new System.Drawing.Size(1066, 667);
            this.panel_Display.TabIndex = 2;
            this.panel_Display.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Display_Paint);
            // 
            // base_panel
            // 
            this.base_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.base_panel.AutoScroll = true;
            this.base_panel.AutoSize = true;
            this.base_panel.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._5385082;
            this.base_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.base_panel.Controls.Add(this.pictureBox_main_log);
            this.base_panel.Location = new System.Drawing.Point(3, 3);
            this.base_panel.Name = "base_panel";
            this.base_panel.Size = new System.Drawing.Size(1063, 1000);
            this.base_panel.TabIndex = 0;
            // 
            // pictureBox_main_log
            // 
            this.pictureBox_main_log.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_main_log.Image = global::WindowsFormsApp1.Properties.Resources.LOGO;
            this.pictureBox_main_log.Location = new System.Drawing.Point(184, 55);
            this.pictureBox_main_log.Name = "pictureBox_main_log";
            this.pictureBox_main_log.Size = new System.Drawing.Size(674, 546);
            this.pictureBox_main_log.TabIndex = 0;
            this.pictureBox_main_log.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1310, 736);
            this.Controls.Add(this.panel_titel);
            this.Controls.Add(this.panel_Display);
            this.Controls.Add(this.panel_left);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.panel_left.ResumeLayout(false);
            this.panel_titel.ResumeLayout(false);
            this.panel_titel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_BOX_USER_DP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Display.ResumeLayout(false);
            this.panel_Display.PerformLayout();
            this.base_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main_log)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private FontAwesome.Sharp.IconButton iconButton_Dashboard;
        private FontAwesome.Sharp.IconButton iconButton_Local_Guide;
        private FontAwesome.Sharp.IconButton iconButton_Vehicles;
        private FontAwesome.Sharp.IconButton iconButton_Events;
        private FontAwesome.Sharp.IconButton iconButton_orders;
        private FontAwesome.Sharp.IconButton iconButton_rooms;
        private System.Windows.Forms.Panel panel_Display;
        private FontAwesome.Sharp.IconButton iconButton_tweet;
        private FontAwesome.Sharp.IconButton iconButton_inst;
        private FontAwesome.Sharp.IconButton iconButtonWhatup;
        private FontAwesome.Sharp.IconButton iconButton_facebook;
        private System.Windows.Forms.Panel panel_titel;
        private System.Windows.Forms.PictureBox PIC_BOX_USER_DP;
        private System.Windows.Forms.Label lbl_user_name;
        private System.Windows.Forms.Label lbl_hi;
        private FontAwesome.Sharp.IconButton iconButton_settings;
        private FontAwesome.Sharp.IconButton iconButton_bell;
        private System.Windows.Forms.Label label_mng_sys;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel base_panel;
        private System.Windows.Forms.PictureBox pictureBox_main_log;
    }
}