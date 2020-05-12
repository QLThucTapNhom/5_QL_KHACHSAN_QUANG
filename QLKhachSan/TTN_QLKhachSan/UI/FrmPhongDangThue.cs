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
        public static string maphieuthuephong;
      
        ConnectDatabase database = new ConnectDatabase();
        public FrmPhongDangThue()
        {
            InitializeComponent();
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            maphieuthuephong = txtMPThuePhong.Text.Trim();
            FrmThanhToan th = new FrmThanhToan();
            th.Show();
        }
        public void Reset()
        {
            cbbMaDV.Text = "";
            txtTenDV.Text = "";
            nudSoLuong.Value = 0;
        }
        private void cbbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = cbbMaPhong.SelectedItem.ToString();
            database.loadTextBox(txtMPThuePhong," SELECT TOP(1) MaPhieu FROM dbo.PHIEUTHUEPHONG WHERE MaPhong = '"+temp+"' ORDER BY MaPhieu DESC");
            string mpt = txtMPThuePhong.Text.Trim();
            database.loadDataGridView(dgvThongTin, "SELECT PH.MaPhieu, KH.TenKH,P.MaPhong, P.TenPhong,PH.NgayNhanPhong, PH.TienDatCoc "
                                                  +"FROM dbo.PHIEUTHUEPHONG PH, dbo.KHACHHANG KH, dbo.PHONG P "
                                                  + "WHERE PH.MaKH = KH.MaKH AND P.MaPhong = PH.MaPhong "
                                                  +"AND PH.MaPhieu = '"+mpt+"'");
            database.loadTextBox(txtTenPhong, "SELECT TenPhong FROM dbo.PHONG WHERE MaPhong=N'"+temp+"'");
            //database.loadDataGridView(dgvThongTin, "select pt.MaPhieu, pt.MaKH,kh.TenKH,p.TenPhong,lp.TenLoaiPhong "
            // + "from PHIEUTHUEPHONG pt,PHONG p,KHACHHANG kh, LOAIPHONG lp " 
            // + "where pt.MaKH = kh.MaKH and pt.MaPhong = p.MaPhong and p.MaLoaiPhong = lp.MaLoaiPhong and p.MaPhong = N'"+ temp +"'");
            database.loadDataGridView(dgvDichVu, "select dv.MaDV,  dv.TenDV , sd.SoLuong from DICHVU dv,DICHVU_SD sd  where sd.MaDV =dv.MaDV  and Maphong = N'" + temp +"'");
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
            //database.loadnumupdown(nudSoLuong, "select SoLuong from DICHVU_SD where MaPhong = N'" + map +"' and MaDV = N'"+ madv +"'");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string phong = cbbMaPhong.Text.Trim();
                string madv = cbbMaDV.Text.Trim();
                string tendv = txtTenDV.Text.Trim();
                string sl = nudSoLuong.Value.ToString();
                if(madv.Length != 0 && phong.Length != 0)
                {
                    bool check = database.Check(madv, "select MaDV from DICHVU_SD where MaPhong = N'" + phong +"'");
                    if (check == true)
                    {
                        //string update = "update DICHVU_SD set SoLuong = N'" + sl +"' where MaDV = N'" + madv +"' and MaPhong = N'" + phong +"'";
                        string upd = "UPDATE dbo.DICHVU_SD SET SoLuong = SoLuong + "+sl+" WHERE MaPhong = N'" + phong + "' AND MaDV='" + madv + "'";
                        database.ThucThiKetNoi(upd);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        database.loadDataGridView(dgvDichVu, "select dv.MaDV, dv.TenDV , sd.SoLuong from DICHVU dv,DICHVU_SD sd  where sd.MaDV = dv.MaDV  and sd.Maphong = N'" + phong + "'");
                    }
                    else
                    {
                        string insert = "insert into DICHVU_SD(MaPhong,MaDV,SoLuong) values (N'"+ phong +"',N'"+madv+"',N'"+sl+"')";
                        database.ThucThiKetNoi(insert);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        database.loadDataGridView(dgvDichVu, "select dv.MaDV, dv.TenDV , sd.SoLuong from DICHVU dv,DICHVU_SD sd  where sd.MaDV = dv.MaDV  and sd.Maphong = N'" + phong + "'");

                    }
                    Reset();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin Phòng và Dịch Vụ!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin Phòng và Dịch Vụ!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string phong = cbbMaPhong.Text.Trim();
                string madv = cbbMaDV.Text.Trim();              
                if (madv.Length != 0 && phong.Length != 0)
                {
                    bool check = database.Check(madv, "select MaDV from DICHVU_SD where MaPhong = N'" + phong + "'");
                    if (check == true)
                    {
                        string dele = "delete DICHVU_SD where MaDV = N'" + madv +"' and MaPhong = N'"+phong+"' ";
                        database.ThucThiKetNoi(dele);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        database.loadDataGridView(dgvDichVu, "select dv.MaDV, dv.TenDV , sd.SoLuong from DICHVU dv,DICHVU_SD sd  where sd.MaDV =dv.MaDV  and sd.Maphong = N'" + phong + "'");

                    }
                    else
                    {
                        MessageBox.Show("Phòng chưa sử dụng dịch vụ này!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    Reset();
                }              
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin Phòng và Dịch Vụ!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin Phòng và Dịch Vụ!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
