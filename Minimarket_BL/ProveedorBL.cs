using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar...
using Minimarket_ADO;
using Minimarket_BE;

namespace Minimarket_BL
{
    public class ProveedorBL
    {
        ProveedorADO objProveedorADO = new ProveedorADO();

        public DataTable ListarProveedor()
        {
            return objProveedorADO.ListarProveedor();
        }

        public DataTable ListarProveedorActivos()
        {
            return objProveedorADO.ListarProveedorActivos();
        }

        public ProveedorBE ConsultarProveedor(String strCodigo)
        {
            return objProveedorADO.ConsultarProveedor(strCodigo);
        }


        public DataTable ConsultarProductoxProveedor(String strIdCodigo)
        {
            return objProveedorADO.ConsultarProductoxProveedor(strIdCodigo);
        }

        public DataTable ConsultarTransportistaxProveedor(String strIdCodigo)
        {
            return objProveedorADO.ConsultarTransportistaxProveedor(strIdCodigo);
        }

        public Boolean ActualizarProveedor(ProveedorBE objProveedorBE)
        {
            return objProveedorADO.ActualizarProveedor(objProveedorBE);
        }

    }
}