using Minimarket_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimarket_ADO
{
    public class BoletaADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataView dtv;

        public bool RegistrarVenta(BoletaBE objBoletaBE, DataTable Detalle_Boleta, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_RegistrarBoleta";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Usu_Registro", objBoletaBE.Usu_Registro);
                cmd.Parameters.AddWithValue("@Nombres_Cliente", objBoletaBE.Nombres_Cliente);
                cmd.Parameters.AddWithValue("@Apellidos_Cliente", objBoletaBE.Apellidos_Cliente);
                cmd.Parameters.AddWithValue("@Dni_Cliente", objBoletaBE.Dni_Cliente);

                // Agregar el parámetro de tipo tabla para los detalles de la boleta
                SqlParameter paramDetalle = new SqlParameter("@DetalleBoleta", SqlDbType.Structured);
                paramDetalle.TypeName = "EDetalle_Boleta"; // Asegúrate que este sea el tipo definido en SQL Server
                paramDetalle.Value = Detalle_Boleta;
                cmd.Parameters.Add(paramDetalle);

                cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                cnx.Open();
                cmd.ExecuteNonQuery();

                Respuesta = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);
                Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
            }

            return Respuesta;
        }

        public bool SumarStock(String idproducto, int cantidad)
        {
            bool respuesta = true;

            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_SumarStockTienda";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@idproducto", idproducto);

                cnx.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Aquí podrías loguear el error si es necesario
                respuesta = false;
            }

            return respuesta;
        }



        public bool RestarStock(String idproducto, int cantidad)
        {
            bool respuesta = true;

           
                try
                {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_RestarStockTienda";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@idproducto", idproducto);
                cnx.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
                {
                    // Aquí podrías loguear el error si es necesario
                    respuesta = false;
                }
            
            return respuesta;
        }





    }
}

