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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        public HoaDon(string Tong ,string TenNV)
        {
            InitializeComponent();
            lBTenNhanVien.Text = TenNV;
            tbGia.Text = Tong;
            tbDate.Text = DateTime.Now.ToString();
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf; Integrated Security = True");
            SqlCommand cmd = con.CreateCommand();
            String query = "select * from HoaDonTable  ";
           
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable da = new System.Data.DataTable();
            sda.Fill(da);
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into HoaDonTable values('" + "HD0 "+da.Rows.Count  + "','" + tbGia.Text + "','" + DateTime.Now+ "')";
            cmd.ExecuteNonQuery();
            tbMaHD.Text = ("HD0" + da.Rows.Count);
            con.Close();
            dataGridView1.Update();
            LoadDataSP();
            LoadDataSP1();
            
        }
        private void LoadDataSP()
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
            dataGridView2.DataSource = dt;
            con.Close();
        }
        private void LoadDataSP1()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf;Integrated Security=True");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ThongTinHoaDonTable";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deTai1DataSet1.BaoCaoCaTable' table. You can move, or remove it, as needed.
            this.baoCaoCaTableTableAdapter.Fill(this.deTai1DataSet1.BaoCaoCaTable);
            // TODO: This line of code loads data into the 'deTai1DataSet.ThongTinHoaDonTable' table. You can move, or remove it, as needed.
            this.thongTinHoaDonTableTableAdapter.Fill(this.deTai1DataSet.ThongTinHoaDonTable);
            // TODO: This line of code loads data into the 'deTai1DataSet.HoaDonTable' table. You can move, or remove it, as needed.
            this.hoaDonTableTableAdapter.Fill(this.deTai1DataSet.HoaDonTable);
            // TODO: This line of code loads data into the 'deTai1DataSet.SanPhamTable' table. You can move, or remove it, as needed.
            this.sanPhamTableTableAdapter.Fill(this.deTai1DataSet.SanPhamTable);

        }

        private void tbMaHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf; Integrated Security = True");

            String query2 = "select * from ThongTinHoaDonTable";
            SqlCommand scm2 = new SqlCommand(query2, con);
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
            DataTable da2 = new System.Data.DataTable();
            sda2.Fill(da2);
            //MessageBox.Show("Thêm Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (da2.Rows.Count > 0)
            {
                string query1 = " Delete from ThongTinHoaDonTable";
                scm2 = new SqlCommand(query1, con);
                sda2 = new SqlDataAdapter(query1, con);
                DataTable dt = new System.Data.DataTable();
                sda2.Fill(dt);
                LoadDataSP1();
                LoadDataSP();
            }
            this.Hide();
           
            
        }

      
    }
}
