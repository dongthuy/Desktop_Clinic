namespace Clinix
{
    partial class frmThemHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemHoaDon));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cboMaPK = new System.Windows.Forms.ComboBox();
            this.lblTimMaPK = new System.Windows.Forms.Label();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboMaLT = new System.Windows.Forms.ComboBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.cboHinhThuc = new System.Windows.Forms.ComboBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.dtpThoiGianTT = new System.Windows.Forms.DateTimePicker();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblMaPK = new System.Windows.Forms.Label();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.lblMaLT = new System.Windows.Forms.Label();
            this.txtMaPK = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cboMaPK);
            this.groupBox5.Controls.Add(this.lblTimMaPK);
            this.groupBox5.Controls.Add(this.btnInPhieu);
            this.groupBox5.Controls.Add(this.dgvHoaDon);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.groupBox5.Location = new System.Drawing.Point(27, 257);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1426, 434);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông Tin Hóa Đơn:";
            // 
            // cboMaPK
            // 
            this.cboMaPK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaPK.FormattingEnabled = true;
            this.cboMaPK.Location = new System.Drawing.Point(114, 42);
            this.cboMaPK.Name = "cboMaPK";
            this.cboMaPK.Size = new System.Drawing.Size(276, 30);
            this.cboMaPK.TabIndex = 43;
            this.cboMaPK.SelectedIndexChanged += new System.EventHandler(this.cboMaPK_SelectedIndexChanged);
            // 
            // lblTimMaPK
            // 
            this.lblTimMaPK.AutoSize = true;
            this.lblTimMaPK.Location = new System.Drawing.Point(28, 44);
            this.lblTimMaPK.Name = "lblTimMaPK";
            this.lblTimMaPK.Size = new System.Drawing.Size(76, 23);
            this.lblTimMaPK.TabIndex = 42;
            this.lblTimMaPK.Text = "Mã PK:";
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.BackColor = System.Drawing.Color.White;
            this.btnInPhieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnInPhieu.Location = new System.Drawing.Point(1237, 33);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(172, 39);
            this.btnInPhieu.TabIndex = 23;
            this.btnInPhieu.Text = "In Biên Lai";
            this.btnInPhieu.UseVisualStyleBackColor = true;
            this.btnInPhieu.Click += new System.EventHandler(this.btnInPhieu_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.GridColor = System.Drawing.Color.DarkGray;
            this.dgvHoaDon.Location = new System.Drawing.Point(15, 90);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(1394, 325);
            this.dgvHoaDon.TabIndex = 24;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnThoat.Location = new System.Drawing.Point(817, 179);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(172, 39);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Quay Lại";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.cboMaLT);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.cboTrangThai);
            this.groupBox2.Controls.Add(this.cboHinhThuc);
            this.groupBox2.Controls.Add(this.lblMaHD);
            this.groupBox2.Controls.Add(this.dtpThoiGianTT);
            this.groupBox2.Controls.Add(this.lblThoiGian);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.lblGhiChu);
            this.groupBox2.Controls.Add(this.lblTongTien);
            this.groupBox2.Controls.Add(this.lblTrangThai);
            this.groupBox2.Controls.Add(this.lblMaPK);
            this.groupBox2.Controls.Add(this.lblHinhThuc);
            this.groupBox2.Controls.Add(this.lblMaLT);
            this.groupBox2.Controls.Add(this.txtMaPK);
            this.groupBox2.Controls.Add(this.txtMaHD);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Location = new System.Drawing.Point(27, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1426, 239);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // cboMaLT
            // 
            this.cboMaLT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaLT.FormattingEnabled = true;
            this.cboMaLT.Location = new System.Drawing.Point(206, 123);
            this.cboMaLT.Name = "cboMaLT";
            this.cboMaLT.Size = new System.Drawing.Size(233, 30);
            this.cboMaLT.TabIndex = 12;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(727, 73);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(262, 30);
            this.cboTrangThai.TabIndex = 12;
            // 
            // cboHinhThuc
            // 
            this.cboHinhThuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHinhThuc.FormattingEnabled = true;
            this.cboHinhThuc.Location = new System.Drawing.Point(727, 123);
            this.cboHinhThuc.Name = "cboHinhThuc";
            this.cboHinhThuc.Size = new System.Drawing.Size(262, 30);
            this.cboHinhThuc.TabIndex = 12;
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.lblMaHD.Location = new System.Drawing.Point(28, 75);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(125, 23);
            this.lblMaHD.TabIndex = 6;
            this.lblMaHD.Text = "Mã Hóa Đơn:";
            // 
            // dtpThoiGianTT
            // 
            this.dtpThoiGianTT.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpThoiGianTT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGianTT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianTT.Location = new System.Drawing.Point(727, 24);
            this.dtpThoiGianTT.Name = "dtpThoiGianTT";
            this.dtpThoiGianTT.Size = new System.Drawing.Size(262, 30);
            this.dtpThoiGianTT.TabIndex = 10;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.lblThoiGian.Location = new System.Drawing.Point(493, 29);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(206, 23);
            this.lblThoiGian.TabIndex = 6;
            this.lblThoiGian.Text = "Thời Gian Thanh Toán:";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnThem.Location = new System.Drawing.Point(497, 179);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(172, 39);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.lblGhiChu.Location = new System.Drawing.Point(1041, 30);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(83, 23);
            this.lblGhiChu.TabIndex = 6;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.lblTongTien.Location = new System.Drawing.Point(1041, 125);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(103, 23);
            this.lblTongTien.TabIndex = 6;
            this.lblTongTien.Text = "Tổng Tiền:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.lblTrangThai.Location = new System.Drawing.Point(493, 80);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(110, 23);
            this.lblTrangThai.TabIndex = 6;
            this.lblTrangThai.Text = "Trạng Thái:";
            // 
            // lblMaPK
            // 
            this.lblMaPK.AutoSize = true;
            this.lblMaPK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.lblMaPK.Location = new System.Drawing.Point(28, 29);
            this.lblMaPK.Name = "lblMaPK";
            this.lblMaPK.Size = new System.Drawing.Size(151, 23);
            this.lblMaPK.TabIndex = 6;
            this.lblMaPK.Text = "Mã Phiếu Khám:";
            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinhThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.lblHinhThuc.Location = new System.Drawing.Point(493, 125);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(211, 23);
            this.lblHinhThuc.TabIndex = 6;
            this.lblHinhThuc.Text = "Hình Thức Thanh Toán:";
            // 
            // lblMaLT
            // 
            this.lblMaLT.AutoSize = true;
            this.lblMaLT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.lblMaLT.Location = new System.Drawing.Point(28, 125);
            this.lblMaLT.Name = "lblMaLT";
            this.lblMaLT.Size = new System.Drawing.Size(111, 23);
            this.lblMaLT.TabIndex = 6;
            this.lblMaLT.Text = "Mã Lễ Tân:";
            // 
            // txtMaPK
            // 
            this.txtMaPK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPK.Location = new System.Drawing.Point(206, 27);
            this.txtMaPK.Name = "txtMaPK";
            this.txtMaPK.Size = new System.Drawing.Size(233, 30);
            this.txtMaPK.TabIndex = 7;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(206, 73);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(233, 30);
            this.txtMaHD.TabIndex = 7;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(1169, 28);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(240, 76);
            this.txtGhiChu.TabIndex = 7;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(1169, 123);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(240, 30);
            this.txtTongTien.TabIndex = 7;
            // 
            // frmThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1482, 703);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThemHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Hóa Đơn";
            this.Load += new System.EventHandler(this.frmThemHoaDon_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnInPhieu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.DateTimePicker dtpThoiGianTT;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ComboBox cboMaLT;
        private System.Windows.Forms.Label lblMaPK;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.ComboBox cboHinhThuc;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblMaLT;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMaPK;
        private System.Windows.Forms.ComboBox cboMaPK;
        private System.Windows.Forms.Label lblTimMaPK;
    }
}