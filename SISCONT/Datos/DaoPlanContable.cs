using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            SqlDataReader sqlDataReaderPlanContable;
            DataTable dataTableProvider = new DataTable("tblPlanContable");

            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_show_name_cuenta";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@codigo", codigo);

            sqlCommand.ExecuteNonQuery();
            sqlDataReaderPlanContable = sqlCommand.ExecuteReader();
            dataTableProvider.Load(sqlDataReaderPlanContable);
            sqlCommand.Parameters.Clear();

            conexion.CloseConnection();

            if (dataTableProvider.Rows.Count > 0)
                return dataTableProvider.Rows[0]["Cuenta"].ToString();
            else
                return null;
        }
    }
}
