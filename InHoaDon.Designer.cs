namespace Clinix
{
    partial class frmInHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInHoaDon));
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnInPhieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPhieu.ForeColor = System.Drawing.Color.Navy;
            this.btnInPhieu.Location = new System.Drawing.Point(760, 629);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(137, 45);
            this.btnInPhieu.TabIndex = 24;
            this.btnInPhieu.Text = "In Hóa Đơn";
            this.btnInPhieu.UseVisualStyleBackColor = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(750, 718);
            this.reportViewer1.TabIndex = 25;
            // 
            // frmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(750, 718);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnInPhieu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InHoaDon";
            this.Load += new System.EventHandler(this.frmInHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInPhieu;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}