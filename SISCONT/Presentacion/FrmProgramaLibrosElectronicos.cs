using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            this.tblRegistroComprasTableAdapter.Fill(this.dSCompras.tblRegistroCompras);

            llenarComboTipoComprobante();
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
            guardarCompras();
        }

        //MOSTRAR COMPRAS POR MES ACTUAL
        private void showCurrentMonth()
        {
            DataTable dataTable = new DataTable();
            dataTable = compras.allCurrentMonth();

            dgvRegistroCompras.AutoGenerateColumns = false;

            dgvRegistroCompras.ColumnCount = 3;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dgvRegistroCompras.Columns[0].Name = "comprasID";
                dgvRegistroCompras.Columns[0].HeaderText = "#";
                dgvRegistroCompras.Columns[0].DataPropertyName = dataTable.Rows[i]["comprasID"].ToString();

                dgvRegistroCompras.Columns[0].Name = "comprasNumeroRegistro";
                dgvRegistroCompras.Columns[0].HeaderText = "N° Regitro";
                dgvRegistroCompras.Columns[0].DataPropertyName = dataTable.Rows[i]["comprasNumeroRegistro"].ToString();

                dgvRegistroCompras.Columns[0].Name = "comprasFechaEmision";
                dgvRegistroCompras.Columns[0].HeaderText = "Fecha Emisión";
                dgvRegistroCompras.Columns[0].DataPropertyName = dataTable.Rows[i]["comprasFechaEmision"].ToString();

                dgvRegistroCompras.Columns[0].Name = "comprasFechaPago";
                dgvRegistroCompras.Columns[0].HeaderText = "Fecha Pago";
                dgvRegistroCompras.Columns[0].DataPropertyName = dataTable.Rows[i]["comprasFechaPago"].ToString();

                dgvRegistroCompras.Columns[0].Name = "comprasCdpTipo";
                dgvRegistroCompras.Columns[0].HeaderText = "Tipo Comprobante";
                dgvRegistroCompras.Columns[0].DataPropertyName = dataTable.Rows[i]["comprasCdpTipo"].ToString();

                dgvRegistroCompras.Columns[0].Name = "comprasCdpSerie";
                dgvRegistroCompras.Columns[0].HeaderText = "Serie Comprobante";
                dgvRegistroCompras.Columns[0].DataPropertyName = dataTable.Rows[i]["comprasCdpSerie"].ToString();
            }

            dgvRegistroCompras.DataSource = dataTable;
        }

        //GUARDAR Compras 
        private void guardarCompras()
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

                        if (id < 1)
                        {
                            compras.save(
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
                            compras.update(
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
                updateDataGridViewCompras();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Ventas .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //GUARDAR Ventas 
        private void guardarVentas()
        {
            try
            {
                foreach (DataGridViewRow row in dgvRegistroVentas.Rows)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(row.Cells["ventasMes"].Value)))
                    {
                        ventas.save(
                            Convert.ToInt32(row.Cells["ventasMes"].Value),
                            Convert.ToString(row.Cells["ventasNumeroRegistro"].Value),
                            Convert.ToString(row.Cells["ventasFechaEmision"].Value),
                            Convert.ToString(row.Cells["ventasFechaPago"].Value),
                            Convert.ToString(row.Cells["ventasCdpTipo"].Value),
                            Convert.ToString(row.Cells["ventasCdpSerie"].Value),
                            Convert.ToString(row.Cells["ventasCdpNumero"].Value),
                            Convert.ToString(row.Cells["ventasProveedorTipo"].Value),
                            Convert.ToString(row.Cells["ventasProveedorNumero"].Value),
                            Convert.ToString(row.Cells["ventasProveedorRazonSocial"].Value),

                            Convert.ToString(row.Cells["ventasCuenta"].Value),
                            Convert.ToString(row.Cells["ventasDescripcion"].Value),
                            Convert.ToDouble(row.Cells["ventasValorExportacion"].Value),
                            Convert.ToDouble(row.Cells["ventasBaseImponible"].Value),
                            Convert.ToDouble(row.Cells["ventasImporteTotalExonerada"].Value),
                            Convert.ToDouble(row.Cells["ventasImporteTotalInafecta"].Value),
                            Convert.ToDouble(row.Cells["ventasIgv"].Value),
                            Convert.ToDouble(row.Cells["ventasImporteTotal"].Value),
                            Convert.ToDouble(row.Cells["ventasTipoCambio"].Value),
                            Convert.ToDouble(row.Cells["ventasDolares"].Value),

                            Convert.ToDouble(row.Cells["ventasIgvRetencion"].Value),
                            Convert.ToString(row.Cells["ventasCuentaDestino"].Value),
                            Convert.ToString(row.Cells["ventasPago"].Value),
                            Convert.ToString(row.Cells["ventasReferenciaFecha"].Value),
                            Convert.ToString(row.Cells["ventasReferenciaTipo"].Value),
                            Convert.ToString(row.Cells["ventasReferenciaSerie"].Value),
                            Convert.ToString(row.Cells["ventasReferenciaNumero"].Value),
                            Convert.ToString(row.Cells["ventasCodigo"].Value),
                            Convert.ToString(row.Cells["ventasConstanciaNumero"].Value),
                            Convert.ToString(row.Cells["ventasConstanciaFechaPago"].Value),

                            Convert.ToDouble(row.Cells["ventasDetraccionSoles"].Value),
                            Convert.ToString(row.Cells["ventasReferencia"].Value),
                            Convert.ToString(row.Cells["ventasObservacion"].Value)

                        );

                        MessageBox.Show("Ventas registradas correctamente", "Ventas .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se han encontrado ventas a guardar", "Ventas .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo insertar los datos por: " + ex);
            }
        }

        private void llenarComboTipoComprobante()
        {
            //Compras
            comprasCdpTipo.DisplayMember = "Detail";
            comprasCdpTipo.ValueMember = "numero";
            comprasCdpTipo.DataSource = comprobantePago.getAllCpdTypes();

            //Ventas
            ventasCdpTipo.DisplayMember = "Detail";
            ventasCdpTipo.ValueMember = "numero";
            ventasCdpTipo.DataSource = comprobantePago.getAllCpdTypes();
        }


        private void btnGuardarVentas_Click(object sender, EventArgs e)
        {
            guardarVentas();
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

                        dataTableTipoCambio = tipoCambio.show(fecha);
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
                    razonSocial = proveedor.getSupplierName(ruc);
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
                            dgvRegistroCompras.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
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
                    cuenta = planContable.getAcount(codigo);
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
                    dataTableDetraccion = detraccion.show(comprasCodigo);
                    if (dataTableDetraccion.Rows.Count > 0)
                    {
                        double detraccionProcentaje = Convert.ToDouble(dataTableDetraccion.Rows[0]["porcentaje"].ToString());
                        dgvRegistroCompras.Rows[e.RowIndex].Cells["comprasConstanciaReferencia"].Value = Math.Round(comprasImporteTotal * detraccionProcentaje, 2);
                    }
                    else
                        MessageBox.Show("Ingrese un número entero (1 - 5)");
                    break;
            }

        }

        private void dgvRegistroVentas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 2:
                    string fecha, compra, venta;
                    DataTable dataTableTipoCambio = new DataTable();

                    fecha = dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasFechaEmision"].Value.ToString();

                    dataTableTipoCambio = tipoCambio.show(fecha);
                    compra = dataTableTipoCambio.Rows[0]["Compra"].ToString();
                    venta = dataTableTipoCambio.Rows[0]["Venta"].ToString();

                    if (venta == null)
                        MessageBox.Show("No se encontro un tipo de cambio para la fecha: " + fecha, "Tipo de Cambio .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        dgvRegistroVentas.Rows[e.RowIndex].Cells["ventasTipoCambio"].Value = venta;
                    break;
                case 8:
                    string ruc;
                    string razonSocial;
                    ruc = dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    razonSocial = proveedor.getSupplierName(ruc);
                    if (razonSocial == null)
                        MessageBox.Show("No se encontro al proveedor con ruc: " + ruc, "Compras .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = razonSocial;
                    break;
                case 17:
                    break;

                case 21:
                    string codigo;
                    string cuenta;
                    codigo = dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    cuenta = planContable.getAcount(codigo);
                    if (cuenta == null)
                        MessageBox.Show("No se encontro una cuenta con código: " + codigo, "Compras .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = cuenta;
                    break;
            }
        }

        private void menuItemProveedores_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarCompras_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void delete()
        {
            int id = Convert.ToInt32(dgvRegistroCompras.CurrentRow.Cells["comprasID"].Value);
            if (compras.delete(id))
            {
                MessageBox.Show("Compra Eliminada", "Compras .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            else
                MessageBox.Show("Compra NO Eliminada", "Compras .::. Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnEditarCompras_Click(object sender, EventArgs e)
        {

        }

        private void CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateDataGridViewCompras()
        {
            this.tblRegistroComprasTableAdapter.Fill(this.dSCompras.tblRegistroCompras);
            dgvRegistroCompras.Refresh();
        }
    }
}
