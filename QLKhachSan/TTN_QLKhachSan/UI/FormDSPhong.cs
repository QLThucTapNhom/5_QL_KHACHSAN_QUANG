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
        private void FormDSPhong_Load(object sender, EventArgs e)
        {
            data.loadDataGridView(dgvPhong, "SELECT * FROM PHONG");
            data.loadComboBox(cbbMaPhong, "Select MaPhong From PHONG");
            data.loadComboBox(cbbLoaiPhong, "Select MaLoaiPhong from LoaiPhong");            
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
                        string insert = "INSERT INTO PHONG Values('" + maphong + "',N'" + tenphong + "',N'" + loaiphong + "',N'" + tt + "')";
                        data.ThucThiKetNoi(insert);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Reset();
                        cbbMaPhong.Items.Clear();
                        cbbLoaiPhong.Items.Clear();
                        cbbTrangThai.Items.Clear();
                        data.loadDataGridView(dgvPhong, "SELECT * FROM PHONG");
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
                        string insert = "UPDATE dbo.PHONG SET TenPhong = N'" + tenphong + "', MaLoaiPhong = N'" + loaiphong + "', TrangThai = N'" + tt + "' WHERE MaPhong = '"+ maphong +"' ";
                        data.ThucThiKetNoi(insert);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                        
                        data.loadDataGridView(dgvPhong, "SELECT * FROM PHONG");
                    }
                    else
                    {
                        MessageBox.Show("Phòng ban đã tồn tại, Không thể thêm!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                    DialogResult y = MessageBox.Show("Bạn muốn xóa phòng " + map+ " không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (y == DialogResult.Yes)
                    {
                        string del = "delete from PHONG where MaPhong = N'" + map + "'";
                        data.ThucThiKetNoi(del);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        data.loadDataGridView(dgvPhong, "select * from PHONG");
                        cbbMaPhong.Text = "";
                        txtTenPhong.Text = "";
                        cbbLoaiPhong.Text = "";
                        cbbTrangThai.Text = "";
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
    }
}
