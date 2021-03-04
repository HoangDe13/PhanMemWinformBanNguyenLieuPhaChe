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
using System.Data.Common;

namespace DeTai
{

    public partial class Main : Form
    {
        int sum = 0;
        int DT=0;
        int SL = 0;
        public Main()
        {

            InitializeComponent();
            LoadDataSP1();
            LoadDataSP();

        }
        public Main(string role, string role1)
        {
            InitializeComponent();
            lBMaNhanVien.Text = role;
            lBTenNhanVien.Text = role1;
        }
        public Main(string role)
        {
            InitializeComponent();
            tbGiam.Text = role;
        }


        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiemTraAdmin f1 = new KiemTraAdmin();

            f1.Show();




        }
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnGiamGia_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DoiMK mk = new DoiMK();
            mk.Show();
        }

        private void LoadDataSP()
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
        private void LoadDataSP1()
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
        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deTai1DataSet1.BaoCaoCa1Table' table. You can move, or remove it, as needed.
            this.baoCaoCa1TableTableAdapter.Fill(this.deTai1DataSet1.BaoCaoCa1Table);
            // TODO: This line of code loads data into the 'deTai1DataSet1.BaoCaoCaTable' table. You can move, or remove it, as needed.
            this.baoCaoCaTableTableAdapter.Fill(this.deTai1DataSet1.BaoCaoCaTable);


            // TODO: This line of code loads data into the 'deTai1DataSet.SanPhamTable' table. You can move, or remove it, as needed.
            this.sanPhamTableTableAdapter.Fill(this.deTai1DataSet.SanPhamTable);
           

        }
        public void loadTK()
        {
            
        }
        private void btThemVaoHoaDon_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf; Integrated Security = True");
            SqlCommand cmd = con.CreateCommand();

            con.Open();
            cmd.CommandType = CommandType.Text;

            String query = "select * from ThongTinHoaDonTable where MaSP = '" + tbMaSP.Text.Trim() + "' ";
            SqlCommand scm = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable da = new System.Data.DataTable();
            sda.Fill(da);
            int gia = 0;

            if (da.Rows.Count > 0)
            {

                if (int.Parse(da.Rows[0][2].ToString()) == 1)
                {
                    gia = (int.Parse(tbGiaSP.Text)) * 2 * int.Parse(da.Rows[0][2].ToString());
                }
                else
                {
                    gia = int.Parse(da.Rows[0][3].ToString()) + int.Parse(tbGiaSP.Text) * int.Parse(tbstt.Text);
                }
                int soluong = int.Parse(tbstt.Text) + int.Parse(da.Rows[0][2].ToString());
                string query1 = " UPDATE ThongTinHoaDonTable set SoLuong ='" + soluong + "', Gia ='" + gia + "'  where MaSP = '" + tbMaSP.Text.Trim() + "'";
                scm = new SqlCommand(query1, con);
                sda = new SqlDataAdapter(query1, con);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
            }
            else
            {
                cmd.CommandText = "insert into ThongTinHoaDonTable values('" + tbMaSP.Text + "','" + tbTenSP.Text + "','" + tbstt.Text + "','" + int.Parse(tbGiaSP.Text) + "')";
                cmd.ExecuteNonQuery();
            }


            con.Close();
            LoadDataSP();
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf;Integrated Security=True");

        }
        private void tbThanhToan_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridviewHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbThanhToan_Click(object sender, EventArgs e)
        {


        }


        private void btnXoa_Click(object sender, EventArgs e)
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
                LoadDataSP();
                MessageBox.Show("Xóa Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sum = 0;
            tbThanhToan.Text = sum.ToString();
            tbTongThanhToan.Text = sum.ToString();


        }

        private void nDGiam_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbXoa_TextChanged(object sender, EventArgs e)
        {
            //tbXoa.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                sum += int.Parse(dataGridView1.Rows[i].Cells["CGia"].Value.ToString());
            }
            
            tbThanhToan.Text = sum.ToString();
            int giam = sum - (sum * int.Parse(tbGiam.Text) / 100);
            tbTongThanhToan.Text = giam.ToString();
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            this.sanPhamTableTableAdapter.Fill(this.deTai1DataSet.SanPhamTable);
        }
        private void tbMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTenSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Nam 2\Lap Trinh Windows\DeTai\DeTaiWinform\DeTai\DeTai\DeTai1.mdf; Integrated Security = True");
            con.Open();
            
            SqlDataAdapter sda2 = new SqlDataAdapter("select * from SanPhamTable where MaSP like '" + textBox1.Text + "%'", con);
            DataTable dt = new DataTable();
            sda2.Fill(dt);
            dataGridviewHangHoa.DataSource = dt;
            con.Close();
            
            this.sanPhamTableTableAdapter.Fill(this.deTai1DataSet.SanPhamTable);
            


        }

        private void quảnLýCaBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoCa bc = new BaoCaoCa(tbDT.Text,tbSL.Text);
            bc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            dataGridView1.Update();
        }
        private void lBMaNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                SL += int.Parse(dataGridView1.Rows[i].Cells["SoLuong"].Value.ToString());
            }
           
          
            DT += int.Parse(tbTongThanhToan.Text);
            tbDT.Text = DT.ToString();
            tbSL.Text = SL.ToString();
          
            
         
            HoaDon hd = new HoaDon(tbTongThanhToan.Text, lBTenNhanVien.Text);
            this.Hide();
            hd.ShowDialog();
            this.Show();
        }
    }
}