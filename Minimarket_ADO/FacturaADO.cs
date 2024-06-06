using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Minimarket_BE;
using Newtonsoft.Json;

namespace Minimarket_ADO
{
    public class FacturaADO
    {
        private readonly string apiUrl = "https://apiperu.dev/api/ruc";
        private readonly string token = "af453f8bef8ba4e615dc14ed34731d5611e5fcdbffaacb767543e09f92a7bcf5";

        private HttpClient GetHttpClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            return client;
        }

        public async Task<FacturaBE> ObtenerFacturaPorRucAsync(string ruc)
        {
            using (HttpClient client = GetHttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"{apiUrl}/{ruc}");
                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    // Mostrar la respuesta JSON en un mensaje de depuración
                    Console.WriteLine($"JSON Response: {data}");

                    // Deserializar el JSON y obtener el objeto `data`
                    var jsonResponse = JsonConvert.DeserializeObject<Dictionary<string, object>>(data);
                    var facturaData = JsonConvert.DeserializeObject<FacturaBE>(jsonResponse["data"].ToString());

                    return facturaData;
                }
                else
                {
                    throw new Exception($"Error al obtener la factura con RUC {ruc} de la API. StatusCode: {response.StatusCode}");
                }
            }
        }
    }
}
