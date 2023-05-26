namespace WindowsFormsApp1
{
    partial class FormA_Rooms_Premium
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA_Rooms_Premium));
            this.panel_standard_room = new System.Windows.Forms.Panel();
            this.comboBox__ROOM_ID = new System.Windows.Forms.ComboBox();
            this.btn_booking = new System.Windows.Forms.Button();
            this.fgfg = new System.Windows.Forms.Label();
            this.lbl_ROOM_NUMBER = new System.Windows.Forms.Label();
            this.comboBox__ROOM_OPTIONS = new System.Windows.Forms.ComboBox();
            this.lbl_ROOM_OPTIONS = new System.Windows.Forms.Label();
            this.comboBox_ROOM_TYPE = new System.Windows.Forms.ComboBox();
            this.LBL_ROOM_TYPE = new System.Windows.Forms.Label();
            this.dateTimePicker_Derarture = new System.Windows.Forms.DateTimePicker();
            this.label_DERATURE_DATE = new System.Windows.Forms.Label();
            this.dateTimePicker_arrival = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_EMAIL_ADDRESS = new System.Windows.Forms.TextBox();
            this.lbl_EMAIL_ADDRESS = new System.Windows.Forms.Label();
            this.textBox_MOBILE_NO = new System.Windows.Forms.TextBox();
            this.LBL_MOBILE_NO = new System.Windows.Forms.Label();
            this.textBox_NAME = new System.Windows.Forms.TextBox();
            this.lbl_FULL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.dataSetPREMIUM1 = new WindowsFormsApp1.DataSetPREMIUM();
            this.panel_standard_room.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPREMIUM1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_standard_room
            // 
            this.panel_standard_room.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel_standard_room.Controls.Add(this.comboBox__ROOM_ID);
            this.panel_standard_room.Controls.Add(this.btn_booking);
            this.panel_standard_room.Controls.Add(this.fgfg);
            this.panel_standard_room.Controls.Add(this.lbl_ROOM_NUMBER);
            this.panel_standard_room.Controls.Add(this.comboBox__ROOM_OPTIONS);
            this.panel_standard_room.Controls.Add(this.lbl_ROOM_OPTIONS);
            this.panel_standard_room.Controls.Add(this.comboBox_ROOM_TYPE);
            this.panel_standard_room.Controls.Add(this.LBL_ROOM_TYPE);
            this.panel_standard_room.Controls.Add(this.dateTimePicker_Derarture);
            this.panel_standard_room.Controls.Add(this.label_DERATURE_DATE);
            this.panel_standard_room.Controls.Add(this.dateTimePicker_arrival);
            this.panel_standard_room.Controls.Add(this.label3);
            this.panel_standard_room.Controls.Add(this.textBox_EMAIL_ADDRESS);
            this.panel_standard_room.Controls.Add(this.lbl_EMAIL_ADDRESS);
            this.panel_standard_room.Controls.Add(this.textBox_MOBILE_NO);
            this.panel_standard_room.Controls.Add(this.LBL_MOBILE_NO);
            this.panel_standard_room.Controls.Add(this.textBox_NAME);
            this.panel_standard_room.Controls.Add(this.lbl_FULL);
            this.panel_standard_room.Controls.Add(this.label1);
            this.panel_standard_room.Controls.Add(this.pictureBox2);
            this.panel_standard_room.Controls.Add(this.label2);
            this.panel_standard_room.Controls.Add(this.lbl_title);
            this.panel_standard_room.Controls.Add(this.pictureBox1);
            this.panel_standard_room.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_standard_room.Location = new System.Drawing.Point(0, 0);
            this.panel_standard_room.Name = "panel_standard_room";
            this.panel_standard_room.Size = new System.Drawing.Size(1024, 877);
            this.panel_standard_room.TabIndex = 1;
            // 
            // comboBox__ROOM_ID
            // 
            this.comboBox__ROOM_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox__ROOM_ID.FormattingEnabled = true;
            this.comboBox__ROOM_ID.Items.AddRange(new object[] {
            "PR21",
            "PR22",
            "PR23",
            "PR24",
            "PR31",
            "PR32",
            "PR33",
            "PR34",
            "PR41",
            "PR42",
            "PR43",
            "PR44"});
            this.comboBox__ROOM_ID.Location = new System.Drawing.Point(542, 697);
            this.comboBox__ROOM_ID.Name = "comboBox__ROOM_ID";
            this.comboBox__ROOM_ID.Size = new System.Drawing.Size(235, 33);
            this.comboBox__ROOM_ID.TabIndex = 35;
            // 
            // btn_booking
            // 
            this.btn_booking.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_booking.FlatAppearance.BorderSize = 0;
            this.btn_booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_booking.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_booking.Location = new System.Drawing.Point(542, 810);
            this.btn_booking.Name = "btn_booking";
            this.btn_booking.Size = new System.Drawing.Size(198, 50);
            this.btn_booking.TabIndex = 34;
            this.btn_booking.Text = "BOOK NOW";
            this.btn_booking.UseVisualStyleBackColor = false;
            this.btn_booking.Click += new System.EventHandler(this.btn_booking_Click);
            // 
            // fgfg
            // 
            this.fgfg.AutoSize = true;
            this.fgfg.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgfg.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fgfg.Location = new System.Drawing.Point(540, 766);
            this.fgfg.Name = "fgfg";
            this.fgfg.Size = new System.Drawing.Size(200, 32);
            this.fgfg.TabIndex = 33;
            this.fgfg.Text = "TOTAL : LKR";
            // 
            // lbl_ROOM_NUMBER
            // 
            this.lbl_ROOM_NUMBER.AutoSize = true;
            this.lbl_ROOM_NUMBER.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ROOM_NUMBER.Location = new System.Drawing.Point(542, 677);
            this.lbl_ROOM_NUMBER.Name = "lbl_ROOM_NUMBER";
            this.lbl_ROOM_NUMBER.Size = new System.Drawing.Size(125, 17);
            this.lbl_ROOM_NUMBER.TabIndex = 31;
            this.lbl_ROOM_NUMBER.Text = "ROOM NUMBER";
            // 
            // comboBox__ROOM_OPTIONS
            // 
            this.comboBox__ROOM_OPTIONS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox__ROOM_OPTIONS.FormattingEnabled = true;
            this.comboBox__ROOM_OPTIONS.Items.AddRange(new object[] {
            "Room Only  - LKR.12 000",
            "Bed and Breakfast - LKR.19 500",
            "Half Board - LKR.28 000",
            "Full Board - LKR 48 000"});
            this.comboBox__ROOM_OPTIONS.Location = new System.Drawing.Point(543, 623);
            this.comboBox__ROOM_OPTIONS.Name = "comboBox__ROOM_OPTIONS";
            this.comboBox__ROOM_OPTIONS.Size = new System.Drawing.Size(235, 33);
            this.comboBox__ROOM_OPTIONS.TabIndex = 26;
            // 
            // lbl_ROOM_OPTIONS
            // 
            this.lbl_ROOM_OPTIONS.AutoSize = true;
            this.lbl_ROOM_OPTIONS.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ROOM_OPTIONS.Location = new System.Drawing.Point(540, 602);
            this.lbl_ROOM_OPTIONS.Name = "lbl_ROOM_OPTIONS";
            this.lbl_ROOM_OPTIONS.Size = new System.Drawing.Size(127, 17);
            this.lbl_ROOM_OPTIONS.TabIndex = 25;
            this.lbl_ROOM_OPTIONS.Text = "ROOM OPTIONS";
            // 
            // comboBox_ROOM_TYPE
            // 
            this.comboBox_ROOM_TYPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ROOM_TYPE.FormattingEnabled = true;
            this.comboBox_ROOM_TYPE.Items.AddRange(new object[] {
            "DOUBLE",
            "TRIPLE",
            "QUADRUPLE"});
            this.comboBox_ROOM_TYPE.Location = new System.Drawing.Point(542, 559);
            this.comboBox_ROOM_TYPE.Name = "comboBox_ROOM_TYPE";
            this.comboBox_ROOM_TYPE.Size = new System.Drawing.Size(236, 33);
            this.comboBox_ROOM_TYPE.TabIndex = 24;
            // 
            // LBL_ROOM_TYPE
            // 
            this.LBL_ROOM_TYPE.AutoSize = true;
            this.LBL_ROOM_TYPE.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ROOM_TYPE.Location = new System.Drawing.Point(539, 528);
            this.LBL_ROOM_TYPE.Name = "LBL_ROOM_TYPE";
            this.LBL_ROOM_TYPE.Size = new System.Drawing.Size(98, 17);
            this.LBL_ROOM_TYPE.TabIndex = 23;
            this.LBL_ROOM_TYPE.Text = "ROOM TYPE";
            // 
            // dateTimePicker_Derarture
            // 
            this.dateTimePicker_Derarture.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Derarture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Derarture.Location = new System.Drawing.Point(542, 482);
            this.dateTimePicker_Derarture.Name = "dateTimePicker_Derarture";
            this.dateTimePicker_Derarture.Size = new System.Drawing.Size(236, 31);
            this.dateTimePicker_Derarture.TabIndex = 30;
            // 
            // label_DERATURE_DATE
            // 
            this.label_DERATURE_DATE.AutoSize = true;
            this.label_DERATURE_DATE.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DERATURE_DATE.Location = new System.Drawing.Point(539, 456);
            this.label_DERATURE_DATE.Name = "label_DERATURE_DATE";
            this.label_DERATURE_DATE.Size = new System.Drawing.Size(143, 17);
            this.label_DERATURE_DATE.TabIndex = 21;
            this.label_DERATURE_DATE.Text = "DERATURE DATE";
            // 
            // dateTimePicker_arrival
            // 
            this.dateTimePicker_arrival.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_arrival.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_arrival.Location = new System.Drawing.Point(542, 410);
            this.dateTimePicker_arrival.Name = "dateTimePicker_arrival";
            this.dateTimePicker_arrival.Size = new System.Drawing.Size(236, 31);
            this.dateTimePicker_arrival.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(539, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "ARRIVAL DATE";
            // 
            // textBox_EMAIL_ADDRESS
            // 
            this.textBox_EMAIL_ADDRESS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EMAIL_ADDRESS.Location = new System.Drawing.Point(542, 308);
            this.textBox_EMAIL_ADDRESS.Multiline = true;
            this.textBox_EMAIL_ADDRESS.Name = "textBox_EMAIL_ADDRESS";
            this.textBox_EMAIL_ADDRESS.Size = new System.Drawing.Size(236, 37);
            this.textBox_EMAIL_ADDRESS.TabIndex = 18;
            // 
            // lbl_EMAIL_ADDRESS
            // 
            this.lbl_EMAIL_ADDRESS.AutoSize = true;
            this.lbl_EMAIL_ADDRESS.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EMAIL_ADDRESS.Location = new System.Drawing.Point(539, 288);
            this.lbl_EMAIL_ADDRESS.Name = "lbl_EMAIL_ADDRESS";
            this.lbl_EMAIL_ADDRESS.Size = new System.Drawing.Size(130, 17);
            this.lbl_EMAIL_ADDRESS.TabIndex = 17;
            this.lbl_EMAIL_ADDRESS.Text = "EMAIL ADDRESS";
            // 
            // textBox_MOBILE_NO
            // 
            this.textBox_MOBILE_NO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_MOBILE_NO.Location = new System.Drawing.Point(542, 222);
            this.textBox_MOBILE_NO.Multiline = true;
            this.textBox_MOBILE_NO.Name = "textBox_MOBILE_NO";
            this.textBox_MOBILE_NO.Size = new System.Drawing.Size(236, 37);
            this.textBox_MOBILE_NO.TabIndex = 16;
            // 
            // LBL_MOBILE_NO
            // 
            this.LBL_MOBILE_NO.AutoSize = true;
            this.LBL_MOBILE_NO.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MOBILE_NO.Location = new System.Drawing.Point(539, 202);
            this.LBL_MOBILE_NO.Name = "LBL_MOBILE_NO";
            this.LBL_MOBILE_NO.Size = new System.Drawing.Size(92, 17);
            this.LBL_MOBILE_NO.TabIndex = 15;
            this.LBL_MOBILE_NO.Text = "MOBILE NO";
            // 
            // textBox_NAME
            // 
            this.textBox_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_NAME.Location = new System.Drawing.Point(542, 131);
            this.textBox_NAME.Multiline = true;
            this.textBox_NAME.Name = "textBox_NAME";
            this.textBox_NAME.Size = new System.Drawing.Size(236, 37);
            this.textBox_NAME.TabIndex = 14;
            // 
            // lbl_FULL
            // 
            this.lbl_FULL.AutoSize = true;
            this.lbl_FULL.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FULL.Location = new System.Drawing.Point(539, 110);
            this.lbl_FULL.Name = "lbl_FULL";
            this.lbl_FULL.Size = new System.Drawing.Size(99, 17);
            this.lbl_FULL.TabIndex = 5;
            this.lbl_FULL.Text = "FULL  NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "DESCRIPTION";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.icon_title;
            this.pictureBox2.Location = new System.Drawing.Point(408, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(271, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 234);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(402, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(285, 38);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "PREMIUM ROOM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.IMG_6443_min_1024x683_1;
            this.pictureBox1.Location = new System.Drawing.Point(31, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT table_room.*\r\nFROM     table_room";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Full_Name", System.Data.SqlDbType.VarChar, 0, "Full Name"),
            new System.Data.SqlClient.SqlParameter("@mobile_no", System.Data.SqlDbType.VarChar, 0, "mobile no"),
            new System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 0, "email"),
            new System.Data.SqlClient.SqlParameter("@in_date", System.Data.SqlDbType.VarChar, 0, "in_date"),
            new System.Data.SqlClient.SqlParameter("@out_date", System.Data.SqlDbType.VarChar, 0, "out_date"),
            new System.Data.SqlClient.SqlParameter("@room_type", System.Data.SqlDbType.VarChar, 0, "room type"),
            new System.Data.SqlClient.SqlParameter("@room_option", System.Data.SqlDbType.VarChar, 0, "room option"),
            new System.Data.SqlClient.SqlParameter("@room_id", System.Data.SqlDbType.Char, 0, "room_id"),
            new System.Data.SqlClient.SqlParameter("@stay_days", System.Data.SqlDbType.Int, 0, "stay_days"),
            new System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.VarChar, 0, "price")});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "table_room", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Full Name", "Full Name"),
                        new System.Data.Common.DataColumnMapping("mobile no", "mobile no"),
                        new System.Data.Common.DataColumnMapping("email", "email"),
                        new System.Data.Common.DataColumnMapping("in_date", "in_date"),
                        new System.Data.Common.DataColumnMapping("out_date", "out_date"),
                        new System.Data.Common.DataColumnMapping("room type", "room type"),
                        new System.Data.Common.DataColumnMapping("room option", "room option"),
                        new System.Data.Common.DataColumnMapping("room_id", "room_id"),
                        new System.Data.Common.DataColumnMapping("stay_days", "stay_days"),
                        new System.Data.Common.DataColumnMapping("price", "price")})});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-ASH9GI9;Initial Catalog=rooms;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // dataSetPREMIUM1
            // 
            this.dataSetPREMIUM1.DataSetName = "DataSetPREMIUM";
            this.dataSetPREMIUM1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormA_Rooms_Premium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 877);
            this.Controls.Add(this.panel_standard_room);
            this.Name = "FormA_Rooms_Premium";
            this.Text = "Form4";
            this.panel_standard_room.ResumeLayout(false);
            this.panel_standard_room.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPREMIUM1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_standard_room;
        private System.Windows.Forms.Button btn_booking;
        private System.Windows.Forms.Label fgfg;
        private System.Windows.Forms.Label lbl_ROOM_NUMBER;
        private System.Windows.Forms.ComboBox comboBox__ROOM_OPTIONS;
        private System.Windows.Forms.Label lbl_ROOM_OPTIONS;
        private System.Windows.Forms.ComboBox comboBox_ROOM_TYPE;
        private System.Windows.Forms.Label LBL_ROOM_TYPE;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Derarture;
        private System.Windows.Forms.Label label_DERATURE_DATE;
        private System.Windows.Forms.DateTimePicker dateTimePicker_arrival;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_EMAIL_ADDRESS;
        private System.Windows.Forms.Label lbl_EMAIL_ADDRESS;
        private System.Windows.Forms.TextBox textBox_MOBILE_NO;
        private System.Windows.Forms.Label LBL_MOBILE_NO;
        private System.Windows.Forms.TextBox textBox_NAME;
        private System.Windows.Forms.Label lbl_FULL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox__ROOM_ID;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private DataSetPREMIUM dataSetPREMIUM1;
    }
}