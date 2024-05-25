using Minimarket_ADO;
using Minimarket_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimarket_BL
{
    public class TransportistaBL
    {
        TransportistaADO objTransportistaDO = new TransportistaADO();
        public TransportistaBE ConsultarTransportista(String strCodigo)
        {
            return objTransportistaDO.ConsultarTransportista(strCodigo);
        }
     

    }
}
