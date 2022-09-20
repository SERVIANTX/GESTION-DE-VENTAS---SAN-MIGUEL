namespace Proyecto_de_gestion_de_ventas
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Sp_RptClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Gestion_VentaBDDataSet = new Proyecto_de_gestion_de_ventas.Gestion_VentaBDDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtcad = new System.Windows.Forms.TextBox();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbtelefono = new System.Windows.Forms.RadioButton();
            this.rbNumdoc = new System.Windows.Forms.RadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Sp_RptClientesTableAdapter = new Proyecto_de_gestion_de_ventas.Gestion_VentaBDDataSetTableAdapters.Sp_RptClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_RptClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_VentaBDDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sp_RptClientesBindingSource
            // 
            this.Sp_RptClientesBindingSource.DataMember = "Sp_RptClientes";
            this.Sp_RptClientesBindingSource.DataSource = this.Gestion_VentaBDDataSet;
            // 
            // Gestion_VentaBDDataSet
            // 
            this.Gestion_VentaBDDataSet.DataSetName = "Gestion_VentaBDDataSet";
            this.Gestion_VentaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMostrar);
            this.groupBox1.Controls.Add(this.txtcad);
            this.groupBox1.Controls.Add(this.rbNombre);
            this.groupBox1.Controls.Add(this.rbtelefono);
            this.groupBox1.Controls.Add(this.rbNumdoc);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(208, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 89);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.DarkGray;
            this.btnMostrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMostrar.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrar.Image")));
            this.btnMostrar.Location = new System.Drawing.Point(692, 34);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(146, 42);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtcad
            // 
            this.txtcad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcad.Location = new System.Drawing.Point(384, 40);
            this.txtcad.Name = "txtcad";
            this.txtcad.Size = new System.Drawing.Size(281, 29);
            this.txtcad.TabIndex = 4;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNombre.Location = new System.Drawing.Point(279, 41);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(99, 27);
            this.rbNombre.TabIndex = 3;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            this.rbNombre.CheckedChanged += new System.EventHandler(this.rbNombre_CheckedChanged);
            // 
            // rbtelefono
            // 
            this.rbtelefono.AutoSize = true;
            this.rbtelefono.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtelefono.Location = new System.Drawing.Point(170, 41);
            this.rbtelefono.Name = "rbtelefono";
            this.rbtelefono.Size = new System.Drawing.Size(105, 27);
            this.rbtelefono.TabIndex = 2;
            this.rbtelefono.Text = "Teléfono";
            this.rbtelefono.UseVisualStyleBackColor = true;
            this.rbtelefono.CheckedChanged += new System.EventHandler(this.rbtelefono_CheckedChanged);
            // 
            // rbNumdoc
            // 
            this.rbNumdoc.AutoSize = true;
            this.rbNumdoc.Checked = true;
            this.rbNumdoc.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNumdoc.Location = new System.Drawing.Point(13, 41);
            this.rbNumdoc.Name = "rbNumdoc";
            this.rbNumdoc.Size = new System.Drawing.Size(157, 27);
            this.rbNumdoc.TabIndex = 1;
            this.rbNumdoc.TabStop = true;
            this.rbNumdoc.Text = "N° Documento";
            this.rbNumdoc.UseVisualStyleBackColor = true;
            this.rbNumdoc.CheckedChanged += new System.EventHandler(this.rbNumdoc_CheckedChanged);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sp_RptClientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_de_gestion_de_ventas.RptCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(162, 245);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(964, 491);
            this.reportViewer1.TabIndex = 6;
            // 
            // Sp_RptClientesTableAdapter
            // 
            this.Sp_RptClientesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1354, 832);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmClientes";
            this.Text = "Reporte de Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sp_RptClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_VentaBDDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtcad;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbtelefono;
        private System.Windows.Forms.RadioButton rbNumdoc;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sp_RptClientesBindingSource;
        private Gestion_VentaBDDataSet Gestion_VentaBDDataSet;
        private Gestion_VentaBDDataSetTableAdapters.Sp_RptClientesTableAdapter Sp_RptClientesTableAdapter;
    }
}