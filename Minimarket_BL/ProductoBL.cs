﻿using Minimarket_ADO;
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
        public DataTable ListarProductoxProveedor()
        {
            return objProductoADO.ListarProductoxProveedor();
        }
        public ProductoBE ConsultarProducto(String strCodigo)
        {
            return objProductoADO.ConsultarProducto(strCodigo);
        }
        public DataTable ProveedorxProducto(String strProducto)
        {
            return objProductoADO.ProveedorxProducto(strProducto);
        }

    }
}
