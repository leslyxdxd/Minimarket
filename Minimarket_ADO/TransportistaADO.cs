using Minimarket_BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimarket_ADO
{
    public class TransportistaADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;

        public TransportistaBE ConsultarTransportista(String strCodigo)
        {

            try
            {
                //Codifique
                TransportistaBE objTransportistaBE = new TransportistaBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarTransportista";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id_Transporte", strCodigo);


                //Abrimos y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();


                if (dtr.HasRows == true)
                {
                    dtr.Read();


                  
                    objTransportistaBE.Ruc_Transporte = dtr["Ruc_Transporte"].ToString();
                    objTransportistaBE.Marca_Transporte = dtr["Marca_Trasporte"].ToString();
                    objTransportistaBE.Empresa_Transporte = dtr["Empresa_Transporte"].ToString();
                    objTransportistaBE.Direccion_Empresa = dtr["Direccion_Empresa"].ToString();
                    objTransportistaBE.Licencia_Transporte = dtr["Licencia_Transporte"].ToString();
                    objTransportistaBE.Placa_Transporte = dtr["Placa_Trasporte"].ToString();

                }
                dtr.Close();
                return objTransportistaBE;


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }



        }



    }
}
