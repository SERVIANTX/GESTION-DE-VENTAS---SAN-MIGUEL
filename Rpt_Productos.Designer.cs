namespace Proyecto_de_gestion_de_ventas
{
    partial class Rpt_Productos
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
            this.Sp_RptProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Gestion_VentaBDDataSet = new Proyecto_de_gestion_de_ventas.Gestion_VentaBDDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Sp_RptProductosTableAdapter = new Proyecto_de_gestion_de_ventas.Gestion_VentaBDDataSetTableAdapters.Sp_RptProductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_RptProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_VentaBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Sp_RptProductosBindingSource
            // 
            this.Sp_RptProductosBindingSource.DataMember = "Sp_RptProductos";
            this.Sp_RptProductosBindingSource.DataSource = this.Gestion_VentaBDDataSet;
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
            reportDataSource1.Value = this.Sp_RptProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_de_gestion_de_ventas.Rpt_Productos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(633, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Sp_RptProductosTableAdapter
            // 
            this.Sp_RptProductosTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_Productos";
            this.Text = "Reporte de Productos";
            this.Load += new System.EventHandler(this.Rpt_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sp_RptProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_VentaBDDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource Sp_RptProductosBindingSource;
        private Gestion_VentaBDDataSet Gestion_VentaBDDataSet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Gestion_VentaBDDataSetTableAdapters.Sp_RptProductosTableAdapter Sp_RptProductosTableAdapter;
    }
}