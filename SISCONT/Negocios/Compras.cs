using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Datos;

namespace Negocios
{
    public class Compras
    {

        private DaoCompras daoCompras = new DaoCompras();

        public DataTable AllCurrentMonth() { return daoCompras.AllCurrentMonth(); }

        public DataTable AllByMonthFilter(int anio, int mes) { return daoCompras.AllByMonthFilter(anio, mes); }

        public DataTable GetForTXT(int anio, int mes) { return daoCompras.GetForTXT(anio, mes); }

        public bool Insert(
            int mes, string nReg, string fechaEmision, string fechaPago, string cTipo, string cSeire, string cnDocumento,
            string pTipo, string pNumero, string pDocumento, string pRazonSocial, string cuenta, string descripcion, double baseImponible,
            double igv, double noGravada, double descuento, double importeTotal, double dolares, double tipoCambio, double percepcion, string destino,
            string descripcionDestino, string cuentaDestino, string pago, string codigo, string constanciaNumero, string constanciaFechapago,
            double constanciaMonto, string constanciaReferencia, string bancarizacionFecha, string bancarizacionBco, int bancarizacionOperacion, string referenciaFecha,
            string referenciaTipo, string referenciaSerie, string referenciaNumero, string usuario, double comprasConversionDolares
            )
        {
            return daoCompras.Insert(
                mes, nReg, fechaEmision, fechaPago, cTipo, cSeire, cnDocumento,
                pTipo, pNumero, pDocumento, pRazonSocial, cuenta, descripcion, baseImponible,
                igv, noGravada, descuento, importeTotal, dolares, tipoCambio, percepcion, destino,
                descripcionDestino, cuentaDestino, pago, codigo, constanciaNumero, constanciaFechapago,
                constanciaMonto, constanciaReferencia, bancarizacionFecha, bancarizacionBco, bancarizacionOperacion, referenciaFecha,
                referenciaTipo, referenciaSerie, referenciaNumero, usuario, comprasConversionDolares
                );
        }

        public bool Update(
            int id, int mes, string nReg, string fechaEmision, string fechaPago, string cTipo, string cSeire, string cnDocumento,
            string pTipo, string pNumero, string pDocumento, string pRazonSocial, string cuenta, string descripcion, double baseImponible,
            double igv, double noGravada, double descuento, double importeTotal, double dolares, double tipoCambio, double percepcion, string destino,
            string descripcionDestino, string cuentaDestino, string pago, string codigo, string constanciaNumero, string constanciaFechapago,
            double constanciaMonto, string constanciaReferencia, string bancarizacionFecha, string bancarizacionBco, int bancarizacionOperacion, string referenciaFecha,
            string referenciaTipo, string referenciaSerie, string referenciaNumero, string usuario,
            double comprasConversionDolares
            )
        {
            return daoCompras.Update(
                id, mes, nReg, fechaEmision, fechaPago, cTipo, cSeire, cnDocumento,
                pTipo, pNumero, pDocumento, pRazonSocial, cuenta, descripcion, baseImponible,
                igv, noGravada, descuento, importeTotal, dolares, tipoCambio, percepcion, destino,
                descripcionDestino, cuentaDestino, pago, codigo, constanciaNumero, constanciaFechapago,
                constanciaMonto, constanciaReferencia, bancarizacionFecha, bancarizacionBco, bancarizacionOperacion, referenciaFecha, referenciaTipo,
                referenciaSerie, referenciaNumero, usuario, comprasConversionDolares
                );
        }

        public bool Destroy(int id)
        {
            return daoCompras.Destroy(id);
        }
    }
}
