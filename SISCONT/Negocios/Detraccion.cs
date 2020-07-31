using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Datos;

namespace Negocios
{
    public class Detraccion
    {
        DaoDetraccion daoDetraccion = new DaoDetraccion();

        public DataTable index()
        {
            return daoDetraccion.index();
        }

        public DataTable show(int codigo)
        {
            return daoDetraccion.show(codigo);
        }

        public bool insert(int codigo, double monto, double porcentaje)
        {
            return daoDetraccion.insert(codigo, monto, porcentaje);
        }

        public bool update(int id, int codigo, double monto, double porcentaje)
        {
            return daoDetraccion.update(id, codigo, monto, porcentaje);
        }

        public bool destroy(int id)
        {
            return daoDetraccion.destroy(id);
        }
    }
}
