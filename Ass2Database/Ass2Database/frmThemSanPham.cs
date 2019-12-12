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
    public partial class frmThemSanPham : Form
    {
        public delegate void sendInfo(string masanpham, string tensanpham, string xuatxu, long gianiemyet, string loaisanpham);
        public event sendInfo SendInfoEvent;
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-DJ5NDDL\\KTANTSQLSERVER;Initial Catalog=Store;Integrated Security=True";
        public frmThemSanPham()
        {
            InitializeComponent();
            //btnHuy.Click += btnHuy_Click;
            //btnThem.Click += btnHoantat_Click;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn co muốn hủy bỏ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr==DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnHoantat_Click(object sender, EventArgs e)
        {
            if (txtMasanpham.Text=="")
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm!");
            }
            else if (txtTensanpham.Text=="")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!");
            }
            else if (txtXuatxu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập xuất xứ của sản phẩm!");
            }
            else if (txtGianiemyet.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá sản phẩm!");
            }
            else if (txtLoaisanpham.Text=="")
            {
                MessageBox.Show("Vui lòng nhập loại sản phẩm!");
            }
            else
            {
                try
                {
                    string masanpham = txtMasanpham.Text;
                    string tensanpham = txtTensanpham.Text;
                    string xuatxu = txtXuatxu.Text;
                    long gianiemyet = Int32.Parse(txtGianiemyet.Text);
                    string loaisanpham = txtLoaisanpham.Text;
                    if (SendInfoEvent != null)
                    {
                        SendInfoEvent(masanpham, tensanpham, xuatxu, gianiemyet, loaisanpham);
                        this.Close();
                    }
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
                    sqlCommand.CommandText = "add_sp";
                    sqlCommand.Connection = conn;

                    SqlParameter paraMasanpham = new SqlParameter("@Masp", SqlDbType.VarChar, 10);
                    paraMasanpham.Value = txtMasanpham.Text;
                    sqlCommand.Parameters.Add(paraMasanpham);
                    SqlParameter paraTensanpham = new SqlParameter("@Tensp", SqlDbType.NVarChar, 10);
                    paraTensanpham.Value = txtTensanpham.Text;
                    sqlCommand.Parameters.Add(paraTensanpham);
                    SqlParameter paraXuatxu = new SqlParameter("@Xuatxu", SqlDbType.VarChar, 50);
                    paraXuatxu.Value = txtXuatxu.Text;
                    sqlCommand.Parameters.Add(paraXuatxu);
                    SqlParameter paraGianiemyet = new SqlParameter("@Gianiemyet", SqlDbType.Int);
                    paraGianiemyet.Value = Int32.Parse(txtGianiemyet.Text);
                    sqlCommand.Parameters.Add(paraGianiemyet);
                    SqlParameter paraLoaisanpham = new SqlParameter("@Loaisp", SqlDbType.VarChar, 10);
                    paraLoaisanpham.Value = txtLoaisanpham.Text;
                    sqlCommand.Parameters.Add(paraLoaisanpham);
                    sqlCommand.Parameters.Add("@result", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                    int ret = sqlCommand.ExecuteNonQuery();
                    MessageBox.Show(sqlCommand.Parameters["@result"].Value.ToString());
                    if (ret > 0)
                    {
                        txtMasanpham.Text = "";
                        txtTensanpham.Text = "";
                        txtXuatxu.Text = "";
                        txtGianiemyet.Text = "";
                        txtLoaisanpham.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
               
        }
    }
}
