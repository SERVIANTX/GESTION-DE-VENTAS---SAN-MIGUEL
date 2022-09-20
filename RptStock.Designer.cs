namespace Proyecto_de_gestion_de_ventas
{
    partial class RptStock
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
            this.Gestion_VentaBDDataSet = new Proyecto_de_gestion_de_ventas.Gestion_VentaBDDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Sp_RptStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sp_RptStockTableAdapter = new Proyecto_de_gestion_de_ventas.Gestion_VentaBDDataSetTableAdapters.Sp_RptStockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_VentaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_RptStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Gestion_VentaBDDataSet
            // 
            this.Gestion_VentaBDDataSet.DataSetName = "Gestion_VentaBDDataSet";
            this.Gestion_VentaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sp_RptStockBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_de_gestion_de_ventas.Rpt_Stock.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(761, 585);
            this.reportViewer1.TabIndex = 15;
            // 
            // Sp_RptStockBindingSource
            // 
            this.Sp_RptStockBindingSource.DataMember = "Sp_RptStock";
            this.Sp_RptStockBindingSource.DataSource = this.Gestion_VentaBDDataSet;
            // 
            // Sp_RptStockTableAdapter
            // 
            this.Sp_RptStockTableAdapter.ClearBeforeFill = true;
            // 
            // RptStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 585);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RptStock";
            this.Text = "Reporte de Stock";
            this.Load += new System.EventHandler(this.RptStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_VentaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_RptStockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Gestion_VentaBDDataSet Gestion_VentaBDDataSet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sp_RptStockBindingSource;
        private Gestion_VentaBDDataSetTableAdapters.Sp_RptStockTableAdapter Sp_RptStockTableAdapter;
    }
}