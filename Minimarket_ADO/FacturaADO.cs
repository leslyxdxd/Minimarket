using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Minimarket_BE;
using Newtonsoft.Json;

namespace Minimarket_ADO
{

    public class FacturaADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;

        private readonly string apiUrl = "https://apiperu.dev/api/ruc";
        private readonly string token = "bf2be1ada10b09fc57758607c77d4a806c25122ab34daee5ee2026a23c51e0f3";

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


        public bool RegistrarFactura(FacturaBE objFacturaBE, DataTable Detalle_FacturaBE, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                // Configuración de la conexión y comando
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_RegistrarFactura";
                cmd.Parameters.Clear();

                // Agregar parámetros para la factura
                cmd.Parameters.AddWithValue("@Ruc", objFacturaBE.ruc);
                cmd.Parameters.AddWithValue("@RazonSocial", objFacturaBE.nombre_o_razon_social);
                cmd.Parameters.AddWithValue("@Estado", objFacturaBE.estado);
                cmd.Parameters.AddWithValue("@Direccion", objFacturaBE.direccion_completa);
                cmd.Parameters.AddWithValue("@Usu_Registro", objFacturaBE.Usu_Registro);

                // Agregar parámetro para los detalles de la factura como tipo estructurado
                SqlParameter paramDetalle = new SqlParameter("@DetalleFactura", SqlDbType.Structured);
                paramDetalle.TypeName = "EDetalle_Factura"; // Asegúrate que este sea el tipo definido en SQL Server
                paramDetalle.Value = Detalle_FacturaBE;

                cmd.Parameters.Add(paramDetalle);

                // Agregar parámetros de salida
                cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                // Abrir conexión y ejecutar
                cnx.Open();
                cmd.ExecuteNonQuery();

                // Obtener resultados de los parámetros de salida
                Respuesta = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);
                Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Respuesta = false;
                Mensaje = ex.Message;
            }
            finally
            {
                // Asegurar que la conexión se cierra
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }

            return Respuesta;
        }

        public DataTable ListarFactura()
        {

            try
            {

                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ListarFacturasDetalleProductos";
                cmd.Parameters.Clear();
                DataSet dts = new DataSet();
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Factura");
                return dts.Tables["Factura"];


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ConsultarFactura(string strCodigo)
        {
            DataTable dtDetalleFactura = new DataTable();

            try
            {
                using (SqlConnection cnx = new SqlConnection(MiConexion.GetCnx()))
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerDetallesFactura", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Factura", strCodigo);

                    cnx.Open();

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        dtDetalleFactura.Load(dtr);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al consultar la factura en la base de datos (SQL): " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error general al consultar la factura: " + ex.Message);
            }

            return dtDetalleFactura;
        }


    }
}
