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
    public partial class frmLocsptheogia : Form
    {
        public frmLocsptheogia()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-DJ5NDDL\\KTANTSQLSERVER;Initial Catalog=Store;Integrated Security=True";
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtGiatien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số tiền");
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
                    sqlCommand.CommandText = "find_slsp_by_gianiemyet";
                    sqlCommand.Connection = conn;
                    SqlParameter paraTien = new SqlParameter("@Tien", SqlDbType.Int);
                    paraTien.Value = Int32.Parse(txtGiatien.Text);
                    sqlCommand.Parameters.Add(paraTien);
                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                    lvSp.Items.Clear();
                    while (sqlReader.Read())
                    {
                        ListViewItem lvi = new ListViewItem(sqlReader.GetDecimal(0).ToString());
                        lvi.SubItems.Add(sqlReader.GetString(1));
                        lvi.SubItems.Add(sqlReader.GetString(2));
                        lvi.SubItems.Add(sqlReader.GetInt32(3).ToString());
                        lvSp.Items.Add(lvi);
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
