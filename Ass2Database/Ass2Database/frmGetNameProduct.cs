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
    public partial class frmGetNameProduct : Form
    {
        public frmGetNameProduct()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = "Data Source=RYYN;Initial Catalog=Store;Integrated Security=True";
        private void btnXong_Click(object sender, EventArgs e)
        {
            
            if (txtMadoitac.Text=="")
            {
                MessageBox.Show("Bạn phải nhập mã đối tác");
            }
            else
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
                    sqlCommand.CommandText = "getNameProductRyyn";
                    sqlCommand.Connection = conn;
                    SqlParameter paraMadoitac = new SqlParameter("@madoitac", SqlDbType.VarChar, 10);
                    paraMadoitac.Value = txtMadoitac.Text;
                    sqlCommand.Parameters.Add(paraMadoitac);

                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                    lvSanpham.Items.Clear();
                    while (sqlReader.Read())
                    {
                        string madoitac = sqlReader.GetString(0);
                        string madonhang = sqlReader.GetString(1);
                        string tensanpham = sqlReader.GetString(2);
                        ListViewItem lvi = new ListViewItem(madoitac);
                        lvi.SubItems.Add(madonhang);
                        lvi.SubItems.Add(tensanpham);
                        lvSanpham.Items.Add(lvi);
                    }
                    sqlReader.Close();
                    txtMadoitac.Text = "";

                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
