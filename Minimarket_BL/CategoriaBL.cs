using Minimarket_ADO;
using ProyVentas_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimarket_BL
{
    public class CategoriaBL
    {
        CategoriaADO objCategoriaADO = new CategoriaADO();

        public DataTable ListarCat()
        {
            return objCategoriaADO.ListarCat();
        }
    }
}
