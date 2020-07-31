namespace Presentacion
{
    partial class FrmProgramaLibrosElectronicos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.testlabel = new System.Windows.Forms.Label();
            this.btnGuardarVentas = new System.Windows.Forms.Button();
            this.btnGuardarCompras = new System.Windows.Forms.Button();
            this.tabRegistros = new System.Windows.Forms.TabControl();
            this.tabCompras = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvRegistroCompras = new System.Windows.Forms.DataGridView();
            this.tblRegistroComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCompras = new Presentacion.DSCompras();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEliminarCompras = new System.Windows.Forms.Button();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvRegistroVentas = new System.Windows.Forms.DataGridView();
            this.ventasMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasNumeroRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasFechapago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCdpTipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ventasCdpSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCdpNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasProveedorTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasProveedorNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasProveedorRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasValorExportacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasBaseImponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasImporteTotalExonerada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasImporteTotalInafecta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasIgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasImporteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasTipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasIgvRetencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCuentaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoCuentaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasReferenciaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasReferenciaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasReferenciaSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasReferenciaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasConstanciaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasConstanciaFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasDetraccionSoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblRegistroComprasTableAdapter = new Presentacion.DSComprasTableAdapters.tblRegistroComprasTableAdapter();
            this.comprasID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasNumeroRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCdpTipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comprasCdpSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCdpNumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasProveedorTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasProveedorNumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasProveedorTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasProveedorRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasBaseImponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasIgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasNoGravada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasImporteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasTipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConversionDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasPercepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasDescripcionDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCuentaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConstanciaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConstanciaFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConstanciaMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConstanciaReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancarizacionFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancarizacionBco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancarizacionOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabRegistros.SuspendLayout();
            this.tabCompras.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistroComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCompras)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabVentas.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtBuscarProveedor);
            this.panel1.Controls.Add(this.btnBuscarProveedor);
            this.panel1.Controls.Add(this.testlabel);
            this.panel1.Controls.Add(this.btnGuardarVentas);
            this.panel1.Controls.Add(this.btnGuardarCompras);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 87);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 87);
            this.panel2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // txtBuscarProveedor
            // 
            this.txtBuscarProveedor.Location = new System.Drawing.Point(140, 39);
            this.txtBuscarProveedor.Name = "txtBuscarProveedor";
            this.txtBuscarProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarProveedor.TabIndex = 4;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Location = new System.Drawing.Point(59, 36);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProveedor.TabIndex = 3;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            // 
            // testlabel
            // 
            this.testlabel.AutoSize = true;
            this.testlabel.Location = new System.Drawing.Point(255, 42);
            this.testlabel.Name = "testlabel";
            this.testlabel.Size = new System.Drawing.Size(35, 13);
            this.testlabel.TabIndex = 2;
            this.testlabel.Text = "label1";
            // 
            // btnGuardarVentas
            // 
            this.btnGuardarVentas.Location = new System.Drawing.Point(857, 25);
            this.btnGuardarVentas.Name = "btnGuardarVentas";
            this.btnGuardarVentas.Size = new System.Drawing.Size(119, 23);
            this.btnGuardarVentas.TabIndex = 1;
            this.btnGuardarVentas.Text = "Guardar Ventas";
            this.btnGuardarVentas.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCompras
            // 
            this.btnGuardarCompras.Location = new System.Drawing.Point(721, 25);
            this.btnGuardarCompras.Name = "btnGuardarCompras";
            this.btnGuardarCompras.Size = new System.Drawing.Size(109, 23);
            this.btnGuardarCompras.TabIndex = 0;
            this.btnGuardarCompras.Text = "Guardar Compras";
            this.btnGuardarCompras.UseVisualStyleBackColor = true;
            // 
            // tabRegistros
            // 
            this.tabRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabRegistros.Controls.Add(this.tabCompras);
            this.tabRegistros.Controls.Add(this.tabVentas);
            this.tabRegistros.Location = new System.Drawing.Point(12, 105);
            this.tabRegistros.Name = "tabRegistros";
            this.tabRegistros.SelectedIndex = 0;
            this.tabRegistros.Size = new System.Drawing.Size(1096, 562);
            this.tabRegistros.TabIndex = 3;
            // 
            // tabCompras
            // 
            this.tabCompras.Controls.Add(this.panel4);
            this.tabCompras.Controls.Add(this.panel3);
            this.tabCompras.Location = new System.Drawing.Point(4, 22);
            this.tabCompras.Name = "tabCompras";
            this.tabCompras.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompras.Size = new System.Drawing.Size(1088, 536);
            this.tabCompras.TabIndex = 0;
            this.tabCompras.Text = "Compras";
            this.tabCompras.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dgvRegistroCompras);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1076, 464);
            this.panel4.TabIndex = 4;
            // 
            // dgvRegistroCompras
            // 
            this.dgvRegistroCompras.AutoGenerateColumns = false;
            this.dgvRegistroCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comprasID,
            this.comprasMes,
            this.comprasNumeroRegistro,
            this.comprasFechaEmision,
            this.comprasFechaPago,
            this.comprasCdpTipo,
            this.comprasCdpSerie,
            this.comprasCdpNumeroDocumento,
            this.comprasProveedorTipo,
            this.comprasProveedorNumeroDocumento,
            this.comprasProveedorTipoDocumento,
            this.comprasProveedorRazonSocial,
            this.comprasCuenta,
            this.comprasDescripcion,
            this.comprasBaseImponible,
            this.comprasIgv,
            this.comprasNoGravada,
            this.comprasDescuento,
            this.comprasImporteTotal,
            this.comprasDolares,
            this.comprasTipoCambio,
            this.comprasConversionDolares,
            this.comprasPercepcion,
            this.comprasDestino,
            this.comprasDescripcionDestino,
            this.comprasCuentaDestino,
            this.comprasPago,
            this.comprasCodigo,
            this.comprasConstanciaNumero,
            this.comprasConstanciaFechaPago,
            this.comprasConstanciaMonto,
            this.comprasConstanciaReferencia,
            this.BancarizacionFecha,
            this.BancarizacionBco,
            this.BancarizacionOperacion});
            this.dgvRegistroCompras.DataSource = this.tblRegistroComprasBindingSource;
            this.dgvRegistroCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistroCompras.Location = new System.Drawing.Point(0, 0);
            this.dgvRegistroCompras.Name = "dgvRegistroCompras";
            this.dgvRegistroCompras.Size = new System.Drawing.Size(1076, 464);
            this.dgvRegistroCompras.TabIndex = 0;
            this.dgvRegistroCompras.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroCompras_CellEndEdit);
            this.dgvRegistroCompras.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellValueChanged);
            this.dgvRegistroCompras.TabIndexChanged += new System.EventHandler(this.tabIndexChangedEvent);
            this.dgvRegistroCompras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRegistroCompras_KeyDown);
            // 
            // tblRegistroComprasBindingSource
            // 
            this.tblRegistroComprasBindingSource.DataMember = "tblRegistroCompras";
            this.tblRegistroComprasBindingSource.DataSource = this.dSCompras;
            // 
            // dSCompras
            // 
            this.dSCompras.DataSetName = "DSCompras";
            this.dSCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.btnEliminarCompras);
            this.panel3.Location = new System.Drawing.Point(6, 476);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1076, 54);
            this.panel3.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(15, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Guardar Compras";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminarCompras
            // 
            this.btnEliminarCompras.BackColor = System.Drawing.Color.Red;
            this.btnEliminarCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCompras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarCompras.Location = new System.Drawing.Point(142, 17);
            this.btnEliminarCompras.Name = "btnEliminarCompras";
            this.btnEliminarCompras.Size = new System.Drawing.Size(128, 23);
            this.btnEliminarCompras.TabIndex = 0;
            this.btnEliminarCompras.Text = "Eliminar Compras";
            this.btnEliminarCompras.UseVisualStyleBackColor = false;
            this.btnEliminarCompras.Click += new System.EventHandler(this.btnEliminarCompras_Click);
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.panel6);
            this.tabVentas.Controls.Add(this.panel5);
            this.tabVentas.Location = new System.Drawing.Point(4, 22);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentas.Size = new System.Drawing.Size(1088, 536);
            this.tabVentas.TabIndex = 1;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.button2);
            this.panel6.Location = new System.Drawing.Point(6, 476);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1076, 54);
            this.panel6.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Guardar Ventas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnGuardarVentas_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.dgvRegistroVentas);
            this.panel5.Location = new System.Drawing.Point(3, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1079, 456);
            this.panel5.TabIndex = 2;
            // 
            // dgvRegistroVentas
            // 
            this.dgvRegistroVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ventasMes,
            this.ventasNumeroRegistro,
            this.ventasFechaEmision,
            this.ventasFechapago,
            this.ventasCdpTipo,
            this.ventasCdpSerie,
            this.ventasCdpNumero,
            this.ventasProveedorTipo,
            this.ventasProveedorNumero,
            this.ventasProveedorRazonSocial,
            this.ventasCuenta,
            this.ventasDescripcion,
            this.ventasValorExportacion,
            this.ventasBaseImponible,
            this.ventasImporteTotalExonerada,
            this.ventasImporteTotalInafecta,
            this.ventasIgv,
            this.ventasImporteTotal,
            this.ventasTipoCambio,
            this.ventasDolares,
            this.ventasIgvRetencion,
            this.ventasCuentaDestino,
            this.destinoCuentaDescripcion,
            this.ventasPago,
            this.ventasReferenciaFecha,
            this.ventasReferenciaTipo,
            this.ventasReferenciaSerie,
            this.ventasReferenciaNumero,
            this.ventasCodigo,
            this.ventasConstanciaNumero,
            this.ventasConstanciaFechaPago,
            this.ventasDetraccionSoles,
            this.ventasReferencia,
            this.ventasObservacion});
            this.dgvRegistroVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistroVentas.Location = new System.Drawing.Point(0, 0);
            this.dgvRegistroVentas.Name = "dgvRegistroVentas";
            this.dgvRegistroVentas.Size = new System.Drawing.Size(1079, 456);
            this.dgvRegistroVentas.TabIndex = 1;
            this.dgvRegistroVentas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroVentas_CellEndEdit);
            // 
            // ventasMes
            // 
            this.ventasMes.HeaderText = "Mes";
            this.ventasMes.Name = "ventasMes";
            // 
            // ventasNumeroRegistro
            // 
            this.ventasNumeroRegistro.HeaderText = "N° Registro";
            this.ventasNumeroRegistro.Name = "ventasNumeroRegistro";
            // 
            // ventasFechaEmision
            // 
            this.ventasFechaEmision.HeaderText = "Fecha de Emisión";
            this.ventasFechaEmision.Name = "ventasFechaEmision";
            // 
            // ventasFechapago
            // 
            this.ventasFechapago.HeaderText = "Fecha de Pago";
            this.ventasFechapago.Name = "ventasFechapago";
            // 
            // ventasCdpTipo
            // 
            this.ventasCdpTipo.HeaderText = "Comprobante Tipo";
            this.ventasCdpTipo.Name = "ventasCdpTipo";
            this.ventasCdpTipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ventasCdpTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ventasCdpSerie
            // 
            this.ventasCdpSerie.HeaderText = "Comprobante Serie";
            this.ventasCdpSerie.Name = "ventasCdpSerie";
            // 
            // ventasCdpNumero
            // 
            this.ventasCdpNumero.HeaderText = "Comprobante Número Documento";
            this.ventasCdpNumero.Name = "ventasCdpNumero";
            // 
            // ventasProveedorTipo
            // 
            this.ventasProveedorTipo.HeaderText = "Proveedor Tipo";
            this.ventasProveedorTipo.Name = "ventasProveedorTipo";
            // 
            // ventasProveedorNumero
            // 
            this.ventasProveedorNumero.HeaderText = "Proveedor Numero Documento";
            this.ventasProveedorNumero.Name = "ventasProveedorNumero";
            // 
            // ventasProveedorRazonSocial
            // 
            this.ventasProveedorRazonSocial.HeaderText = "Proveedor Razón Social";
            this.ventasProveedorRazonSocial.Name = "ventasProveedorRazonSocial";
            // 
            // ventasCuenta
            // 
            this.ventasCuenta.HeaderText = "Cuenta";
            this.ventasCuenta.Name = "ventasCuenta";
            // 
            // ventasDescripcion
            // 
            this.ventasDescripcion.HeaderText = "Descripción";
            this.ventasDescripcion.Name = "ventasDescripcion";
            // 
            // ventasValorExportacion
            // 
            this.ventasValorExportacion.HeaderText = "Valor de Exportación";
            this.ventasValorExportacion.Name = "ventasValorExportacion";
            // 
            // ventasBaseImponible
            // 
            this.ventasBaseImponible.HeaderText = "Base Imponible";
            this.ventasBaseImponible.Name = "ventasBaseImponible";
            // 
            // ventasImporteTotalExonerada
            // 
            this.ventasImporteTotalExonerada.HeaderText = "Importe Total Exonerada";
            this.ventasImporteTotalExonerada.Name = "ventasImporteTotalExonerada";
            // 
            // ventasImporteTotalInafecta
            // 
            this.ventasImporteTotalInafecta.HeaderText = "Importe Total Inafecta";
            this.ventasImporteTotalInafecta.Name = "ventasImporteTotalInafecta";
            // 
            // ventasIgv
            // 
            this.ventasIgv.HeaderText = "IGV";
            this.ventasIgv.Name = "ventasIgv";
            // 
            // ventasImporteTotal
            // 
            this.ventasImporteTotal.HeaderText = "Importe Total";
            this.ventasImporteTotal.Name = "ventasImporteTotal";
            // 
            // ventasTipoCambio
            // 
            this.ventasTipoCambio.HeaderText = "Tipo de Cambio";
            this.ventasTipoCambio.Name = "ventasTipoCambio";
            // 
            // ventasDolares
            // 
            this.ventasDolares.HeaderText = "Dólares";
            this.ventasDolares.Name = "ventasDolares";
            // 
            // ventasIgvRetencion
            // 
            this.ventasIgvRetencion.HeaderText = "IGV Retención";
            this.ventasIgvRetencion.Name = "ventasIgvRetencion";
            // 
            // ventasCuentaDestino
            // 
            this.ventasCuentaDestino.HeaderText = "Cuenta Destino";
            this.ventasCuentaDestino.Name = "ventasCuentaDestino";
            // 
            // destinoCuentaDescripcion
            // 
            this.destinoCuentaDescripcion.HeaderText = "Cuenta Destino Descripción";
            this.destinoCuentaDescripcion.Name = "destinoCuentaDescripcion";
            // 
            // ventasPago
            // 
            this.ventasPago.HeaderText = "Pago";
            this.ventasPago.Name = "ventasPago";
            // 
            // ventasReferenciaFecha
            // 
            this.ventasReferenciaFecha.HeaderText = "Referencia Fecha";
            this.ventasReferenciaFecha.Name = "ventasReferenciaFecha";
            // 
            // ventasReferenciaTipo
            // 
            this.ventasReferenciaTipo.HeaderText = "Referencia Tipo";
            this.ventasReferenciaTipo.Name = "ventasReferenciaTipo";
            // 
            // ventasReferenciaSerie
            // 
            this.ventasReferenciaSerie.HeaderText = "Referencia Serie";
            this.ventasReferenciaSerie.Name = "ventasReferenciaSerie";
            // 
            // ventasReferenciaNumero
            // 
            this.ventasReferenciaNumero.HeaderText = "Referencia Número";
            this.ventasReferenciaNumero.Name = "ventasReferenciaNumero";
            // 
            // ventasCodigo
            // 
            this.ventasCodigo.HeaderText = "Código";
            this.ventasCodigo.Name = "ventasCodigo";
            // 
            // ventasConstanciaNumero
            // 
            this.ventasConstanciaNumero.HeaderText = "Constancia Número";
            this.ventasConstanciaNumero.Name = "ventasConstanciaNumero";
            // 
            // ventasConstanciaFechaPago
            // 
            this.ventasConstanciaFechaPago.HeaderText = "Constancia Fecha Pago";
            this.ventasConstanciaFechaPago.Name = "ventasConstanciaFechaPago";
            // 
            // ventasDetraccionSoles
            // 
            this.ventasDetraccionSoles.HeaderText = "Detracción en Soles";
            this.ventasDetraccionSoles.Name = "ventasDetraccionSoles";
            // 
            // ventasReferencia
            // 
            this.ventasReferencia.HeaderText = "Referencia";
            this.ventasReferencia.Name = "ventasReferencia";
            // 
            // ventasObservacion
            // 
            this.ventasObservacion.HeaderText = "Observación";
            this.ventasObservacion.Name = "ventasObservacion";
            // 
            // tblRegistroComprasTableAdapter
            // 
            this.tblRegistroComprasTableAdapter.ClearBeforeFill = true;
            // 
            // comprasID
            // 
            this.comprasID.DataPropertyName = "idLibroCompras";
            this.comprasID.HeaderText = "#";
            this.comprasID.Name = "comprasID";
            this.comprasID.ReadOnly = true;
            this.comprasID.Width = 40;
            // 
            // comprasMes
            // 
            this.comprasMes.DataPropertyName = "Mes";
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.Aqua;
            this.comprasMes.DefaultCellStyle = dataGridViewCellStyle46;
            this.comprasMes.HeaderText = "Mes";
            this.comprasMes.Name = "comprasMes";
            this.comprasMes.Width = 40;
            // 
            // comprasNumeroRegistro
            // 
            this.comprasNumeroRegistro.DataPropertyName = "NReg";
            this.comprasNumeroRegistro.HeaderText = "N° Registro";
            this.comprasNumeroRegistro.Name = "comprasNumeroRegistro";
            // 
            // comprasFechaEmision
            // 
            this.comprasFechaEmision.DataPropertyName = "FechaEmision";
            this.comprasFechaEmision.HeaderText = "Fecha de Emisión";
            this.comprasFechaEmision.Name = "comprasFechaEmision";
            this.comprasFechaEmision.Width = 80;
            // 
            // comprasFechaPago
            // 
            this.comprasFechaPago.DataPropertyName = "FechaPago";
            this.comprasFechaPago.HeaderText = "Fecha de Pago";
            this.comprasFechaPago.Name = "comprasFechaPago";
            this.comprasFechaPago.Width = 80;
            // 
            // comprasCdpTipo
            // 
            this.comprasCdpTipo.DataPropertyName = "CTipo";
            this.comprasCdpTipo.HeaderText = "Comprobante Tipo";
            this.comprasCdpTipo.Name = "comprasCdpTipo";
            this.comprasCdpTipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.comprasCdpTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.comprasCdpTipo.Width = 120;
            // 
            // comprasCdpSerie
            // 
            this.comprasCdpSerie.DataPropertyName = "CSerie";
            this.comprasCdpSerie.HeaderText = "Comprobante Serie";
            this.comprasCdpSerie.Name = "comprasCdpSerie";
            // 
            // comprasCdpNumeroDocumento
            // 
            this.comprasCdpNumeroDocumento.DataPropertyName = "CNDocumento";
            this.comprasCdpNumeroDocumento.HeaderText = "Comprobante Número Documento";
            this.comprasCdpNumeroDocumento.Name = "comprasCdpNumeroDocumento";
            // 
            // comprasProveedorTipo
            // 
            this.comprasProveedorTipo.DataPropertyName = "PTipo";
            this.comprasProveedorTipo.HeaderText = "Proveedor Tipo";
            this.comprasProveedorTipo.Name = "comprasProveedorTipo";
            // 
            // comprasProveedorNumeroDocumento
            // 
            this.comprasProveedorNumeroDocumento.DataPropertyName = "PNumero";
            this.comprasProveedorNumeroDocumento.HeaderText = "Proveedor Numero Documento";
            this.comprasProveedorNumeroDocumento.Name = "comprasProveedorNumeroDocumento";
            // 
            // comprasProveedorTipoDocumento
            // 
            this.comprasProveedorTipoDocumento.DataPropertyName = "PDocumento";
            this.comprasProveedorTipoDocumento.HeaderText = "Proveedor Tipo Documento";
            this.comprasProveedorTipoDocumento.Name = "comprasProveedorTipoDocumento";
            // 
            // comprasProveedorRazonSocial
            // 
            this.comprasProveedorRazonSocial.DataPropertyName = "PNombreRazonSocial";
            this.comprasProveedorRazonSocial.HeaderText = "Proveedor Razón Social";
            this.comprasProveedorRazonSocial.Name = "comprasProveedorRazonSocial";
            this.comprasProveedorRazonSocial.Width = 200;
            // 
            // comprasCuenta
            // 
            this.comprasCuenta.DataPropertyName = "Cuenta";
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.Aqua;
            this.comprasCuenta.DefaultCellStyle = dataGridViewCellStyle47;
            this.comprasCuenta.HeaderText = "Cuenta";
            this.comprasCuenta.Name = "comprasCuenta";
            // 
            // comprasDescripcion
            // 
            this.comprasDescripcion.DataPropertyName = "Descripcion";
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.Aqua;
            this.comprasDescripcion.DefaultCellStyle = dataGridViewCellStyle48;
            this.comprasDescripcion.HeaderText = "Descripción";
            this.comprasDescripcion.Name = "comprasDescripcion";
            // 
            // comprasBaseImponible
            // 
            this.comprasBaseImponible.DataPropertyName = "BaseImponible";
            this.comprasBaseImponible.HeaderText = "Base Imponible";
            this.comprasBaseImponible.Name = "comprasBaseImponible";
            // 
            // comprasIgv
            // 
            this.comprasIgv.DataPropertyName = "IGV";
            this.comprasIgv.HeaderText = "IGV";
            this.comprasIgv.Name = "comprasIgv";
            // 
            // comprasNoGravada
            // 
            this.comprasNoGravada.DataPropertyName = "NoGravada";
            this.comprasNoGravada.HeaderText = "No Gravada";
            this.comprasNoGravada.Name = "comprasNoGravada";
            // 
            // comprasDescuento
            // 
            this.comprasDescuento.DataPropertyName = "Descuentos";
            this.comprasDescuento.HeaderText = "Descuento";
            this.comprasDescuento.Name = "comprasDescuento";
            // 
            // comprasImporteTotal
            // 
            this.comprasImporteTotal.DataPropertyName = "ImporteTotal";
            this.comprasImporteTotal.HeaderText = "Importe Total";
            this.comprasImporteTotal.Name = "comprasImporteTotal";
            // 
            // comprasDolares
            // 
            this.comprasDolares.DataPropertyName = "Dolares";
            this.comprasDolares.HeaderText = "Dolares";
            this.comprasDolares.Name = "comprasDolares";
            // 
            // comprasTipoCambio
            // 
            this.comprasTipoCambio.DataPropertyName = "TipoCambio";
            this.comprasTipoCambio.HeaderText = "Tipo de Cambio";
            this.comprasTipoCambio.Name = "comprasTipoCambio";
            // 
            // comprasConversionDolares
            // 
            this.comprasConversionDolares.DataPropertyName = "ConversionDolar";
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.Cyan;
            this.comprasConversionDolares.DefaultCellStyle = dataGridViewCellStyle49;
            this.comprasConversionDolares.HeaderText = "Conversión Dólares (S/.)";
            this.comprasConversionDolares.Name = "comprasConversionDolares";
            this.comprasConversionDolares.ReadOnly = true;
            // 
            // comprasPercepcion
            // 
            this.comprasPercepcion.DataPropertyName = "Percepcion";
            this.comprasPercepcion.HeaderText = "Percepción";
            this.comprasPercepcion.Name = "comprasPercepcion";
            // 
            // comprasDestino
            // 
            this.comprasDestino.DataPropertyName = "Destino";
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.Aqua;
            this.comprasDestino.DefaultCellStyle = dataGridViewCellStyle50;
            this.comprasDestino.HeaderText = "Destino";
            this.comprasDestino.Name = "comprasDestino";
            // 
            // comprasDescripcionDestino
            // 
            this.comprasDescripcionDestino.DataPropertyName = "DescripcionDestino";
            dataGridViewCellStyle51.BackColor = System.Drawing.Color.Aqua;
            this.comprasDescripcionDestino.DefaultCellStyle = dataGridViewCellStyle51;
            this.comprasDescripcionDestino.HeaderText = "Descripción Destino";
            this.comprasDescripcionDestino.Name = "comprasDescripcionDestino";
            // 
            // comprasCuentaDestino
            // 
            this.comprasCuentaDestino.DataPropertyName = "CuentaDestino";
            dataGridViewCellStyle52.BackColor = System.Drawing.Color.Aqua;
            this.comprasCuentaDestino.DefaultCellStyle = dataGridViewCellStyle52;
            this.comprasCuentaDestino.HeaderText = "Cuenta Destino";
            this.comprasCuentaDestino.Name = "comprasCuentaDestino";
            // 
            // comprasPago
            // 
            this.comprasPago.DataPropertyName = "Pgo";
            dataGridViewCellStyle53.BackColor = System.Drawing.Color.Aqua;
            this.comprasPago.DefaultCellStyle = dataGridViewCellStyle53;
            this.comprasPago.HeaderText = "Pago";
            this.comprasPago.Name = "comprasPago";
            // 
            // comprasCodigo
            // 
            this.comprasCodigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle54.BackColor = System.Drawing.Color.Aqua;
            this.comprasCodigo.DefaultCellStyle = dataGridViewCellStyle54;
            this.comprasCodigo.HeaderText = "Código";
            this.comprasCodigo.Name = "comprasCodigo";
            // 
            // comprasConstanciaNumero
            // 
            this.comprasConstanciaNumero.DataPropertyName = "ConstanciaNumero";
            this.comprasConstanciaNumero.HeaderText = "Constancia Número";
            this.comprasConstanciaNumero.Name = "comprasConstanciaNumero";
            // 
            // comprasConstanciaFechaPago
            // 
            this.comprasConstanciaFechaPago.DataPropertyName = "ConstanciaFechaPago";
            this.comprasConstanciaFechaPago.HeaderText = "Constancia de Fecha de Pago";
            this.comprasConstanciaFechaPago.Name = "comprasConstanciaFechaPago";
            this.comprasConstanciaFechaPago.Width = 80;
            // 
            // comprasConstanciaMonto
            // 
            this.comprasConstanciaMonto.DataPropertyName = "ConstanciaMonto";
            this.comprasConstanciaMonto.HeaderText = "Constancia Monto";
            this.comprasConstanciaMonto.Name = "comprasConstanciaMonto";
            // 
            // comprasConstanciaReferencia
            // 
            this.comprasConstanciaReferencia.DataPropertyName = "ConstanciaReferencia";
            this.comprasConstanciaReferencia.HeaderText = "Constancia Referencia";
            this.comprasConstanciaReferencia.Name = "comprasConstanciaReferencia";
            // 
            // BancarizacionFecha
            // 
            this.BancarizacionFecha.DataPropertyName = "BancarizacionFecha";
            this.BancarizacionFecha.HeaderText = "Bancarizacion Fecha";
            this.BancarizacionFecha.Name = "BancarizacionFecha";
            this.BancarizacionFecha.Width = 80;
            // 
            // BancarizacionBco
            // 
            this.BancarizacionBco.DataPropertyName = "BancarizacionBco";
            this.BancarizacionBco.HeaderText = "Bancarizacion Bco";
            this.BancarizacionBco.Name = "BancarizacionBco";
            // 
            // BancarizacionOperacion
            // 
            this.BancarizacionOperacion.DataPropertyName = "BancarizacionOperacion";
            this.BancarizacionOperacion.HeaderText = "Bancarizacion Operacion";
            this.BancarizacionOperacion.Name = "BancarizacionOperacion";
            // 
            // FrmProgramaLibrosElectronicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 679);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabRegistros);
            this.Name = "FrmProgramaLibrosElectronicos";
            this.Text = "FrmProgramaLibrosElectronicos";
            this.Load += new System.EventHandler(this.FrmProgramaLibrosElectronicos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabRegistros.ResumeLayout(false);
            this.tabCompras.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistroComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCompras)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabVentas.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarProveedor;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.Label testlabel;
        private System.Windows.Forms.Button btnGuardarVentas;
        private System.Windows.Forms.Button btnGuardarCompras;
        private System.Windows.Forms.TabControl tabRegistros;
        private System.Windows.Forms.TabPage tabCompras;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvRegistroCompras;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEliminarCompras;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvRegistroVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasNumeroRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasFechapago;
        private System.Windows.Forms.DataGridViewComboBoxColumn ventasCdpTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCdpSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCdpNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasProveedorTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasProveedorNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasProveedorRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasValorExportacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasBaseImponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasImporteTotalExonerada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasImporteTotalInafecta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasIgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasImporteTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasTipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasIgvRetencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCuentaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoCuentaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasReferenciaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasReferenciaTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasReferenciaSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasReferenciaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasConstanciaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasConstanciaFechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasDetraccionSoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasObservacion;
        private DSCompras dSCompras;
        private System.Windows.Forms.BindingSource tblRegistroComprasBindingSource;
        private DSComprasTableAdapters.tblRegistroComprasTableAdapter tblRegistroComprasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasID;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasNumeroRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasFechaPago;
        private System.Windows.Forms.DataGridViewComboBoxColumn comprasCdpTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCdpSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCdpNumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasProveedorTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasProveedorNumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasProveedorTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasProveedorRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasBaseImponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasIgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasNoGravada;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasImporteTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasTipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConversionDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasPercepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasDescripcionDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCuentaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConstanciaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConstanciaFechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConstanciaMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConstanciaReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancarizacionFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancarizacionBco;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancarizacionOperacion;
    }
}