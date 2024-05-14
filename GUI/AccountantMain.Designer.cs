namespace GUI
{
    partial class AccountantMain
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
            this.listgrp = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.infogrp = new System.Windows.Forms.GroupBox();
            this.NgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.NgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.exportbtn = new System.Windows.Forms.Button();
            this.typetxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.debittxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.durationtxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.feestxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ownertxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listgrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.infogrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // listgrp
            // 
            this.listgrp.BackColor = System.Drawing.SystemColors.Control;
            this.listgrp.Controls.Add(this.dataGridView1);
            this.listgrp.Location = new System.Drawing.Point(15, 313);
            this.listgrp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listgrp.Name = "listgrp";
            this.listgrp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listgrp.Size = new System.Drawing.Size(896, 241);
            this.listgrp.TabIndex = 3;
            this.listgrp.TabStop = false;
            this.listgrp.Text = "Danh sách hợp đồng đã tạo ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(887, 223);
            this.dataGridView1.TabIndex = 0;
            // 
            // infogrp
            // 
            this.infogrp.BackColor = System.Drawing.SystemColors.Control;
            this.infogrp.Controls.Add(this.NgayDangKy);
            this.infogrp.Controls.Add(this.NgayHetHan);
            this.infogrp.Controls.Add(this.exportbtn);
            this.infogrp.Controls.Add(this.typetxt);
            this.infogrp.Controls.Add(this.label13);
            this.infogrp.Controls.Add(this.label14);
            this.infogrp.Controls.Add(this.label15);
            this.infogrp.Controls.Add(this.label7);
            this.infogrp.Controls.Add(this.label8);
            this.infogrp.Controls.Add(this.debittxt);
            this.infogrp.Controls.Add(this.label9);
            this.infogrp.Controls.Add(this.emailtxt);
            this.infogrp.Controls.Add(this.label10);
            this.infogrp.Controls.Add(this.durationtxt);
            this.infogrp.Controls.Add(this.idtxt);
            this.infogrp.Controls.Add(this.feestxt);
            this.infogrp.Controls.Add(this.label4);
            this.infogrp.Controls.Add(this.ownertxt);
            this.infogrp.Controls.Add(this.label2);
            this.infogrp.Location = new System.Drawing.Point(13, 6);
            this.infogrp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infogrp.Name = "infogrp";
            this.infogrp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infogrp.Size = new System.Drawing.Size(896, 290);
            this.infogrp.TabIndex = 4;
            this.infogrp.TabStop = false;
            this.infogrp.Text = "Thông tin bảo hiểm";
            this.infogrp.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // NgayDangKy
            // 
            this.NgayDangKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayDangKy.Location = new System.Drawing.Point(196, 127);
            this.NgayDangKy.Name = "NgayDangKy";
            this.NgayDangKy.Size = new System.Drawing.Size(217, 22);
            this.NgayDangKy.TabIndex = 31;
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayHetHan.Location = new System.Drawing.Point(577, 124);
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.Size = new System.Drawing.Size(217, 22);
            this.NgayHetHan.TabIndex = 31;
            // 
            // exportbtn
            // 
            this.exportbtn.BackColor = System.Drawing.Color.Green;
            this.exportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exportbtn.Location = new System.Drawing.Point(740, 226);
            this.exportbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportbtn.Name = "exportbtn";
            this.exportbtn.Size = new System.Drawing.Size(97, 41);
            this.exportbtn.TabIndex = 30;
            this.exportbtn.Text = "Xuất file";
            this.exportbtn.UseVisualStyleBackColor = false;
            this.exportbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // typetxt
            // 
            this.typetxt.Location = new System.Drawing.Point(196, 172);
            this.typetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typetxt.Name = "typetxt";
            this.typetxt.Size = new System.Drawing.Size(217, 22);
            this.typetxt.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(95, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Loại bảo hiểm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(527, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "Số nợ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(477, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 16);
            this.label15.TabIndex = 20;
            this.label15.Text = "Ngày hết hạn";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Mã";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ngày đăng kí";
            // 
            // debittxt
            // 
            this.debittxt.Location = new System.Drawing.Point(577, 78);
            this.debittxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.debittxt.Name = "debittxt";
            this.debittxt.Size = new System.Drawing.Size(217, 22);
            this.debittxt.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Thời hạn bảo hiểm (năm)";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(576, 27);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(217, 22);
            this.emailtxt.TabIndex = 13;
            this.emailtxt.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(529, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Email";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // durationtxt
            // 
            this.durationtxt.Location = new System.Drawing.Point(196, 220);
            this.durationtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.durationtxt.Name = "durationtxt";
            this.durationtxt.Size = new System.Drawing.Size(217, 22);
            this.durationtxt.TabIndex = 9;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(576, 171);
            this.idtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(217, 22);
            this.idtxt.TabIndex = 7;
            // 
            // feestxt
            // 
            this.feestxt.Location = new System.Drawing.Point(196, 76);
            this.feestxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.feestxt.Name = "feestxt";
            this.feestxt.Size = new System.Drawing.Size(217, 22);
            this.feestxt.TabIndex = 5;
            this.feestxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phí bảo hiểm";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ownertxt
            // 
            this.ownertxt.Location = new System.Drawing.Point(196, 28);
            this.ownertxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ownertxt.Name = "ownertxt";
            this.ownertxt.Size = new System.Drawing.Size(217, 22);
            this.ownertxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Người sở hữu";
            // 
            // AccountantMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(917, 567);
            this.Controls.Add(this.infogrp);
            this.Controls.Add(this.listgrp);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountantMain";
            this.Text = "AccountantMain";
            this.listgrp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.infogrp.ResumeLayout(false);
            this.infogrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox listgrp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox infogrp;
        private System.Windows.Forms.Button exportbtn;
        private System.Windows.Forms.TextBox typetxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox debittxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox durationtxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox feestxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ownertxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker NgayDangKy;
        private System.Windows.Forms.DateTimePicker NgayHetHan;
    }
}