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
    public partial class frmCau3bAss : Form
    {
        public frmCau3bAss()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = "Data Source=RYYN;Initial Catalog=Store;Integrated Security=True";
        private void btnXong_Click(object sender, EventArgs e)
        {
            if (txtDiachi.Text!="")
            {
                try
                {
                    if (conn==null)
                    {
                        conn = new SqlConnection(strConn);
                    }
                    if (conn.State==ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "Cau3bAss";
                    sqlCommand.Connection = conn;
                    sqlCommand.Parameters.Add("@diachi", SqlDbType.VarChar, 100).Value = txtDiachi.Text;
                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                    lvThongtin.Items.Clear();
                    while (sqlReader.Read())
                    {
                        ListViewItem lvi = new ListViewItem(sqlReader.GetString(0));
                        lvi.SubItems.Add(sqlReader.GetDecimal(1).ToString());
                        lvThongtin.Items.Add(lvi);
                        
                    }
                    sqlReader.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!");
            }
        }
    }
}
