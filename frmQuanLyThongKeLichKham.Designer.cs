namespace Clinix
{
    partial class frmQuanLyThongKeLichKham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyThongKeLichKham));
            this.dtpNgayBDLK = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKTLK = new System.Windows.Forms.DateTimePicker();
            this.XuatBC = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // dtpNgayBDLK
            // 
            this.dtpNgayBDLK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBDLK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBDLK.Location = new System.Drawing.Point(925, 23);
            this.dtpNgayBDLK.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayBDLK.Name = "dtpNgayBDLK";
            this.dtpNgayBDLK.Size = new System.Drawing.Size(144, 30);
            this.dtpNgayBDLK.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dtpNgayBDLK, "Ngày bắt đầu");
            // 
            // dtpNgayKTLK
            // 
            this.dtpNgayKTLK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKTLK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKTLK.Location = new System.Drawing.Point(925, 61);
            this.dtpNgayKTLK.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayKTLK.Name = "dtpNgayKTLK";
            this.dtpNgayKTLK.Size = new System.Drawing.Size(144, 30);
            this.dtpNgayKTLK.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dtpNgayKTLK, "Ngày kết thúc");
            // 
            // XuatBC
            // 
            this.XuatBC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XuatBC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.XuatBC.Location = new System.Drawing.Point(925, 116);
            this.XuatBC.Margin = new System.Windows.Forms.Padding(4);
            this.XuatBC.Name = "XuatBC";
            this.XuatBC.Size = new System.Drawing.Size(144, 42);
            this.XuatBC.TabIndex = 2;
            this.XuatBC.Text = "Xuất BC";
            this.XuatBC.UseVisualStyleBackColor = true;
            this.XuatBC.Click += new System.EventHandler(this.XuatBC_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(890, 751);
            this.crystalReportViewer1.TabIndex = 3;
            this.crystalReportViewer1.ToolPanelWidth = 267;
            // 
            // frmQuanLyThongKeLichKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1082, 751);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.XuatBC);
            this.Controls.Add(this.dtpNgayKTLK);
            this.Controls.Add(this.dtpNgayBDLK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyThongKeLichKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê lịch khám";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayBDLK;
        private System.Windows.Forms.DateTimePicker dtpNgayKTLK;
        private System.Windows.Forms.Button XuatBC;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}