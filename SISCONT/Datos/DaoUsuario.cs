using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DaoUsuario
    {
        private Conexion conexion = new Conexion();

        SqlCommand sqlCommand = new SqlCommand();

        public DataTable Login(string usuario, string contrasenia)
        {
            SqlDataReader sqlDataReaderProvider;
            DataTable dataTableProvider = new DataTable("tblUsuarios");

            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_login";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@Usuario", usuario);
            sqlCommand.Parameters.AddWithValue("@Contrasenia", contrasenia);

            sqlCommand.ExecuteNonQuery();
            sqlDataReaderProvider = sqlCommand.ExecuteReader();
            dataTableProvider.Load(sqlDataReaderProvider);
            sqlCommand.Parameters.Clear();

            conexion.CloseConnection();

            if (dataTableProvider.Rows.Count > 0)
                return dataTableProvider;
            else
                return null;
        }
    }
}
