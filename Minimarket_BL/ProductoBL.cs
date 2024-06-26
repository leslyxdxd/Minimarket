using Minimarket_ADO;
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
    public class ProductoBL
    {
        ProductoADO objProductoADO = new ProductoADO();

        public DataTable ListarProducto()
        {
            return objProductoADO.ListarProducto();
        }
       
        public ProductoBE ConsultarProducto(String strCodigo)
        {
            return objProductoADO.ConsultarProducto(strCodigo);
        }
        public Boolean InhabilitarProducto(ProductoBE objProductoBE)
        {
            return objProductoADO.InhabilitarProducto(objProductoBE);
        }

        public Boolean HabilitarProducto(ProductoBE objProductoBE)
        {
            return objProductoADO.HabilitarProducto(objProductoBE);
        }



    }
}
