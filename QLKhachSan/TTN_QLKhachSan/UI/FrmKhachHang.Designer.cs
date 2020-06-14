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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonSDT = new System.Windows.Forms.RadioButton();
            this.radioButtonCMND = new System.Windows.Forms.RadioButton();
            this.radioButtonTen = new System.Windows.Forms.RadioButton();
            this.textBox_timkiem = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLs = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonds = new System.Windows.Forms.Button();
            this.buttonsua = new System.Windows.Forms.Button();
            this.buttonthem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbCmnd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showma);
            this.groupBox1.Controls.Add(this.MAKH);
            this.groupBox1.Controls.Add(this.dgv);
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
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(11, 264);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(785, 123);
            this.dgv.TabIndex = 3;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkh_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkh_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonSDT);
            this.groupBox4.Controls.Add(this.radioButtonCMND);
            this.groupBox4.Controls.Add(this.radioButtonTen);
            this.groupBox4.Controls.Add(this.textBox_timkiem);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(11, 182);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(785, 75);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // radioButtonSDT
            // 
            this.radioButtonSDT.AutoSize = true;
            this.radioButtonSDT.Location = new System.Drawing.Point(562, 30);
            this.radioButtonSDT.Name = "radioButtonSDT";
            this.radioButtonSDT.Size = new System.Drawing.Size(56, 23);
            this.radioButtonSDT.TabIndex = 11;
            this.radioButtonSDT.Text = "SDT";
            this.radioButtonSDT.UseVisualStyleBackColor = true;
            // 
            // radioButtonCMND
            // 
            this.radioButtonCMND.AutoSize = true;
            this.radioButtonCMND.Location = new System.Drawing.Point(478, 30);
            this.radioButtonCMND.Name = "radioButtonCMND";
            this.radioButtonCMND.Size = new System.Drawing.Size(75, 23);
            this.radioButtonCMND.TabIndex = 10;
            this.radioButtonCMND.Text = "CMND";
            this.radioButtonCMND.UseVisualStyleBackColor = true;
            // 
            // radioButtonTen
            // 
            this.radioButtonTen.AutoSize = true;
            this.radioButtonTen.Checked = true;
            this.radioButtonTen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonTen.Location = new System.Drawing.Point(412, 31);
            this.radioButtonTen.Name = "radioButtonTen";
            this.radioButtonTen.Size = new System.Drawing.Size(50, 23);
            this.radioButtonTen.TabIndex = 9;
            this.radioButtonTen.TabStop = true;
            this.radioButtonTen.Text = "Tên";
            this.radioButtonTen.UseVisualStyleBackColor = true;
            // 
            // textBox_timkiem
            // 
            this.textBox_timkiem.Location = new System.Drawing.Point(113, 27);
            this.textBox_timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_timkiem.Name = "textBox_timkiem";
            this.textBox_timkiem.Size = new System.Drawing.Size(285, 26);
            this.textBox_timkiem.TabIndex = 8;
            this.textBox_timkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_timkiem_KeyDown);
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
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "SEARCH";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLs);
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
            // btnLs
            // 
            this.btnLs.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLs.Location = new System.Drawing.Point(648, 25);
            this.btnLs.Name = "btnLs";
            this.btnLs.Size = new System.Drawing.Size(92, 30);
            this.btnLs.TabIndex = 4;
            this.btnLs.Text = "Lịch sử KH";
            this.btnLs.UseVisualStyleBackColor = true;
            this.btnLs.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // buttonxoa
            // 
            this.buttonxoa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonxoa.Location = new System.Drawing.Point(346, 24);
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
            this.buttonds.Location = new System.Drawing.Point(497, 24);
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
            this.buttonsua.Location = new System.Drawing.Point(194, 24);
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
            this.buttonthem.Location = new System.Drawing.Point(42, 25);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(92, 30);
            this.buttonthem.TabIndex = 0;
            this.buttonthem.Text = "Thêm";
            this.buttonthem.UseVisualStyleBackColor = true;
            this.buttonthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbCmnd);
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
            // cbbCmnd
            // 
            this.cbbCmnd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbCmnd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCmnd.FormattingEnabled = true;
            this.cbbCmnd.Location = new System.Drawing.Point(347, 23);
            this.cbbCmnd.MaxLength = 12;
            this.cbbCmnd.Name = "cbbCmnd";
            this.cbbCmnd.Size = new System.Drawing.Size(157, 27);
            this.cbbCmnd.TabIndex = 6;
            this.cbbCmnd.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbbCmnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbcmnd_KeyPress);
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
            this.txtsdt.MaxLength = 12;
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(159, 26);
            this.txtsdt.TabIndex = 4;
            this.txtsdt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbCmnd;
        private System.Windows.Forms.Label showma;
        private System.Windows.Forms.Label MAKH;
        private System.Windows.Forms.Button btnLs;
        private System.Windows.Forms.TextBox textBox_timkiem;
        private System.Windows.Forms.RadioButton radioButtonSDT;
        private System.Windows.Forms.RadioButton radioButtonCMND;
        private System.Windows.Forms.RadioButton radioButtonTen;
    }
}