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
    public partial class FrmThietBiTheoPhong : Form
    {
        ConnectDatabase database = new ConnectDatabase();
        public FrmThietBiTheoPhong()
        {
            InitializeComponent();
        }
        private void ResetSD()
        {
            cbbMaTB.Text = "";
            txtTenTB.Clear();
            cbbTTtb.Text = "";
            nudsl.Value = 0;
        }
        private void FrmThietBi_Load(object sender, EventArgs e)
        {
            database.loadComboBox(cbbMaPhong, "select MaPhong from PHONG");
            database.loadComboBox(cbbMaTB, "select MaTB from THIETBI");
        }

        private void cbbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = cbbMaPhong.SelectedItem.ToString();
            database.loadDataGridView(dgvThongTin, "SELECT P.MaPhong, P.TenPhong,L.MaLoaiPhong, L.TenLoaiPhong, L.DonGia, L.SoNgToiDa FROM dbo.PHONG P, dbo.LOAIPHONG L "
            +" WHERE L.MaLoaiPhong = P.MaLoaiPhong AND P.MaPhong = N'" + temp + "'");
            database.loadDataGridView(dgvDichVu, "select  sd.MaTB, tb.TenTB, sd.SoLuong from THIETBI_SD sd, THIETBI tb where sd.MaTB =tb.MaTB and sd.MaPhong = N'" + temp + "'");
        }

        private void cbbMaDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string matb = cbbMaTB.SelectedItem.ToString();
            string maphong = cbbMaPhong.Text.Trim();
            database.loadTextBox(txtTenTB, "Select TenTB from THIETBI where MaTB = N'" + matb + "'");
            database.loadnumupdown(nudsl, "select SoLuong from THIETBI_SD where MaPhong = N'" + maphong + "' and MaTB = N'" + matb + "'");
            database.loadComboBox_Show(cbbTTtb, "select TrangThai from THIETBI_SD where MaPhong = N'" + maphong +"' and MaTB = N'"+ matb +"'");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maphong = cbbMaPhong.Text.Trim();
                string matb = cbbMaTB.Text.Trim();
                string tentb = txtTenTB.Text.Trim();
                string sl = nudsl.Value.ToString();
                string tt = cbbTTtb.Text.Trim();
                if(maphong.Length != 0 && matb.Length != 0 && tentb.Length != 0 && tt.Length != 0)
                {
                    bool check = database.Check(matb, "select MaTB from THIETBI_SD where MaPhong = N'" + maphong + "'");
                    if (check == true)
                     {
                        string update = "update THIETBI_SD set SoLuong = SoLuong + N'"+sl+"',TrangThai =N'"+tt+"' where MaPhong =N'"+maphong+"' and MaTB = N'"+matb+"'";
                        database.ThucThiKetNoi(update);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        database.loadDataGridView(dgvDichVu, "select  sd.MaTB, tb.TenTB, sd.SoLuong from THIETBI_SD sd, THIETBI tb where sd.MaTB =tb.MaTB and sd.MaPhong = N'" + maphong + "'");
                        ResetSD();
                    }
                    else
                    {
                        string insert = "INSERT INTO dbo.THIETBI_SD ( MaPhong, MaTB, SoLuong, TrangThai ) "
                         +"VALUES(N'"+maphong+"', N'"+matb+"', '"+sl+"', N'"+tt+"')";
                        database.ThucThiKetNoi(insert);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        database.loadDataGridView(dgvDichVu, "select  sd.MaTB, tb.TenTB, sd.SoLuong from THIETBI_SD sd, THIETBI tb where sd.MaTB =tb.MaTB and sd.MaPhong = N'" + maphong + "'");
                        ResetSD();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin Phòng và Thiết Bị!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch
            {               
                    MessageBox.Show("Đã xảy ra lỗi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);             
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string phong = cbbMaPhong.Text.Trim();
                string matb = cbbMaTB.Text.Trim();
                if (matb.Length != 0 && phong.Length != 0)
                {
                    bool check = database.Check(matb, "select MaTB from THIETBI_SD where MaPhong = N'" + phong + "'");
                    if (check == true)
                    {
                        DialogResult h = MessageBox.Show("Bạn có muốn xóa Thiết bị ở Phòng này không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (h == DialogResult.Yes)
                        {
                            string dele = "delete THIETBI_SD where MaTB = N'" + matb + "' and MaPhong = N'" + phong + "' ";
                            database.ThucThiKetNoi(dele);
                            MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            database.loadDataGridView(dgvDichVu, "select  sd.MaTB, tb.TenTB, sd.SoLuong from THIETBI_SD sd, THIETBI tb where sd.MaTB =tb.MaTB and sd.MaPhong = N'" + phong + "'");
                            ResetSD();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phòng chưa có thiết bị này!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        ResetSD();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin Phòng và Thiết bị!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin Phòng và Dịch Vụ!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
