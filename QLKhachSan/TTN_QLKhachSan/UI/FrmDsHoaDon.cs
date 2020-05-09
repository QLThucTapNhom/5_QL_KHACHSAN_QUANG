using LoginForm_DeMo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QLKhachSan.UI
{
    public partial class FrmDsHoaDon : Form
    {
        ConnectDatabase database = new ConnectDatabase();
        public FrmDsHoaDon()
        {
            InitializeComponent();
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string day = dateTimePicker1.Value.Day.ToString();
            string month = dateTimePicker1.Value.Month.ToString();
            string year = dateTimePicker1.Value.Year.ToString();
            database.loadDataGridView(dataGridView1, "select * from HOADON where day(NgayLap) = N'" + day + "' and month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "'");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
             string day = dateTimePicker1.Value.Day.ToString();
             string month = dateTimePicker1.Value.Month.ToString();
             string year = dateTimePicker1.Value.Year.ToString();
            if (radioButtonday.Checked)
            {
                database.loadDataGridView(dataGridView1, "select * from HOADON where day(NgayLap) = N'" + day + "' and month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "'");
            }
            if (radioButtonmonth.Checked)
            {
                database.loadDataGridView(dataGridView1, "select * from HOADON where month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "'");
            }
            if (radioButtonyear.Checked)
            {
                database.loadDataGridView(dataGridView1, "select * from HOADON where year(NgayLap) = N'" + year + "'");
            }
        }
       
        private void radioButtonmonth_CheckedChanged(object sender, EventArgs e)
        {
            string month = dateTimePicker1.Value.Month.ToString();
            string year = dateTimePicker1.Value.Year.ToString();
            database.loadDataGridView(dataGridView1, "select * from HOADON where month(NgayLap) = N'" + month + "' and year(NgayLap) = N'" + year + "'");
        }

        private void radioButtonyear_CheckedChanged(object sender, EventArgs e)
        {
            string year = dateTimePicker1.Value.Year.ToString();
            database.loadDataGridView(dataGridView1, "select * from HOADON where year(NgayLap) = N'" + year + "'");
        }

        private void FrmDsHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
