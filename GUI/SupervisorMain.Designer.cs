namespace GUI
{
    partial class SupervisorMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.idcontracttxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.updatertxt = new System.Windows.Forms.TextBox();
            this.ContractNametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DateUpdatedtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdatedContenttxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UpdatedContenttxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DateUpdatedtp);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.idcontracttxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.updatertxt);
            this.groupBox1.Controls.Add(this.ContractNametxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(896, 211);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bảo hiểm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Người cập nhật";
            // 
            // idcontracttxt
            // 
            this.idcontracttxt.Location = new System.Drawing.Point(641, 24);
            this.idcontracttxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idcontracttxt.Name = "idcontracttxt";
            this.idcontracttxt.Size = new System.Drawing.Size(217, 22);
            this.idcontracttxt.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(486, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Mã hợp đồng";
            // 
            // updatertxt
            // 
            this.updatertxt.Location = new System.Drawing.Point(196, 82);
            this.updatertxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updatertxt.Name = "updatertxt";
            this.updatertxt.Size = new System.Drawing.Size(217, 22);
            this.updatertxt.TabIndex = 9;
            this.updatertxt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // ContractNametxt
            // 
            this.ContractNametxt.Location = new System.Drawing.Point(196, 28);
            this.ContractNametxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContractNametxt.Name = "ContractNametxt";
            this.ContractNametxt.Size = new System.Drawing.Size(217, 22);
            this.ContractNametxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hợp đồng bảo hiểm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 236);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(896, 320);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hợp đồng đã tạo ";
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
            this.dataGridView1.Size = new System.Drawing.Size(887, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // DateUpdatedtp
            // 
            this.DateUpdatedtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateUpdatedtp.Location = new System.Drawing.Point(641, 82);
            this.DateUpdatedtp.Name = "DateUpdatedtp";
            this.DateUpdatedtp.Size = new System.Drawing.Size(217, 22);
            this.DateUpdatedtp.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ngày cập nhật";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nội dung cập nhật";
            // 
            // UpdatedContenttxt
            // 
            this.UpdatedContenttxt.Location = new System.Drawing.Point(196, 142);
            this.UpdatedContenttxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdatedContenttxt.Name = "UpdatedContenttxt";
            this.UpdatedContenttxt.Size = new System.Drawing.Size(662, 22);
            this.UpdatedContenttxt.TabIndex = 38;
            // 
            // SupervisorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(917, 567);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SupervisorMain";
            this.Text = "SupervisorMain";
            this.Load += new System.EventHandler(this.SupervisorMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idcontracttxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox updatertxt;
        private System.Windows.Forms.TextBox ContractNametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateUpdatedtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UpdatedContenttxt;
    }
}