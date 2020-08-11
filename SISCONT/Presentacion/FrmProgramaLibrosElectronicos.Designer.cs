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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRutaTXT = new System.Windows.Forms.TextBox();
            this.btnGenerarTXT = new System.Windows.Forms.Button();
            this.btnCargarCarpeta = new System.Windows.Forms.Button();
            this.txtNombreMes = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreRuc = new System.Windows.Forms.TextBox();
            this.txtNombreAnio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabRegistros = new System.Windows.Forms.TabControl();
            this.tabCompras = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvRegistroCompras = new ADGV.AdvancedDataGridView();
            this.BSComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCompras = new Presentacion.DSCompras();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGuardarCompras = new System.Windows.Forms.Button();
            this.btnEliminarCompras = new System.Windows.Forms.Button();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnEliminarVentas = new System.Windows.Forms.Button();
            this.btnGuardarVentas = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvRegistroVentas = new ADGV.AdvancedDataGridView();
            this.BSVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSVentas = new Presentacion.DSVentas();
            this.TAComprasTableAdapter = new Presentacion.DSComprasTableAdapters.tblRegistroComprasTableAdapter();
            this.TAVentasTableAdapter = new Presentacion.DSVentasTableAdapters.tblRegistroVentasTableAdapter();
            this.ventasID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasNumeroRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ventasCuentaDestinoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.idLibroVentasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPagoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSerieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNDocumentoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTipoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNumeroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNombreRazonSocialDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorExportacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseImponibleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeTotalExoneradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeTotalInafectaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGVDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeTotalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolaresDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igvRetencionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaDestinoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaFechaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaTipoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaSerieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaNumeroDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constanciaNumeroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constanciaFechaPagoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detraccionSolesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaModificacionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaDestinoDescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasNumeroRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCdpTipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comprasCdpSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCdpNumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasProveedorTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasProveedorNumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.comprasCuentaDestino = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comprasCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConstanciaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConstanciaFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConstanciaMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConstanciaReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancarizacionFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancarizacionBco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancarizacionOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasReferenciaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasReferenciaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasReferenciaSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasReferenciaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSerieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNombreRazonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseImponibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noGravadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolaresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conversionDolarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCambioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percepcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDestinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaDestinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pgoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constanciaNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constanciaFechaPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constanciaMontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constanciaReferenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bancarizacionFechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bancarizacionBcoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bancarizacionOperacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaFechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaSerieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaModificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabRegistros.SuspendLayout();
            this.tabCompras.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCompras)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabVentas.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtNombreMes);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombreRuc);
            this.panel1.Controls.Add(this.txtNombreAnio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 55);
            this.panel1.TabIndex = 4;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Aqua;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(10, 6);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(86, 34);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txtRutaTXT);
            this.panel2.Controls.Add(this.btnGenerarTXT);
            this.panel2.Controls.Add(this.btnCargarCarpeta);
            this.panel2.Location = new System.Drawing.Point(874, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 52);
            this.panel2.TabIndex = 5;
            // 
            // txtRutaTXT
            // 
            this.txtRutaTXT.Location = new System.Drawing.Point(21, 18);
            this.txtRutaTXT.Name = "txtRutaTXT";
            this.txtRutaTXT.ReadOnly = true;
            this.txtRutaTXT.Size = new System.Drawing.Size(150, 20);
            this.txtRutaTXT.TabIndex = 5;
            this.txtRutaTXT.Text = "C:\\Users\\Public\\Documents\\";
            // 
            // btnGenerarTXT
            // 
            this.btnGenerarTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGenerarTXT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGenerarTXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarTXT.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenerarTXT.Location = new System.Drawing.Point(284, 17);
            this.btnGenerarTXT.Name = "btnGenerarTXT";
            this.btnGenerarTXT.Size = new System.Drawing.Size(92, 22);
            this.btnGenerarTXT.TabIndex = 1;
            this.btnGenerarTXT.Text = "Generar TXT";
            this.btnGenerarTXT.UseVisualStyleBackColor = false;
            this.btnGenerarTXT.Click += new System.EventHandler(this.btnGenerarTXT_Click);
            // 
            // btnCargarCarpeta
            // 
            this.btnCargarCarpeta.BackColor = System.Drawing.Color.Aqua;
            this.btnCargarCarpeta.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCargarCarpeta.FlatAppearance.BorderSize = 0;
            this.btnCargarCarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarCarpeta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCargarCarpeta.Location = new System.Drawing.Point(170, 17);
            this.btnCargarCarpeta.Name = "btnCargarCarpeta";
            this.btnCargarCarpeta.Size = new System.Drawing.Size(34, 22);
            this.btnCargarCarpeta.TabIndex = 6;
            this.btnCargarCarpeta.Text = "***";
            this.btnCargarCarpeta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCargarCarpeta.UseVisualStyleBackColor = false;
            this.btnCargarCarpeta.Click += new System.EventHandler(this.btnCargarCarpeta_Click);
            // 
            // txtNombreMes
            // 
            this.txtNombreMes.Location = new System.Drawing.Point(326, 19);
            this.txtNombreMes.Name = "txtNombreMes";
            this.txtNombreMes.Size = new System.Drawing.Size(68, 20);
            this.txtNombreMes.TabIndex = 11;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(400, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 22);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Año";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombreRuc
            // 
            this.txtNombreRuc.Location = new System.Drawing.Point(146, 19);
            this.txtNombreRuc.Name = "txtNombreRuc";
            this.txtNombreRuc.Size = new System.Drawing.Size(100, 20);
            this.txtNombreRuc.TabIndex = 7;
            // 
            // txtNombreAnio
            // 
            this.txtNombreAnio.Location = new System.Drawing.Point(252, 19);
            this.txtNombreAnio.Name = "txtNombreAnio";
            this.txtNombreAnio.Size = new System.Drawing.Size(68, 20);
            this.txtNombreAnio.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "RUC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabRegistros
            // 
            this.tabRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabRegistros.Controls.Add(this.tabCompras);
            this.tabRegistros.Controls.Add(this.tabVentas);
            this.tabRegistros.Location = new System.Drawing.Point(12, 65);
            this.tabRegistros.Name = "tabRegistros";
            this.tabRegistros.SelectedIndex = 0;
            this.tabRegistros.Size = new System.Drawing.Size(1264, 610);
            this.tabRegistros.TabIndex = 3;
            // 
            // tabCompras
            // 
            this.tabCompras.Controls.Add(this.panel4);
            this.tabCompras.Controls.Add(this.panel3);
            this.tabCompras.Location = new System.Drawing.Point(4, 22);
            this.tabCompras.Name = "tabCompras";
            this.tabCompras.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompras.Size = new System.Drawing.Size(1256, 584);
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
            this.panel4.Size = new System.Drawing.Size(1244, 526);
            this.panel4.TabIndex = 4;
            // 
            // dgvRegistroCompras
            // 
            this.dgvRegistroCompras.AllowUserToDeleteRows = false;
            this.dgvRegistroCompras.AutoGenerateColumns = false;
            this.dgvRegistroCompras.AutoGenerateContextFilters = true;
            this.dgvRegistroCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comprasID,
            this.comprasNumeroRegistro,
            this.comprasFechaEmision,
            this.comprasFechaPago,
            this.comprasCdpTipo,
            this.comprasCdpSerie,
            this.comprasCdpNumeroDocumento,
            this.comprasProveedorTipo,
            this.comprasProveedorNumeroDocumento,
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
            this.comprasCodigo,
            this.comprasConstanciaNumero,
            this.comprasConstanciaFechaPago,
            this.comprasConstanciaMonto,
            this.comprasConstanciaReferencia,
            this.BancarizacionFecha,
            this.BancarizacionBco,
            this.BancarizacionOperacion,
            this.comprasReferenciaFecha,
            this.comprasReferenciaTipo,
            this.comprasReferenciaSerie,
            this.comprasReferenciaNumero,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.fechaPagoDataGridViewTextBoxColumn,
            this.cTipoDataGridViewTextBoxColumn,
            this.cSerieDataGridViewTextBoxColumn,
            this.cNDocumentoDataGridViewTextBoxColumn,
            this.pTipoDataGridViewTextBoxColumn,
            this.pNumeroDataGridViewTextBoxColumn,
            this.pDocumentoDataGridViewTextBoxColumn,
            this.pNombreRazonSocialDataGridViewTextBoxColumn,
            this.cuentaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.baseImponibleDataGridViewTextBoxColumn,
            this.iGVDataGridViewTextBoxColumn,
            this.noGravadaDataGridViewTextBoxColumn,
            this.descuentosDataGridViewTextBoxColumn,
            this.importeTotalDataGridViewTextBoxColumn,
            this.dolaresDataGridViewTextBoxColumn,
            this.conversionDolarDataGridViewTextBoxColumn,
            this.tipoCambioDataGridViewTextBoxColumn,
            this.percepcionDataGridViewTextBoxColumn,
            this.destinoDataGridViewTextBoxColumn,
            this.descripcionDestinoDataGridViewTextBoxColumn,
            this.cuentaDestinoDataGridViewTextBoxColumn,
            this.pgoDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.constanciaNumeroDataGridViewTextBoxColumn,
            this.constanciaFechaPagoDataGridViewTextBoxColumn,
            this.constanciaMontoDataGridViewTextBoxColumn,
            this.constanciaReferenciaDataGridViewTextBoxColumn,
            this.bancarizacionFechaDataGridViewTextBoxColumn,
            this.bancarizacionBcoDataGridViewTextBoxColumn,
            this.bancarizacionOperacionDataGridViewTextBoxColumn,
            this.referenciaFechaDataGridViewTextBoxColumn,
            this.referenciaTipoDataGridViewTextBoxColumn,
            this.referenciaSerieDataGridViewTextBoxColumn,
            this.referenciaNumeroDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.fechaRegistroDataGridViewTextBoxColumn,
            this.fechaModificacionDataGridViewTextBoxColumn});
            this.dgvRegistroCompras.DataSource = this.BSComprasBindingSource;
            this.dgvRegistroCompras.DateWithTime = false;
            this.dgvRegistroCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistroCompras.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvRegistroCompras.Location = new System.Drawing.Point(0, 0);
            this.dgvRegistroCompras.Name = "dgvRegistroCompras";
            this.dgvRegistroCompras.Size = new System.Drawing.Size(1244, 526);
            this.dgvRegistroCompras.TabIndex = 13;
            this.dgvRegistroCompras.TimeFilter = false;
            this.dgvRegistroCompras.SortStringChanged += new System.EventHandler(this.sgvRegistroCompras_SortStringChanged);
            this.dgvRegistroCompras.FilterStringChanged += new System.EventHandler(this.sgvRegistroCompras_FilterStringChanged);
            this.dgvRegistroCompras.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroCompras_CellEndEdit);
            this.dgvRegistroCompras.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvCompras_DefaultValuesNeeded);
            // 
            // BSComprasBindingSource
            // 
            this.BSComprasBindingSource.DataMember = "tblRegistroCompras";
            this.BSComprasBindingSource.DataSource = this.dSCompras;
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
            this.panel3.Controls.Add(this.btnGuardarCompras);
            this.panel3.Controls.Add(this.btnEliminarCompras);
            this.panel3.Location = new System.Drawing.Point(3, 538);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1244, 40);
            this.panel3.TabIndex = 3;
            // 
            // btnGuardarCompras
            // 
            this.btnGuardarCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardarCompras.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnGuardarCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCompras.Location = new System.Drawing.Point(3, 3);
            this.btnGuardarCompras.Name = "btnGuardarCompras";
            this.btnGuardarCompras.Size = new System.Drawing.Size(109, 34);
            this.btnGuardarCompras.TabIndex = 0;
            this.btnGuardarCompras.Text = "Guardar";
            this.btnGuardarCompras.UseVisualStyleBackColor = false;
            this.btnGuardarCompras.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminarCompras
            // 
            this.btnEliminarCompras.BackColor = System.Drawing.Color.Red;
            this.btnEliminarCompras.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnEliminarCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCompras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarCompras.Location = new System.Drawing.Point(139, 3);
            this.btnEliminarCompras.Name = "btnEliminarCompras";
            this.btnEliminarCompras.Size = new System.Drawing.Size(73, 34);
            this.btnEliminarCompras.TabIndex = 0;
            this.btnEliminarCompras.Text = "Eliminar";
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
            this.tabVentas.Size = new System.Drawing.Size(1256, 584);
            this.tabVentas.TabIndex = 1;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.btnEliminarVentas);
            this.panel6.Controls.Add(this.btnGuardarVentas);
            this.panel6.Location = new System.Drawing.Point(3, 537);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1247, 41);
            this.panel6.TabIndex = 4;
            // 
            // btnEliminarVentas
            // 
            this.btnEliminarVentas.BackColor = System.Drawing.Color.Red;
            this.btnEliminarVentas.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnEliminarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarVentas.Location = new System.Drawing.Point(127, 3);
            this.btnEliminarVentas.Name = "btnEliminarVentas";
            this.btnEliminarVentas.Size = new System.Drawing.Size(71, 34);
            this.btnEliminarVentas.TabIndex = 2;
            this.btnEliminarVentas.Text = "Eliminar";
            this.btnEliminarVentas.UseVisualStyleBackColor = false;
            this.btnEliminarVentas.Click += new System.EventHandler(this.btnEliminarVentas_Click);
            // 
            // btnGuardarVentas
            // 
            this.btnGuardarVentas.BackColor = System.Drawing.Color.Lime;
            this.btnGuardarVentas.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnGuardarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarVentas.Location = new System.Drawing.Point(3, 3);
            this.btnGuardarVentas.Name = "btnGuardarVentas";
            this.btnGuardarVentas.Size = new System.Drawing.Size(108, 34);
            this.btnGuardarVentas.TabIndex = 1;
            this.btnGuardarVentas.Text = "Guardar";
            this.btnGuardarVentas.UseVisualStyleBackColor = false;
            this.btnGuardarVentas.Click += new System.EventHandler(this.btnGuardarVentas_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.dgvRegistroVentas);
            this.panel5.Location = new System.Drawing.Point(3, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1247, 528);
            this.panel5.TabIndex = 2;
            // 
            // dgvRegistroVentas
            // 
            this.dgvRegistroVentas.AutoGenerateColumns = false;
            this.dgvRegistroVentas.AutoGenerateContextFilters = true;
            this.dgvRegistroVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ventasID,
            this.ventasNumeroRegistro,
            this.ventasFechaEmision,
            this.ventasFechaPago,
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
            this.ventasCuentaDestinoDescripcion,
            this.ventasReferenciaFecha,
            this.ventasReferenciaTipo,
            this.ventasReferenciaSerie,
            this.ventasReferenciaNumero,
            this.ventasCodigo,
            this.ventasConstanciaNumero,
            this.ventasConstanciaFechaPago,
            this.ventasDetraccionSoles,
            this.ventasReferencia,
            this.ventasObservacion,
            this.idLibroVentasDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.fechaPagoDataGridViewTextBoxColumn1,
            this.cTipoDataGridViewTextBoxColumn1,
            this.cSerieDataGridViewTextBoxColumn1,
            this.cNDocumentoDataGridViewTextBoxColumn1,
            this.pTipoDataGridViewTextBoxColumn1,
            this.pNumeroDataGridViewTextBoxColumn1,
            this.pNombreRazonSocialDataGridViewTextBoxColumn1,
            this.cuentaDataGridViewTextBoxColumn1,
            this.descripcionDataGridViewTextBoxColumn1,
            this.valorExportacionDataGridViewTextBoxColumn,
            this.baseImponibleDataGridViewTextBoxColumn1,
            this.importeTotalExoneradaDataGridViewTextBoxColumn,
            this.importeTotalInafectaDataGridViewTextBoxColumn,
            this.iGVDataGridViewTextBoxColumn1,
            this.importeTotalDataGridViewTextBoxColumn1,
            this.tCDataGridViewTextBoxColumn,
            this.dolaresDataGridViewTextBoxColumn1,
            this.igvRetencionDataGridViewTextBoxColumn,
            this.cuentaDestinoDataGridViewTextBoxColumn1,
            this.pagoDataGridViewTextBoxColumn,
            this.referenciaFechaDataGridViewTextBoxColumn1,
            this.referenciaTipoDataGridViewTextBoxColumn1,
            this.referenciaSerieDataGridViewTextBoxColumn1,
            this.referenciaNumeroDocumentoDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn1,
            this.constanciaNumeroDataGridViewTextBoxColumn1,
            this.constanciaFechaPagoDataGridViewTextBoxColumn1,
            this.detraccionSolesDataGridViewTextBoxColumn,
            this.referenciaDataGridViewTextBoxColumn,
            this.observacionDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn1,
            this.fechaRegistroDataGridViewTextBoxColumn1,
            this.fechaModificacionDataGridViewTextBoxColumn1,
            this.cuentaDestinoDescripcionDataGridViewTextBoxColumn});
            this.dgvRegistroVentas.DataSource = this.BSVentasBindingSource;
            this.dgvRegistroVentas.DateWithTime = false;
            this.dgvRegistroVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistroVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvRegistroVentas.Location = new System.Drawing.Point(0, 0);
            this.dgvRegistroVentas.Name = "dgvRegistroVentas";
            this.dgvRegistroVentas.Size = new System.Drawing.Size(1247, 528);
            this.dgvRegistroVentas.TabIndex = 2;
            this.dgvRegistroVentas.TimeFilter = false;
            this.dgvRegistroVentas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroVentas_CellEndEdit);
            this.dgvRegistroVentas.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvRegistroVentas_DefaultValueNeeded);
            // 
            // BSVentasBindingSource
            // 
            this.BSVentasBindingSource.DataMember = "tblRegistroVentas";
            this.BSVentasBindingSource.DataSource = this.dSVentas;
            // 
            // dSVentas
            // 
            this.dSVentas.DataSetName = "DSVentas";
            this.dSVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TAComprasTableAdapter
            // 
            this.TAComprasTableAdapter.ClearBeforeFill = true;
            // 
            // TAVentasTableAdapter
            // 
            this.TAVentasTableAdapter.ClearBeforeFill = true;
            // 
            // ventasID
            // 
            this.ventasID.DataPropertyName = "idLibroVentas";
            this.ventasID.HeaderText = "#";
            this.ventasID.MinimumWidth = 22;
            this.ventasID.Name = "ventasID";
            this.ventasID.ReadOnly = true;
            this.ventasID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasID.Width = 50;
            // 
            // ventasNumeroRegistro
            // 
            this.ventasNumeroRegistro.DataPropertyName = "NReg";
            this.ventasNumeroRegistro.HeaderText = "N° Reg";
            this.ventasNumeroRegistro.MinimumWidth = 22;
            this.ventasNumeroRegistro.Name = "ventasNumeroRegistro";
            this.ventasNumeroRegistro.ReadOnly = true;
            this.ventasNumeroRegistro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasNumeroRegistro.Visible = false;
            this.ventasNumeroRegistro.Width = 40;
            // 
            // ventasFechaEmision
            // 
            this.ventasFechaEmision.DataPropertyName = "FechaEmision";
            this.ventasFechaEmision.HeaderText = "Fecha Emisión";
            this.ventasFechaEmision.MinimumWidth = 22;
            this.ventasFechaEmision.Name = "ventasFechaEmision";
            this.ventasFechaEmision.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasFechaEmision.Width = 70;
            // 
            // ventasFechaPago
            // 
            this.ventasFechaPago.DataPropertyName = "FechaPago";
            this.ventasFechaPago.HeaderText = "Fecha Pago";
            this.ventasFechaPago.MinimumWidth = 22;
            this.ventasFechaPago.Name = "ventasFechaPago";
            this.ventasFechaPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasFechaPago.Width = 70;
            // 
            // ventasCdpTipo
            // 
            this.ventasCdpTipo.DataPropertyName = "CTipo";
            this.ventasCdpTipo.HeaderText = "CDP Tipo";
            this.ventasCdpTipo.MinimumWidth = 22;
            this.ventasCdpTipo.Name = "ventasCdpTipo";
            this.ventasCdpTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ventasCdpSerie
            // 
            this.ventasCdpSerie.DataPropertyName = "CSerie";
            this.ventasCdpSerie.HeaderText = "CDP Serie";
            this.ventasCdpSerie.MinimumWidth = 22;
            this.ventasCdpSerie.Name = "ventasCdpSerie";
            this.ventasCdpSerie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasCdpSerie.Width = 50;
            // 
            // ventasCdpNumero
            // 
            this.ventasCdpNumero.DataPropertyName = "CNDocumento";
            this.ventasCdpNumero.HeaderText = "CDP N°";
            this.ventasCdpNumero.MinimumWidth = 22;
            this.ventasCdpNumero.Name = "ventasCdpNumero";
            this.ventasCdpNumero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasCdpNumero.Width = 50;
            // 
            // ventasProveedorTipo
            // 
            this.ventasProveedorTipo.DataPropertyName = "PTipo";
            this.ventasProveedorTipo.HeaderText = "Tipo Proveedor";
            this.ventasProveedorTipo.MinimumWidth = 22;
            this.ventasProveedorTipo.Name = "ventasProveedorTipo";
            this.ventasProveedorTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasProveedorTipo.Width = 40;
            // 
            // ventasProveedorNumero
            // 
            this.ventasProveedorNumero.DataPropertyName = "PNumero";
            this.ventasProveedorNumero.HeaderText = "N° Proveedor";
            this.ventasProveedorNumero.MinimumWidth = 22;
            this.ventasProveedorNumero.Name = "ventasProveedorNumero";
            this.ventasProveedorNumero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasProveedorNumero.Width = 70;
            // 
            // ventasProveedorRazonSocial
            // 
            this.ventasProveedorRazonSocial.DataPropertyName = "PNombreRazonSocial";
            this.ventasProveedorRazonSocial.HeaderText = "Razón Social Proveedor";
            this.ventasProveedorRazonSocial.MinimumWidth = 22;
            this.ventasProveedorRazonSocial.Name = "ventasProveedorRazonSocial";
            this.ventasProveedorRazonSocial.ReadOnly = true;
            this.ventasProveedorRazonSocial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ventasCuenta
            // 
            this.ventasCuenta.DataPropertyName = "Cuenta";
            this.ventasCuenta.HeaderText = "Cuenta";
            this.ventasCuenta.MinimumWidth = 22;
            this.ventasCuenta.Name = "ventasCuenta";
            this.ventasCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasCuenta.Width = 50;
            // 
            // ventasDescripcion
            // 
            this.ventasDescripcion.DataPropertyName = "Descripcion";
            this.ventasDescripcion.HeaderText = "Descripción";
            this.ventasDescripcion.MinimumWidth = 22;
            this.ventasDescripcion.Name = "ventasDescripcion";
            this.ventasDescripcion.ReadOnly = true;
            this.ventasDescripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ventasValorExportacion
            // 
            this.ventasValorExportacion.DataPropertyName = "ValorExportacion";
            this.ventasValorExportacion.HeaderText = "Valor Exportación";
            this.ventasValorExportacion.MinimumWidth = 22;
            this.ventasValorExportacion.Name = "ventasValorExportacion";
            this.ventasValorExportacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasValorExportacion.Width = 60;
            // 
            // ventasBaseImponible
            // 
            this.ventasBaseImponible.DataPropertyName = "BaseImponible";
            this.ventasBaseImponible.HeaderText = "Base Imponible";
            this.ventasBaseImponible.MinimumWidth = 22;
            this.ventasBaseImponible.Name = "ventasBaseImponible";
            this.ventasBaseImponible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasBaseImponible.Width = 60;
            // 
            // ventasImporteTotalExonerada
            // 
            this.ventasImporteTotalExonerada.DataPropertyName = "ImporteTotalExonerada";
            this.ventasImporteTotalExonerada.HeaderText = "Importe Total Exonerada";
            this.ventasImporteTotalExonerada.MinimumWidth = 22;
            this.ventasImporteTotalExonerada.Name = "ventasImporteTotalExonerada";
            this.ventasImporteTotalExonerada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasImporteTotalExonerada.Width = 60;
            // 
            // ventasImporteTotalInafecta
            // 
            this.ventasImporteTotalInafecta.DataPropertyName = "ImporteTotalInafecta";
            this.ventasImporteTotalInafecta.HeaderText = "Importe Total Inafecta";
            this.ventasImporteTotalInafecta.MinimumWidth = 22;
            this.ventasImporteTotalInafecta.Name = "ventasImporteTotalInafecta";
            this.ventasImporteTotalInafecta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasImporteTotalInafecta.Width = 60;
            // 
            // ventasIgv
            // 
            this.ventasIgv.DataPropertyName = "IGV";
            this.ventasIgv.HeaderText = "IGV";
            this.ventasIgv.MinimumWidth = 22;
            this.ventasIgv.Name = "ventasIgv";
            this.ventasIgv.ReadOnly = true;
            this.ventasIgv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasIgv.Width = 60;
            // 
            // ventasImporteTotal
            // 
            this.ventasImporteTotal.DataPropertyName = "ImporteTotal";
            this.ventasImporteTotal.HeaderText = "Importe Total";
            this.ventasImporteTotal.MinimumWidth = 22;
            this.ventasImporteTotal.Name = "ventasImporteTotal";
            this.ventasImporteTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasImporteTotal.Width = 60;
            // 
            // ventasTipoCambio
            // 
            this.ventasTipoCambio.DataPropertyName = "TC";
            this.ventasTipoCambio.HeaderText = "Tipo Cambio";
            this.ventasTipoCambio.MinimumWidth = 22;
            this.ventasTipoCambio.Name = "ventasTipoCambio";
            this.ventasTipoCambio.ReadOnly = true;
            this.ventasTipoCambio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasTipoCambio.Width = 60;
            // 
            // ventasDolares
            // 
            this.ventasDolares.DataPropertyName = "Dolares";
            this.ventasDolares.HeaderText = "Dólares";
            this.ventasDolares.MinimumWidth = 22;
            this.ventasDolares.Name = "ventasDolares";
            this.ventasDolares.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasDolares.Width = 60;
            // 
            // ventasIgvRetencion
            // 
            this.ventasIgvRetencion.DataPropertyName = "IgvRetencion";
            this.ventasIgvRetencion.HeaderText = "IGV Retención";
            this.ventasIgvRetencion.MinimumWidth = 22;
            this.ventasIgvRetencion.Name = "ventasIgvRetencion";
            this.ventasIgvRetencion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasIgvRetencion.Width = 60;
            // 
            // ventasCuentaDestino
            // 
            this.ventasCuentaDestino.DataPropertyName = "CuentaDestino";
            this.ventasCuentaDestino.HeaderText = "Cuenta Destino";
            this.ventasCuentaDestino.MinimumWidth = 22;
            this.ventasCuentaDestino.Name = "ventasCuentaDestino";
            this.ventasCuentaDestino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasCuentaDestino.Width = 60;
            // 
            // ventasCuentaDestinoDescripcion
            // 
            this.ventasCuentaDestinoDescripcion.DataPropertyName = "CuentaDestinoDescripcion";
            this.ventasCuentaDestinoDescripcion.HeaderText = "Destino Descripción";
            this.ventasCuentaDestinoDescripcion.MinimumWidth = 22;
            this.ventasCuentaDestinoDescripcion.Name = "ventasCuentaDestinoDescripcion";
            this.ventasCuentaDestinoDescripcion.ReadOnly = true;
            this.ventasCuentaDestinoDescripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ventasReferenciaFecha
            // 
            this.ventasReferenciaFecha.DataPropertyName = "ReferenciaFecha";
            this.ventasReferenciaFecha.HeaderText = "Fecha Referencia";
            this.ventasReferenciaFecha.MinimumWidth = 22;
            this.ventasReferenciaFecha.Name = "ventasReferenciaFecha";
            this.ventasReferenciaFecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasReferenciaFecha.Width = 70;
            // 
            // ventasReferenciaTipo
            // 
            this.ventasReferenciaTipo.DataPropertyName = "ReferenciaTipo";
            this.ventasReferenciaTipo.HeaderText = "Tipo Referencia";
            this.ventasReferenciaTipo.MinimumWidth = 22;
            this.ventasReferenciaTipo.Name = "ventasReferenciaTipo";
            this.ventasReferenciaTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ventasReferenciaSerie
            // 
            this.ventasReferenciaSerie.DataPropertyName = "ReferenciaSerie";
            this.ventasReferenciaSerie.HeaderText = "Serie Referencia";
            this.ventasReferenciaSerie.MinimumWidth = 22;
            this.ventasReferenciaSerie.Name = "ventasReferenciaSerie";
            this.ventasReferenciaSerie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasReferenciaSerie.Width = 60;
            // 
            // ventasReferenciaNumero
            // 
            this.ventasReferenciaNumero.DataPropertyName = "ReferenciaNumeroDocumento";
            this.ventasReferenciaNumero.HeaderText = "N° Referencia";
            this.ventasReferenciaNumero.MinimumWidth = 22;
            this.ventasReferenciaNumero.Name = "ventasReferenciaNumero";
            this.ventasReferenciaNumero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasReferenciaNumero.Width = 60;
            // 
            // ventasCodigo
            // 
            this.ventasCodigo.DataPropertyName = "Codigo";
            this.ventasCodigo.HeaderText = "Código";
            this.ventasCodigo.MinimumWidth = 22;
            this.ventasCodigo.Name = "ventasCodigo";
            this.ventasCodigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasCodigo.Width = 30;
            // 
            // ventasConstanciaNumero
            // 
            this.ventasConstanciaNumero.DataPropertyName = "ConstanciaNumero";
            this.ventasConstanciaNumero.HeaderText = "N° Constancia";
            this.ventasConstanciaNumero.MinimumWidth = 22;
            this.ventasConstanciaNumero.Name = "ventasConstanciaNumero";
            this.ventasConstanciaNumero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasConstanciaNumero.Width = 60;
            // 
            // ventasConstanciaFechaPago
            // 
            this.ventasConstanciaFechaPago.DataPropertyName = "ConstanciaFechaPago";
            this.ventasConstanciaFechaPago.HeaderText = "Constancia Fecha Pago";
            this.ventasConstanciaFechaPago.MinimumWidth = 22;
            this.ventasConstanciaFechaPago.Name = "ventasConstanciaFechaPago";
            this.ventasConstanciaFechaPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasConstanciaFechaPago.Width = 70;
            // 
            // ventasDetraccionSoles
            // 
            this.ventasDetraccionSoles.DataPropertyName = "DetraccionSoles";
            this.ventasDetraccionSoles.HeaderText = "Detracción Soles";
            this.ventasDetraccionSoles.MinimumWidth = 22;
            this.ventasDetraccionSoles.Name = "ventasDetraccionSoles";
            this.ventasDetraccionSoles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasDetraccionSoles.Width = 60;
            // 
            // ventasReferencia
            // 
            this.ventasReferencia.DataPropertyName = "Referencia";
            this.ventasReferencia.HeaderText = "Monto Referencial";
            this.ventasReferencia.MinimumWidth = 22;
            this.ventasReferencia.Name = "ventasReferencia";
            this.ventasReferencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ventasReferencia.Width = 60;
            // 
            // ventasObservacion
            // 
            this.ventasObservacion.DataPropertyName = "Observacion";
            this.ventasObservacion.HeaderText = "Observación";
            this.ventasObservacion.MinimumWidth = 22;
            this.ventasObservacion.Name = "ventasObservacion";
            this.ventasObservacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // idLibroVentasDataGridViewTextBoxColumn
            // 
            this.idLibroVentasDataGridViewTextBoxColumn.DataPropertyName = "idLibroVentas";
            this.idLibroVentasDataGridViewTextBoxColumn.HeaderText = "idLibroVentas";
            this.idLibroVentasDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idLibroVentasDataGridViewTextBoxColumn.Name = "idLibroVentasDataGridViewTextBoxColumn";
            this.idLibroVentasDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLibroVentasDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mes";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mes";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NReg";
            this.dataGridViewTextBoxColumn6.HeaderText = "NReg";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FechaEmision";
            this.dataGridViewTextBoxColumn7.HeaderText = "FechaEmision";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaPagoDataGridViewTextBoxColumn1
            // 
            this.fechaPagoDataGridViewTextBoxColumn1.DataPropertyName = "FechaPago";
            this.fechaPagoDataGridViewTextBoxColumn1.HeaderText = "FechaPago";
            this.fechaPagoDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.fechaPagoDataGridViewTextBoxColumn1.Name = "fechaPagoDataGridViewTextBoxColumn1";
            this.fechaPagoDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cTipoDataGridViewTextBoxColumn1
            // 
            this.cTipoDataGridViewTextBoxColumn1.DataPropertyName = "CTipo";
            this.cTipoDataGridViewTextBoxColumn1.HeaderText = "CTipo";
            this.cTipoDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.cTipoDataGridViewTextBoxColumn1.Name = "cTipoDataGridViewTextBoxColumn1";
            this.cTipoDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cSerieDataGridViewTextBoxColumn1
            // 
            this.cSerieDataGridViewTextBoxColumn1.DataPropertyName = "CSerie";
            this.cSerieDataGridViewTextBoxColumn1.HeaderText = "CSerie";
            this.cSerieDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.cSerieDataGridViewTextBoxColumn1.Name = "cSerieDataGridViewTextBoxColumn1";
            this.cSerieDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cNDocumentoDataGridViewTextBoxColumn1
            // 
            this.cNDocumentoDataGridViewTextBoxColumn1.DataPropertyName = "CNDocumento";
            this.cNDocumentoDataGridViewTextBoxColumn1.HeaderText = "CNDocumento";
            this.cNDocumentoDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.cNDocumentoDataGridViewTextBoxColumn1.Name = "cNDocumentoDataGridViewTextBoxColumn1";
            this.cNDocumentoDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pTipoDataGridViewTextBoxColumn1
            // 
            this.pTipoDataGridViewTextBoxColumn1.DataPropertyName = "PTipo";
            this.pTipoDataGridViewTextBoxColumn1.HeaderText = "PTipo";
            this.pTipoDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.pTipoDataGridViewTextBoxColumn1.Name = "pTipoDataGridViewTextBoxColumn1";
            this.pTipoDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pNumeroDataGridViewTextBoxColumn1
            // 
            this.pNumeroDataGridViewTextBoxColumn1.DataPropertyName = "PNumero";
            this.pNumeroDataGridViewTextBoxColumn1.HeaderText = "PNumero";
            this.pNumeroDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.pNumeroDataGridViewTextBoxColumn1.Name = "pNumeroDataGridViewTextBoxColumn1";
            this.pNumeroDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pNombreRazonSocialDataGridViewTextBoxColumn1
            // 
            this.pNombreRazonSocialDataGridViewTextBoxColumn1.DataPropertyName = "PNombreRazonSocial";
            this.pNombreRazonSocialDataGridViewTextBoxColumn1.HeaderText = "PNombreRazonSocial";
            this.pNombreRazonSocialDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.pNombreRazonSocialDataGridViewTextBoxColumn1.Name = "pNombreRazonSocialDataGridViewTextBoxColumn1";
            this.pNombreRazonSocialDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cuentaDataGridViewTextBoxColumn1
            // 
            this.cuentaDataGridViewTextBoxColumn1.DataPropertyName = "Cuenta";
            this.cuentaDataGridViewTextBoxColumn1.HeaderText = "Cuenta";
            this.cuentaDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.cuentaDataGridViewTextBoxColumn1.Name = "cuentaDataGridViewTextBoxColumn1";
            this.cuentaDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // descripcionDataGridViewTextBoxColumn1
            // 
            this.descripcionDataGridViewTextBoxColumn1.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.descripcionDataGridViewTextBoxColumn1.Name = "descripcionDataGridViewTextBoxColumn1";
            this.descripcionDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // valorExportacionDataGridViewTextBoxColumn
            // 
            this.valorExportacionDataGridViewTextBoxColumn.DataPropertyName = "ValorExportacion";
            this.valorExportacionDataGridViewTextBoxColumn.HeaderText = "ValorExportacion";
            this.valorExportacionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.valorExportacionDataGridViewTextBoxColumn.Name = "valorExportacionDataGridViewTextBoxColumn";
            this.valorExportacionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // baseImponibleDataGridViewTextBoxColumn1
            // 
            this.baseImponibleDataGridViewTextBoxColumn1.DataPropertyName = "BaseImponible";
            this.baseImponibleDataGridViewTextBoxColumn1.HeaderText = "BaseImponible";
            this.baseImponibleDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.baseImponibleDataGridViewTextBoxColumn1.Name = "baseImponibleDataGridViewTextBoxColumn1";
            this.baseImponibleDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // importeTotalExoneradaDataGridViewTextBoxColumn
            // 
            this.importeTotalExoneradaDataGridViewTextBoxColumn.DataPropertyName = "ImporteTotalExonerada";
            this.importeTotalExoneradaDataGridViewTextBoxColumn.HeaderText = "ImporteTotalExonerada";
            this.importeTotalExoneradaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.importeTotalExoneradaDataGridViewTextBoxColumn.Name = "importeTotalExoneradaDataGridViewTextBoxColumn";
            this.importeTotalExoneradaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // importeTotalInafectaDataGridViewTextBoxColumn
            // 
            this.importeTotalInafectaDataGridViewTextBoxColumn.DataPropertyName = "ImporteTotalInafecta";
            this.importeTotalInafectaDataGridViewTextBoxColumn.HeaderText = "ImporteTotalInafecta";
            this.importeTotalInafectaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.importeTotalInafectaDataGridViewTextBoxColumn.Name = "importeTotalInafectaDataGridViewTextBoxColumn";
            this.importeTotalInafectaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // iGVDataGridViewTextBoxColumn1
            // 
            this.iGVDataGridViewTextBoxColumn1.DataPropertyName = "IGV";
            this.iGVDataGridViewTextBoxColumn1.HeaderText = "IGV";
            this.iGVDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.iGVDataGridViewTextBoxColumn1.Name = "iGVDataGridViewTextBoxColumn1";
            this.iGVDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // importeTotalDataGridViewTextBoxColumn1
            // 
            this.importeTotalDataGridViewTextBoxColumn1.DataPropertyName = "ImporteTotal";
            this.importeTotalDataGridViewTextBoxColumn1.HeaderText = "ImporteTotal";
            this.importeTotalDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.importeTotalDataGridViewTextBoxColumn1.Name = "importeTotalDataGridViewTextBoxColumn1";
            this.importeTotalDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tCDataGridViewTextBoxColumn
            // 
            this.tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
            this.tCDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dolaresDataGridViewTextBoxColumn1
            // 
            this.dolaresDataGridViewTextBoxColumn1.DataPropertyName = "Dolares";
            this.dolaresDataGridViewTextBoxColumn1.HeaderText = "Dolares";
            this.dolaresDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.dolaresDataGridViewTextBoxColumn1.Name = "dolaresDataGridViewTextBoxColumn1";
            this.dolaresDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // igvRetencionDataGridViewTextBoxColumn
            // 
            this.igvRetencionDataGridViewTextBoxColumn.DataPropertyName = "IgvRetencion";
            this.igvRetencionDataGridViewTextBoxColumn.HeaderText = "IgvRetencion";
            this.igvRetencionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.igvRetencionDataGridViewTextBoxColumn.Name = "igvRetencionDataGridViewTextBoxColumn";
            this.igvRetencionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cuentaDestinoDataGridViewTextBoxColumn1
            // 
            this.cuentaDestinoDataGridViewTextBoxColumn1.DataPropertyName = "CuentaDestino";
            this.cuentaDestinoDataGridViewTextBoxColumn1.HeaderText = "CuentaDestino";
            this.cuentaDestinoDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.cuentaDestinoDataGridViewTextBoxColumn1.Name = "cuentaDestinoDataGridViewTextBoxColumn1";
            this.cuentaDestinoDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pagoDataGridViewTextBoxColumn
            // 
            this.pagoDataGridViewTextBoxColumn.DataPropertyName = "Pago";
            this.pagoDataGridViewTextBoxColumn.HeaderText = "Pago";
            this.pagoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pagoDataGridViewTextBoxColumn.Name = "pagoDataGridViewTextBoxColumn";
            this.pagoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // referenciaFechaDataGridViewTextBoxColumn1
            // 
            this.referenciaFechaDataGridViewTextBoxColumn1.DataPropertyName = "ReferenciaFecha";
            this.referenciaFechaDataGridViewTextBoxColumn1.HeaderText = "ReferenciaFecha";
            this.referenciaFechaDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.referenciaFechaDataGridViewTextBoxColumn1.Name = "referenciaFechaDataGridViewTextBoxColumn1";
            this.referenciaFechaDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // referenciaTipoDataGridViewTextBoxColumn1
            // 
            this.referenciaTipoDataGridViewTextBoxColumn1.DataPropertyName = "ReferenciaTipo";
            this.referenciaTipoDataGridViewTextBoxColumn1.HeaderText = "ReferenciaTipo";
            this.referenciaTipoDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.referenciaTipoDataGridViewTextBoxColumn1.Name = "referenciaTipoDataGridViewTextBoxColumn1";
            this.referenciaTipoDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // referenciaSerieDataGridViewTextBoxColumn1
            // 
            this.referenciaSerieDataGridViewTextBoxColumn1.DataPropertyName = "ReferenciaSerie";
            this.referenciaSerieDataGridViewTextBoxColumn1.HeaderText = "ReferenciaSerie";
            this.referenciaSerieDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.referenciaSerieDataGridViewTextBoxColumn1.Name = "referenciaSerieDataGridViewTextBoxColumn1";
            this.referenciaSerieDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // referenciaNumeroDocumentoDataGridViewTextBoxColumn
            // 
            this.referenciaNumeroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "ReferenciaNumeroDocumento";
            this.referenciaNumeroDocumentoDataGridViewTextBoxColumn.HeaderText = "ReferenciaNumeroDocumento";
            this.referenciaNumeroDocumentoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.referenciaNumeroDocumentoDataGridViewTextBoxColumn.Name = "referenciaNumeroDocumentoDataGridViewTextBoxColumn";
            this.referenciaNumeroDocumentoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // codigoDataGridViewTextBoxColumn1
            // 
            this.codigoDataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.codigoDataGridViewTextBoxColumn1.Name = "codigoDataGridViewTextBoxColumn1";
            this.codigoDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // constanciaNumeroDataGridViewTextBoxColumn1
            // 
            this.constanciaNumeroDataGridViewTextBoxColumn1.DataPropertyName = "ConstanciaNumero";
            this.constanciaNumeroDataGridViewTextBoxColumn1.HeaderText = "ConstanciaNumero";
            this.constanciaNumeroDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.constanciaNumeroDataGridViewTextBoxColumn1.Name = "constanciaNumeroDataGridViewTextBoxColumn1";
            this.constanciaNumeroDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // constanciaFechaPagoDataGridViewTextBoxColumn1
            // 
            this.constanciaFechaPagoDataGridViewTextBoxColumn1.DataPropertyName = "ConstanciaFechaPago";
            this.constanciaFechaPagoDataGridViewTextBoxColumn1.HeaderText = "ConstanciaFechaPago";
            this.constanciaFechaPagoDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.constanciaFechaPagoDataGridViewTextBoxColumn1.Name = "constanciaFechaPagoDataGridViewTextBoxColumn1";
            this.constanciaFechaPagoDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // detraccionSolesDataGridViewTextBoxColumn
            // 
            this.detraccionSolesDataGridViewTextBoxColumn.DataPropertyName = "DetraccionSoles";
            this.detraccionSolesDataGridViewTextBoxColumn.HeaderText = "DetraccionSoles";
            this.detraccionSolesDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.detraccionSolesDataGridViewTextBoxColumn.Name = "detraccionSolesDataGridViewTextBoxColumn";
            this.detraccionSolesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // referenciaDataGridViewTextBoxColumn
            // 
            this.referenciaDataGridViewTextBoxColumn.DataPropertyName = "Referencia";
            this.referenciaDataGridViewTextBoxColumn.HeaderText = "Referencia";
            this.referenciaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.referenciaDataGridViewTextBoxColumn.Name = "referenciaDataGridViewTextBoxColumn";
            this.referenciaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // observacionDataGridViewTextBoxColumn
            // 
            this.observacionDataGridViewTextBoxColumn.DataPropertyName = "Observacion";
            this.observacionDataGridViewTextBoxColumn.HeaderText = "Observacion";
            this.observacionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.observacionDataGridViewTextBoxColumn.Name = "observacionDataGridViewTextBoxColumn";
            this.observacionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // usuarioDataGridViewTextBoxColumn1
            // 
            this.usuarioDataGridViewTextBoxColumn1.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn1.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.usuarioDataGridViewTextBoxColumn1.Name = "usuarioDataGridViewTextBoxColumn1";
            this.usuarioDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaRegistroDataGridViewTextBoxColumn1
            // 
            this.fechaRegistroDataGridViewTextBoxColumn1.DataPropertyName = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn1.HeaderText = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.fechaRegistroDataGridViewTextBoxColumn1.Name = "fechaRegistroDataGridViewTextBoxColumn1";
            this.fechaRegistroDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaModificacionDataGridViewTextBoxColumn1
            // 
            this.fechaModificacionDataGridViewTextBoxColumn1.DataPropertyName = "FechaModificacion";
            this.fechaModificacionDataGridViewTextBoxColumn1.HeaderText = "FechaModificacion";
            this.fechaModificacionDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.fechaModificacionDataGridViewTextBoxColumn1.Name = "fechaModificacionDataGridViewTextBoxColumn1";
            this.fechaModificacionDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cuentaDestinoDescripcionDataGridViewTextBoxColumn
            // 
            this.cuentaDestinoDescripcionDataGridViewTextBoxColumn.DataPropertyName = "CuentaDestinoDescripcion";
            this.cuentaDestinoDescripcionDataGridViewTextBoxColumn.HeaderText = "CuentaDestinoDescripcion";
            this.cuentaDestinoDescripcionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cuentaDestinoDescripcionDataGridViewTextBoxColumn.Name = "cuentaDestinoDescripcionDataGridViewTextBoxColumn";
            this.cuentaDestinoDescripcionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // comprasID
            // 
            this.comprasID.DataPropertyName = "IdLibroCompras";
            this.comprasID.HeaderText = "#";
            this.comprasID.MinimumWidth = 22;
            this.comprasID.Name = "comprasID";
            this.comprasID.ReadOnly = true;
            this.comprasID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comprasID.Width = 40;
            // 
            // comprasNumeroRegistro
            // 
            this.comprasNumeroRegistro.DataPropertyName = "NReg";
            this.comprasNumeroRegistro.HeaderText = "N° Registro";
            this.comprasNumeroRegistro.MinimumWidth = 22;
            this.comprasNumeroRegistro.Name = "comprasNumeroRegistro";
            this.comprasNumeroRegistro.ReadOnly = true;
            this.comprasNumeroRegistro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comprasNumeroRegistro.Visible = false;
            this.comprasNumeroRegistro.Width = 50;
            // 
            // comprasFechaEmision
            // 
            this.comprasFechaEmision.DataPropertyName = "FechaEmision";
            this.comprasFechaEmision.HeaderText = "Fecha de Emisión";
            this.comprasFechaEmision.MinimumWidth = 22;
            this.comprasFechaEmision.Name = "comprasFechaEmision";
            this.comprasFechaEmision.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comprasFechaEmision.Width = 70;
            // 
            // comprasFechaPago
            // 
            this.comprasFechaPago.DataPropertyName = "FechaPago";
            this.comprasFechaPago.HeaderText = "Fecha de Pago";
            this.comprasFechaPago.MinimumWidth = 22;
            this.comprasFechaPago.Name = "comprasFechaPago";
            this.comprasFechaPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comprasFechaPago.Width = 70;
            // 
            // comprasCdpTipo
            // 
            this.comprasCdpTipo.DataPropertyName = "CTipo";
            this.comprasCdpTipo.HeaderText = "Tipo Comprobante";
            this.comprasCdpTipo.MinimumWidth = 22;
            this.comprasCdpTipo.Name = "comprasCdpTipo";
            this.comprasCdpTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // comprasCdpSerie
            // 
            this.comprasCdpSerie.DataPropertyName = "CSerie";
            this.comprasCdpSerie.HeaderText = "Serie Comprobante";
            this.comprasCdpSerie.MinimumWidth = 22;
            this.comprasCdpSerie.Name = "comprasCdpSerie";
            this.comprasCdpSerie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.comprasCdpSerie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comprasCdpSerie.Width = 50;
            // 
            // comprasCdpNumeroDocumento
            // 
            this.comprasCdpNumeroDocumento.DataPropertyName = "CNDocumento";
            this.comprasCdpNumeroDocumento.HeaderText = "N° Doc Comprobante";
            this.comprasCdpNumeroDocumento.MinimumWidth = 22;
            this.comprasCdpNumeroDocumento.Name = "comprasCdpNumeroDocumento";
            this.comprasCdpNumeroDocumento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comprasCdpNumeroDocumento.Width = 50;
            // 
            // comprasProveedorTipo
            // 
            this.comprasProveedorTipo.DataPropertyName = "PTipo";
            this.comprasProveedorTipo.HeaderText = "Tipo de Proveedor";
            this.comprasProveedorTipo.MinimumWidth = 22;
            this.comprasProveedorTipo.Name = "comprasProveedorTipo";
            this.comprasProveedorTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comprasProveedorTipo.Width = 40;
            // 
            // comprasProveedorNumeroDocumento
            // 
            this.comprasProveedorNumeroDocumento.DataPropertyName = "PNumero";
            this.comprasProveedorNumeroDocumento.HeaderText = "N° Doc Proveedor";
            this.comprasProveedorNumeroDocumento.MinimumWidth = 22;
            this.comprasProveedorNumeroDocumento.Name = "comprasProveedorNumeroDocumento";
            this.comprasProveedorNumeroDocumento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // comprasProveedorRazonSocial
            // 
            this.comprasProveedorRazonSocial.DataPropertyName = "PNombreRazonSocial";
            this.comprasProveedorRazonSocial.HeaderText = "Razón Social Proveedor";
            this.comprasProveedorRazonSocial.MinimumWidth = 22;
            this.comprasProveedorRazonSocial.Name = "comprasProveedorRazonSocial";
            this.comprasProveedorRazonSocial.ReadOnly = true;
            this.comprasProveedorRazonSocial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comprasProveedorRazonSocial.Width = 150;
            // 
            // comprasCuenta
            // 
            this.comprasCuenta.DataPropertyName = "Cuenta";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            this.comprasCuenta.DefaultCellStyle = dataGridViewCellStyle1;
            this.comprasCuenta.HeaderText = "Cuenta";
            this.comprasCuenta.MinimumWidth = 22;
            this.comprasCuenta.Name = "comprasCuenta";
            this.comprasCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comprasCuenta.Width = 50;
            // 
            // comprasDescripcion
            // 
            this.comprasDescripcion.DataPropertyName = "Descripcion";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Aqua;
            this.comprasDescripcion.DefaultCellStyle = dataGridViewCellStyle2;
            this.comprasDescripcion.HeaderText = "Descripción";
            this.comprasDescripcion.MinimumWidth = 22;
            this.comprasDescripcion.Name = "comprasDescripcion";
            this.comprasDescripcion.ReadOnly = true;
            this.comprasDescripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // comprasBaseImponible
            // 
            this.comprasBaseImponible.DataPropertyName = "BaseImponible";
            this.comprasBaseImponible.HeaderText = "Base Imponible";
            this.comprasBaseImponible.MinimumWidth = 22;
            this.comprasBaseImponible.Name = "comprasBaseImponible";
            this.comprasBaseImponible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comprasBaseImponible.Width = 80;
            // 
            // comprasIgv
            // 
            this.comprasIgv.DataPropertyName = "IGV";
            this.comprasIgv.HeaderText = "IGV";
            this.comprasIgv.MinimumWidth = 22;
            this.comprasIgv.Name = "comprasIgv";
            this.comprasIgv.ReadOnly = true;
            this.comprasIgv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comprasIgv.Width = 80;
            // 
            // comprasNoGravada
            // 
            this.comprasNoGravada.DataPropertyName = "NoGravada";
            this.comprasNoGravada.HeaderText = "No Gravada";
            this.comprasNoGravada.MinimumWidth = 22;
            this.comprasNoGravada.Name = "comprasNoGravada";
            this.comprasNoGravada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comprasNoGravada.Width = 80;
            // 
            // comprasDescuento
            // 
            this.comprasDescuento.DataPropertyName = "Descuentos";
            this.comprasDescuento.HeaderText = "Descuento";
            this.comprasDescuento.MinimumWidth = 22;
            this.comprasDescuento.Name = "comprasDescuento";
            this.comprasDescuento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comprasDescuento.Width = 80;
            // 
            // comprasImporteTotal
            // 
            this.comprasImporteTotal.DataPropertyName = "ImporteTotal";
            this.comprasImporteTotal.HeaderText = "Importe Total";
            this.comprasImporteTotal.MinimumWidth = 22;
            this.comprasImporteTotal.Name = "comprasImporteTotal";
            this.comprasImporteTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comprasImporteTotal.Width = 80;
            // 
            // comprasDolares
            // 
            this.comprasDolares.DataPropertyName = "Dolares";
            this.comprasDolares.HeaderText = "Dólares";
            this.comprasDolares.MinimumWidth = 22;
            this.comprasDolares.Name = "comprasDolares";
            this.comprasDolares.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comprasDolares.Width = 80;
            // 
            // comprasTipoCambio
            // 
            this.comprasTipoCambio.DataPropertyName = "TipoCambio";
            this.comprasTipoCambio.HeaderText = "Tipo de Cambio";
            this.comprasTipoCambio.MinimumWidth = 22;
            this.comprasTipoCambio.Name = "comprasTipoCambio";
            this.comprasTipoCambio.ReadOnly = true;
            this.comprasTipoCambio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comprasTipoCambio.Width = 80;
            // 
            // comprasConversionDolares
            // 
            this.comprasConversionDolares.DataPropertyName = "ConversionDolar";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Aqua;
            this.comprasConversionDolares.DefaultCellStyle = dataGridViewCellStyle3;
            this.comprasConversionDolares.HeaderText = "Conversión Dólares (S/.)";
            this.comprasConversionDolares.MinimumWidth = 22;
            this.comprasConversionDolares.Name = "comprasConversionDolares";
            this.comprasConversionDolares.ReadOnly = true;
            this.comprasConversionDolares.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comprasConversionDolares.Visible = false;
            this.comprasConversionDolares.Width = 80;
            // 
            // comprasPercepcion
            // 
            this.comprasPercepcion.DataPropertyName = "Percepcion";
            this.comprasPercepcion.HeaderText = "Percepción";
            this.comprasPercepcion.MinimumWidth = 22;
            this.comprasPercepcion.Name = "comprasPercepcion";
            this.comprasPercepcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comprasPercepcion.Width = 80;
            // 
            // comprasDestino
            // 
            this.comprasDestino.DataPropertyName = "Destino";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Aqua;
            this.comprasDestino.DefaultCellStyle = dataGridViewCellStyle4;
            this.comprasDestino.HeaderText = "Cuenta Pago";
            this.comprasDestino.MinimumWidth = 22;
            this.comprasDestino.Name = "comprasDestino";
            this.comprasDestino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comprasDestino.Width = 50;
            // 
            // comprasDescripcionDestino
            // 
            this.comprasDescripcionDestino.DataPropertyName = "DescripcionDestino";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Aqua;
            this.comprasDescripcionDestino.DefaultCellStyle = dataGridViewCellStyle5;
            this.comprasDescripcionDestino.HeaderText = "Cuenta Pago Descripción";
            this.comprasDescripcionDestino.MinimumWidth = 22;
            this.comprasDescripcionDestino.Name = "comprasDescripcionDestino";
            this.comprasDescripcionDestino.ReadOnly = true;
            this.comprasDescripcionDestino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // comprasCuentaDestino
            // 
            this.comprasCuentaDestino.DataPropertyName = "CuentaDestino";
            this.comprasCuentaDestino.HeaderText = "Cuenta Destino";
            this.comprasCuentaDestino.MinimumWidth = 22;
            this.comprasCuentaDestino.Name = "comprasCuentaDestino";
            this.comprasCuentaDestino.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.comprasCuentaDestino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comprasCuentaDestino.Width = 150;
            // 
            // comprasCodigo
            // 
            this.comprasCodigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Aqua;
            this.comprasCodigo.DefaultCellStyle = dataGridViewCellStyle6;
            this.comprasCodigo.HeaderText = "Código";
            this.comprasCodigo.MinimumWidth = 22;
            this.comprasCodigo.Name = "comprasCodigo";
            this.comprasCodigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comprasCodigo.Width = 40;
            // 
            // comprasConstanciaNumero
            // 
            this.comprasConstanciaNumero.DataPropertyName = "ConstanciaNumero";
            this.comprasConstanciaNumero.HeaderText = "Constancia Número";
            this.comprasConstanciaNumero.MinimumWidth = 22;
            this.comprasConstanciaNumero.Name = "comprasConstanciaNumero";
            this.comprasConstanciaNumero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // comprasConstanciaFechaPago
            // 
            this.comprasConstanciaFechaPago.DataPropertyName = "ConstanciaFechaPago";
            this.comprasConstanciaFechaPago.HeaderText = "Constancia Fecha Pago";
            this.comprasConstanciaFechaPago.MinimumWidth = 22;
            this.comprasConstanciaFechaPago.Name = "comprasConstanciaFechaPago";
            this.comprasConstanciaFechaPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // comprasConstanciaMonto
            // 
            this.comprasConstanciaMonto.DataPropertyName = "ConstanciaMonto";
            this.comprasConstanciaMonto.HeaderText = "Constancia Monto";
            this.comprasConstanciaMonto.MinimumWidth = 22;
            this.comprasConstanciaMonto.Name = "comprasConstanciaMonto";
            this.comprasConstanciaMonto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // comprasConstanciaReferencia
            // 
            this.comprasConstanciaReferencia.DataPropertyName = "ConstanciaReferencia";
            this.comprasConstanciaReferencia.HeaderText = "Monto Referencial";
            this.comprasConstanciaReferencia.MinimumWidth = 22;
            this.comprasConstanciaReferencia.Name = "comprasConstanciaReferencia";
            this.comprasConstanciaReferencia.ReadOnly = true;
            this.comprasConstanciaReferencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // BancarizacionFecha
            // 
            this.BancarizacionFecha.DataPropertyName = "BancarizacionFecha";
            this.BancarizacionFecha.HeaderText = "Bancarización Fecha";
            this.BancarizacionFecha.MinimumWidth = 22;
            this.BancarizacionFecha.Name = "BancarizacionFecha";
            this.BancarizacionFecha.ReadOnly = true;
            this.BancarizacionFecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // BancarizacionBco
            // 
            this.BancarizacionBco.DataPropertyName = "BancarizacionBco";
            this.BancarizacionBco.HeaderText = "Bancarización Banco";
            this.BancarizacionBco.MinimumWidth = 22;
            this.BancarizacionBco.Name = "BancarizacionBco";
            this.BancarizacionBco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // BancarizacionOperacion
            // 
            this.BancarizacionOperacion.DataPropertyName = "BancarizacionOperacion";
            this.BancarizacionOperacion.HeaderText = "Bancarización Operación";
            this.BancarizacionOperacion.MinimumWidth = 22;
            this.BancarizacionOperacion.Name = "BancarizacionOperacion";
            this.BancarizacionOperacion.ReadOnly = true;
            this.BancarizacionOperacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // comprasReferenciaFecha
            // 
            this.comprasReferenciaFecha.DataPropertyName = "ReferenciaFecha";
            this.comprasReferenciaFecha.HeaderText = "Referencia Fecha";
            this.comprasReferenciaFecha.MinimumWidth = 22;
            this.comprasReferenciaFecha.Name = "comprasReferenciaFecha";
            this.comprasReferenciaFecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // comprasReferenciaTipo
            // 
            this.comprasReferenciaTipo.DataPropertyName = "ReferenciaTipo";
            this.comprasReferenciaTipo.HeaderText = "Referencia Tipo";
            this.comprasReferenciaTipo.MinimumWidth = 22;
            this.comprasReferenciaTipo.Name = "comprasReferenciaTipo";
            this.comprasReferenciaTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // comprasReferenciaSerie
            // 
            this.comprasReferenciaSerie.DataPropertyName = "ReferenciaSerie";
            this.comprasReferenciaSerie.HeaderText = "Referencia Serie";
            this.comprasReferenciaSerie.MinimumWidth = 22;
            this.comprasReferenciaSerie.Name = "comprasReferenciaSerie";
            this.comprasReferenciaSerie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // comprasReferenciaNumero
            // 
            this.comprasReferenciaNumero.DataPropertyName = "ReferenciaNumero";
            this.comprasReferenciaNumero.HeaderText = "N° Referencia";
            this.comprasReferenciaNumero.MinimumWidth = 22;
            this.comprasReferenciaNumero.Name = "comprasReferenciaNumero";
            this.comprasReferenciaNumero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idLibroCompras";
            this.dataGridViewTextBoxColumn1.HeaderText = "idLibroCompras";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Mes";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mes";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NReg";
            this.dataGridViewTextBoxColumn3.HeaderText = "NReg";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FechaEmision";
            this.dataGridViewTextBoxColumn4.HeaderText = "FechaEmision";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaPagoDataGridViewTextBoxColumn
            // 
            this.fechaPagoDataGridViewTextBoxColumn.DataPropertyName = "FechaPago";
            this.fechaPagoDataGridViewTextBoxColumn.HeaderText = "FechaPago";
            this.fechaPagoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fechaPagoDataGridViewTextBoxColumn.Name = "fechaPagoDataGridViewTextBoxColumn";
            this.fechaPagoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cTipoDataGridViewTextBoxColumn
            // 
            this.cTipoDataGridViewTextBoxColumn.DataPropertyName = "CTipo";
            this.cTipoDataGridViewTextBoxColumn.HeaderText = "CTipo";
            this.cTipoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cTipoDataGridViewTextBoxColumn.Name = "cTipoDataGridViewTextBoxColumn";
            this.cTipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cSerieDataGridViewTextBoxColumn
            // 
            this.cSerieDataGridViewTextBoxColumn.DataPropertyName = "CSerie";
            this.cSerieDataGridViewTextBoxColumn.HeaderText = "CSerie";
            this.cSerieDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cSerieDataGridViewTextBoxColumn.Name = "cSerieDataGridViewTextBoxColumn";
            this.cSerieDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cNDocumentoDataGridViewTextBoxColumn
            // 
            this.cNDocumentoDataGridViewTextBoxColumn.DataPropertyName = "CNDocumento";
            this.cNDocumentoDataGridViewTextBoxColumn.HeaderText = "CNDocumento";
            this.cNDocumentoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cNDocumentoDataGridViewTextBoxColumn.Name = "cNDocumentoDataGridViewTextBoxColumn";
            this.cNDocumentoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pTipoDataGridViewTextBoxColumn
            // 
            this.pTipoDataGridViewTextBoxColumn.DataPropertyName = "PTipo";
            this.pTipoDataGridViewTextBoxColumn.HeaderText = "PTipo";
            this.pTipoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pTipoDataGridViewTextBoxColumn.Name = "pTipoDataGridViewTextBoxColumn";
            this.pTipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pNumeroDataGridViewTextBoxColumn
            // 
            this.pNumeroDataGridViewTextBoxColumn.DataPropertyName = "PNumero";
            this.pNumeroDataGridViewTextBoxColumn.HeaderText = "PNumero";
            this.pNumeroDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pNumeroDataGridViewTextBoxColumn.Name = "pNumeroDataGridViewTextBoxColumn";
            this.pNumeroDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pDocumentoDataGridViewTextBoxColumn
            // 
            this.pDocumentoDataGridViewTextBoxColumn.DataPropertyName = "PDocumento";
            this.pDocumentoDataGridViewTextBoxColumn.HeaderText = "PDocumento";
            this.pDocumentoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pDocumentoDataGridViewTextBoxColumn.Name = "pDocumentoDataGridViewTextBoxColumn";
            this.pDocumentoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pNombreRazonSocialDataGridViewTextBoxColumn
            // 
            this.pNombreRazonSocialDataGridViewTextBoxColumn.DataPropertyName = "PNombreRazonSocial";
            this.pNombreRazonSocialDataGridViewTextBoxColumn.HeaderText = "PNombreRazonSocial";
            this.pNombreRazonSocialDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pNombreRazonSocialDataGridViewTextBoxColumn.Name = "pNombreRazonSocialDataGridViewTextBoxColumn";
            this.pNombreRazonSocialDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cuentaDataGridViewTextBoxColumn
            // 
            this.cuentaDataGridViewTextBoxColumn.DataPropertyName = "Cuenta";
            this.cuentaDataGridViewTextBoxColumn.HeaderText = "Cuenta";
            this.cuentaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cuentaDataGridViewTextBoxColumn.Name = "cuentaDataGridViewTextBoxColumn";
            this.cuentaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // baseImponibleDataGridViewTextBoxColumn
            // 
            this.baseImponibleDataGridViewTextBoxColumn.DataPropertyName = "BaseImponible";
            this.baseImponibleDataGridViewTextBoxColumn.HeaderText = "BaseImponible";
            this.baseImponibleDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.baseImponibleDataGridViewTextBoxColumn.Name = "baseImponibleDataGridViewTextBoxColumn";
            this.baseImponibleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // iGVDataGridViewTextBoxColumn
            // 
            this.iGVDataGridViewTextBoxColumn.DataPropertyName = "IGV";
            this.iGVDataGridViewTextBoxColumn.HeaderText = "IGV";
            this.iGVDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.iGVDataGridViewTextBoxColumn.Name = "iGVDataGridViewTextBoxColumn";
            this.iGVDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // noGravadaDataGridViewTextBoxColumn
            // 
            this.noGravadaDataGridViewTextBoxColumn.DataPropertyName = "NoGravada";
            this.noGravadaDataGridViewTextBoxColumn.HeaderText = "NoGravada";
            this.noGravadaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.noGravadaDataGridViewTextBoxColumn.Name = "noGravadaDataGridViewTextBoxColumn";
            this.noGravadaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // descuentosDataGridViewTextBoxColumn
            // 
            this.descuentosDataGridViewTextBoxColumn.DataPropertyName = "Descuentos";
            this.descuentosDataGridViewTextBoxColumn.HeaderText = "Descuentos";
            this.descuentosDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.descuentosDataGridViewTextBoxColumn.Name = "descuentosDataGridViewTextBoxColumn";
            this.descuentosDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // importeTotalDataGridViewTextBoxColumn
            // 
            this.importeTotalDataGridViewTextBoxColumn.DataPropertyName = "ImporteTotal";
            this.importeTotalDataGridViewTextBoxColumn.HeaderText = "ImporteTotal";
            this.importeTotalDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.importeTotalDataGridViewTextBoxColumn.Name = "importeTotalDataGridViewTextBoxColumn";
            this.importeTotalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dolaresDataGridViewTextBoxColumn
            // 
            this.dolaresDataGridViewTextBoxColumn.DataPropertyName = "Dolares";
            this.dolaresDataGridViewTextBoxColumn.HeaderText = "Dolares";
            this.dolaresDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.dolaresDataGridViewTextBoxColumn.Name = "dolaresDataGridViewTextBoxColumn";
            this.dolaresDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // conversionDolarDataGridViewTextBoxColumn
            // 
            this.conversionDolarDataGridViewTextBoxColumn.DataPropertyName = "ConversionDolar";
            this.conversionDolarDataGridViewTextBoxColumn.HeaderText = "ConversionDolar";
            this.conversionDolarDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.conversionDolarDataGridViewTextBoxColumn.Name = "conversionDolarDataGridViewTextBoxColumn";
            this.conversionDolarDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tipoCambioDataGridViewTextBoxColumn
            // 
            this.tipoCambioDataGridViewTextBoxColumn.DataPropertyName = "TipoCambio";
            this.tipoCambioDataGridViewTextBoxColumn.HeaderText = "TipoCambio";
            this.tipoCambioDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.tipoCambioDataGridViewTextBoxColumn.Name = "tipoCambioDataGridViewTextBoxColumn";
            this.tipoCambioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // percepcionDataGridViewTextBoxColumn
            // 
            this.percepcionDataGridViewTextBoxColumn.DataPropertyName = "Percepcion";
            this.percepcionDataGridViewTextBoxColumn.HeaderText = "Percepcion";
            this.percepcionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.percepcionDataGridViewTextBoxColumn.Name = "percepcionDataGridViewTextBoxColumn";
            this.percepcionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // destinoDataGridViewTextBoxColumn
            // 
            this.destinoDataGridViewTextBoxColumn.DataPropertyName = "Destino";
            this.destinoDataGridViewTextBoxColumn.HeaderText = "Destino";
            this.destinoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.destinoDataGridViewTextBoxColumn.Name = "destinoDataGridViewTextBoxColumn";
            this.destinoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // descripcionDestinoDataGridViewTextBoxColumn
            // 
            this.descripcionDestinoDataGridViewTextBoxColumn.DataPropertyName = "DescripcionDestino";
            this.descripcionDestinoDataGridViewTextBoxColumn.HeaderText = "DescripcionDestino";
            this.descripcionDestinoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.descripcionDestinoDataGridViewTextBoxColumn.Name = "descripcionDestinoDataGridViewTextBoxColumn";
            this.descripcionDestinoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cuentaDestinoDataGridViewTextBoxColumn
            // 
            this.cuentaDestinoDataGridViewTextBoxColumn.DataPropertyName = "CuentaDestino";
            this.cuentaDestinoDataGridViewTextBoxColumn.HeaderText = "CuentaDestino";
            this.cuentaDestinoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cuentaDestinoDataGridViewTextBoxColumn.Name = "cuentaDestinoDataGridViewTextBoxColumn";
            this.cuentaDestinoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pgoDataGridViewTextBoxColumn
            // 
            this.pgoDataGridViewTextBoxColumn.DataPropertyName = "Pgo";
            this.pgoDataGridViewTextBoxColumn.HeaderText = "Pgo";
            this.pgoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pgoDataGridViewTextBoxColumn.Name = "pgoDataGridViewTextBoxColumn";
            this.pgoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // constanciaNumeroDataGridViewTextBoxColumn
            // 
            this.constanciaNumeroDataGridViewTextBoxColumn.DataPropertyName = "ConstanciaNumero";
            this.constanciaNumeroDataGridViewTextBoxColumn.HeaderText = "ConstanciaNumero";
            this.constanciaNumeroDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.constanciaNumeroDataGridViewTextBoxColumn.Name = "constanciaNumeroDataGridViewTextBoxColumn";
            this.constanciaNumeroDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // constanciaFechaPagoDataGridViewTextBoxColumn
            // 
            this.constanciaFechaPagoDataGridViewTextBoxColumn.DataPropertyName = "ConstanciaFechaPago";
            this.constanciaFechaPagoDataGridViewTextBoxColumn.HeaderText = "ConstanciaFechaPago";
            this.constanciaFechaPagoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.constanciaFechaPagoDataGridViewTextBoxColumn.Name = "constanciaFechaPagoDataGridViewTextBoxColumn";
            this.constanciaFechaPagoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // constanciaMontoDataGridViewTextBoxColumn
            // 
            this.constanciaMontoDataGridViewTextBoxColumn.DataPropertyName = "ConstanciaMonto";
            this.constanciaMontoDataGridViewTextBoxColumn.HeaderText = "ConstanciaMonto";
            this.constanciaMontoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.constanciaMontoDataGridViewTextBoxColumn.Name = "constanciaMontoDataGridViewTextBoxColumn";
            this.constanciaMontoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // constanciaReferenciaDataGridViewTextBoxColumn
            // 
            this.constanciaReferenciaDataGridViewTextBoxColumn.DataPropertyName = "ConstanciaReferencia";
            this.constanciaReferenciaDataGridViewTextBoxColumn.HeaderText = "ConstanciaReferencia";
            this.constanciaReferenciaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.constanciaReferenciaDataGridViewTextBoxColumn.Name = "constanciaReferenciaDataGridViewTextBoxColumn";
            this.constanciaReferenciaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // bancarizacionFechaDataGridViewTextBoxColumn
            // 
            this.bancarizacionFechaDataGridViewTextBoxColumn.DataPropertyName = "BancarizacionFecha";
            this.bancarizacionFechaDataGridViewTextBoxColumn.HeaderText = "BancarizacionFecha";
            this.bancarizacionFechaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.bancarizacionFechaDataGridViewTextBoxColumn.Name = "bancarizacionFechaDataGridViewTextBoxColumn";
            this.bancarizacionFechaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // bancarizacionBcoDataGridViewTextBoxColumn
            // 
            this.bancarizacionBcoDataGridViewTextBoxColumn.DataPropertyName = "BancarizacionBco";
            this.bancarizacionBcoDataGridViewTextBoxColumn.HeaderText = "BancarizacionBco";
            this.bancarizacionBcoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.bancarizacionBcoDataGridViewTextBoxColumn.Name = "bancarizacionBcoDataGridViewTextBoxColumn";
            this.bancarizacionBcoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // bancarizacionOperacionDataGridViewTextBoxColumn
            // 
            this.bancarizacionOperacionDataGridViewTextBoxColumn.DataPropertyName = "BancarizacionOperacion";
            this.bancarizacionOperacionDataGridViewTextBoxColumn.HeaderText = "BancarizacionOperacion";
            this.bancarizacionOperacionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.bancarizacionOperacionDataGridViewTextBoxColumn.Name = "bancarizacionOperacionDataGridViewTextBoxColumn";
            this.bancarizacionOperacionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // referenciaFechaDataGridViewTextBoxColumn
            // 
            this.referenciaFechaDataGridViewTextBoxColumn.DataPropertyName = "ReferenciaFecha";
            this.referenciaFechaDataGridViewTextBoxColumn.HeaderText = "ReferenciaFecha";
            this.referenciaFechaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.referenciaFechaDataGridViewTextBoxColumn.Name = "referenciaFechaDataGridViewTextBoxColumn";
            this.referenciaFechaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // referenciaTipoDataGridViewTextBoxColumn
            // 
            this.referenciaTipoDataGridViewTextBoxColumn.DataPropertyName = "ReferenciaTipo";
            this.referenciaTipoDataGridViewTextBoxColumn.HeaderText = "ReferenciaTipo";
            this.referenciaTipoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.referenciaTipoDataGridViewTextBoxColumn.Name = "referenciaTipoDataGridViewTextBoxColumn";
            this.referenciaTipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // referenciaSerieDataGridViewTextBoxColumn
            // 
            this.referenciaSerieDataGridViewTextBoxColumn.DataPropertyName = "ReferenciaSerie";
            this.referenciaSerieDataGridViewTextBoxColumn.HeaderText = "ReferenciaSerie";
            this.referenciaSerieDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.referenciaSerieDataGridViewTextBoxColumn.Name = "referenciaSerieDataGridViewTextBoxColumn";
            this.referenciaSerieDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // referenciaNumeroDataGridViewTextBoxColumn
            // 
            this.referenciaNumeroDataGridViewTextBoxColumn.DataPropertyName = "ReferenciaNumero";
            this.referenciaNumeroDataGridViewTextBoxColumn.HeaderText = "ReferenciaNumero";
            this.referenciaNumeroDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.referenciaNumeroDataGridViewTextBoxColumn.Name = "referenciaNumeroDataGridViewTextBoxColumn";
            this.referenciaNumeroDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaRegistroDataGridViewTextBoxColumn
            // 
            this.fechaRegistroDataGridViewTextBoxColumn.DataPropertyName = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn.HeaderText = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fechaRegistroDataGridViewTextBoxColumn.Name = "fechaRegistroDataGridViewTextBoxColumn";
            this.fechaRegistroDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaModificacionDataGridViewTextBoxColumn
            // 
            this.fechaModificacionDataGridViewTextBoxColumn.DataPropertyName = "FechaModificacion";
            this.fechaModificacionDataGridViewTextBoxColumn.HeaderText = "FechaModificacion";
            this.fechaModificacionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fechaModificacionDataGridViewTextBoxColumn.Name = "fechaModificacionDataGridViewTextBoxColumn";
            this.fechaModificacionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // FrmProgramaLibrosElectronicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 695);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabRegistros);
            this.Name = "FrmProgramaLibrosElectronicos";
            this.Text = "Programa Libros Electronicos";
            this.Load += new System.EventHandler(this.FrmProgramaLibrosElectronicos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabRegistros.ResumeLayout(false);
            this.tabCompras.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCompras)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabVentas.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabControl tabRegistros;
        private System.Windows.Forms.TabPage tabCompras;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGuardarCompras;
        private System.Windows.Forms.Button btnEliminarCompras;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnGuardarVentas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnEliminarVentas;
        private System.Windows.Forms.Button btnGenerarTXT;
        private System.Windows.Forms.TextBox txtRutaTXT;
        private System.Windows.Forms.Button btnCargarCarpeta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreRuc;
        private System.Windows.Forms.TextBox txtNombreMes;
        private System.Windows.Forms.TextBox txtNombreAnio;
        private ADGV.AdvancedDataGridView dgvRegistroCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLibroComprasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEmisionDataGridViewTextBoxColumn;
        private DSCompras dSCompras;
        private System.Windows.Forms.BindingSource BSComprasBindingSource;
        private DSComprasTableAdapters.tblRegistroComprasTableAdapter TAComprasTableAdapter;
        private ADGV.AdvancedDataGridView dgvRegistroVentas;
        private DSVentas dSVentas;
        private System.Windows.Forms.BindingSource BSVentasBindingSource;
        private DSVentasTableAdapters.tblRegistroVentasTableAdapter TAVentasTableAdapter;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasNumeroRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasFechaPago;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCuentaDestinoDescripcion;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idLibroVentasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPagoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSerieDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNDocumentoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTipoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNumeroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNombreRazonSocialDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorExportacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseImponibleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeTotalExoneradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeTotalInafectaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGVDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeTotalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolaresDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn igvRetencionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaDestinoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaFechaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaTipoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaSerieDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaNumeroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn constanciaNumeroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn constanciaFechaPagoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn detraccionSolesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaModificacionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaDestinoDescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasID;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasNumeroRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasFechaPago;
        private System.Windows.Forms.DataGridViewComboBoxColumn comprasCdpTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCdpSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCdpNumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasProveedorTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasProveedorNumeroDocumento;
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
        private System.Windows.Forms.DataGridViewComboBoxColumn comprasCuentaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConstanciaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConstanciaFechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConstanciaMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConstanciaReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancarizacionFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancarizacionBco;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancarizacionOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasReferenciaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasReferenciaTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasReferenciaSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasReferenciaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSerieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNombreRazonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseImponibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noGravadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolaresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conversionDolarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCambioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percepcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDestinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaDestinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pgoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constanciaNumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constanciaFechaPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constanciaMontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constanciaReferenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bancarizacionFechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bancarizacionBcoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bancarizacionOperacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaFechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaSerieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaNumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaModificacionDataGridViewTextBoxColumn;
    }
}