using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Data;
using Datos;

namespace Negocios
{
    public class Proveedor
    {
        private DaoProveedor daoProveedor = new DaoProveedor();
        public string GetSupplierName(string ruc)
        {
            string razonSocial;
            razonSocial = daoProveedor.Show(ruc);
            return razonSocial;
        }

        public DataTable All()
        {
            return daoProveedor.All();
        }

        public bool Insert(string ruc, string razonSocial)
        {
            daoProveedor.Insert(ruc, razonSocial);
            return true;
        }

        public bool Update(int id, string ruc, string razonSocial)
        {
            daoProveedor.Update(id, ruc, razonSocial);
            return true;
        }

        public bool Destroy(int id)
        {
            daoProveedor.Destroy(id);
            return true;
        }
    }
}
