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

        public DataTable AllByMonthFilter(int anio, int mes) { return daoVentas.AllByMonthFilter(anio, mes); }

        public DataTable GetForTXT(int anio, int mes) { return daoVentas.GetForTXT(anio, mes); }

        public bool Insert(
            string numeroRegistro, string fechaEmision, string fechaPago, string cdpTipo, string cdpSerie,
            string cdpNumeroDocumento, string proveedorTipo, string proveedorNumero, string proveedorNombreRazonSocial,
            string cuenta, string descripcion, double valorExportacion, double baseImponible, double importeTotalExonerada,
            double importeTotalInafecta, double igv, double importeTotal, double tipoCambio, double dolares, double igvRetencion,
            string cuentaDestino, string cuentaDestinoDescripcion, string referenciaFecha, string referenciaTipo, string referenciaSerie, string referenciaNumeroDocumento,
            string codigo, string constanciaNumero, string constanciaFechaPago, double detraccionSoles, string referencia, string observacion, string usuario
            )
        {
            return daoVentas.Insert(
                numeroRegistro, fechaEmision, fechaPago, cdpTipo, cdpSerie, cdpNumeroDocumento,
                proveedorTipo, proveedorNumero, proveedorNombreRazonSocial, cuenta, descripcion, valorExportacion, baseImponible,
                importeTotalExonerada, importeTotalInafecta, igv, importeTotal, tipoCambio, dolares, igvRetencion, cuentaDestino,
                cuentaDestinoDescripcion, referenciaFecha, referenciaTipo, referenciaSerie, referenciaNumeroDocumento, codigo, constanciaNumero,
                constanciaFechaPago, detraccionSoles, referencia, observacion, usuario
                );
        }

        public bool Update(
            int id, string numeroRegistro, string fechaEmision, string fechaPago, string cdpTipo, string cdpSerie,
            string cdpNumeroDocumento, string proveedorTipo, string proveedorNumero, string proveedorNombreRazonSocial,
            string cuenta, string descripcion, double valorExportacion, double baseImponible, double importeTotalExonerada,
            double importeTotalInafecta, double igv, double importeTotal, double tipoCambio, double dolares, double igvRetencion,
            string cuentaDestino, string cuentaDestinoDescripcion, string referenciaFecha, string referenciaTipo, string referenciaSerie, string referenciaNumeroDocumento,
            string codigo, string constanciaNumero, string constanciaFechaPago, double detraccionSoles, string referencia, string observacion, string usuario
            )
        {
            return daoVentas.Update(
                id, numeroRegistro, fechaEmision, fechaPago, cdpTipo, cdpSerie, cdpNumeroDocumento,
                proveedorTipo, proveedorNumero, proveedorNombreRazonSocial, cuenta, descripcion, valorExportacion, baseImponible,
                importeTotalExonerada, importeTotalInafecta, igv, importeTotal, tipoCambio, dolares, igvRetencion, cuentaDestino,
                cuentaDestinoDescripcion, referenciaFecha, referenciaTipo, referenciaSerie, referenciaNumeroDocumento, codigo, constanciaNumero,
                constanciaFechaPago, detraccionSoles, referencia, observacion, usuario
                );
        }

        public bool Destroy(int id) { return daoVentas.Destroy(id); }
    }
}
