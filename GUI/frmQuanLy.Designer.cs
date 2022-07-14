
namespace GUI
{
    partial class frmQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvMH = new System.Windows.Forms.DataGridView();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txbMaMH = new System.Windows.Forms.TextBox();
            this.txbTenMH = new System.Windows.Forms.TextBox();
            this.txbIDLH = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvMH);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(256, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 581);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btnEdit,
            this.toolStripSeparator3,
            this.btnAdd,
            this.toolStripSeparator1,
            this.btnDelete,
            this.toolStripSeparator4,
            this.btnCancel,
            this.toolStripSeparator5});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(657, 25);
            this.bindingNavigator1.TabIndex = 10;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeftAutoMirrorImage = true;
            this.btnEdit.Size = new System.Drawing.Size(47, 22);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(49, 22);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(60, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeftAutoMirrorImage = true;
            this.btnCancel.Size = new System.Drawing.Size(63, 22);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(657, 562);
            this.dataGridView1.TabIndex = 3;
            // 
            // dgvMH
            // 
            this.dgvMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMH.Location = new System.Drawing.Point(3, 41);
            this.dgvMH.Name = "dgvMH";
            this.dgvMH.Size = new System.Drawing.Size(657, 537);
            this.dgvMH.TabIndex = 12;
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Location = new System.Drawing.Point(-3, 2);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage2,
            this.navigationPage1});
            this.navigationPane1.RegularSize = new System.Drawing.Size(259, 308);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(259, 308);
            this.navigationPane1.TabIndex = 13;
            this.navigationPane1.Text = "Nhập";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Nhập Mặt Hàng";
            this.navigationPage2.Controls.Add(this.txbIDLH);
            this.navigationPage2.Controls.Add(this.txbTenMH);
            this.navigationPage2.Controls.Add(this.txbMaMH);
            this.navigationPage2.Controls.Add(this.labelControl3);
            this.navigationPage2.Controls.Add(this.labelControl2);
            this.navigationPage2.Controls.Add(this.labelControl1);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(130, 235);
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Nhập loại hàng";
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(130, 235);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(4, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã MH";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(0, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên MH";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(0, 158);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "ID_LoaiHang";
            // 
            // txbMaMH
            // 
            this.txbMaMH.Location = new System.Drawing.Point(4, 46);
            this.txbMaMH.Name = "txbMaMH";
            this.txbMaMH.Size = new System.Drawing.Size(100, 20);
            this.txbMaMH.TabIndex = 4;
            // 
            // txbTenMH
            // 
            this.txbTenMH.Location = new System.Drawing.Point(0, 110);
            this.txbTenMH.Name = "txbTenMH";
            this.txbTenMH.Size = new System.Drawing.Size(100, 20);
            this.txbTenMH.TabIndex = 5;
            // 
            // txbIDLH
            // 
            this.txbIDLH.Location = new System.Drawing.Point(3, 177);
            this.txbIDLH.Name = "txbIDLH";
            this.txbIDLH.Size = new System.Drawing.Size(100, 20);
            this.txbIDLH.TabIndex = 6;
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 578);
            this.Controls.Add(this.navigationPane1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanLy";
            this.Text = "frmQuanLy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLy_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMH;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private System.Windows.Forms.TextBox txbIDLH;
        private System.Windows.Forms.TextBox txbTenMH;
        private System.Windows.Forms.TextBox txbMaMH;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
    }
}