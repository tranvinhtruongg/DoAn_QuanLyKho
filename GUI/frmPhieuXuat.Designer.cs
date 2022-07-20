
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
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.MaPX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dtgvXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPX,
            this.TenMH,
            this.SoLuongXuat,
            this.DonGiaXuat,
            this.ThanhTien});
            this.dtgvXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvXuat.Location = new System.Drawing.Point(0, 0);
            this.dtgvXuat.Name = "dtgvXuat";
            this.dtgvXuat.RowHeadersWidth = 51;
            this.dtgvXuat.RowTemplate.Height = 24;
            this.dtgvXuat.Size = new System.Drawing.Size(790, 222);
            this.dtgvXuat.TabIndex = 0;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(532, 420);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(78, 20);
            this.lblTongTien.TabIndex = 6;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // txbTongTien
            // 
            this.txbTongTien.Location = new System.Drawing.Point(621, 410);
            this.txbTongTien.Multiline = true;
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.Size = new System.Drawing.Size(181, 35);
            this.txbTongTien.TabIndex = 7;
            this.txbTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayXuat.Location = new System.Drawing.Point(137, 113);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(149, 22);
            this.dtpNgayXuat.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MaPX
            // 
            this.MaPX.DataPropertyName = "ID";
            this.MaPX.HeaderText = "Mã PX";
            this.MaPX.MinimumWidth = 6;
            this.MaPX.Name = "MaPX";
            this.MaPX.Width = 150;
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMatHang";
            this.TenMH.HeaderText = "Tên hàng";
            this.TenMH.MinimumWidth = 6;
            this.TenMH.Name = "TenMH";
            this.TenMH.Width = 150;
            // 
            // SoLuongXuat
            // 
            this.SoLuongXuat.DataPropertyName = "SoLuong";
            this.SoLuongXuat.HeaderText = "Số lượng";
            this.SoLuongXuat.MinimumWidth = 6;
            this.SoLuongXuat.Name = "SoLuongXuat";
            this.SoLuongXuat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SoLuongXuat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SoLuongXuat.Width = 150;
            // 
            // DonGiaXuat
            // 
            this.DonGiaXuat.DataPropertyName = "DonGia";
            this.DonGiaXuat.HeaderText = "Đơn giá";
            this.DonGiaXuat.MinimumWidth = 6;
            this.DonGiaXuat.Name = "DonGiaXuat";
            this.DonGiaXuat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DonGiaXuat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DonGiaXuat.Width = 150;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 150;
            // 
            // frmPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpNgayXuat);
            this.Controls.Add(this.txbTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbMaPX);
            this.Controls.Add(this.lblNgayXuat);
            this.Controls.Add(this.lblMaPX);
            this.Controls.Add(this.lblTen);
            this.Name = "frmPhieuXuat";
            this.Text = "frmPhieuXuat";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.DateTimePicker dtpNgayXuat;
        private System.Windows.Forms.Button button1;
    }
}