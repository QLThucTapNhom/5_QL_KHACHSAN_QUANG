namespace TTN_QLKhachSan.UI
{
    partial class FrmThuePhong
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
            this.dgvThuePhong = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDatCoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxcmt = new System.Windows.Forms.ComboBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThuePhong = new System.Windows.Forms.Button();
            this.cbbMaPhong = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDsPhongTrong = new System.Windows.Forms.DataGridView();
            this.cbbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuePhong)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsPhongTrong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvThuePhong);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvThuePhong
            // 
            this.dgvThuePhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuePhong.Location = new System.Drawing.Point(15, 310);
            this.dgvThuePhong.Name = "dgvThuePhong";
            this.dgvThuePhong.Size = new System.Drawing.Size(778, 87);
            this.dgvThuePhong.TabIndex = 3;
            this.dgvThuePhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuePhong_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpNgayThue);
            this.groupBox3.Controls.Add(this.txtDatCoc);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.comboBoxcmt);
            this.groupBox3.Controls.Add(this.txtMaKH);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnThuePhong);
            this.groupBox3.Controls.Add(this.cbbMaPhong);
            this.groupBox3.Controls.Add(this.txtSDT);
            this.groupBox3.Controls.Add(this.txtTenKh);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(431, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 292);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phiếu Thuê Phòng";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtDatCoc
            // 
            this.txtDatCoc.Location = new System.Drawing.Point(148, 219);
            this.txtDatCoc.Name = "txtDatCoc";
            this.txtDatCoc.Size = new System.Drawing.Size(195, 26);
            this.txtDatCoc.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Đặt Cọc";
            // 
            // comboBoxcmt
            // 
            this.comboBoxcmt.FormattingEnabled = true;
            this.comboBoxcmt.Location = new System.Drawing.Point(148, 25);
            this.comboBoxcmt.Name = "comboBoxcmt";
            this.comboBoxcmt.Size = new System.Drawing.Size(195, 27);
            this.comboBoxcmt.TabIndex = 16;
            this.comboBoxcmt.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(148, 87);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(195, 26);
            this.txtMaKH.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mã KH";
            // 
            // btnThuePhong
            // 
            this.btnThuePhong.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuePhong.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThuePhong.Location = new System.Drawing.Point(20, 249);
            this.btnThuePhong.Name = "btnThuePhong";
            this.btnThuePhong.Size = new System.Drawing.Size(323, 33);
            this.btnThuePhong.TabIndex = 12;
            this.btnThuePhong.Text = "Thuê Phòng";
            this.btnThuePhong.UseVisualStyleBackColor = true;
            this.btnThuePhong.Click += new System.EventHandler(this.btnThuePhong_Click);
            // 
            // cbbMaPhong
            // 
            this.cbbMaPhong.FormattingEnabled = true;
            this.cbbMaPhong.Location = new System.Drawing.Point(148, 152);
            this.cbbMaPhong.Name = "cbbMaPhong";
            this.cbbMaPhong.Size = new System.Drawing.Size(195, 27);
            this.cbbMaPhong.TabIndex = 10;
            this.cbbMaPhong.SelectedIndexChanged += new System.EventHandler(this.cbbMaPhong_SelectedIndexChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(148, 120);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(195, 26);
            this.txtSDT.TabIndex = 9;
            // 
            // txtTenKh
            // 
            this.txtTenKh.Location = new System.Drawing.Point(148, 56);
            this.txtTenKh.Name = "txtTenKh";
            this.txtTenKh.Size = new System.Drawing.Size(195, 26);
            this.txtTenKh.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày Thuê";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "SĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "CMT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên KH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDsPhongTrong);
            this.groupBox2.Controls.Add(this.cbbLoaiPhong);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Phòng Còn Trống";
            // 
            // dgvDsPhongTrong
            // 
            this.dgvDsPhongTrong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsPhongTrong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDsPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsPhongTrong.Location = new System.Drawing.Point(3, 61);
            this.dgvDsPhongTrong.Name = "dgvDsPhongTrong";
            this.dgvDsPhongTrong.Size = new System.Drawing.Size(365, 221);
            this.dgvDsPhongTrong.TabIndex = 0;
            // 
            // cbbLoaiPhong
            // 
            this.cbbLoaiPhong.FormattingEnabled = true;
            this.cbbLoaiPhong.Location = new System.Drawing.Point(215, 23);
            this.cbbLoaiPhong.Name = "cbbLoaiPhong";
            this.cbbLoaiPhong.Size = new System.Drawing.Size(152, 27);
            this.cbbLoaiPhong.TabIndex = 2;
            this.cbbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiPhong_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại Phòng/Người";
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThue.Location = new System.Drawing.Point(148, 187);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(195, 26);
            this.dtpNgayThue.TabIndex = 19;
            // 
            // FrmThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 401);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmThuePhong";
            this.Text = "FrmThuePhong";
            this.Load += new System.EventHandler(this.FrmThuePhong_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuePhong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsPhongTrong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDsPhongTrong;
        private System.Windows.Forms.DataGridView dgvThuePhong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThuePhong;
        private System.Windows.Forms.ComboBox cbbMaPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbLoaiPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxcmt;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKh;
        private System.Windows.Forms.TextBox txtDatCoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayThue;
    }
}