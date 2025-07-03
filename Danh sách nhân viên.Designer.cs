namespace Clinix
{
    partial class frmDanhSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSach));
            this.btnTimfrmDS = new System.Windows.Forms.Button();
            this.dgvDanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.txtTimfrmDS = new System.Windows.Forms.TextBox();
            this.btnThemfrmDS = new System.Windows.Forms.Button();
            this.btnXoafrmDS = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnDongfrmDS = new System.Windows.Forms.Button();
            this.btnXuatfrmDS = new System.Windows.Forms.Button();
            this.ttTimfrmDS = new System.Windows.Forms.ToolTip(this.components);
            this.ttTimThuoc = new System.Windows.Forms.ToolTip(this.components);
            this.ttXemChiTiet = new System.Windows.Forms.ToolTip(this.components);
            this.lblLoaiNguoiDung = new System.Windows.Forms.Label();
            this.cbLoaiNguoiDungfrmDS = new System.Windows.Forms.ComboBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNDfrmDS = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTenfrmDS = new System.Windows.Forms.TextBox();
            this.gbND = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).BeginInit();
            this.gbND.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimfrmDS
            // 
            this.btnTimfrmDS.BackColor = System.Drawing.Color.White;
            this.btnTimfrmDS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimfrmDS.Location = new System.Drawing.Point(800, 485);
            this.btnTimfrmDS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTimfrmDS.Name = "btnTimfrmDS";
            this.btnTimfrmDS.Size = new System.Drawing.Size(122, 33);
            this.btnTimfrmDS.TabIndex = 2;
            this.btnTimfrmDS.Text = "Tìm kiếm";
            this.btnTimfrmDS.UseVisualStyleBackColor = true;
            this.btnTimfrmDS.Click += new System.EventHandler(this.btnTimfrmDS_Click);
            // 
            // dgvDanhSachNhanVien
            // 
            this.dgvDanhSachNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNhanVien.Location = new System.Drawing.Point(45, 145);
            this.dgvDanhSachNhanVien.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            this.dgvDanhSachNhanVien.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDanhSachNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachNhanVien.RowTemplate.Height = 24;
            this.dgvDanhSachNhanVien.Size = new System.Drawing.Size(877, 323);
            this.dgvDanhSachNhanVien.TabIndex = 4;
            this.dgvDanhSachNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachNhanVien_CellClick);
            // 
            // txtTimfrmDS
            // 
            this.txtTimfrmDS.Location = new System.Drawing.Point(45, 485);
            this.txtTimfrmDS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTimfrmDS.Multiline = true;
            this.txtTimfrmDS.Name = "txtTimfrmDS";
            this.txtTimfrmDS.Size = new System.Drawing.Size(745, 33);
            this.txtTimfrmDS.TabIndex = 11;
            this.ttTimfrmDS.SetToolTip(this.txtTimfrmDS, "Nhập tên nhân viên");
            // 
            // btnThemfrmDS
            // 
            this.btnThemfrmDS.BackColor = System.Drawing.Color.White;
            this.btnThemfrmDS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemfrmDS.Location = new System.Drawing.Point(966, 223);
            this.btnThemfrmDS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnThemfrmDS.Name = "btnThemfrmDS";
            this.btnThemfrmDS.Size = new System.Drawing.Size(122, 40);
            this.btnThemfrmDS.TabIndex = 12;
            this.btnThemfrmDS.Text = "Thêm";
            this.btnThemfrmDS.UseVisualStyleBackColor = true;
            this.btnThemfrmDS.Click += new System.EventHandler(this.btnThemfrmDS_Click);
            // 
            // btnXoafrmDS
            // 
            this.btnXoafrmDS.BackColor = System.Drawing.Color.White;
            this.btnXoafrmDS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoafrmDS.Location = new System.Drawing.Point(966, 271);
            this.btnXoafrmDS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnXoafrmDS.Name = "btnXoafrmDS";
            this.btnXoafrmDS.Size = new System.Drawing.Size(122, 40);
            this.btnXoafrmDS.TabIndex = 15;
            this.btnXoafrmDS.Text = "Xoá";
            this.btnXoafrmDS.UseVisualStyleBackColor = true;
            this.btnXoafrmDS.Click += new System.EventHandler(this.btnXoafrmDS_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.Location = new System.Drawing.Point(966, 32);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(122, 40);
            this.btnXemChiTiet.TabIndex = 18;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.ttXemChiTiet.SetToolTip(this.btnXemChiTiet, "Chọn người dùng để xem thông tin chi tiết ");
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnDongfrmDS
            // 
            this.btnDongfrmDS.BackColor = System.Drawing.Color.White;
            this.btnDongfrmDS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongfrmDS.Location = new System.Drawing.Point(966, 319);
            this.btnDongfrmDS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDongfrmDS.Name = "btnDongfrmDS";
            this.btnDongfrmDS.Size = new System.Drawing.Size(122, 40);
            this.btnDongfrmDS.TabIndex = 19;
            this.btnDongfrmDS.Text = "Đóng";
            this.btnDongfrmDS.UseVisualStyleBackColor = true;
            this.btnDongfrmDS.Click += new System.EventHandler(this.btnDongfrmDS_Click);
            // 
            // btnXuatfrmDS
            // 
            this.btnXuatfrmDS.BackColor = System.Drawing.Color.White;
            this.btnXuatfrmDS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatfrmDS.Location = new System.Drawing.Point(966, 367);
            this.btnXuatfrmDS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnXuatfrmDS.Name = "btnXuatfrmDS";
            this.btnXuatfrmDS.Size = new System.Drawing.Size(122, 40);
            this.btnXuatfrmDS.TabIndex = 20;
            this.btnXuatfrmDS.Text = "Xuất";
            this.btnXuatfrmDS.UseVisualStyleBackColor = true;
            this.btnXuatfrmDS.Click += new System.EventHandler(this.btnXuatfrmDS_Click);
            // 
            // lblLoaiNguoiDung
            // 
            this.lblLoaiNguoiDung.AutoSize = true;
            this.lblLoaiNguoiDung.Location = new System.Drawing.Point(22, 83);
            this.lblLoaiNguoiDung.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLoaiNguoiDung.Name = "lblLoaiNguoiDung";
            this.lblLoaiNguoiDung.Size = new System.Drawing.Size(154, 23);
            this.lblLoaiNguoiDung.TabIndex = 0;
            this.lblLoaiNguoiDung.Text = "Loại người dùng:";
            // 
            // cbLoaiNguoiDungfrmDS
            // 
            this.cbLoaiNguoiDungfrmDS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiNguoiDungfrmDS.FormattingEnabled = true;
            this.cbLoaiNguoiDungfrmDS.Location = new System.Drawing.Point(197, 76);
            this.cbLoaiNguoiDungfrmDS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbLoaiNguoiDungfrmDS.Name = "cbLoaiNguoiDungfrmDS";
            this.cbLoaiNguoiDungfrmDS.Size = new System.Drawing.Size(163, 30);
            this.cbLoaiNguoiDungfrmDS.TabIndex = 3;
            this.cbLoaiNguoiDungfrmDS.SelectedIndexChanged += new System.EventHandler(this.cbLoaiNguoiDungfrmDS_SelectedIndexChanged);
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(22, 37);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(149, 23);
            this.lblMaNV.TabIndex = 10;
            this.lblMaNV.Text = "Mã người dùng: ";
            // 
            // txtMaNDfrmDS
            // 
            this.txtMaNDfrmDS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNDfrmDS.Location = new System.Drawing.Point(197, 30);
            this.txtMaNDfrmDS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMaNDfrmDS.Name = "txtMaNDfrmDS";
            this.txtMaNDfrmDS.Size = new System.Drawing.Size(163, 30);
            this.txtMaNDfrmDS.TabIndex = 6;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(429, 37);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(78, 23);
            this.lblHoTen.TabIndex = 5;
            this.lblHoTen.Text = "Họ tên: ";
            // 
            // txtHoTenfrmDS
            // 
            this.txtHoTenfrmDS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenfrmDS.Location = new System.Drawing.Point(517, 30);
            this.txtHoTenfrmDS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtHoTenfrmDS.Name = "txtHoTenfrmDS";
            this.txtHoTenfrmDS.Size = new System.Drawing.Size(313, 30);
            this.txtHoTenfrmDS.TabIndex = 1;
            // 
            // gbND
            // 
            this.gbND.BackColor = System.Drawing.Color.AliceBlue;
            this.gbND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbND.Controls.Add(this.txtHoTenfrmDS);
            this.gbND.Controls.Add(this.lblHoTen);
            this.gbND.Controls.Add(this.txtMaNDfrmDS);
            this.gbND.Controls.Add(this.lblMaNV);
            this.gbND.Controls.Add(this.cbLoaiNguoiDungfrmDS);
            this.gbND.Controls.Add(this.lblLoaiNguoiDung);
            this.gbND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.gbND.Location = new System.Drawing.Point(45, 12);
            this.gbND.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbND.Name = "gbND";
            this.gbND.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbND.Size = new System.Drawing.Size(877, 126);
            this.gbND.TabIndex = 21;
            this.gbND.TabStop = false;
            this.gbND.Text = "Thông tin người dùng";
            // 
            // frmDanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1132, 553);
            this.Controls.Add(this.btnXuatfrmDS);
            this.Controls.Add(this.btnDongfrmDS);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.btnXoafrmDS);
            this.Controls.Add(this.btnThemfrmDS);
            this.Controls.Add(this.txtTimfrmDS);
            this.Controls.Add(this.dgvDanhSachNhanVien);
            this.Controls.Add(this.btnTimfrmDS);
            this.Controls.Add(this.gbND);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmDanhSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách nhân viên";
            this.Load += new System.EventHandler(this.frmDanhSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).EndInit();
            this.gbND.ResumeLayout(false);
            this.gbND.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTimfrmDS;
        private System.Windows.Forms.DataGridView dgvDanhSachNhanVien;
        private System.Windows.Forms.TextBox txtTimfrmDS;
        private System.Windows.Forms.Button btnThemfrmDS;
        private System.Windows.Forms.Button btnXoafrmDS;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnDongfrmDS;
        private System.Windows.Forms.Button btnXuatfrmDS;
        private System.Windows.Forms.ToolTip ttTimfrmDS;
        private System.Windows.Forms.ToolTip ttTimThuoc;
        private System.Windows.Forms.ToolTip ttXemChiTiet;
        private System.Windows.Forms.Label lblLoaiNguoiDung;
        private System.Windows.Forms.ComboBox cbLoaiNguoiDungfrmDS;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNDfrmDS;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTenfrmDS;
        private System.Windows.Forms.GroupBox gbND;
    }
}