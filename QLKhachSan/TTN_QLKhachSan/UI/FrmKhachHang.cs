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
    public partial class FrmKhachHang : Form
    {
        ConnectDatabase database = new ConnectDatabase();
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            database.loadDataGridView(dgvkh, "select * from KHACHHANG");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public void Rerset()
        {
            txtsdt.Text = "";
            txtten.Text = "";
            cbbcmnd.Text = "";
            MAKH.Text = "";
            showma.Text = "";
            cbbtkcmnd.Text = "";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmnd = cbbcmnd.SelectedItem.ToString();
            database.loadTextBox(txtten, "select TenKH from KHACHHANG where CMND = N'"+ cmnd +"'");
            database.loadTextBox(txtsdt, "select SDT from KHACHHANG where CMND = N'" + cmnd + "'");
            MAKH.Text = "Mã KH :";
            database.loadlabel(showma, "select MaKH from KHACHHANG where CMND = N'" + cmnd + "'");
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            database.loadComboBox(cbbcmnd, "select CMND from KHACHHANG");
            database.loadComboBox(cbbtkcmnd, "select CMND from KHACHHANG");
            database.loadDataGridView(dgvkh, "select * from KHACHHANG");
        }
        
        public void Loadcmnd()
        {
            database.loadComboBox(cbbcmnd, "select CMND from KHACHHANG");
            database.loadComboBox(cbbtkcmnd, "select CMND from KHACHHANG");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string ten = txtten.Text.Trim();
            string sdt = txtsdt.Text.Trim();
            string cmnd = cbbcmnd.Text.Trim();
            string ma = showma.Text.Trim();
            try
            {
                if (ten.Length != 0 && sdt.Length != 0 && cmnd.Length != 0)
                {
                    string update = "update KHACHHANG set TenKH = N'" + ten + "', SDT = N'" + sdt + "',CMND= N'" + cmnd + "' where MaKH = N'"+ ma +"'";
                    database.ThucThiKetNoi(update);
                    MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Loadcmnd();
                    database.loadDataGridView(dgvkh, "select * from KHACHHANG");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
            }
            catch
            {
                MessageBox.Show("Không thể sửa!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = txtten.Text.Trim();
            string sdt = txtsdt.Text.Trim();
            string cmnd = cbbcmnd.Text.Trim();
            try
            {
                bool check = database.Check(cmnd, "Select CMND from KHACHHANG");
                if(check == false)
                {
                    if(ten.Length != 0 && sdt.Length != 0 && cmnd.Length != 0)
                    {
                        string insert = "insert into KHACHHANG (TenKH,SDT,CMND) values (N'" + ten + "',N'" + sdt + "',N'" + cmnd + "')";
                        database.ThucThiKetNoi(insert);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        database.loadDataGridView(dgvkh, "select * from KHACHHANG");
                        MAKH.Text = "Mã KH :";
                        database.loadlabel(showma, "select MaKH from KHACHHANG where CMND = N'" + cmnd + "'");
                        Rerset();
                        Loadcmnd();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    }
                }
                else
                {
                    MessageBox.Show("Khách hàng đã tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }


            }
            catch
            {
                MessageBox.Show("Lỗi rồi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
            }
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            string temp = showma.Text.Trim();
            try
            {
                string delete = "delete KHACHHANG where MaKH = N'" + temp + "'";
                database.ThucThiKetNoi(delete);
                MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                database.loadDataGridView(dgvkh, "select * from KHACHHANG");
                Rerset();
                Loadcmnd();

            }
            catch
            {
                MessageBox.Show("Không thể xóa!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string temp = cbbtkcmnd.Text.Trim();
            if(temp.Length != 0)
            {
                string search = cbbtkcmnd.Text.Trim();
                database.loadDataGridView(dgvkh, "select * from KHACHHANG where CMND = N'" + search + "'");
                Rerset();
            }
            else
            {
                MessageBox.Show("Vui Lòng chọn số CMND của khách hàng!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cbbtkcmnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string search = cbbtkcmnd.SelectedItem.ToString();
            database.loadDataGridView(dgvkh, "select * from KHACHHANG where CMND = N'" + search + "'");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtsdt.Clear();
            txtten.Clear();
            cbbcmnd.Text = "";
        }
    }
}
