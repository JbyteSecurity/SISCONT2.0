using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DaoRol
    {
        private Conexion conexion = new Conexion();
        SqlCommand sqlCommand = new SqlCommand();

        public DataTable All()
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_all_rol";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);
            conexion.CloseConnection();
            return dataTable;
        }
    }
}
