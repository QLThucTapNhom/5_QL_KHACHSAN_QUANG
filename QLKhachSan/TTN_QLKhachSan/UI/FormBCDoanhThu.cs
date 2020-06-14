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
    public partial class FormBCDoanhThu : Form
    {
        ConnectDatabase database = new ConnectDatabase();
        public FormBCDoanhThu()
        {
            InitializeComponent();
        }

        public void BCngay()
        {
            string day = dateTimePicker1.Value.Day.ToString();
            string month = dateTimePicker1.Value.Month.ToString();
            string year = dateTimePicker1.Value.Year.ToString();
                //
            database.loadlabel(lbslhd, "select count(MaHD) from HOADON where day(NgayLap) = N'" + day + "' and month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "'");
            database.loadlabel(lbdthu, "select SUM(TongTien) from HOADON where day(NgayLap) = N'" + day + "' and month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "'");
            database.loadlabel(lbtiendv, "select SUM(TienDV) from HOADON where day(NgayLap) = N'" + day + "' and month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "'");
            database.loadlabel(lbtienphong, "select SUM(TienPhong) from HOADON where day(NgayLap) = N'" + day + "' and month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "'");
            database.loadDataGridView(dgvdv, "select sd.MaDV, dv.TenDV , sum(sd.SoLuong) as N'Tổng', sum( sd.SoLuong * dv.GiaDV) as N'Thành Tiền' "
                                            + " from DICHVU dv, DICHVU_SD sd , PHIEUTHUEPHONG pt , HOADON hd  "
                                            + "where sd.MaDV = dv.MaDV  and sd.MaPhieu = pt.MaPhieu and pt.MaPhieu = hd.MaPhieu "
                                            + " and day(NgayLap) = N'" + day + "' and month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "' "
                                            + " group by dv.TenDV,sd.MaDV order by  sum(sd.SoLuong) desc");
            database.loadDataGridView(dgvphong, "select pt.MaPhong, p.TenPhong, COUNT(pt.MaPhieu) as N' Số lần được thuê' , sum(hd.TienPhong) as N'Thành Tiền' "
                                            + "from LOAIPHONG lp, PHONG p, PHIEUTHUEPHONG pt, HOADON hd  " 
                                            + "where lp.MaLoaiPhong = p.MaLoaiPhong and p.MaPhong = pt.MaPhong and pt.MaPhieu = hd.MaPhieu " 
                                            + "and  day(NgayLap) = N'" + day + "' and month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "' " 
                                            + " group by pt.MaPhong, p.TenPhong order by COUNT(pt.MaPhieu) desc");

            //
            if (lbdthu.Text == "")
                {
                    lbdthu.Text = "0";
                    lbtienphong.Text = "0";
                    lbtiendv.Text = "0";
                }
        }

        public void BCThang()
        {
            string day = dateTimePicker1.Value.Day.ToString();
            string month = dateTimePicker1.Value.Month.ToString();
            string year = dateTimePicker1.Value.Year.ToString();
            //
            database.loadlabel(lbslhd, "select count(MaHD) from HOADON where month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "'");
            database.loadlabel(lbdthu, "select SUM(TongTien) from HOADON where month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "'");
            database.loadlabel(lbtiendv, "select SUM(TienDV) from HOADON where month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "'");
            database.loadlabel(lbtienphong, "select SUM(TienPhong) from HOADON where month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "'");
            database.loadDataGridView(dgvdv, "select sd.MaDV, dv.TenDV , sum(sd.SoLuong) as N'Tổng', sum( sd.SoLuong * dv.GiaDV) as N'Thành Tiền' "
                                            + " from DICHVU dv, DICHVU_SD sd , PHIEUTHUEPHONG pt , HOADON hd  "
                                            + "where sd.MaDV = dv.MaDV  and sd.MaPhieu = pt.MaPhieu and pt.MaPhieu = hd.MaPhieu "
                                            + " and month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "' "
                                            + " group by dv.TenDV,sd.MaDV order by  sum(sd.SoLuong) desc");
            database.loadDataGridView(dgvphong, "select pt.MaPhong, p.TenPhong, COUNT(pt.MaPhieu) as N' Số lần được thuê' , sum(hd.TienPhong) as N'Thành Tiền' "
                                            + "from LOAIPHONG lp, PHONG p, PHIEUTHUEPHONG pt, HOADON hd  "
                                            + "where lp.MaLoaiPhong = p.MaLoaiPhong and p.MaPhong = pt.MaPhong and pt.MaPhieu = hd.MaPhieu "
                                            + "and month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "' "
                                            + " group by pt.MaPhong, p.TenPhong order by COUNT(pt.MaPhieu) desc");
            //
            if (lbdthu.Text == "")
            {
                lbdthu.Text = "0";
                lbtienphong.Text = "0";
                lbtiendv.Text = "0";
            }
        }

        public void BCNam()
        {
            string day = dateTimePicker1.Value.Day.ToString();
            string month = dateTimePicker1.Value.Month.ToString();
            string year = dateTimePicker1.Value.Year.ToString();
            //
            database.loadlabel(lbslhd, "select count(MaHD) from HOADON where  year(NgayLap) = N'" + year + "'");
            database.loadlabel(lbdthu, "select SUM(TongTien) from HOADON where year(NgayLap) = N'" + year + "'");
            database.loadlabel(lbtiendv, "select SUM(TienDV) from HOADON where year(NgayLap) = N'" + year + "'");
            database.loadlabel(lbtienphong, "select SUM(TienPhong) from HOADON where year(NgayLap) = N'" + year + "'");
            database.loadDataGridView(dgvdv, "select sd.MaDV, dv.TenDV , sum(sd.SoLuong) as N'Tổng', sum( sd.SoLuong * dv.GiaDV) as N'Thành Tiền' "
                                            + " from DICHVU dv, DICHVU_SD sd , PHIEUTHUEPHONG pt , HOADON hd  "
                                            + "where sd.MaDV = dv.MaDV  and sd.MaPhieu = pt.MaPhieu and pt.MaPhieu = hd.MaPhieu "
                                            + "and year(NgayLap) = N'" + year + "' "
                                            + " group by dv.TenDV,sd.MaDV order by  sum(sd.SoLuong) desc");
            database.loadDataGridView(dgvphong, "select pt.MaPhong, p.TenPhong, COUNT(pt.MaPhieu) as N' Số lần được thuê' , sum(hd.TienPhong) as N'Thành Tiền' "
                                            + "from LOAIPHONG lp, PHONG p, PHIEUTHUEPHONG pt, HOADON hd  "
                                            + "where lp.MaLoaiPhong = p.MaLoaiPhong and p.MaPhong = pt.MaPhong and pt.MaPhieu = hd.MaPhieu "
                                            + "and year(NgayLap) = N'" + year + "' "
                                            + " group by pt.MaPhong, p.TenPhong order by COUNT(pt.MaPhieu) desc");
            //
            if (lbdthu.Text == "")
            {
                lbdthu.Text = "0";
                lbtienphong.Text = "0";
                lbtiendv.Text = "0";
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            if (radioButtonday.Checked)
            {
                BCngay();
            }
            if (radioButtonmonth.Checked)
            {
                BCThang();
            }
            if (radioButtonyear.Checked)
            {
                BCNam();
            }
        }

        private void radioButtonday_CheckedChanged(object sender, EventArgs e)
        {
            BCngay();
        }

        private void radioButtonmonth_CheckedChanged(object sender, EventArgs e)
        {
            BCThang();
        }

        private void radioButtonyear_CheckedChanged(object sender, EventArgs e)
        {
            BCNam();
        }

        private void lbslhd_Click(object sender, EventArgs e)
        {

        }

        private void FormBCDoanhThu_Load(object sender, EventArgs e)
        {
            lbdthu.Text = lbslhd.Text = "0";
            radioButtonday.Checked = true;
        }
    }
}
