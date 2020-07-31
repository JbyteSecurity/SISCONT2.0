using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Datos;

namespace Negocios
{
    public class Ventas
    {
        private DaoVentas daoVentas = new DaoVentas();

        public DataTable allByMonth() { return daoVentas.AllByMonth(); }

        public bool Insert(
            int mes, string numeroRegistro, string fechaEmision, string fechaPago, string cdpTipo, string cdpSerie,
            string cdpNumeroDocumento, string proveedorTipo, string proveedorNumero, string proveedorNombreRazonSocial,
            string cuenta, string descripcion, double valorExportacion, double baseImponible, double importeTotalExonerada,
            double importeTotalInafecta, double igv, double importeTotal, double tipoCambio, double dolares, double igvRetencion,
            string cuentaDestino, string cuentaDestinoDescripcion, string pago, string referenciaFecha, string referenciaTipo, string referenciaSerie, string referenciaNumeroDocumento,
            string codigo, string constanciaNumero, string constanciaFechaPago, double detraccionSoles, string referencia, string observacion, string usuario
            )
        {
            return daoVentas.Insert(
                mes, numeroRegistro, fechaEmision, fechaPago, cdpTipo, cdpSerie, cdpNumeroDocumento,
                proveedorTipo, proveedorNumero, proveedorNombreRazonSocial, cuenta, descripcion, valorExportacion, baseImponible,
                importeTotalExonerada, importeTotalInafecta, igv, importeTotal, tipoCambio, dolares, igvRetencion, cuentaDestino,
                cuentaDestinoDescripcion, pago, referenciaFecha, referenciaTipo, referenciaSerie, referenciaNumeroDocumento, codigo, constanciaNumero,
                constanciaFechaPago, detraccionSoles, referencia, observacion, usuario
                );
        }

        public bool Update(
            int id, int mes, string numeroRegistro, string fechaEmision, string fechaPago, string cdpTipo, string cdpSerie,
            string cdpNumeroDocumento, string proveedorTipo, string proveedorNumero, string proveedorNombreRazonSocial,
            string cuenta, string descripcion, double valorExportacion, double baseImponible, double importeTotalExonerada,
            double importeTotalInafecta, double igv, double importeTotal, double tipoCambio, double dolares, double igvRetencion,
            string cuentaDestino, string cuentaDestinoDescripcion, string pago, string referenciaFecha, string referenciaTipo, string referenciaSerie, string referenciaNumeroDocumento,
            string codigo, string constanciaNumero, string constanciaFechaPago, double detraccionSoles, string referencia, string observacion, string usuario
            )
        {
            return daoVentas.Update(
                id, mes, numeroRegistro, fechaEmision, fechaPago, cdpTipo, cdpSerie, cdpNumeroDocumento,
                proveedorTipo, proveedorNumero, proveedorNombreRazonSocial, cuenta, descripcion, valorExportacion, baseImponible,
                importeTotalExonerada, importeTotalInafecta, igv, importeTotal, tipoCambio, dolares, igvRetencion, cuentaDestino,
                cuentaDestinoDescripcion, pago, referenciaFecha, referenciaTipo, referenciaSerie, referenciaNumeroDocumento, codigo, constanciaNumero,
                constanciaFechaPago, detraccionSoles, referencia, observacion, usuario
                );
        }

        public bool Destroy(int id) { return daoVentas.Destroy(id); }
    }
}
