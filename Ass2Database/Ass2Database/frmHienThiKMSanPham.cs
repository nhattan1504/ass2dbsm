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
    public partial class frmHienThiKMSanPham : Form
    {
        public frmHienThiKMSanPham()
        {
            InitializeComponent();
        }

        private void txtSodonhang_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-DJ5NDDL\\KTANTSQLSERVER;Initial Catalog=Store;Integrated Security=True";
        private void btnXong_Click(object sender, EventArgs e)
        {
            if (txtTensanpham.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm");
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
                    sqlCommand.CommandText = "find_slsp_by_tensp";
                    sqlCommand.Connection = conn;
                    SqlParameter paraTensanpham = new SqlParameter("@Tensp", SqlDbType.NVarChar,100);
                    paraTensanpham.Value = txtTensanpham.Text;
                    sqlCommand.Parameters.Add(paraTensanpham);
                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                    lvKM.Items.Clear();
                    while (sqlReader.Read())
                    {
                        ListViewItem lvi = new ListViewItem(sqlReader.GetString(0));
                        lvi.SubItems.Add(sqlReader.GetString(1));
                        lvi.SubItems.Add(sqlReader.GetString(2));
                        lvi.SubItems.Add(sqlReader.GetDateTime(3).ToString());
                        lvi.SubItems.Add(sqlReader.GetDateTime(4).ToString());
                        lvi.SubItems.Add(sqlReader.GetString(5));
                        lvKM.Items.Add(lvi);
                    }
                    sqlReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }

        }
    }
    }

