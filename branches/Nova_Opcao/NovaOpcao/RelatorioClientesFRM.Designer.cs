﻿namespace NovaOpcao
{
    partial class RelatorioClientesFRM
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
            this.CLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NOVAOPCAODBDataSetCLIENTES = new NovaOpcao.NOVAOPCAODBDataSetCLIENTES();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CLIENTETableAdapter = new NovaOpcao.NOVAOPCAODBDataSetCLIENTESTableAdapters.CLIENTETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOVAOPCAODBDataSetCLIENTES)).BeginInit();
            this.SuspendLayout();
            // 
            // CLIENTEBindingSource
            // 
            this.CLIENTEBindingSource.DataMember = "CLIENTE";
            this.CLIENTEBindingSource.DataSource = this.NOVAOPCAODBDataSetCLIENTES;
            // 
            // NOVAOPCAODBDataSetCLIENTES
            // 
            this.NOVAOPCAODBDataSetCLIENTES.DataSetName = "NOVAOPCAODBDataSetCLIENTES";
            this.NOVAOPCAODBDataSetCLIENTES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Clientes";
            reportDataSource1.Value = this.CLIENTEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NovaOpcao.RelatorioClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1059, 437);
            this.reportViewer1.TabIndex = 0;
            // 
            // CLIENTETableAdapter
            // 
            this.CLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioClientesFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 437);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelatorioClientesFRM";
            this.Text = "RelatorioClientes";
            this.Load += new System.EventHandler(this.RelatorioClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOVAOPCAODBDataSetCLIENTES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CLIENTEBindingSource;
        private NOVAOPCAODBDataSetCLIENTES NOVAOPCAODBDataSetCLIENTES;
        private NOVAOPCAODBDataSetCLIENTESTableAdapters.CLIENTETableAdapter CLIENTETableAdapter;
    }
}