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

        private void QLDichVu_Load(object sender, EventArgs e)
        {
            string Load = "Select* From DICHVU";
            db.loadDataGridView(dGVDichVu,Load);
        }

        private void dGVDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dGVDichVu.CurrentRow.Index;
            txtma.Text = dGVDichVu.Rows[i].Cells[0].Value.ToString();
            txtten.Text = dGVDichVu.Rows[i].Cells[1].Value.ToString();
            txtgia.Text = dGVDichVu.Rows[i].Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
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
                    MessageBox.Show("Thêm Dịch Vụ Thành Công !");

                }    
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
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
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Chưa điền đủ thông tin cần xóa");
            }
            else
            {
                string madv = txtma.Text.ToString();
                bool check = db.Check(madv, "SELECT MaDV  FROM dbo.DICHVU_SD WHERE MaDV=N'" + madv + "'");
                if (check == true)
                {
                    MessageBox.Show("Chưa thể xóa!");
                }
                else
                {
                    DialogResult y = MessageBox.Show("Bạn muốn xóa "+txtma.Text.Trim()+" không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (y == DialogResult.Yes)
                    {
                        string xoa = "DELETE FROM dbo.DICHVU WHERE MaDV = N'" + txtma.Text.Trim() + "'";
                        db.ThucThiKetNoi(xoa);
                        string Load = "Select * From dbo.DICHVU";
                        db.loadDataGridView(dGVDichVu, Load);
                    }
                    
                }
                
                

            }    
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnDS_Click(object sender, EventArgs e)
        {
            
        }
    }
}
