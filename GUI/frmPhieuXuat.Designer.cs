
namespace GUI
{
    partial class frmPhieuXuat
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
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMaPX = new System.Windows.Forms.Label();
            this.lblNgayXuat = new System.Windows.Forms.Label();
            this.txbMaPX = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvXuat = new System.Windows.Forms.DataGridView();
            this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.btnReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(299, 23);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(136, 29);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "XUẤT KHO";
            // 
            // lblMaPX
            // 
            this.lblMaPX.AutoSize = true;
            this.lblMaPX.Location = new System.Drawing.Point(24, 66);
            this.lblMaPX.Name = "lblMaPX";
            this.lblMaPX.Size = new System.Drawing.Size(96, 17);
            this.lblMaPX.TabIndex = 1;
            this.lblMaPX.Text = "Mã phiếu xuất";
            // 
            // lblNgayXuat
            // 
            this.lblNgayXuat.AutoSize = true;
            this.lblNgayXuat.Location = new System.Drawing.Point(24, 113);
            this.lblNgayXuat.Name = "lblNgayXuat";
            this.lblNgayXuat.Size = new System.Drawing.Size(71, 17);
            this.lblNgayXuat.TabIndex = 2;
            this.lblNgayXuat.Text = "Ngày xuất";
            // 
            // txbMaPX
            // 
            this.txbMaPX.Location = new System.Drawing.Point(137, 63);
            this.txbMaPX.Multiline = true;
            this.txbMaPX.Name = "txbMaPX";
            this.txbMaPX.Size = new System.Drawing.Size(149, 27);
            this.txbMaPX.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvXuat);
            this.panel1.Location = new System.Drawing.Point(12, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 222);
            this.panel1.TabIndex = 5;
            // 
            // dtgvXuat
            // 
            this.dtgvXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvXuat.Location = new System.Drawing.Point(0, 0);
            this.dtgvXuat.Name = "dtgvXuat";
            this.dtgvXuat.RowHeadersWidth = 51;
            this.dtgvXuat.RowTemplate.Height = 24;
            this.dtgvXuat.Size = new System.Drawing.Size(790, 222);
            this.dtgvXuat.TabIndex = 0;
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayXuat.Location = new System.Drawing.Point(137, 113);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(149, 22);
            this.dtpNgayXuat.TabIndex = 8;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(679, 141);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(123, 35);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // frmPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 449);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dtpNgayXuat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbMaPX);
            this.Controls.Add(this.lblNgayXuat);
            this.Controls.Add(this.lblMaPX);
            this.Controls.Add(this.lblTen);
            this.Name = "frmPhieuXuat";
            this.Text = "frmPhieuXuat";
            this.Load += new System.EventHandler(this.frmPhieuXuat_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblMaPX;
        private System.Windows.Forms.Label lblNgayXuat;
        private System.Windows.Forms.TextBox txbMaPX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvXuat;
        private System.Windows.Forms.DateTimePicker dtpNgayXuat;
        private System.Windows.Forms.Button btnReport;
    }
}