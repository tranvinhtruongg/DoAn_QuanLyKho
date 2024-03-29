﻿
namespace GUI
{
    partial class frmMH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMH));
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txbViTri = new System.Windows.Forms.TextBox();
            this.btnDSLH = new DevExpress.XtraEditors.SimpleButton();
            this.txbTenMH = new System.Windows.Forms.TextBox();
            this.txbIDLH = new System.Windows.Forms.TextBox();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMHH = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Edit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage2});
            this.navigationPane1.RegularSize = new System.Drawing.Size(407, 603);
            this.navigationPane1.SelectedPage = this.navigationPage2;
            this.navigationPane1.Size = new System.Drawing.Size(407, 603);
            this.navigationPane1.TabIndex = 33;
            this.navigationPane1.Text = "Nhập";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Nhập Mặt Hàng";
            this.navigationPage2.Controls.Add(this.labelControl1);
            this.navigationPage2.Controls.Add(this.txbViTri);
            this.navigationPage2.Controls.Add(this.btnDSLH);
            this.navigationPage2.Controls.Add(this.txbTenMH);
            this.navigationPage2.Controls.Add(this.txbIDLH);
            this.navigationPage2.Controls.Add(this.labelControl15);
            this.navigationPage2.Controls.Add(this.labelControl16);
            this.navigationPage2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(246, 513);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 105);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 17);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Vị Trí";
            // 
            // txbViTri
            // 
            this.txbViTri.Location = new System.Drawing.Point(7, 129);
            this.txbViTri.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txbViTri.Name = "txbViTri";
            this.txbViTri.Size = new System.Drawing.Size(153, 22);
            this.txbViTri.TabIndex = 8;
            // 
            // btnDSLH
            // 
            this.btnDSLH.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSLH.Appearance.Options.UseFont = true;
            this.btnDSLH.Location = new System.Drawing.Point(8, 282);
            this.btnDSLH.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDSLH.Name = "btnDSLH";
            this.btnDSLH.Size = new System.Drawing.Size(188, 52);
            this.btnDSLH.TabIndex = 7;
            this.btnDSLH.Text = "Hiển thị danh sách";
            this.btnDSLH.Click += new System.EventHandler(this.btnDSLH_Click);
            // 
            // txbTenMH
            // 
            this.txbTenMH.Location = new System.Drawing.Point(7, 68);
            this.txbTenMH.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txbTenMH.Name = "txbTenMH";
            this.txbTenMH.Size = new System.Drawing.Size(153, 22);
            this.txbTenMH.TabIndex = 5;
            // 
            // txbIDLH
            // 
            this.txbIDLH.Location = new System.Drawing.Point(7, 199);
            this.txbIDLH.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txbIDLH.Name = "txbIDLH";
            this.txbIDLH.Size = new System.Drawing.Size(153, 22);
            this.txbIDLH.TabIndex = 4;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(7, 36);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(40, 16);
            this.labelControl15.TabIndex = 1;
            this.labelControl15.Text = "Tên LH";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(7, 166);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(37, 16);
            this.labelControl16.TabIndex = 0;
            this.labelControl16.Text = "ID Kho";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvMHH);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Location = new System.Drawing.Point(409, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(979, 594);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý";
            // 
            // dgvMHH
            // 
            this.dgvMHH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMHH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMHH.Location = new System.Drawing.Point(4, 46);
            this.dgvMHH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMHH.Name = "dgvMHH";
            this.dgvMHH.RowHeadersWidth = 51;
            this.dgvMHH.Size = new System.Drawing.Size(971, 544);
            this.dgvMHH.TabIndex = 11;
            this.dgvMHH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMHH_CellClick);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.btnAdd,
            this.toolStripSeparator1,
            this.btnDelete,
            this.toolStripSeparator4,
            this.btnCancel,
            this.toolStripSeparator5,
            this.Edit});
            this.bindingNavigator1.Location = new System.Drawing.Point(4, 19);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(971, 27);
            this.bindingNavigator1.TabIndex = 10;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            this.btnAdd.Size = new System.Drawing.Size(61, 24);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
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
            this.btnDelete.Size = new System.Drawing.Size(77, 24);
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
            this.btnCancel.Size = new System.Drawing.Size(77, 24);
            this.btnCancel.Text = "Cancel";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // Edit
            // 
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(59, 24);
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click_1);
            // 
            // frmMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 603);
            this.Controls.Add(this.navigationPane1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMH";
            this.Text = "frmMH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txbViTri;
        private DevExpress.XtraEditors.SimpleButton btnDSLH;
        private System.Windows.Forms.TextBox txbTenMH;
        private System.Windows.Forms.TextBox txbIDLH;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton Edit;
        private System.Windows.Forms.DataGridView dgvMHH;
    }
}