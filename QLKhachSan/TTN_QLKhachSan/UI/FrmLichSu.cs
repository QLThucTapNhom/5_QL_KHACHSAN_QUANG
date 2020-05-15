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
    public partial class FrmLichSu : Form
    {
        ConnectDatabase database = new ConnectDatabase();
        public FrmLichSu()
        {
            InitializeComponent();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonmonth_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonyear_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonday_CheckedChanged(object sender, EventArgs e)
        {
            string day = dateTimePicker1.Value.Day.ToString();
            string month = dateTimePicker1.Value.Month.ToString();
            string year = dateTimePicker1.Value.Year.ToString();
            database.loadDataGridView(dataGridView1, "SELECT PH.MaPhieu, PH.MaPhong, KH.MaKH, KH.TenKH, PH.NgayNhanPhong "
                + "FROM dbo.PHIEUTHUEPHONG PH, dbo.KHACHHANG KH WHERE PH.MaKH = KH.MaKH AND day(NgayNhanPhong) = N'"
                + day + "' and month(NgayNhanPhong) = N'" + month + "' and year(NgayNhanPhong) = N'" + year + "'");
        }

        private void radioButtonmonth_CheckedChanged_1(object sender, EventArgs e)
        {
            string month = dateTimePicker1.Value.Month.ToString();
            string year = dateTimePicker1.Value.Year.ToString();
            database.loadDataGridView(dataGridView1, "SELECT PH.MaPhieu, PH.MaPhong, KH.MaKH, KH.TenKH, PH.NgayNhanPhong "
                +"FROM dbo.PHIEUTHUEPHONG PH, dbo.KHACHHANG KH "
                + "where PH.MaKH = KH.MaKH AND month(NgayNhanPhong) = N'" + month + "' and year(NgayNhanPhong) = N'" + year + "'");
        }

        private void radioButtonyear_CheckedChanged_1(object sender, EventArgs e)
        {
            string year = dateTimePicker1.Value.Year.ToString();
            database.loadDataGridView(dataGridView1, "SELECT PH.MaPhieu, PH.MaPhong, KH.MaKH, KH.TenKH, PH.NgayNhanPhong "
                + "FROM dbo.PHIEUTHUEPHONG PH, dbo.KHACHHANG KH "
                + " where PH.MaKH = KH.MaKH AND year(NgayNhanPhong) = N'" + year + "'");
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            string day = dateTimePicker1.Value.Day.ToString();
            string month = dateTimePicker1.Value.Month.ToString();
            string year = dateTimePicker1.Value.Year.ToString();
            if (radioButtonday.Checked)
            {
                database.loadDataGridView(dataGridView1, "select * from PHIEUTHUEPHONG where day(NgayNhanPhong) = N'" + day + "' and month(NgayNhanPhong) = N'" + month + "' and year(NgayNhanPhong) = N'" + year + "'");
            }
            if (radioButtonmonth.Checked)
            {
                database.loadDataGridView(dataGridView1, "select * from PHIEUTHUEPHONG where month(NgayNhanPhong) = N'" + month + "' and year(NgayNhanPhong) = N'" + year + "'");
            }
            if (radioButtonyear.Checked)
            {
                database.loadDataGridView(dataGridView1, "select * from PHIEUTHUEPHONG where year(NgayNhanPhong) = N'" + year + "'");
            }
        }
    }
}
