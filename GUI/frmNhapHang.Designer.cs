﻿
namespace GUI
{
    partial class frmNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapHang));
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.dtpNS = new System.Windows.Forms.DateTimePicker();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnDSNhapMH = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txbIDKho = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbmMH = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txbNhanVien = new System.Windows.Forms.TextBox();
            this.txbSoLuong = new System.Windows.Forms.TextBox();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNhapMH = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage2});
            this.navigationPane1.RegularSize = new System.Drawing.Size(396, 770);
            this.navigationPane1.SelectedPage = this.navigationPage2;
            this.navigationPane1.Size = new System.Drawing.Size(396, 770);
            this.navigationPane1.TabIndex = 36;
            this.navigationPane1.Text = "Nhập";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Nhập Hàng";
            this.navigationPage2.Controls.Add(this.dtpNS);
            this.navigationPage2.Controls.Add(this.labelControl6);
            this.navigationPage2.Controls.Add(this.btnDSNhapMH);
            this.navigationPage2.Controls.Add(this.labelControl4);
            this.navigationPage2.Controls.Add(this.labelControl3);
            this.navigationPage2.Controls.Add(this.txbIDKho);
            this.navigationPage2.Controls.Add(this.labelControl2);
            this.navigationPage2.Controls.Add(this.cbmMH);
            this.navigationPage2.Controls.Add(this.labelControl1);
            this.navigationPage2.Controls.Add(this.txbNhanVien);
            this.navigationPage2.Controls.Add(this.txbSoLuong);
            this.navigationPage2.Controls.Add(this.labelControl15);
            this.navigationPage2.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(216, 660);
            // 
            // dtpNS
            // 
            this.dtpNS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNS.Location = new System.Drawing.Point(13, 281);
            this.dtpNS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNS.Name = "dtpNS";
            this.dtpNS.Size = new System.Drawing.Size(132, 22);
            this.dtpNS.TabIndex = 19;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 261);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(53, 17);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Ngày lập";
            // 
            // btnDSNhapMH
            // 
            this.btnDSNhapMH.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSNhapMH.Appearance.Options.UseFont = true;
            this.btnDSNhapMH.Location = new System.Drawing.Point(15, 316);
            this.btnDSNhapMH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDSNhapMH.Name = "btnDSNhapMH";
            this.btnDSNhapMH.Size = new System.Drawing.Size(207, 42);
            this.btnDSNhapMH.TabIndex = 12;
            this.btnDSNhapMH.Text = "Hiển thị danh sách";
            this.btnDSNhapMH.Click += new System.EventHandler(this.btnDSNhapMH_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 249);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(0, 16);
            this.labelControl4.TabIndex = 16;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 196);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 16);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "ID Kho";
            // 
            // txbIDKho
            // 
            this.txbIDKho.Location = new System.Drawing.Point(15, 219);
            this.txbIDKho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbIDKho.Name = "txbIDKho";
            this.txbIDKho.Size = new System.Drawing.Size(116, 22);
            this.txbIDKho.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 17);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 16);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Tên MH";
            // 
            // cbmMH
            // 
            this.cbmMH.FormattingEnabled = true;
            this.cbmMH.Location = new System.Drawing.Point(13, 37);
            this.cbmMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbmMH.Name = "cbmMH";
            this.cbmMH.Size = new System.Drawing.Size(185, 24);
            this.cbmMH.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 140);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 16);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "ID Nhân viên";
            // 
            // txbNhanVien
            // 
            this.txbNhanVien.Location = new System.Drawing.Point(13, 160);
            this.txbNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbNhanVien.Name = "txbNhanVien";
            this.txbNhanVien.Size = new System.Drawing.Size(116, 22);
            this.txbNhanVien.TabIndex = 8;
            // 
            // txbSoLuong
            // 
            this.txbSoLuong.Location = new System.Drawing.Point(13, 105);
            this.txbSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbSoLuong.Name = "txbSoLuong";
            this.txbSoLuong.Size = new System.Drawing.Size(179, 22);
            this.txbSoLuong.TabIndex = 5;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(13, 79);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(60, 17);
            this.labelControl15.TabIndex = 1;
            this.labelControl15.Text = "Số Lượng";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.dgvNhapMH);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Location = new System.Drawing.Point(391, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1212, 676);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý";
            // 
            // dgvNhapMH
            // 
            this.dgvNhapMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhapMH.Location = new System.Drawing.Point(3, 44);
            this.dgvNhapMH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNhapMH.Name = "dgvNhapMH";
            this.dgvNhapMH.RowHeadersWidth = 51;
            this.dgvNhapMH.Size = new System.Drawing.Size(1206, 630);
            this.dgvNhapMH.TabIndex = 11;
            this.dgvNhapMH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapMH_CellContentClick);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnCancel});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 17);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1206, 27);
            this.bindingNavigator1.TabIndex = 10;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(61, 24);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeftAutoMirrorImage = true;
            this.btnCancel.Size = new System.Drawing.Size(81, 24);
            this.btnCancel.Text = " Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1619, 770);
            this.Controls.Add(this.navigationPane1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNhapHang";
            this.Text = "frmNhapHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txbNhanVien;
        private System.Windows.Forms.TextBox txbSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNhapMH;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ComboBox cbmMH;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnDSNhapMH;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txbIDKho;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.DateTimePicker dtpNS;
    }
}