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
        public DataTable getAllCpdTypes()
        {
            DataTable dataTableCDPTypes = new DataTable();
            dataTableCDPTypes = daoComprobantePago.allCdpTypes();
            return dataTableCDPTypes;
        }
    }
}
