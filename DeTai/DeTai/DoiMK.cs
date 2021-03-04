using DeTai.DeTai1DataSetTableAdapters;
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
using System.Data;

namespace DeTai
{
    public partial class DoiMK : Form
    {
        DeTai1DataSet deTai1 = new DeTai1DataSet();
        public DoiMK()
        {
            InitializeComponent();
        }
      
          
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf;Integrated Security=True");
            
            String query = "select * from NhanVienTable where MaNV = '" + tBTenDangNhap.Text.Trim() + "' and MatKhau = '" + tBMatKhau.Text.Trim() + "'";
            SqlCommand scm = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            
            DataTable da = new System.Data.DataTable();
            sda.Fill(da);
            if (da.Rows.Count == 1)
            {
                string query1 = " UPDATE NhanVienTable set MatKhau ='" +tbMatKhauMoi.Text+ "' where MaNV = '" + tBTenDangNhap.Text.Trim() + "'";
                scm = new SqlCommand(query1, con);
                sda = new SqlDataAdapter(query1, con);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                MessageBox.Show("Đã Thay Đổi Thành Công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }    
            else
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại Tài Khoản Hoặc Mật Khẩu ", "Lỗi" ,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
