
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
            this.dgvMH = new System.Windows.Forms.DataGridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dtpNS = new System.Windows.Forms.DateTimePicker();
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
            this.navigationPane1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Size = new System.Drawing.Size(297, 605);
            this.navigationPage2});
            this.navigationPane1.RegularSize = new System.Drawing.Size(297, 626);
            this.navigationPane1.SelectedPage = this.navigationPage2;
            this.navigationPane1.Size = new System.Drawing.Size(297, 626);
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
            this.navigationPage2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.navigationPage2.Controls.Add(this.txbNhanVien);
            this.navigationPage2.Size = new System.Drawing.Size(189, 532);
            this.navigationPage2.Controls.Add(this.labelControl15);
            this.navigationPage2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(189, 553);
            // 
            // dtpNS
            // 
            this.dtpNS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNS.Location = new System.Drawing.Point(10, 228);
            this.dtpNS.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNS.Name = "dtpNS";
            this.dtpNS.Size = new System.Drawing.Size(100, 20);
            this.dtpNS.TabIndex = 19;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(10, 212);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 13);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Ngày nhập";
            // 
            this.navigationPage2.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(335, 655);
            // 
            // btnDSNhapMH
            // 
            this.btnDSNhapMH.Size = new System.Drawing.Size(106, 34);
            this.btnDSNhapMH.Appearance.Options.UseFont = true;
            this.btnDSNhapMH.Location = new System.Drawing.Point(11, 257);
            this.btnDSNhapMH.Name = "btnDSNhapMH";
            this.btnDSNhapMH.Size = new System.Drawing.Size(155, 34);
            this.btnDSNhapMH.TabIndex = 12;
            this.btnDSNhapMH.Text = "Hiển thị danh sách";
            this.btnDSNhapMH.Click += new System.EventHandler(this.btnDSNhapMH_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 202);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(0, 13);
            this.labelControl4.TabIndex = 16;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 159);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "ID Kho";
            // 
            // txbIDKho
            // 
            this.txbIDKho.Location = new System.Drawing.Point(11, 178);
            this.txbIDKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbIDKho.Name = "txbIDKho";
            this.txbIDKho.Size = new System.Drawing.Size(88, 20);
            this.txbIDKho.TabIndex = 13;
            // 
            this.btnDSNhapMH.TabIndex = 12;
            this.btnDSNhapMH.Text = "Hiển thị danh sách";
            this.btnDSNhapMH.Click += new System.EventHandler(this.btnDSNhapMH_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Tên MH";
            // 
            // cbmMH
            // 
            this.cbmMH.FormattingEnabled = true;
            this.cbmMH.Location = new System.Drawing.Point(10, 30);
            this.cbmMH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbmMH.Name = "cbmMH";
            this.cbmMH.Size = new System.Drawing.Size(140, 21);
            this.cbmMH.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 114);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "ID Nhân viên";
            // 
            // txbNhanVien
            // 
            this.txbNhanVien.Location = new System.Drawing.Point(10, 130);
            this.txbNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbNhanVien.Name = "txbNhanVien";
            this.txbNhanVien.Size = new System.Drawing.Size(88, 20);
            this.txbNhanVien.TabIndex = 8;
            // 
            // txbSoLuong
            // 
            this.txbSoLuong.Location = new System.Drawing.Point(10, 85);
            this.txbSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbSoLuong.Name = "txbSoLuong";
            this.txbSoLuong.Size = new System.Drawing.Size(135, 20);
            this.txbSoLuong.TabIndex = 5;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(10, 64);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(45, 13);
            this.labelControl15.TabIndex = 1;
            this.labelControl15.Text = "Số Lượng";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            this.groupBox1.Location = new System.Drawing.Point(299, 3);
            this.groupBox1.Controls.Add(this.dgvNhapMH);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Location = new System.Drawing.Point(293, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(909, 549);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý";
            // 
            // dgvNhapMH
            this.dgvNhapMH.Location = new System.Drawing.Point(2, 42);
            this.dgvNhapMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhapMH.Location = new System.Drawing.Point(2, 42);
            this.dgvNhapMH.Name = "dgvNhapMH";
            this.dgvNhapMH.RowHeadersWidth = 51;
            this.dgvNhapMH.Size = new System.Drawing.Size(905, 505);
            this.dgvNhapMH.TabIndex = 11;
            this.dgvNhapMH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapMH_CellContentClick);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Location = new System.Drawing.Point(2, 15);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnCancel});
            this.bindingNavigator1.Location = new System.Drawing.Point(2, 15);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(612, 27);
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(905, 27);
            this.bindingNavigator1.TabIndex = 10;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(53, 24);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeftAutoMirrorImage = true;
            this.btnCancel.Size = new System.Drawing.Size(70, 24);
            this.btnCancel.Text = " Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.Controls.Add(this.dgvMH);
            // txbIDKho
            // 
            this.txbIDKho.Location = new System.Drawing.Point(15, 219);
            this.txbIDKho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbIDKho.Name = "txbIDKho";
            this.txbIDKho.Size = new System.Drawing.Size(116, 20);
            this.txbIDKho.TabIndex = 13;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 196);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "ID Kho";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 249);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(0, 13);
            this.labelControl4.TabIndex = 16;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(14, 261);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 13);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Số Lượng";
            // 
            // dtpNS
            // 
            this.dtpNS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNS.Location = new System.Drawing.Point(14, 280);
            this.dtpNS.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNS.Name = "dtpNS";
            this.dtpNS.Size = new System.Drawing.Size(132, 20);
            this.dtpNS.TabIndex = 19;
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 626);
            this.Controls.Add(this.navigationPane1);
            this.Controls.Add(this.groupBox1);
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