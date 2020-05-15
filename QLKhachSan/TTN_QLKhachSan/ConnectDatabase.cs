using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace LoginForm_DeMo
{
    class ConnectDatabase
    {
        string str = @"Data Source=DESKTOP-4H2CDN2;Initial Catalog=QLKHACHSAN;Integrated Security=True";
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        SqlDataReader sqlDataReader;
        DataSet dataSet = new DataSet();

        void KetNoi()
        {
            sqlConnection = new SqlConnection(str);
            sqlConnection.Open();
        }

        void NgatKetNoi()
        {
            sqlConnection.Close();
        }

        public void ThucThiKetNoi(string strsql)
        {
            KetNoi();
            sqlCommand = new SqlCommand(strsql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            NgatKetNoi();
        }


        public void loadDataGridView(DataGridView dg, string strselect)
        {
            DataTable table = new DataTable();
            sqlDataAdapter = new SqlDataAdapter(strselect, str);
            table.Clear();
            sqlDataAdapter.Fill(table);
            dg.DataSource = table;
        }

        public void loadComboBox(ComboBox cb, string strselect)
        {
            KetNoi();
            sqlCommand = new SqlCommand(strselect, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cb.Items.Add(sqlDataReader[0].ToString());
            }
            NgatKetNoi();
        }
        public void loadComboBox_Show(ComboBox cb, string strselect)
        {
            KetNoi();
            sqlCommand = new SqlCommand(strselect, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cb.Text = (sqlDataReader[0].ToString());
            }
            NgatKetNoi();
        }
        public void loadnumupdown(NumericUpDown num, string strselect)
        {
            KetNoi();
            sqlCommand = new SqlCommand(strselect, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                num.Text = (sqlDataReader[0].ToString());
            }
            NgatKetNoi();
        }
        public void loadDateTime(DateTimePicker dtp, string strselect)
        {
            KetNoi();
            sqlCommand = new SqlCommand(strselect, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                dtp.Text = (sqlDataReader[0].ToString());
            }
            NgatKetNoi();
        }
        public void loadTextBox(TextBox tb, string strselect)
        {
            KetNoi();
            sqlCommand = new SqlCommand(strselect, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                tb.Text = sqlDataReader[0].ToString();
            }
            NgatKetNoi();
        }
        public void loadlabel(Label lb, string strselect)
        {
            KetNoi();
            sqlCommand = new SqlCommand(strselect, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                lb.Text = sqlDataReader[0].ToString();
            }
            NgatKetNoi();
        }



        public bool Check(string temp, string strsql)
        {

            KetNoi();
            bool check = false;
            sqlCommand = new SqlCommand(strsql, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                if (sqlDataReader[0].ToString().Trim() == temp)
                    check = true;
            }
            NgatKetNoi();
            return check;
        }

    }
}
