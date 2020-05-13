using LoginForm_DeMo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QLKhachSan.UI
{
    public partial class FrmThanhToan : Form
    {
        
        public FrmThanhToan()
        {
            InitializeComponent();
        }
        FrmPhongDangThue frm = new FrmPhongDangThue();
        ConnectDatabase db = new ConnectDatabase();
        public string mptp = FrmPhongDangThue.maphieuthuephong;
        public void ThanhToan()
        {
            db.loadTextBox(txtTenKH, "SELECT K.TenKH FROM dbo.KHACHHANG K, dbo.PHIEUTHUEPHONG P WHERE K.MaKH = P.MaKH AND P.MaPhieu=N'" + mptp + "'");
            db.loadTextBox(txtCNMD, "SELECT K.CMND FROM dbo.KHACHHANG K, dbo.PHIEUTHUEPHONG P WHERE K.MaKH = P.MaKH AND P.MaPhieu=N'" + mptp + "'");
            db.loadTextBox(txtMaKH, "select makh from dbo.PHIEUTHUEPHONG where MaPhieu=N'"+mptp+"' ");
            
            txtMaPhieu.Text = mptp;
            db.loadTextBox(txtMaPhong, "SELECT PH.MaPhong FROM dbo.PHIEUTHUEPHONG PH WHERE PH.MaPhieu = N'" + mptp+"'");

            db.loadTextBox(txtDonGia, "SELECT L.DonGia FROM dbo.PHIEUTHUEPHONG PH, dbo.PHONG P, dbo.LOAIPHONG L "
                 + "WHERE P.MaPhong = PH.MaPhong AND L.MaLoaiPhong = P.MaLoaiPhong AND PH.MaPhieu = N'" + mptp + "'");

            db.loadDateTime(dtpNgayThue, "SELECT NgayNhanPhong FROM dbo.PHIEUTHUEPHONG WHERE MaPhieu=N'"+mptp+"'");

            //Tính số ngày thuê phòng
            DateTime today = DateTime.Now;
            DateTime ngaythue = dtpNgayThue.Value;
            TimeSpan count = today.Subtract(ngaythue);

            txtSoNgayThue.Text = (count.Days+1).ToString();
            ///
            //Tiền phòng
            string songay = txtSoNgayThue.Text.Trim();
            string dongia = txtDonGia.Text.Trim();

            double tienphong = Int32.Parse(songay) * double.Parse(dongia);
            txtTienPhong.Text =tienphong.ToString();
            // Tiền dịch vụ
            db.loadTextBox(txtTienDV, "SELECT SUM(SD.SoLuong * DV.GiaDV) FROM dbo.DICHVU DV, dbo.DICHVU_SD SD "
             + "WHERE DV.MaDV = SD.MaDV and SD.MaPhong = N'"+txtMaPhong.Text.Trim()+"' GROUP BY SD.MaPhong");
            //chi tiết sử dụng dịch vụ

            db.loadDataGridView(dgvDichVu, "SELECT DV.MaDV, DV.TenDV, DV.GiaDV, SD.SoLuong FROM dbo.DICHVU DV, dbo.DICHVU_SD SD"
                          + " WHERE DV.MaDV = SD.MaDV and SD.MaPhong = N'" + txtMaPhong.Text.Trim() + "'");
            // Tiền đặt cọc
            db.loadTextBox(txtTienCoc, "SELECT TienDatCoc FROM dbo.PHIEUTHUEPHONG WHERE MaPhieu=N'" + txtMaPhieu.Text.Trim() + "'");
            //Tổng Tiền
            double tp = double.Parse(txtTienPhong.Text.Trim());
            double tiendv;
            double tiencoc;
            double conlai;
            try
            {
                tiendv = double.Parse(txtTienDV.Text.Trim());
                tiencoc = double.Parse(txtTienCoc.Text.Trim());

            }
            catch
            {
                tiendv = 0;
                tiencoc = 0;
            }
            double tongtien = tiendv + tp;
            conlai = tongtien - tiencoc;
            txtTongTien.Text = tongtien.ToString();
            txtConLai.Text = conlai.ToString();
        }
        private void FrmThanhToan_Load(object sender, EventArgs e)
        {
            ThanhToan();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                //Thêm hóa đơn vào bảng hóa đơn

                string maKH = txtMaKH.Text.Trim();
                string maPhong = txtMaPhong.Text.Trim();
                //string ngayLap = dtpNgayTra.Value.ToString();
                string ngayThue = dtpNgayThue.Value.ToString();
                string ngayTra = dtpNgayTra.Value.ToString();
                string tienPhong = txtTienPhong.Text.Trim();
                string tienDV = txtTienDV.Text.Trim();
                string tongTien = txtTongTien.Text.Trim();
                string insert = "insert into dbo.hoadon ( MaKH ,MaPhong  ,NgayLap ,NgayNhan ,NgayTra ,TienPhong ,TienDV ,TongTien) "
                + "values('" + maKH + "' , N'" + maPhong + "' ,  GETDATE() , '" + ngayThue + "' , '" + ngayTra + "' , '" + tienPhong + "' , '" + tienDV + "' , '" + tongTien + "')";
                db.ThucThiKetNoi(insert);

                //Trả phòng
                ////Thiết lập trạng thái phòng về trống
                string update = "UPDATE dbo.PHONG SET TrangThai=N'Trống' WHERE MaPhong=N'" + txtMaPhong.Text.Trim() + "'";
                db.ThucThiKetNoi(update);
                string del = "DELETE FROM dbo.DICHVU_SD WHERE MaPhong=N'" + txtMaPhong.Text.Trim() + "'";
                db.ThucThiKetNoi(del);
                MessageBox.Show("Thanh Toán Hoàn Tất!");
                this.Close();
                
            }
            catch
            {
                MessageBox.Show("Lỗi Hệ Thống!");
            }
            
        }

        private void txtTienKhachTra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double conlai = double.Parse(txtConLai.Text.Trim());
                double tienkhachtra;
                try
                {
                    tienkhachtra = double.Parse(txtTienKhachTra.Text.Trim());
                    double tientrakhach = tienkhachtra - conlai;
                    txtTienTraLai.Text = tientrakhach.ToString();
                }
                catch
                {
                    tienkhachtra = 0;
                }
                
            }
            catch
            {

            }
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
