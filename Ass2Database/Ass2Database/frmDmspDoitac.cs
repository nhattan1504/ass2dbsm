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
    public partial class frmDmspDoitac : Form
    {
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-DJ5NDDL\\KTANTSQLSERVER;Initial Catalog=Store;Integrated Security=True";

        public void getList()
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
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT * FROM tblDMDT";
                sqlCommand.Connection = conn;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                lvDtsp.Items.Clear();
                while (sqlReader.Read())
                {
                    ListViewItem lvi = new ListViewItem(sqlReader.GetString(0));
                    lvi.SubItems.Add(sqlReader.GetString(1));
                    lvi.SubItems.Add(sqlReader.GetString(2));
                    lvi.SubItems.Add(sqlReader.GetDecimal(3).ToString());
                    lvi.SubItems.Add(sqlReader.GetInt32(4).ToString());
                    lvDtsp.Items.Add(lvi);
                }
                sqlReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public frmDmspDoitac()
        {
            InitializeComponent();
            getList();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        string madanhmuc;
        string madoitac;
        string masanpham;
        decimal gia;
        int soluong;
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (lvDtsp.SelectedItems.Count == 1)
            {
                this.madanhmuc = lvDtsp.SelectedItems[0].SubItems[0].Text;
                this.madoitac = lvDtsp.SelectedItems[0].SubItems[1].Text;
                this.masanpham = lvDtsp.SelectedItems[0].SubItems[2].Text;
                this.gia= decimal.Parse(lvDtsp.SelectedItems[0].SubItems[3].Text);
                this.soluong = Int32.Parse(lvDtsp.SelectedItems[0].SubItems[4].Text);
                frmCapNhatDtsp frmcapnhatDtsp = new frmCapNhatDtsp(this.madanhmuc, this.madoitac, this.masanpham, this.gia, this.soluong);
                frmcapnhatDtsp.ShowDialog();
                getList();


            }
            else if (lvDtsp.SelectedItems.Count > 1)
            {
                MessageBox.Show("Lựa chọn không hợp lệ!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDtsp.SelectedItems.Count == 1)
            {
                string masanpham = lvDtsp.SelectedItems[0].SubItems[1].Text;
                DialogResult yn = MessageBox.Show("Bạn có muốn xóa đơn hàng: " + masanpham, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (yn == DialogResult.Yes)
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
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = "delete from tblDMDT where masanpham=@masp";
                        sqlCommand.Connection = conn;
                        sqlCommand.Parameters.Add("@masp", SqlDbType.VarChar, 10).Value = masanpham;
                        int ret = sqlCommand.ExecuteNonQuery();
                        if (ret > 0)
                        {
                            MessageBox.Show("Xóa sản phẩm thành công");
                            getList();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }


            }
            else if (lvDtsp.SelectedItems.Count > 1)
            {
                MessageBox.Show("Lựa chọn không hợp lệ!");
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đơn hàng cần xóa!");
            }
        }
    }
}
