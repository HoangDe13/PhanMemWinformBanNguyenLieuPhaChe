namespace DeTai
{
    partial class HoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deTai1DataSet = new DeTai.DeTai1DataSet();
            this.sanPhamTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamTableTableAdapter = new DeTai.DeTai1DataSetTableAdapters.SanPhamTableTableAdapter();
            this.tableAdapterManager = new DeTai.DeTai1DataSetTableAdapters.TableAdapterManager();
            this.hoaDonTableTableAdapter = new DeTai.DeTai1DataSetTableAdapters.HoaDonTableTableAdapter();
            this.thongTinHoaDonTableTableAdapter = new DeTai.DeTai1DataSetTableAdapters.ThongTinHoaDonTableTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thongTinHoaDonTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.lBTenNhanVien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deTai1DataSet1 = new DeTai.DeTai1DataSet1();
            this.baoCaoCaTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baoCaoCaTableTableAdapter = new DeTai.DeTai1DataSet1TableAdapters.BaoCaoCaTableTableAdapter();
            this.tableAdapterManager1 = new DeTai.DeTai1DataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTai1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinHoaDonTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTai1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoCaTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn1,
            this.ngayBanDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.hoaDonTableBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(74, 529);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(452, 27);
            this.dataGridView2.TabIndex = 1;
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "Mã Hóa Đơn";
            this.maHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            this.maHDDataGridViewTextBoxColumn.Width = 116;
            // 
            // giaDataGridViewTextBoxColumn1
            // 
            this.giaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giaDataGridViewTextBoxColumn1.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn1.HeaderText = "Giá";
            this.giaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.giaDataGridViewTextBoxColumn1.Name = "giaDataGridViewTextBoxColumn1";
            // 
            // ngayBanDataGridViewTextBoxColumn
            // 
            this.ngayBanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayBanDataGridViewTextBoxColumn.DataPropertyName = " NgayBan";
            this.ngayBanDataGridViewTextBoxColumn.HeaderText = "Ngày Bán";
            this.ngayBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayBanDataGridViewTextBoxColumn.Name = "ngayBanDataGridViewTextBoxColumn";
            // 
            // hoaDonTableBindingSource
            // 
            this.hoaDonTableBindingSource.DataMember = "HoaDonTable";
            this.hoaDonTableBindingSource.DataSource = this.deTai1DataSet;
            // 
            // deTai1DataSet
            // 
            this.deTai1DataSet.DataSetName = "DeTai1DataSet";
            this.deTai1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanPhamTableBindingSource
            // 
            this.sanPhamTableBindingSource.DataMember = "SanPhamTable";
            this.sanPhamTableBindingSource.DataSource = this.deTai1DataSet;
            // 
            // sanPhamTableTableAdapter
            // 
            this.sanPhamTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DanhMucTableTableAdapter = null;
            this.tableAdapterManager.HoaDonTableTableAdapter = this.hoaDonTableTableAdapter;
            this.tableAdapterManager.NhanVienTableTableAdapter = null;
            this.tableAdapterManager.SanPhamTableTableAdapter = this.sanPhamTableTableAdapter;
            this.tableAdapterManager.ThongTinHoaDonTableTableAdapter = this.thongTinHoaDonTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = DeTai.DeTai1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hoaDonTableTableAdapter
            // 
            this.hoaDonTableTableAdapter.ClearBeforeFill = true;
            // 
            // thongTinHoaDonTableTableAdapter
            // 
            this.thongTinHoaDonTableTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.thongTinHoaDonTableBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(27, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 325);
            this.dataGridView1.TabIndex = 2;
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã Sản Phẩm";
            this.maSPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            this.maSPDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "Tên Sản Phẩm";
            this.tenSPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.Width = 91;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.giaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            this.giaDataGridViewTextBoxColumn.Width = 59;
            // 
            // thongTinHoaDonTableBindingSource
            // 
            this.thongTinHoaDonTableBindingSource.DataMember = "ThongTinHoaDonTable";
            this.thongTinHoaDonTableBindingSource.DataSource = this.deTai1DataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 49);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hóa Đơn";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(401, 562);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(112, 22);
            this.tbDate.TabIndex = 7;
            // 
            // tbGia
            // 
            this.tbGia.Location = new System.Drawing.Point(267, 562);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(99, 22);
            this.tbGia.TabIndex = 8;
            // 
            // lBTenNhanVien
            // 
            this.lBTenNhanVien.AutoSize = true;
            this.lBTenNhanVien.Location = new System.Drawing.Point(141, 91);
            this.lBTenNhanVien.Name = "lBTenNhanVien";
            this.lBTenNhanVien.Size = new System.Drawing.Size(74, 17);
            this.lBTenNhanVien.TabIndex = 11;
            this.lBTenNhanVien.Text = "Họ và Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên Nhân Viên: ";
            // 
            // tbMaHD
            // 
            this.tbMaHD.Location = new System.Drawing.Point(152, 562);
            this.tbMaHD.Name = "tbMaHD";
            this.tbMaHD.Size = new System.Drawing.Size(64, 22);
            this.tbMaHD.TabIndex = 13;
            // 
            // btnDongY
            // 
            this.btnDongY.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.Location = new System.Drawing.Point(181, 617);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(188, 46);
            this.btnDongY.TabIndex = 14;
            this.btnDongY.Text = "Đồng ý ";
            this.btnDongY.UseVisualStyleBackColor = false;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(43, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 75);
            this.panel1.TabIndex = 15;
            // 
            // deTai1DataSet1
            // 
            this.deTai1DataSet1.DataSetName = "DeTai1DataSet1";
            this.deTai1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baoCaoCaTableBindingSource
            // 
            this.baoCaoCaTableBindingSource.DataMember = "BaoCaoCaTable";
            this.baoCaoCaTableBindingSource.DataSource = this.deTai1DataSet1;
            // 
            // baoCaoCaTableTableAdapter
            // 
            this.baoCaoCaTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BaoCaoCaTableTableAdapter = this.baoCaoCaTableTableAdapter;
            this.tableAdapterManager1.UpdateOrder = DeTai.DeTai1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 684);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.tbMaHD);
            this.Controls.Add(this.lBTenNhanVien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbGia);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.DoubleBuffered = true;
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTai1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinHoaDonTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTai1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoCaTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private DeTai1DataSet deTai1DataSet;
        private System.Windows.Forms.BindingSource sanPhamTableBindingSource;
        private DeTai1DataSetTableAdapters.SanPhamTableTableAdapter sanPhamTableTableAdapter;
        private DeTai1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DeTai1DataSetTableAdapters.HoaDonTableTableAdapter hoaDonTableTableAdapter;
        private System.Windows.Forms.BindingSource hoaDonTableBindingSource;
        private DeTai1DataSetTableAdapters.ThongTinHoaDonTableTableAdapter thongTinHoaDonTableTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource thongTinHoaDonTableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.Label lBTenNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbMaHD;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Panel panel1;
        private DeTai1DataSet1 deTai1DataSet1;
        private System.Windows.Forms.BindingSource baoCaoCaTableBindingSource;
        private DeTai1DataSet1TableAdapters.BaoCaoCaTableTableAdapter baoCaoCaTableTableAdapter;
        private DeTai1DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
    }
}