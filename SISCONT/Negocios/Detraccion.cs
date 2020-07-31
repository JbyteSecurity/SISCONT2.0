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

        public DataTable Index()
        {
            return daoDetraccion.Index();
        }

        public DataTable Show(int codigo)
        {
            return daoDetraccion.Show(codigo);
        }

        public bool Insert(int codigo, double monto, double porcentaje)
        {
            return daoDetraccion.Insert(codigo, monto, porcentaje);
        }

        public bool Update(int id, int codigo, double monto, double porcentaje)
        {
            return daoDetraccion.Update(id, codigo, monto, porcentaje);
        }

        public bool Destroy(int id)
        {
            return daoDetraccion.Destroy(id);
        }
    }
}
