using System;
using System.Threading.Tasks;
using Minimarket_BE;
using Minimarket_ADO;

namespace Minimarket_BL
{
    public class ClienteBL
    {
        private readonly ClienteADO clienteADO;

        public ClienteBL()
        {
            clienteADO = new ClienteADO();
        }

        public async Task<ClienteBE> ObtenerClientePorDniAsync(string dni)
        {
            try
            {
                return await clienteADO.ObtenerClientePorDniAsync(dni);
            }
            catch (Exception ex)
            {
                // Manejo de errores
                throw new Exception($"Error en la lógica de negocios al obtener el cliente con DNI {dni}.", ex);
            }
        }

    }
}
