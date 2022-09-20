namespace Proyecto_de_gestion_de_ventas
{
    partial class FrmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            this.label5 = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumdoc = new System.Windows.Forms.TextBox();
            this.CmbPersonal = new System.Windows.Forms.ComboBox();
            this.cmbTpDoc = new System.Windows.Forms.ComboBox();
            this.CmbSucursal = new System.Windows.Forms.ComboBox();
            this.txtIdprod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nudcantidad = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtprecioVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdcliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.cmbTDB = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNDocB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtsubTotal = new System.Windows.Forms.TextBox();
            this.cmbGarantia = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMGarantia = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNumserie = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(244, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 28);
            this.label5.TabIndex = 54;
            this.label5.Text = "Personal";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.DarkGray;
            this.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.Location = new System.Drawing.Point(1018, 381);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(169, 54);
            this.BtnNuevo.TabIndex = 16;
            this.BtnNuevo.Text = "Agregar";
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.Location = new System.Drawing.Point(1018, 259);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(180, 76);
            this.BtnAgregar.TabIndex = 18;
            this.BtnAgregar.Text = "Registrar Venta";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(171, 537);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1063, 234);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(258, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 28);
            this.label1.TabIndex = 56;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(177, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 28);
            this.label2.TabIndex = 57;
            this.label2.Text = "Tipo Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(145, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 28);
            this.label3.TabIndex = 58;
            this.label3.Text = "Numero Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(747, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 28);
            this.label4.TabIndex = 59;
            this.label4.Text = "Sucursal";
            // 
            // txtNumdoc
            // 
            this.txtNumdoc.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumdoc.Location = new System.Drawing.Point(385, 214);
            this.txtNumdoc.Name = "txtNumdoc";
            this.txtNumdoc.Size = new System.Drawing.Size(177, 36);
            this.txtNumdoc.TabIndex = 3;
            this.txtNumdoc.TextChanged += new System.EventHandler(this.txtNumdoc_TextChanged);
            this.txtNumdoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumdoc_KeyPress);
            // 
            // CmbPersonal
            // 
            this.CmbPersonal.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPersonal.FormattingEnabled = true;
            this.CmbPersonal.Location = new System.Drawing.Point(385, 29);
            this.CmbPersonal.Name = "CmbPersonal";
            this.CmbPersonal.Size = new System.Drawing.Size(226, 36);
            this.CmbPersonal.TabIndex = 1;
            // 
            // cmbTpDoc
            // 
            this.cmbTpDoc.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTpDoc.FormattingEnabled = true;
            this.cmbTpDoc.Location = new System.Drawing.Point(385, 166);
            this.cmbTpDoc.Name = "cmbTpDoc";
            this.cmbTpDoc.Size = new System.Drawing.Size(177, 36);
            this.cmbTpDoc.TabIndex = 2;
            this.cmbTpDoc.SelectedIndexChanged += new System.EventHandler(this.cmbTpDoc_SelectedIndexChanged);
            // 
            // CmbSucursal
            // 
            this.CmbSucursal.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSucursal.FormattingEnabled = true;
            this.CmbSucursal.Location = new System.Drawing.Point(888, 118);
            this.CmbSucursal.Name = "CmbSucursal";
            this.CmbSucursal.Size = new System.Drawing.Size(205, 36);
            this.CmbSucursal.TabIndex = 7;
            this.CmbSucursal.SelectedIndexChanged += new System.EventHandler(this.CmbSucursal_SelectedIndexChanged);
            // 
            // txtIdprod
            // 
            this.txtIdprod.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdprod.Location = new System.Drawing.Point(270, 333);
            this.txtIdprod.Name = "txtIdprod";
            this.txtIdprod.ReadOnly = true;
            this.txtIdprod.Size = new System.Drawing.Size(92, 36);
            this.txtIdprod.TabIndex = 30;
            this.txtIdprod.TextChanged += new System.EventHandler(this.txtIdprod_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(266, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 28);
            this.label7.TabIndex = 71;
            this.label7.Text = "IdProducto";
            // 
            // cmbProducto
            // 
            this.cmbProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProducto.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(459, 333);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(152, 36);
            this.cmbProducto.TabIndex = 9;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(489, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 28);
            this.label11.TabIndex = 69;
            this.label11.Text = "Producto";
            // 
            // nudcantidad
            // 
            this.nudcantidad.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudcantidad.Location = new System.Drawing.Point(494, 408);
            this.nudcantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudcantidad.Name = "nudcantidad";
            this.nudcantidad.Size = new System.Drawing.Size(73, 36);
            this.nudcantidad.TabIndex = 10;
            this.nudcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudcantidad.ValueChanged += new System.EventHandler(this.nudcantidad_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(486, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 28);
            this.label6.TabIndex = 91;
            this.label6.Text = "Cantidad";
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenta.Location = new System.Drawing.Point(888, 161);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(136, 36);
            this.dtpFechaVenta.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(686, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 28);
            this.label8.TabIndex = 93;
            this.label8.Text = "Fecha de Venta";
            // 
            // txtprecioVenta
            // 
            this.txtprecioVenta.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecioVenta.Location = new System.Drawing.Point(685, 333);
            this.txtprecioVenta.Name = "txtprecioVenta";
            this.txtprecioVenta.ReadOnly = true;
            this.txtprecioVenta.Size = new System.Drawing.Size(136, 36);
            this.txtprecioVenta.TabIndex = 12;
            this.txtprecioVenta.Text = "0";
            this.txtprecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecioVenta_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(681, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 28);
            this.label9.TabIndex = 95;
            this.label9.Text = "Precio Unitario";
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.DarkGray;
            this.btnQuitar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.Location = new System.Drawing.Point(1018, 459);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(169, 54);
            this.btnQuitar.TabIndex = 17;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(385, 121);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(225, 36);
            this.txtCliente.TabIndex = 100;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(583, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 38);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(239, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 28);
            this.label10.TabIndex = 102;
            this.label10.Text = "IdCliente";
            // 
            // txtIdcliente
            // 
            this.txtIdcliente.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdcliente.Location = new System.Drawing.Point(385, 73);
            this.txtIdcliente.Name = "txtIdcliente";
            this.txtIdcliente.ReadOnly = true;
            this.txtIdcliente.Size = new System.Drawing.Size(78, 36);
            this.txtIdcliente.TabIndex = 103;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(287, 382);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 28);
            this.label12.TabIndex = 104;
            this.label12.Text = "Stock";
            // 
            // txtstock
            // 
            this.txtstock.Enabled = false;
            this.txtstock.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.Location = new System.Drawing.Point(268, 408);
            this.txtstock.Name = "txtstock";
            this.txtstock.ReadOnly = true;
            this.txtstock.Size = new System.Drawing.Size(107, 36);
            this.txtstock.TabIndex = 105;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(754, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 28);
            this.label13.TabIndex = 107;
            this.label13.Text = "Importe";
            // 
            // txtimporte
            // 
            this.txtimporte.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimporte.Location = new System.Drawing.Point(888, 211);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.ReadOnly = true;
            this.txtimporte.Size = new System.Drawing.Size(122, 36);
            this.txtimporte.TabIndex = 100;
            this.txtimporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtimporte_KeyPress);
            // 
            // cmbTDB
            // 
            this.cmbTDB.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTDB.FormattingEnabled = true;
            this.cmbTDB.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.cmbTDB.Location = new System.Drawing.Point(888, 26);
            this.cmbTDB.Name = "cmbTDB";
            this.cmbTDB.Size = new System.Drawing.Size(205, 36);
            this.cmbTDB.TabIndex = 5;
            this.cmbTDB.SelectedIndexChanged += new System.EventHandler(this.cmbTDB_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(649, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(233, 28);
            this.label14.TabIndex = 114;
            this.label14.Text = "Tipo De Documento";
            // 
            // txtNDocB
            // 
            this.txtNDocB.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNDocB.Location = new System.Drawing.Point(888, 70);
            this.txtNDocB.Name = "txtNDocB";
            this.txtNDocB.Size = new System.Drawing.Size(205, 36);
            this.txtNDocB.TabIndex = 6;
            this.txtNDocB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNDocB_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(691, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(181, 28);
            this.label15.TabIndex = 112;
            this.label15.Text = "N° Documento ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(707, 381);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 28);
            this.label16.TabIndex = 116;
            this.label16.Text = "SubTotal";
            // 
            // txtsubTotal
            // 
            this.txtsubTotal.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubTotal.Location = new System.Drawing.Point(686, 407);
            this.txtsubTotal.Name = "txtsubTotal";
            this.txtsubTotal.ReadOnly = true;
            this.txtsubTotal.Size = new System.Drawing.Size(136, 36);
            this.txtsubTotal.TabIndex = 13;
            this.txtsubTotal.Text = "0";
            this.txtsubTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsubTotal_KeyPress);
            // 
            // cmbGarantia
            // 
            this.cmbGarantia.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGarantia.FormattingEnabled = true;
            this.cmbGarantia.Items.AddRange(new object[] {
            "Tiene Garantia",
            "No tiene Garantia"});
            this.cmbGarantia.Location = new System.Drawing.Point(234, 482);
            this.cmbGarantia.Name = "cmbGarantia";
            this.cmbGarantia.Size = new System.Drawing.Size(177, 36);
            this.cmbGarantia.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(271, 456);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 28);
            this.label17.TabIndex = 119;
            this.label17.Text = "Garantia";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(455, 456);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(222, 28);
            this.label18.TabIndex = 120;
            this.label18.Text = "Meses de Garantia";
            // 
            // txtMGarantia
            // 
            this.txtMGarantia.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMGarantia.Location = new System.Drawing.Point(493, 482);
            this.txtMGarantia.Name = "txtMGarantia";
            this.txtMGarantia.Size = new System.Drawing.Size(73, 36);
            this.txtMGarantia.TabIndex = 12;
            this.txtMGarantia.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.Location = new System.Drawing.Point(681, 456);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(201, 28);
            this.label19.TabIndex = 121;
            this.label19.Text = "Número de Serie";
            // 
            // txtNumserie
            // 
            this.txtNumserie.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumserie.Location = new System.Drawing.Point(685, 483);
            this.txtNumserie.Name = "txtNumserie";
            this.txtNumserie.Size = new System.Drawing.Size(136, 36);
            this.txtNumserie.TabIndex = 13;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.DarkGray;
            this.iconButton1.Enabled = false;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.iconButton1.IconColor = System.Drawing.Color.Maroon;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(1188, 39);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(125, 57);
            this.iconButton1.TabIndex = 122;
            this.iconButton1.Text = "Anular Venta";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Visible = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1338, 793);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.txtNumserie);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtMGarantia);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmbGarantia);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtsubTotal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbTDB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNDocB);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtimporte);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtIdcliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.txtprecioVenta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudcantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdprod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CmbSucursal);
            this.Controls.Add(this.cmbTpDoc);
            this.Controls.Add(this.CmbPersonal);
            this.Controls.Add(this.txtNumdoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnAgregar);
            this.Name = "FrmVenta";
            this.Text = "Registro de Ventas";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumdoc;
        private System.Windows.Forms.ComboBox CmbPersonal;
        private System.Windows.Forms.ComboBox cmbTpDoc;
        private System.Windows.Forms.ComboBox CmbSucursal;
        private System.Windows.Forms.TextBox txtIdprod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudcantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtprecioVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdcliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.ComboBox cmbTDB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNDocB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtsubTotal;
        private System.Windows.Forms.ComboBox cmbGarantia;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMGarantia;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNumserie;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}