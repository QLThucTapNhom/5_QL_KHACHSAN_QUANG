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
    public partial class QLNguoiDung : Form
    {
        ConnectDatabase database = new ConnectDatabase();
        public QLNguoiDung()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            txttendn.Text = "";
            txtpass.Text = "";
            comboBoxquyen.Text = "";
        }

        private void cbbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = cbbMaNV.SelectedItem.ToString();
            database.loadTextBox(txtTenNV, "select HoTenNV from NHANVIEN where MaNV = N'" + temp + "'");
            bool check = database.Check(temp, "select MaNV from TAIKHOAN");
            if (check == true)
            {
                database.loadTextBox(txttendn, "select TenDangNhap from TAIKHOAN where MaNV = N'" + temp + "'");
                database.loadTextBox(txtpass, "select MatKhau from TAIKHOAN where MaNV = N'" + temp + "'");
                database.loadComboBox_Show(comboBoxquyen, "select q.TenQuyen from QUYEN q, TAIKHOAN tk where q.MaQuyen=tk.MaQuyen and tk.MaNV = N'" + temp + "'");
            }
            else
            {
                Reset();

            }

        }

        private void QLNguoiDung_Load(object sender, EventArgs e)
        {
            database.loadComboBox(cbbMaNV, "Select MaNV from NHANVIEN");
            database.loadDataGridView(dataGridView1, "select * from TAIKHOAN");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string manv = cbbMaNV.Text.Trim();
               // string tennv = txtTenNV.Text.Trim();
                string tk = txttendn.Text.Trim();
                string pass = txtpass.Text.Trim();
                string loai = comboBoxquyen.Text.Trim();
                if(loai == "Quản Lý")
                {
                    loai = "1";
                }
                else
                {
                    loai = "2";
                }

                if (manv.Length != 0 && tk.Length != 0 && pass.Length != 0 && loai.Length != 0)
                {
                    bool check = database.Check(manv, "select MaNV from TAIKHOAN");
                    if (check == false)
                    {
                        string insert = "insert into TAIKHOAN(TenDangNhap,MatKhau,MaQuyen,MaNV) values (N'" + tk + "',N'" + pass + "',N'" + loai + "',N'" + manv + "')";
                        database.ThucThiKetNoi(insert);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        database.loadDataGridView(dataGridView1, "select * from TAIKHOAN");
                    }
                    else
                    {
                        MessageBox.Show("Nhân viên đã có tài khoản, Không thể thêm!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Bạn cần điền đầy đủ thông tin để hoàn tất!","Mời bạn nhập lại!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin để hoàn tất!", "Mời bạn nhập lại!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ma = cbbMaNV.Text.Trim();
            try
            {
                bool check = database.Check(ma, "select MaNV from TAIKHOAN");

                if (check == true)
                {
                    DialogResult h = MessageBox.Show("Bạn có muốn xóa Tài khoản này không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (h == DialogResult.Yes)
                    {
                        string del = "delete from TAIKHOAN where MaNV = N'" + ma + "'";
                        database.ThucThiKetNoi(del);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        database.loadDataGridView(dataGridView1, "select * from TAIKHOAN");
                        Reset();
                    }
                }
                else
                {
                    MessageBox.Show("Nhân viên chưa có tài khoản!", "Mời bạn kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa! ","", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
           
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
