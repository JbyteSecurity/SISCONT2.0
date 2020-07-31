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
        SqlCommand comando = new SqlCommand();

        public string ShowAcount(string codigo)
        {
            SqlDataReader sqlDataReaderPlanContable;
            DataTable dataTableProvider = new DataTable("tblPlanContable");

            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "sp_show_name_cuenta";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@codigo", codigo);

            comando.ExecuteNonQuery();
            sqlDataReaderPlanContable = comando.ExecuteReader();
            dataTableProvider.Load(sqlDataReaderPlanContable);
            comando.Parameters.Clear();

            conexion.CloseConnection();

            if (dataTableProvider.Rows.Count > 0)
                return dataTableProvider.Rows[0]["Cuenta"].ToString();
            else
                return null;
        }
    }
}
