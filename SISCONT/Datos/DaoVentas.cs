using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class DaoVentas
    {
        private Conexion conexion = new Conexion();

        SqlCommand comando = new SqlCommand();

        public void insert(
            int mes, string numeroRegistro, string fechaEmision, string fechaPago, string cdpTipo, string cdpSerie,
            string cdpNumeroDocumento, string proveedorTipo, string proveedorNumero, string proveedorNombreRazonSocial,
            string cuenta, string descripcion, double valorExportacion, double baseImponible, double importeTotalExonerada,
            double importeTotalInafecta, double igv, double importeTotal, double tipoCambio, double dolares, double igvRetencion,
            string cuentaDestino, string pago, string referenciaFecha, string referenciaTipo, string referenciaSerie, string referenciaNumeroDocumento,
            string codigo, string constanciaNumero, string constanciaFechaPago, double detraccionSoles, string referencia, string observacion
            )
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "sp_insert_registro_ventas";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Mes", mes);
            comando.Parameters.AddWithValue("@NReg", numeroRegistro);
            comando.Parameters.AddWithValue("@FechaEmision", fechaEmision);
            comando.Parameters.AddWithValue("@FechaPago", fechaPago);
            comando.Parameters.AddWithValue("@CTipo", cdpTipo);
            comando.Parameters.AddWithValue("@CSerie", cdpSerie);
            comando.Parameters.AddWithValue("@CNDocumento", cdpNumeroDocumento);
            comando.Parameters.AddWithValue("@PTipo", proveedorTipo);
            comando.Parameters.AddWithValue("@PNumero", proveedorNumero);
            comando.Parameters.AddWithValue("@PNombreRazonSocial", proveedorNombreRazonSocial);
            comando.Parameters.AddWithValue("@Cuenta", cuenta);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@ValorExportacion", valorExportacion);
            comando.Parameters.AddWithValue("@BaseImponible", baseImponible);
            comando.Parameters.AddWithValue("@ImporteTotalExonerada", importeTotalExonerada);
            comando.Parameters.AddWithValue("@ImporteTotalInafecta", importeTotalInafecta);
            comando.Parameters.AddWithValue("@IGV", igv);
            comando.Parameters.AddWithValue("@ImporteTotal", importeTotal);
            comando.Parameters.AddWithValue("@TC", tipoCambio);
            comando.Parameters.AddWithValue("@Dolares", dolares);
            comando.Parameters.AddWithValue("@IgvRetencion", igvRetencion);
            comando.Parameters.AddWithValue("@CuentaDestino", cuentaDestino);
            comando.Parameters.AddWithValue("@Pago", pago);
            comando.Parameters.AddWithValue("@ReferenciaFecha", referenciaFecha);
            comando.Parameters.AddWithValue("@ReferenciaTipo", referenciaTipo);
            comando.Parameters.AddWithValue("@ReferenciaSerie", referenciaSerie);
            comando.Parameters.AddWithValue("@ReferenciaNumeroDocumento", referenciaNumeroDocumento);
            comando.Parameters.AddWithValue("@Codigo", codigo);
            comando.Parameters.AddWithValue("@ConstanciaNumero", constanciaNumero);
            comando.Parameters.AddWithValue("@ConstanciaFechaPago", constanciaFechaPago);
            comando.Parameters.AddWithValue("@DetraccionSoles", detraccionSoles);
            comando.Parameters.AddWithValue("@Referencia", referencia);
            comando.Parameters.AddWithValue("@Observacion", observacion);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CloseConnection();
        }
    }
}
