namespace Apresentacao
{
    partial class FrmRelatorioOs
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OFICINADataSet10 = new Apresentacao.OFICINADataSet10();
            this.OSTableAdapter = new Apresentacao.OFICINADataSet10TableAdapters.OSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OFICINADataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Apresentacao.ReportOrdemServico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(552, 352);
            this.reportViewer1.TabIndex = 0;
            // 
            // OSBindingSource
            // 
            this.OSBindingSource.DataMember = "OS";
            this.OSBindingSource.DataSource = this.OFICINADataSet10;
            // 
            // OFICINADataSet10
            // 
            this.OFICINADataSet10.DataSetName = "OFICINADataSet10";
            this.OFICINADataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OSTableAdapter
            // 
            this.OSTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorioOs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 352);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRelatorioOs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRelatorioOs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelatorioOs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OFICINADataSet10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OSBindingSource;
        private OFICINADataSet10 OFICINADataSet10;
        private OFICINADataSet10TableAdapters.OSTableAdapter OSTableAdapter;
    }
}