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
    public class StockBL
    {

        StockADO objStockADO = new StockADO();

        public DataTable ListarStock()
        {
            return objStockADO.ListarStock();

        }

        public StockBE ConsultarProducto(String strCodigo)
        {
            return objStockADO.ConsultarProducto(strCodigo);
        }

     

    }
}
