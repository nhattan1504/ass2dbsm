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
    public partial class frmCapNhatDonHang : Form
    {
        string madonhang;
        string trangthai;
        string makhachhang;
        int tongsanpham;
        long tongtien;
        string diachigui;
        string diachinhan;
        public frmCapNhatDonHang(string madonhang,string trangthai,string makhachhang,int tongsanpham,long tongtien,string diachigui,string diachinhan)
        {
            InitializeComponent();
            this.madonhang = madonhang;
            this.trangthai = trangthai;
            this.makhachhang = makhachhang;
            this.tongsanpham = tongsanpham;
            this.tongtien = tongtien;
            this.diachigui = diachigui;
            this.diachinhan = diachinhan;
            txtDiachigui.Text = diachigui;
            txtDiachinhan.Text = diachinhan;
            txtMadonhang.Text = madonhang;
            txtMakhachhang.Text = makhachhang;
            txtTongsanpham.Text = tongsanpham.ToString();
            txtTongtien.Text = tongtien.ToString();
            txtTrangthai.Text = trangthai;
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn dừng cập nhật?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr==DialogResult.Yes)
            {
                this.Close();
            }
        }
        SqlConnection conn = null;
        string strConn = "Data Source=RYYN;Initial Catalog=Store;Integrated Security=True";
        private void btnHoantat_Click(object sender, EventArgs e)
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
                
                this.trangthai = txtTrangthai.Text;
                this.diachigui = txtDiachigui.Text;
                this.diachinhan = txtDiachinhan.Text;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "update tblDH set trangthai=@trangthai,diachigui=@diachigui,diachinhan=@diachinhan where madonhang=@madonhang";
                sqlCommand.Connection = conn;
                sqlCommand.Parameters.Add("@trangthai", SqlDbType.VarChar, 50).Value = this.trangthai;
                sqlCommand.Parameters.Add("@diachigui", SqlDbType.VarChar, 100).Value = this.diachigui;
                sqlCommand.Parameters.Add("@diachinhan", SqlDbType.VarChar, 100).Value = this.diachinhan;
                sqlCommand.Parameters.Add("@madonhang", SqlDbType.VarChar, 10).Value = this.madonhang;
                int ret = sqlCommand.ExecuteNonQuery();
                if (ret >0)
                {
                    MessageBox.Show("Cập nhật thông tin thành công cho đơn hàng: "+this.madonhang);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
