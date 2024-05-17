﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minimarket_ADO;
using Minimarket_BE;

namespace Minimarket_BL
{
    public class RemisionBL
    {
        RemisionADO objRemisionADO = new RemisionADO();

        public DataTable ListarGuiasProveedoresFechas(String strCodigo, DateTime FecIni, DateTime FecFin)
        {
            return objRemisionADO.ListarGuiasProveedoresFechas(strCodigo,  FecIni,  FecFin);

        }

        public Boolean InsertarRemision(RemisionBE objRemisionBE)
        {
            return objRemisionADO.InsertarRemision(objRemisionBE);
        }






    }
}
