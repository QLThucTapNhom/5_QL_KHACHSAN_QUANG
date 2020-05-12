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
        public void loadcbbdgv()
        {
            string Load = "Select * From DICHVU";
            db.loadDataGridView(dGVDichVu, Load);
            cbbDV.Items.Clear();
            db.loadComboBox(cbbDV, "select MaDV from DICHVU");
        }

        private void QLDichVu_Load(object sender, EventArgs e)
        {
            string Load = "Select* From DICHVU";
            db.loadDataGridView(dGVDichVu,Load);
            db.loadComboBox(cbbDV, "select MaDV from DICHVU");
        }

        private void dGVDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dGVDichVu.CurrentRow.Index;
            cbbDV.Text = dGVDichVu.Rows[i].Cells[0].Value.ToString();
            txtten.Text = dGVDichVu.Rows[i].Cells[1].Value.ToString();
            txtgia.Text = dGVDichVu.Rows[i].Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
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
               
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
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
                
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
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
        }
    }
}
