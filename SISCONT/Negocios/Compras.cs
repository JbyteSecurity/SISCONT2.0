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

        public DataTable AllCurrentMonth()
        {
            return daoCompras.AllCurrentMonth();
        }
        public DataTable GetForTXT() { return daoCompras.GetForTXT(); }

        public void Insert(
            int mes, string nReg, string fechaEmision, string fechaPago, string cTipo, string cSeire, string cnDocumento,
            string pTipo, string pNumero, string pDocumento, string pRazonSocial, string cuenta, string descripcion, double baseImponible,
            double igv, double noGravada, double descuento, double importeTotal, double dolares, double tipoCambio, double percepcion, string destino,
            string descripcionDestino, string cuentaDestino, string pago, string codigo, string constanciaNumero, string constanciaFechapago,
            double constanciaMonto, string constanciaReferencia, string bancarizacionFecha, string bancarizacionBco, int bancarizacionOperacion, string usuario, double comprasConversionDolares
            )
        {
            daoCompras.Insert(
                mes,
                nReg,
                fechaEmision,
                fechaPago,
                cTipo,
                cSeire,
                cnDocumento,
                pTipo,
                pNumero,
                pDocumento,
                pRazonSocial,
                cuenta,
                descripcion,
                baseImponible,
                igv,
                noGravada,
                descuento,
                importeTotal,
                dolares,
                tipoCambio,
                percepcion,
                destino,
                descripcionDestino,
                cuentaDestino,
                pago,
                codigo,
                constanciaNumero,
                constanciaFechapago,
                constanciaMonto,
                constanciaReferencia,
                bancarizacionFecha,
                bancarizacionBco,
                bancarizacionOperacion,
                usuario,
                comprasConversionDolares
                );
        }

        public void Update(
            int id, int mes, string nReg, string fechaEmision, string fechaPago, string cTipo, string cSeire, string cnDocumento,
            string pTipo, string pNumero, string pDocumento, string pRazonSocial, string cuenta, string descripcion, double baseImponible,
            double igv, double noGravada, double descuento, double importeTotal, double dolares, double tipoCambio, double percepcion, string destino,
            string descripcionDestino, string cuentaDestino, string pago, string codigo, string constanciaNumero, string constanciaFechapago,
            double constanciaMonto, string constanciaReferencia, string bancarizacionFecha, string bancarizacionBco, int bancarizacionOperacion, string usuario,
            double comprasConversionDolares
            )
        {
            daoCompras.Update(
                id,
                mes,
                nReg,
                fechaEmision,
                fechaPago,
                cTipo,
                cSeire,
                cnDocumento,
                pTipo,
                pNumero,
                pDocumento,
                pRazonSocial,
                cuenta,
                descripcion,
                baseImponible,
                igv,
                noGravada,
                descuento,
                importeTotal,
                dolares,
                tipoCambio,
                percepcion,
                destino,
                descripcionDestino,
                cuentaDestino,
                pago,
                codigo,
                constanciaNumero,
                constanciaFechapago,
                constanciaMonto,
                constanciaReferencia,
                bancarizacionFecha,
                bancarizacionBco,
                bancarizacionOperacion,
                usuario,
                comprasConversionDolares
                );
        }

        public bool Destroy(int id)
        {
            daoCompras.Destroy(id);
            return true;
        }
    }
}
