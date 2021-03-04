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

namespace DeTai
{
    public partial class KiemTraAdmin : Form
    {
        public KiemTraAdmin()
        {
            InitializeComponent();
        }

        private void KiemTraAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf;Integrated Security=True");
            String query = "select * from NhanVienTable where MaNV = '" + tBTenDangNhap.Text.Trim() + "' and MatKhau = '" + tBMatKhau.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable da = new System.Data.DataTable();
            sda.Fill(da);
            if (da.Rows.Count == 1)
            {
                if (da.Rows[0][3].ToString() == "0")
                {
                    Main m = new Main();
                    Admin a = new Admin();
                    this.Close();
                    m.Close();
                    
                    a.Show();
                }
                else
                {
                    MessageBox.Show("Chỉ Dành Cho Quản Lý", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bạn Nhập Sai Tài Khoản Hoặc Mật Khẩu !!", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Close();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbTaiKhoan_Click(object sender, EventArgs e)
        {

        }
    }
}