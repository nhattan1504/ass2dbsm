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
    public partial class frmCapNhatDtsp : Form
    {
        string madanhmuc;
        string madoitac;
        string masanpham;
        decimal gia;
        int soluong;
        public frmCapNhatDtsp(string madanhmuc, string madoitac, string masanpham, decimal gia, int soluong)
        {
            InitializeComponent();
            this.madanhmuc = madanhmuc;
            this.madoitac = madoitac;
            this.masanpham = masanpham;
            this.gia = gia;
            this.soluong = soluong;
            txtGia.Text = gia.ToString();
            txtSoluong.Text = soluong.ToString();
            
        }
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-DJ5NDDL\\KTANTSQLSERVER;Initial Catalog=Store;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
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
                this.gia = decimal.Parse(txtGia.Text);
                this.soluong = Int32.Parse(txtSoluong.Text);
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "update tblDMDT set gianiemyet=@gia,soluong=@soluong where masanpham=@masanpham";
                sqlCommand.Connection = conn;
                //sqlCommand.Parameters.Add("@madanhmuc", SqlDbType.VarChar, 10).Value = this.madanhmuc;
                sqlCommand.Parameters.Add("@gia", SqlDbType.Decimal).Value = this.gia;
                sqlCommand.Parameters.Add("@soluong", SqlDbType.Int).Value = this.soluong;
                sqlCommand.Parameters.Add("@masanpham", SqlDbType.VarChar,10).Value = this.masanpham;
                int ret = sqlCommand.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Cập nhật thông tin thành công cho sản phẩm: " + this.masanpham);
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
