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
    public partial class frmThongTinDoiTac : Form
    {
        public string madoitac="";
        public string tencuahang ="";
        public string hoten ="";
        public DateTime ngaysinh;
        public string email ="";
        public string sodienthoai ="";
        public string mskd ="";
        public string diachi ="";
        SqlConnection conn = null;
        string strConn = "Data Source=RYYN;Initial Catalog=Store;Integrated Security=True";
        public frmThongTinDoiTac()
        {
            InitializeComponent();
            getList();
            
        }
        private void getList()
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
                SqlCommand sqlCommmand = new SqlCommand();
                sqlCommmand.CommandType = CommandType.Text;
                sqlCommmand.CommandText = "select * from tblDT";
                sqlCommmand.Connection = conn;

                SqlDataReader sqlReader = sqlCommmand.ExecuteReader();
                lvDoitac.Items.Clear();
                while (sqlReader.Read())
                {
                    
                    ListViewItem lvi = new ListViewItem(sqlReader.GetString(0));
                    lvi.SubItems.Add(sqlReader.GetString(1));
                    lvi.SubItems.Add(sqlReader.GetString(2));
                    lvi.SubItems.Add(sqlReader.GetString(5));
                    lvi.SubItems.Add(sqlReader.GetString(7));
                    lvDoitac.Items.Add(lvi);

                }
                sqlReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lvDoitac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn đóng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDoitac.SelectedItems.Count==1)
            {
                string madoitac = lvDoitac.SelectedItems[0].SubItems[0].Text;

                DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa đối tác: " + madoitac,"Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr==DialogResult.Yes)
                {
                    if (conn == null)
                    {
                        conn = new SqlConnection(strConn);
                    }
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlCommand sqlCommmand = new SqlCommand();
                    sqlCommmand.CommandType = CommandType.Text;
                    sqlCommmand.CommandText = "delete from tblDT where madoitac=@madoitac";
                    sqlCommmand.Connection = conn;
                    sqlCommmand.Parameters.Add("@madoitac", SqlDbType.VarChar, 10).Value = madoitac;
                    int ret = sqlCommmand.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        MessageBox.Show("Xóa thành công đối tác có mã là: " + madoitac);
                        lvDoitac.Items.Clear();
                        getList();

                    }
                    else
                    {
                        MessageBox.Show("Xóa đối tác không thành công!");
                    }
                }
                
                

            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu muốn thao tác!");
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (lvDoitac.SelectedItems.Count==1)
            {
                this.madoitac = lvDoitac.SelectedItems[0].SubItems[0].Text;
                
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
                    SqlCommand sqlCommmand = new SqlCommand();
                    sqlCommmand.CommandType = CommandType.Text;
                    sqlCommmand.CommandText = "select * from tblDT where madoitac=@madoitac";
                    sqlCommmand.Connection = conn;
                    sqlCommmand.Parameters.Add("@madoitac", SqlDbType.VarChar, 10).Value = madoitac;
                    SqlDataReader sqlReader = sqlCommmand.ExecuteReader();

                    if (sqlReader.Read())
                    {
                        this.tencuahang = sqlReader.GetString(1);
                        this.hoten = sqlReader.GetString(2);
                        this.ngaysinh = sqlReader.GetDateTime(3);
                        this.email = sqlReader.GetString(4);
                        this.sodienthoai = sqlReader.GetString(5);
                        this.mskd = sqlReader.GetString(6);
                        this.diachi = sqlReader.GetString(7);


                    }
                    sqlReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                frmCapnhatdoitac frmCapNhat = new frmCapnhatdoitac(this.madoitac, this.tencuahang, this.hoten, this.ngaysinh, this.email, this.sodienthoai, this.mskd, this.diachi);
                frmCapNhat.ShowDialog();
                getList();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu muốn thao tác!");
            }
        }
    }
}
