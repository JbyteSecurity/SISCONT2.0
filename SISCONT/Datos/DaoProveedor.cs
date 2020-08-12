using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{

    public class DaoProveedor
    {
        private Conexion conexion = new Conexion();
        SqlCommand sqlCommand = new SqlCommand();

        public string Show(string ruc)
        {
            SqlDataReader sqlDataReaderProvider;
            DataTable dataTableProvider = new DataTable("tblProveedores");

            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_show_name_proveedor";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@ruc", ruc);

            sqlCommand.ExecuteNonQuery();
            sqlDataReaderProvider = sqlCommand.ExecuteReader();
            dataTableProvider.Load(sqlDataReaderProvider);
            sqlCommand.Parameters.Clear();

            conexion.CloseConnection();

            if (dataTableProvider.Rows.Count > 0)
                return dataTableProvider.Rows[0]["RazonSocial"].ToString();
            else
                return null;
        }

        public DataTable All()
        {
            SqlDataReader sqlDataReader;
            DataTable dataTableSuppliers = new DataTable();
            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_all_proveedor";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlDataReader = sqlCommand.ExecuteReader();
            dataTableSuppliers.Load(sqlDataReader);
            conexion.CloseConnection();
            return dataTableSuppliers;

        }

        public bool Insert(string ruc, string razonSocial)
        {
            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_insert_proveedor";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@Ruc", ruc);
            sqlCommand.Parameters.AddWithValue("@RazonSocial", razonSocial);

            if(sqlCommand.ExecuteNonQuery() > 0)
            {
                sqlCommand.Parameters.Clear();
                conexion.CloseConnection();
                return true;
            } return false;
            
        }

        public bool Update(int id, string ruc, string razonSocial)
        {
            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_update_proveedor";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@Id", id);
            sqlCommand.Parameters.AddWithValue("@Ruc", ruc);
            sqlCommand.Parameters.AddWithValue("@RazonSocial", razonSocial);

            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                sqlCommand.Parameters.Clear();
                conexion.CloseConnection();
                return true;
            }
            return false;
        }

        public bool Destroy(int id)
        {
            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_destroy_proveedor";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@id", id);
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                sqlCommand.Parameters.Clear();
                conexion.CloseConnection();
                return true;
            }
            return false;
        }
    }
}
