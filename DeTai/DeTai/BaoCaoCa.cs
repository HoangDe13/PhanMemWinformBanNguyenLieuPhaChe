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
    public partial class BaoCaoCa : Form
    {
        public BaoCaoCa()
        {
            InitializeComponent();
            LoadDataSP2();
        }
        public BaoCaoCa(string SL,string DT)
        {
            InitializeComponent();
            textBox1.Text = DT;
            textBox2.Text = SL;
        }

        private void BaoCaoCa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deTai1DataSet1.BaoCaoCaTable' table. You can move, or remove it, as needed.
            this.baoCaoCaTableTableAdapter.Fill(this.deTai1DataSet1.BaoCaoCaTable);

        }
        private void LoadDataSP2()
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
