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
    public class MovimientoBL
    {
        MovimientoADO objMovimientoADO = new MovimientoADO();

        public Boolean InsertarMovimiento(MovimientoBE objMovimientoBE)
        {
            return objMovimientoADO.InsertarMovimiento(objMovimientoBE);
        }
        public DataTable ListarMovimiento()
        {
            return objMovimientoADO.ListarMovimiento();
        }
    }
}
