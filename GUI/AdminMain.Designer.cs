namespace GUI
{
    partial class AdminMain
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
            this.AdminMainBody = new System.Windows.Forms.Panel();
            this.userNav = new System.Windows.Forms.Button();
            this.AdminDashBoard = new System.Windows.Forms.Panel();
            this.typeInsNav = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AdminDashBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminMainBody
            // 
            this.AdminMainBody.Location = new System.Drawing.Point(113, -1);
            this.AdminMainBody.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminMainBody.Name = "AdminMainBody";
            this.AdminMainBody.Size = new System.Drawing.Size(707, 498);
            this.AdminMainBody.TabIndex = 1;
            // 
            // userNav
            // 
            this.userNav.Location = new System.Drawing.Point(0, 38);
            this.userNav.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userNav.Name = "userNav";
            this.userNav.Size = new System.Drawing.Size(113, 43);
            this.userNav.TabIndex = 0;
            this.userNav.Text = "Quản lí tài khoản";
            this.userNav.UseVisualStyleBackColor = true;
            this.userNav.Click += new System.EventHandler(this.userNav_Click);
            // 
            // AdminDashBoard
            // 
            this.AdminDashBoard.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AdminDashBoard.Controls.Add(this.button1);
            this.AdminDashBoard.Controls.Add(this.typeInsNav);
            this.AdminDashBoard.Controls.Add(this.userNav);
            this.AdminDashBoard.Location = new System.Drawing.Point(0, 0);
            this.AdminDashBoard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminDashBoard.Name = "AdminDashBoard";
            this.AdminDashBoard.Size = new System.Drawing.Size(113, 552);
            this.AdminDashBoard.TabIndex = 0;
            // 
            // typeInsNav
            // 
            this.typeInsNav.Location = new System.Drawing.Point(0, 99);
            this.typeInsNav.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.typeInsNav.Name = "typeInsNav";
            this.typeInsNav.Size = new System.Drawing.Size(113, 47);
            this.typeInsNav.TabIndex = 2;
            this.typeInsNav.Text = "Quản lí loại bảo hiểm";
            this.typeInsNav.UseVisualStyleBackColor = true;
            this.typeInsNav.Click += new System.EventHandler(this.typeInsNav_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kế toán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 487);
            this.Controls.Add(this.AdminMainBody);
            this.Controls.Add(this.AdminDashBoard);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.Load += new System.EventHandler(this.AdminMain_Load);
            this.AdminDashBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AdminMainBody;
        private System.Windows.Forms.Button userNav;
        private System.Windows.Forms.Panel AdminDashBoard;
        private System.Windows.Forms.Button typeInsNav;
        private System.Windows.Forms.Button button1;
    }
}