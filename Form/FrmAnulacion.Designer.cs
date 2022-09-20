
namespace Proyecto_de_gestion_de_ventas
{
    partial class FrmAnulacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnulacion));
            this.cmbTDB = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNDocB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAnular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtidVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidpro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombrep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcan = new System.Windows.Forms.TextBox();
            this.txtstockmin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtidalmacen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAnularp = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTDB
            // 
            this.cmbTDB.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTDB.FormattingEnabled = true;
            this.cmbTDB.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.cmbTDB.Location = new System.Drawing.Point(173, 91);
            this.cmbTDB.Name = "cmbTDB";
            this.cmbTDB.Size = new System.Drawing.Size(164, 28);
            this.cmbTDB.TabIndex = 115;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(14, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 20);
            this.label14.TabIndex = 118;
            this.label14.Text = "Tipo De Documento";
            // 
            // txtNDocB
            // 
            this.txtNDocB.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNDocB.Location = new System.Drawing.Point(173, 135);
            this.txtNDocB.Name = "txtNDocB";
            this.txtNDocB.Size = new System.Drawing.Size(164, 27);
            this.txtNDocB.TabIndex = 116;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(47, 138);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 20);
            this.label15.TabIndex = 117;
            this.label15.Text = "N° Documento ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(467, 371);
            this.dataGridView1.TabIndex = 119;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.DarkGray;
            this.btnAnular.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.Location = new System.Drawing.Point(907, 483);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(128, 58);
            this.btnAnular.TabIndex = 120;
            this.btnAnular.Text = "Anular Venta";
            this.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(353, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 42);
            this.button1.TabIndex = 121;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtidVenta
            // 
            this.txtidVenta.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidVenta.Location = new System.Drawing.Point(173, 12);
            this.txtidVenta.Name = "txtidVenta";
            this.txtidVenta.ReadOnly = true;
            this.txtidVenta.Size = new System.Drawing.Size(67, 27);
            this.txtidVenta.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(93, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 123;
            this.label1.Text = "Id Venta";
            // 
            // txtidpro
            // 
            this.txtidpro.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidpro.Location = new System.Drawing.Point(586, 45);
            this.txtidpro.Name = "txtidpro";
            this.txtidpro.ReadOnly = true;
            this.txtidpro.Size = new System.Drawing.Size(78, 27);
            this.txtidpro.TabIndex = 125;
            this.txtidpro.TextChanged += new System.EventHandler(this.txtidpro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(485, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 126;
            this.label2.Text = "Id Producto";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(506, 191);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(529, 278);
            this.dataGridView2.TabIndex = 127;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(502, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 128;
            this.label3.Text = "Nombre";
            // 
            // txtnombrep
            // 
            this.txtnombrep.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrep.Location = new System.Drawing.Point(586, 91);
            this.txtnombrep.Name = "txtnombrep";
            this.txtnombrep.ReadOnly = true;
            this.txtnombrep.Size = new System.Drawing.Size(102, 27);
            this.txtnombrep.TabIndex = 129;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(502, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 130;
            this.label4.Text = "Cantidad";
            // 
            // txtcan
            // 
            this.txtcan.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcan.Location = new System.Drawing.Point(586, 135);
            this.txtcan.Name = "txtcan";
            this.txtcan.ReadOnly = true;
            this.txtcan.Size = new System.Drawing.Size(102, 27);
            this.txtcan.TabIndex = 131;
            // 
            // txtstockmin
            // 
            this.txtstockmin.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstockmin.Location = new System.Drawing.Point(785, 45);
            this.txtstockmin.Name = "txtstockmin";
            this.txtstockmin.ReadOnly = true;
            this.txtstockmin.Size = new System.Drawing.Size(102, 27);
            this.txtstockmin.TabIndex = 133;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(692, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 132;
            this.label5.Text = "Stock Min.";
            // 
            // txtcosto
            // 
            this.txtcosto.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcosto.Location = new System.Drawing.Point(785, 91);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.ReadOnly = true;
            this.txtcosto.Size = new System.Drawing.Size(102, 27);
            this.txtcosto.TabIndex = 135;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(729, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 134;
            this.label6.Text = "Costo";
            // 
            // txtprecio
            // 
            this.txtprecio.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(785, 135);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.ReadOnly = true;
            this.txtprecio.Size = new System.Drawing.Size(102, 27);
            this.txtprecio.TabIndex = 137;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(724, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 136;
            this.label7.Text = "Precio";
            // 
            // txtidalmacen
            // 
            this.txtidalmacen.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidalmacen.Location = new System.Drawing.Point(173, 48);
            this.txtidalmacen.Name = "txtidalmacen";
            this.txtidalmacen.ReadOnly = true;
            this.txtidalmacen.Size = new System.Drawing.Size(132, 27);
            this.txtidalmacen.TabIndex = 138;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(93, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 139;
            this.label8.Text = "Sucursal";
            // 
            // btnAnularp
            // 
            this.btnAnularp.BackColor = System.Drawing.Color.DarkGray;
            this.btnAnularp.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnularp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAnularp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnularp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnularp.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.btnAnularp.IconColor = System.Drawing.Color.White;
            this.btnAnularp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnularp.IconSize = 30;
            this.btnAnularp.Location = new System.Drawing.Point(916, 102);
            this.btnAnularp.Name = "btnAnularp";
            this.btnAnularp.Size = new System.Drawing.Size(128, 56);
            this.btnAnularp.TabIndex = 140;
            this.btnAnularp.Text = "Anular Producto";
            this.btnAnularp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnularp.UseVisualStyleBackColor = false;
            this.btnAnularp.Click += new System.EventHandler(this.btnAnularp_Click);
            // 
            // FrmAnulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1071, 597);
            this.Controls.Add(this.btnAnularp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtidalmacen);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtstockmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnombrep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidpro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidVenta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbTDB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNDocB);
            this.Controls.Add(this.label15);
            this.Name = "FrmAnulacion";
            this.Text = "FrmAnulacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTDB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNDocB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtidVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidpro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombrep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcan;
        private System.Windows.Forms.TextBox txtstockmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtidalmacen;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnAnularp;
    }
}