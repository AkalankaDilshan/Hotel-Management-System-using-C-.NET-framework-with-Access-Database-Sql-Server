namespace WindowsFormsApp1
{
    partial class Form_admin
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
            this.lbl_titel = new System.Windows.Forms.Label();
            this.iconButton_VIEW = new FontAwesome.Sharp.IconButton();
            this.iconButton_REMOVE_USERS = new FontAwesome.Sharp.IconButton();
            this.iconButton_ADD_USERS = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titel
            // 
            this.lbl_titel.AutoSize = true;
            this.lbl_titel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titel.ForeColor = System.Drawing.Color.Ivory;
            this.lbl_titel.Location = new System.Drawing.Point(344, 31);
            this.lbl_titel.Name = "lbl_titel";
            this.lbl_titel.Size = new System.Drawing.Size(326, 50);
            this.lbl_titel.TabIndex = 0;
            this.lbl_titel.Text = "ADMIN PANEL";
            // 
            // iconButton_VIEW
            // 
            this.iconButton_VIEW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(223)))), ((int)(((byte)(170)))));
            this.iconButton_VIEW.FlatAppearance.BorderSize = 0;
            this.iconButton_VIEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_VIEW.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_VIEW.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton_VIEW.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.iconButton_VIEW.IconColor = System.Drawing.Color.RosyBrown;
            this.iconButton_VIEW.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_VIEW.Location = new System.Drawing.Point(720, 476);
            this.iconButton_VIEW.Name = "iconButton_VIEW";
            this.iconButton_VIEW.Size = new System.Drawing.Size(287, 65);
            this.iconButton_VIEW.TabIndex = 4;
            this.iconButton_VIEW.Text = "VIEW USER TABLE";
            this.iconButton_VIEW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_VIEW.UseVisualStyleBackColor = false;
            // 
            // iconButton_REMOVE_USERS
            // 
            this.iconButton_REMOVE_USERS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(223)))), ((int)(((byte)(170)))));
            this.iconButton_REMOVE_USERS.FlatAppearance.BorderSize = 0;
            this.iconButton_REMOVE_USERS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_REMOVE_USERS.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_REMOVE_USERS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton_REMOVE_USERS.IconChar = FontAwesome.Sharp.IconChar.UserSlash;
            this.iconButton_REMOVE_USERS.IconColor = System.Drawing.Color.RosyBrown;
            this.iconButton_REMOVE_USERS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_REMOVE_USERS.Location = new System.Drawing.Point(374, 476);
            this.iconButton_REMOVE_USERS.Name = "iconButton_REMOVE_USERS";
            this.iconButton_REMOVE_USERS.Size = new System.Drawing.Size(287, 65);
            this.iconButton_REMOVE_USERS.TabIndex = 3;
            this.iconButton_REMOVE_USERS.Text = "REMOVE USERS";
            this.iconButton_REMOVE_USERS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_REMOVE_USERS.UseVisualStyleBackColor = false;
            // 
            // iconButton_ADD_USERS
            // 
            this.iconButton_ADD_USERS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(223)))), ((int)(((byte)(170)))));
            this.iconButton_ADD_USERS.FlatAppearance.BorderSize = 0;
            this.iconButton_ADD_USERS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_ADD_USERS.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_ADD_USERS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton_ADD_USERS.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButton_ADD_USERS.IconColor = System.Drawing.Color.RosyBrown;
            this.iconButton_ADD_USERS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_ADD_USERS.Location = new System.Drawing.Point(39, 476);
            this.iconButton_ADD_USERS.Name = "iconButton_ADD_USERS";
            this.iconButton_ADD_USERS.Size = new System.Drawing.Size(287, 65);
            this.iconButton_ADD_USERS.TabIndex = 2;
            this.iconButton_ADD_USERS.Text = "SIGN UP";
            this.iconButton_ADD_USERS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_ADD_USERS.UseVisualStyleBackColor = false;
            this.iconButton_ADD_USERS.Click += new System.EventHandler(this.iconButton_ADD_USERS_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.pngwing_com_1_;
            this.pictureBox1.Location = new System.Drawing.Point(347, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form_admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1042, 583);
            this.Controls.Add(this.iconButton_VIEW);
            this.Controls.Add(this.iconButton_REMOVE_USERS);
            this.Controls.Add(this.iconButton_ADD_USERS);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_titel);
            this.Name = "Form_admin";
            this.Text = "Form_admin";
            this.Load += new System.EventHandler(this.Form_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton_ADD_USERS;
        private FontAwesome.Sharp.IconButton iconButton_REMOVE_USERS;
        private FontAwesome.Sharp.IconButton iconButton_VIEW;
    }
}