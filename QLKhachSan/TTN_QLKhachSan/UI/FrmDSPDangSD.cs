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
    public partial class FrmDSPDangSD : Form
    {
        ConnectDatabase database = new ConnectDatabase();
        public FrmDSPDangSD()
        {
            InitializeComponent();
        }

        private void FrmDSPDangSD_Load(object sender, EventArgs e)
        {
            database.loadDataGridView(dataGridView1, "select * from PHONG where TrangThai = N'Thuê'");
        }
    }
}
