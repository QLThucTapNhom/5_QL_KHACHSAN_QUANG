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
    public partial class FrmNhanVien : Form
    {
        ConnectDatabase db = new ConnectDatabase();
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        

        public void Loadd()
        {
            db.loadDataGridView(dgvNhanVien, "select * from NHANVIEN");
            cbbtimnv.Items.Clear();
            db.loadComboBox(cbbtimnv, "select HoTenNV from NHANVIEN");
            cbbMaNV.Items.Clear();
            db.loadComboBox(cbbMaNV, "select MaNV from NHANVIEN");
        }
        public void Reset()
        {
            cbbMaNV.Text = "";
            txtCMT.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTenNV.Text = "";
            cbbtimnv.Text = "";
            dtpNgaySinh.Text = "";
            cbbChucVu.Text = "";
            cbbGioiTinh.Text = "";
            dtpNgaySinh.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
<<<<<<< HEAD
                string manv = cbbMaNV.Text.Trim();
=======
                string manv = txtMaNV.Text.Trim();
>>>>>>> 93fe350f3f55a0477b97b47ab5a0b0f7db97fdda
                string ten = txtTenNV.Text.Trim();
                string cmt = txtCMT.Text.Trim();
                string ngaysinh = dtpNgaySinh.Value.Year + "/" + dtpNgaySinh.Value.Month + "/" + dtpNgaySinh.Value.Day;
                string gtinh = cbbGioiTinh.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                string dchi = txtDiaChi.Text.Trim();                
                string chucvu = cbbChucVu.Text.Trim();
                //if (manv.Length != 0 && ten.Length != 0 && gtinh.Length != 0 && cmt.Length != 0 && chucvu.Length != 0)
                if (manv.Length != 0 && ten.Length != 0 && gtinh.Length != 0 && cmt.Length != 0 && chucvu.Length != 0)
                {
                    bool check = db.Check(manv, "select MaNV from NHANVIEN");
<<<<<<< HEAD
                    bool check2 = db.Check(cmt, "select CMND from NHANVIEN");
                    if (check == false && check2 == false)
                    {
                        string insert = "INSERT INTO NHANVIEN Values('"+ manv +"',N'"+ ten +"','"+cmt +"','"+ngaysinh+"',N'"+gtinh+"','"+sdt+"',N'"+ dchi +"',N'"+chucvu+"')";
=======
                    if (check == false)
                    {
                        string insert = "INSERT INTO NHANVIEN Values('"+ manv +"',N'"+ ten +"','"+cmt +"','"+ngaysinh+"','"+gtinh+"','"+sdt+"',N'"+ dchi +"',N'"+chucvu+"')";
>>>>>>> 93fe350f3f55a0477b97b47ab5a0b0f7db97fdda
                        db.ThucThiKetNoi(insert);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cbbChucVu.Items.Clear();
                        cbbGioiTinh.Items.Clear();
<<<<<<< HEAD
                        Loadd();
                    }
                    else
                    {
                        if(check == true)
                        {
                            MessageBox.Show("Trùng mã nhân viên, Không thể thêm!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        if (check2 == true)
                        {
                            MessageBox.Show("Trùng số CMND, Không thể thêm!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
=======
                        db.loadDataGridView(dgvNhanVien, "select * from NHANVIEN");
                    }
                    else
                    {
                        MessageBox.Show("Nhân viên đã có tài khoản, Không thể thêm!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
>>>>>>> 93fe350f3f55a0477b97b47ab5a0b0f7db97fdda
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

        private void BtnXoa_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string manv = cbbMaNV.Text.Trim();
=======
            string manv = txtMaNV.Text.Trim();
>>>>>>> 93fe350f3f55a0477b97b47ab5a0b0f7db97fdda
            try
            {
                bool check = db.Check(manv, "select MaNV from NHANVIEN");

                if (check == true)
                {
<<<<<<< HEAD
                    DialogResult h = MessageBox.Show("Bạn có muốn xóa Nhân viên này không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (h == DialogResult.Yes)
                    {
                        string del = "delete from NHANVIEN where MaNV = N'" + manv + "'";
                        db.ThucThiKetNoi(del);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Loadd();
                        Reset();
                    }
=======
                    string del = "delete from NHANVIEN where MaNV = N'" + manv + "'";
                    db.ThucThiKetNoi(del);
                    MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    db.loadDataGridView(dgvNhanVien, "select * from NHANVIEN");
                    txtMaNV.Text = "";
                    txtCMT.Text = "";
                    txtDiaChi.Text = "";
                    txtSDT.Text = "";
                    txtTenNV.Text = "";
                    txtTimKiem.Text = "";
                    dtpNgaySinh.Text = "";
                    cbbChucVu.Text = "";
                    cbbGioiTinh.Text = "";
>>>>>>> 93fe350f3f55a0477b97b47ab5a0b0f7db97fdda
                }
                else
                {
                    MessageBox.Show("Nhân viên chưa có tài khoản!", "Mời bạn kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa! ", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
<<<<<<< HEAD
        

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            Loadd();
        }
        

        private void BtnLammoi_Click(object sender, EventArgs e)
        {
            Reset();
=======

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            db.loadDataGridView(dgvNhanVien, "select * from NHANVIEN");
        }

        private void BtnLammoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtCMT.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTenNV.Text = "";
            txtTimKiem.Text = "";
            dtpNgaySinh.Text = "";
            cbbChucVu.Text = "";
            cbbGioiTinh.Text = "";
>>>>>>> 93fe350f3f55a0477b97b47ab5a0b0f7db97fdda
        }

        private void DgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a;
            a = dgvNhanVien.CurrentRow.Index;
<<<<<<< HEAD
            cbbMaNV.Text = dgvNhanVien.Rows[a].Cells[0].Value.ToString();
=======
            txtMaNV.Text = dgvNhanVien.Rows[a].Cells[0].Value.ToString();
>>>>>>> 93fe350f3f55a0477b97b47ab5a0b0f7db97fdda
            txtTenNV.Text = dgvNhanVien.Rows[a].Cells[1].Value.ToString();
            txtCMT.Text = dgvNhanVien.Rows[a].Cells[2].Value.ToString();
            DateTime dt1 = Convert.ToDateTime(dgvNhanVien.Rows[a].Cells[3].Value.ToString());
            dtpNgaySinh.Value = dt1;
            cbbGioiTinh.Text = dgvNhanVien.Rows[a].Cells[4].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[a].Cells[5].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[a].Cells[6].Value.ToString();
            cbbChucVu.Text = dgvNhanVien.Rows[a].Cells[7].Value.ToString();
        }

        private void DgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
<<<<<<< HEAD
                string manv = cbbMaNV.Text.Trim();
=======
                string manv = txtMaNV.Text.Trim();
>>>>>>> 93fe350f3f55a0477b97b47ab5a0b0f7db97fdda
                string ten = txtTenNV.Text.Trim();
                string cmt = txtCMT.Text.Trim();
                string ngaysinh = dtpNgaySinh.Value.Year + "/" + dtpNgaySinh.Value.Month + "/" + dtpNgaySinh.Value.Day;
                string gtinh = cbbGioiTinh.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                string dchi = txtDiaChi.Text.Trim();
                string chucvu = cbbChucVu.Text.Trim();
                if (manv.Length != 0 && ten.Length != 0 && gtinh.Length != 0 && cmt.Length != 0 && chucvu.Length != 0)
                {
               
                    bool check = db.Check(manv, "select MaNV from NHANVIEN");
<<<<<<< HEAD
        
                    if (check == true)
                    {
                       // string del = "delete NHANVIEN where MaNV=N'" + manv + "'";

                        DialogResult h = MessageBox.Show("Bạn có muốn sửa thông tin Nhân viên này không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (h == DialogResult.Yes)
                        {
                            string update = "UPDATE dbo.NHANVIEN SET  HoTenNV= N'" + ten + "' ,CMND= N'" + cmt + "' ,NgaySinh= '" + ngaysinh + "' ,GioiTinh= N'" + gtinh + "' , SDT= N'" + sdt + "' ,DiaChi= N'" + dchi + "' ,ChucVu = N'" + chucvu + "' WHERE MaNV=N'" + manv + "'";
                            db.ThucThiKetNoi(update);
                            MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Loadd();
                        }
                    }
                    else
                    {   
=======
                    if (check == true)
                    {
                        string update = "UPDATE dbo.NHANVIEN SET  HoTenNV= N'" + ten + "' ,CMND= N'" + cmt + "' ,NgaySinh= '" + ngaysinh + "' ,GioiTinh= N'" + gtinh+ "' , SDT= N'" + sdt + "' ,DiaChi= N'" + dchi + "' ,ChucVu = N'" + chucvu + "' WHERE MaNV=N'" + manv + "'";
                        db.ThucThiKetNoi(update);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        db.loadDataGridView(dgvNhanVien, "select * from NHANVIEN");
                    }
                    else
                    {
>>>>>>> 93fe350f3f55a0477b97b47ab5a0b0f7db97fdda
                        MessageBox.Show("Nhân viên không tồn lại!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string tukhoa = cbbtimnv.Text.Trim();
            //string timkiem ="SELECT*FROM dbo.NHANVIEN WHERE  MaNV like'%" + tukhoa + "+%' OR HoTenNV LIKE '%"+ tukhoa + "%' OR CMND LIKE '%"+ tukhoa + "%'OR SDT LIKE '%"+ tukhoa + "%'OR HoTenNV LIKE '%"+ tukhoa + "%'OR DiaChi LIKE '%"+ tukhoa + "%'OR ChucVu LIKE '%"+ tukhoa + "%'";
            string timkiem = "SELECT*FROM dbo.NHANVIEN WHERE  HoTenNV LIKE '%" + tukhoa + "%'";
            db.loadDataGridView(dgvNhanVien, timkiem);
            Reset();
            cbbtimnv.Text = tukhoa;

        }

        private void txtTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cbbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string manv = cbbMaNV.SelectedItem.ToString();
            db.loadTextBox(txtCMT, "select CMND from NHANVIEN where MaNV = N'" + manv + "'");
            db.loadTextBox(txtDiaChi, "select DiaChi from NHANVIEN where MaNV = N'" + manv + "'");
            db.loadTextBox(txtTenNV, "select HoTenNV from NHANVIEN where MaNV = N'" + manv + "'");
            db.loadTextBox(txtSDT, "select SDT from NHANVIEN where MaNV = N'" + manv + "'");
            db.loadComboBox_Show(cbbChucVu, "select ChucVu from NHANVIEN where MaNV = N'" + manv + "'");
            db.loadComboBox_Show(cbbGioiTinh, "select GioiTinh from NHANVIEN where MaNV = N'" + manv + "'");
            db.loaddtp(dtpNgaySinh, "select NgaySinh from NHANVIEN where MaNV = N'" + manv + "'");
        }
=======
            string tukhoa = txtTimKiem.Text.Trim();
            //string timkiem ="SELECT*FROM dbo.NHANVIEN WHERE  MaNV like'%" + tukhoa + "+%' OR HoTenNV LIKE '%"+ tukhoa + "%' OR CMND LIKE '%"+ tukhoa + "%'OR SDT LIKE '%"+ tukhoa + "%'OR HoTenNV LIKE '%"+ tukhoa + "%'OR DiaChi LIKE '%"+ tukhoa + "%'OR ChucVu LIKE '%"+ tukhoa + "%'";
            string timkiem = "SELECT*FROM dbo.NHANVIEN WHERE  HoTenNV LIKE '%" + tukhoa + "%'";
            db.loadDataGridView(dgvNhanVien, timkiem);

        }
>>>>>>> 93fe350f3f55a0477b97b47ab5a0b0f7db97fdda
    }
}
