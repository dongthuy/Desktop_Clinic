namespace Clinix
{
    partial class frmQLThanhToan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLThanhToan));
            this.lblMaBN = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboMaPK = new System.Windows.Forms.ComboBox();
            this.cboMaBN = new System.Windows.Forms.ComboBox();
            this.lblMaPK = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuKham = new System.Windows.Forms.DataGridView();
            this.dgvPhieuChiDinh = new System.Windows.Forms.DataGridView();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuKham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuChiDinh)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaBN
            // 
            this.lblMaBN.AutoSize = true;
            this.lblMaBN.Location = new System.Drawing.Point(20, 41);
            this.lblMaBN.Name = "lblMaBN";
            this.lblMaBN.Size = new System.Drawing.Size(77, 23);
            this.lblMaBN.TabIndex = 21;
            this.lblMaBN.Text = "Mã BN:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox3.Controls.Add(this.cboMaPK);
            this.groupBox3.Controls.Add(this.cboMaBN);
            this.groupBox3.Controls.Add(this.lblMaPK);
            this.groupBox3.Controls.Add(this.lblMaBN);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.groupBox3.Location = new System.Drawing.Point(33, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(806, 83);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lọc Và Tìm Bệnh Nhân Thanh Toán";
            // 
            // cboMaPK
            // 
            this.cboMaPK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaPK.FormattingEnabled = true;
            this.cboMaPK.Location = new System.Drawing.Point(507, 38);
            this.cboMaPK.Name = "cboMaPK";
            this.cboMaPK.Size = new System.Drawing.Size(276, 30);
            this.cboMaPK.TabIndex = 41;
            this.cboMaPK.SelectedIndexChanged += new System.EventHandler(this.cboMaPK_SelectedIndexChanged);
            // 
            // cboMaBN
            // 
            this.cboMaBN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaBN.FormattingEnabled = true;
            this.cboMaBN.Location = new System.Drawing.Point(112, 38);
            this.cboMaBN.Name = "cboMaBN";
            this.cboMaBN.Size = new System.Drawing.Size(251, 30);
            this.cboMaBN.TabIndex = 40;
            this.cboMaBN.SelectedIndexChanged += new System.EventHandler(this.cboMaBN_SelectedIndexChanged);
            // 
            // lblMaPK
            // 
            this.lblMaPK.AutoSize = true;
            this.lblMaPK.Location = new System.Drawing.Point(407, 41);
            this.lblMaPK.Name = "lblMaPK";
            this.lblMaPK.Size = new System.Drawing.Size(76, 23);
            this.lblMaPK.TabIndex = 21;
            this.lblMaPK.Text = "Mã PK:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPhieuKham);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.groupBox1.Location = new System.Drawing.Point(33, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1416, 204);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Khám:";
            // 
            // dgvPhieuKham
            // 
            this.dgvPhieuKham.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvPhieuKham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPhieuKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuKham.GridColor = System.Drawing.Color.DarkGray;
            this.dgvPhieuKham.Location = new System.Drawing.Point(10, 29);
            this.dgvPhieuKham.Name = "dgvPhieuKham";
            this.dgvPhieuKham.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvPhieuKham.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieuKham.RowTemplate.Height = 24;
            this.dgvPhieuKham.Size = new System.Drawing.Size(1395, 165);
            this.dgvPhieuKham.TabIndex = 23;
            // 
            // dgvPhieuChiDinh
            // 
            this.dgvPhieuChiDinh.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvPhieuChiDinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPhieuChiDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuChiDinh.GridColor = System.Drawing.Color.DarkGray;
            this.dgvPhieuChiDinh.Location = new System.Drawing.Point(10, 29);
            this.dgvPhieuChiDinh.Name = "dgvPhieuChiDinh";
            this.dgvPhieuChiDinh.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvPhieuChiDinh.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhieuChiDinh.RowTemplate.Height = 24;
            this.dgvPhieuChiDinh.Size = new System.Drawing.Size(1395, 166);
            this.dgvPhieuChiDinh.TabIndex = 25;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnLamMoi.Location = new System.Drawing.Point(1135, 55);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(122, 44);
            this.btnLamMoi.TabIndex = 22;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnThoat.Location = new System.Drawing.Point(1305, 628);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(144, 42);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Quay Lại";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvPhieuChiDinh);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.groupBox4.Location = new System.Drawing.Point(33, 345);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1416, 206);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Phiếu Chỉ Định:";
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.BackColor = System.Drawing.Color.White;
            this.btnTaoHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnTaoHD.Location = new System.Drawing.Point(1277, 55);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(172, 44);
            this.btnTaoHD.TabIndex = 23;
            this.btnTaoHD.Text = "Thêm Hóa Đơn";
            this.btnTaoHD.UseVisualStyleBackColor = true;
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.groupBox2.Location = new System.Drawing.Point(33, 567);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 112);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ghi Chú:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(357, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "- Tiền Khám Bệnh (DV001) 200.000 - VND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(504, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "- Thành tiền = Tiền Khám Bệnh + Tiền Dịch Vụ Chỉ Định Khác";
            // 
            // frmQLThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1482, 703);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTaoHD);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Thanh Toán";
            this.Load += new System.EventHandler(this.frmQLThanhToan_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuKham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuChiDinh)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMaBN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPhieuKham;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.ComboBox cboMaBN;
        private System.Windows.Forms.DataGridView dgvPhieuChiDinh;
        private System.Windows.Forms.ComboBox cboMaPK;
        private System.Windows.Forms.Label lblMaPK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTaoHD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}