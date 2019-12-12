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
    public partial class frmThemDoiTacSanPham : Form
    {
        public frmThemDoiTacSanPham()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn hủy bỏ thao tác ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThemsanpham_Click(object sender, EventArgs e)
        {
            if (txtMadoitac.Text=="")
            {
                MessageBox.Show("Vui lòng nhập mã đối tác!");
            }
            else if (txtTencuahang.Text=="")
            {
                MessageBox.Show("Vui lòng nhập tên cửa hàng!");
            }
            else if (txtHoten.Text=="")
            {
                MessageBox.Show("Vui lòng nhập họ tên chủ cửa hàng!");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ Email!");
            }
            else if (txtMasokinhdoanh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã số kinh doanh!");
            }
            else if (txtDiachi.Text=="")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!");
            }
           
            else
            {
                frmThemSanPham frmThemsanpham = new frmThemSanPham();
                frmThemsanpham.SendInfoEvent += frmThemsanpham_SendInfoEvent;
                frmThemsanpham.ShowDialog();
            }
            
        }
        void frmThemsanpham_SendInfoEvent(string masanpham,string tensanpham,string xuatxu,long gianiemyet,string loaisanpham)
        {
            ListViewItem lvi = new ListViewItem(masanpham);
            lvi.SubItems.Add(tensanpham);
            lvi.SubItems.Add(xuatxu);
            lvi.SubItems.Add(gianiemyet.ToString());
            lvi.SubItems.Add(loaisanpham);
            lvSanpham.Items.Add(lvi);

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lvSanpham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-DJ5NDDL\\KTANTSQLSERVER;Initial Catalog=Store;Integrated Security=True";
        private void btnHoantat_Click(object sender, EventArgs e)
        {
            int numProduct = lvSanpham.Items.Count;
            if (numProduct==0)
            {
                MessageBox.Show("Bạn chưa thêm sản phẩm nào!");
            }
            else
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
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "themDoiTacRyyn";
                    sqlCommand.Connection = conn;

                    SqlParameter paraMadoitac = new SqlParameter("@madoitac", SqlDbType.VarChar, 10);
                    paraMadoitac.Value = txtMadoitac.Text;
                    sqlCommand.Parameters.Add(paraMadoitac);
                    SqlParameter paraTencuahang = new SqlParameter("@tencuahang", SqlDbType.NVarChar, 100);
                    paraTencuahang.Value = txtTencuahang.Text;
                    sqlCommand.Parameters.Add(paraTencuahang);
                    SqlParameter paraHoten = new SqlParameter("@hoten", SqlDbType.NVarChar, 100);
                    paraHoten.Value = txtHoten.Text;
                    sqlCommand.Parameters.Add(paraHoten);
                    SqlParameter paraNgaysinh = new SqlParameter("@ngaysinh", SqlDbType.Date);
                    paraNgaysinh.Value = dtpNgaysinh.Value;
                    sqlCommand.Parameters.Add(paraNgaysinh);
                    SqlParameter paraEmail = new SqlParameter("@email", SqlDbType.VarChar, 100);
                    paraEmail.Value = txtEmail.Text;
                    sqlCommand.Parameters.Add(paraEmail);
                    SqlParameter paraSodienthoai = new SqlParameter("@sodienthoai", SqlDbType.VarChar, 10);
                    paraSodienthoai.Value = txtSodienthoai.Text;
                    sqlCommand.Parameters.Add(paraSodienthoai);
                    SqlParameter paraMSkinhdoanh = new SqlParameter("@mskd", SqlDbType.VarChar, 10);
                    paraMSkinhdoanh.Value = txtMasokinhdoanh.Text;
                    sqlCommand.Parameters.Add(paraMSkinhdoanh);
                    SqlParameter paraDiachi = new SqlParameter("@diachi", SqlDbType.NVarChar, 100);
                    paraDiachi.Value = txtDiachi.Text;
                    sqlCommand.Parameters.Add(paraDiachi);

                    sqlCommand.Parameters.Add("@result", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                    int ret = sqlCommand.ExecuteNonQuery();
                    MessageBox.Show(sqlCommand.Parameters["@result"].Value.ToString());
                    if (ret>0)
                    {
                        txtDiachi.Text = "";
                        txtEmail.Text = "";
                        txtHoten.Text = "";
                        txtMadoitac.Text = "";
                        txtMasokinhdoanh.Text = "";
                        txtSodienthoai.Text = "";
                        txtTencuahang.Text = "";
                        lvSanpham.Items.Clear();
                    }                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void lvSanpham_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
