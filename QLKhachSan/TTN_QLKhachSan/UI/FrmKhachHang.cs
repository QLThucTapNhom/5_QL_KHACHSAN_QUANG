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
            database.loadDataGridView(dgv, "select MaKH as N'Mã khách hàng',TenKH as N'Tên khách hàng',CMND,SDT from KHACHHANG where MaKH in (select MaKH from PHIEUTHUEPHONG where MaPhong in (select MaPhong from PHONG where TrangThai = N'Thuê'))");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public void Rerset()
        {
            txtsdt.Text = "";
            txtten.Text = "";
            cbbCmnd.Text = "";
            MAKH.Text = "";
            showma.Text = "";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmnd = cbbCmnd.SelectedItem.ToString().Trim();
            database.loadTextBox(txtten, "select TenKH from KHACHHANG where CMND = N'"+ cmnd +"'");
            database.loadTextBox(txtsdt, "select SDT from KHACHHANG where CMND = N'" + cmnd + "'");
            txtsdt.Text = txtsdt.Text.Trim();
            MAKH.Text = "Mã KH :";
            database.loadlabel(showma, "select MaKH from KHACHHANG where CMND = N'" + cmnd + "'");
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            database.loadComboBox(cbbCmnd, "select CMND from KHACHHANG");
            int x = cbbCmnd.Items.Count;
            for (int i = 0; i < x; i++)
            {
                cbbCmnd.Items[i] = cbbCmnd.Items[i].ToString().Trim();
            }
          
           database.loadDataGridView(dgv, "select MaKH as N'Mã khách hàng',TenKH as N'Tên khách hàng',CMND,SDT from KHACHHANG where MaKH in (select MaKH from PHIEUTHUEPHONG where MaPhong in (select MaPhong from PHONG where TrangThai = N'Thuê'))");
        }

        public void Loadcmnd()
        {
            cbbCmnd.Items.Clear();
            database.loadComboBox(cbbCmnd, "Select CMND from KHACHHANG");
            int x = cbbCmnd.Items.Count;
            for (int i = 0; i < x; i++)
            {
                cbbCmnd.Items[i] = cbbCmnd.Items[i].ToString().Trim();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = txtten.Text.Trim();
                string sdt = txtsdt.Text.Trim();
                string cmnd = cbbCmnd.Text.Trim();
                string ma = showma.Text.Trim();
               
                if (ten.Length != 0 && sdt.Length != 0 && cmnd.Length != 0)
                {
                    if(cmnd.Length == 9 || cmnd.Length == 12)
                    {
                        DialogResult h = MessageBox.Show("Bạn có muốn sửa thông tin Khách hàng này không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (h == DialogResult.Yes)
                        {
                            string update = "update KHACHHANG set TenKH = N'" + ten + "' , CMND =N'" + cmnd + "' , SDT ='" + sdt + "' where MaKH = N'" + ma + "'";
                            database.ThucThiKetNoi(update);
                            MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            database.loadDataGridView(dgv, "select * from KHACHHANG where CMND = N'" + cmnd + "' ");

                            Loadcmnd();
                            Rerset();
                        }
                    }
                    else
                    {
                        MessageBox.Show("CMND 9 số hoặc 12 số!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }


                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string tenn = txtten.Text.Trim();
            string sdtt = txtsdt.Text.Trim();
            string cmndd = cbbCmnd.Text.Trim();
            try
            {
                bool check = database.Check(cmndd, "Select CMND from KHACHHANG");
                if(check == false)
                {
                    if(tenn.Length != 0 && sdtt.Length != 0 && cmndd.Length != 0)
                    {
                        
                        if((cmndd.Length == 9 || cmndd.Length ==12) )
                        {
                            string insert = " Insert into KHACHHANG values( N'" + tenn + "',N'" + cmndd + "',N'" + sdtt + "')";
                            database.ThucThiKetNoi(insert);
                            MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            
                            MAKH.Text = "Mã KH :";
                            database.loadlabel(showma, "select MaKH from KHACHHANG where CMND = N'" + cmndd + "'");
                            database.loadDataGridView(dgv, "select * from KHACHHANG where CMND = N'" + cmndd + "' ");
                            Rerset();
                            Loadcmnd();
                            
                        }
                        else
                        {
                            MessageBox.Show("CMND 9 hoặc 12 số !", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        }
                     
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
                       
            }
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            string cmnd = cbbCmnd.Text.Trim();
            try
            {
                bool check = database.Check(cmnd, "select CMND from KHACHHANG");
                {
                    if (check == true)
                    {
                        DialogResult h = MessageBox.Show("Bạn có muốn xóa Khách hàng này không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (h == DialogResult.Yes)
                        {
                            string delete = "Delete KHACHHANG where CMND = N'" + cmnd + "'";
                            database.ThucThiKetNoi(delete);
                            MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            database.loadDataGridView(dgv, "Select * from KHACHHANG");
                            Rerset();
                            Loadcmnd();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn CMND của Khách Hàng muốn xóa!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    }
                }
            }
            catch
            {
                MessageBox.Show("Khách hàng đang Thuê phòng!!!, Không thể Xóa! ", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string search1 = textBox_timkiem.Text.Trim();

            if (search1.Length != 0)
            {
               
                if(radioButtonTen.Checked )
                {
                    database.loadDataGridView(dgv, "select * from KHACHHANG where TenKH like N'%" + search1 + "%'");
                    Rerset();
                    textBox_timkiem.Text = "";
                }
                if (radioButtonCMND.Checked )
                {
                    database.loadDataGridView(dgv, "select * from KHACHHANG where CMND = N'" + search1 + "'");
                    Rerset();
                    textBox_timkiem.Text = "";
                }
                if (radioButtonSDT.Checked )
                {
                    database.loadDataGridView(dgv, "select * from KHACHHANG where SDT = N'" + search1 + "'");
                    Rerset();
                    textBox_timkiem.Text = "";
                }
            }
          
            this.ActiveControl = textBox_timkiem;
        }

       

        private void btnReset_Click(object sender, EventArgs e)
        {
            database.loadDataGridView(dgv, "Select * from KHACHHANG");

        }

        private void dgvkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a;
            a = dgv.CurrentRow.Index;
            showma.Text = dgv.Rows[a].Cells[0].Value.ToString().Trim();
            txtten.Text = dgv.Rows[a].Cells[1].Value.ToString().Trim();
            cbbCmnd.Text = dgv.Rows[a].Cells[2].Value.ToString().Trim();
            txtsdt.Text = dgv.Rows[a].Cells[3].Value.ToString().Trim();
        }

        private void cbbcmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && cbbCmnd.Text.Length <= 12)
                e.Handled = true;
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) )
                e.Handled = true;
        }

        private void textBox_timkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button5_Click(sender, e);
            }
        }
    }
}
