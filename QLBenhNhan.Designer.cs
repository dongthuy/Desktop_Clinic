namespace Clinix
{
    partial class frmQLBenhNhan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLBenhNhan));
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblMaBN = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dgvDanhSachBN = new System.Windows.Forms.DataGridView();
            this.btnXuatE = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBN)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(155, 65);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(131, 30);
            this.dtpNgaySinh.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.lblMaBN);
            this.groupBox2.Controls.Add(this.dtpNgaySinh);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.lblNgaySinh);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.lblGioiTinh);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.txtMaBN);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.lblSDT);
            this.groupBox2.Controls.Add(this.lblDiaChi);
            this.groupBox2.Controls.Add(this.lblHoTen);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Location = new System.Drawing.Point(34, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1415, 309);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnTimKiem.Location = new System.Drawing.Point(1194, 250);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(172, 44);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblMaBN
            // 
            this.lblMaBN.AutoSize = true;
            this.lblMaBN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.lblMaBN.Location = new System.Drawing.Point(30, 23);
            this.lblMaBN.Name = "lblMaBN";
            this.lblMaBN.Size = new System.Drawing.Size(77, 23);
            this.lblMaBN.TabIndex = 6;
            this.lblMaBN.Text = "Mã BN:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Location = new System.Drawing.Point(1261, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 76);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(7, 41);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(56, 26);
            this.radNu.TabIndex = 9;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(7, 9);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(68, 26);
            this.radNam.TabIndex = 9;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnXoa.Location = new System.Drawing.Point(1194, 182);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(172, 44);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.lblNgaySinh.Location = new System.Drawing.Point(30, 70);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(102, 23);
            this.lblNgaySinh.TabIndex = 6;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnThem.Location = new System.Drawing.Point(331, 180);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(172, 44);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.lblGioiTinh.Location = new System.Drawing.Point(1140, 27);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(98, 23);
            this.lblGioiTinh.TabIndex = 6;
            this.lblGioiTinh.Text = "Giới Tính:";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnLuu.Location = new System.Drawing.Point(630, 182);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(172, 44);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnSua.Location = new System.Drawing.Point(918, 180);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(172, 44);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMaBN
            // 
            this.txtMaBN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBN.Location = new System.Drawing.Point(154, 20);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(131, 30);
            this.txtMaBN.TabIndex = 7;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnLamMoi.Location = new System.Drawing.Point(33, 180);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(172, 44);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.lblSDT.Location = new System.Drawing.Point(525, 74);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(54, 23);
            this.lblSDT.TabIndex = 6;
            this.lblSDT.Text = "SĐT:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.lblDiaChi.Location = new System.Drawing.Point(30, 121);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(80, 23);
            this.lblDiaChi.TabIndex = 6;
            this.lblDiaChi.Text = "Địa Chỉ:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.lblHoTen.Location = new System.Drawing.Point(524, 27);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(104, 23);
            this.lblHoTen.TabIndex = 6;
            this.lblHoTen.Text = "Họ và Tên:";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(653, 68);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(275, 30);
            this.txtSDT.TabIndex = 7;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(34, 259);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(1057, 30);
            this.txtTimKiem.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(154, 119);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(1212, 30);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(653, 24);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(275, 30);
            this.txtHoTen.TabIndex = 7;
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // dgvDanhSachBN
            // 
            this.dgvDanhSachBN.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvDanhSachBN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachBN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachBN.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachBN.GridColor = System.Drawing.Color.DarkGray;
            this.dgvDanhSachBN.Location = new System.Drawing.Point(34, 353);
            this.dgvDanhSachBN.Name = "dgvDanhSachBN";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachBN.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachBN.RowHeadersWidth = 51;
            this.dgvDanhSachBN.RowTemplate.Height = 24;
            this.dgvDanhSachBN.Size = new System.Drawing.Size(1415, 259);
            this.dgvDanhSachBN.TabIndex = 15;
            this.dgvDanhSachBN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachBN_CellClick);
            // 
            // btnXuatE
            // 
            this.btnXuatE.BackColor = System.Drawing.Color.White;
            this.btnXuatE.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnXuatE.Location = new System.Drawing.Point(1075, 638);
            this.btnXuatE.Name = "btnXuatE";
            this.btnXuatE.Size = new System.Drawing.Size(172, 39);
            this.btnXuatE.TabIndex = 12;
            this.btnXuatE.Text = "Xuất Excel";
            this.btnXuatE.UseVisualStyleBackColor = true;
            this.btnXuatE.Click += new System.EventHandler(this.btnXuatE_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnThoat.Location = new System.Drawing.Point(1277, 638);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(172, 39);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Quay Lại";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmQLBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1482, 703);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatE);
            this.Controls.Add(this.dgvDanhSachBN);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLBenhNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Bệnh Nhân";
            this.Load += new System.EventHandler(this.frmQLBenhNhan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblMaBN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvDanhSachBN;
        private System.Windows.Forms.Button btnXuatE;
        private System.Windows.Forms.Button btnThoat;
    }
}