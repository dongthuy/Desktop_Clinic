namespace Clinix
{
    partial class ThemLichKham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemLichKham));
            this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayHen = new System.Windows.Forms.DateTimePicker();
            this.dtpKhungGio = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.ttGioiTinh = new System.Windows.Forms.ToolTip(this.components);
            this.ttDiaChi = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenBenhNhan
            // 
            this.txtTenBenhNhan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBenhNhan.Location = new System.Drawing.Point(38, 131);
            this.txtTenBenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenBenhNhan.Name = "txtTenBenhNhan";
            this.txtTenBenhNhan.Size = new System.Drawing.Size(415, 26);
            this.txtTenBenhNhan.TabIndex = 0;
            this.txtTenBenhNhan.TextChanged += new System.EventHandler(this.txtTenBenhNhan_TextChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(247, 66);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(206, 26);
            this.txtSDT.TabIndex = 3;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên bệnh nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(503, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giới tính";
            // 
            // dtpNgayHen
            // 
            this.dtpNgayHen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayHen.Location = new System.Drawing.Point(36, 61);
            this.dtpNgayHen.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayHen.Name = "dtpNgayHen";
            this.dtpNgayHen.Size = new System.Drawing.Size(274, 30);
            this.dtpNgayHen.TabIndex = 11;
            // 
            // dtpKhungGio
            // 
            this.dtpKhungGio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpKhungGio.Location = new System.Drawing.Point(36, 114);
            this.dtpKhungGio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpKhungGio.Name = "dtpKhungGio";
            this.dtpKhungGio.Size = new System.Drawing.Size(274, 30);
            this.dtpKhungGio.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.lblDiaChi);
            this.groupBox1.Controls.Add(this.lblGioiTinh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaBenhNhan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtTenBenhNhan);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.groupBox1.Location = new System.Drawing.Point(30, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(663, 241);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(487, 118);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(142, 48);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.Black;
            this.lblDiaChi.Location = new System.Drawing.Point(33, 199);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(151, 22);
            this.lblDiaChi.TabIndex = 14;
            this.lblDiaChi.Text = "Địa chỉ bệnh nhân";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.lblGioiTinh.Location = new System.Drawing.Point(503, 70);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(86, 22);
            this.lblGioiTinh.TabIndex = 13;
            this.lblGioiTinh.Text = "Giới tính ";
            this.ttGioiTinh.SetToolTip(this.lblGioiTinh, "Chọn ô giới tính trong bảng");
            this.ttDiaChi.SetToolTip(this.lblGioiTinh, "Chọn ô địa chỉ trong bảng");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã bệnh nhân";
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.Enabled = false;
            this.txtMaBenhNhan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBenhNhan.Location = new System.Drawing.Point(37, 67);
            this.txtMaBenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.Size = new System.Drawing.Size(176, 26);
            this.txtMaBenhNhan.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnIn);
            this.groupBox2.Controls.Add(this.dtpKhungGio);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.dtpNgayHen);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.groupBox2.Location = new System.Drawing.Point(750, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(348, 241);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết lịch khám";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Thời gian khám";
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(186, 173);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(142, 48);
            this.btnIn.TabIndex = 18;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(36, 173);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(142, 48);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvBenhNhan
            // 
            this.dgvBenhNhan.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenhNhan.Location = new System.Drawing.Point(30, 262);
            this.dgvBenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            this.dgvBenhNhan.RowHeadersWidth = 51;
            this.dgvBenhNhan.Size = new System.Drawing.Size(1068, 278);
            this.dgvBenhNhan.TabIndex = 16;
            this.dgvBenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBenhNhan_CellClick);
            // 
            // ThemLichKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1132, 553);
            this.Controls.Add(this.dgvBenhNhan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThemLichKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm lịch khám";
            this.Load += new System.EventHandler(this.frmThemLichKham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenBenhNhan;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayHen;
        private System.Windows.Forms.DateTimePicker dtpKhungGio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaBenhNhan;
        private System.Windows.Forms.DataGridView dgvBenhNhan;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolTip ttGioiTinh;
        private System.Windows.Forms.ToolTip ttDiaChi;
    }
}