using Minimarket_ADO;
using Minimarket_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimarket_BL
{
    public class BoletaBL
    {

        private BoletaADO objBoletaADO = new BoletaADO();

        public bool Registrar(BoletaBE objBoletaBE, DataTable Detalle_Boleta, out string Mensaje)
        {
            return objBoletaADO.RegistrarVenta(objBoletaBE, Detalle_Boleta, out Mensaje);
        }
    }
}
