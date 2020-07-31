using System;
using System.Collections.Generic;
using System.Text;
using Datos;

namespace Negocios
{
    public class Ventas
    {
        private DaoVentas daoVentas = new DaoVentas();
        public void save(
            int mes, string numeroRegistro, string fechaEmision, string fechaPago, string cdpTipo, string cdpSerie,
            string cdpNumeroDocumento, string proveedorTipo, string proveedorNumero, string proveedorNombreRazonSocial,
            string cuenta, string descripcion, double valorExportacion, double baseImponible, double importeTotalExonerada,
            double importeTotalInafecta, double igv, double importeTotal, double tipoCambio, double dolares, double igvRetencion,
            string cuentaDestino, string pago, string referenciaFecha, string referenciaTipo, string referenciaSerie, string referenciaNumeroDocumento,
            string codigo, string constanciaNumero, string constanciaFechaPago, double detraccionSoles, string referencia, string observacion
            )
        {
            daoVentas.insert(
                mes, numeroRegistro, fechaEmision, fechaPago, cdpTipo, cdpSerie, cdpNumeroDocumento,
                proveedorTipo, proveedorNumero, proveedorNombreRazonSocial, cuenta, descripcion, valorExportacion, baseImponible,
                importeTotalExonerada, importeTotalInafecta, igv, importeTotal, tipoCambio, dolares, igvRetencion, cuentaDestino,
                pago, referenciaFecha, referenciaTipo, referenciaSerie, referenciaNumeroDocumento, codigo, constanciaNumero,
                constanciaFechaPago, detraccionSoles, referencia, observacion
                );
        }
    }
}
