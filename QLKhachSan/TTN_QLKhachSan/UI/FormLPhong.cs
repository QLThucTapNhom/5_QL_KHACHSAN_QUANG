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
    public partial class FormLPhong : Form
    {
        ConnectDatabase data = new ConnectDatabase();
        public FormLPhong()
        {
            InitializeComponent();
        }
        public void Loadd()
        {
            data.loadDataGridView(dgvLPhong, "select * from LOAIPHONG");
            cbbTenLoaiPhongg.Items.Clear();
            data.loadComboBox(cbbTenLoaiPhongg, "Select TenLoaiPhong from LOAIPHONG");
        }
        public void Reset()
        {
            txtDongiaa.Text = "";
            txtmalpp.Text = "";
            txtsonguoii.Text = "";
            cbbTenLoaiPhongg.Text = "";
        }
        private void FormLPhong_Load(object sender, EventArgs e)
        {
            Loadd();
        }

        private void cbbMaLPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbbTenLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string malp = txtmalpp.Text.Trim();
                string tenlp = cbbTenLoaiPhongg.Text.Trim();
                string gia = txtDongiaa.Text.Trim();
                string songuoi = txtsonguoii.Text.Trim();

                if (malp.Length != 0 && tenlp.Length != 0 && gia.Length != 0 && songuoi.Length != 0)
                {
                    bool check = data.Check(malp, "SELECT MaLoaiPhong from LOAIPHONG");
                    if (check == false)
                    {
                        string insert = "insert into LOAIPHONG values (N'" + malp + "',N'" + tenlp + "',N'" + gia + "',N'" + songuoi + "')";
                        data.ThucThiKetNoi(insert);
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
                string malp = txtmalpp.Text.Trim();
                string tenlp = cbbTenLoaiPhongg.Text.Trim();
                string gia =txtDongiaa.Text.Trim();
                string songuoi = txtsonguoii.Text.Trim();
                if (malp.Length != 0 && tenlp.Length != 0 && gia.Length != 0 && songuoi.Length != 0 )
                {

                    bool check = data.Check(malp, "SELECT MaLoaiPhong from LOAIPHONG");
                    if (check == true)
                    {
                        string update = "update LOAIPHONG set TenLoaiPhong = N'" + tenlp + "', DonGia = N'" + gia + "', SoNgToiDa = N'" + songuoi + "' where MaLoaiPhong = N'" + malp + "'";
                        data.ThucThiKetNoi(update);
                        Loadd();
                        Reset();
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
            string malp = txtmalpp.Text.Trim();
            try
            {
                bool check = data.Check(malp, "SELECT MaLoaiPhong from LOAIPHONG");

                if (check == true)
                {
                    DialogResult y = MessageBox.Show("Bạn muốn xóa loại phòng " + malp + " không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (y == DialogResult.Yes)
                    {
                        string del = "delete from LOAIPHONG where MaLoaiPhong = N'" + malp + "'";
                        data.ThucThiKetNoi(del); 
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Loadd();
                        Reset();
                    }

                }
                else
                {
                    MessageBox.Show("Loai phòng không tồn tại !", "Mời bạn kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa! ", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtsonguoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbbTenLoaiPhong_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string temp = cbbTenLoaiPhongg.SelectedItem.ToString();
            try
            {
                data.loadTextBox(txtmalpp, "select MaLoaiPhong from LOAIPHONG where TenLoaiPhong =N'" + temp + "'");
                data.loadTextBox(txtDongiaa, "select DonGia from LOAIPHONG where TenLoaiPhong =N'" + temp + "'");
                data.loadTextBox(txtsonguoii, "select SoNgToiDa from LOAIPHONG where TenLoaiPhong =N'" + temp + "'");
            }
            catch
            {

            }
        }
    }
}
