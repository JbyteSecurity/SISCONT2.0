using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Datos;

namespace Negocios
{
    public class PlanContable
    {
        private DaoPlanContable daoPlanContable = new DaoPlanContable();

        public string GetAcount(string codigo) { return daoPlanContable.ShowAcount(codigo); }

        public DataTable ShowAcountFilter(string clasificacion) { return daoPlanContable.ShowAcountFilter(clasificacion); }
    }
}
