namespace GUI
{
    partial class AdminInsuranceType
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datalistUser = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.canclebtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deductibletxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Amounttxt = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nametypetxt = new System.Windows.Forms.TextBox();
            this.premiumRatetxt = new System.Windows.Forms.TextBox();
            this.limittxt = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datalistUser);
            this.groupBox2.Location = new System.Drawing.Point(12, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1008, 443);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách loại bảo hiểm";
            // 
            // datalistUser
            // 
            this.datalistUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datalistUser.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datalistUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistUser.Location = new System.Drawing.Point(6, 25);
            this.datalistUser.Name = "datalistUser";
            this.datalistUser.ReadOnly = true;
            this.datalistUser.RowHeadersWidth = 62;
            this.datalistUser.RowTemplate.Height = 28;
            this.datalistUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistUser.Size = new System.Drawing.Size(996, 412);
            this.datalistUser.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.limittxt);
            this.groupBox1.Controls.Add(this.premiumRatetxt);
            this.groupBox1.Controls.Add(this.canclebtn);
            this.groupBox1.Controls.Add(this.savebtn);
            this.groupBox1.Controls.Add(this.deletebtn);
            this.groupBox1.Controls.Add(this.editbtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.deductibletxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Amounttxt);
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nametypetxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 237);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // canclebtn
            // 
            this.canclebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.canclebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.canclebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.canclebtn.Location = new System.Drawing.Point(864, 180);
            this.canclebtn.Name = "canclebtn";
            this.canclebtn.Size = new System.Drawing.Size(131, 34);
            this.canclebtn.TabIndex = 14;
            this.canclebtn.Text = "Hủy";
            this.canclebtn.UseVisualStyleBackColor = false;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.Green;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.savebtn.Location = new System.Drawing.Point(711, 180);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(130, 34);
            this.savebtn.TabIndex = 13;
            this.savebtn.Text = "Lưu";
            this.savebtn.UseVisualStyleBackColor = false;
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deletebtn.Location = new System.Drawing.Point(909, 120);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(86, 34);
            this.deletebtn.TabIndex = 12;
            this.deletebtn.Text = "Xóa";
            this.deletebtn.UseVisualStyleBackColor = false;
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editbtn.Location = new System.Drawing.Point(809, 120);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(86, 34);
            this.editbtn.TabIndex = 11;
            this.editbtn.Text = "Sửa";
            this.editbtn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hạn mức hợp đồng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tỷ lệ phí bảo hiểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Khấu trừ";
            // 
            // deductibletxt
            // 
            this.deductibletxt.Enabled = false;
            this.deductibletxt.Location = new System.Drawing.Point(24, 184);
            this.deductibletxt.Name = "deductibletxt";
            this.deductibletxt.PasswordChar = '*';
            this.deductibletxt.Size = new System.Drawing.Size(293, 26);
            this.deductibletxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số tiền bảo hiểm";
            // 
            // Amounttxt
            // 
            this.Amounttxt.Enabled = false;
            this.Amounttxt.Location = new System.Drawing.Point(24, 120);
            this.Amounttxt.Name = "Amounttxt";
            this.Amounttxt.Size = new System.Drawing.Size(293, 26);
            this.Amounttxt.TabIndex = 3;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addbtn.Location = new System.Drawing.Point(711, 120);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(86, 34);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "Thêm";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên loại bảo hiểm";
            // 
            // nametypetxt
            // 
            this.nametypetxt.Enabled = false;
            this.nametypetxt.Location = new System.Drawing.Point(24, 58);
            this.nametypetxt.Name = "nametypetxt";
            this.nametypetxt.Size = new System.Drawing.Size(293, 26);
            this.nametypetxt.TabIndex = 0;
            // 
            // premiumRatetxt
            // 
            this.premiumRatetxt.Enabled = false;
            this.premiumRatetxt.Location = new System.Drawing.Point(371, 124);
            this.premiumRatetxt.Name = "premiumRatetxt";
            this.premiumRatetxt.Size = new System.Drawing.Size(293, 26);
            this.premiumRatetxt.TabIndex = 17;
            // 
            // limittxt
            // 
            this.limittxt.Enabled = false;
            this.limittxt.Location = new System.Drawing.Point(371, 184);
            this.limittxt.Name = "limittxt";
            this.limittxt.Size = new System.Drawing.Size(293, 26);
            this.limittxt.TabIndex = 18;
            // 
            // AdminInsuranceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 710);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "AdminInsuranceType";
            this.Text = "AdminInsuranceType";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datalistUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView datalistUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button canclebtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deductibletxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Amounttxt;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametypetxt;
        private System.Windows.Forms.TextBox limittxt;
        private System.Windows.Forms.TextBox premiumRatetxt;
    }
}