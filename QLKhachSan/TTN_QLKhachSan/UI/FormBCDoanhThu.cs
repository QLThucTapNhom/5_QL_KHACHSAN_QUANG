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
    public partial class FormBCDoanhThu : Form
    {
        ConnectDatabase database = new ConnectDatabase();
        public FormBCDoanhThu()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string day = dateTimePicker1.Value.Day.ToString();
            string month = dateTimePicker1.Value.Month.ToString();
            string year = dateTimePicker1.Value.Year.ToString();
            if (radioButtonday.Checked)
            {
                database.loadlabel(lbslhd, "select count(MaHD) from HOADON where day(NgayLap) = N'" + day + "' and month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "'");
                database.loadlabel(lbdthu, "select SUM(TongTien) from HOADON where day(NgayLap) = N'" + day + "' and month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "'");
                if(lbdthu.Text == "")
                {
                    lbdthu.Text = "0";
                }
            }
            if (radioButtonmonth.Checked)
            {
                database.loadlabel(lbslhd, "select count(MaHD) from HOADON where month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "'");
                database.loadlabel(lbdthu, "select SUM(TongTien) from HOADON where month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "'");
                if (lbdthu.Text == "")
                {
                    lbdthu.Text = "0";
                }
            }
            if (radioButtonyear.Checked)
            {
                database.loadlabel(lbslhd, "select count(MaHD) from HOADON where year(NgayLap) = N'" + year + "'");
                database.loadlabel(lbdthu, "select SUM(TongTien) from HOADON where year(NgayLap) = N'" + year + "'");
                if (lbdthu.Text == "")
                {
                    lbdthu.Text = "0";
                }
            }
        }

        private void radioButtonday_CheckedChanged(object sender, EventArgs e)
        {
            string day = dateTimePicker1.Value.Day.ToString();
            string month = dateTimePicker1.Value.Month.ToString();
            string year = dateTimePicker1.Value.Year.ToString();
            database.loadlabel(lbslhd, "select count(MaHD) from HOADON where day(NgayLap) = N'" + day + "' and month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "'");
            database.loadlabel(lbdthu, "select SUM(TongTien) from HOADON where day(NgayLap) = N'" + day + "' and month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "'");
            if (lbdthu.Text == "")
            {
                lbdthu.Text = "0";
            }
        }

        private void radioButtonmonth_CheckedChanged(object sender, EventArgs e)
        {
            string month = dateTimePicker1.Value.Month.ToString();
            string year = dateTimePicker1.Value.Year.ToString();
            database.loadlabel(lbslhd, "select count(MaHD) from HOADON where month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "'");
            database.loadlabel(lbdthu, "select SUM(TongTien) from HOADON where month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "'");
            if (lbdthu.Text == "")
            {
                lbdthu.Text = "0";
            }
        }

        private void radioButtonyear_CheckedChanged(object sender, EventArgs e)
        {
            string year = dateTimePicker1.Value.Year.ToString();
            database.loadlabel(lbslhd, "select count(MaHD) from HOADON where year(NgayLap) = N'" + year + "'");
            database.loadlabel(lbdthu, "select SUM(TongTien) from HOADON where year(NgayLap) = N'" + year + "'");
            if (lbdthu.Text == "")
            {
                lbdthu.Text = "0";
            }
        }

        private void lbslhd_Click(object sender, EventArgs e)
        {

        }
    }
}
