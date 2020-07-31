using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Datos;

namespace Negocios
{
    public class ComprobantePago
    {
        private DaoComprobantePago daoComprobantePago = new DaoComprobantePago();
        public DataTable GetAllCpdTypes()
        {
            DataTable dataTableCDPTypes = new DataTable();
            dataTableCDPTypes = daoComprobantePago.AllCdpTypes();
            return dataTableCDPTypes;
        }
    }
}
