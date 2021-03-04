namespace DeTai
{
    partial class BaoCaoCa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoCa));
            this.baoCaoCaTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deTai1DataSet1 = new DeTai.DeTai1DataSet1();
            this.baoCaoCaTableTableAdapter = new DeTai.DeTai1DataSet1TableAdapters.BaoCaoCaTableTableAdapter();
            this.tableAdapterManager = new DeTai.DeTai1DataSet1TableAdapters.TableAdapterManager();
            this.tbSL = new System.Windows.Forms.Label();
            this.tbDT = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoCaTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTai1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // baoCaoCaTableBindingSource
            // 
            this.baoCaoCaTableBindingSource.DataMember = "BaoCaoCaTable";
            this.baoCaoCaTableBindingSource.DataSource = this.deTai1DataSet1;
            // 
            // deTai1DataSet1
            // 
            this.deTai1DataSet1.DataSetName = "DeTai1DataSet1";
            this.deTai1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baoCaoCaTableTableAdapter
            // 
            this.baoCaoCaTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaoCaoCa1TableTableAdapter = null;
            this.tableAdapterManager.BaoCaoCaTableTableAdapter = this.baoCaoCaTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = DeTai.DeTai1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbSL
            // 
            this.tbSL.AutoSize = true;
            this.tbSL.BackColor = System.Drawing.Color.SkyBlue;
            this.tbSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbSL.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tbSL.Location = new System.Drawing.Point(20, 172);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(273, 24);
            this.tbSL.TabIndex = 0;
            this.tbSL.Text = "Tổng Số Lượng Các Mặt hàng :";
            // 
            // tbDT
            // 
            this.tbDT.AutoSize = true;
            this.tbDT.BackColor = System.Drawing.Color.SkyBlue;
            this.tbDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbDT.Location = new System.Drawing.Point(50, 201);
            this.tbDT.Name = "tbDT";
            this.tbDT.Size = new System.Drawing.Size(244, 24);
            this.tbDT.TabIndex = 1;
            this.tbDT.Text = "Tổng Doanh Thu Trong Ca:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(300, 203);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(169, 22);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(120, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kết Ca Bán Hàng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(139, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 56);
            this.label1.TabIndex = 5;
            this.label1.Text = "BÁO CÁO CA";
            // 
            // BaoCaoCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbDT);
            this.Controls.Add(this.tbSL);
            this.Name = "BaoCaoCa";
            this.Text = "Báo Cáo ca";
            this.Load += new System.EventHandler(this.BaoCaoCa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoCaTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTai1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DeTai1DataSet1 deTai1DataSet1;
        private System.Windows.Forms.BindingSource baoCaoCaTableBindingSource;
        private DeTai1DataSet1TableAdapters.BaoCaoCaTableTableAdapter baoCaoCaTableTableAdapter;
        private DeTai1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label tbSL;
        private System.Windows.Forms.Label tbDT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}