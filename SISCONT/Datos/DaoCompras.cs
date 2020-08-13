using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DaoCompras
    {
        private Conexion conexion = new Conexion();
        SqlCommand sqlCommand = new SqlCommand();
        DataSet dataSet = new DataSet();

        public DataTable All()
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_all_registro_ventas";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);
            conexion.CloseConnection();
            return dataTable;
        }

        //public DataTable AllCurrentMonth()
        //{
        //    SqlDataReader sqlDataReader;
        //    DataTable dataTable = new DataTable();
        //    sqlCommand.Connection = conexion.OpenConnection();
        //    sqlCommand.CommandText = "sp_all_current_month_compras";
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    sqlDataReader = sqlCommand.ExecuteReader();
        //    dataTable.Load(sqlDataReader);
        //    conexion.CloseConnection();
        //    return dataTable;
        //}

        public DataSet AllCurrentMonth()
        {
            //SqlCommand sqlCommandMoth = new SqlCommand("sp_all_current_month_compras", conexion.OpenConnection());

            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_all_current_month_compras";

            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataSet, "RegistroCompras");
            return dataSet;
        }

        //public DataTable AllByMonthFilter(int anio, int mes)
        //{
        //    SqlDataReader sqlDataReader;
        //    DataTable dataTable = new DataTable();

        //    sqlCommand.Connection = conexion.OpenConnection();
        //    sqlCommand.CommandText = "sp_all_current_month_compras_filter";
        //    sqlCommand.CommandType = CommandType.StoredProcedure;

        //    sqlCommand.Parameters.AddWithValue("@Anio", anio);
        //    sqlCommand.Parameters.AddWithValue("@Mes", mes);

        //    sqlCommand.ExecuteNonQuery();
        //    sqlDataReader = sqlCommand.ExecuteReader();
        //    dataTable.Load(sqlDataReader);
        //    sqlCommand.Parameters.Clear();

        //    conexion.CloseConnection();
        //    return dataTable;
        //}

        public DataSet AllByMonthFilter(int anio, int mes)
        {
            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_all_current_month_compras_filter";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@Anio", anio);
            sqlCommand.Parameters.AddWithValue("@Mes", mes);
            sqlCommand.Parameters.Clear();


            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataSet, "RegistroComprasFiltro");
            return dataSet;
        }

        public DataTable GetForTXT(int anio, int mes)
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_generate_txt_compras";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@Anio", anio);
            sqlCommand.Parameters.AddWithValue("@Mes", mes);

            sqlCommand.ExecuteNonQuery();
            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);
            sqlCommand.Parameters.Clear();

            conexion.CloseConnection();
            return dataTable;
        }

        public bool Insert(
            /*int mes,*/ string nReg, string fechaEmision, string fechaPago, string cTipo, string cSerie, string cnDocumento,
            string pTipo, string pNumero, /*string pDocumento,*/ string pRazonSocial, string cuenta, string descripcion, double baseImponible,
            double igv, double noGravada, double descuento, double importeTotal, double dolares, double tipoCambio, double percepcion, string destino,
            string descripcionDestino, string cuentaDestino, /*string pago,*/ string codigo, string constanciaNumero, string constanciaFechapago,
            double constanciaMonto, string constanciaReferencia, string bancarizacionFecha, string bancarizacionBco, int bancarizacionOperacion, string referenciaFecha,
            string referenciaTipo, string referenciaSerie, string referenciaNumero, string usuario,
            double conversionDolares, string observacion
            )
        {
            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_insert_compras";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Clear();

            //sqlCommand.Parameters.AddWithValue("@Mes", mes);
            sqlCommand.Parameters.AddWithValue("@NReg", nReg);
            sqlCommand.Parameters.AddWithValue("@FechaEmision", fechaEmision);
            sqlCommand.Parameters.AddWithValue("@FechaPago", fechaPago);
            sqlCommand.Parameters.AddWithValue("@CTipo", cTipo);
            sqlCommand.Parameters.AddWithValue("@CSerie", cSerie);
            sqlCommand.Parameters.AddWithValue("@CNDocumento", cnDocumento);
            sqlCommand.Parameters.AddWithValue("@PTipo", pTipo);
            sqlCommand.Parameters.AddWithValue("@PNumero", pNumero);
            //sqlCommand.Parameters.AddWithValue("@PDocumento", pDocumento);

            sqlCommand.Parameters.AddWithValue("@PNombreRazonSocial", pRazonSocial);
            sqlCommand.Parameters.AddWithValue("@Cuenta", cuenta);
            sqlCommand.Parameters.AddWithValue("@Descripcion", descripcion);
            sqlCommand.Parameters.AddWithValue("@BaseImponible", baseImponible);
            sqlCommand.Parameters.AddWithValue("@IGV", igv);
            sqlCommand.Parameters.AddWithValue("@NoGravada", noGravada);
            sqlCommand.Parameters.AddWithValue("@Descuentos", descuento);
            sqlCommand.Parameters.AddWithValue("@ImporteTotal", importeTotal);
            sqlCommand.Parameters.AddWithValue("@Dolares", dolares);
            sqlCommand.Parameters.AddWithValue("@TipoCambio", tipoCambio);

            sqlCommand.Parameters.AddWithValue("@Percepcion", percepcion);
            sqlCommand.Parameters.AddWithValue("@Destino", destino);
            sqlCommand.Parameters.AddWithValue("@DescripcionDestino", descripcionDestino);
            sqlCommand.Parameters.AddWithValue("@CuentaDestino", cuentaDestino);
            //sqlCommand.Parameters.AddWithValue("@Pgo", pago);
            sqlCommand.Parameters.AddWithValue("@Codigo", codigo);
            sqlCommand.Parameters.AddWithValue("@ConstanciaNumero", constanciaNumero);
            sqlCommand.Parameters.AddWithValue("@ConstanciaFechaPago", constanciaFechapago);
            sqlCommand.Parameters.AddWithValue("@ConstanciaMonto", constanciaMonto);
            sqlCommand.Parameters.AddWithValue("@ConstanciaReferencia", constanciaReferencia);

            sqlCommand.Parameters.AddWithValue("@BancarizacionFecha", bancarizacionFecha);
            sqlCommand.Parameters.AddWithValue("@BancarizacionBco", bancarizacionBco);
            sqlCommand.Parameters.AddWithValue("@BancarizacionOperacion", bancarizacionOperacion);
            sqlCommand.Parameters.AddWithValue("@Usuario", usuario);
            sqlCommand.Parameters.AddWithValue("@ConversionDolar", conversionDolares);

            sqlCommand.Parameters.AddWithValue("@ReferenciaFecha", referenciaFecha);
            sqlCommand.Parameters.AddWithValue("@ReferenciaTipo", referenciaTipo);
            sqlCommand.Parameters.AddWithValue("@ReferenciaSerie", referenciaSerie);
            sqlCommand.Parameters.AddWithValue("@ReferenciaNumero", referenciaNumero);
            sqlCommand.Parameters.AddWithValue("@Observacion", observacion);

            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                sqlCommand.Parameters.Clear();
                conexion.CloseConnection();
                return true;
            }
            return false;
        }

        public bool Update(
            int id, /*int mes,*/ string nReg, string fechaEmision, string fechaPago, string cTipo, string cSerie, string cnDocumento,
            string pTipo, string pNumero, /*string pDocumento,*/ string pRazonSocial, string cuenta, string descripcion, double baseImponible,
            double igv, double noGravada, double descuento, double importeTotal, double dolares, double tipoCambio, double percepcion, string destino,
            string descripcionDestino, string cuentaDestino,/* string pago,*/ string codigo, string constanciaNumero, string constanciaFechapago,
            double constanciaMonto, string constanciaReferencia, string bancarizacionFecha, string bancarizacionBco, int bancarizacionOperacion, string referenciaFecha,
            string referenciaTipo, string referenciaSerie, string referenciaNumero, string usuario,
            double conversionDolares, string observacion
            )
        {
            sqlCommand.Connection = conexion.OpenConnection();
            sqlCommand.CommandText = "sp_update_registro_compras";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Clear();

            sqlCommand.Parameters.AddWithValue("@id", id);
            //sqlCommand.Parameters.AddWithValue("@Mes", mes);
            sqlCommand.Parameters.AddWithValue("@NReg", nReg);
            sqlCommand.Parameters.AddWithValue("@FechaEmision", fechaEmision);
            sqlCommand.Parameters.AddWithValue("@FechaPago", fechaPago);
            sqlCommand.Parameters.AddWithValue("@CTipo", cTipo);
            sqlCommand.Parameters.AddWithValue("@CSerie", cSerie);
            sqlCommand.Parameters.AddWithValue("@CNDocumento", cnDocumento);
            sqlCommand.Parameters.AddWithValue("@PTipo", pTipo);
            sqlCommand.Parameters.AddWithValue("@PNumero", pNumero);
            //sqlCommand.Parameters.AddWithValue("@PDocumento", pDocumento);

            sqlCommand.Parameters.AddWithValue("@PNombreRazonSocial", pRazonSocial);
            sqlCommand.Parameters.AddWithValue("@Cuenta", cuenta);
            sqlCommand.Parameters.AddWithValue("@Descripcion", descripcion);
            sqlCommand.Parameters.AddWithValue("@BaseImponible", baseImponible);
            sqlCommand.Parameters.AddWithValue("@IGV", igv);
            sqlCommand.Parameters.AddWithValue("@NoGravada", noGravada);
            sqlCommand.Parameters.AddWithValue("@Descuentos", descuento);
            sqlCommand.Parameters.AddWithValue("@ImporteTotal", importeTotal);
            sqlCommand.Parameters.AddWithValue("@Dolares", dolares);
            sqlCommand.Parameters.AddWithValue("@TipoCambio", tipoCambio);

            sqlCommand.Parameters.AddWithValue("@Percepcion", percepcion);
            sqlCommand.Parameters.AddWithValue("@Destino", destino);
            sqlCommand.Parameters.AddWithValue("@DescripcionDestino", descripcionDestino);
            sqlCommand.Parameters.AddWithValue("@CuentaDestino", cuentaDestino);
            //sqlCommand.Parameters.AddWithValue("@Pgo", pago);
            sqlCommand.Parameters.AddWithValue("@Codigo", codigo);
            sqlCommand.Parameters.AddWithValue("@ConstanciaNumero", constanciaNumero);
            sqlCommand.Parameters.AddWithValue("@ConstanciaFechaPago", constanciaFechapago);
            sqlCommand.Parameters.AddWithValue("@ConstanciaMonto", constanciaMonto);
            sqlCommand.Parameters.AddWithValue("@ConstanciaReferencia", constanciaReferencia);

            sqlCommand.Parameters.AddWithValue("@BancarizacionFecha", bancarizacionFecha);
            sqlCommand.Parameters.AddWithValue("@BancarizacionBco", bancarizacionBco);
            sqlCommand.Parameters.AddWithValue("@BancarizacionOperacion", bancarizacionOperacion);
            sqlCommand.Parameters.AddWithValue("@Usuario", usuario);
            sqlCommand.Parameters.AddWithValue("@ConversionDolar", conversionDolares);

            sqlCommand.Parameters.AddWithValue("@ReferenciaFecha", referenciaFecha);
            sqlCommand.Parameters.AddWithValue("@ReferenciaTipo", referenciaTipo);
            sqlCommand.Parameters.AddWithValue("@ReferenciaSerie", referenciaSerie);
            sqlCommand.Parameters.AddWithValue("@ReferenciaNumero", referenciaNumero);
            sqlCommand.Parameters.AddWithValue("@Observacion", observacion);

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
            sqlCommand.CommandText = "sp_delete_compras";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Clear();
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
