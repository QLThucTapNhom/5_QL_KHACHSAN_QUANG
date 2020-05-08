namespace TTN_QLKhachSan.UI
{
    partial class FrmKhachHang
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
            this.showma = new System.Windows.Forms.Label();
            this.MAKH = new System.Windows.Forms.Label();
            this.dgvkh = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbbtkcmnd = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonds = new System.Windows.Forms.Button();
            this.buttonsua = new System.Windows.Forms.Button();
            this.buttonthem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbcmnd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showma);
            this.groupBox1.Controls.Add(this.MAKH);
            this.groupBox1.Controls.Add(this.dgvkh);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 393);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý thông tin khách hàng";
            // 
            // showma
            // 
            this.showma.AutoSize = true;
            this.showma.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.showma.Location = new System.Drawing.Point(409, 94);
            this.showma.Name = "showma";
            this.showma.Size = new System.Drawing.Size(0, 19);
            this.showma.TabIndex = 5;
            // 
            // MAKH
            // 
            this.MAKH.AutoSize = true;
            this.MAKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MAKH.Location = new System.Drawing.Point(341, 94);
            this.MAKH.Name = "MAKH";
            this.MAKH.Size = new System.Drawing.Size(0, 19);
            this.MAKH.TabIndex = 4;
            // 
            // dgvkh
            // 
            this.dgvkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkh.Location = new System.Drawing.Point(11, 264);
            this.dgvkh.Name = "dgvkh";
            this.dgvkh.Size = new System.Drawing.Size(785, 112);
            this.dgvkh.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbbtkcmnd);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(11, 182);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(785, 75);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // cbbtkcmnd
            // 
            this.cbbtkcmnd.FormattingEnabled = true;
            this.cbbtkcmnd.Location = new System.Drawing.Point(113, 29);
            this.cbbtkcmnd.Name = "cbbtkcmnd";
            this.cbbtkcmnd.Size = new System.Drawing.Size(492, 27);
            this.cbbtkcmnd.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button5.Location = new System.Drawing.Point(640, 27);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 30);
            this.button5.TabIndex = 6;
            this.button5.Text = "Tìm Kiếm";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "CMND";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonxoa);
            this.groupBox3.Controls.Add(this.buttonds);
            this.groupBox3.Controls.Add(this.buttonsua);
            this.groupBox3.Controls.Add(this.buttonthem);
            this.groupBox3.Location = new System.Drawing.Point(11, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(785, 75);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // buttonxoa
            // 
            this.buttonxoa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonxoa.Location = new System.Drawing.Point(536, 25);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(92, 30);
            this.buttonxoa.TabIndex = 3;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = true;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // buttonds
            // 
            this.buttonds.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonds.Location = new System.Drawing.Point(384, 25);
            this.buttonds.Name = "buttonds";
            this.buttonds.Size = new System.Drawing.Size(92, 30);
            this.buttonds.TabIndex = 2;
            this.buttonds.Text = "Danh Sách";
            this.buttonds.UseVisualStyleBackColor = true;
            this.buttonds.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonsua
            // 
            this.buttonsua.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonsua.Location = new System.Drawing.Point(235, 25);
            this.buttonsua.Name = "buttonsua";
            this.buttonsua.Size = new System.Drawing.Size(92, 30);
            this.buttonsua.TabIndex = 1;
            this.buttonsua.Text = "Sửa";
            this.buttonsua.UseVisualStyleBackColor = true;
            this.buttonsua.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonthem
            // 
            this.buttonthem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonthem.Location = new System.Drawing.Point(91, 26);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(92, 30);
            this.buttonthem.TabIndex = 0;
            this.buttonthem.Text = "Thêm";
            this.buttonthem.UseVisualStyleBackColor = true;
            this.buttonthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbcmnd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtsdt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtten);
            this.groupBox2.Location = new System.Drawing.Point(11, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 64);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // cbbcmnd
            // 
            this.cbbcmnd.FormattingEnabled = true;
            this.cbbcmnd.Location = new System.Drawing.Point(347, 23);
            this.cbbcmnd.Name = "cbbcmnd";
            this.cbbcmnd.Size = new System.Drawing.Size(157, 27);
            this.cbbcmnd.TabIndex = 6;
            this.cbbcmnd.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "SĐT";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(593, 24);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(159, 26);
            this.txtsdt.TabIndex = 4;
            this.txtsdt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "CMND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ Tên";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(91, 24);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(159, 26);
            this.txtten.TabIndex = 0;
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 401);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmKhachHang";
            this.Text = "FrmKhachHang";
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Button buttonds;
        private System.Windows.Forms.Button buttonsua;
        private System.Windows.Forms.Button buttonthem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.DataGridView dgvkh;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbcmnd;
        private System.Windows.Forms.ComboBox cbbtkcmnd;
        private System.Windows.Forms.Label showma;
        private System.Windows.Forms.Label MAKH;
    }
}