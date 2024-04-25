using System;
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

        public DataTable ListarGuiaRemision()
        {
            return objRemisionADO.ListarGuiaRemision();

        }

      



    }
}
