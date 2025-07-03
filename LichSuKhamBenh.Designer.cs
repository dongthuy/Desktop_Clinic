namespace Clinix
{
    partial class LichSuKhamBenh
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
            System.Windows.Forms.Button btnTim;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichSuKhamBenh));
            this.dgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.dgvBenhAn = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ttTim = new System.Windows.Forms.ToolTip(this.components);
            btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhAn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnTim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            btnTim.Location = new System.Drawing.Point(826, 31);
            btnTim.Margin = new System.Windows.Forms.Padding(4);
            btnTim.Name = "btnTim";
            btnTim.Size = new System.Drawing.Size(160, 38);
            btnTim.TabIndex = 3;
            btnTim.Text = "Tìm Kiếm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvBenhNhan
            // 
            this.dgvBenhNhan.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBenhNhan.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBenhNhan.Location = new System.Drawing.Point(79, 114);
            this.dgvBenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            this.dgvBenhNhan.RowHeadersWidth = 51;
            this.dgvBenhNhan.Size = new System.Drawing.Size(907, 165);
            this.dgvBenhNhan.TabIndex = 0;
            this.dgvBenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBenhNhan_CellClick);
            // 
            // dgvBenhAn
            // 
            this.dgvBenhAn.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvBenhAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBenhAn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBenhAn.GridColor = System.Drawing.Color.AliceBlue;
            this.dgvBenhAn.Location = new System.Drawing.Point(79, 324);
            this.dgvBenhAn.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBenhAn.Name = "dgvBenhAn";
            this.dgvBenhAn.RowHeadersWidth = 51;
            this.dgvBenhAn.Size = new System.Drawing.Size(907, 187);
            this.dgvBenhAn.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(79, 37);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(731, 30);
            this.txtSearch.TabIndex = 2;
            this.ttTim.SetToolTip(this.txtSearch, "Nhập tên bệnh nhân");
            this.txtSearch.MouseEnter += new System.EventHandler(this.txtSearch_MouseEnter);
            this.txtSearch.MouseLeave += new System.EventHandler(this.txtSearch_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(75, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông tin bệnh nhân:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.label2.Location = new System.Drawing.Point(75, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lịch sử khám bệnh:";
            // 
            // LichSuKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1082, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(btnTim);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvBenhAn);
            this.Controls.Add(this.dgvBenhNhan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LichSuKhamBenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch Sử Khám Bệnh";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBenhNhan;
        private System.Windows.Forms.DataGridView dgvBenhAn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip ttTim;
    }
}

