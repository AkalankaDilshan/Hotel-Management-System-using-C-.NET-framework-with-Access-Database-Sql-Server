namespace WindowsFormsApp1
{
    partial class FormA_orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA_orders));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialButton1 = new FontAwesome.Sharp.Material.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_price = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_food_sub = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialButton2 = new FontAwesome.Sharp.Material.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.materialButton3 = new FontAwesome.Sharp.Material.MaterialButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.materialButtonplace = new FontAwesome.Sharp.Material.MaterialButton();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.dataSet_order1 = new WindowsFormsApp1.DataSet_order();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_order1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sri Lankan Style \r\nStir Fried Vegetable Noodles \r\nwith Black Pork Curry";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // materialButton1
            // 
            this.materialButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(163)))), ((int)(((byte)(87)))));
            this.materialButton1.FlatAppearance.BorderSize = 0;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton1.IconChar = FontAwesome.Sharp.MaterialIcons.ArrangeSendToBack;
            this.materialButton1.IconColor = System.Drawing.Color.Black;
            this.materialButton1.Location = new System.Drawing.Point(37, 336);
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(214, 67);
            this.materialButton1.TabIndex = 3;
            this.materialButton1.Text = "    ORDER";
            this.materialButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_price);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 418);
            this.panel1.TabIndex = 4;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(178, 277);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(73, 17);
            this.lbl_price.TabIndex = 6;
            this.lbl_price.Text = "LKR 1,450.00";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = true;
            this.numericUpDown1.BackColor = System.Drawing.Color.GreenYellow;
            this.numericUpDown1.Location = new System.Drawing.Point(106, 304);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(70, 22);
            this.numericUpDown1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_food_sub);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.numericUpDown2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.materialButton2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(707, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 417);
            this.panel2.TabIndex = 7;
            // 
            // lbl_food_sub
            // 
            this.lbl_food_sub.AutoSize = true;
            this.lbl_food_sub.BackColor = System.Drawing.Color.Transparent;
            this.lbl_food_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_food_sub.Location = new System.Drawing.Point(4, 218);
            this.lbl_food_sub.Name = "lbl_food_sub";
            this.lbl_food_sub.Size = new System.Drawing.Size(250, 60);
            this.lbl_food_sub.TabIndex = 7;
            this.lbl_food_sub.Text = "Basmathi Rice, Chicken Curry, Brinjal Moju,\r\nTempered Potato ,Boiled Egg, \r\nTomat" +
    "o and Onion Sambol,Mango Chutney, \r\n Papadam. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "LKR 1,500.00";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.AutoSize = true;
            this.numericUpDown2.BackColor = System.Drawing.Color.GreenYellow;
            this.numericUpDown2.Location = new System.Drawing.Point(106, 304);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(70, 22);
            this.numericUpDown2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 192);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // materialButton2
            // 
            this.materialButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(163)))), ((int)(((byte)(87)))));
            this.materialButton2.FlatAppearance.BorderSize = 0;
            this.materialButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton2.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton2.IconChar = FontAwesome.Sharp.MaterialIcons.ArrangeSendToBack;
            this.materialButton2.IconColor = System.Drawing.Color.Black;
            this.materialButton2.Location = new System.Drawing.Point(37, 336);
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(214, 67);
            this.materialButton2.TabIndex = 3;
            this.materialButton2.Text = "    ORDER";
            this.materialButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.materialButton2.UseVisualStyleBackColor = false;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yellow Rice with Chicken Curry\r\n";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(207)))), ((int)(((byte)(254)))));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.numericUpDown3);
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.materialButton3);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(380, 77);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(285, 417);
            this.panel6.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 45);
            this.label11.TabIndex = 7;
            this.label11.Text = "The rare yet perfect combination \r\nof string hopper Kottu with the\r\n beloved Kiri" +
    " Maalu curry";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(203, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "LKR 1,600.00";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.AutoSize = true;
            this.numericUpDown3.BackColor = System.Drawing.Color.GreenYellow;
            this.numericUpDown3.Location = new System.Drawing.Point(106, 304);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(70, 22);
            this.numericUpDown3.TabIndex = 5;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(283, 192);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // materialButton3
            // 
            this.materialButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(163)))), ((int)(((byte)(87)))));
            this.materialButton3.FlatAppearance.BorderSize = 0;
            this.materialButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton3.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton3.IconChar = FontAwesome.Sharp.MaterialIcons.ArrangeSendToBack;
            this.materialButton3.IconColor = System.Drawing.Color.Black;
            this.materialButton3.Location = new System.Drawing.Point(37, 337);
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(214, 67);
            this.materialButton3.TabIndex = 3;
            this.materialButton3.Text = "    ORDER";
            this.materialButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.materialButton3.UseVisualStyleBackColor = false;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(242, 48);
            this.label13.TabIndex = 1;
            this.label13.Text = "String Hopper Kottu with \r\n             Kiri Maalu";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Silver;
            this.label14.Font = new System.Drawing.Font("Leelawadee UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label14.Location = new System.Drawing.Point(309, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(504, 59);
            this.label14.TabIndex = 10;
            this.label14.Text = "FOOD  AND  BEVERAGE";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.vScrollBar1.Location = new System.Drawing.Point(2, 426);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 0);
            this.vScrollBar1.TabIndex = 11;
            // 
            // materialButtonplace
            // 
            this.materialButtonplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(163)))), ((int)(((byte)(87)))));
            this.materialButtonplace.FlatAppearance.BorderSize = 0;
            this.materialButtonplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButtonplace.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButtonplace.IconChar = FontAwesome.Sharp.MaterialIcons.ArrangeSendToBack;
            this.materialButtonplace.IconColor = System.Drawing.Color.Black;
            this.materialButtonplace.Location = new System.Drawing.Point(230, 504);
            this.materialButtonplace.Name = "materialButtonplace";
            this.materialButtonplace.Size = new System.Drawing.Size(583, 67);
            this.materialButtonplace.TabIndex = 7;
            this.materialButtonplace.Text = "                 PLACE  ORDER";
            this.materialButtonplace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.materialButtonplace.UseVisualStyleBackColor = false;
            this.materialButtonplace.Click += new System.EventHandler(this.materialButtonplace_Click);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT Account.*\r\nFROM     Account";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [Account] ([Date], [Time], [Description], [Income]) VALUES (@Date, @T" +
    "ime, @Description, @Income)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Date", System.Data.SqlDbType.VarChar, 0, "Date"),
            new System.Data.SqlClient.SqlParameter("@Time", System.Data.SqlDbType.VarChar, 0, "Time"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@Income", System.Data.SqlDbType.Int, 0, "Income")});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Account", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Date", "Date"),
                        new System.Data.Common.DataColumnMapping("Time", "Time"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("Income", "Income")})});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-ASH9GI9;Initial Catalog=Account;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // dataSet_order1
            // 
            this.dataSet_order1.DataSetName = "DataSet_order";
            this.dataSet_order1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormA_orders
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1012, 583);
            this.Controls.Add(this.materialButtonplace);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormA_orders";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormA_orders";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_order1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.Material.MaterialButton materialButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_food_sub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.Material.MaterialButton materialButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private FontAwesome.Sharp.Material.MaterialButton materialButton3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private FontAwesome.Sharp.Material.MaterialButton materialButtonplace;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private DataSet_order dataSet_order1;
    }
}