using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Minimarket_BE;
using Newtonsoft.Json;

namespace Minimarket_ADO
{
    public class ClienteADO
    {
        private readonly string apiUrl = "https://apiperu.dev/api/dni";
        private readonly string token = "bf2be1ada10b09fc57758607c77d4a806c25122ab34daee5ee2026a23c51e0f3";

        private HttpClient GetHttpClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            return client;
        }

        public async Task<ClienteBE> ObtenerClientePorDniAsync(string dni)
        {
            try
            {
                using (HttpClient client = GetHttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"{apiUrl}/{dni}");
                    if (response.IsSuccessStatusCode)
                    {
                        string data = await response.Content.ReadAsStringAsync();
                        // Mostrar la respuesta JSON en un mensaje de depuración
                        Console.WriteLine($"JSON Response: {data}");

                        // Deserializar el JSON y obtener el objeto `data`
                        var jsonResponse = JsonConvert.DeserializeObject<Dictionary<string, object>>(data);
                        Console.WriteLine("Data Deserialized successfully.");

                        var clienteData = JsonConvert.DeserializeObject<ClienteBE>(jsonResponse["data"].ToString());

                        return clienteData;
                    }
                    else
                    {
                        throw new Exception($"Error al obtener el cliente con DNI {dni} de la API. StatusCode: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en la lógica de negocios al obtener el cliente con DNI {dni}.", ex);
            }
        }






    }
}
