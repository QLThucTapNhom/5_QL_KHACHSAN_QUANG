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
    public partial class FormDSPhong : Form
    {
        public FormDSPhong()
        {
            InitializeComponent();
        }
        ConnectDatabase data = new ConnectDatabase();
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void Reset()
        {
            cbbMaPhong.Text = "";
            cbbLoaiPhong.Text = "";
            cbbTrangThai.Text = "";
            txtTenPhong.Text = "";

        }
        public void Loadd()
        {
            data.loadDataGridView(dgvPhong, "SELECT * FROM PHONG");
            cbbMaPhong.Items.Clear();
            data.loadComboBox(cbbMaPhong, "Select MaPhong From PHONG");
            cbbLoaiPhong.Items.Clear();
            data.loadComboBox(cbbLoaiPhong, "Select TenLoaiPhong from LoaiPhong");
        }
        private void FormDSPhong_Load(object sender, EventArgs e)
        {
            Loadd();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maphong = cbbMaPhong.Text;
                string tenphong = txtTenPhong.Text;
                string tt = cbbTrangThai.Text;
                string loaiphong = cbbLoaiPhong.Text;

                if (maphong.Length != 0 && tenphong.Length != 0 && tt.Length != 0 && loaiphong.Length != 0)
                {
                    bool check = data.Check(maphong, "SELECT MaPhong from PHONG");
                    if (check == false)
                    {
                        string insert = "INSERT INTO PHONG(MaPhong,TenPhong,TrangThai) Values('" + maphong + "',N'" + tenphong + "',N'" + tt + "')";
                        data.ThucThiKetNoi(insert);
                        string update = "update PHONG set PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong from LOAIPHONG where LOAIPHONG.TenLoaiPhong = N'" + loaiphong + "' and PHONG.MaPhong = N'" + maphong + "'";
                        data.ThucThiKetNoi(update);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Reset();
                        Loadd();
                    }
                    else
                    {
                        MessageBox.Show("Phòng ban đã tồn tại, Không thể thêm!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                }
                else
                {
                    MessageBox.Show("Bạn cần điền đầy đủ thông tin để hoàn tất!", "Mời bạn nhập lại!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maphong = cbbMaPhong.Text;
                string tenphong = txtTenPhong.Text;
                string tt = cbbTrangThai.Text;
                string loaiphong = cbbLoaiPhong.Text;
                if (maphong != "" && tenphong != "" && tt != "" && loaiphong != "")
                {

                    bool check = data.Check(maphong, "SELECT MaPhong from PHONG");
                    if (check == true)
                    {
                        bool check1 = data.Check(tt, "select TrangThai from PHONG where MaPhong =N'" + maphong +"'");
                        if(check1 == true)
                        {
                            string update = "UPDATE dbo.PHONG SET TenPhong = N'" + tenphong + "', TrangThai = N'" + tt + "' WHERE MaPhong = '" + maphong + "' ";
                            data.ThucThiKetNoi(update);
                            string update1 = "update PHONG set PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong from LOAIPHONG where LOAIPHONG.TenLoaiPhong = N'" + loaiphong + "' and PHONG.MaPhong = N'" + maphong + "'";
                            data.ThucThiKetNoi(update1);
                            MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Loadd();
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa trạng thái Phòng!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Phòng ban đã tồn tại, Không thể sửa!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch
            {
                MessageBox.Show("Lỗi rồi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string map = cbbMaPhong.Text.Trim();
            try
            {
                bool check = data.Check(map, "select MaPhong from PHONG");

                if (check == true)
                {
                    DialogResult y = MessageBox.Show("Bạn muốn xóa phòng " + map + " không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (y == DialogResult.Yes)
                    {
                        string del = "delete from PHONG where MaPhong = N'" + map + "'";
                        data.ThucThiKetNoi(del);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Loadd();
                        Reset();
                    }

                }
                else
                {
                    MessageBox.Show("Phòng không tồn tại !", "Mời bạn kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa! ", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a;
            a = dgvPhong.CurrentRow.Index;
            cbbMaPhong.Text = dgvPhong.Rows[a].Cells[0].Value.ToString();
            txtTenPhong.Text = dgvPhong.Rows[a].Cells[1].Value.ToString();
            cbbLoaiPhong.Text = dgvPhong.Rows[a].Cells[2].Value.ToString();
            cbbTrangThai.Text = dgvPhong.Rows[a].Cells[3].Value.ToString();
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = cbbMaPhong.SelectedItem.ToString();
            data.loadTextBox(txtTenPhong, "select TenPhong from PHONG where MaPhong = N'" + temp + "'");
            bool check = data.Check(temp, "select MaPhong from PHONG");
            if (check == true)
            {
                data.loadComboBox_Show(cbbLoaiPhong, "select LOAIPHONG.TenLoaiPhong from LOAIPHONG, PHONG where LOAIPHONG.MaLoaiPhong=PHONG.MaLoaiPhong and PHONG.MaPhong = N'" + temp + "'");
                data.loadComboBox_Show(cbbTrangThai, "select TrangThai from PHONG where PHONG.MaPhong = N'" + temp + "'");
            }
            else
            {
                Reset();
            }
        }



        private void cbbMaPhong_KeyUp(object sender, KeyEventArgs e)
        {
            txtTenPhong.Text = cbbMaPhong.Text;

        }

        private void cbbMaPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
    }
}
