namespace Apresentacao
{
    partial class FrmRelatorioCliente
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
            this.OFICINADataSetRelatorioCliente = new Apresentacao.OFICINADataSetRelatorioCliente();
            this.CLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CLIENTETableAdapter = new Apresentacao.OFICINADataSetRelatorioClienteTableAdapters.CLIENTETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OFICINADataSetRelatorioCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "Relatorio_Cliente";
            reportDataSource2.Value = this.CLIENTEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Apresentacao.ReportCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(595, 379);
            this.reportViewer1.TabIndex = 0;
            // 
            // OFICINADataSetRelatorioCliente
            // 
            this.OFICINADataSetRelatorioCliente.DataSetName = "OFICINADataSetRelatorioCliente";
            this.OFICINADataSetRelatorioCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CLIENTEBindingSource
            // 
            this.CLIENTEBindingSource.DataMember = "CLIENTE";
            this.CLIENTEBindingSource.DataSource = this.OFICINADataSetRelatorioCliente;
            // 
            // CLIENTETableAdapter
            // 
            this.CLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 379);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRelatorioCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRelatorioCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelatorioCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OFICINADataSetRelatorioCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CLIENTEBindingSource;
        private OFICINADataSetRelatorioCliente OFICINADataSetRelatorioCliente;
        private OFICINADataSetRelatorioClienteTableAdapters.CLIENTETableAdapter CLIENTETableAdapter;
    }
}