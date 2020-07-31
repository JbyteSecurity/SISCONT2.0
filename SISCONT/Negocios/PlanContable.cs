using System;
using System.Collections.Generic;
using System.Text;
using Datos;

namespace Negocios
{
    public class PlanContable
    {
        private DaoPlanContable daoPlanContable = new DaoPlanContable();

        public string GetAcount(string codigo)
        {
            string cuenta;
            cuenta = daoPlanContable.ShowAcount(codigo);
            return cuenta;
        }
    }
}
