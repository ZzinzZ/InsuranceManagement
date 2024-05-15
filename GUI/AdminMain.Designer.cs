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
            this.userNav = new System.Windows.Forms.Button();
            this.AdminDashBoard = new System.Windows.Forms.Panel();
            this.accountantNav = new System.Windows.Forms.Button();
            this.typeInsNav = new System.Windows.Forms.Button();
            this.AdminDashBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNav
            // 
            this.userNav.Location = new System.Drawing.Point(0, 47);
            this.userNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userNav.Name = "userNav";
            this.userNav.Size = new System.Drawing.Size(151, 53);
            this.userNav.TabIndex = 0;
            this.userNav.Text = "Quản lí tài khoản";
            this.userNav.UseVisualStyleBackColor = true;
            this.userNav.Click += new System.EventHandler(this.userNav_Click);
            // 
            // AdminDashBoard
            // 
            this.AdminDashBoard.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AdminDashBoard.Controls.Add(this.accountantNav);
            this.AdminDashBoard.Controls.Add(this.typeInsNav);
            this.AdminDashBoard.Controls.Add(this.userNav);
            this.AdminDashBoard.Location = new System.Drawing.Point(0, 0);
            this.AdminDashBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminDashBoard.Name = "AdminDashBoard";
            this.AdminDashBoard.Size = new System.Drawing.Size(151, 560);
            this.AdminDashBoard.TabIndex = 0;
            // 
            // accountantNav
            // 
            this.accountantNav.Location = new System.Drawing.Point(0, 206);
            this.accountantNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountantNav.Name = "accountantNav";
            this.accountantNav.Size = new System.Drawing.Size(151, 53);
            this.accountantNav.TabIndex = 3;
            this.accountantNav.Text = "Kế toán";
            this.accountantNav.UseVisualStyleBackColor = true;
            this.accountantNav.Click += new System.EventHandler(this.button1_Click);
            // 
            // typeInsNav
            // 
            this.typeInsNav.Location = new System.Drawing.Point(0, 122);
            this.typeInsNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeInsNav.Name = "typeInsNav";
            this.typeInsNav.Size = new System.Drawing.Size(151, 58);
            this.typeInsNav.TabIndex = 2;
            this.typeInsNav.Text = "Quản lí loại bảo hiểm";
            this.typeInsNav.UseVisualStyleBackColor = true;
            this.typeInsNav.Click += new System.EventHandler(this.typeInsNav_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 558);
            this.Controls.Add(this.AdminDashBoard);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.Load += new System.EventHandler(this.AdminMain_Load);
            this.AdminDashBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button userNav;
        private System.Windows.Forms.Panel AdminDashBoard;
        private System.Windows.Forms.Button typeInsNav;
        private System.Windows.Forms.Button accountantNav;
    }
}