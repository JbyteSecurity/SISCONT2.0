using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

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

        public DataTable All()
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_all_user";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);
            conexion.CloseConnection();
            return dataTable;
        }

        public DataTable Show(string usuario)
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();

            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_show_user";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@Usuario", usuario);

            sqlCommand.ExecuteNonQuery();
            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);
            sqlCommand.Parameters.Clear();

            conexion.CloseConnection();
            return dataTable;
        }

        public bool Insert(string usuario, string contrasenia, string nombre, string correo, string telefono, int rolId)
        {
            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_insert_user";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@Usuario", usuario);
            sqlCommand.Parameters.AddWithValue("@Contrasenia", GetSHA1(contrasenia));
            sqlCommand.Parameters.AddWithValue("@Nombre", nombre);
            sqlCommand.Parameters.AddWithValue("@Correo", correo);
            sqlCommand.Parameters.AddWithValue("@Telefono", telefono);
            sqlCommand.Parameters.AddWithValue("@RolId", rolId);

            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                sqlCommand.Parameters.Clear();
                conexion.CloseConnection();
                return true;
            }
            else
                return false;
        }

        public bool Update(int id, string usuario, string contrasenia, string nombre, string correo, string telefono, int rolId)
        {
            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_update_user";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@idUsuario", id);
            sqlCommand.Parameters.AddWithValue("@Usuario", usuario);
            sqlCommand.Parameters.AddWithValue("@Contrasenia", GetSHA1(contrasenia));
            sqlCommand.Parameters.AddWithValue("@Nombre", nombre);
            sqlCommand.Parameters.AddWithValue("@Correo", correo);
            sqlCommand.Parameters.AddWithValue("@Telefono", telefono);
            sqlCommand.Parameters.AddWithValue("@RolId", rolId);

            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                sqlCommand.Parameters.Clear();
                conexion.CloseConnection();
                return true;
            }
            else
                return false;
        }

        public bool Destroy(int id)
        {
            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_delete_user";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@idUsuario", id);

            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                sqlCommand.Parameters.Clear();
                conexion.CloseConnection();
                return true;
            }
            else
                return false;
        }

        public string GetSHA1(String password)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(password);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }
    }
}
