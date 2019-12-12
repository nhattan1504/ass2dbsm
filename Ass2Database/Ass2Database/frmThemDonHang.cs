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
    public partial class frmThemDonHang : Form
    {
        SqlConnection conn = null;
        string strConn = "Data Source=RYYN;Initial Catalog=Store;Integrated Security=True";
        public frmThemDonHang()
        {
            InitializeComponent();
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
                sqlCommand.CommandText = "getDSSanPhamAss";
                sqlCommand.Connection = conn;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                lvSanPham.Items.Clear();
                while (sqlReader.Read())
                {
                    ListViewItem lvi = new ListViewItem(sqlReader.GetString(0));
                    lvi.SubItems.Add(sqlReader.GetString(1));
                    lvi.SubItems.Add(sqlReader.GetString(2));
                    lvi.SubItems.Add(sqlReader.GetDecimal(3).ToString());
                    lvi.SubItems.Add(sqlReader.GetInt32(4).ToString());
                    lvSanPham.Items.Add(lvi);
                }
                sqlReader.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn hủy bỏ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text != "")
            {
                string makhachhang = txtMaKhachHang.Text;
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
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "select * from tblKH where makhachhang=" + makhachhang;
                    sqlCommand.Connection = conn;

                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                    
                    if (sqlReader.Read())
                    {
                        sqlReader.Close();
                        if (lvSanPham.SelectedItems.Count == 1)
                        {

                            string masanpham = lvSanPham.SelectedItems[0].SubItems[0].Text;
                            string tensanpham = lvSanPham.SelectedItems[0].SubItems[1].Text;
                            string nguoiban = lvSanPham.SelectedItems[0].SubItems[2].Text;
                            frmNhapSoLuong frmnhapSoluong = new frmNhapSoLuong(makhachhang, masanpham, tensanpham, nguoiban);
                            frmnhapSoluong.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Bạn chưa chọn sản phẩm!");
                        }
                    }
                    else
                    {
                        sqlReader.Close();
                        MessageBox.Show("Mã khách hàng không tồn tại");

                    }
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng!");
            }
            
        }
    }
}
