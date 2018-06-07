namespace Projeto
{
    partial class dgRelatorio
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
            this.PROJETODataSet = new Projeto.PROJETODataSet();
            this.CLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CLIENTETableAdapter = new Projeto.PROJETODataSetTableAdapters.CLIENTETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PROJETODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "client";
            reportDataSource1.Value = this.CLIENTEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto.Rcliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // PROJETODataSet
            // 
            this.PROJETODataSet.DataSetName = "PROJETODataSet";
            this.PROJETODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CLIENTEBindingSource
            // 
            this.CLIENTEBindingSource.DataMember = "CLIENTE";
            this.CLIENTEBindingSource.DataSource = this.PROJETODataSet;
            // 
            // CLIENTETableAdapter
            // 
            this.CLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // dgRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "dgRelatorio";
            this.Text = "dgRelatorio";
            this.Load += new System.EventHandler(this.dgRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PROJETODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CLIENTEBindingSource;
        private PROJETODataSet PROJETODataSet;
        private PROJETODataSetTableAdapters.CLIENTETableAdapter CLIENTETableAdapter;
    }
}