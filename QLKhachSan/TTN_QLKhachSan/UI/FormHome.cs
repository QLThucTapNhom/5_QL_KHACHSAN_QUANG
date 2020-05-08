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
    public partial class FormHome : Form
    {
        ConnectDatabase database = new ConnectDatabase();
        public FormHome()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemDichVu_Click(object sender, EventArgs e)
        {
            QLDichVu DV = new QLDichVu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            DV.FormBorderStyle = FormBorderStyle.None;
            this.panelControl.Controls.Add(DV);
            foreach (Control ctrl in panelControl.Controls)
            {
                if (ctrl != DV)
                    ctrl.Dispose();
            }
            DV.Show();
        }

        private void ToolStripMenuItemUsers_Click(object sender, EventArgs e)
        {
            string tem = "1";
            bool check = database.Check(tem, "select MaQuyen from TAIKHOAN where TenDangNhap = '" + Form1.useracc + "'");
            if (check == true)
            {
                QLNguoiDung user = new QLNguoiDung() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                user.FormBorderStyle = FormBorderStyle.None;
                this.panelControl.Controls.Add(user);
                foreach (Control ctrl in panelControl.Controls)
                {
                    if (ctrl != user)
                        ctrl.Dispose();
                }
                user.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa được cấp quyền để sử dụng tính năng này!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ToolStripMenuItemThuePhong_Click(object sender, EventArgs e)
        {
            
        }
        private void MenuItemKhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachHang thue = new FrmKhachHang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            thue.FormBorderStyle = FormBorderStyle.None;
            this.panelControl.Controls.Add(thue);
            foreach (Control ctrl in panelControl.Controls)
            {
                if (ctrl != thue)
                    ctrl.Dispose();
            }
            thue.Show();
        }

        private void MenuItemPhieuThue_Click(object sender, EventArgs e)
        {
            FrmThuePhong thue = new FrmThuePhong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            thue.FormBorderStyle = FormBorderStyle.None;
            this.panelControl.Controls.Add(thue);
            foreach (Control ctrl in panelControl.Controls)
            {
                if (ctrl != thue)
                    ctrl.Dispose();
            }
            thue.Show();
        }
        
        private void MenuItemNhanVien_Click(object sender, EventArgs e)
        {
            string tem = "1";
            bool check = database.Check(tem, "select MaQuyen from TAIKHOAN where TenDangNhap = '" + Form1.useracc + "'");
            if (check == true)
            {
                FrmNhanVien Nv = new FrmNhanVien() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                Nv.FormBorderStyle = FormBorderStyle.None;
                this.panelControl.Controls.Add(Nv);
                foreach (Control ctrl in panelControl.Controls)
                {
                    if (ctrl != Nv)
                        ctrl.Dispose();
                }
                Nv.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa được cấp quyền để sử dụng tính năng này!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
           
        }

        private void MenuStripTTPhong_Click(object sender, EventArgs e)
        {
            FrmPhongDangThue p = new FrmPhongDangThue() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.FormBorderStyle = FormBorderStyle.None;
            this.panelControl.Controls.Add(p);
            foreach (Control ctrl in panelControl.Controls)
            {
                if (ctrl != p)
                    ctrl.Dispose();
            }
            p.Show();
        }

        private void MenuItemDSPhongDangThue_Click(object sender, EventArgs e)
        {
            FrmDSPDangSD p = new FrmDSPDangSD() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.FormBorderStyle = FormBorderStyle.None;
            this.panelControl.Controls.Add(p);
            foreach (Control ctrl in panelControl.Controls)
            {
                if (ctrl != p)
                    ctrl.Dispose();
            }
            p.Show();
        }

        private void MenuItemDSPhong_Click(object sender, EventArgs e)
        {
            FormDSPhong p = new FormDSPhong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.FormBorderStyle = FormBorderStyle.None;
            this.panelControl.Controls.Add(p);
            foreach (Control ctrl in panelControl.Controls)
            {
                if (ctrl != p)
                    ctrl.Dispose();
            }
            p.Show();
        }

        private void MenuItemThietBiPhong_Click(object sender, EventArgs e)
        {
            FrmThietBi p = new FrmThietBi() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.FormBorderStyle = FormBorderStyle.None;
            this.panelControl.Controls.Add(p);
            foreach (Control ctrl in panelControl.Controls)
            {
                if (ctrl != p)
                    ctrl.Dispose();
            }
            p.Show();
        }

        private void MenuItemLichSu_Click(object sender, EventArgs e)
        {
            FrmLichSu p = new FrmLichSu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.FormBorderStyle = FormBorderStyle.None;
            this.panelControl.Controls.Add(p);
            foreach (Control ctrl in panelControl.Controls)
            {
                if (ctrl != p)
                    ctrl.Dispose();
            }
            p.Show();
        }

        private void MenuItemHoaDon_Click(object sender, EventArgs e)
        {
            FrmDsHoaDon p = new FrmDsHoaDon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.FormBorderStyle = FormBorderStyle.None;
            this.panelControl.Controls.Add(p);
            foreach (Control ctrl in panelControl.Controls)
            {
                if (ctrl != p)
                    ctrl.Dispose();
            }
            p.Show();
        }

        private void MenuItemBC_Click(object sender, EventArgs e)
        {
            FormBCDoanhThu p = new FormBCDoanhThu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.FormBorderStyle = FormBorderStyle.None;
            this.panelControl.Controls.Add(p);
            foreach (Control ctrl in panelControl.Controls)
            {
                if (ctrl != p)
                    ctrl.Dispose();
            }
            p.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Do you want exit program ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MenuItemLogOut_Click(object sender, EventArgs e)
        {
            

            DialogResult h = MessageBox.Show("Do you want log out ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                this.Hide();
                Form1 dn = new Form1();
                dn.Show();
            }
        }
    }
}
