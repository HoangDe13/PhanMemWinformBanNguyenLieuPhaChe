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
using DeTai.DeTai1DataSetTableAdapters;

namespace DeTai
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            LoadDataHD();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deTai1DataSet.HoaDonTable' table. You can move, or remove it, as needed.
            this.hoaDonTableTableAdapter.Fill(this.deTai1DataSet.HoaDonTable);
            // TODO: This line of code loads data into the 'deTai1DataSet.SanPhamTable' table. You can move, or remove it, as needed.
            this.sanPhamTableTableAdapter.Fill(this.deTai1DataSet.SanPhamTable);
            //LoadDataDM();
            // TODO: This line of code loads data into the 'deTai1DataSet.DanhMucTable' table. You can move, or remove it, as needed.
            this.danhMucTableTableAdapter.Fill(this.deTai1DataSet.DanhMucTable);
            //LoadDataNV();
            // TODO: This line of code loads data into the 'deTai1DataSet.NhanVienTable' table. You can move, or remove it, as needed.
            this.nhanVienTableTableAdapter.Fill(this.deTai1DataSet.NhanVienTable);


        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf;Integrated Security=True");

            String query = "select * from NhanVienTable where MaNV = '" + tbMaNV.Text.Trim() + "' ";
            SqlCommand scm = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable da = new System.Data.DataTable();
            sda.Fill(da);
            nhanVienTableTableAdapter.Update(deTai1DataSet);
            if (da.Rows.Count == 0)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into NhanVienTable values('" + tbMaNV.Text + "','" + tbTenNhanVien.Text + "','" + tbMatKhau.Text + "','" + cbChucVu.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                LoadDataNV();

                MessageBox.Show("Thêm Nhân Viên Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mã Nhân Viên Bị Trùng , Hãy Đổi Mã Nhân Viên Khác ", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadDataSP()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf;Integrated Security=True");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from SanPhamTable";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);
            dataGridviewHangHoa.DataSource = dt;
            con.Close();
        }
        private void LoadDataDT()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf;Integrated Security=True");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from HoaDonTable";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);
            dataGridView4.DataSource = dt;
            con.Close();
        }

        private void LoadDataNV()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf;Integrated Security=True");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from NhanVienTable";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void LoadDataDM()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf;Integrated Security=True");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from DanhMucTable";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        private void LoadDataHD()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf;Integrated Security=True");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from HoaDonTable";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);
            dataGridView4.DataSource = dt;
            con.Close();
        }
        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf;Integrated Security=True");

            String query = "select * from NhanVienTable where MaNV = '" + tbMaNV.Text.Trim() + "' ";
            SqlCommand scm = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable da = new System.Data.DataTable();
            sda.Fill(da);
            nhanVienTableTableAdapter.Update(deTai1DataSet);
            if (da.Rows.Count > 0)
            {
                string query1 = " UPDATE NhanVienTable set MaNV ='" + tbMaNV.Text + "', TenNV ='" + tbTenNhanVien.Text + "',MatKhau ='" + tbMatKhau.Text + "', ChucVu ='" + cbChucVu.Text + "' where MaNV = '" + tbMaNV.Text.Trim() + "'";
                scm = new SqlCommand(query1, con);
                sda = new SqlDataAdapter(query1, con);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                LoadDataNV();
                MessageBox.Show("Cập Nhật Nhân Viên Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Mã Nhân Viên ", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf;Integrated Security=True");

            String query = "select * from NhanVienTable where MaNV = '" + tbMaNV.Text.Trim() + "' ";
            SqlCommand scm = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable da = new System.Data.DataTable();
            sda.Fill(da);
            nhanVienTableTableAdapter.Update(deTai1DataSet);
            if (da.Rows.Count > 0)
            {
                string query1 = " Delete from NhanVienTable where MaNV = '" + tbMaNV.Text.Trim() + "'";
                scm = new SqlCommand(query1, con);
                sda = new SqlDataAdapter(query1, con);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                LoadDataNV();
                MessageBox.Show("Xóa Nhân Viên Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Mã Nhân Viên ", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThamDanhMuc_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf;Integrated Security=True");

            String query = "select * from DanhMucTable where MaDM = '" + tbMaHangHoa.Text.Trim() + "' ";
            SqlCommand scm = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable da = new System.Data.DataTable();
            sda.Fill(da);
            nhanVienTableTableAdapter.Update(deTai1DataSet);
            if (da.Rows.Count == 0)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into DanhMucTable values('" + tbMaHangHoa.Text + "','" + cbDanhMuc.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                LoadDataDM();

                MessageBox.Show("Thêm Danh Mục Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mã Danh Mục Bị Trùng , Hãy Đổi Mã Danh Mục Khác ", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaDanhMuc_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf;Integrated Security=True");

            String query = "select * from DanhMucTable where MaDM = '" + tbMaHangHoa.Text.Trim() + "' ";
            SqlCommand scm = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable da = new System.Data.DataTable();
            sda.Fill(da);
            nhanVienTableTableAdapter.Update(deTai1DataSet);
            if (da.Rows.Count > 0)
            {
                string query1 = " Delete from DanhMucTable where MaDM = '" + tbMaHangHoa.Text.Trim() + "'";
                scm = new SqlCommand(query1, con);
                sda = new SqlDataAdapter(query1, con);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                LoadDataDM();
                MessageBox.Show("Xóa Danh Mục Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Mã Danh Muc ", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaDanhMuc_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf;Integrated Security=True");

            String query = "select * from DanhMucTable where MaDM = '" + tbMaHangHoa.Text.Trim() + "' ";
            SqlCommand scm = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable da = new System.Data.DataTable();
            sda.Fill(da);
            nhanVienTableTableAdapter.Update(deTai1DataSet);
            if (da.Rows.Count > 0)
            {
                string query1 = " UPDATE DanhMucTable set MaDM ='" + tbMaHangHoa.Text + "', DanhMuc ='" + cbDanhMuc.Text + "' where MaDM = '" + tbMaHangHoa.Text.Trim() + "'";
                scm = new SqlCommand(query1, con);
                sda = new SqlDataAdapter(query1, con);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                LoadDataDM();
                MessageBox.Show("Cập Nhật Danh Mục Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Mã Danh Mục ", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf;Integrated Security=True");

            String query = "select * from SanPhamTable where MaSP = '" + tbMaSP.Text.Trim() + "' ";
            SqlCommand scm = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable da = new System.Data.DataTable();
            sda.Fill(da);
            nhanVienTableTableAdapter.Update(deTai1DataSet);
            if (da.Rows.Count == 0)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into SanPhamTable values('" + tbMaSP.Text + "','" + tBTenSP.Text + "','" + tBGiaSP.Text + "','" + tBDanhMuc.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                LoadDataSP();

                MessageBox.Show("Thêm Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mã Sản Phẩm Bị Trùng , Hãy Đổi Mã sản Phẩm Khác ", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaHangHoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf;Integrated Security=True");

            String query = "select * from SanPhamTable where MaSP = '" + tbMaSP.Text.Trim() + "' ";
            SqlCommand scm = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable da = new System.Data.DataTable();
            sda.Fill(da);
            nhanVienTableTableAdapter.Update(deTai1DataSet);
            if (da.Rows.Count > 0)
            {
                string query1 = " UPDATE SanPhamTable set MaSP ='" + tbMaSP.Text + "', TenSP ='" + tBTenSP.Text + "',Gia ='" + tBGiaSP.Text + "', DanhMuc ='" + tBDanhMuc.Text + "' where MaSP = '" + tbMaSP.Text.Trim() + "'";
                scm = new SqlCommand(query1, con);
                sda = new SqlDataAdapter(query1, con);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                LoadDataSP();
                MessageBox.Show("Cập Nhật Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Mã Sản Phẩm ", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaHangHoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf;Integrated Security=True");

            String query = "select * from SanPhamTable where MaSP = '" + tbMaSP.Text.Trim() + "' ";
            SqlCommand scm = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable da = new System.Data.DataTable();
            sda.Fill(da);
            nhanVienTableTableAdapter.Update(deTai1DataSet);
            if (da.Rows.Count > 0)
            {
                string query1 = " Delete from SanPhamTable where MaSP = '" + tbMaSP.Text.Trim() + "'";
                scm = new SqlCommand(query1, con);
                sda = new SqlDataAdapter(query1, con);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                LoadDataSP();
                MessageBox.Show("Xóa Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Mã Sản Phẩm ", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridviewHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Close();
            
           
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            int sum = 0;

            for (int i = 0; i < dataGridView4.Rows.Count - 1; i++)
            {
                sum += int.Parse(dataGridView4.Rows[i].Cells["CGia"].Value.ToString());
            }

            lbDoanhThu.Text = sum.ToString();

        }
    }

}