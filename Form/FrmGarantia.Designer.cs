namespace Proyecto_de_gestion_de_ventas
{
    partial class FrmGarantia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGarantia));
            this.txtMD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpGara = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbApro = new System.Windows.Forms.RadioButton();
            this.rbdRechazado = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdGa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnumdoc = new System.Windows.Forms.TextBox();
            this.txtIdcliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNDocB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbTDB = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtidventa = new System.Windows.Forms.TextBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTPDoc = new System.Windows.Forms.TextBox();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmeses = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtGaran = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblaprobo = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtticket = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMD
            // 
            this.txtMD.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMD.Location = new System.Drawing.Point(936, 175);
            this.txtMD.Name = "txtMD";
            this.txtMD.Size = new System.Drawing.Size(230, 36);
            this.txtMD.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(976, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 28);
            this.label4.TabIndex = 58;
            this.label4.Text = "Observaciones";
            // 
            // dtpGara
            // 
            this.dtpGara.CustomFormat = "yyyy-MM-dd";
            this.dtpGara.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGara.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGara.Location = new System.Drawing.Point(705, 268);
            this.dtpGara.Name = "dtpGara";
            this.dtpGara.Size = new System.Drawing.Size(161, 36);
            this.dtpGara.TabIndex = 5;
            this.dtpGara.ValueChanged += new System.EventHandler(this.dtpGara_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(683, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 28);
            this.label2.TabIndex = 54;
            this.label2.Text = "Fecha de Uso Garantia";
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnQuitar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuitar.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("BtnQuitar.Image")));
            this.BtnQuitar.Location = new System.Drawing.Point(1048, 361);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(189, 45);
            this.BtnQuitar.TabIndex = 9;
            this.BtnQuitar.Text = "Nuevo";
            this.BtnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnQuitar.UseVisualStyleBackColor = false;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.Image")));
            this.BtnActualizar.Location = new System.Drawing.Point(1048, 488);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(189, 48);
            this.BtnActualizar.TabIndex = 11;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.Location = new System.Drawing.Point(1048, 424);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(189, 47);
            this.BtnAgregar.TabIndex = 10;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(111, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 28);
            this.label1.TabIndex = 48;
            this.label1.Text = "N° Documento";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(601, 559);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(636, 233);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(739, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 28);
            this.label5.TabIndex = 61;
            this.label5.Text = "Aprobacion";
            // 
            // rdbApro
            // 
            this.rdbApro.AutoSize = true;
            this.rdbApro.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbApro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdbApro.Location = new System.Drawing.Point(731, 358);
            this.rdbApro.Name = "rdbApro";
            this.rdbApro.Size = new System.Drawing.Size(139, 32);
            this.rdbApro.TabIndex = 6;
            this.rdbApro.TabStop = true;
            this.rdbApro.Text = "Aprobado";
            this.rdbApro.UseVisualStyleBackColor = true;
            // 
            // rbdRechazado
            // 
            this.rbdRechazado.AutoSize = true;
            this.rbdRechazado.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdRechazado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbdRechazado.Location = new System.Drawing.Point(731, 392);
            this.rbdRechazado.Name = "rbdRechazado";
            this.rbdRechazado.Size = new System.Drawing.Size(152, 32);
            this.rbdRechazado.TabIndex = 7;
            this.rbdRechazado.TabStop = true;
            this.rbdRechazado.Text = "Rechazado";
            this.rbdRechazado.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(727, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 28);
            this.label6.TabIndex = 65;
            this.label6.Text = "Id Garantia";
            // 
            // txtIdGa
            // 
            this.txtIdGa.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdGa.Location = new System.Drawing.Point(753, 90);
            this.txtIdGa.Name = "txtIdGa";
            this.txtIdGa.ReadOnly = true;
            this.txtIdGa.Size = new System.Drawing.Size(63, 36);
            this.txtIdGa.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(87, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 28);
            this.label8.TabIndex = 68;
            this.label8.Text = "Tipo De Documento";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(77, 175);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(209, 36);
            this.txtCliente.TabIndex = 102;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(147, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 28);
            this.label7.TabIndex = 101;
            this.label7.Text = "Cliente";
            // 
            // txtnumdoc
            // 
            this.txtnumdoc.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumdoc.Location = new System.Drawing.Point(77, 340);
            this.txtnumdoc.Name = "txtnumdoc";
            this.txtnumdoc.ReadOnly = true;
            this.txtnumdoc.Size = new System.Drawing.Size(205, 36);
            this.txtnumdoc.TabIndex = 2;
            this.txtnumdoc.TextChanged += new System.EventHandler(this.txtnumdoc_TextChanged);
            this.txtnumdoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumdoc_KeyPress);
            // 
            // txtIdcliente
            // 
            this.txtIdcliente.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdcliente.Location = new System.Drawing.Point(144, 90);
            this.txtIdcliente.Name = "txtIdcliente";
            this.txtIdcliente.ReadOnly = true;
            this.txtIdcliente.Size = new System.Drawing.Size(78, 36);
            this.txtIdcliente.TabIndex = 106;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(140, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 28);
            this.label10.TabIndex = 105;
            this.label10.Text = "IdCliente";
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(23, 559);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.RowHeadersVisible = false;
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2.Size = new System.Drawing.Size(522, 233);
            this.dgv2.TabIndex = 107;
            this.dgv2.CurrentCellChanged += new System.EventHandler(this.dgv2_CurrentCellChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(106, 464);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 28);
            this.label9.TabIndex = 108;
            this.label9.Text = "N° Documento ";
            // 
            // txtNDocB
            // 
            this.txtNDocB.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNDocB.Location = new System.Drawing.Point(77, 500);
            this.txtNDocB.Name = "txtNDocB";
            this.txtNDocB.Size = new System.Drawing.Size(205, 36);
            this.txtNDocB.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(87, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 28);
            this.label11.TabIndex = 110;
            this.label11.Text = "Tipo De Documento";
            // 
            // cmbTDB
            // 
            this.cmbTDB.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTDB.FormattingEnabled = true;
            this.cmbTDB.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.cmbTDB.Location = new System.Drawing.Point(77, 419);
            this.cmbTDB.Name = "cmbTDB";
            this.cmbTDB.Size = new System.Drawing.Size(205, 36);
            this.cmbTDB.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(312, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 38);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtproducto
            // 
            this.txtproducto.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproducto.Location = new System.Drawing.Point(678, 175);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(205, 36);
            this.txtproducto.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(739, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 28);
            this.label12.TabIndex = 114;
            this.label12.Text = "Producto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(395, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 28);
            this.label13.TabIndex = 115;
            this.label13.Text = "IdVenta";
            // 
            // txtidventa
            // 
            this.txtidventa.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidventa.Location = new System.Drawing.Point(399, 90);
            this.txtidventa.Name = "txtidventa";
            this.txtidventa.ReadOnly = true;
            this.txtidventa.Size = new System.Drawing.Size(78, 36);
            this.txtidventa.TabIndex = 116;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(743, 506);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(205, 36);
            this.txtbuscar.TabIndex = 12;
            this.txtbuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(628, 509);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 28);
            this.label14.TabIndex = 117;
            this.label14.Text = "Buscar";
            // 
            // txtTPDoc
            // 
            this.txtTPDoc.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTPDoc.Location = new System.Drawing.Point(77, 258);
            this.txtTPDoc.Name = "txtTPDoc";
            this.txtTPDoc.ReadOnly = true;
            this.txtTPDoc.Size = new System.Drawing.Size(209, 36);
            this.txtTPDoc.TabIndex = 119;
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaVenta.Enabled = false;
            this.dtpFechaVenta.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaVenta.Location = new System.Drawing.Point(367, 175);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(152, 36);
            this.dtpFechaVenta.TabIndex = 120;
            this.dtpFechaVenta.ValueChanged += new System.EventHandler(this.dtpFechaVenta_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(363, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(185, 28);
            this.label15.TabIndex = 121;
            this.label15.Text = "Fecha de Venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(347, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 28);
            this.label3.TabIndex = 122;
            this.label3.Text = "Tiempo Transcurrido";
            // 
            // txtmeses
            // 
            this.txtmeses.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmeses.Location = new System.Drawing.Point(367, 359);
            this.txtmeses.Name = "txtmeses";
            this.txtmeses.ReadOnly = true;
            this.txtmeses.Size = new System.Drawing.Size(117, 36);
            this.txtmeses.TabIndex = 123;
            this.txtmeses.Text = "0";
            this.txtmeses.TextChanged += new System.EventHandler(this.txtmeses_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(377, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 28);
            this.label16.TabIndex = 124;
            this.label16.Text = "Cuenta Con ";
            // 
            // txtGaran
            // 
            this.txtGaran.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGaran.Location = new System.Drawing.Point(367, 258);
            this.txtGaran.Name = "txtGaran";
            this.txtGaran.ReadOnly = true;
            this.txtGaran.Size = new System.Drawing.Size(117, 36);
            this.txtGaran.TabIndex = 125;
            this.txtGaran.TextChanged += new System.EventHandler(this.txtGaran_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(490, 261);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 28);
            this.label17.TabIndex = 126;
            this.label17.Text = "Meses";
            // 
            // lblaprobo
            // 
            this.lblaprobo.AutoSize = true;
            this.lblaprobo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblaprobo.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaprobo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblaprobo.Location = new System.Drawing.Point(377, 419);
            this.lblaprobo.Name = "lblaprobo";
            this.lblaprobo.Size = new System.Drawing.Size(0, 28);
            this.lblaprobo.TabIndex = 127;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(490, 362);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 28);
            this.label18.TabIndex = 128;
            this.label18.Text = "Meses";
            // 
            // txtticket
            // 
            this.txtticket.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtticket.Location = new System.Drawing.Point(936, 268);
            this.txtticket.Name = "txtticket";
            this.txtticket.Size = new System.Drawing.Size(230, 36);
            this.txtticket.TabIndex = 129;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.Location = new System.Drawing.Point(1002, 226);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(118, 28);
            this.label19.TabIndex = 130;
            this.label19.Text = "N° Ticket";
            // 
            // FrmGarantia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1354, 832);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtticket);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblaprobo);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtGaran);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtmeses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTPDoc);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtidventa);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbTDB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNDocB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.txtIdcliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtnumdoc);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdGa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbdRechazado);
            this.Controls.Add(this.rdbApro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpGara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnQuitar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label1);
            this.Name = "FrmGarantia";
            this.Text = "Registro de Garantia";
            this.Load += new System.EventHandler(this.FrmGarantia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpGara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbApro;
        private System.Windows.Forms.RadioButton rbdRechazado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdGa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnumdoc;
        private System.Windows.Forms.TextBox txtIdcliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNDocB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbTDB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtidventa;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTPDoc;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmeses;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtGaran;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblaprobo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtticket;
        private System.Windows.Forms.Label label19;
    }
}