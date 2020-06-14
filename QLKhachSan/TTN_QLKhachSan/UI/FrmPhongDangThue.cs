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

            string maPhieu = txtMPThuePhong.Text.Trim();
            string maPhong = cbbMaPhong.Text.Trim();
            bool check = database.Check(maPhong, "SELECT MaPhong FROM dbo.PHONG WHERE MaPhong=N'" + maPhong + "' AND TrangThai LIKE N'%Thuê%'");
            if (maPhieu.Length != 0)
            {
                if (check == true)
                {
                    maphieuthuephong = txtMPThuePhong.Text.Trim();
                    FrmThanhToan th = new FrmThanhToan();
                    th.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Phòng đã được thanh toán!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng cần thanh toán!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.loadComboBox(comboBox_tendv, "select TenDV from DICHVU");


        }
        public void Reset()
        {
            textBox_mdv.Text = "";
            comboBox_tendv.Text = "";
            nudSoLuong.Value = 0;
        }

        public void Loaddgvdv()
        {
            string mp = txtMPThuePhong.Text.Trim();
            database.loadDataGridView(dgvDichVu, "select dv.MaDV,  dv.TenDV , sd.SoLuong from DICHVU dv,DICHVU_SD sd  where sd.MaDV =dv.MaDV  and sd.MaPhieu =  N'" + mp + "'");

        }
        private void cbbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = cbbMaPhong.SelectedItem.ToString();
            database.loadTextBox(txtTenPhong, "SELECT TenPhong FROM dbo.PHONG WHERE MaPhong=N'" + temp + "'");
            database.loadTextBox(txtMPThuePhong, " SELECT TOP(1) MaPhieu FROM dbo.PHIEUTHUEPHONG WHERE MaPhong = '" + temp + "' ORDER BY MaPhieu DESC");
           
            string mpt = txtMPThuePhong.Text.Trim();
            database.loadDataGridView(dgvThongTin, "SELECT PH.MaPhieu, KH.TenKH,P.MaPhong, P.TenPhong,PH.NgayNhanPhong, PH.TienDatCoc "
                                                  + "FROM dbo.PHIEUTHUEPHONG PH, dbo.KHACHHANG KH, dbo.PHONG P "
                                                  + "WHERE PH.MaKH = KH.MaKH AND P.MaPhong = PH.MaPhong "
                                                  + "AND PH.MaPhieu = '" + mpt + "'");
            Loaddgvdv();
        }

        private void FrmPhongDangThue_Load(object sender, EventArgs e)
        {
            database.loadComboBox(cbbMaPhong, "select MaPhong from PHONG where TrangThai = N'Thuê'");
            database.loadComboBox(comboBox_tendv, "select TenDV from DICHVU");
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maphieu = txtMPThuePhong.Text.Trim();
                string madv = textBox_mdv.Text.Trim();
                string tendv = comboBox_tendv.Text.Trim();
                string sl = nudSoLuong.Value.ToString();
                if (madv.Length != 0 && maphieu.Length != 0)
                {
                    if (nudSoLuong.Value == 0)
                    {
                        MessageBox.Show("Vui lòng nhập Số lượng để hoàn tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        bool check = database.Check(madv, "select MaDV from DICHVU_SD where MaPhieu = N'" + maphieu + "'");
                        if (check == true)
                        {
                            string upd = "UPDATE dbo.DICHVU_SD SET SoLuong = SoLuong + " + sl + " WHERE MaPhieu = N'" + maphieu + "' AND MaDV='" + madv + "'";
                            database.ThucThiKetNoi(upd);
                            MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Loaddgvdv();
                        }
                        else
                        {
                            string insert = "insert into DICHVU_SD(MaPhieu,MaDV,SoLuong) values (N'" + maphieu + "',N'" + madv + "',N'" + sl + "')";
                            database.ThucThiKetNoi(insert);
                            MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Loaddgvdv();
                        }
                        Reset();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin Phòng và Dịch Vụ!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin Phòng và Dịch Vụ!" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string maphieu = txtMPThuePhong.Text.Trim();
                string madv = textBox_mdv.Text.Trim();
                if (madv.Length != 0 && maphieu.Length != 0)
                {
                    bool check = database.Check(madv, "select MaDV from DICHVU_SD where MaPhieu = N'" + maphieu + "'");
                    if (check == true)
                    {
                        DialogResult h = MessageBox.Show("Bạn có muốn hủy Dịch vụ tại Phòng này không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (h == DialogResult.Yes)
                        {
                            string dele = "delete DICHVU_SD where MaDV = N'" + madv + "' and MaPhieu = N'" + maphieu + "' ";
                            database.ThucThiKetNoi(dele);
                            Loaddgvdv();
                            MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
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

        private void dgvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //   int a;
            //    a = dgvThongTin.CurrentRow.Index;
            //   cbbMaPhong.Text = dgvDichVu.Rows[a].Cells[3].Value.ToString();
            //  txtTenPhong.Text = dgvDichVu.Rows[a].Cells[4].Value.ToString();
            // txtMPThuePhong.Text = dgvDichVu.Rows[a].Cells[1].Value.ToString();
        }

        private void comboBox_tendv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tendv = comboBox_tendv.SelectedItem.ToString();
            string mp = txtMPThuePhong.Text.Trim();
            database.loadTextBox(textBox_mdv, "select MaDV from DICHVU where TenDV = N'" + tendv + "'");
            database.loadnumupdown(nudSoLuong, "select SoLuong from DICHVU_SD where MaPhieu = N'" + mp + "' and MaDV = N'" + textBox_mdv.Text.Trim() + "'"); 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbbMaPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
    }
}
