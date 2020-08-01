using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //bool edit = false;
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


        //GUARDAR Compras 
        private void SaveCompras()
        {
            try
            {
                foreach (DataGridViewRow row in dgvRegistroCompras.Rows)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(row.Cells["comprasMes"].Value)))
                    {
                        int id = Convert.ToInt32(row.Cells["comprasID"].Value);
                        int comprasMes = Convert.ToInt32(row.Cells["comprasMes"].Value);
                        string comprasNumeroRegistro = Convert.ToString(row.Cells["comprasNumeroRegistro"].Value);
                        string comprasFechaEmision = Convert.ToString(row.Cells["comprasFechaEmision"].Value);
                        string comprasFechaPago = Convert.ToString(row.Cells["comprasFechaPago"].Value);
                        string comprasCdpTipo = Convert.ToString(row.Cells["comprasCdpTipo"].Value);
                        string comprasCdpSerie = Convert.ToString(row.Cells["comprasCdpSerie"].Value);
                        string comprasCdpNumeroDocumento = Convert.ToString(row.Cells["comprasCdpNumeroDocumento"].Value);
                        string comprasProveedorTipo = Convert.ToString(row.Cells["comprasProveedorTipo"].Value);
                        string comprasProveedorNumeroDocumento = Convert.ToString(row.Cells["comprasProveedorNumeroDocumento"].Value);
                        string comprasProveedorTipoDocumento = Convert.ToString(row.Cells["comprasProveedorTipoDocumento"].Value);

                        string comprasProveedorRazonSocial = Convert.ToString(row.Cells["comprasProveedorRazonSocial"].Value);
                        string comprasCuenta = Convert.ToString(row.Cells["comprasCuenta"].Value);
                        string comprasDescripcion = Convert.ToString(row.Cells["comprasDescripcion"].Value);
                        double comprasBaseImponible = Convert.ToDouble(row.Cells["comprasBaseImponible"].Value);
                        double comprasIgv = Convert.ToDouble(row.Cells["comprasIgv"].Value);
                        double comprasNoGravada = Convert.ToDouble(row.Cells["comprasNoGravada"].Value);
                        double comprasDescuento = Convert.ToDouble(row.Cells["comprasDescuento"].Value);
                        double comprasImporteTotal = Convert.ToDouble(row.Cells["comprasImporteTotal"].Value);
                        double comprasDolares = Convert.ToDouble(row.Cells["comprasDolares"].Value);
                        double comprasTipoCambio = Convert.ToDouble(row.Cells["comprasTipoCambio"].Value);

                        double comprasPercepcion = Convert.ToDouble(row.Cells["comprasPercepcion"].Value);
                        string comprasDestino = Convert.ToString(row.Cells["comprasDestino"].Value);
                        string comprasDescripcionDestino = Convert.ToString(row.Cells["comprasDescripcionDestino"].Value);
                        string comprasCuentaDestino = Convert.ToString(row.Cells["comprasCuentaDestino"].Value);
                        string comprasPago = Convert.ToString(row.Cells["comprasPago"].Value);
                        string comprasCodigo = Convert.ToString(row.Cells["comprasCodigo"].Value);
                        string comprasConstanciaNumero = Convert.ToString(row.Cells["comprasConstanciaNumero"].Value);
                        string comprasConstanciaFechaPago = Convert.ToString(row.Cells["comprasConstanciaFechaPago"].Value);
                        double comprasConstanciaMonto = Convert.ToDouble(row.Cells["comprasConstanciaMonto"].Value);
                        string comprasConstanciaReferencia = Convert.ToString(row.Cells["comprasConstanciaReferencia"].Value);

                        string BancarizacionFecha = Convert.ToString(row.Cells["BancarizacionFecha"].Value);
                        string BancarizacionBco = Convert.ToString(row.Cells["BancarizacionBco"].Value);
                        int BancarizacionOperacion = Convert.ToInt32(row.Cells["BancarizacionOperacion"].Value);
                        double comprasConversionDolares = Convert.ToDouble(row.Cells["comprasConversionDolares"].Value);

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
                                BancarizacionFecha, BancarizacionBco, BancarizacionOperacion, Usuario, comprasConversionDolares
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
                                BancarizacionFecha, BancarizacionBco, BancarizacionOperacion, Usuario, comprasConversionDolares
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
                        int ventasMes = Convert.ToInt32(row.Cells["ventasMes"].Value);
                        string ventasNumeroRegistro = Convert.ToString(row.Cells["ventasNumeroRegistro"].Value);
                        string ventasFechaEmision = Convert.ToString(row.Cells["ventasFechaEmision"].Value);
                        string ventasFechaPago = Convert.ToString(row.Cells["ventasFechaPago"].Value);
                        string ventasCdpTipo = Convert.ToString(row.Cells["ventasCdpTipo"].Value);
                        string ventasCdpSerie = Convert.ToString(row.Cells["ventasCdpSerie"].Value);
                        string ventasCdpNumero = Convert.ToString(row.Cells["ventasCdpNumero"].Value);
                        string ventasProveedorTipo = Convert.ToString(row.Cells["ventasProveedorTipo"].Value);
                        string ventasProveedorNumero = Convert.ToString(row.Cells["ventasProveedorNumero"].Value);
                        string ventasProveedorRazonSocial = Convert.ToString(row.Cells["ventasProveedorRazonSocial"].Value);

                        string ventasCuenta = Convert.ToString(row.Cells["ventasCuenta"].Value);
                        string ventasDescripcion = Convert.ToString(row.Cells["ventasDescripcion"].Value);
                        double ventasValorExportacion = Convert.ToDouble(row.Cells["ventasValorExportacion"].Value);
                        double ventasBaseImponible = Convert.ToDouble(row.Cells["ventasBaseImponible"].Value);
                        double ventasImporteTotalExonerada = Convert.ToDouble(row.Cells["ventasImporteTotalExonerada"].Value);
                        double ventasImporteTotalInafecta = Convert.ToDouble(row.Cells["ventasImporteTotalInafecta"].Value);
                        double ventasIgv = Convert.ToDouble(row.Cells["ventasIgv"].Value);
                        double ventasImporteTotal = Convert.ToDouble(row.Cells["ventasImporteTotal"].Value);
                        double ventasTipoCambio = Convert.ToDouble(row.Cells["ventasTipoCambio"].Value);
                        double ventasDolares = Convert.ToDouble(row.Cells["ventasDolares"].Value);

                        double ventasIgvRetencion = Convert.ToDouble(row.Cells["ventasIgvRetencion"].Value);
                        string ventasCuentaDestino = Convert.ToString(row.Cells["ventasCuentaDestino"].Value);
                        string ventasCuentaDestinoDescripcion = Convert.ToString(row.Cells["ventasCuentaDestinoDescripcion"].Value);
                        string ventasPago = Convert.ToString(row.Cells["ventasPago"].Value);
                        string ventasReferenciaFecha = Convert.ToString(row.Cells["ventasReferenciaFecha"].Value);
                        string ventasReferenciaTipo = Convert.ToString(row.Cells["ventasReferenciaTipo"].Value);
                        string ventasReferenciaSerie = Convert.ToString(row.Cells["ventasReferenciaSerie"].Value);
                        string ventasReferenciaNumero = Convert.ToString(row.Cells["ventasReferenciaNumero"].Value);
                        string ventasCodigo = Convert.ToString(row.Cells["ventasCodigo"].Value);
                        string ventasConstanciaNumero = Convert.ToString(row.Cells["ventasConstanciaNumero"].Value);
                        string ventasConstanciaFechaPago = Convert.ToString(row.Cells["ventasConstanciaFechaPago"].Value);

                        double ventasDetraccionSoles = Convert.ToDouble(row.Cells["ventasDetraccionSoles"].Value);
                        string ventasReferencia = Convert.ToString(row.Cells["ventasReferencia"].Value);
                        string ventasObservacion = Convert.ToString(row.Cells["ventasObservacion"].Value);
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
                if (fecha.Length == 10)
                {
                    DateTime.Parse(fecha);
                    return true;
                }
                return false;
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

                    if (isDate(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasFechaEmision"].Value.ToString()))
                    {
                        fecha = dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasFechaEmision"].Value.ToString();

                        dataTableTipoCambio = tipoCambio.Show(fecha);
                        compra = dataTableTipoCambio.Rows[0]["Compra"].ToString();
                        venta = dataTableTipoCambio.Rows[0]["Venta"].ToString();
                    }
                    else
                        MessageBox.Show("(" + dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasFechaEmision"].Value.ToString() + ") No es una fecha valida \nIngrese una fecha válida con los siguientes formatos: \ndd/mm/yyyy o yyyy-mm-dd");

                    if (venta == null)
                        MessageBox.Show("No se encontro un tipo de cambio para la fecha: " + fecha, "Tipo de Cambio .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasTipoCambio"].Value = venta;
                    break;
                case 9:
                    string ruc;
                    string razonSocial;
                    ruc = dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasProveedorNumeroDocumento"].Value.ToString();
                    razonSocial = proveedor.GetSupplierName(ruc);
                    if (razonSocial == null)
                        MessageBox.Show("No se encontro al proveedor con ruc: " + ruc, "Compras .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        dgvRegistroCompras.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value = razonSocial;
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

                    if (!String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasDolares"].Value.ToString() as String))
                        dolares = Convert.ToDouble(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasDolares"].Value.ToString());

                    if (!String.IsNullOrEmpty(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasTipoCambio"].Value.ToString() as String))
                        tipoCambi = Convert.ToDouble(dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasTipoCambio"].Value.ToString());

                    dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasConversionDolares"].Value = Math.Round((dolares * tipoCambi), 2);
                    break;
                case 12:
                case 23:
                    string codigo;
                    string cuenta;
                    codigo = dgvRegistroCompras.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    cuenta = planContable.GetAcount(codigo);
                    if (cuenta == null)
                        MessageBox.Show("No se encontro una cuenta con código: " + codigo, "Compras .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        dgvRegistroCompras.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = cuenta;
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
                    string fecha, compra, venta;
                    DataTable dataTableTipoCambio = new DataTable();

                    fecha = dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasFechaEmision"].Value.ToString();

                    dataTableTipoCambio = tipoCambio.Show(fecha);
                    compra = dataTableTipoCambio.Rows[0]["Compra"].ToString();
                    venta = dataTableTipoCambio.Rows[0]["Venta"].ToString();

                    if (venta == null)
                        MessageBox.Show("No se encontro un tipo de cambio para la fecha: " + fecha, "Tipo de Cambio .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasTipoCambio"].Value = venta;
                    break;
                case 9:
                    string ruc;
                    string razonSocial;
                    ruc = dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    razonSocial = proveedor.GetSupplierName(ruc);
                    if (razonSocial == null)
                        MessageBox.Show("No se encontro al proveedor con ruc: " + ruc, "Compras .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = razonSocial;
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
            e.Row.DefaultCellStyle.Font = new Font(dgvRegistroCompras.Font, FontStyle.Bold);
        }

        private void dgvVentas_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["ventasId"].Value = GenerateID();
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
            GenerateComprasTXT();
        }

        private void GenerateComprasTXT()
        {
            DataTable dataTable = new DataTable();
            dataTable = compras.GetForTXT();
            if (dataTable.Rows.Count > 0)
            {

                string fileRoute = null, filename;
                if (String.IsNullOrEmpty(txtRutaTXT.Text))
                    MessageBox.Show("Por favor ingresa la ruta a donde gurdar el TXT");
                else
                {
                    fileRoute = txtRutaTXT.Text;

                    string pleLibroCompras = "LE";
                    string pleRuc = "20602111602";
                    string pleAnio = "2020";
                    string pleMes = "03";

                    filename = fileRoute + pleLibroCompras + pleRuc + pleAnio + pleMes + "00080100001111.txt";

                    if (File.Exists(filename))
                    {
                        DialogResult dialogResult = MessageBox.Show("Ya existe un erchivo con el mismo nombre", "Archivos txt .::. Info", MessageBoxButtons.YesNo);
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

        private void CreateComprasTXT(string filename, DataTable dataTable)
        {
            StreamWriter fichero;
            fichero = File.CreateText(filename);
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                string txtPlePeriodo = dataTable.Rows[i]["Periodo"].ToString();
                string txtPleRegimen1 = dataTable.Rows[i]["Regimen1"].ToString();
                string txtPleRegimen2 = dataTable.Rows[i]["Regimen2"].ToString();
                string txtPleFechaEmision = dataTable.Rows[i]["FechaEmision"].ToString();
                string txtPleFechaPago = dataTable.Rows[i]["FechaPago"].ToString();
                string txtPleComprobanteTipo = dataTable.Rows[i]["ComprobanteTipo"].ToString();
                string txtPleComprobanteSerie = dataTable.Rows[i]["ComprobanteSerie"].ToString();
                string txtPleAnioEmisionAduana = dataTable.Rows[i]["AnioEmisionAduana"].ToString();
                string txtPleCampo10 = dataTable.Rows[i]["Campo10"].ToString();
                string txtPleProveedorTipo = dataTable.Rows[i]["ProveedorTipo"].ToString();
                string txtPleProveedorNumero = dataTable.Rows[i]["ProveedorNumero"].ToString();
                string txtPleProveedorNombre = dataTable.Rows[i]["ProveedorNombre"].ToString();
                string txtPleBaseImponible = dataTable.Rows[i]["BaseImponible"].ToString();
                string txtPleIGV = dataTable.Rows[i]["IGV"].ToString();
                string txtPleBaseImponible2 = dataTable.Rows[i]["BaseImponible2"].ToString();
                string txtPleIGV2 = dataTable.Rows[i]["IGV"].ToString();
                string txtPleBaseImponible3 = dataTable.Rows[i]["BaseImponible3"].ToString();
                string txtPleIGV3 = dataTable.Rows[i]["IGV"].ToString();
                string txtPleNoGravada = dataTable.Rows[i]["NoGravada"].ToString();
                string txtPleImpuestoImponible = dataTable.Rows[i]["ImpuestoImponible"].ToString();
                string txtPleOtrosMontos = dataTable.Rows[i]["OtrosMontos"].ToString();
                string txtPleImporteTotal = dataTable.Rows[i]["ImporteTotal"].ToString();
                string txtPleCodigoMoneda = dataTable.Rows[i]["CodigoMoneda"].ToString();
                string txtPleTipoCambio = dataTable.Rows[i]["TipoCambio"].ToString();
                string txtPleConstanciaFechaPago = dataTable.Rows[i]["ConstanciaFechaPago"].ToString();
                string txtPleConstanciaNumero = dataTable.Rows[i]["ConstanciaNumero"].ToString();
                string txtPleMancaDetraccion = dataTable.Rows[i]["MancaDetraccion"].ToString();
                string txtPleCalsificacionBienes = dataTable.Rows[i]["CalsificacionBienes"].ToString();
                string txtPleIdentificacionContrato = dataTable.Rows[i]["IdentificacionContrato"].ToString();
                string txtPleErrorTipo1 = dataTable.Rows[i]["ErrorTipo1"].ToString();
                string txtPleErrorTipo2 = dataTable.Rows[i]["ErrorTipo2"].ToString();
                string txtPleErrorTipo3 = dataTable.Rows[i]["ErrorTipo3"].ToString();
                string txtPleErrorTipo4 = dataTable.Rows[i]["ErrorTipo4"].ToString();
                string txtPleIdentificadorComprobante = dataTable.Rows[i]["IdentificadorComprobante"].ToString();
                string txtPleEstadoIdentifica = dataTable.Rows[i]["EstadoIdentifica"].ToString();
                string txtPleCampoLibre = dataTable.Rows[i]["CampoLibre"].ToString();

                if (txtPleCampoLibre != "") txtPleCampoLibre = "|" + txtPleCampoLibre;

                fichero.WriteLine(
                    txtPlePeriodo + "|" +
                    txtPleRegimen1 + "|" +
                    txtPleRegimen2 + "|" +
                    txtPleFechaEmision + "|" +
                    txtPleFechaPago + "|" +
                    txtPleComprobanteTipo + "|" +
                    txtPleComprobanteSerie + "|" +
                    txtPleAnioEmisionAduana + "|" +
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
                    txtPleConstanciaNumero + "|" +
                    txtPleMancaDetraccion + "|" +
                    txtPleCalsificacionBienes + "|" +
                    txtPleIdentificacionContrato + "|" +
                    txtPleErrorTipo1 + "|" +
                    txtPleErrorTipo2 + "|" +
                    txtPleErrorTipo3 + "|" +
                    txtPleErrorTipo4 + "|" +
                    txtPleIdentificadorComprobante + "|" +
                    txtPleEstadoIdentifica +
                    txtPleCampoLibre
                    );
            }
            fichero.Close();
        }
    }
}
