using System.Data;
using Datos;

namespace Negocios
{
    public class Rol
    {
        DaoRol daoRol = new DaoRol();

        public DataTable All() { return daoRol.All(); }

        public bool Insert(string nombre) { return daoRol.Insert(nombre); }
        public bool Update(int id, string nombre) { return daoRol.Update(id, nombre); }
        public bool Destroy(int id) { return daoRol.Destroy(id); }
    }
}
