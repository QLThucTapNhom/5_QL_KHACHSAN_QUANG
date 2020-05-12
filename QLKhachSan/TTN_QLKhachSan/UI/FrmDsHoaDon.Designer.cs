namespace TTN_QLKhachSan.UI
{
    partial class FrmDsHoaDon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonyear = new System.Windows.Forms.RadioButton();
            this.radioButtonmonth = new System.Windows.Forms.RadioButton();
            this.radioButtonday = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 376);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hóa Đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(773, 195);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.radioButtonyear);
            this.groupBox2.Controls.Add(this.radioButtonmonth);
            this.groupBox2.Controls.Add(this.radioButtonday);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(17, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 123);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonyear
            // 
            this.radioButtonyear.AutoSize = true;
            this.radioButtonyear.Location = new System.Drawing.Point(645, 78);
            this.radioButtonyear.Name = "radioButtonyear";
            this.radioButtonyear.Size = new System.Drawing.Size(57, 23);
            this.radioButtonyear.TabIndex = 5;
            this.radioButtonyear.TabStop = true;
            this.radioButtonyear.Text = "Năm";
            this.radioButtonyear.UseVisualStyleBackColor = true;
            this.radioButtonyear.CheckedChanged += new System.EventHandler(this.radioButtonyear_CheckedChanged);
            // 
            // radioButtonmonth
            // 
            this.radioButtonmonth.AutoSize = true;
            this.radioButtonmonth.Location = new System.Drawing.Point(429, 80);
            this.radioButtonmonth.Name = "radioButtonmonth";
            this.radioButtonmonth.Size = new System.Drawing.Size(98, 23);
            this.radioButtonmonth.TabIndex = 4;
            this.radioButtonmonth.TabStop = true;
            this.radioButtonmonth.Text = "Tháng/Năm";
            this.radioButtonmonth.UseVisualStyleBackColor = true;
            this.radioButtonmonth.CheckedChanged += new System.EventHandler(this.radioButtonmonth_CheckedChanged);
            // 
            // radioButtonday
            // 
            this.radioButtonday.AutoSize = true;
            this.radioButtonday.Location = new System.Drawing.Point(199, 80);
            this.radioButtonday.Name = "radioButtonday";
            this.radioButtonday.Size = new System.Drawing.Size(135, 23);
            this.radioButtonday.TabIndex = 3;
            this.radioButtonday.TabStop = true;
            this.radioButtonday.Text = "Ngày/Tháng/Năm";
            this.radioButtonday.UseVisualStyleBackColor = true;
            this.radioButtonday.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hiển thị theo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời Gian";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "M/d/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 26);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FrmDsHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 401);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDsHoaDon";
            this.Text = "FrmDsHoaDon";
            this.Load += new System.EventHandler(this.FrmDsHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonyear;
        private System.Windows.Forms.RadioButton radioButtonmonth;
        private System.Windows.Forms.RadioButton radioButtonday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}