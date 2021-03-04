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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf;Integrated Security=True");
            String query = "select * from NhanVienTable where MaNV = '" + tBTenDangNhap.Text.Trim() + "' and MatKhau = '" + tBMatKhau.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable da = new System.Data.DataTable();
            sda.Fill(da);
            if (da.Rows.Count == 1)
            {

                DialogResult rs = MessageBox.Show("Mở Ca Bán Hàng Với Nhân Viên "+ da.Rows[0][1].ToString() , "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {

                    Main f1 = new Main(da.Rows[0][0].ToString(), da.Rows[0][1].ToString());

                    this.Hide();
                    f1.ShowDialog();
                    this.Show();
                    
                }
                   
            }
            else
            {
                MessageBox.Show("Bạn Nhập Sai Tài Khoản Hoặc Mật Khẩu !!", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có muốn thoát không ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tBTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
