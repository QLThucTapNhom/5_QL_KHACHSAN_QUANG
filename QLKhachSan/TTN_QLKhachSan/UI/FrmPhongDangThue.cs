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
    public partial class FrmPhongDangThue : Form
    {
        ConnectDatabase database = new ConnectDatabase();
        public FrmPhongDangThue()
        {
            InitializeComponent();
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            FrmThanhToan th = new FrmThanhToan();
            th.Show();
        }

        private void cbbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = cbbMaPhong.SelectedItem.ToString();
            database.loadDataGridView(dgvThongTin, "select pt.MaPhieu, pt.MaKH,kh.TenKH,p.TenPhong,lp.TenLoaiPhong "
                                                    + "from PHIEUTHUEPHONG pt,PHONG p,KHACHHANG kh, LOAIPHONG lp " 
                                                    + "where pt.MaKH = kh.MaKH and pt.MaPhong = p.MaPhong and p.MaLoaiPhong = lp.MaLoaiPhong and p.MaPhong = N'"+ temp +"'");
            database.loadDataGridView(dgvDichVu, "select  dv.TenDV , sd.SoLuong from DICHVU dv,DICHVU_SD sd  where sd.MaPhong = N'P01' and sd.MaDV =dv.MaDV  and Maphong = N'" + temp +"'");
        }

        private void FrmPhongDangThue_Load(object sender, EventArgs e)
        {
            database.loadComboBox(cbbMaPhong, "select MaPhong from PHONG where TrangThai = N'Thuê'");
            database.loadComboBox(cbbMaDV, "select MaDV from DICHVU");
        }

        private void cbbMaDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string madv = cbbMaDV.SelectedItem.ToString();
            string map = cbbMaPhong.SelectedItem.ToString();
            database.loadTextBox(txtTenDV, "select TenDV from DICHVU where MaDV = N'" + madv + "'");
            nudSoLuong.Value = 0;
            database.loadnumupdown(nudSoLuong, "select SoLuong from DICHVU_SD where MaPhong = N'" + map +"' and MaDV = N'"+ madv +"'");
        }
    }
}
