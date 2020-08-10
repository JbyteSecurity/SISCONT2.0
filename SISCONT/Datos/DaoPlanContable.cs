using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DaoPlanContable
    {
        private Conexion conexion = new Conexion();
        SqlCommand sqlCommand = new SqlCommand();

        public string ShowAcount(string codigo)
        {
            DataTable dataTable = new DataTable();
            SqlDataReader sqlDataReader;
            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_show_name_cuenta";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@codigo", codigo);

            sqlCommand.ExecuteNonQuery();
            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);
            sqlCommand.Parameters.Clear();

            conexion.CloseConnection();

            if (dataTable.Rows.Count > 0)
                return dataTable.Rows[0]["Cuenta"].ToString();
            else
                return null;
        }

        public DataTable ShowAcountFilter(string clasificacion)
        {
            DataTable dataTable = new DataTable();
            SqlDataReader sqlDataReader;

            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_show_plan_filter";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@clasificacion", clasificacion);

            sqlCommand.ExecuteNonQuery();
            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);
            sqlCommand.Parameters.Clear();

            conexion.CloseConnection();

            return dataTable;
        }
    }
}
