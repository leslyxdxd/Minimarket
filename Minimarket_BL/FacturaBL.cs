using System;
using System.Threading.Tasks;
using Minimarket_BE;
using Minimarket_ADO;

namespace Minimarket_BL
{
    public class FacturaBL
    {
        private readonly FacturaADO facturaADO;

        public FacturaBL()
        {
            facturaADO = new FacturaADO();
        }

        public async Task<FacturaBE> ObtenerFacturaPorRucAsync(string ruc)
        {
            try
            {
                return await facturaADO.ObtenerFacturaPorRucAsync(ruc);
            }
            catch (Exception ex)
            {
                // Manejo de errores
                throw new Exception($"Error en la lógica de negocios al obtener la factura con RUC {ruc}.", ex);
            }
        }
    }
}
