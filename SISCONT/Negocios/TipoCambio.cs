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
        public DataTable Show(string fecha)
        {
            DataTable dataTable = new DataTable();
            dataTable = daoTipoCambio.Show(fecha);
            return dataTable;
        }

        public DataTable All()
        {
            DataTable dataTableSuppliers = new DataTable();
            dataTableSuppliers = daoTipoCambio.All(); ;
            return dataTableSuppliers;
        }

        public bool Insert(string fecha, double compra, double venta)
        {
            daoTipoCambio.Insert(fecha, compra, venta);
            return true;
        }

        public bool Update(int id, string fecha, double compra, double venta)
        {
            daoTipoCambio.Update(id, fecha, compra, venta);
            return true;
        }

        public bool Destroy(int id)
        {
            daoTipoCambio.Destroy(id);
            return true;
        }
    }
}
