
namespace GUI
{
    partial class Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DA_QLKKDataSet2 = new GUI.DA_QLKKDataSet2();
            this.PHIEUXUATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PHIEUXUATTableAdapter = new GUI.DA_QLKKDataSet2TableAdapters.PHIEUXUATTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DA_QLKKDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHIEUXUATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "phieuxuat";
            reportDataSource2.Value = this.PHIEUXUATBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.BaoCao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(863, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DA_QLKKDataSet2
            // 
            this.DA_QLKKDataSet2.DataSetName = "DA_QLKKDataSet2";
            this.DA_QLKKDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PHIEUXUATBindingSource
            // 
            this.PHIEUXUATBindingSource.DataMember = "PHIEUXUAT";
            this.PHIEUXUATBindingSource.DataSource = this.DA_QLKKDataSet2;
            // 
            // PHIEUXUATTableAdapter
            // 
            this.PHIEUXUATTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DA_QLKKDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHIEUXUATBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PHIEUXUATBindingSource;
        private DA_QLKKDataSet2 DA_QLKKDataSet2;
        private DA_QLKKDataSet2TableAdapters.PHIEUXUATTableAdapter PHIEUXUATTableAdapter;
    }
}