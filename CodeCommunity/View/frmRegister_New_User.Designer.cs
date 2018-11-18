namespace CodeCommunity.View
{
    partial class frmRegister_New_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister_New_User));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFirst_Name = new System.Windows.Forms.TextBox();
            this.lblFirst_Name = new System.Windows.Forms.Label();
            this.txtLast_Name = new System.Windows.Forms.TextBox();
            this.lblLast_Name = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChoose_Profile_Img = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.numUpDown_Age = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Age)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblTitle.Location = new System.Drawing.Point(84, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(216, 34);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "USE THE BELOW FORM TO \r\nREGISTER A NEW USER\r\n";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(157, 552);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 30);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Green;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(244, 552);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(79, 30);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(61, 182);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(263, 26);
            this.txtPassword.TabIndex = 10;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Silver;
            this.lblPassword.Location = new System.Drawing.Point(63, 159);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 17);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password :";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(61, 124);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(263, 26);
            this.txtusername.TabIndex = 8;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Silver;
            this.lblUsername.Location = new System.Drawing.Point(63, 101);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(86, 17);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(61, 240);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '*';
            this.txtEmail.Size = new System.Drawing.Size(263, 26);
            this.txtEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Silver;
            this.lblEmail.Location = new System.Drawing.Point(63, 217);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 17);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email :";
            // 
            // txtFirst_Name
            // 
            this.txtFirst_Name.Location = new System.Drawing.Point(61, 298);
            this.txtFirst_Name.Multiline = true;
            this.txtFirst_Name.Name = "txtFirst_Name";
            this.txtFirst_Name.PasswordChar = '*';
            this.txtFirst_Name.Size = new System.Drawing.Size(263, 26);
            this.txtFirst_Name.TabIndex = 17;
            // 
            // lblFirst_Name
            // 
            this.lblFirst_Name.AutoSize = true;
            this.lblFirst_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst_Name.ForeColor = System.Drawing.Color.Silver;
            this.lblFirst_Name.Location = new System.Drawing.Point(63, 275);
            this.lblFirst_Name.Name = "lblFirst_Name";
            this.lblFirst_Name.Size = new System.Drawing.Size(96, 17);
            this.lblFirst_Name.TabIndex = 16;
            this.lblFirst_Name.Text = "First Name :";
            // 
            // txtLast_Name
            // 
            this.txtLast_Name.Location = new System.Drawing.Point(61, 356);
            this.txtLast_Name.Multiline = true;
            this.txtLast_Name.Name = "txtLast_Name";
            this.txtLast_Name.PasswordChar = '*';
            this.txtLast_Name.Size = new System.Drawing.Size(263, 26);
            this.txtLast_Name.TabIndex = 19;
            // 
            // lblLast_Name
            // 
            this.lblLast_Name.AutoSize = true;
            this.lblLast_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast_Name.ForeColor = System.Drawing.Color.Silver;
            this.lblLast_Name.Location = new System.Drawing.Point(63, 333);
            this.lblLast_Name.Name = "lblLast_Name";
            this.lblLast_Name.Size = new System.Drawing.Size(95, 17);
            this.lblLast_Name.TabIndex = 18;
            this.lblLast_Name.Text = "Last Name :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.Silver;
            this.lblAge.Location = new System.Drawing.Point(63, 407);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(46, 17);
            this.lblAge.TabIndex = 20;
            this.lblAge.Text = "Age :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 444);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnChoose_Profile_Img
            // 
            this.btnChoose_Profile_Img.BackColor = System.Drawing.Color.Gray;
            this.btnChoose_Profile_Img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoose_Profile_Img.Location = new System.Drawing.Point(145, 458);
            this.btnChoose_Profile_Img.Name = "btnChoose_Profile_Img";
            this.btnChoose_Profile_Img.Size = new System.Drawing.Size(179, 30);
            this.btnChoose_Profile_Img.TabIndex = 23;
            this.btnChoose_Profile_Img.Text = "CHOOSE PROFILE IMG";
            this.btnChoose_Profile_Img.UseVisualStyleBackColor = false;
            this.btnChoose_Profile_Img.Click += new System.EventHandler(this.btnChoose_Profile_Img_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(61, 552);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 30);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "RESET FORM";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // numUpDown_Age
            // 
            this.numUpDown_Age.Location = new System.Drawing.Point(116, 407);
            this.numUpDown_Age.Name = "numUpDown_Age";
            this.numUpDown_Age.Size = new System.Drawing.Size(207, 20);
            this.numUpDown_Age.TabIndex = 25;
            // 
            // frmRegister_New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(384, 611);
            this.Controls.Add(this.numUpDown_Age);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnChoose_Profile_Img);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtLast_Name);
            this.Controls.Add(this.lblLast_Name);
            this.Controls.Add(this.txtFirst_Name);
            this.Controls.Add(this.lblFirst_Name);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblUsername);
            this.Name = "frmRegister_New_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Community -REGISTER USER-";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFirst_Name;
        private System.Windows.Forms.Label lblFirst_Name;
        private System.Windows.Forms.TextBox txtLast_Name;
        private System.Windows.Forms.Label lblLast_Name;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChoose_Profile_Img;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown numUpDown_Age;
    }
}