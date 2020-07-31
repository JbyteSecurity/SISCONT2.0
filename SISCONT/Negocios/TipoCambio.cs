using System;
using System.Collections.Generic;
using System.Text;
using Datos;
using System.Data;

namespace Negocios
{
    public class TipoCambio
    {
        private DaoTipoCambio daoTipoCambio = new DaoTipoCambio();
        public DataTable show(string fecha)
        {
            DataTable dataTable = new DataTable();
            dataTable = daoTipoCambio.show(fecha);
            return dataTable;
        }

        public DataTable all()
        {

            DataTable dataTableSuppliers = new DataTable();
            dataTableSuppliers = daoTipoCambio.all(); ;
            return dataTableSuppliers;

        }

        public bool save(string fecha, double compra, double venta)
        {
            daoTipoCambio.insert(fecha, compra, venta);
            return true;
        }

        public bool edit(int id, string fecha, double compra, double venta)
        {
            daoTipoCambio.update(id, fecha, compra, venta);
            return true;
        }

        public bool delete(int id)
        {
            daoTipoCambio.destroy(id);
            return true;
        }
    }
}
