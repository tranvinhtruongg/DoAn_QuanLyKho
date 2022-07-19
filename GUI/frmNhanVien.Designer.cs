
namespace GUI
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.navigationPane_NV = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnHTNV = new System.Windows.Forms.Button();
            this.dtpNS = new System.Windows.Forms.DateTimePicker();
            this.cmbGT = new System.Windows.Forms.ComboBox();
            this.txbDiachi = new System.Windows.Forms.TextBox();
            this.txbDienthoai = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbTenNV = new System.Windows.Forms.TextBox();
            this.lblDC = new System.Windows.Forms.Label();
            this.lblNS = new System.Windows.Forms.Label();
            this.lblDT = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.grbNV = new System.Windows.Forms.GroupBox();
            this.dtgvNV = new System.Windows.Forms.DataGridView();
            this.bindingNavigator_NV = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane_NV)).BeginInit();
            this.navigationPane_NV.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.grbNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_NV)).BeginInit();
            this.bindingNavigator_NV.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane_NV
            // 
            this.navigationPane_NV.Controls.Add(this.navigationPage1);
            this.navigationPane_NV.Location = new System.Drawing.Point(0, 0);
            this.navigationPane_NV.Margin = new System.Windows.Forms.Padding(2);
            this.navigationPane_NV.Name = "navigationPane_NV";
            this.navigationPane_NV.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1});
            this.navigationPane_NV.RegularSize = new System.Drawing.Size(380, 582);
            this.navigationPane_NV.SelectedPage = this.navigationPage1;
            this.navigationPane_NV.Size = new System.Drawing.Size(380, 582);
            this.navigationPane_NV.TabIndex = 0;
            this.navigationPane_NV.Text = "Nhân Viên";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Danh sách nhân viên";
            this.navigationPage1.Controls.Add(this.btnHTNV);
            this.navigationPage1.Controls.Add(this.dtpNS);
            this.navigationPage1.Controls.Add(this.cmbGT);
            this.navigationPage1.Controls.Add(this.txbDiachi);
            this.navigationPage1.Controls.Add(this.txbDienthoai);
            this.navigationPage1.Controls.Add(this.txbEmail);
            this.navigationPage1.Controls.Add(this.txbTenNV);
            this.navigationPage1.Controls.Add(this.lblDC);
            this.navigationPage1.Controls.Add(this.lblNS);
            this.navigationPage1.Controls.Add(this.lblDT);
            this.navigationPage1.Controls.Add(this.lblGT);
            this.navigationPage1.Controls.Add(this.lblEmail);
            this.navigationPage1.Controls.Add(this.lblTenNV);
            this.navigationPage1.Margin = new System.Windows.Forms.Padding(2);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(225, 509);
            // 
            // btnHTNV
            // 
            this.btnHTNV.Location = new System.Drawing.Point(17, 260);
            this.btnHTNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnHTNV.Name = "btnHTNV";
            this.btnHTNV.Size = new System.Drawing.Size(181, 30);
            this.btnHTNV.TabIndex = 17;
            this.btnHTNV.Text = "Hiển thị danh sách nhân viên";
            this.btnHTNV.UseVisualStyleBackColor = true;
            this.btnHTNV.Click += new System.EventHandler(this.btnHTNV_Click);
            // 
            // dtpNS
            // 
            this.dtpNS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNS.Location = new System.Drawing.Point(88, 170);
            this.dtpNS.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNS.Name = "dtpNS";
            this.dtpNS.Size = new System.Drawing.Size(132, 20);
            this.dtpNS.TabIndex = 16;
            // 
            // cmbGT
            // 
            this.cmbGT.FormattingEnabled = true;
            this.cmbGT.Location = new System.Drawing.Point(88, 57);
            this.cmbGT.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGT.Name = "cmbGT";
            this.cmbGT.Size = new System.Drawing.Size(132, 21);
            this.cmbGT.TabIndex = 15;
            // 
            // txbDiachi
            // 
            this.txbDiachi.Location = new System.Drawing.Point(88, 208);
            this.txbDiachi.Margin = new System.Windows.Forms.Padding(2);
            this.txbDiachi.Multiline = true;
            this.txbDiachi.Name = "txbDiachi";
            this.txbDiachi.Size = new System.Drawing.Size(132, 23);
            this.txbDiachi.TabIndex = 14;
            // 
            // txbDienthoai
            // 
            this.txbDienthoai.Location = new System.Drawing.Point(88, 133);
            this.txbDienthoai.Margin = new System.Windows.Forms.Padding(2);
            this.txbDienthoai.Multiline = true;
            this.txbDienthoai.Name = "txbDienthoai";
            this.txbDienthoai.Size = new System.Drawing.Size(132, 23);
            this.txbDienthoai.TabIndex = 12;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(88, 92);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmail.Multiline = true;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(132, 23);
            this.txbEmail.TabIndex = 11;
            // 
            // txbTenNV
            // 
            this.txbTenNV.Location = new System.Drawing.Point(88, 24);
            this.txbTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.txbTenNV.Multiline = true;
            this.txbTenNV.Name = "txbTenNV";
            this.txbTenNV.Size = new System.Drawing.Size(132, 23);
            this.txbTenNV.TabIndex = 9;
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Location = new System.Drawing.Point(14, 211);
            this.lblDC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(40, 13);
            this.lblDC.TabIndex = 8;
            this.lblDC.Text = "Địa chỉ";
            // 
            // lblNS
            // 
            this.lblNS.AutoSize = true;
            this.lblNS.Location = new System.Drawing.Point(14, 175);
            this.lblNS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNS.Name = "lblNS";
            this.lblNS.Size = new System.Drawing.Size(51, 13);
            this.lblNS.TabIndex = 7;
            this.lblNS.Text = "Năm sinh";
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Location = new System.Drawing.Point(14, 136);
            this.lblDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(55, 13);
            this.lblDT.TabIndex = 6;
            this.lblDT.Text = "Điện thoại";
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Location = new System.Drawing.Point(14, 59);
            this.lblGT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(47, 13);
            this.lblGT.TabIndex = 5;
            this.lblGT.Text = "Giới tính";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(14, 94);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(14, 26);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(76, 13);
            this.lblTenNV.TabIndex = 3;
            this.lblTenNV.Text = "Tên nhân viên";
            // 
            // grbNV
            // 
            this.grbNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbNV.AutoSize = true;
            this.grbNV.Controls.Add(this.dtgvNV);
            this.grbNV.Controls.Add(this.bindingNavigator_NV);
            this.grbNV.Location = new System.Drawing.Point(376, 2);
            this.grbNV.Margin = new System.Windows.Forms.Padding(2);
            this.grbNV.Name = "grbNV";
            this.grbNV.Padding = new System.Windows.Forms.Padding(2);
            this.grbNV.Size = new System.Drawing.Size(537, 595);
            this.grbNV.TabIndex = 1;
            this.grbNV.TabStop = false;
            this.grbNV.Text = "Quản lý nhân viên";
            // 
            // dtgvNV
            // 
            this.dtgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNV.Location = new System.Drawing.Point(4, 39);
            this.dtgvNV.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvNV.Name = "dtgvNV";
            this.dtgvNV.RowHeadersWidth = 51;
            this.dtgvNV.RowTemplate.Height = 24;
            this.dtgvNV.Size = new System.Drawing.Size(529, 539);
            this.dtgvNV.TabIndex = 12;
            this.dtgvNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNV_CellClick);
            // 
            // bindingNavigator_NV
            // 
            this.bindingNavigator_NV.AddNewItem = null;
            this.bindingNavigator_NV.CountItem = null;
            this.bindingNavigator_NV.DeleteItem = null;
            this.bindingNavigator_NV.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator_NV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btnEdit,
            this.toolStripSeparator3,
            this.btnAdd,
            this.toolStripSeparator1,
            this.btnDelete,
            this.toolStripSeparator4,
            this.btnCancel,
            this.toolStripSeparator5});
            this.bindingNavigator_NV.Location = new System.Drawing.Point(2, 15);
            this.bindingNavigator_NV.MoveFirstItem = null;
            this.bindingNavigator_NV.MoveLastItem = null;
            this.bindingNavigator_NV.MoveNextItem = null;
            this.bindingNavigator_NV.MovePreviousItem = null;
            this.bindingNavigator_NV.Name = "bindingNavigator_NV";
            this.bindingNavigator_NV.PositionItem = null;
            this.bindingNavigator_NV.Size = new System.Drawing.Size(533, 27);
            this.bindingNavigator_NV.TabIndex = 11;
            this.bindingNavigator_NV.Text = "bindingNavigator1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeftAutoMirrorImage = true;
            this.btnEdit.Size = new System.Drawing.Size(51, 24);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(64, 24);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeftAutoMirrorImage = true;
            this.btnCancel.Size = new System.Drawing.Size(67, 24);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 593);
            this.Controls.Add(this.grbNV);
            this.Controls.Add(this.navigationPane_NV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane_NV)).EndInit();
            this.navigationPane_NV.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage1.PerformLayout();
            this.grbNV.ResumeLayout(false);
            this.grbNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_NV)).EndInit();
            this.bindingNavigator_NV.ResumeLayout(false);
            this.bindingNavigator_NV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane_NV;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.TextBox txbDiachi;
        private System.Windows.Forms.TextBox txbDienthoai;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbTenNV;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lblNS;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cmbGT;
        private System.Windows.Forms.DateTimePicker dtpNS;
        private System.Windows.Forms.GroupBox grbNV;
        private System.Windows.Forms.BindingNavigator bindingNavigator_NV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Button btnHTNV;
        private System.Windows.Forms.DataGridView dtgvNV;
    }
}