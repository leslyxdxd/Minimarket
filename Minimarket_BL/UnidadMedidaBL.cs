using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar...
using ProyVentas_ADO;
namespace ProyVentas_BL
{
    public  class UnidadMedidaBL
    {
        UnidadMedidaADO objUnidadMedidaADO = new UnidadMedidaADO();

        public DataTable ListarUM()
        {
            return objUnidadMedidaADO.ListarUM();
        }
        public DataTable ConsultarUMXRemision(String strIdCodigo)
        {
            return objUnidadMedidaADO.ConsultarUMXRemision(strIdCodigo);
        }
        public DataTable ListarUM_Pro()
        {
            return objUnidadMedidaADO.ListarUM_Pro();
        }
    }
}
