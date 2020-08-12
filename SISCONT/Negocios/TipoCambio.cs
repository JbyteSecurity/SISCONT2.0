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
            return daoTipoCambio.Show(fecha);
        }

        public DataTable All()
        {
            return daoTipoCambio.All();
        }

        public bool Insert(string fecha, double compra, double venta)
        {
            return daoTipoCambio.Insert(fecha, compra, venta);
        }

        public bool Update(int id, string fecha, double compra, double venta)
        {
            
            return daoTipoCambio.Update(id, fecha, compra, venta);
        }

        public bool Destroy(int id)
        {
            return daoTipoCambio.Destroy(id);
        }
    }
}
