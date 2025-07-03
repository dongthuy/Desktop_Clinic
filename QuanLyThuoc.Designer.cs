namespace Clinix
{
    partial class QuanLyThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyThuoc));
            this.btnDongfrmThuoc = new System.Windows.Forms.Button();
            this.btnXuatfrmThuoc = new System.Windows.Forms.Button();
            this.txtTimfrmThuoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.btnTimfrmThuoc = new System.Windows.Forms.Button();
            this.ttTimfrmThuoc = new System.Windows.Forms.ToolTip(this.components);
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDongfrmThuoc
            // 
            this.btnDongfrmThuoc.BackColor = System.Drawing.Color.White;
            this.btnDongfrmThuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongfrmThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnDongfrmThuoc.Location = new System.Drawing.Point(850, 500);
            this.btnDongfrmThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDongfrmThuoc.Name = "btnDongfrmThuoc";
            this.btnDongfrmThuoc.Size = new System.Drawing.Size(156, 40);
            this.btnDongfrmThuoc.TabIndex = 34;
            this.btnDongfrmThuoc.Text = "Quay Lại";
            this.btnDongfrmThuoc.UseVisualStyleBackColor = true;
            this.btnDongfrmThuoc.Click += new System.EventHandler(this.btnDongfrmThuoc_Click);
            // 
            // btnXuatfrmThuoc
            // 
            this.btnXuatfrmThuoc.BackColor = System.Drawing.Color.White;
            this.btnXuatfrmThuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatfrmThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnXuatfrmThuoc.Location = new System.Drawing.Point(659, 500);
            this.btnXuatfrmThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXuatfrmThuoc.Name = "btnXuatfrmThuoc";
            this.btnXuatfrmThuoc.Size = new System.Drawing.Size(156, 40);
            this.btnXuatfrmThuoc.TabIndex = 30;
            this.btnXuatfrmThuoc.Text = "Xuất";
            this.btnXuatfrmThuoc.UseVisualStyleBackColor = true;
            this.btnXuatfrmThuoc.Click += new System.EventHandler(this.btnXuatfrmThuoc_Click);
            // 
            // txtTimfrmThuoc
            // 
            this.txtTimfrmThuoc.Location = new System.Drawing.Point(49, 83);
            this.txtTimfrmThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimfrmThuoc.Name = "txtTimfrmThuoc";
            this.txtTimfrmThuoc.Size = new System.Drawing.Size(642, 30);
            this.txtTimfrmThuoc.TabIndex = 28;
            this.ttTimfrmThuoc.SetToolTip(this.txtTimfrmThuoc, "Nhập tên thuốc/ công dụng");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.label2.Location = new System.Drawing.Point(343, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "DANH SÁCH THUỐC SỬ DỤNG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dgvThuoc.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvThuoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Location = new System.Drawing.Point(49, 137);
            this.dgvThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.RowHeadersWidth = 51;
            this.dgvThuoc.RowTemplate.Height = 24;
            this.dgvThuoc.Size = new System.Drawing.Size(957, 340);
            this.dgvThuoc.TabIndex = 24;
            // 
            // btnTimfrmThuoc
            // 
            this.btnTimfrmThuoc.BackColor = System.Drawing.Color.White;
            this.btnTimfrmThuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimfrmThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnTimfrmThuoc.Location = new System.Drawing.Point(717, 73);
            this.btnTimfrmThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimfrmThuoc.Name = "btnTimfrmThuoc";
            this.btnTimfrmThuoc.Size = new System.Drawing.Size(134, 40);
            this.btnTimfrmThuoc.TabIndex = 22;
            this.btnTimfrmThuoc.Text = "Tìm kiếm";
            this.btnTimfrmThuoc.UseVisualStyleBackColor = true;
            this.btnTimfrmThuoc.Click += new System.EventHandler(this.btnTimfrmThuoc_Click);
            // 
            // ttTimfrmThuoc
            // 
            this.ttTimfrmThuoc.Tag = "";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.White;
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnLoad.Location = new System.Drawing.Point(872, 73);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(134, 40);
            this.btnLoad.TabIndex = 35;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // QuanLyThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1052, 553);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDongfrmThuoc);
            this.Controls.Add(this.btnXuatfrmThuoc);
            this.Controls.Add(this.txtTimfrmThuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvThuoc);
            this.Controls.Add(this.btnTimfrmThuoc);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuanLyThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách thuốc ";
            this.Load += new System.EventHandler(this.frmThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDongfrmThuoc;
        private System.Windows.Forms.Button btnXuatfrmThuoc;
        private System.Windows.Forms.TextBox txtTimfrmThuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.Button btnTimfrmThuoc;
        private System.Windows.Forms.ToolTip ttTimfrmThuoc;
        private System.Windows.Forms.Button btnLoad;
    }
}