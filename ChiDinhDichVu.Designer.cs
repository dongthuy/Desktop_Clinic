namespace Clinix
{
    partial class ChiDinhDichVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiDinhDichVu));
            this.dataGridViewDV = new System.Windows.Forms.DataGridView();
            this.btnIn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimMP = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnNhapMoi = new System.Windows.Forms.Button();
            this.cbbDV = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewPhieuKham = new System.Windows.Forms.DataGridView();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtChanDoan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuKham)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDV
            // 
            this.dataGridViewDV.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDV.Location = new System.Drawing.Point(26, 168);
            this.dataGridViewDV.Name = "dataGridViewDV";
            this.dataGridViewDV.RowHeadersWidth = 51;
            this.dataGridViewDV.RowTemplate.Height = 24;
            this.dataGridViewDV.Size = new System.Drawing.Size(787, 213);
            this.dataGridViewDV.TabIndex = 37;
            this.dataGridViewDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDV_CellClick);
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnIn.Location = new System.Drawing.Point(1114, 644);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(118, 38);
            this.btnIn.TabIndex = 40;
            this.btnIn.Text = "In phiếu";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.label8.Location = new System.Drawing.Point(22, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 115;
            this.label8.Text = "Chẩn đoán:";
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaDV.Location = new System.Drawing.Point(695, 106);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(118, 38);
            this.btnXoaDV.TabIndex = 114;
            this.btnXoaDV.Text = "Xóa ";
            this.btnXoaDV.UseVisualStyleBackColor = true;
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // btnThemDV
            // 
            this.btnThemDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemDV.Location = new System.Drawing.Point(695, 44);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(118, 38);
            this.btnThemDV.TabIndex = 113;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnTim.Location = new System.Drawing.Point(452, 40);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(118, 38);
            this.btnTim.TabIndex = 105;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click_1);
            // 
            // txtTimMP
            // 
            this.txtTimMP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMP.Location = new System.Drawing.Point(18, 40);
            this.txtTimMP.Multiline = true;
            this.txtTimMP.Name = "txtTimMP";
            this.txtTimMP.Size = new System.Drawing.Size(415, 38);
            this.txtTimMP.TabIndex = 104;
            this.toolTip1.SetToolTip(this.txtTimMP, "Nhập mã/ tên bệnh nhân");
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnThoat.Location = new System.Drawing.Point(1316, 644);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 38);
            this.btnThoat.TabIndex = 101;
            this.btnThoat.Text = "Quay Lại";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnLuu.Location = new System.Drawing.Point(904, 644);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(118, 38);
            this.btnLuu.TabIndex = 99;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnNhapMoi
            // 
            this.btnNhapMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhapMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnNhapMoi.Location = new System.Drawing.Point(705, 644);
            this.btnNhapMoi.Name = "btnNhapMoi";
            this.btnNhapMoi.Size = new System.Drawing.Size(118, 38);
            this.btnNhapMoi.TabIndex = 98;
            this.btnNhapMoi.Text = "Nhập mới";
            this.btnNhapMoi.UseVisualStyleBackColor = true;
            this.btnNhapMoi.Click += new System.EventHandler(this.btnNhapMoi_Click);
            // 
            // cbbDV
            // 
            this.cbbDV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbDV.FormattingEnabled = true;
            this.cbbDV.Location = new System.Drawing.Point(132, 117);
            this.cbbDV.Name = "cbbDV";
            this.cbbDV.Size = new System.Drawing.Size(242, 27);
            this.cbbDV.TabIndex = 96;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.label10.Location = new System.Drawing.Point(22, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 23);
            this.label10.TabIndex = 95;
            this.label10.Text = "Dịch vụ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.label5.Location = new System.Drawing.Point(460, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 117;
            this.label5.Text = "Số lượng:";
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSL.Location = new System.Drawing.Point(557, 117);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(100, 27);
            this.txtSL.TabIndex = 118;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtTimMP);
            this.groupBox1.Controls.Add(this.dataGridViewPhieuKham);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 703);
            this.groupBox1.TabIndex = 121;
            this.groupBox1.TabStop = false;
            // 
            // dataGridViewPhieuKham
            // 
            this.dataGridViewPhieuKham.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPhieuKham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPhieuKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPhieuKham.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPhieuKham.Location = new System.Drawing.Point(18, 100);
            this.dataGridViewPhieuKham.Name = "dataGridViewPhieuKham";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPhieuKham.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPhieuKham.RowHeadersWidth = 51;
            this.dataGridViewPhieuKham.RowTemplate.Height = 24;
            this.dataGridViewPhieuKham.Size = new System.Drawing.Size(552, 582);
            this.dataGridViewPhieuKham.TabIndex = 103;
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaBenhNhan.Location = new System.Drawing.Point(599, 36);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.Size = new System.Drawing.Size(214, 27);
            this.txtMaBenhNhan.TabIndex = 91;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoTen.Location = new System.Drawing.Point(148, 40);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(253, 27);
            this.txtHoTen.TabIndex = 92;
            // 
            // txtChanDoan
            // 
            this.txtChanDoan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChanDoan.Location = new System.Drawing.Point(132, 44);
            this.txtChanDoan.Multiline = true;
            this.txtChanDoan.Name = "txtChanDoan";
            this.txtChanDoan.Size = new System.Drawing.Size(525, 52);
            this.txtChanDoan.TabIndex = 116;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.AliceBlue;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.label9.Location = new System.Drawing.Point(33, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 23);
            this.label9.TabIndex = 90;
            this.label9.Text = "Tuổi:";
            // 
            // txtTuoi
            // 
            this.txtTuoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTuoi.Location = new System.Drawing.Point(148, 84);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(127, 27);
            this.txtTuoi.TabIndex = 94;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.label6.Location = new System.Drawing.Point(511, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 87;
            this.label6.Text = "Mã BN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.label2.Location = new System.Drawing.Point(33, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 88;
            this.label2.Text = "Họ và Tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.txtMaBenhNhan);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTuoi);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.groupBox2.Location = new System.Drawing.Point(621, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(838, 134);
            this.groupBox2.TabIndex = 122;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin bệnh nhân";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtChanDoan);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtSL);
            this.groupBox3.Controls.Add(this.dataGridViewDV);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbbDV);
            this.groupBox3.Controls.Add(this.btnXoaDV);
            this.groupBox3.Controls.Add(this.btnThemDV);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.groupBox3.Location = new System.Drawing.Point(621, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(838, 440);
            this.groupBox3.TabIndex = 123;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chỉ định";
            // 
            // ChiDinhDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1482, 703);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnNhapMoi);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChiDinhDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉ Định Dịch Vụ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuKham)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDV;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXoaDV;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimMP;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnNhapMoi;
        private System.Windows.Forms.ComboBox cbbDV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewPhieuKham;
        private System.Windows.Forms.TextBox txtMaBenhNhan;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtChanDoan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}