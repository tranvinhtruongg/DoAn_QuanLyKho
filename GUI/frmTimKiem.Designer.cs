
namespace GUI
{
    partial class frmTimKiem
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
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txbMatHang = new System.Windows.Forms.TextBox();
            this.cmbLoaiHang = new System.Windows.Forms.ComboBox();
            this.dgvTimKem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKem)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.navigationPage2);
            this.navigationFrame1.Location = new System.Drawing.Point(-2, 2);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage2});
            this.navigationFrame1.SelectedPage = this.navigationPage2;
            this.navigationFrame1.Size = new System.Drawing.Size(217, 451);
            this.navigationFrame1.TabIndex = 0;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "navigationPage2";
            this.navigationPage2.Controls.Add(this.btnTimKiem);
            this.navigationPage2.Controls.Add(this.labelControl2);
            this.navigationPage2.Controls.Add(this.labelControl1);
            this.navigationPage2.Controls.Add(this.txbMatHang);
            this.navigationPage2.Controls.Add(this.cmbLoaiHang);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(217, 451);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.Location = new System.Drawing.Point(47, 300);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(121, 47);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(47, 172);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mặt hàng";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(47, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Loại hàng";
            // 
            // txbMatHang
            // 
            this.txbMatHang.Location = new System.Drawing.Point(47, 205);
            this.txbMatHang.Name = "txbMatHang";
            this.txbMatHang.Size = new System.Drawing.Size(100, 20);
            this.txbMatHang.TabIndex = 1;
            // 
            // cmbLoaiHang
            // 
            this.cmbLoaiHang.FormattingEnabled = true;
            this.cmbLoaiHang.Location = new System.Drawing.Point(47, 75);
            this.cmbLoaiHang.Name = "cmbLoaiHang";
            this.cmbLoaiHang.Size = new System.Drawing.Size(121, 21);
            this.cmbLoaiHang.TabIndex = 0;
            // 
            // dgvTimKem
            // 
            this.dgvTimKem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTimKem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimKem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKem.Location = new System.Drawing.Point(221, 2);
            this.dgvTimKem.Name = "dgvTimKem";
            this.dgvTimKem.Size = new System.Drawing.Size(580, 451);
            this.dgvTimKem.TabIndex = 1;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTimKem);
            this.Controls.Add(this.navigationFrame1);
            this.Name = "frmTimKiem";
            this.Text = "frmTimKiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txbMatHang;
        private System.Windows.Forms.DataGridView dgvTimKem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbLoaiHang;
    }
}