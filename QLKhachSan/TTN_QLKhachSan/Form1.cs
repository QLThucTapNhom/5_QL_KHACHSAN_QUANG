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
using TTN_QLKhachSan.UI;

namespace TTN_QLKhachSan
{
    public partial class Form1 : Form
    {
        ConnectDatabase database = new ConnectDatabase();
        public static string useracc;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            if (txtTaiKhoan.Text.TrimEnd().Length != 0 && txtMatKhau.Text.TrimEnd().Length != 0)
            {

                string username = txtTaiKhoan.Text.TrimEnd();
                string password = txtMatKhau.Text.TrimEnd();


                bool check = database.Check(password, "select MatKhau from TAIKHOAN where TenDangNhap ='" + username + "'");
                if (check == true)
                {
                    useracc = username;
                    FormHome m = new FormHome();
                    m.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Username hoặc password không chính xác!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                    checkBox1.Checked = false;
                }

            }
            else
            {

                MessageBox.Show("Vui lòng nhập đầy đủ username và password!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
                checkBox1.Checked = false;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn muốn thoát không?", "",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Do you want exit program ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
