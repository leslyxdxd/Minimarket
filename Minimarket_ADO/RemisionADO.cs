using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Minimarket_BE;


namespace Minimarket_ADO
{
    public class RemisionADO
    {

        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;



        public DataTable ListarGuiasProveedoresFechas(String strCodigo, DateTime FecIni, DateTime FecFin)
        {

            try
            {

                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarGuiasProveedoresFechas";
                cmd.Parameters.Clear();


                //parametros del store procedure
                cmd.Parameters.AddWithValue("@Id_Proveedor", strCodigo);
                cmd.Parameters.AddWithValue("@fecini", FecIni);
                cmd.Parameters.AddWithValue("@fecfin", FecFin);


                ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();

                ada.Fill(dts, "Remision");
                return dts.Tables["Remision"];


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }



        }
        public Boolean InsertarRemision(RemisionBE objRemisionBE)
        {

            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InsertarDetalleRemision";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id_Proveedor", objRemisionBE.Id_Proveedor);
                cmd.Parameters.AddWithValue("@Id_Producto", objRemisionBE.Id_Producto);
                cmd.Parameters.AddWithValue("@Id_Transporte", objRemisionBE.Id_Transporte);
                cmd.Parameters.AddWithValue("@Id_UM", objRemisionBE.Id_UM);
                cmd.Parameters.AddWithValue("@Peso_Carga", objRemisionBE.Peso_Carga);
                cmd.Parameters.AddWithValue("@FechaIni", objRemisionBE.FechaIni);

                cmd.Parameters.AddWithValue("@FechaFin", objRemisionBE.FechaFin);
                cmd.Parameters.AddWithValue("@Punto_Partida", objRemisionBE.Punto_Partida);
                cmd.Parameters.AddWithValue("@Punto_Llegada", objRemisionBE.Punto_Llegada);

                cmd.Parameters.AddWithValue("@Cantidad", objRemisionBE.Cantidad);
                cmd.Parameters.AddWithValue("@Observaciones", objRemisionBE.Observaciones);
                cmd.Parameters.AddWithValue("@Num_Guia", objRemisionBE.Num_Guia);

                cmd.Parameters.AddWithValue("@Usu_Registro", objRemisionBE.Usu_Registro);

    
                //Abrimos y ejecutamos

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }

        public DataTable ListarRemision()
        {

            try
            {

                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarRemision";
                cmd.Parameters.Clear();
                DataSet dts = new DataSet();
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Remision");
                return dts.Tables["Remision"];


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }






    }




}
