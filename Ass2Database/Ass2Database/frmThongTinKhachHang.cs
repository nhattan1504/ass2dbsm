using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ass2Database
{
    public partial class frmThongTinKhachHang : Form
    {
        public frmThongTinKhachHang()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = "Data Source=RYYN;Initial Catalog=Store;Integrated Security=True";
        private void btnXong_Click(object sender, EventArgs e)
        {
            if (txtSodonhang.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập số đơn hàng");
            }
            else
            {
                try
                {
                    if (conn == null)
                    {
                        conn = new SqlConnection(strConn);
                    }
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "printCustomersRyyn";
                    sqlCommand.Connection = conn;
                    SqlParameter paraSodonhang = new SqlParameter("@numOrder", SqlDbType.Int);
                    paraSodonhang.Value = Int32.Parse(txtSodonhang.Text);
                    sqlCommand.Parameters.Add(paraSodonhang);
                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                    lvInfo.Items.Clear();
                    while (sqlReader.Read())
                    {
                        ListViewItem lvi = new ListViewItem(sqlReader.GetString(0));
                        lvi.SubItems.Add(sqlReader.GetString(1));
                        lvi.SubItems.Add(sqlReader.GetString(2));
                        lvi.SubItems.Add(sqlReader.GetString(3));
                        lvi.SubItems.Add(sqlReader.GetValue(4).ToString());
                        lvInfo.Items.Add(lvi);
                    }
                    sqlReader.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                

            }
       
        }
    }
}
