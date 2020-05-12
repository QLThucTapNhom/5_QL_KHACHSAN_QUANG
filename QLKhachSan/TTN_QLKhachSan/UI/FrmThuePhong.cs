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
            //database.loadComboBox(cbbMaPhong, "select MaPhong from PHONG");

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
                
                if (cmnd.Length != 0)
                {
                        
                    string insert = "insert into PHIEUTHUEPHONG(MaKH, MaPhong, NgayNhanPhong, TienDatCoc) values(N'" + makh + "', N'" + phong + "', N'" + Nthue + "', '"+TienDC+"')";   
                    database.ThucThiKetNoi(insert);    
                    string update = "update PHONG set TrangThai = N'Thuê' where MaPhong = '" + phong + "'";   
                    database.ThucThiKetNoi(update);
                    MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    string query = "SELECT TOP(1) PH.MaPhieu, KH.TenKH, P.MaPhong, P.TenPhong, LP.DonGia, PH.NgayNhanPhong "
                    + "FROM dbo.PHIEUTHUEPHONG PH, dbo.KHACHHANG KH, dbo.PHONG P, dbo.LOAIPHONG LP "
                    + "WHERE KH.MaKH = PH.MaKH AND P.MaPhong = PH.MaPhong AND LP.MaLoaiPhong = P.MaLoaiPhong "
                    + "ORDER BY PH.MaPhieu DESC";
                    database.loadDataGridView(dgvThuePhong, query);

                }                            
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn số CMND của khách hàng!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmnd = comboBoxcmt.SelectedItem.ToString();
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

        
    }
}
