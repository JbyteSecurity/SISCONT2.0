using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class DaoTipoCambio
    {
        Conexion conexion = new Conexion();
        SqlCommand sqlCommand = new SqlCommand();

        public DataTable All()
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_all_tipo_cambio";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);
            conexion.CloseConnection();
            return dataTable;
        }

        public DataTable Show(string fecha)
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();

            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_show_tipo_cambio";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@Fecha", Convert.ToDateTime(fecha));

            sqlCommand.ExecuteNonQuery();
            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);
            sqlCommand.Parameters.Clear();

            conexion.CloseConnection();
            return dataTable;
        }

        public void Insert(string fecha, double compra, double venta)
        {
            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_insert_tipo_cambio";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@Fecha", fecha);
            sqlCommand.Parameters.AddWithValue("@Compra", compra);
            sqlCommand.Parameters.AddWithValue("@Venta", venta);

            sqlCommand.ExecuteNonQuery();
            sqlCommand.Parameters.Clear();
            conexion.CloseConnection();
        }

        public void Update(int id, string fecha, double compra, double venta)
        {
            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_update_tipo_cambio";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.Parameters.AddWithValue("@Fecha", fecha);
            sqlCommand.Parameters.AddWithValue("@Compra", compra);
            sqlCommand.Parameters.AddWithValue("@Venta", venta);

            sqlCommand.ExecuteNonQuery();
            sqlCommand.Parameters.Clear();
            conexion.CloseConnection();
        }

        public void Destroy(int id)
        {
            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_delete_tipo_cambio";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@id", id);

            sqlCommand.ExecuteNonQuery();
            sqlCommand.Parameters.Clear();
            conexion.CloseConnection();
        }
    }
}
