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
            this.listgrp = new System.Windows.Forms.GroupBox();
            this.datalistUser = new System.Windows.Forms.DataGridView();
            this.infogrp = new System.Windows.Forms.GroupBox();
            this.limittxt = new System.Windows.Forms.TextBox();
            this.premiumRatetxt = new System.Windows.Forms.TextBox();
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
            this.listgrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistUser)).BeginInit();
            this.infogrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // listgrp
            // 
            this.listgrp.Controls.Add(this.datalistUser);
            this.listgrp.Location = new System.Drawing.Point(11, 204);
            this.listgrp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listgrp.Name = "listgrp";
            this.listgrp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listgrp.Size = new System.Drawing.Size(896, 354);
            this.listgrp.TabIndex = 3;
            this.listgrp.TabStop = false;
            this.listgrp.Text = "Danh sách loại bảo hiểm";
            // 
            // datalistUser
            // 
            this.datalistUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datalistUser.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datalistUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistUser.Location = new System.Drawing.Point(5, 20);
            this.datalistUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datalistUser.Name = "datalistUser";
            this.datalistUser.ReadOnly = true;
            this.datalistUser.RowHeadersWidth = 62;
            this.datalistUser.RowTemplate.Height = 28;
            this.datalistUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistUser.Size = new System.Drawing.Size(885, 330);
            this.datalistUser.TabIndex = 0;
            // 
            // infogrp
            // 
            this.infogrp.Controls.Add(this.limittxt);
            this.infogrp.Controls.Add(this.premiumRatetxt);
            this.infogrp.Controls.Add(this.canclebtn);
            this.infogrp.Controls.Add(this.savebtn);
            this.infogrp.Controls.Add(this.deletebtn);
            this.infogrp.Controls.Add(this.editbtn);
            this.infogrp.Controls.Add(this.label5);
            this.infogrp.Controls.Add(this.label4);
            this.infogrp.Controls.Add(this.label3);
            this.infogrp.Controls.Add(this.deductibletxt);
            this.infogrp.Controls.Add(this.label2);
            this.infogrp.Controls.Add(this.Amounttxt);
            this.infogrp.Controls.Add(this.addbtn);
            this.infogrp.Controls.Add(this.label1);
            this.infogrp.Controls.Add(this.nametypetxt);
            this.infogrp.Location = new System.Drawing.Point(11, 10);
            this.infogrp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infogrp.Name = "infogrp";
            this.infogrp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infogrp.Size = new System.Drawing.Size(896, 190);
            this.infogrp.TabIndex = 2;
            this.infogrp.TabStop = false;
            this.infogrp.Text = "Thông tin";
            // 
            // limittxt
            // 
            this.limittxt.Enabled = false;
            this.limittxt.Location = new System.Drawing.Point(330, 147);
            this.limittxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.limittxt.Name = "limittxt";
            this.limittxt.Size = new System.Drawing.Size(261, 22);
            this.limittxt.TabIndex = 18;
            // 
            // premiumRatetxt
            // 
            this.premiumRatetxt.Enabled = false;
            this.premiumRatetxt.Location = new System.Drawing.Point(330, 99);
            this.premiumRatetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.premiumRatetxt.Name = "premiumRatetxt";
            this.premiumRatetxt.Size = new System.Drawing.Size(261, 22);
            this.premiumRatetxt.TabIndex = 17;
            // 
            // canclebtn
            // 
            this.canclebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.canclebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.canclebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.canclebtn.Location = new System.Drawing.Point(768, 144);
            this.canclebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.canclebtn.Name = "canclebtn";
            this.canclebtn.Size = new System.Drawing.Size(116, 27);
            this.canclebtn.TabIndex = 14;
            this.canclebtn.Text = "Hủy";
            this.canclebtn.UseVisualStyleBackColor = false;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.Green;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.savebtn.Location = new System.Drawing.Point(632, 144);
            this.savebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(116, 27);
            this.savebtn.TabIndex = 13;
            this.savebtn.Text = "Lưu";
            this.savebtn.UseVisualStyleBackColor = false;
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deletebtn.Location = new System.Drawing.Point(808, 96);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(76, 27);
            this.deletebtn.TabIndex = 12;
            this.deletebtn.Text = "Xóa";
            this.deletebtn.UseVisualStyleBackColor = false;
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editbtn.Location = new System.Drawing.Point(719, 96);
            this.editbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(76, 27);
            this.editbtn.TabIndex = 11;
            this.editbtn.Text = "Sửa";
            this.editbtn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hạn mức hợp đồng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tỷ lệ phí bảo hiểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Khấu trừ";
            // 
            // deductibletxt
            // 
            this.deductibletxt.Enabled = false;
            this.deductibletxt.Location = new System.Drawing.Point(21, 147);
            this.deductibletxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deductibletxt.Name = "deductibletxt";
            this.deductibletxt.PasswordChar = '*';
            this.deductibletxt.Size = new System.Drawing.Size(261, 22);
            this.deductibletxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số tiền bảo hiểm";
            // 
            // Amounttxt
            // 
            this.Amounttxt.Enabled = false;
            this.Amounttxt.Location = new System.Drawing.Point(21, 96);
            this.Amounttxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Amounttxt.Name = "Amounttxt";
            this.Amounttxt.Size = new System.Drawing.Size(261, 22);
            this.Amounttxt.TabIndex = 3;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addbtn.Location = new System.Drawing.Point(632, 96);
            this.addbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(76, 27);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "Thêm";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên loại bảo hiểm";
            // 
            // nametypetxt
            // 
            this.nametypetxt.Enabled = false;
            this.nametypetxt.Location = new System.Drawing.Point(21, 46);
            this.nametypetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nametypetxt.Name = "nametypetxt";
            this.nametypetxt.Size = new System.Drawing.Size(261, 22);
            this.nametypetxt.TabIndex = 0;
            // 
            // AdminInsuranceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 568);
            this.Controls.Add(this.listgrp);
            this.Controls.Add(this.infogrp);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminInsuranceType";
            this.Text = "AdminInsuranceType";
            this.listgrp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datalistUser)).EndInit();
            this.infogrp.ResumeLayout(false);
            this.infogrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox listgrp;
        private System.Windows.Forms.DataGridView datalistUser;
        private System.Windows.Forms.GroupBox infogrp;
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