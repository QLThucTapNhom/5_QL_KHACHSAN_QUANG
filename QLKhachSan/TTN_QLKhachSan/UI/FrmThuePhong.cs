using LoginForm_DeMo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QLKhachSan.UI
{
    public partial class FrmThuePhong : Form
    {
        ConnectDatabase database = new ConnectDatabase();
        public FrmThuePhong()
        {
            InitializeComponent();
        }

        private void cbbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = cbbLoaiPhong.SelectedItem.ToString();
            cbbMaPhong.Items.Clear();
            database.loadComboBox(cbbMaPhong, "select p.MaPhong from PHONG p, LOAIPHONG lp where p.TrangThai = N'Trống' and p.MaLoaiPhong = lp.MaLoaiPhong and lp.TenLoaiPhong = N'" + temp + "'");
            database.loadDataGridView(dgvDsPhongTrong, "select p.MaPhong, p.TenPhong, lp.DonGia from PHONG p, LOAIPHONG lp where p.TrangThai = N'Trống' and p.MaLoaiPhong = lp.MaLoaiPhong and lp.TenLoaiPhong = N'" + temp + "'");
        }

        private void FrmThuePhong_Load(object sender, EventArgs e)
        {
            string temp = cbbLoaiPhong.Text.Trim();
            database.loadComboBox(cbbLoaiPhong, "select TenLoaiPhong from LOAIPHONG");
            database.loadComboBox(comboBoxcmt, "select CMND from KHACHHANG");
            database.loadlabel(lbmanv, "select MaNV from TAIKHOAN where TenDangNhap =  N'" + Form1.useracc + "' ");
            database.loadlabel(lbnamenv, "select nv.HoTenNV from NHANVIEN nv, TAIKHOAN tk where nv.MaNV = tk.MaNV and tk.TenDangNhap =  N'" + Form1.useracc + "' ");
        }

        private void btnThuePhong_Click(object sender, EventArgs e)
        {


            try
            {
                string cmnd = comboBoxcmt.Text.Trim();
                string makh = txtMaKH.Text.Trim();
                string phong = cbbMaPhong.Text.Trim();
                string Nthue = dtpNgayThue.Value.ToString();
                string TienDC = txtDatCoc.Text.Trim();
                string manv = lbmanv.Text.Trim();

                if (cmnd.Length != 0 && phong.Length != 0 && TienDC.Length != 0)
                {
                    bool check = database.Check(phong, "select MaPhong from PHONG where TrangThai = N'Trống'");
                    if (check == true)
                    {
                        if (Double.Parse(txtDatCoc.Text) >= 100000)
                        {
                            string insert = "insert into PHIEUTHUEPHONG values ( N'" + makh + "', N'" + manv + "', N'" + phong + "', N'" + Nthue + "', N'" + TienDC + "')";
                            database.ThucThiKetNoi(insert);
                            string up = "update PHONG set TrangThai = N'Thuê' where MaPhong = '" + phong + "'";
                            database.ThucThiKetNoi(up);
                            MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            database.loadDataGridView(dgvThuePhong, "select * from PHIEUTHUEPHONG where MaPhong = N'" + phong + "'");
                        }
                        else
                        {
                            MessageBox.Show("Đặt cọc tối thiếu 100.000!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Phòng đã thuê!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng chọn số CMND của khách hàng và Phòng khách hàng muốn thuê!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
            }
            catch
            {
                MessageBox.Show("Vui lòng điền đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmnd = comboBoxcmt.SelectedItem.ToString().Trim();
            database.loadTextBox(txtTenKh, "select TenKH from KHACHHANG where CMND ='" + cmnd + "'");
            database.loadTextBox(txtMaKH, "select MaKH from KHACHHANG where CMND ='" + cmnd + "'");
            database.loadTextBox(txtSDT, "select SDT from KHACHHANG where CMND ='" + cmnd + "'");
           
        }

        private void dgvThuePhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cbbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtDatCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
