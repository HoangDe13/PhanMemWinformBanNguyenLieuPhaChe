namespace DeTai
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nhanVienTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deTai1DataSet = new DeTai.DeTai1DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.tBMatKhau = new System.Windows.Forms.TextBox();
            this.tBTenDangNhap = new System.Windows.Forms.TextBox();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTai1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nhanVienTableBindingSource
            // 
            this.nhanVienTableBindingSource.DataMember = "NhanVienTable";
            this.nhanVienTableBindingSource.DataSource = this.deTai1DataSet;
            // 
            // deTai1DataSet
            // 
            this.deTai1DataSet.DataSetName = "DeTai1DataSet";
            this.deTai1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(226, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 36);
            this.label1.TabIndex = 27;
            this.label1.Text = "Đăng Nhập";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.ForeColor = System.Drawing.Color.Navy;
            this.btnThoat.Location = new System.Drawing.Point(305, 186);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(121, 40);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDangNhap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDangNhap.ForeColor = System.Drawing.Color.Navy;
            this.btnDangNhap.Location = new System.Drawing.Point(142, 187);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(121, 40);
            this.btnDangNhap.TabIndex = 25;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click_1);
            // 
            // tBMatKhau
            // 
            this.tBMatKhau.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tBMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tBMatKhau.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.tBMatKhau.Location = new System.Drawing.Point(271, 139);
            this.tBMatKhau.Name = "tBMatKhau";
            this.tBMatKhau.PasswordChar = '*';
            this.tBMatKhau.Size = new System.Drawing.Size(244, 26);
            this.tBMatKhau.TabIndex = 24;
            // 
            // tBTenDangNhap
            // 
            this.tBTenDangNhap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tBTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tBTenDangNhap.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.tBTenDangNhap.Location = new System.Drawing.Point(271, 96);
            this.tBTenDangNhap.Name = "tBTenDangNhap";
            this.tBTenDangNhap.Size = new System.Drawing.Size(244, 26);
            this.tBTenDangNhap.TabIndex = 22;
            this.tBTenDangNhap.TextChanged += new System.EventHandler(this.tBTenDangNhap_TextChanged);
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiKhoan.ForeColor = System.Drawing.Color.Purple;
            this.lbTaiKhoan.Location = new System.Drawing.Point(48, 91);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(177, 26);
            this.lbTaiKhoan.TabIndex = 21;
            this.lbTaiKhoan.Text = "Tên Đăng Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LemonChiffon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(48, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 26);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mật Khẩu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.CausesValidation = false;
            this.panel1.ForeColor = System.Drawing.Color.Chocolate;
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 82);
            this.panel1.TabIndex = 30;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(669, 298);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.tBMatKhau);
            this.Controls.Add(this.tBTenDangNhap);
            this.Controls.Add(this.lbTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Đăng Nhập";
            this.TransparencyKey = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTai1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DeTai1DataSet deTai1DataSet;
        private System.Windows.Forms.BindingSource nhanVienTableBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox tBMatKhau;
        private System.Windows.Forms.TextBox tBTenDangNhap;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}

