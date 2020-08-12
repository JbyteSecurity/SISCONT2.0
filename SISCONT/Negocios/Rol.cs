using System.Data;
using Datos;

namespace Negocios
{
    public class Rol
    {
        DaoRol daoRol = new DaoRol();

        public DataTable All() { return daoRol.All(); }
    }
}
