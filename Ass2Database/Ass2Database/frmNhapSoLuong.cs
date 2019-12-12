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
    public partial class frmNhapSoLuong : Form
    {
        string makhachhang;
        string masanpham;
        string tensanpham;
        string nguoiban;
        int soluong;
        public frmNhapSoLuong(string makhachhang,string masanpham,string tensanpham,string nguoiban)
        {
            InitializeComponent();
            this.makhachhang = makhachhang;
            this.masanpham = masanpham;
            this.tensanpham = tensanpham;
            this.nguoiban = nguoiban;
            txtMasanpham.Text = masanpham;
            txtTensanpham.Text = tensanpham;
            txtNguoiban.Text = nguoiban;
        }
        SqlConnection conn = null;
        string strConn = "Data Source=RYYN;Initial Catalog=Store;Integrated Security=True";
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn hủy bỏ thao tác!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnHoantat_Click(object sender, EventArgs e)
        {
            if (txtSoluong.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập số lượng muốn mua!");
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
                    this.soluong = Int32.Parse(txtSoluong.Text);
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "addOrderAss";
                    sqlCommand.Connection = conn;
                    sqlCommand.Parameters.Add("@makhachhang", SqlDbType.VarChar, 10).Value = this.makhachhang;
                    sqlCommand.Parameters.Add("@tongsanpham", SqlDbType.Int).Value = 0;
                    sqlCommand.Parameters.Add("@tonggiatien", SqlDbType.Decimal, 10).Value = 0;
                   
                    sqlCommand.Parameters.Add("@result", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                    int ret = sqlCommand.ExecuteNonQuery();
                    if (ret < 0)
                    {
                        MessageBox.Show(sqlCommand.Parameters["@result"].Value.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Thêm đơn hàng thành công");
                        this.Close();
                           
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}
