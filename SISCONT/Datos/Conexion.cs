using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    class Conexion
    {
        #region Connection to SQL Server
        readonly private SqlConnection conexion = new SqlConnection("Data Source=198.12.230.10;Initial Catalog=SISCONT; User ID=procont; Password=Lampara1988");

        public SqlConnection OpenConnection()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public SqlConnection CloseConnection()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
        #endregion
    }
}
