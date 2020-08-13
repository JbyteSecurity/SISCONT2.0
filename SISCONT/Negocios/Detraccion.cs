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

        public DataTable GetForCombo() { return daoDetraccion.GetForCombo(); }

        public bool Insert(int codigo, double monto, double porcentaje, string definicion, int anexo)
        {
            return daoDetraccion.Insert(codigo, monto, porcentaje, definicion, anexo);
        }

        public bool Update(int id, int codigo, double monto, double porcentaje, string definicion, int anexo)
        {
            return daoDetraccion.Update(id, codigo, monto, porcentaje, definicion, anexo);
        }

        public bool Destroy(int id)
        {
            return daoDetraccion.Destroy(id);
        }
    }
}
