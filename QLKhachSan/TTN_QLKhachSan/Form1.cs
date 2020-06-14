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
using System.Threading;

namespace TTN_QLKhachSan
{
    public partial class Form1 : Form
    {
        Thread th;
        public void OpenFormHome(Object obj)
        {
            Application.Run(new FormHome());

        }

        ConnectDatabase database = new ConnectDatabase();
        public static string useracc;
        public static string manv;
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


                bool check = database.Check(password, "Select MatKhau from TAIKHOAN where TenDangNhap =  N'" + username + "'");
                if (check == true)
                {
                    useracc = username;

                    FormHome m = new FormHome();
                    m.Show();
                    this.Hide();

                    //this.Close();
                    //th = new Thread(OpenFormHome);
                    //th.SetApartmentState(ApartmentState.STA);
                    //th.Start();

                }
                else
                {

                    MessageBox.Show("Username hoặc password không chính xác!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                    checkBox1.Checked = false;
                    this.ActiveControl = txtTaiKhoan;
                }

            }
            else
            {

                MessageBox.Show("Vui lòng nhập đầy đủ username và password!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
                checkBox1.Checked = false;
                this.ActiveControl = txtTaiKhoan;
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
            this.ActiveControl = txtMatKhau;
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Do you want exit program ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtTaiKhoan;
        }
    }
}
