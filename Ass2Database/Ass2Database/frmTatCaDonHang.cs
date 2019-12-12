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
    public partial class frmTatCaDonHang : Form
    {
        SqlConnection conn = null;
        string strConn = "Data Source=RYYN;Initial Catalog=Store;Integrated Security=True";
        public void getListOrder()
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
                sqlCommand.CommandText = "select * from tblDH";
                sqlCommand.Connection = conn;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                lvDonhang.Items.Clear();
                while (sqlReader.Read())
                {
                    ListViewItem lvi = new ListViewItem(sqlReader.GetString(0));
                    lvi.SubItems.Add(sqlReader.GetString(1));
                    lvi.SubItems.Add(sqlReader.GetString(2));
                    lvi.SubItems.Add(sqlReader.GetInt32(3).ToString());
                    lvi.SubItems.Add(sqlReader.GetDecimal(4).ToString());
                    lvi.SubItems.Add(sqlReader.GetString(5));
                    lvi.SubItems.Add(sqlReader.GetString(6));
                    lvDonhang.Items.Add(lvi);
                }
                sqlReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public frmTatCaDonHang()
        {
            InitializeComponent();
            getListOrder();

        }
        
        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thật sự muốn đóng!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if (lvDonhang.SelectedItems.Count==1)
            {
                string madonhang = lvDonhang.SelectedItems[0].SubItems[0].Text;
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa đơn hàng: " + madonhang, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
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
                        sqlCommand.CommandText = "delete from tblDH where madonhang=@madonhang";
                        sqlCommand.Connection = conn;
                        sqlCommand.Parameters.Add("@madonhang", SqlDbType.VarChar, 10).Value = madonhang;
                        int ret = sqlCommand.ExecuteNonQuery();
                        if (ret > 0)
                        {
                            MessageBox.Show("Xóa đơn hàng thành công");
                            getListOrder();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                

            }
            else if (lvDonhang.SelectedItems.Count>1)
            {
                MessageBox.Show("Lựa chọn không hợp lệ!");
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đơn hàng cần xóa!");
            }
        }
        string madonhang;
        string trangthai;
        string makhachhang;
        int tongsanpham;
        long tongtien;
        string diachigui;
        string diachinhan;
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (lvDonhang.SelectedItems.Count == 1)
            {
                this.madonhang = lvDonhang.SelectedItems[0].SubItems[0].Text;
                this.trangthai = lvDonhang.SelectedItems[0].SubItems[1].Text;
                this.makhachhang = lvDonhang.SelectedItems[0].SubItems[2].Text;
                this.tongsanpham = Int32.Parse(lvDonhang.SelectedItems[0].SubItems[3].Text);
                this.tongtien = Int32.Parse (lvDonhang.SelectedItems[0].SubItems[4].Text);
                this.diachigui = lvDonhang.SelectedItems[0].SubItems[5].Text;
                this.diachinhan = lvDonhang.SelectedItems[0].SubItems[6].Text;
                frmCapNhatDonHang frmcapnhatDonHang = new frmCapNhatDonHang(this.madonhang,this.trangthai,this.makhachhang,this.tongsanpham,this.tongtien,this.diachigui,this.diachinhan);
                frmcapnhatDonHang.ShowDialog();
                getListOrder();


            }
            else if (lvDonhang.SelectedItems.Count > 1)
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
