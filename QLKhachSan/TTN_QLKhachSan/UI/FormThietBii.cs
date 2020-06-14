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
    public partial class FormThietBii : Form
    {
        ConnectDatabase database = new ConnectDatabase();
        public FormThietBii()
        {
            InitializeComponent();
        }
        public void Loadd()
        {
            cbbmatb.Items.Clear();
            database.loadComboBox(cbbmatb, "select MaTB from THIETBI");
            database.loadDataGridView(dgvtb, "select * from THIETBI");
        }
        public void Reset()
        {
            cbbmatb.Text = "";
            txttentb.Text = "";
        }
        private void FormThietBii_Load(object sender, EventArgs e)
        {
            Loadd();
        }

        private void cbbmatb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = cbbmatb.SelectedItem.ToString();
            database.loadTextBox(txttentb, "select TenTB from THIETBI where MaTB = N'"+ temp +"'");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
               string ma = cbbmatb.Text.Trim();
                string ten = txttentb.Text.Trim();

                if (ma.Length != 0 && ten.Length != 0 )
                {
                    bool check = database.Check(ma, "select MaTB from THIETBI");
                    if (check == false)
                    {
                        string insert = "INSERT INTO THIETBI Values('" + ma + "',N'" + ten + "')";
                        database.ThucThiKetNoi(insert);
                        
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Reset();
                        Loadd();
                    }
                    else
                    {
                        MessageBox.Show("Thiết bị đã tồn tại, Không thể thêm!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                string ma = cbbmatb.Text.Trim();
                string ten = txttentb.Text.Trim();

                if (ma.Length != 0 && ten.Length != 0)
                {

                    bool check = database.Check(ma, "SELECT MaTB from THIETBI");
                    if (check == true)
                    {
                        string update = "UPDATE THIETBI SET TenTB = N'" + ten + "' WHERE MaTB = '" + ma + "' ";
                        database.ThucThiKetNoi(update);
                       
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Loadd();

                    }
                    else
                    {
                        MessageBox.Show("Thiết Bị chưa tồn tại, Không thể sửa!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
            string ma = cbbmatb.Text.Trim();
            try
            {
                bool check = database.Check(ma, "SELECT MaTB from THIETBI");

                if (check == true)
                {
                    DialogResult y = MessageBox.Show("Bạn muốn xóa Thiết bị " + ma + " không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (y == DialogResult.Yes)
                    {
                        string del = "delete from THIETBI where MaTB = N'" + ma + "'";
                        database.ThucThiKetNoi(del);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Loadd();
                        Reset();
                    }

                }
                else
                {
                    MessageBox.Show("Thiết bị phòng không tồn tại !", "Mời bạn kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa! ", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
