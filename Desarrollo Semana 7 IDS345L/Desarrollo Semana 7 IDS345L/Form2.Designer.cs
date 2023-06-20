namespace Desarrollo_Semana_7_IDS345L
{
    partial class Form2
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
            this.tblClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDCajaDataSet = new Desarrollo_Semana_7_IDS345L.BDCajaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bDCajaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblClienteTableAdapter = new Desarrollo_Semana_7_IDS345L.BDCajaDataSetTableAdapters.tblClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDCajaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDCajaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblClienteBindingSource
            // 
            this.tblClienteBindingSource.DataMember = "tblCliente";
            this.tblClienteBindingSource.DataSource = this.bDCajaDataSet;
            // 
            // bDCajaDataSet
            // 
            this.bDCajaDataSet.DataSetName = "BDCajaDataSet";
            this.bDCajaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Desarrollo_Semana_7_IDS345L.ReporteComprobante.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1043, 727);
            this.reportViewer1.TabIndex = 0;
            // 
            // bDCajaDataSetBindingSource
            // 
            this.bDCajaDataSetBindingSource.DataSource = this.bDCajaDataSet;
            this.bDCajaDataSetBindingSource.Position = 0;
            // 
            // tblClienteTableAdapter
            // 
            this.tblClienteTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 727);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDCajaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDCajaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BDCajaDataSet bDCajaDataSet;
        private System.Windows.Forms.BindingSource bDCajaDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblClienteBindingSource;
        private BDCajaDataSetTableAdapters.tblClienteTableAdapter tblClienteTableAdapter;
    }
}