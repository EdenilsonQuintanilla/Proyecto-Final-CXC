namespace Cuentas_Por_Cobrar2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtIdA = new System.Windows.Forms.TextBox();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.txtCn = new System.Windows.Forms.TextBox();
            this.txtPrec = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNrc = new System.Windows.Forms.TextBox();
            this.txtDirec = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtIdc = new System.Windows.Forms.TextBox();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnElimi = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirrecionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nRCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idarticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montopendienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechalimiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuentasporcobrarDataSet = new Cuentas_Por_Cobrar2.cuentasporcobrarDataSet();
            this.cuentasTableAdapter = new Cuentas_Por_Cobrar2.cuentasporcobrarDataSetTableAdapters.cuentasTableAdapter();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasporcobrarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.txtFecha);
            this.groupBox2.Controls.Add(this.txtMonto);
            this.groupBox2.Controls.Add(this.txtIdA);
            this.groupBox2.Controls.Add(this.txtDescr);
            this.groupBox2.Controls.Add(this.txtCn);
            this.groupBox2.Controls.Add(this.txtPrec);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(272, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 269);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Articulo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(144, 196);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(144, 233);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 8;
            this.txtFecha.Text = "aa-mm-dd";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(144, 162);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 7;
            // 
            // txtIdA
            // 
            this.txtIdA.Location = new System.Drawing.Point(144, 22);
            this.txtIdA.Name = "txtIdA";
            this.txtIdA.Size = new System.Drawing.Size(100, 20);
            this.txtIdA.TabIndex = 2;
            // 
            // txtDescr
            // 
            this.txtDescr.Location = new System.Drawing.Point(144, 59);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(100, 20);
            this.txtDescr.TabIndex = 3;
            // 
            // txtCn
            // 
            this.txtCn.Location = new System.Drawing.Point(144, 95);
            this.txtCn.Name = "txtCn";
            this.txtCn.Size = new System.Drawing.Size(100, 20);
            this.txtCn.TabIndex = 4;
            // 
            // txtPrec
            // 
            this.txtPrec.Location = new System.Drawing.Point(144, 125);
            this.txtPrec.Name = "txtPrec";
            this.txtPrec.Size = new System.Drawing.Size(100, 20);
            this.txtPrec.TabIndex = 6;
            this.txtPrec.Leave += new System.EventHandler(this.txtPrec_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Fecha Limitre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Montopendiente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Precio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Descripcion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID Articulo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNrc);
            this.groupBox1.Controls.Add(this.txtDirec);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.txtIdc);
            this.groupBox1.Controls.Add(this.txtDui);
            this.groupBox1.Controls.Add(this.txtNit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(36, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 249);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // txtNrc
            // 
            this.txtNrc.Location = new System.Drawing.Point(94, 195);
            this.txtNrc.Name = "txtNrc";
            this.txtNrc.Size = new System.Drawing.Size(100, 20);
            this.txtNrc.TabIndex = 7;
            // 
            // txtDirec
            // 
            this.txtDirec.Location = new System.Drawing.Point(94, 162);
            this.txtDirec.Name = "txtDirec";
            this.txtDirec.Size = new System.Drawing.Size(100, 20);
            this.txtDirec.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(94, 130);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 5;
            // 
            // txtIdc
            // 
            this.txtIdc.Location = new System.Drawing.Point(94, 18);
            this.txtIdc.Name = "txtIdc";
            this.txtIdc.Size = new System.Drawing.Size(100, 20);
            this.txtIdc.TabIndex = 1;
            this.txtIdc.TextChanged += new System.EventHandler(this.txtIdc_TextChanged);
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(94, 55);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(100, 20);
            this.txtDui.TabIndex = 2;
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(94, 96);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(100, 20);
            this.txtNit.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "NRC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DUI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "NIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombres";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(594, 227);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 29);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnElimi
            // 
            this.btnElimi.Location = new System.Drawing.Point(594, 136);
            this.btnElimi.Name = "btnElimi";
            this.btnElimi.Size = new System.Drawing.Size(100, 33);
            this.btnElimi.TabIndex = 9;
            this.btnElimi.Text = "Eliminar";
            this.btnElimi.UseVisualStyleBackColor = true;
            this.btnElimi.Click += new System.EventHandler(this.btnElimi_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(594, 90);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 33);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(594, 42);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 33);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclienteDataGridViewTextBoxColumn,
            this.dUIDataGridViewTextBoxColumn,
            this.nITDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.dirrecionDataGridViewTextBoxColumn,
            this.nRCDataGridViewTextBoxColumn,
            this.idarticuloDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.montopendienteDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.fechalimiteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cuentasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(658, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "idcliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "idcliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclienteDataGridViewTextBoxColumn.Width = 71;
            // 
            // dUIDataGridViewTextBoxColumn
            // 
            this.dUIDataGridViewTextBoxColumn.DataPropertyName = "DUI";
            this.dUIDataGridViewTextBoxColumn.HeaderText = "DUI";
            this.dUIDataGridViewTextBoxColumn.Name = "dUIDataGridViewTextBoxColumn";
            this.dUIDataGridViewTextBoxColumn.ReadOnly = true;
            this.dUIDataGridViewTextBoxColumn.Width = 51;
            // 
            // nITDataGridViewTextBoxColumn
            // 
            this.nITDataGridViewTextBoxColumn.DataPropertyName = "NIT";
            this.nITDataGridViewTextBoxColumn.HeaderText = "NIT";
            this.nITDataGridViewTextBoxColumn.Name = "nITDataGridViewTextBoxColumn";
            this.nITDataGridViewTextBoxColumn.ReadOnly = true;
            this.nITDataGridViewTextBoxColumn.Width = 50;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombresDataGridViewTextBoxColumn.Width = 72;
            // 
            // dirrecionDataGridViewTextBoxColumn
            // 
            this.dirrecionDataGridViewTextBoxColumn.DataPropertyName = "dirrecion";
            this.dirrecionDataGridViewTextBoxColumn.HeaderText = "dirrecion";
            this.dirrecionDataGridViewTextBoxColumn.Name = "dirrecionDataGridViewTextBoxColumn";
            this.dirrecionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dirrecionDataGridViewTextBoxColumn.Width = 72;
            // 
            // nRCDataGridViewTextBoxColumn
            // 
            this.nRCDataGridViewTextBoxColumn.DataPropertyName = "NRC";
            this.nRCDataGridViewTextBoxColumn.HeaderText = "NRC";
            this.nRCDataGridViewTextBoxColumn.Name = "nRCDataGridViewTextBoxColumn";
            this.nRCDataGridViewTextBoxColumn.ReadOnly = true;
            this.nRCDataGridViewTextBoxColumn.Width = 55;
            // 
            // idarticuloDataGridViewTextBoxColumn
            // 
            this.idarticuloDataGridViewTextBoxColumn.DataPropertyName = "idarticulo";
            this.idarticuloDataGridViewTextBoxColumn.HeaderText = "idarticulo";
            this.idarticuloDataGridViewTextBoxColumn.Name = "idarticuloDataGridViewTextBoxColumn";
            this.idarticuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.idarticuloDataGridViewTextBoxColumn.Width = 74;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 86;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 73;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 61;
            // 
            // montopendienteDataGridViewTextBoxColumn
            // 
            this.montopendienteDataGridViewTextBoxColumn.DataPropertyName = "montopendiente";
            this.montopendienteDataGridViewTextBoxColumn.HeaderText = "montopendiente";
            this.montopendienteDataGridViewTextBoxColumn.Name = "montopendienteDataGridViewTextBoxColumn";
            this.montopendienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.montopendienteDataGridViewTextBoxColumn.Width = 108;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 52;
            // 
            // fechalimiteDataGridViewTextBoxColumn
            // 
            this.fechalimiteDataGridViewTextBoxColumn.DataPropertyName = "fechalimite";
            this.fechalimiteDataGridViewTextBoxColumn.HeaderText = "fechalimite";
            this.fechalimiteDataGridViewTextBoxColumn.Name = "fechalimiteDataGridViewTextBoxColumn";
            this.fechalimiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechalimiteDataGridViewTextBoxColumn.Width = 82;
            // 
            // cuentasBindingSource
            // 
            this.cuentasBindingSource.DataMember = "cuentas";
            this.cuentasBindingSource.DataSource = this.cuentasporcobrarDataSet;
            // 
            // cuentasporcobrarDataSet
            // 
            this.cuentasporcobrarDataSet.DataSetName = "cuentasporcobrarDataSet";
            this.cuentasporcobrarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cuentasTableAdapter
            // 
            this.cuentasTableAdapter.ClearBeforeFill = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(125, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "$";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(125, 162);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "$";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(125, 199);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(745, 512);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnElimi);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cuentas Por Cobrar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasporcobrarDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtIdA;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.TextBox txtCn;
        private System.Windows.Forms.TextBox txtPrec;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNrc;
        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtIdc;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnElimi;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private cuentasporcobrarDataSet cuentasporcobrarDataSet;
        private System.Windows.Forms.BindingSource cuentasBindingSource;
        private cuentasporcobrarDataSetTableAdapters.cuentasTableAdapter cuentasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirrecionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idarticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montopendienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechalimiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}

