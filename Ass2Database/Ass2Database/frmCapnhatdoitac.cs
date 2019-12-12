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
    public partial class frmCapnhatdoitac : Form
    {
        string madotac;
        string tencuahang;
        string hoten;
        DateTime ngaysinh;
        string email;
        string sodienthoai;
        string mskd;
        string diachi;

        public frmCapnhatdoitac(string madoitac,string tencuahang,string hoten,DateTime ngaysinh,string email,string sodienthoai,string mskd,string diachi)
        {
            this.madotac = madoitac;
            this.tencuahang = tencuahang;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.email = email;
            this.sodienthoai = sodienthoai;
            this.mskd = mskd;
            this.diachi = diachi;
            InitializeComponent();
            txtMadoitac.Text = this.madotac;
            txtTencuahang.Text = this.tencuahang;
            txtHoten.Text = this.hoten;
            dtpNgaysinh.Value=this.ngaysinh;
            txtEmail.Text = this.email;
            txtSodienthoai.Text = this.sodienthoai;
            txtMskd.Text = this.mskd;
            txtDiachi.Text = this.diachi;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn hủy thao tác", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr==DialogResult.Yes)
            {
                this.Close();
            }
        }
        SqlConnection conn = null;
        string strConn = "Data Source=RYYN;Initial Catalog=Store;Integrated Security=True";
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            this.tencuahang = txtTencuahang.Text;
            this.hoten = txtHoten.Text;
            this.ngaysinh = dtpNgaysinh.Value;
            this.email = txtEmail.Text;
            this.sodienthoai = txtSodienthoai.Text;
            this.mskd = txtMskd.Text;
            this.diachi = txtDiachi.Text;
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
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "update tblDT set tencuahang=@tencuahang,hoten=@hoten,ngaysinh=@ngaysinh,email=@email,sodienthoai=@sodienthoai,mskd=@mskd,diachi=@diachi where madoitac=@madoitac";
                sqlCommand.Connection = conn;
                sqlCommand.Parameters.Add("@madoitac", SqlDbType.VarChar, 10).Value = this.madotac;
                sqlCommand.Parameters.Add("@tencuahang", SqlDbType.NVarChar, 100).Value = this.tencuahang;
                sqlCommand.Parameters.Add("@hoten", SqlDbType.NVarChar, 100).Value = this.hoten;
                sqlCommand.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = this.ngaysinh;
                sqlCommand.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = this.email;
                sqlCommand.Parameters.Add("@sodienthoai", SqlDbType.VarChar, 10).Value = this.sodienthoai;
                sqlCommand.Parameters.Add("@mskd", SqlDbType.VarChar, 10).Value = this.mskd;
                sqlCommand.Parameters.Add("@diachi", SqlDbType.NVarChar, 100).Value = this.diachi;
                int ret = sqlCommand.ExecuteNonQuery();
                if (ret>0)
                {
                    MessageBox.Show("Cập nhật thông tin thành công cho đối tác: " + this.madotac);
                    this.Close();
                    //frmThongTinDoiTac frmThongTin = new frmThongTinDoiTac();
                    //frmThongTin.ShowDialog();
                    
                }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
