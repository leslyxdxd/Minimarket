using System;
using System.Threading.Tasks;
using Minimarket_BE;
using Minimarket_ADO;
using System.Data;

namespace Minimarket_BL
{
    public class FacturaBL
    {
        private readonly FacturaADO facturaADO;

        FacturaADO objFacturaADO = new FacturaADO();

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


        public bool RegistrarFactura(FacturaBE objFacturaBL, DataTable DetalleFactura, out string Mensaje)
        {
            return objFacturaADO.RegistrarFactura(objFacturaBL, DetalleFactura, out Mensaje);
        }

        public DataTable ListarFactura()
        {
            return objFacturaADO.ListarFactura();
        }

        public DataTable ConsultarFactura(String strCodigo)
        {
            return objFacturaADO.ConsultarFactura(strCodigo);
        }
    }
}
