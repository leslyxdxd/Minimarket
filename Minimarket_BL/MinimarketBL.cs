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
    public class MinimarketBL
    {
        MinimarketADO objMinimarketADO = new MinimarketADO();

        public DataTable ListarMinimarket()
        {
            return objMinimarketADO.ListarMinimarket();
        }

        public MinimarketBE ObtenerDatosMinimarket()
        {
                return objMinimarketADO.ObtenerDatosMinimarket();    
        }

        public DataTable ListarMinimarketActivos()
        {
            return objMinimarketADO.ListarMinimarketActivos();
        }

        public Boolean InsertarMinimarket(MinimarketBE objMinimarketBE)
        {
            return objMinimarketADO.InsertarMinimarket(objMinimarketBE);
        }


        public Boolean ActualizarMinimarket(MinimarketBE objMinimarketBE)
        {
            return objMinimarketADO.ActualizarMinimarket(objMinimarketBE);
        }


        public MinimarketBE ConsultarMinimarket(Int16 strCodigo)
        {
            return objMinimarketADO.ConsultarMinimarket(strCodigo);
        }


        public Boolean InhabilitarMinimarket(MinimarketBE objMinimarketBE)
        {
            return objMinimarketADO.InhabilitarMinimarket(objMinimarketBE);
        }
        
    }
}
