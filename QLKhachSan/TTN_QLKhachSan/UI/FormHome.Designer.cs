namespace TTN_QLKhachSan.UI
{
    partial class FormHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemThuePhong = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPhieuThue = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngĐangĐượcThuêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripTTPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDSPhongDangThue = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemThietBiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDSPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLichSu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemBC = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 46);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::TTN_QLKhachSan.Properties.Resources.icons8_close_window_48;
            this.btnExit.Location = new System.Drawing.Point(799, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 31);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(854, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(27, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = " X";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ KHÁCH SẠN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(1, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 28);
            this.panel2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemUsers,
            this.ToolStripMenuItemThuePhong,
            this.phòngĐangĐượcThuêToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.MenuItemLichSu,
            this.MenuItemHoaDon,
            this.MenuItemBC,
            this.trợGiúpToolStripMenuItem,
            this.MenuItemLogOut});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemUsers
            // 
            this.ToolStripMenuItemUsers.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ToolStripMenuItemUsers.Name = "ToolStripMenuItemUsers";
            this.ToolStripMenuItemUsers.Size = new System.Drawing.Size(47, 20);
            this.ToolStripMenuItemUsers.Text = "Users";
            this.ToolStripMenuItemUsers.Click += new System.EventHandler(this.ToolStripMenuItemUsers_Click);
            // 
            // ToolStripMenuItemThuePhong
            // 
            this.ToolStripMenuItemThuePhong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemKhachHang,
            this.MenuItemPhieuThue});
            this.ToolStripMenuItemThuePhong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ToolStripMenuItemThuePhong.Name = "ToolStripMenuItemThuePhong";
            this.ToolStripMenuItemThuePhong.Size = new System.Drawing.Size(84, 20);
            this.ToolStripMenuItemThuePhong.Text = "Thuê Phòng";
            this.ToolStripMenuItemThuePhong.Click += new System.EventHandler(this.ToolStripMenuItemThuePhong_Click);
            // 
            // MenuItemKhachHang
            // 
            this.MenuItemKhachHang.Name = "MenuItemKhachHang";
            this.MenuItemKhachHang.Size = new System.Drawing.Size(172, 22);
            this.MenuItemKhachHang.Text = "Khách Hàng";
            this.MenuItemKhachHang.Click += new System.EventHandler(this.MenuItemKhachHang_Click);
            // 
            // MenuItemPhieuThue
            // 
            this.MenuItemPhieuThue.Name = "MenuItemPhieuThue";
            this.MenuItemPhieuThue.Size = new System.Drawing.Size(172, 22);
            this.MenuItemPhieuThue.Text = "Phiếu Thuê Phòng";
            this.MenuItemPhieuThue.Click += new System.EventHandler(this.MenuItemPhieuThue_Click);
            // 
            // phòngĐangĐượcThuêToolStripMenuItem
            // 
            this.phòngĐangĐượcThuêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripTTPhong,
            this.MenuItemDSPhongDangThue});
            this.phòngĐangĐượcThuêToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.phòngĐangĐượcThuêToolStripMenuItem.Name = "phòngĐangĐượcThuêToolStripMenuItem";
            this.phòngĐangĐượcThuêToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.phòngĐangĐượcThuêToolStripMenuItem.Text = "Phòng Đang Sử Dụng";
            // 
            // MenuStripTTPhong
            // 
            this.MenuStripTTPhong.Name = "MenuStripTTPhong";
            this.MenuStripTTPhong.Size = new System.Drawing.Size(130, 22);
            this.MenuStripTTPhong.Text = "TT Phòng";
            this.MenuStripTTPhong.Click += new System.EventHandler(this.MenuStripTTPhong_Click);
            // 
            // MenuItemDSPhongDangThue
            // 
            this.MenuItemDSPhongDangThue.Name = "MenuItemDSPhongDangThue";
            this.MenuItemDSPhongDangThue.Size = new System.Drawing.Size(130, 22);
            this.MenuItemDSPhongDangThue.Text = "Danh Sách";
            this.MenuItemDSPhongDangThue.Click += new System.EventHandler(this.MenuItemDSPhongDangThue_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNhanVien,
            this.ToolStripMenuItemDichVu,
            this.MenuItemThietBiPhong,
            this.MenuItemDSPhong});
            this.quảnLýToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // MenuItemNhanVien
            // 
            this.MenuItemNhanVien.Name = "MenuItemNhanVien";
            this.MenuItemNhanVien.Size = new System.Drawing.Size(182, 22);
            this.MenuItemNhanVien.Text = "Nhân Viên";
            this.MenuItemNhanVien.Click += new System.EventHandler(this.MenuItemNhanVien_Click);
            // 
            // ToolStripMenuItemDichVu
            // 
            this.ToolStripMenuItemDichVu.Name = "ToolStripMenuItemDichVu";
            this.ToolStripMenuItemDichVu.Size = new System.Drawing.Size(182, 22);
            this.ToolStripMenuItemDichVu.Text = "Dịch Vụ";
            this.ToolStripMenuItemDichVu.Click += new System.EventHandler(this.ToolStripMenuItemDichVu_Click);
            // 
            // MenuItemThietBiPhong
            // 
            this.MenuItemThietBiPhong.Name = "MenuItemThietBiPhong";
            this.MenuItemThietBiPhong.Size = new System.Drawing.Size(182, 22);
            this.MenuItemThietBiPhong.Text = "Thiết Bị Theo Phòng";
            this.MenuItemThietBiPhong.Click += new System.EventHandler(this.MenuItemThietBiPhong_Click);
            // 
            // MenuItemDSPhong
            // 
            this.MenuItemDSPhong.Name = "MenuItemDSPhong";
            this.MenuItemDSPhong.Size = new System.Drawing.Size(182, 22);
            this.MenuItemDSPhong.Text = "DS Phòng";
            this.MenuItemDSPhong.Click += new System.EventHandler(this.MenuItemDSPhong_Click);
            // 
            // MenuItemLichSu
            // 
            this.MenuItemLichSu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MenuItemLichSu.Name = "MenuItemLichSu";
            this.MenuItemLichSu.Size = new System.Drawing.Size(121, 20);
            this.MenuItemLichSu.Text = "Lịch sử thuê phòng";
            this.MenuItemLichSu.Click += new System.EventHandler(this.MenuItemLichSu_Click);
            // 
            // MenuItemHoaDon
            // 
            this.MenuItemHoaDon.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MenuItemHoaDon.Name = "MenuItemHoaDon";
            this.MenuItemHoaDon.Size = new System.Drawing.Size(83, 20);
            this.MenuItemHoaDon.Text = "DS Hóa Đơn";
            this.MenuItemHoaDon.Click += new System.EventHandler(this.MenuItemHoaDon_Click);
            // 
            // MenuItemBC
            // 
            this.MenuItemBC.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MenuItemBC.Name = "MenuItemBC";
            this.MenuItemBC.Size = new System.Drawing.Size(119, 20);
            this.MenuItemBC.Text = "Báo cáo doanh thu";
            this.MenuItemBC.Click += new System.EventHandler(this.MenuItemBC_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // MenuItemLogOut
            // 
            this.MenuItemLogOut.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MenuItemLogOut.Name = "MenuItemLogOut";
            this.MenuItemLogOut.Size = new System.Drawing.Size(72, 20);
            this.MenuItemLogOut.Text = "Đăng xuất";
            this.MenuItemLogOut.Click += new System.EventHandler(this.MenuItemLogOut_Click);
            // 
            // panelControl
            // 
            this.panelControl.BackgroundImage = global::TTN_QLKhachSan.Properties.Resources.woman_leaning_on_handrail_in_room_1838554;
            this.panelControl.Location = new System.Drawing.Point(1, 72);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(830, 400);
            this.panelControl.TabIndex = 3;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 491);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(850, 530);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUsers;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemThuePhong;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLichSu;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLogOut;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNhanVien;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDichVu;
        private System.Windows.Forms.ToolStripMenuItem phòngĐangĐượcThuêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuStripTTPhong;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDSPhongDangThue;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDSPhong;
        private System.Windows.Forms.ToolStripMenuItem MenuItemThietBiPhong;
        private System.Windows.Forms.ToolStripMenuItem MenuItemBC;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHoaDon;
        private System.Windows.Forms.ToolStripMenuItem MenuItemKhachHang;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPhieuThue;
        private System.Windows.Forms.Button btnExit;
    }
}