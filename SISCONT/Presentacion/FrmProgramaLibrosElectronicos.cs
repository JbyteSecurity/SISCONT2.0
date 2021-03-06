﻿using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class FrmProgramaLibrosElectronicos : Form
    {
        private PlanContable planContable = new PlanContable();
        private Proveedor proveedor = new Proveedor();
        private ComprobantePago comprobantePago = new ComprobantePago();
        private TipoCambio tipoCambio = new TipoCambio();

        private readonly Compras compras = new Compras();
        private Ventas ventas = new Ventas();
        private Detraccion detraccion = new Detraccion();

        string TXTRoute = null;

        BindingSource bindingSourceCompras = new BindingSource();
        DataTable dataTableCompras = new DataTable();

        public string username;
        public FrmProgramaLibrosElectronicos()
        {
            InitializeComponent();
        }

        private void FrmProgramaLibrosElectronicos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDetracciones.sp_all_combo_detracciones' Puede moverla o quitarla según sea necesario.
            this.TADetraccionesTableAdapter.Fill(this.dSDetracciones.sp_all_combo_detracciones);
            FillDataGridViewCompras();
            FillDataGridViewVentas();

            FillComboTipoComprobante();
            FillComboCuentaDestino();

            //FillComboCodigo();

            removeColumnsCompras();
            removeColumnsVentas();

            //this.dgvRegistroCompras.DataSource = this.BSComprasBindingSource;

            txtNombreAnio.Text = DateTime.UtcNow.ToString("yyyy");
            txtNombreMes.Text = DateTime.UtcNow.ToString("MM");

            dgvRegistroCompras.RowHeadersVisible = false;
            dgvRegistroCompras.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgvRegistroCompras.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);

            dgvRegistroVentas.RowHeadersVisible = false;
            dgvRegistroVentas.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgvRegistroVentas.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
            lblPeriodoActual.Text = "Periodo Actual: " + DateTime.UtcNow.ToString("MMMM") + " " + DateTime.UtcNow.ToString("yyyy");
            //lblPeriodoActual.Text = username;
        }

        private void cellContentClickEvent(object sender, DataGridViewCellEventArgs e)
        {
            //mostrarProveedor();

        }

        private void tabIndexChangedEvent(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveCompras();
        }

        

        
        private void FillDataGridViewCompras(bool filter = false)
        {
            if (filter)
            {
                int filtroMes = Convert.ToInt32(txtNombreMes.Text);
                int filtroAnio = Convert.ToInt32(txtNombreAnio.Text);

                this.TAComprasTableAdapter.FillByYearAndMonth(this.dSCompras.tblRegistroCompras, filtroMes, filtroAnio);
                if (Convert.ToString(filtroMes) != DateTime.UtcNow.ToString("MM"))
                dgvRegistroCompras.ReadOnly = true;

                //bindingSourceCompras.DataSource = compras.AllByMonthFilter(filtroAnio, filtroMes).Tables["RegistroComprasFiltro"].DefaultView;
            }
            else
            {
                this.TAComprasTableAdapter.FillCurrentMonth(this.dSCompras.tblRegistroCompras);
                dgvRegistroCompras.ReadOnly = false;
            }
            #region FillData other option
            //bindingSourceCompras.DataSource = compras.AllCurrentMonth().Tables["RegistroCompras"].DefaultView;

            ////bindingSourceCompras.DataSource = dataTableCompras;

            //dgvRegistroCompras.AutoGenerateColumns = false;

            //this.comprasID.DataPropertyName = "comprasID";
            ////this.comprasMes.DataPropertyName = "comprasMes";
            //this.comprasNumeroRegistro.DataPropertyName = "comprasNumeroRegistro";
            //this.comprasFechaEmision.DataPropertyName = "comprasFechaEmision";
            //this.comprasFechaPago.DataPropertyName = "comprasFechaPago";
            //this.comprasCdpTipo.DataPropertyName = "comprasCdpTipo";
            //this.comprasCdpSerie.DataPropertyName = "comprasCdpSerie";
            //this.comprasCdpNumeroDocumento.DataPropertyName = "comprasCdpNumeroDocumento";
            //this.comprasProveedorTipo.DataPropertyName = "comprasProveedorTipo";
            //this.comprasProveedorNumeroDocumento.DataPropertyName = "comprasProveedorNumeroDocumento";
            ////this.comprasProveedorTipoDocumento.DataPropertyName = "comprasProveedorTipoDocumento";
            //this.comprasProveedorRazonSocial.DataPropertyName = "comprasProveedorRazonSocial";
            //this.comprasCuenta.DataPropertyName = "comprasCuenta";
            //this.comprasDescripcion.DataPropertyName = "comprasDescripcion";
            //this.comprasBaseImponible.DataPropertyName = "comprasBaseImponible";
            //this.comprasIgv.DataPropertyName = "comprasIgv";
            //this.comprasNoGravada.DataPropertyName = "comprasNoGravada";
            //this.comprasDescuento.DataPropertyName = "comprasDescuento";
            //this.comprasImporteTotal.DataPropertyName = "comprasImporteTotal";
            //this.comprasDolares.DataPropertyName = "comprasDolares";
            //this.comprasTipoCambio.DataPropertyName = "comprasTipoCambio";
            //this.comprasConversionDolares.DataPropertyName = "comprasConversionDolares";
            //this.comprasPercepcion.DataPropertyName = "comprasPercepcion";
            //this.comprasDestino.DataPropertyName = "comprasDestino";
            //this.comprasDescripcionDestino.DataPropertyName = "comprasDescripcionDestino";
            //this.comprasCuentaDestino.DataPropertyName = "comprasCuentaDestino";
            ////this.comprasPago.DataPropertyName = "comprasPago";
            //this.comprasCodigo.DataPropertyName = "comprasCodigo";
            //this.comprasConstanciaNumero.DataPropertyName = "comprasConstanciaNumero";
            //this.comprasConstanciaFechaPago.DataPropertyName = "comprasConstanciaFechaPago";
            //this.comprasConstanciaMonto.DataPropertyName = "comprasConstanciaMonto";
            //this.comprasConstanciaReferencia.DataPropertyName = "comprasConstanciaReferencia";
            //this.BancarizacionFecha.DataPropertyName = "BancarizacionFecha";
            //this.BancarizacionBco.DataPropertyName = "BancarizacionBco";
            //this.BancarizacionOperacion.DataPropertyName = "BancarizacionOperacion";
            //this.comprasReferenciaFecha.DataPropertyName = "comprasReferenciaFecha";
            //this.comprasReferenciaTipo.DataPropertyName = "comprasReferenciaTipo";
            //this.comprasReferenciaSerie.DataPropertyName = "comprasReferenciaSerie";
            //this.comprasReferenciaNumero.DataPropertyName = "comprasReferenciaNumero";

            //dgvRegistroCompras.DataSource = bindingSourceCompras;
            #endregion
        }
        private void FillDataGridViewVentas(bool filter = false)
        {
            DataTable dataTable = new DataTable();

            if (filter)
            {
                int filtroMes = Convert.ToInt32(txtNombreMes.Text);
                int filtroAnio = Convert.ToInt32(txtNombreAnio.Text);
                //dataTable = ventas.AllByMonthFilter(filtroAnio, filtroMes);
                this.TAVentasTableAdapter.FillByYearAndMonth(this.dSVentas.tblRegistroVentas, filtroMes, filtroAnio);
                dgvRegistroVentas.ReadOnly = true;
            }
            else
            {
                this.TAVentasTableAdapter.FillCurrentMonth(this.dSVentas.tblRegistroVentas);
                dgvRegistroVentas.ReadOnly = false;
            }
            #region Other option FIll Data
            //dataTable = ventas.allByMonth();

            //dgvRegistroVentas.AutoGenerateColumns = false;

            ////dgvRegistroVentas.ColumnCount = 3;

            //this.ventasID.DataPropertyName = "idLibroVentas";
            ////this.ventasMes.DataPropertyName = "Mes";
            //this.ventasNumeroRegistro.DataPropertyName = "NReg";
            //this.ventasFechaEmision.DataPropertyName = "FechaEmision";
            ////this.ventasFechapago.DataPropertyName = "FechaPago";
            //this.ventasCdpTipo.DataPropertyName = "CTipo";
            //this.ventasCdpSerie.DataPropertyName = "CSerie";
            //this.ventasCdpNumero.DataPropertyName = "CNDocumento";
            //this.ventasProveedorTipo.DataPropertyName = "PTipo";
            //this.ventasProveedorNumero.DataPropertyName = "PNumero";
            //this.ventasProveedorRazonSocial.DataPropertyName = "PNombreRazonSocial";
            //this.ventasCuenta.DataPropertyName = "Cuenta";
            //this.ventasDescripcion.DataPropertyName = "Descripcion";
            //this.ventasValorExportacion.DataPropertyName = "ValorExportacion";
            //this.ventasBaseImponible.DataPropertyName = "BaseImponible";
            //this.ventasImporteTotalExonerada.DataPropertyName = "ImporteTotalExonerada";
            //this.ventasImporteTotalInafecta.DataPropertyName = "ImporteTotalInafecta";
            //this.ventasIgv.DataPropertyName = "IGV";
            //this.ventasImporteTotal.DataPropertyName = "ImporteTotal";
            //this.ventasTipoCambio.DataPropertyName = "TC";
            //this.ventasDolares.DataPropertyName = "Dolares";
            //this.ventasIgvRetencion.DataPropertyName = "IgvRetencion";
            //this.ventasCuentaDestino.DataPropertyName = "CuentaDestino";
            ////this.ventasCuentaDestinoDescripcion.DataPropertyName = "CuentaDestinoDescripcion";
            ////this.ventasPago.DataPropertyName = "Pago";
            //this.ventasReferenciaFecha.DataPropertyName = "ReferenciaFecha";
            //this.ventasReferenciaTipo.DataPropertyName = "ReferenciaTipo";
            //this.ventasReferenciaSerie.DataPropertyName = "ReferenciaSerie";
            //this.ventasReferenciaNumero.DataPropertyName = "ReferenciaNumeroDocumento";
            //this.ventasCodigo.DataPropertyName = "Codigo";
            //this.ventasConstanciaNumero.DataPropertyName = "ConstanciaNumero";
            //this.ventasConstanciaFechaPago.DataPropertyName = "ConstanciaFechaPago";
            //this.ventasDetraccionSoles.DataPropertyName = "DetraccionSoles";
            //this.ventasReferencia.DataPropertyName = "Referencia";
            //this.ventasObservacion.DataPropertyName = "Observacion";

            //dgvRegistroVentas.DataSource = dataTable;
            #endregion
        }

        //GUARDAR Compras 
        private void SaveCompras()
        {
            try
            {
                foreach (DataGridViewRow row in dgvRegistroCompras.Rows)
                {
                    if (row.Cells["comprasFechaEmision"].Value != null)
                    {
                        int id = row.Cells["comprasID"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["comprasID"].Value) : 0;
                        //int comprasMes = row.Cells["comprasMes"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["comprasMes"].Value) : 0;

                        string comprasNumeroRegistro = row.Cells["comprasNumeroRegistro"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasNumeroRegistro"].Value) : "";
                        string comprasFechaEmision = row.Cells["comprasFechaEmision"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasFechaEmision"].Value) : "";
                        string comprasFechaPago = row.Cells["comprasFechaPago"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasFechaPago"].Value) : "1900-01-01";
                        string comprasCdpTipo = row.Cells["comprasCdpTipo"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasCdpTipo"].Value) : "";
                        string comprasCdpSerie = row.Cells["comprasCdpSerie"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasCdpSerie"].Value).ToUpper() : "";
                        string comprasCdpNumeroDocumento = row.Cells["comprasCdpNumeroDocumento"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasCdpNumeroDocumento"].Value) : "";
                        string comprasProveedorTipo = row.Cells["comprasProveedorTipo"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasProveedorTipo"].Value) : "";
                        string comprasProveedorNumeroDocumento = row.Cells["comprasProveedorNumeroDocumento"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasProveedorNumeroDocumento"].Value) : "";
                        //string comprasProveedorTipoDocumento = row.Cells["comprasProveedorTipoDocumento"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasProveedorTipoDocumento"].Value) : "";

                        string comprasProveedorRazonSocial = row.Cells["comprasProveedorRazonSocial"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasProveedorRazonSocial"].Value) : "";
                        string comprasCuenta = row.Cells["comprasCuenta"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasCuenta"].Value) : "";
                        string comprasDescripcion = row.Cells["comprasDescripcion"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasDescripcion"].Value) : "";
                        double comprasBaseImponible = row.Cells["comprasBaseImponible"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["comprasBaseImponible"].Value) : 0;
                        double comprasIgv = row.Cells["comprasIgv"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["comprasIgv"].Value) : 0;
                        double comprasNoGravada = row.Cells["comprasNoGravada"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["comprasNoGravada"].Value) : 0;
                        double comprasDescuento = row.Cells["comprasDescuento"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["comprasDescuento"].Value) : 0;
                        double comprasImporteTotal = row.Cells["comprasImporteTotal"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["comprasImporteTotal"].Value) : 0;
                        double comprasDolares = row.Cells["comprasDolares"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["comprasDolares"].Value) : 0;
                        double comprasTipoCambio = row.Cells["comprasTipoCambio"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["comprasTipoCambio"].Value) : 0;

                        double comprasPercepcion = row.Cells["comprasPercepcion"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["comprasPercepcion"].Value) : 0;
                        string comprasDestino = row.Cells["comprasDestino"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasDestino"].Value) : "";
                        string comprasDescripcionDestino = row.Cells["comprasDescripcionDestino"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasDescripcionDestino"].Value) : "";
                        string comprasCuentaDestino = row.Cells["comprasCuentaDestino"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasCuentaDestino"].Value) : "";
                        //string comprasPago = row.Cells["comprasPago"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasPago"].Value) : "";
                        string comprasCodigo = row.Cells["comprasCodigo"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasCodigo"].Value) : "";
                        string comprasConstanciaNumero = row.Cells["comprasConstanciaNumero"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasConstanciaNumero"].Value) : "";
                        string comprasConstanciaFechaPago = row.Cells["comprasConstanciaFechaPago"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasConstanciaFechaPago"].Value) : "1900-01-01";
                        double comprasConstanciaMonto = row.Cells["comprasConstanciaMonto"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["comprasConstanciaMonto"].Value) : 0;
                        string comprasConstanciaReferencia = row.Cells["comprasConstanciaReferencia"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasConstanciaReferencia"].Value) : "";

                        string BancarizacionFecha = row.Cells["BancarizacionFecha"].Value != DBNull.Value ? Convert.ToString(row.Cells["BancarizacionFecha"].Value) : "1900-01-01";
                        string BancarizacionBco = row.Cells["BancarizacionBco"].Value != DBNull.Value ? Convert.ToString(row.Cells["BancarizacionBco"].Value) : "";
                        int BancarizacionOperacion = row.Cells["BancarizacionOperacion"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["BancarizacionOperacion"].Value) : 0;
                        double comprasConversionDolares = row.Cells["comprasConversionDolares"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["comprasConversionDolares"].Value) : 0;

                        string ReferenciaFecha = row.Cells["comprasConstanciaFechaPago"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasReferenciaFecha"].Value) : "";
                        string ReferenciaTipo = row.Cells["comprasReferenciaTipo"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasReferenciaTipo"].Value) : "";
                        string ReferenciaSerie = row.Cells["comprasReferenciaSerie"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasReferenciaSerie"].Value) : "";
                        string ReferenciaNumero = row.Cells["comprasReferenciaNumero"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasReferenciaNumero"].Value) : "";
                        string comprasObservacion = row.Cells["comprasObservacion"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasObservacion"].Value) : "";


                        string Usuario = username;

                        if (id < 0)
                        {
                            compras.Insert(
                                /*comprasMes, */comprasNumeroRegistro, comprasFechaEmision, comprasFechaPago, comprasCdpTipo,
                                comprasCdpSerie, comprasCdpNumeroDocumento, comprasProveedorTipo, comprasProveedorNumeroDocumento,
                                /*comprasProveedorTipoDocumento,*/ comprasProveedorRazonSocial, comprasCuenta, comprasDescripcion,
                                comprasBaseImponible, comprasIgv, comprasNoGravada, comprasDescuento, comprasImporteTotal, comprasDolares,
                                comprasTipoCambio, comprasPercepcion, comprasDestino, comprasDescripcionDestino, comprasCuentaDestino, /*comprasPago,*/
                                comprasCodigo, comprasConstanciaNumero, comprasConstanciaFechaPago, comprasConstanciaMonto, comprasConstanciaReferencia,
                                BancarizacionFecha, BancarizacionBco, BancarizacionOperacion, ReferenciaFecha, ReferenciaTipo, ReferenciaSerie, ReferenciaNumero,
                                Usuario, comprasConversionDolares, comprasObservacion
                            );
                        }
                        else
                        {
                            compras.Update(
                                id, /*comprasMes,*/ comprasNumeroRegistro, comprasFechaEmision, comprasFechaPago, comprasCdpTipo,
                                comprasCdpSerie, comprasCdpNumeroDocumento, comprasProveedorTipo, comprasProveedorNumeroDocumento,
                               /* comprasProveedorTipoDocumento, */comprasProveedorRazonSocial, comprasCuenta, comprasDescripcion,
                                comprasBaseImponible, comprasIgv, comprasNoGravada, comprasDescuento, comprasImporteTotal, comprasDolares,
                                comprasTipoCambio, comprasPercepcion, comprasDestino, comprasDescripcionDestino, comprasCuentaDestino, /*comprasPago,*/
                                comprasCodigo, comprasConstanciaNumero, comprasConstanciaFechaPago, comprasConstanciaMonto, comprasConstanciaReferencia,
                                BancarizacionFecha, BancarizacionBco, BancarizacionOperacion, ReferenciaFecha, ReferenciaTipo, ReferenciaSerie, ReferenciaNumero, Usuario,
                                comprasConversionDolares, comprasObservacion
                                );
                        }
                    }
                }
                MessageBox.Show("Se han guardado los cambios correctamente", "Compras .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataGridViewCompras();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Ventas .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //GUARDAR Ventas 
        private void SaveVentas()
        {
            try
            {
                foreach (DataGridViewRow row in dgvRegistroVentas.Rows)
                {
                    if (row.Cells["VentasFechaEmision"].Value != DBNull.Value)
                    {
                        int ventasId = Convert.ToInt32(row.Cells["ventasId"].Value);
                        string ventasNumeroRegistro = row.Cells["ventasNumeroRegistro"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasNumeroRegistro"].Value) : "";
                        string ventasFechaEmision = row.Cells["ventasFechaEmision"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasFechaEmision"].Value) : "";
                        string ventasFechaPago = row.Cells["ventasFechaPago"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasFechaPago"].Value) : "";
                        string ventasCdpTipo = row.Cells["ventasCdpTipo"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasCdpTipo"].Value) : "";
                        string ventasCdpSerie = row.Cells["ventasCdpSerie"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasCdpSerie"].Value).ToUpper() : "";
                        string ventasCdpNumero = row.Cells["ventasCdpNumero"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasCdpNumero"].Value) : "";
                        string ventasProveedorTipo = row.Cells["ventasProveedorTipo"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasProveedorTipo"].Value) : "";
                        string ventasProveedorNumero = row.Cells["ventasProveedorNumero"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasProveedorNumero"].Value).ToUpper() : "";
                        string ventasProveedorRazonSocial = row.Cells["ventasProveedorRazonSocial"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasProveedorRazonSocial"].Value) : "";

                        string ventasCuenta = row.Cells["ventasCuenta"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasCuenta"].Value) : "";
                        string ventasDescripcion = row.Cells["ventasDescripcion"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasDescripcion"].Value) : "";
                        double ventasValorExportacion = row.Cells["ventasValorExportacion"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["ventasValorExportacion"].Value) : 0;
                        double ventasBaseImponible = row.Cells["ventasBaseImponible"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["ventasBaseImponible"].Value) : 0;
                        double ventasImporteTotalExonerada = row.Cells["ventasImporteTotalExonerada"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["ventasImporteTotalExonerada"].Value) : 0;
                        double ventasImporteTotalInafecta = row.Cells["ventasImporteTotalInafecta"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["ventasImporteTotalInafecta"].Value) : 0;
                        double ventasIgv = row.Cells["ventasIgv"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["ventasIgv"].Value) : 0;
                        double ventasImporteTotal = row.Cells["ventasImporteTotal"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["ventasImporteTotal"].Value) : 0;
                        double ventasTipoCambio = row.Cells["ventasTipoCambio"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["ventasTipoCambio"].Value) : 0;
                        double ventasDolares = row.Cells["ventasDolares"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["ventasDolares"].Value) : 0;
                        //double ventasDolaresConversion = row.Cells["ventasDolaresConversion"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["ventasDolaresConversion"].Value) : 0;

                        double ventasIgvRetencion = row.Cells["ventasIgvRetencion"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["ventasIgvRetencion"].Value) : 0;
                        string ventasCuentaDestino = row.Cells["ventasCuentaDestino"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasCuentaDestino"].Value) : "";
                        string ventasCuentaDestinoDescripcion = row.Cells["ventasCuentaDestinoDescripcion"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasCuentaDestinoDescripcion"].Value) : "";
                        string ventasReferenciaFecha = row.Cells["ventasReferenciaFecha"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasReferenciaFecha"].Value) : "";
                        string ventasReferenciaTipo = row.Cells["ventasReferenciaTipo"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasReferenciaTipo"].Value) : "";
                        string ventasReferenciaSerie = row.Cells["ventasReferenciaSerie"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasReferenciaSerie"].Value) : "";
                        string ventasReferenciaNumero = row.Cells["ventasReferenciaNumero"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasReferenciaNumero"].Value) : "";
                        string ventasCodigo = row.Cells["ventasCodigo"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasCodigo"].Value) : "";
                        string ventasConstanciaNumero = row.Cells["ventasConstanciaNumero"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasConstanciaNumero"].Value) : "";
                        string ventasConstanciaFechaPago = row.Cells["ventasConstanciaFechaPago"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasConstanciaFechaPago"].Value) : "";

                        double ventasDetraccionSoles = row.Cells["ventasDetraccionSoles"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["ventasDetraccionSoles"].Value) : 0;
                        string ventasReferencia = row.Cells["ventasReferencia"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasReferencia"].Value) : "";
                        string ventasObservacion = row.Cells["ventasObservacion"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasObservacion"].Value) : "";
                        string ventasUSuario = username;

                        if (ventasId < 0)
                        {
                            ventas.Insert(
                                ventasNumeroRegistro, ventasFechaEmision, ventasFechaPago, ventasCdpTipo, ventasCdpSerie, ventasCdpNumero, ventasProveedorTipo,
                                ventasProveedorNumero, ventasProveedorRazonSocial, ventasCuenta, ventasDescripcion, ventasValorExportacion, ventasBaseImponible,
                                ventasImporteTotalExonerada, ventasImporteTotalInafecta, ventasIgv, ventasImporteTotal, ventasTipoCambio, ventasDolares,
                                ventasIgvRetencion, ventasCuentaDestino, ventasCuentaDestinoDescripcion, ventasReferenciaFecha, ventasReferenciaTipo, ventasReferenciaSerie,
                                ventasReferenciaNumero, ventasCodigo, ventasConstanciaNumero, ventasConstanciaFechaPago, ventasDetraccionSoles, ventasReferencia,
                                ventasObservacion, ventasUSuario
                                );
                        } else
                        {
                            ventas.Update(
                                ventasId, ventasNumeroRegistro, ventasFechaEmision, ventasFechaPago, ventasCdpTipo, ventasCdpSerie, ventasCdpNumero, ventasProveedorTipo,
                                ventasProveedorNumero, ventasProveedorRazonSocial, ventasCuenta, ventasDescripcion, ventasValorExportacion, ventasBaseImponible,
                                ventasImporteTotalExonerada, ventasImporteTotalInafecta, ventasIgv, ventasImporteTotal, ventasTipoCambio, ventasDolares,
                                ventasIgvRetencion, ventasCuentaDestino, ventasCuentaDestinoDescripcion, ventasReferenciaFecha, ventasReferenciaTipo, ventasReferenciaSerie,
                                ventasReferenciaNumero, ventasCodigo, ventasConstanciaNumero, ventasConstanciaFechaPago, ventasDetraccionSoles, ventasReferencia,
                                ventasObservacion, ventasUSuario
                                );
                        }

                    }
                }
                MessageBox.Show("Se han guardado los cambios", "Ventas .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataGridViewVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar los datos por: " + ex);
            }
        }

        private void FillComboTipoComprobante()
        {
            //Compras
            comprasCdpTipo.DisplayMember = "Detail";
            comprasCdpTipo.ValueMember = "numero";
            comprasCdpTipo.DataSource = comprobantePago.GetAllCpdTypes();

            //Ventas
            ventasCdpTipo.DisplayMember = "Detail";
            ventasCdpTipo.ValueMember = "numero";
            ventasCdpTipo.DataSource = comprobantePago.GetAllCpdTypes();
        }

        private void FillComboCuentaDestino()
        {
            comprasCuentaDestino.DisplayMember = "Detail";
            comprasCuentaDestino.ValueMember = "Codigo";
            comprasCuentaDestino.DataSource = planContable.ShowAcountFilter("dest");

        }

        private void FillComboCodigo()
        {
            comprasCodigo.DisplayMember = "Combo";
            comprasCodigo.ValueMember = "codigo";
            comprasCodigo.DataSource = detraccion.GetForCombo();

            ventasCodigo.DisplayMember = "Combo";
            ventasCodigo.ValueMember = "codigo";
            ventasCodigo.DataSource = detraccion.GetForCombo();
        }


        private void btnGuardarVentas_Click(object sender, EventArgs e)
        {
            SaveVentas();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            //
        }

        public static Boolean isDate(String fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void dgvRegistroCompras_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvRegistroCompras.EditingControlShowing += dgvRegistroCompras_EditingControlShowing;
            switch (e.ColumnIndex)
            {
                case 2:
                    if (dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasFechaEmision"].Value != DBNull.Value)
                    {
                        if (!String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasFechaEmision"].Value.ToString() as String))
                        {
                            string fecha = null, compra = null, venta = null;
                            DataTable dataTableTipoCambio = new DataTable();

                            if (isDate(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasFechaEmision"].Value.ToString()))
                            {
                                fecha = dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasFechaEmision"].Value.ToString();

                                if (DateTime.Parse(fecha) <= DateTime.Parse(DateTime.UtcNow.ToString("dd/MM/yyyy")))
                                {
                                    dataTableTipoCambio = tipoCambio.Show(fecha);
                                    if (dataTableTipoCambio.Rows.Count > 0)
                                    {
                                        compra = dataTableTipoCambio.Rows[0]["Compra"].ToString();
                                        venta = dataTableTipoCambio.Rows[0]["Venta"].ToString();

                                        dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasTipoCambio"].Value = venta;
                                        dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasFechaPago"].Value = fecha;
                                    }
                                    else
                                        MessageBox.Show("No se encontro un tipo de cambio para la fecha: " + fecha, "Tipo de Cambio .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No se aceptan Fechas Futuras");
                                    dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasFechaPago"].Value = "";
                                    dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasFechaEmision"].Value = "";
                                    dgvRegistroCompras.CurrentCell = dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasFechaEmision"];
                                }
                            }
                            else
                                MessageBox.Show("(" + dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasFechaEmision"].Value.ToString() + ") No es una fecha valida \nIngrese una fecha válida con los siguientes formatos: \ndd/mm/yyyy o yyyy-mm-dd");
                        }
                    }
                    break;

                case 4:
                    if (dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasCdpTipo"].Value != DBNull.Value)
                    {
                        if (String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasCdpTipo"].Value.ToString() as String))
                        {
                            string comprasCDPTipo = dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasCdpTipo"].Value.ToString();
                            if (comprasCDPTipo.Equals("07"))
                                dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasCdpTipo"].Value = Convert.ToDouble(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasCdpTipo"].Value) * (-1);
                        }
                    }
                    break;
                case 8:
                    if (dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasProveedorNumeroDocumento"].Value != DBNull.Value)
                    {
                        if (!String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasProveedorNumeroDocumento"].Value.ToString() as string))
                        {
                            string ruc;
                            string razonSocial;
                            ruc = dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasProveedorNumeroDocumento"].Value.ToString();
                            razonSocial = proveedor.GetSupplierName(ruc);
                            if (razonSocial == null)
                            {
                                dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasProveedorNumeroDocumento"].Value = "";
                                MessageBox.Show("No se encontro al proveedor con ruc: " + ruc, "Compras .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasProveedorRazonSocial"].Value = razonSocial;
                        }
                    }
                    break;
                case 12:
                case 14:
                case 15:
                    //Calculos de No BaseInmponible
                    if (dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasBaseImponible"].Value != DBNull.Value)
                    {
                        double baseImponible = 0, descuento = 0, igv = 0, noGravada = 0, negativo = 1, importe_total;
                        string comprasCDPTipo = dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasCdpTipo"].Value.ToString();

                        if (comprasCDPTipo.Equals("07")) negativo = (-1);

                        if (!String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasBaseImponible"].Value.ToString() as String))
                            baseImponible = Convert.ToDouble(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasBaseImponible"].Value.ToString());

                        if (!String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasDescuento"].Value.ToString() as String))
                            descuento = Convert.ToDouble(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasDescuento"].Value.ToString());
                        
                        if (!String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasNoGravada"].Value.ToString() as String))
                            noGravada = Convert.ToDouble(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasNoGravada"].Value.ToString());

                        igv = Math.Round(((baseImponible + descuento) * 0.18) * negativo, 2);


                        importe_total = Math.Round((baseImponible + descuento + igv + noGravada) * negativo, 2);

                        dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasIgv"].Value = igv;
                        dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasImporteTotal"].Value = importe_total;
                        dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasBaseImponible"].Value = baseImponible * negativo;
                        //importe_total = Convert.ToDouble(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasImporteTotal"].Value.ToString());

                        if (importe_total >= 3500)
                        {
                            if (String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["BancarizacionFecha"].Value as String) || String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["BancarizacionBco"].Value as String) || String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["BancarizacionOperacion"].Value as String))
                            {
                                //MessageBox.Show("Ingrese Bancarización");
                                //dgvRegistroCompras.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Teal;
                                dgvRegistroCompras.Rows[e.RowIndex].Cells["BancarizacionFecha"].Style.BackColor = Color.Red;
                                dgvRegistroCompras.Rows[e.RowIndex].Cells["BancarizacionBco"].Style.BackColor = Color.Red;
                                dgvRegistroCompras.Rows[e.RowIndex].Cells["BancarizacionOperacion"].Style.BackColor = Color.Red;
                            }
                            else
                            {
                                //dgvRegistroCompras.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                                dgvRegistroCompras.Rows[e.RowIndex].Cells["BancarizacionFecha"].Style.BackColor = Color.White;
                                dgvRegistroCompras.Rows[e.RowIndex].Cells["BancarizacionBco"].Style.BackColor = Color.White;
                                dgvRegistroCompras.Rows[e.RowIndex].Cells["BancarizacionOperacion"].Style.BackColor = Color.White;
                            }

                        }
                    }
                    break;
                case 17: // Dolares

                    if (dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasDolares"].Value != DBNull.Value && Convert.ToDouble(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasDolares"].Value) != 0)
                    {
                        
                        double tipoCambi = 0, dolares = 0, descuento = 0, igv = 0, noGravada = 0, negativo = 1;
                        string comprasCDPTipo = dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasCdpTipo"].Value.ToString();
                        if (comprasCDPTipo.Equals("07")) negativo = (-1);

                        if (!String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasDolares"].Value.ToString() as String))
                            dolares = Convert.ToDouble(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasDolares"].Value.ToString());

                        if (!String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasTipoCambio"].Value.ToString() as String))
                            tipoCambi = Convert.ToDouble(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasTipoCambio"].Value.ToString());

                        dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasConversionDolares"].Value = Math.Round((dolares * tipoCambi), 2);

                        //Calcular en soles
                        double convertDolares = Math.Round((dolares * tipoCambi), 2);
                        descuento = 0;
                        noGravada = 0;
                        igv = 0;

                        double doBaseImponible = convertDolares / 1.18;
                        igv = doBaseImponible * 0.18;

                        dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasBaseImponible"].Value = Math.Round(doBaseImponible * negativo, 2);

                        dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasIgv"].Value = Math.Round(igv * negativo, 2);

                        dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasImporteTotal"].Value = Math.Round((doBaseImponible + descuento + igv + noGravada) * negativo, 2);
                    }
                    break;
                case 10:
                case 21:
                    if (dgvRegistroCompras.Rows[e.RowIndex].Cells[e.RowIndex].Value != DBNull.Value)
                    {
                        if (!String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                        {
                            string codigo = dgvRegistroCompras.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                            string cuenta = planContable.GetAcount(codigo);
                            if (cuenta == null)
                                MessageBox.Show("No se encontro una cuenta con código: " + codigo, "Compras .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                dgvRegistroCompras.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = cuenta;
                        }
                    }
                    break;
                case 24: // Codigo


                    if (dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasCodigo"].Value != DBNull.Value)
                    {
                        if (!String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasCodigo"].Value.ToString() as String))
                        {
                            double comprasImporteTotal = 0;
                            int compraCodigo = 0;
                            string codComp = null;

                            if (String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasImporteTotal"].Value.ToString() as String))
                                MessageBox.Show("Ingrese un Importe Total");
                            else comprasImporteTotal = Convert.ToDouble(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasImporteTotal"].Value.ToString());


                            codComp = string.Join(" ", dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasCodigo"].Value.ToString().Split(' ').Skip(0).Take(1).ToArray());

                            compraCodigo = Convert.ToInt32(codComp);

                            DataTable dataTableDetraccion = new DataTable();
                            dataTableDetraccion = detraccion.Show(compraCodigo);
                            if (dataTableDetraccion.Rows.Count > 0)
                            {
                                double detraccionProcentaje = Convert.ToDouble(dataTableDetraccion.Rows[0]["porcentaje"].ToString());
                                double detraccionMonto = Convert.ToDouble(dataTableDetraccion.Rows[0]["monto"].ToString());
                                if (comprasImporteTotal > detraccionMonto)
                                    dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasConstanciaReferencia"].Value = Math.Round(comprasImporteTotal * detraccionProcentaje, 2);
                                else
                                    dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasConstanciaReferencia"].Value = "";
                            }
                            else
                            {
                                //MessageBox.Show("Ingrese un número entero (1 - 5)");
                                dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasConstanciaReferencia"].Value = "";
                            }
                        }
                    }
                    break;
            }
        }

        private void dgvRegistroVentas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 2:
                    try
                    {
                        if (dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasFechaEmision"].Value != DBNull.Value)
                        {
                            if (!String.IsNullOrEmpty(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasFechaEmision"].Value.ToString() as String))
                            {

                                string fecha = null, compra = null, venta = null;
                                DataTable dataTableTipoCambio = new DataTable();

                                if (isDate(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasFechaEmision"].Value.ToString()))
                                {
                                    fecha = dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasFechaEmision"].Value.ToString().Substring(0, 10);

                                    if (DateTime.Parse(fecha) <= DateTime.Parse(DateTime.UtcNow.ToString("dd/MM/yyyy")))
                                    {

                                        dataTableTipoCambio = tipoCambio.Show(fecha);
                                        if (dataTableTipoCambio.Rows.Count > 0)
                                        {
                                            compra = dataTableTipoCambio.Rows[0]["Compra"].ToString();
                                            venta = dataTableTipoCambio.Rows[0]["Venta"].ToString();

                                            dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasFechaPago"].Value = fecha;
                                            dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasTipoCambio"].Value = venta;
                                        }
                                        else MessageBox.Show("No se encontro un tipo de cambio para la fecha: " + fecha, "Tipo de Cambio .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se aceptan Fechas Futuras");
                                        dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasFechaPago"].Value = "";
                                        dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasFechaEmision"].Value = "";
                                        dgvRegistroVentas.CurrentCell = dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasFechaEmision"];
                                    }
                                }
                                else MessageBox.Show("(" + dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasFechaEmision"].Value.ToString() + ") No es una fecha valida \nIngrese una fecha válida con los siguientes formatos: \ndd/mm/yyyy o yyyy-mm-dd");
                            }
                        }
                    } catch (Exception err)
                    {
                        //MessageBox.Show("Error fe: " + err);
                    }
                    break;
                case 8:
                    if (dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != DBNull.Value)
                    {
                        if (!String.IsNullOrEmpty(dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() as String))
                        {
                            string ruc;
                            string razonSocial;
                            ruc = dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                            razonSocial = proveedor.GetSupplierName(ruc);

                            if (razonSocial == null)
                                MessageBox.Show("No se encontro al proveedor con ruc: " + ruc, "Compras .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = razonSocial;
                        }
                    }
                    break;
                case 17: // BaseImponible
                    if (dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value != DBNull.Value)
                    {
                        double biImporteTotal = 0, negativo = 1;
                        string ventasTipoCDP = dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasCdpTipo"].Value.ToString();
                        if (ventasTipoCDP.Equals("07")) negativo = (-1);

                        if (String.IsNullOrEmpty(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value.ToString()))
                            MessageBox.Show("Ingrese un Importe Total");
                        else
                            biImporteTotal = Convert.ToDouble(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value.ToString());

                        dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasBaseImponible"].Value = Math.Round((biImporteTotal / 1.18) * negativo, 2);


                        double igvImporteTotal = 0, igvBaseImponible = 0;
                        if (String.IsNullOrEmpty(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value.ToString()))
                            MessageBox.Show("Ingrese un Importe Total");
                        else
                            igvImporteTotal = Convert.ToDouble(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value.ToString());

                        if (String.IsNullOrEmpty(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasBaseImponible"].Value.ToString()))
                            MessageBox.Show("Ingrese una Base Imponible");
                        else
                            igvBaseImponible = Convert.ToDouble(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasBaseImponible"].Value.ToString());

                        dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasIgv"].Value = Math.Round((igvImporteTotal - igvBaseImponible) * negativo, 2);
                        dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value = igvImporteTotal * negativo;
                    }
                    break;
                case 10:
                case 21:
                    if (dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != DBNull.Value)
                    {
                        if (!String.IsNullOrEmpty(dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() as String))
                        {
                            string codigo;
                            string cuenta;
                            codigo = dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                            cuenta = planContable.GetAcount(codigo);
                            if (cuenta == null)
                                MessageBox.Show("No se encontro una cuenta con código: " + codigo, "Compras .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = cuenta;
                        }
                    }
                    break;
                case 19: // Dolares
                    if (dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasDolares"].Value != DBNull.Value)
                    {
                        if (!String.IsNullOrEmpty(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasDolares"].Value.ToString() as String))
                        {
                            double dolares, tipoCambio = 0, impTotal, igv, baseImponible, negativo = 1;
                            string ventasTipoCDP = dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasCdpTipo"].Value.ToString();
                            if (ventasTipoCDP.Equals("07")) negativo = (-1); 
                            
                            dolares = Convert.ToDouble(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasDolares"].Value.ToString());

                            if (dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasTipoCambio"].Value != DBNull.Value && !String.IsNullOrEmpty(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasTipoCambio"].Value.ToString() as String))
                                tipoCambio = Convert.ToDouble(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasTipoCambio"].Value.ToString());

                            impTotal = Math.Round(tipoCambio * dolares, 2);
                            baseImponible = Math.Round((impTotal / 1.18) * negativo, 2);
                            igv = Math.Round((impTotal - baseImponible) * negativo, 2);

                            dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value = impTotal;
                            dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasBaseImponible"].Value = baseImponible;
                            dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasIGV"].Value = igv;
                        }
                    }

                    if (dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value != DBNull.Value)
                    {
                        double biImporteTotal = 0, negativo = 1;
                        string ventasTipoCDP = dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasCdpTipo"].Value.ToString();
                        if (ventasTipoCDP.Equals("07")) negativo = (-1);

                        if (String.IsNullOrEmpty(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value.ToString()))
                            MessageBox.Show("Ingrese un Importe Total");
                        else
                            biImporteTotal = Convert.ToDouble(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value.ToString());

                        dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasBaseImponible"].Value = Math.Round((biImporteTotal / 1.18) * negativo, 2);


                        double igvImporteTotal = 0, igvBaseImponible = 0;
                        if (String.IsNullOrEmpty(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value.ToString()))
                            MessageBox.Show("Ingrese un Importe Total");
                        else
                            igvImporteTotal = Convert.ToDouble(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value.ToString());

                        if (String.IsNullOrEmpty(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasBaseImponible"].Value.ToString()))
                            MessageBox.Show("Ingrese una Base Imponible");
                        else
                            igvBaseImponible = Convert.ToDouble(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasBaseImponible"].Value.ToString());

                        dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasIgv"].Value = Math.Round((igvImporteTotal - igvBaseImponible) * negativo, 2);
                        dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value = igvImporteTotal * negativo;
                    }
                    break;
                case 27:
                    if (dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value != DBNull.Value)
                    {
                        if (!String.IsNullOrEmpty(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasCodigo"].Value.ToString() as String))
                        {
                            double ventasImporteTotal = 0;
                            int ventasCodigo = 0;
                            string ventCod;

                            ventCod = string.Join(" ", dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasCodigo"].Value.ToString().Split(' ').Skip(0).Take(1).ToArray());

                            ventasCodigo = Convert.ToInt32(ventCod);

                            if (String.IsNullOrEmpty(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value.ToString() as String))
                                MessageBox.Show("Ingrese un Importe Total");
                            else
                                ventasImporteTotal = Convert.ToDouble(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value.ToString());


                            DataTable dataTableDetraccion = new DataTable();
                            dataTableDetraccion = detraccion.Show(ventasCodigo);
                            if (dataTableDetraccion.Rows.Count > 0)
                            {
                                double detraccionProcentaje = Convert.ToDouble(dataTableDetraccion.Rows[0]["porcentaje"].ToString());
                                double detraccionMonto = Convert.ToDouble(dataTableDetraccion.Rows[0]["monto"].ToString());

                                if (ventasImporteTotal > detraccionMonto)
                                    dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasReferencia"].Value = Math.Round(ventasImporteTotal * detraccionProcentaje, 2);
                                else
                                    dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasReferencia"].Value = "";
                            }
                            else
                                MessageBox.Show("Ingrese un número entero (1 - 5)");
                        }
                    }
                    break;
            }
        }


        private void btnEliminarCompras_Click(object sender, EventArgs e)
        {
            Destroy();
        }

        private void Destroy()
        {
            int id = Convert.ToInt32(dgvRegistroCompras.CurrentRow.Cells["comprasID"].Value);
            DialogResult DialogResultDestroy = MessageBox.Show("¿Realmente quieres eliminar está compra?", "Compras .::. Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResultDestroy == DialogResult.Yes)
            {
                if (compras.Destroy(id))
                {
                    FillDataGridViewCompras();
                }
                else
                    MessageBox.Show("Compra NO Eliminada", "Compras .::. Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnEliminarVentas_Click(object sender, EventArgs e)
        {
            DestroyVentas();
        }

        private void dgvCompras_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["comprasID"].Value = GenerateID();
            e.Row.DefaultCellStyle.Font = new Font(dgvRegistroCompras.Font, FontStyle.Italic);

            e.Row.Cells["comprasFechaEmision"].Value = DateTime.UtcNow.ToString("dd/MM/yyyy");

            e.Row.Cells["comprasProveedorTipo"].Value = "06";
        }
        private void dgvRegistroVentas_DefaultValueNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["ventasId"].Value = GenerateID();
            e.Row.DefaultCellStyle.Font = new Font(dgvRegistroVentas.Font, FontStyle.Italic);

            e.Row.Cells["ventasFechaEmision"].Value = DateTime.UtcNow.ToString("dd/MM/yyyy");
            e.Row.Cells["ventasProveedorTipo"].Value = "06";
        }
        

        private int GenerateID()
        {
            Random random = new Random();
            int numero = random.Next(-1000, -1);
            return numero;
        }

        private void DestroyVentas()
        {
            int id = Convert.ToInt32(dgvRegistroVentas.CurrentRow.Cells["ventasId"].Value);
            DialogResult dialogResultVentas = MessageBox.Show("¿Realmente quieres eliminar la venta?", "Ventas .::. Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResultVentas == DialogResult.Yes)
            {
                if (ventas.Destroy(id))
                {
                    FillDataGridViewVentas();
                }
                else
                    MessageBox.Show("Venta no eliminada", "Ventas .::. Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGenerarTXT_Click(object sender, EventArgs e)
        {
            string pleNombreRuc = txtNombreRuc.Text;
            string pleNombreAnio = txtNombreAnio.Text;
            string pleNombreMes = txtNombreMes.Text;

            if (pleNombreRuc != "" && pleNombreAnio != "" && pleNombreMes != "")
            {
                GenerateComprasTXT();
                GenerateCompras82TXT();
                GenerateVentasTXT();
                //MessageBox.Show("Archivos txt Crerados correctamente");
            } else MessageBox.Show("Los compos RUC, Año y Mes son Obligatorios", "PLE .::. Generación de TXTs", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GenerateComprasTXT()
        {
            DataTable dataTable = new DataTable();
            dataTable = compras.GetForTXT(Convert.ToInt32(txtNombreAnio.Text), Convert.ToInt32(txtNombreMes.Text));
            if (dataTable.Rows.Count > 0)
            {

                string fileRoute = null, filename;
                if (String.IsNullOrEmpty(txtRutaTXT.Text))
                    MessageBox.Show("Por favor ingresa la ruta a donde gurdar el TXT");
                else
                {
                    fileRoute = txtRutaTXT.Text;

                    string pleLibroCompras = "LE";
                    string pleRuc = txtNombreRuc.Text;
                    string pleAnio = txtNombreAnio.Text;
                    string pleMes = txtNombreMes.Text.PadLeft(2, '0');

                    filename = fileRoute + pleLibroCompras + pleRuc + pleAnio + pleMes + "00080100001111.txt";

                    if (File.Exists(filename))
                    {
                        DialogResult dialogResult = MessageBox.Show("Ya existe un erchivo COMPRAS 8.1 con el mismo nombre", "Archivos txt .::. Info", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            CreateComprasTXT(filename, dataTable);
                        }
                    }
                    else
                        CreateComprasTXT(filename, dataTable);
                }
            }
            else
                MessageBox.Show("No se encontrarón datos para generar el TXT");
        }

        private void GenerateVentasTXT()
        {
            DataTable dataTable = new DataTable();
            dataTable = ventas.GetForTXT(Convert.ToInt32(txtNombreAnio.Text), Convert.ToInt32(txtNombreMes.Text));
            if (dataTable.Rows.Count > 0)
            {

                string fileRoute = null, filename;
                if (String.IsNullOrEmpty(txtRutaTXT.Text))
                    MessageBox.Show("Por favor ingresa la ruta a donde gurdar el TXT");
                else
                {
                    fileRoute = txtRutaTXT.Text;

                    string pleLibroCompras = "LE";
                    string pleRuc = txtNombreRuc.Text;
                    string pleAnio = txtNombreAnio.Text;
                    string pleMes = txtNombreMes.Text.PadLeft(2, '0');

                    filename = fileRoute + pleLibroCompras + pleRuc + pleAnio + pleMes + "00140100001111.txt";



                    if (File.Exists(filename))
                    {
                        DialogResult dialogResult = MessageBox.Show("Ya existe un erchivo VENTAS con el mismo nombre", "Archivos txt .::. Info", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            CreateVentasTXT(filename, dataTable);
                        }
                    }
                    else
                        CreateVentasTXT(filename, dataTable);
                }
            }
            else
                MessageBox.Show("No se encontrarón datos para generar el TXT");
        }

        private void GenerateCompras82TXT()
        {
            string fileRoute = null, filename;
            if (String.IsNullOrEmpty(txtRutaTXT.Text))
                MessageBox.Show("Por favor ingresa la ruta a donde gurdar el TXT");
            else
            {
                fileRoute = txtRutaTXT.Text;

                string pleLibroCompras = "LE";
                string pleRuc = txtNombreRuc.Text;
                string pleAnio = txtNombreAnio.Text;
                string pleMes = txtNombreMes.Text.PadLeft(2, '0');

                filename = fileRoute + pleLibroCompras + pleRuc + pleAnio + pleMes + "00080200001011.txt"; 



                if (File.Exists(filename))
                {
                    DialogResult dialogResult = MessageBox.Show("Ya existe un erchivo COMPRAS 8.2 con el mismo nombre", "Archivos txt .::. Info", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        CreateCompras82TXT(filename);
                    }
                }
                else
                    CreateCompras82TXT(filename);
                }
        }

        private void CreateComprasTXT(string filename, DataTable dataTable)
        {
            StreamWriter fichero;
            fichero = File.CreateText(filename);
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                string txtPlePeriodo = dataTable.Rows[i]["Periodo"].ToString(); //Campo 01
                string txtPleRegimen1 = dataTable.Rows[i]["Regimen1"].ToString(); //Campo 02
                string txtPleRegimen2 = dataTable.Rows[i]["Regimen2"].ToString().PadLeft(3, '0'); //Campo 03
                string txtPleFechaEmision = dataTable.Rows[i]["FechaEmision"].ToString(); //Campo 04
                string txtPleFechaPago = dataTable.Rows[i]["FechaPago"].ToString(); //Campo 05
                string txtPleComprobanteTipo = dataTable.Rows[i]["ComprobanteTipo"].ToString(); //Campo 06
                string txtPleComprobanteSerie = dataTable.Rows[i]["ComprobanteSerie"].ToString(); //Campo 07
                string txtPleAnioEmisionAduana = dataTable.Rows[i]["AnioEmisionAduana"].ToString(); //Campo 08
                string txtPleComprobanteNumero = dataTable.Rows[i]["ComprobanteNumero"].ToString(); //Campo 09
                string txtPleCampo10 = dataTable.Rows[i]["Campo10"].ToString(); //Campo 10
                int txtPleProveedorTipo = Convert.ToInt32(dataTable.Rows[i]["ProveedorTipo"].ToString()); //Campo 11
                string txtPleProveedorNumero = dataTable.Rows[i]["ProveedorNumero"].ToString(); //Campo 12
                string txtPleProveedorNombre = dataTable.Rows[i]["ProveedorNombre"].ToString(); //Campo 13
                string txtPleBaseImponible = dataTable.Rows[i]["BaseImponible"].ToString(); //Campo 14
                string txtPleIGV = dataTable.Rows[i]["IGV"].ToString(); //Campo 15
                string txtPleBaseImponible2 = dataTable.Rows[i]["BaseImponible2"].ToString(); //Campo 16
                string txtPleIGV2 = dataTable.Rows[i]["IGV2"].ToString(); //Campo 17
                string txtPleBaseImponible3 = dataTable.Rows[i]["BaseImponible3"].ToString(); //Campo 18
                string txtPleIGV3 = dataTable.Rows[i]["IGV3"].ToString(); //Campo 19
                string txtPleNoGravada = dataTable.Rows[i]["NoGravada"].ToString(); //Campo 20
                string txtPleImpuestoImponible = dataTable.Rows[i]["ImpuestoImponible"].ToString(); //Campo 21
                string txtPleOtrosMontos = dataTable.Rows[i]["OtrosMontos"].ToString(); //Campo 22
                string txtPleImporteTotal = dataTable.Rows[i]["ImporteTotal"].ToString(); //Campo 23
                string txtPleCodigoMoneda = dataTable.Rows[i]["CodigoMoneda"].ToString(); //Campo 24
                string txtPleTipoCambio = dataTable.Rows[i]["TipoCambio"].ToString(); //Campo 25
                string txtPleConstanciaFechaPago = dataTable.Rows[i]["ConstanciaFechaPago"].ToString(); //Campo 26
                string txtPleComprobanteTipoModifica = dataTable.Rows[i]["ComprobanteTipoModifica"].ToString(); //Campo 27
                string txtPleComprobanteSerieModifica = dataTable.Rows[i]["ComprobanteSerieModifica"].ToString(); //Campo 28
                string txtPleCodigoDependenciaAduanera = dataTable.Rows[i]["CodigoDependenciaAduanera"].ToString(); //Campo 29
                string txtPleComprobanteNumeroModifica = dataTable.Rows[i]["ComprobanteNumeroModifica"].ToString(); //Campo 30
                string txtPleFechaConstanciaDetraccion = dataTable.Rows[i]["FechaConstanciaDetraccion"].ToString(); //Campo 31
                string txtPleConstanciaNumero = dataTable.Rows[i]["ConstanciaNumero"].ToString(); //Campo 32
                string txtPleMancaDetraccion = dataTable.Rows[i]["MancaDetraccion"].ToString(); //Campo 33
                string txtPleCalsificacionBienes = dataTable.Rows[i]["CalsificacionBienes"].ToString(); //Campo 34
                string txtPleIdentificacionContrato = dataTable.Rows[i]["IdentificacionContrato"].ToString(); //Campo 35
                string txtPleErrorTipo1 = dataTable.Rows[i]["ErrorTipo1"].ToString(); //Campo 36
                string txtPleErrorTipo2 = dataTable.Rows[i]["ErrorTipo2"].ToString(); //Campo 37
                string txtPleErrorTipo3 = dataTable.Rows[i]["ErrorTipo3"].ToString(); //Campo 38
                string txtPleErrorTipo4 = dataTable.Rows[i]["ErrorTipo4"].ToString(); //Campo 39
                string txtPleIdentificadorComprobante = dataTable.Rows[i]["IdentificadorComprobante"].ToString(); //Campo 40
                string txtPleEstadoIdentifica = dataTable.Rows[i]["EstadoIdentifica"].ToString(); //Campo 41
                string txtPleCampoLibre = dataTable.Rows[i]["CampoLibre"].ToString(); //Campo 42

                //if (txtPleCampoLibre != "") txtPleCampoLibre = "|" + txtPleCampoLibre;

                fichero.WriteLine(
                    txtPlePeriodo + "|" +
                    txtPleRegimen1 + "|" +
                    "M" + txtPleRegimen2 + "|" +
                    txtPleFechaEmision + "|" +
                    txtPleFechaPago + "|" +
                    txtPleComprobanteTipo + "|" +
                    txtPleComprobanteSerie + "|" +
                    txtPleAnioEmisionAduana + "|" +
                    txtPleComprobanteNumero + "|" +
                    txtPleCampo10 + "|" +
                    txtPleProveedorTipo + "|" +
                    txtPleProveedorNumero + "|" +
                    txtPleProveedorNombre + "|" +
                    txtPleBaseImponible + "|" +
                    txtPleIGV + "|" +
                    txtPleBaseImponible2 + "|" +
                    txtPleIGV2 + "|" +
                    txtPleBaseImponible3 + "|" +
                    txtPleIGV3 + "|" +
                    txtPleNoGravada + "|" +
                    txtPleImpuestoImponible + "|" +
                    txtPleOtrosMontos + "|" +
                    txtPleImporteTotal + "|" +
                    txtPleCodigoMoneda + "|" +
                    txtPleTipoCambio + "|" +
                    txtPleConstanciaFechaPago + "|" +
                    txtPleComprobanteTipoModifica + "|" +
                    txtPleComprobanteSerieModifica + "|" +
                    txtPleCodigoDependenciaAduanera + "|" +
                    txtPleComprobanteNumeroModifica + "|" +
                    txtPleFechaConstanciaDetraccion + "|" +
                    txtPleConstanciaNumero + "|" +
                    txtPleMancaDetraccion + "|" +
                    txtPleCalsificacionBienes + "|" +
                    txtPleIdentificacionContrato + "|" +
                    txtPleErrorTipo1 + "|" +
                    txtPleErrorTipo2 + "|" +
                    txtPleErrorTipo3 + "|" +
                    txtPleErrorTipo4 + "|" +
                    txtPleIdentificadorComprobante + "|" +
                    txtPleEstadoIdentifica + "|" +
                    txtPleCampoLibre + "|"
                    );
            }
            fichero.Close();
        }

        private void CreateVentasTXT(string filename, DataTable dataTable)
        {
            StreamWriter fichero;
            fichero = File.CreateText(filename);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string txtPlePeriodo = dataTable.Rows[i]["Periodo"].ToString(); //Campo 01
                string txtPleRegimen1 = dataTable.Rows[i]["Regimen1"].ToString(); //Campo 02
                string txtPleRegimen2 = dataTable.Rows[i]["Regimen2"].ToString().PadLeft(3, '0'); //Campo 03
                string txtPleFechaEmision = dataTable.Rows[i]["FechaEmision"].ToString(); //Campo 04
                string txtPleFechaPago = dataTable.Rows[i]["FechaPago"].ToString(); //Campo 05
                string txtPleComprobanteTipo = dataTable.Rows[i]["ComprobanteTipo"].ToString(); //Campo 06
                string txtPleComprobanteSerie = dataTable.Rows[i]["ComprobanteSerie"].ToString(); //Campo 07
                string ComprobanteNumero = dataTable.Rows[i]["ComprobanteNumero"].ToString(); //Campo 08
                string txtPleRegistroTicket = dataTable.Rows[i]["RegistroTicket"].ToString(); //Campo 09
                string txtPleProveedorTipo = dataTable.Rows[i]["ProveedorTipo"].ToString(); //Campo 10
                string txtPleProveedorNumero = dataTable.Rows[i]["ProveedorNumero"].ToString(); //Campo 11
                string txtPleProveedorNombre = dataTable.Rows[i]["ProveedorNombre"].ToString(); //Campo 12
                string txtPleValorExportacion = dataTable.Rows[i]["ValorExportacion"].ToString(); //Campo 13
                string txtPleBaseImponible = dataTable.Rows[i]["BaseImponible"].ToString(); //Campo 14
                string DocumentoBaseImponible = dataTable.Rows[i]["DocumentoBaseImponible"].ToString(); //Campo 15
                string txtPleIGV = dataTable.Rows[i]["IGV"].ToString(); //Campo 16
                string txtPleDescuentoIGV = dataTable.Rows[i]["DescuentoIGV"].ToString(); //Campo 17
                string txtPleImporteTotalExonerada = dataTable.Rows[i]["ImporteTotalExonerada"].ToString(); //Campo 18
                string txtPleImporteTotalInafecta = dataTable.Rows[i]["ImporteTotalInafecta"].ToString(); //Campo 19
                string txtPleISC = dataTable.Rows[i]["ISC"].ToString(); //Campo 20
                string txtPleBaseImponibleConIGVArroz = dataTable.Rows[i]["BaseImponibleConIGVArroz"].ToString(); //Campo 21
                string txtPleIVArrozPilado = dataTable.Rows[i]["IVArrozPilado"].ToString(); //Campo 22
                string txtPleOtrosMontos = dataTable.Rows[i]["OtrosMontos"].ToString(); //Campo 23
                string txtPleImporteTotal = dataTable.Rows[i]["ImporteTotal"].ToString(); //Campo 24
                string txtPleCodigoMoneda = dataTable.Rows[i]["CodigoMoneda"].ToString(); //Campo 25
                string txtPleTipoCambio = dataTable.Rows[i]["TipoCambio"].ToString(); //Campo 26
                if (txtPleCodigoMoneda == "") txtPleTipoCambio = "";
                string txtPleReferenciaFecha = dataTable.Rows[i]["ReferenciaFecha"].ToString(); //Campo 27
                string ComprobanteTipoModifica = dataTable.Rows[i]["ComprobanteTipoModifica"].ToString(); //Campo 28
                string ComprobanteSerieModifica = dataTable.Rows[i]["ComprobanteSerieModifica"].ToString(); //Campo 29
                string txtPleComprobanteNumeroModifica = dataTable.Rows[i]["ComprobanteNumeroModifica"].ToString(); //Campo 30
                string txtPleIdentificacionContrato = dataTable.Rows[i]["IdentificacionContrato"].ToString(); //Campo 31
                string txtPleErrorTipo1 = dataTable.Rows[i]["ErrorTipo1"].ToString(); //Campo 32
                string txtPleIdentificadorComprobante = dataTable.Rows[i]["IdentificadorComprobante"].ToString(); //Campo 33
                string txtPleEstadoIdentifica = dataTable.Rows[i]["EstadoIdentifica"].ToString(); //Campo 34
                string txtPleCampoLibre = dataTable.Rows[i]["CampoLibre"].ToString(); //Campo 35

                //if (txtPleCampoLibre != "") txtPleCampoLibre = "|" + txtPleCampoLibre;

                fichero.WriteLine(
                    txtPlePeriodo + "|" +
                    txtPleRegimen1 + "|" +
                    "M" + txtPleRegimen2 + "|" +
                    txtPleFechaEmision + "|" +
                    txtPleFechaPago + "|" +
                    txtPleComprobanteTipo + "|" +
                    txtPleComprobanteSerie + "|" +
                    ComprobanteNumero + "|" +
                    txtPleRegistroTicket + "|" +
                    txtPleProveedorTipo + "|" +
                    txtPleProveedorNumero + "|" +
                    txtPleProveedorNombre + "|" +
                    txtPleValorExportacion + "|" +
                    txtPleBaseImponible + "|" +
                    DocumentoBaseImponible + "|" +
                    txtPleIGV + "|" +
                    txtPleDescuentoIGV + "|" +
                    txtPleImporteTotalExonerada + "|" +
                    txtPleImporteTotalInafecta + "|" +
                    txtPleISC + "|" +
                    txtPleBaseImponibleConIGVArroz + "|" +
                    txtPleIVArrozPilado + "|" +
                    txtPleOtrosMontos + "|" +
                    txtPleImporteTotal + "|" +
                    txtPleCodigoMoneda + "|" +
                    txtPleTipoCambio + "|" +
                    txtPleReferenciaFecha + "|" +
                    ComprobanteTipoModifica + "|" +
                    ComprobanteSerieModifica + "|" +
                    txtPleComprobanteNumeroModifica + "|" +
                    txtPleIdentificacionContrato + "|" +
                    txtPleErrorTipo1 + "|" +
                    txtPleIdentificadorComprobante + "|" +
                    txtPleEstadoIdentifica + "|" +
                    txtPleCampoLibre
                    );
            }
            fichero.Close();
        }

        private void CreateCompras82TXT(string filename)
        {
            StreamWriter fichero;
            fichero = File.CreateText(filename);
            //fichero.WriteLine();
            fichero.Close();
        }

        private void btnCargarCarpeta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                TXTRoute = fbd.SelectedPath + "\\";
                txtRutaTXT.Text = TXTRoute;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombreMes.Text != "" && txtNombreAnio.Text != "")
            {
                FillDataGridViewCompras(true);
                FillDataGridViewVentas(true);
            }
            else
                MessageBox.Show("Ingrese un Año y un Mes para realizar el filtrado"); 
        }

        private void sgvRegistroCompras_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSourceCompras.Sort = this.dgvRegistroCompras.SortString;
            this.BSComprasBindingSource.Sort = this.dgvRegistroCompras.SortString;
            //this.spallcurrentmonthcomprasBindingSource.Sort = this.dgvRegistroCompras.FilterString;

            //dgvRegistroCompras.Update();
        }

        private void sgvRegistroCompras_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingSourceCompras.Filter = this.dgvRegistroCompras.SortString;
            this.BSComprasBindingSource.Filter = this.dgvRegistroCompras.FilterString;
            //this.spallcurrentmonthcomprasBindingSource.Filter = this.dgvRegistroCompras.FilterString;
            //dgvRegistroCompras.Update();
        }

        private void removeColumnsCompras()
        {
            dgvRegistroCompras.Columns.Remove("dataGridViewTextBoxColumn1");
            dgvRegistroCompras.Columns.Remove("dataGridViewTextBoxColumn2");
            dgvRegistroCompras.Columns.Remove("dataGridViewTextBoxColumn3");
            dgvRegistroCompras.Columns.Remove("dataGridViewTextBoxColumn4");
            dgvRegistroCompras.Columns.Remove("FechaPagoDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("CTipoDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("CSerieDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("CNDocumentoDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("PTipoDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("PNumeroDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("PDocumentoDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("PNombreRazonSocialDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("CuentaDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("DescripcionDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("BaseImponibleDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("IGVDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("NoGravadaDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("DescuentosDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("ImporteTotalDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("DolaresDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("TipoCambioDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("PercepcionDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("DestinoDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("DescripcionDestinoDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("PgoDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("CuentaDestinoDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("CodigoDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("ConstanciaNumeroDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("ConstanciaFechaPagoDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("ConstanciaMontoDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("ConstanciaReferenciaDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("BancarizacionFechaDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("BancarizacionBcoDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("BancarizacionOperacionDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("ReferenciaFechaDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("ReferenciaTipoDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("ReferenciaSerieDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("ReferenciaNumeroDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("UsuarioDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("FechaRegistroDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("FechaModificacionDataGridViewTextBoxColumn");
            dgvRegistroCompras.Columns.Remove("ConversionDolarDataGridViewTextBoxColumn");
        }

        private void removeColumnsVentas()
        {
            dgvRegistroVentas.Columns.Remove("idLibroVentasDataGridViewTextBoxColumn");
            dgvRegistroVentas.Columns.Remove("dataGridViewTextBoxColumn5");
            dgvRegistroVentas.Columns.Remove("dataGridViewTextBoxColumn6");
            dgvRegistroVentas.Columns.Remove("dataGridViewTextBoxColumn7");
            dgvRegistroVentas.Columns.Remove("fechaPagoDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("cTipoDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("cSerieDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("cNDocumentoDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("pTipoDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("pNumeroDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("pNombreRazonSocialDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("cuentaDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("descripcionDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("valorExportacionDataGridViewTextBoxColumn");
            dgvRegistroVentas.Columns.Remove("baseImponibleDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("importeTotalExoneradaDataGridViewTextBoxColumn");
            dgvRegistroVentas.Columns.Remove("importeTotalInafectaDataGridViewTextBoxColumn");
            dgvRegistroVentas.Columns.Remove("iGVDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("importeTotalDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("tCDataGridViewTextBoxColumn");
            dgvRegistroVentas.Columns.Remove("dolaresDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("igvRetencionDataGridViewTextBoxColumn");
            dgvRegistroVentas.Columns.Remove("cuentaDestinoDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("pagoDataGridViewTextBoxColumn");
            dgvRegistroVentas.Columns.Remove("referenciaFechaDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("referenciaTipoDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("referenciaSerieDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("referenciaNumeroDocumentoDataGridViewTextBoxColumn");
            dgvRegistroVentas.Columns.Remove("codigoDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("constanciaNumeroDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("constanciaFechaPagoDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("detraccionSolesDataGridViewTextBoxColumn");
            dgvRegistroVentas.Columns.Remove("referenciaDataGridViewTextBoxColumn");
            dgvRegistroVentas.Columns.Remove("observacionDataGridViewTextBoxColumn");
            dgvRegistroVentas.Columns.Remove("usuarioDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("fechaRegistroDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("fechaModificacionDataGridViewTextBoxColumn1");
            dgvRegistroVentas.Columns.Remove("cuentaDestinoDescripcionDataGridViewTextBoxColumn");
        }
        private void fillCurrentMonthToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.TAComprasTableAdapter.FillCurrentMonth(this.dSCompras.tblRegistroCompras);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FillDataGridViewCompras();
            FillDataGridViewVentas();
        }

        private void dgvRegistroCompras_KeyDown(object sender, KeyEventArgs e)
        {
            ZoomCompras(e);
            ZoomVentas(e);
        }

        private void ZoomCompras(KeyEventArgs e)
        {
            float fontSize = dgvRegistroCompras.DefaultCellStyle.Font.Size;
            float fontHeaderSize = dgvRegistroCompras.ColumnHeadersDefaultCellStyle.Font.Size;

            if (e.KeyCode == Keys.Add)//Control con '+'
            {
                dgvRegistroCompras.DefaultCellStyle.Font = new Font("Tahoma", fontSize + 1, FontStyle.Regular);
                dgvRegistroCompras.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", fontHeaderSize + 1, FontStyle.Bold);
                foreach (DataGridViewColumn column in dgvRegistroCompras.Columns)
                {
                    column.Width = column.Width + 3;
                }

                foreach (DataGridViewRow row in dgvRegistroCompras.Rows)
                {
                    row.Height = row.Height + 1;
                }
            }
            else if (e.KeyCode == Keys.Subtract)//Control con '-'
            {
                dgvRegistroCompras.DefaultCellStyle.Font = new Font("Tahoma", fontSize - 1, FontStyle.Regular);
                dgvRegistroCompras.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", fontHeaderSize - 1, FontStyle.Bold);
                foreach (DataGridViewColumn column in dgvRegistroCompras.Columns)
                {
                    column.Width = column.Width - 3;
                }

                foreach (DataGridViewRow row in dgvRegistroCompras.Rows)
                {
                    row.Height = row.Height - 1;
                }
            }
        }

        private void ZoomVentas(KeyEventArgs e)
        {
            float fontSize = dgvRegistroVentas.DefaultCellStyle.Font.Size;
            float fontHeaderSize = dgvRegistroVentas.ColumnHeadersDefaultCellStyle.Font.Size;

            if (e.KeyCode == Keys.Add)//Control con '+'
            {
                dgvRegistroVentas.DefaultCellStyle.Font = new Font("Tahoma", fontSize + 1, FontStyle.Regular);
                dgvRegistroVentas.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", fontHeaderSize + 1, FontStyle.Bold);
                foreach (DataGridViewColumn column in dgvRegistroVentas.Columns)
                {
                    column.Width = column.Width + 3;
                }

                foreach (DataGridViewRow row in dgvRegistroVentas.Rows)
                {
                    row.Height = row.Height + 1;
                }
            }
            else if (e.KeyCode == Keys.Subtract)//Control con '-'
            {
                dgvRegistroVentas.DefaultCellStyle.Font = new Font("Tahoma", fontSize - 1, FontStyle.Regular);
                dgvRegistroVentas.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", fontHeaderSize - 1, FontStyle.Bold);
                foreach (DataGridViewColumn column in dgvRegistroVentas.Columns)
                {
                    column.Width = column.Width - 3;
                }

                foreach (DataGridViewRow row in dgvRegistroVentas.Rows)
                {
                    row.Height = row.Height - 1;
                }
            }
        }

        ComboBox cboCodigoCompras = null;
        private void dgvRegistroCompras_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs ev)
        {
            
            //cboCodigoCompras = ev.Control as ComboBox;

            //int compraCodigo = -1;

            //if (cboCodigoCompras != null)
            //{
            //    compraCodigo = cboCodigoCompras.SelectedIndex;
            //    double comprasImporteTotal = 0;

            //    if (String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasImporteTotal"].Value.ToString() as String))
            //        MessageBox.Show("Ingrese un Importe Total");
            //    else comprasImporteTotal = Convert.ToDouble(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasImporteTotal"].Value.ToString());

            //    //compraCodigo = Convert.ToInt32(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasCodigo"].Value.ToString());

            //    DataTable dataTableDetraccion = new DataTable();
            //    dataTableDetraccion = detraccion.Show(compraCodigo);
            //    if (dataTableDetraccion.Rows.Count > 0)
            //    {
            //        double detraccionProcentaje = Convert.ToDouble(dataTableDetraccion.Rows[0]["porcentaje"].ToString());
            //        double detraccionMonto = Convert.ToDouble(dataTableDetraccion.Rows[0]["monto"].ToString());
            //        if (comprasImporteTotal > detraccionMonto)
            //            dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasConstanciaReferencia"].Value = Math.Round(comprasImporteTotal * detraccionProcentaje, 2);
            //        else
            //            dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasConstanciaReferencia"].Value = "";
            //    }
            //}
        }

        private void dgvRegistroVentas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
