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
    
    public partial class QLDichVu : Form
    {
        ConnectDatabase db = new ConnectDatabase();
        public QLDichVu()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        public void loadcbbdgv()
        {
            string Load = "Select * From DICHVU";
            db.loadDataGridView(dGVDichVu, Load);
            cbbDV.Items.Clear();
            db.loadComboBox(cbbDV, "select MaDV from DICHVU");
        }
=======
>>>>>>> 93fe350f3f55a0477b97b47ab5a0b0f7db97fdda

        private void QLDichVu_Load(object sender, EventArgs e)
        {
            string Load = "Select* From DICHVU";
            db.loadDataGridView(dGVDichVu,Load);
<<<<<<< HEAD
            db.loadComboBox(cbbDV, "select MaDV from DICHVU");
=======
>>>>>>> 93fe350f3f55a0477b97b47ab5a0b0f7db97fdda
        }

        private void dGVDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dGVDichVu.CurrentRow.Index;
<<<<<<< HEAD
            cbbDV.Text = dGVDichVu.Rows[i].Cells[0].Value.ToString();
=======
            txtma.Text = dGVDichVu.Rows[i].Cells[0].Value.ToString();
>>>>>>> 93fe350f3f55a0477b97b47ab5a0b0f7db97fdda
            txtten.Text = dGVDichVu.Rows[i].Cells[1].Value.ToString();
            txtgia.Text = dGVDichVu.Rows[i].Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            try
            {
                string ten = txtten.Text.Trim();
                string gia = txtgia.Text.Trim();
                string madv = cbbDV.Text.Trim();
                if (ten.Length != 0 && gia.Length != 0 && madv.Length != 0)              
                {
                    bool check = db.Check(madv, "select MaDV from DICHVU");
                    if (check == true)
                    {
                        MessageBox.Show("Mã Dịch Vụ đã Tồn tại", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        string insert = "insert into DICHVU values(N'" + madv + "',N'" + ten + "','" + gia + "')";
                        db.ThucThiKetNoi(insert);
                        loadcbbdgv();
                        MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    }
                }
                else
                {
                    MessageBox.Show("Chưa điền đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
            }
            catch
            {

            }
               
=======
            if(txtma.Text=="")
            {
                MessageBox.Show("Chưa điền đủ thông tin");
            }
            else
            {
                string id = txtma.Text.Trim();

                bool check = db.Check(id, "select MaDV from DICHVU");
                if(check==true)
                {
                    MessageBox.Show("Mã Dịch Vụ đã Tồn tại");
                }    
                else
                {
                    string insert = "insert into DICHVU values(N'"+txtma.Text+"',N'"+txtten.Text+"',"+txtgia.Text+")";
                    db.ThucThiKetNoi(insert);
                    string Load = "Select* From DICHVU";
                    db.loadDataGridView(dGVDichVu, Load);
                    MessageBox.Show("Thêm thành công");

                }    
            }    
>>>>>>> 93fe350f3f55a0477b97b47ab5a0b0f7db97fdda
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            try
            {
                string ten = txtten.Text.Trim();
                string gia = txtgia.Text.Trim();
                string madv = cbbDV.Text.Trim();
                if (ten.Length != 0 && gia.Length != 0 && madv.Length != 0)           
                {
                    bool check = db.Check(madv, "select MaDV from DICHVU");
                    if (check == true)
                    {
                        DialogResult h = MessageBox.Show("Bạn có muốn sửa Dịch vụ này không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (h == DialogResult.Yes)
                        {
                            string sua = "update DICHVU set TenDV = N'" + ten + "',GiaDV = '" + gia + "' where MaDV = N'" + madv + "'";
                            db.ThucThiKetNoi(sua);
                            loadcbbdgv();
                            MessageBox.Show("Sửa thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã Dịch Vụ không khớp!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa điền đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }            
            }
            catch
            {

            }
                
=======
            if (txtma.Text == "")
            {
                MessageBox.Show("Chưa điền đủ thông tin");
            }
            else
            {
                string sua = "update DICHVU set TenDV = N'" + txtten.Text + "',GiaDV = " + txtgia.Text + " where MaDV = N'"+txtma.Text+"'";
                db.ThucThiKetNoi(sua);
                string Load = "Select* From DICHVU";
                db.loadDataGridView(dGVDichVu, Load);
                MessageBox.Show("Sửa thành công");

            }    
>>>>>>> 93fe350f3f55a0477b97b47ab5a0b0f7db97fdda
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (cbbDV.Text == "")
            {
                MessageBox.Show("Chưa điền đủ thông tin cần xóa", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DialogResult h = MessageBox.Show("Bạn có muốn xóa Dịch vụ này không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (h == DialogResult.Yes)
                {
                    string xoa = "exec Xoa_DV @MaDV =N'" + cbbDV.Text.Trim() + "'";
                    db.ThucThiKetNoi(xoa);
                    loadcbbdgv();
                    MessageBox.Show("Xóa thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = cbbDV.SelectedItem.ToString();
            db.loadTextBox(txtten,"select TenDV from DICHVU where MaDV = N'"+ temp +"'");
            db.loadTextBox(txtgia, "select GiaDV from DICHVU where MaDV = N'" + temp + "'");
=======
            if (txtma.Text == "")
            {
                MessageBox.Show("Chưa điền đủ thông tin cần xóa");
            }
            else
            {
                string xoa = "exec Xoa_DV @MaDV =N'"+txtma.Text.Trim()+"'";
                db.ThucThiKetNoi(xoa);
                string Load = "Select* From DICHVU";
                db.loadDataGridView(dGVDichVu, Load);
                MessageBox.Show("Xóa thành công");

            }    
>>>>>>> 93fe350f3f55a0477b97b47ab5a0b0f7db97fdda
        }
    }
}
