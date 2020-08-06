using System;
using System.Data;
using System.Drawing;
using System.IO;
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

        private Compras compras = new Compras();
        private Ventas ventas = new Ventas();
        private Detraccion detraccion = new Detraccion();

        string TXTRoute = null;
        public FrmProgramaLibrosElectronicos()
        {
            InitializeComponent();
        }

        private void FrmProgramaLibrosElectronicos_Load(object sender, EventArgs e)
        {
            FillDataComprasVentas();
            FillComboTipoComprobante();
            dgvRegistroCompras.AutoGenerateColumns = false;
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

        //MOSTRAR COMPRAS POR MES ACTUAL
        private void FilterCompras()
        {
            int filtroMes = Convert.ToInt32(txtNombreMes.Text);
            int filtroAnio = Convert.ToInt32(txtNombreAnio.Text);

            DataTable dataTable = new DataTable();
            dataTable = compras.AllByMonthFilter(filtroAnio, filtroMes);

            dgvRegistroCompras.AutoGenerateColumns = false;

            //dgvRegistroCompras.ColumnCount = 3;

                this.comprasID.DataPropertyName = "idLibroCompras";
                this.comprasMes.DataPropertyName = "Mes";
                this.comprasNumeroRegistro.DataPropertyName = "NReg";
                this.comprasFechaEmision.DataPropertyName = "FechaEmision";
                this.comprasFechaPago.DataPropertyName = "FechaPago";
                this.comprasCdpTipo.DataPropertyName = "CTipo";
                this.comprasCdpSerie.DataPropertyName = "CSerie";
                this.comprasCdpNumeroDocumento.DataPropertyName = "CNDocumento";
                this.comprasProveedorTipo.DataPropertyName = "PTipo";
                this.comprasProveedorNumeroDocumento.DataPropertyName = "PNumero";
                this.comprasProveedorTipoDocumento.DataPropertyName = "PDocumento";
                this.comprasProveedorRazonSocial.DataPropertyName = "PNombreRazonSocial";
                this.comprasCuenta.DataPropertyName = "Cuenta";
                this.comprasDescripcion.DataPropertyName = "Descripcion";
                this.comprasBaseImponible.DataPropertyName = "BaseImponible";
                this.comprasIgv.DataPropertyName = "IGV";
                this.comprasNoGravada.DataPropertyName = "NoGravada";
                this.comprasDescuento.DataPropertyName = "Descuentos";
                this.comprasImporteTotal.DataPropertyName = "ImporteTotal";
                this.comprasDolares.DataPropertyName = "Dolares";
                this.comprasTipoCambio.DataPropertyName = "TipoCambio";
                this.comprasConversionDolares.DataPropertyName = "ConversionDolar";
                this.comprasPercepcion.DataPropertyName = "Percepcion";
                this.comprasDestino.DataPropertyName = "Destino";
                this.comprasDescripcionDestino.DataPropertyName = "DescripcionDestino";
                this.comprasCuentaDestino.DataPropertyName = "CuentaDestino";
                this.comprasPago.DataPropertyName = "Pgo";
                this.comprasCodigo.DataPropertyName = "Codigo";
                this.comprasConstanciaNumero.DataPropertyName = "ConstanciaNumero";
                this.comprasConstanciaFechaPago.DataPropertyName = "ConstanciaFechaPago";
                this.comprasConstanciaMonto.DataPropertyName = "ConstanciaMonto";
                this.comprasConstanciaReferencia.DataPropertyName = "ConstanciaReferencia";
                this.BancarizacionFecha.DataPropertyName = "BancarizacionFecha";
                this.BancarizacionBco.DataPropertyName = "BancarizacionBco";
                this.BancarizacionOperacion.DataPropertyName = "BancarizacionOperacion";
                this.comprasReferenciaFecha.DataPropertyName = "ReferenciaFecha";
                this.comprasReferenciaTipo.DataPropertyName = "ReferenciaTipo";
                this.comprasReferenciaSerie.DataPropertyName = "ReferenciaSerie";
                this.comprasReferenciaNumero.DataPropertyName = "ReferenciaNumero";


            dgvRegistroCompras.DataSource = dataTable;
        }

        private void FilterVentas()
        {
            int filtroMes = Convert.ToInt32(txtNombreMes.Text);
            int filtroAnio = Convert.ToInt32(txtNombreAnio.Text);

            DataTable dataTable = new DataTable();
            dataTable = ventas.AllByMonthFilter(filtroAnio, filtroMes);

            dgvRegistroVentas.AutoGenerateColumns = false;

            //dgvRegistroVentas.ColumnCount = 3;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                this.ventasId.DataPropertyName = "idLibroVentas";
                this.ventasMes.DataPropertyName = "Mes";
                this.ventasNumeroRegistro.DataPropertyName = "NReg";
                this.ventasFechaEmision.DataPropertyName = "FechaEmision";
                this.ventasFechapago.DataPropertyName = "FechaPago";
                this.ventasCdpTipo.DataPropertyName = "CTipo";
                this.ventasCdpSerie.DataPropertyName = "CSerie";
                this.ventasCdpNumero.DataPropertyName = "CNDocumento";
                this.ventasProveedorTipo.DataPropertyName = "PTipo";
                this.ventasProveedorNumero.DataPropertyName = "PNumero";
                this.ventasProveedorRazonSocial.DataPropertyName = "PNombreRazonSocial";
                this.ventasCuenta.DataPropertyName = "Cuenta";
                this.ventasDescripcion.DataPropertyName = "Descripcion";
                this.ventasValorExportacion.DataPropertyName = "ValorExportacion";
                this.ventasBaseImponible.DataPropertyName = "BaseImponible";
                this.ventasImporteTotalExonerada.DataPropertyName = "ImporteTotalExonerada";
                this.ventasImporteTotalInafecta.DataPropertyName = "ImporteTotalInafecta";
                this.ventasIgv.DataPropertyName = "IGV";
                this.ventasImporteTotal.DataPropertyName = "ImporteTotal";
                this.ventasTipoCambio.DataPropertyName = "TC";
                this.ventasDolares.DataPropertyName = "Dolares";
                this.ventasIgvRetencion.DataPropertyName = "IgvRetencion";
                this.ventasCuentaDestino.DataPropertyName = "CuentaDestino";
                this.ventasCuentaDestinoDescripcion.DataPropertyName = "CuentaDestinoDescripcion";
                this.ventasPago.DataPropertyName = "Pago";
                this.ventasReferenciaFecha.DataPropertyName = "ReferenciaFecha";
                this.ventasReferenciaTipo.DataPropertyName = "ReferenciaTipo";
                this.ventasReferenciaSerie.DataPropertyName = "ReferenciaSerie";
                this.ventasReferenciaNumero.DataPropertyName = "ReferenciaNumeroDocumento";
                this.ventasCodigo.DataPropertyName = "Codigo";
                this.ventasConstanciaNumero.DataPropertyName = "ConstanciaNumero";
                this.ventasConstanciaFechaPago.DataPropertyName = "ConstanciaFechaPago";
                this.ventasDetraccionSoles.DataPropertyName = "DetraccionSoles";
                this.ventasReferencia.DataPropertyName = "Referencia";
                this.ventasObservacion.DataPropertyName = "Observacion";
            }

            dgvRegistroVentas.DataSource = dataTable;
        }

        //GUARDAR Compras 
        private void SaveCompras()
        {
            try
            {
                foreach (DataGridViewRow row in dgvRegistroCompras.Rows)
                {
                    if (row.Cells["comprasMes"].Value != null)
                    {
                        int id = row.Cells["comprasID"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["comprasID"].Value) : 0;
                        int comprasMes = row.Cells["comprasMes"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["comprasMes"].Value) : 0;

                        string comprasNumeroRegistro = row.Cells["comprasNumeroRegistro"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasNumeroRegistro"].Value) : "";
                        string comprasFechaEmision = row.Cells["comprasFechaEmision"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasFechaEmision"].Value) : "";
                        string comprasFechaPago = row.Cells["comprasFechaPago"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasFechaPago"].Value) : "1900-01-01";
                        string comprasCdpTipo = row.Cells["comprasCdpTipo"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasCdpTipo"].Value) : "";
                        string comprasCdpSerie = row.Cells["comprasCdpSerie"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasCdpSerie"].Value) : "";
                        string comprasCdpNumeroDocumento = row.Cells["comprasCdpNumeroDocumento"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasCdpNumeroDocumento"].Value) : "";
                        string comprasProveedorTipo = row.Cells["comprasProveedorTipo"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasProveedorTipo"].Value) : "";
                        string comprasProveedorNumeroDocumento = row.Cells["comprasProveedorNumeroDocumento"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasProveedorNumeroDocumento"].Value) : "";
                        string comprasProveedorTipoDocumento = row.Cells["comprasProveedorTipoDocumento"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasProveedorTipoDocumento"].Value) : "";

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
                        string comprasPago = row.Cells["comprasPago"].Value != DBNull.Value ? Convert.ToString(row.Cells["comprasPago"].Value) : "";
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
                        

                        string Usuario = "user02";

                        if (id < 0)
                        {
                            compras.Insert(
                                comprasMes, comprasNumeroRegistro, comprasFechaEmision, comprasFechaPago, comprasCdpTipo,
                                comprasCdpSerie, comprasCdpNumeroDocumento, comprasProveedorTipo, comprasProveedorNumeroDocumento,
                                comprasProveedorTipoDocumento, comprasProveedorRazonSocial, comprasCuenta, comprasDescripcion,
                                comprasBaseImponible, comprasIgv, comprasNoGravada, comprasDescuento, comprasImporteTotal, comprasDolares,
                                comprasTipoCambio, comprasPercepcion, comprasDestino, comprasDescripcionDestino, comprasCuentaDestino, comprasPago,
                                comprasCodigo, comprasConstanciaNumero, comprasConstanciaFechaPago, comprasConstanciaMonto, comprasConstanciaReferencia,
                                BancarizacionFecha, BancarizacionBco, BancarizacionOperacion, ReferenciaFecha, ReferenciaTipo, ReferenciaSerie, ReferenciaNumero,
                                Usuario, comprasConversionDolares
                            );
                        }
                        else
                        {
                            compras.Update(
                                id, comprasMes, comprasNumeroRegistro, comprasFechaEmision, comprasFechaPago, comprasCdpTipo,
                                comprasCdpSerie, comprasCdpNumeroDocumento, comprasProveedorTipo, comprasProveedorNumeroDocumento,
                                comprasProveedorTipoDocumento, comprasProveedorRazonSocial, comprasCuenta, comprasDescripcion,
                                comprasBaseImponible, comprasIgv, comprasNoGravada, comprasDescuento, comprasImporteTotal, comprasDolares,
                                comprasTipoCambio, comprasPercepcion, comprasDestino, comprasDescripcionDestino, comprasCuentaDestino, comprasPago,
                                comprasCodigo, comprasConstanciaNumero, comprasConstanciaFechaPago, comprasConstanciaMonto, comprasConstanciaReferencia,
                                BancarizacionFecha, BancarizacionBco, BancarizacionOperacion, ReferenciaFecha, ReferenciaTipo, ReferenciaSerie, ReferenciaNumero, Usuario, comprasConversionDolares
                                );
                        }
                    }
                }
                MessageBox.Show("Se han guardado los cambios correctamente", "Compras .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataComprasVentas();
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
                    if (!string.IsNullOrEmpty(Convert.ToString(row.Cells["ventasMes"].Value)))
                    {
                        int ventasId = Convert.ToInt32(row.Cells["ventasId"].Value);
                        int ventasMes = row.Cells["ventasMes"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["ventasMes"].Value) : 0;
                        string ventasNumeroRegistro = row.Cells["ventasNumeroRegistro"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasNumeroRegistro"].Value) : "";
                        string ventasFechaEmision = row.Cells["ventasFechaEmision"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasFechaEmision"].Value) : "";
                        string ventasFechaPago = row.Cells["ventasFechaPago"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasFechaPago"].Value) : "";
                        string ventasCdpTipo = row.Cells["ventasCdpTipo"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasCdpTipo"].Value) : "";
                        string ventasCdpSerie = row.Cells["ventasCdpSerie"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasCdpSerie"].Value) : "";
                        string ventasCdpNumero = row.Cells["ventasCdpNumero"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasCdpNumero"].Value) : "";
                        string ventasProveedorTipo = row.Cells["ventasProveedorTipo"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasProveedorTipo"].Value) : "";
                        string ventasProveedorNumero = row.Cells["ventasProveedorNumero"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasProveedorNumero"].Value) : "";
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
                        double ventasDolaresConversion = row.Cells["ventasDolaresConversion"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["ventasDolaresConversion"].Value) : 0;

                        double ventasIgvRetencion = row.Cells["ventasIgvRetencion"].Value != DBNull.Value ? Convert.ToDouble(row.Cells["ventasIgvRetencion"].Value) : 0;
                        string ventasCuentaDestino = row.Cells["ventasCuentaDestino"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasCuentaDestino"].Value) : "";
                        string ventasCuentaDestinoDescripcion = row.Cells["ventasCuentaDestinoDescripcion"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasCuentaDestinoDescripcion"].Value) : "";
                        string ventasPago = row.Cells["ventasPago"].Value != DBNull.Value ? Convert.ToString(row.Cells["ventasPago"].Value) : "";
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
                        string ventasUSuario = "user02";

                        if (ventasId < 0)
                        {
                            ventas.Insert(
                                ventasMes, ventasNumeroRegistro, ventasFechaEmision, ventasFechaPago, ventasCdpTipo, ventasCdpSerie, ventasCdpNumero, ventasProveedorTipo,
                                ventasProveedorNumero, ventasProveedorRazonSocial, ventasCuenta, ventasDescripcion, ventasValorExportacion, ventasBaseImponible,
                                ventasImporteTotalExonerada, ventasImporteTotalInafecta, ventasIgv, ventasImporteTotal, ventasTipoCambio, ventasDolares,
                                ventasIgvRetencion, ventasCuentaDestino, ventasCuentaDestinoDescripcion, ventasPago, ventasReferenciaFecha, ventasReferenciaTipo, ventasReferenciaSerie,
                                ventasReferenciaNumero, ventasCodigo, ventasConstanciaNumero, ventasConstanciaFechaPago, ventasDetraccionSoles, ventasReferencia,
                                ventasObservacion, ventasUSuario
                                );
                        } else
                        {
                            ventas.Update(
                                ventasId, ventasMes, ventasNumeroRegistro, ventasFechaEmision, ventasFechaPago, ventasCdpTipo, ventasCdpSerie, ventasCdpNumero, ventasProveedorTipo,
                                ventasProveedorNumero, ventasProveedorRazonSocial, ventasCuenta, ventasDescripcion, ventasValorExportacion, ventasBaseImponible,
                                ventasImporteTotalExonerada, ventasImporteTotalInafecta, ventasIgv, ventasImporteTotal, ventasTipoCambio, ventasDolares,
                                ventasIgvRetencion, ventasCuentaDestino, ventasCuentaDestinoDescripcion, ventasPago, ventasReferenciaFecha, ventasReferenciaTipo, ventasReferenciaSerie,
                                ventasReferenciaNumero, ventasCodigo, ventasConstanciaNumero, ventasConstanciaFechaPago, ventasDetraccionSoles, ventasReferencia,
                                ventasObservacion, ventasUSuario
                                );
                        }

                    }
                }
                MessageBox.Show("Se han guardado los cambios", "Ventas .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataComprasVentas();
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


        private void btnGuardarVentas_Click(object sender, EventArgs e)
        {
            SaveVentas();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            //
        }

        private void dgvRegistroCompras_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void dgvRegistroCompras_CellLeave_1(object sender, DataGridViewCellEventArgs e)
        {

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
            switch (e.ColumnIndex)
            {
                case 3:

                    string fecha = null, compra = null, venta = null;
                    DataTable dataTableTipoCambio = new DataTable();

                    if (dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasFechaEmision"].Value != DBNull.Value)
                    {
                        if (isDate(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasFechaEmision"].Value.ToString()))
                        {
                            fecha = dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasFechaEmision"].Value.ToString();

                            dataTableTipoCambio = tipoCambio.Show(fecha);
                            if (dataTableTipoCambio.Rows.Count > 0)
                            {
                                compra = dataTableTipoCambio.Rows[0]["Compra"].ToString();
                                venta = dataTableTipoCambio.Rows[0]["Venta"].ToString();


                                dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasTipoCambio"].Value = venta;
                            }
                            else
                                MessageBox.Show("No se encontro un tipo de cambio para la fecha: " + fecha, "Tipo de Cambio .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasFechaPago"].Value = fecha;
                        }
                        else
                            MessageBox.Show("(" + dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasFechaEmision"].Value.ToString() + ") No es una fecha valida \nIngrese una fecha válida con los siguientes formatos: \ndd/mm/yyyy o yyyy-mm-dd");
                    }
                    break;
                case 9:
                    string ruc;
                    string razonSocial;
                    if (dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasProveedorNumeroDocumento"].Value != DBNull.Value)
                    {
                        ruc = dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasProveedorNumeroDocumento"].Value.ToString();
                        razonSocial = proveedor.GetSupplierName(ruc);
                        if (razonSocial == null)
                        {
                            MessageBox.Show("No se encontro al proveedor con ruc: " + ruc, "Compras .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasProveedorNumeroDocumento"].Value = "";
                        }
                        else
                            dgvRegistroCompras.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value = razonSocial;
                    }
                    break;
                case 14:
                case 16:
                case 18:
                    //Calculos de No BaseInmponible
                    double baseImponible = 0, descuento = 0, igv = 0, noGravada = 0;

                    if (!String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasBaseImponible"].Value.ToString() as String))
                        baseImponible = Convert.ToDouble(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasBaseImponible"].Value.ToString());

                    if (!String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasDescuento"].Value.ToString() as String))
                        descuento = Convert.ToDouble(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasDescuento"].Value.ToString());

                    dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasIgv"].Value = Math.Round((baseImponible + descuento) * 0.18, 2);

                    if (!String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasIgv"].Value.ToString() as String))
                        igv = Convert.ToDouble(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasIgv"].Value.ToString());

                    if (!String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasNoGravada"].Value.ToString() as String))
                        noGravada = Convert.ToDouble(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasNoGravada"].Value.ToString());

                    dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasImporteTotal"].Value = baseImponible + descuento + igv + noGravada;
                    double importe_total;
                    importe_total = Convert.ToDouble(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasImporteTotal"].Value.ToString());

                    if (importe_total >= 3500)
                    {
                        if (String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["BancarizacionFecha"].Value as String) || String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["BancarizacionBco"].Value as String) || String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["BancarizacionOperacion"].Value as String))
                        {
                            MessageBox.Show("Ingrese Bancarización");
                            dgvRegistroCompras.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Teal;
                        }
                        else
                        {
                            dgvRegistroCompras.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        }

                    }
                    break;
                case 19:
                    double tipoCambi = 0, dolares = 0;

                    if (dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasDolares"].Value != DBNull.Value)
                    {
                        if (!String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasDolares"].Value.ToString() as String))
                            dolares = Convert.ToDouble(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasDolares"].Value.ToString());

                        if (!String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasTipoCambio"].Value.ToString() as String))
                            tipoCambi = Convert.ToDouble(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasTipoCambio"].Value.ToString());

                        dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasConversionDolares"].Value = Math.Round((dolares * tipoCambi), 2);
                    }
                    break;
                case 12:
                case 23:
                    string codigo;
                    string cuenta;
                    if (dgvRegistroCompras.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != DBNull.Value)
                    {
                        codigo = dgvRegistroCompras.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        cuenta = planContable.GetAcount(codigo);
                        if (cuenta == null)
                            MessageBox.Show("No se encontro una cuenta con código: " + codigo, "Compras .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            dgvRegistroCompras.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = cuenta;
                    }
                    break;
                case 27:
                    double comprasImporteTotal = 0;
                    int comprasCodigo = 0;

                    if (String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasImporteTotal"].Value.ToString() as String))
                        MessageBox.Show("Ingrese un Importe Total");
                    else
                        comprasImporteTotal = Convert.ToDouble(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasImporteTotal"].Value.ToString());

                    if (String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasCodigo"].Value.ToString() as String))
                        MessageBox.Show("Ingrese un código");
                    else
                        comprasCodigo = Convert.ToInt32(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasCodigo"].Value.ToString());

                    DataTable dataTableDetraccion = new DataTable();
                    dataTableDetraccion = detraccion.Show(comprasCodigo);
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
                        MessageBox.Show("Ingrese un número entero (1 - 5)");
                        dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasConstanciaReferencia"].Value = "";
                    }
                        
                    break;
            }
        }

        private void dgvRegistroVentas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 3:
                    string fecha = null, compra = null, venta = null;
                    DataTable dataTableTipoCambio = new DataTable();

                    if (isDate(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasFechaEmision"].Value.ToString()))
                    {
                        fecha = dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasFechaEmision"].Value.ToString().Substring(0, 10);

                        dataTableTipoCambio = tipoCambio.Show(fecha);
                        compra = dataTableTipoCambio.Rows[0]["Compra"].ToString();
                        venta = dataTableTipoCambio.Rows[0]["Venta"].ToString();

                        dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasFechaPago"].Value = fecha;

                        if (venta == null)
                            MessageBox.Show("No se encontro un tipo de cambio para la fecha: " + fecha, "Tipo de Cambio .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasTipoCambio"].Value = venta;
                    } else
                        MessageBox.Show("(" + dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasFechaEmision"].Value.ToString() + ") No es una fecha valida \nIngrese una fecha válida con los siguientes formatos: \ndd/mm/yyyy o yyyy-mm-dd");
                    
                    break;
                case 9:
                    string ruc;
                    string razonSocial;
                    if (dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != DBNull.Value) {
                        ruc = dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        razonSocial = proveedor.GetSupplierName(ruc);

                        if (razonSocial == null)
                            MessageBox.Show("No se encontro al proveedor con ruc: " + ruc, "Compras .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = razonSocial;
                    }
                    break;
                case 18: // BaseImponible
                    double biImporteTotal = 0;
                    if (String.IsNullOrEmpty(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value.ToString()))
                        MessageBox.Show("Ingrese un Importe Total");
                    else
                        biImporteTotal = Convert.ToDouble(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value.ToString());

                    dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasBaseImponible"].Value = Math.Round((biImporteTotal / 1.18), 2);
                   

                    double igvImporteTotal = 0, igvBaseImponible = 0;
                    if (String.IsNullOrEmpty(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value.ToString()))
                        MessageBox.Show("Ingrese un Importe Total");
                    else
                        igvImporteTotal = Convert.ToDouble(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value.ToString());

                    if (String.IsNullOrEmpty(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasBaseImponible"].Value.ToString()))
                        MessageBox.Show("Ingrese una Base Imponible");
                    else
                        igvBaseImponible = Convert.ToDouble(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasBaseImponible"].Value.ToString());

                    dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasIgv"].Value = Math.Round((igvImporteTotal - igvBaseImponible), 2);

                    break;
                case 11:
                case 22:
                    string codigo;
                    string cuenta;
                    codigo = dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    cuenta = planContable.GetAcount(codigo);
                    if (cuenta == null)
                        MessageBox.Show("No se encontro una cuenta con código: " + codigo, "Compras .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = cuenta;
                    break;
                case 29:
                    double ventasImporteTotal = 0;
                    int ventasCodigo = 0;

                    if (String.IsNullOrEmpty(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value.ToString() as String))
                        MessageBox.Show("Ingrese un Importe Total");
                    else
                        ventasImporteTotal = Convert.ToDouble(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasImporteTotal"].Value.ToString());

                    if (String.IsNullOrEmpty(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasCodigo"].Value.ToString() as String))
                        MessageBox.Show("Ingrese un código");
                    else
                        ventasCodigo = Convert.ToInt32(dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasCodigo"].Value.ToString());

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
            if (compras.Destroy(id))
            {
                MessageBox.Show("Compra Eliminada", "Compras .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataComprasVentas();
            }
            else
                MessageBox.Show("Compra NO Eliminada", "Compras .::. Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FillDataComprasVentas()
        {
            this.sp_all_current_month_comprasTableAdapter.Fill(this.dSRegistroCompras.sp_all_current_month_compras);
            dgvRegistroCompras.Refresh();

            this.sp_all_month_ventasTableAdapter.Fill(this.dSRegistroVentas.sp_all_month_ventas);
            dgvRegistroVentas.Refresh();
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

        private void dgvVentas_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["ventasId"].Value = GenerateID();
            e.Row.DefaultCellStyle.Font = new Font(dgvRegistroVentas.Font, FontStyle.Italic);

            e.Row.Cells["ventasFechaEmision"].Value = DateTime.UtcNow.ToString("dd/MM/yyyy");
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
            if (ventas.Destroy(id))
            {
                MessageBox.Show("Venta Eliminada", "Ventas .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataComprasVentas();
            }
            else
                MessageBox.Show("Venta no eliminada", "Ventas .::. Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Archivos txt Crerados correctamente");
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
                string txtPleRegimen2 = dataTable.Rows[i]["Regimen2"].ToString(); //Campo 03
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
                    txtPleRegimen2 + "|" +
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
                string txtPleRegimen2 = dataTable.Rows[i]["Regimen2"].ToString(); //Campo 03
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
                    txtPleRegimen2 + "|" +
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

        private void CreateCompras82TXT(string filename = "LE2060211160220200300080200001011.txt")
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
                FilterCompras();
                FilterVentas();
            }
            else
                MessageBox.Show("Ingrese un Año y un Mes para realizar el filtrado"); 
        }
    }
}
