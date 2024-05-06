namespace GUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginEmailtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.loginPasswordtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.registerNavbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.loginNavbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.registerNametxt = new System.Windows.Forms.TextBox();
            this.registerbtn = new System.Windows.Forms.Button();
            this.registerEmailtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.registerPasswordtxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comfirmPasswordtxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // loginEmailtxt
            // 
            this.loginEmailtxt.Location = new System.Drawing.Point(95, 141);
            this.loginEmailtxt.Name = "loginEmailtxt";
            this.loginEmailtxt.Size = new System.Drawing.Size(218, 26);
            this.loginEmailtxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginbtn.Location = new System.Drawing.Point(95, 268);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(218, 35);
            this.loginbtn.TabIndex = 3;
            this.loginbtn.Text = "Đăng nhập";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "ĐĂNG KÝ";
            // 
            // loginPasswordtxt
            // 
            this.loginPasswordtxt.Location = new System.Drawing.Point(95, 215);
            this.loginPasswordtxt.Name = "loginPasswordtxt";
            this.loginPasswordtxt.PasswordChar = '*';
            this.loginPasswordtxt.Size = new System.Drawing.Size(218, 26);
            this.loginPasswordtxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mật Khẩu";
            // 
            // registerNavbtn
            // 
            this.registerNavbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.registerNavbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerNavbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registerNavbtn.Location = new System.Drawing.Point(95, 373);
            this.registerNavbtn.Name = "registerNavbtn";
            this.registerNavbtn.Size = new System.Drawing.Size(218, 35);
            this.registerNavbtn.TabIndex = 8;
            this.registerNavbtn.Text = "Đăng kí tài khoản";
            this.registerNavbtn.UseVisualStyleBackColor = false;
            this.registerNavbtn.Click += new System.EventHandler(this.registerNavbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bạn chưa có tài khoản?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Bạn đã có tài khoản?";
            // 
            // loginNavbtn
            // 
            this.loginNavbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.loginNavbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginNavbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginNavbtn.Location = new System.Drawing.Point(495, 373);
            this.loginNavbtn.Name = "loginNavbtn";
            this.loginNavbtn.Size = new System.Drawing.Size(218, 35);
            this.loginNavbtn.TabIndex = 15;
            this.loginNavbtn.Text = "Đăng nhập tài khoản";
            this.loginNavbtn.UseVisualStyleBackColor = false;
            this.loginNavbtn.Click += new System.EventHandler(this.loginNavbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Họ tên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Email";
            // 
            // registerNametxt
            // 
            this.registerNametxt.Location = new System.Drawing.Point(495, 147);
            this.registerNametxt.Name = "registerNametxt";
            this.registerNametxt.Size = new System.Drawing.Size(218, 26);
            this.registerNametxt.TabIndex = 12;
            // 
            // registerbtn
            // 
            this.registerbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registerbtn.Location = new System.Drawing.Point(495, 287);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(218, 35);
            this.registerbtn.TabIndex = 11;
            this.registerbtn.Text = "Đăng ký";
            this.registerbtn.UseVisualStyleBackColor = false;
            // 
            // registerEmailtxt
            // 
            this.registerEmailtxt.Location = new System.Drawing.Point(495, 106);
            this.registerEmailtxt.Name = "registerEmailtxt";
            this.registerEmailtxt.Size = new System.Drawing.Size(218, 26);
            this.registerEmailtxt.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mật Khẩu";
            // 
            // registerPasswordtxt
            // 
            this.registerPasswordtxt.Location = new System.Drawing.Point(495, 193);
            this.registerPasswordtxt.Name = "registerPasswordtxt";
            this.registerPasswordtxt.PasswordChar = '*';
            this.registerPasswordtxt.Size = new System.Drawing.Size(218, 26);
            this.registerPasswordtxt.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Xác nhận MK";
            // 
            // comfirmPasswordtxt
            // 
            this.comfirmPasswordtxt.Location = new System.Drawing.Point(495, 243);
            this.comfirmPasswordtxt.Name = "comfirmPasswordtxt";
            this.comfirmPasswordtxt.PasswordChar = '*';
            this.comfirmPasswordtxt.Size = new System.Drawing.Size(218, 26);
            this.comfirmPasswordtxt.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(529, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(351, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(376, 450);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 23;
            this.picture.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comfirmPasswordtxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.registerPasswordtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.loginNavbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.registerNametxt);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.registerEmailtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.registerNavbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginPasswordtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginEmailtxt);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginEmailtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginPasswordtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button registerNavbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button loginNavbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox registerNametxt;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.TextBox registerEmailtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox registerPasswordtxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox comfirmPasswordtxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picture;
    }
}