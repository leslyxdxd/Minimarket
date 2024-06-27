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
    public class MovimientoADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;




        public Boolean InsertarMovimiento(MovimientoBE objMovimientoBE)
        {
            try
            {
                   
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InsertarMovimientoStock";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id_Stock", objMovimientoBE.Id_Stock);
                cmd.Parameters.AddWithValue("@Movimiento_Tienda", objMovimientoBE.Movimiento_Tienda);
                cmd.Parameters.AddWithValue("@Usu_Registro", objMovimientoBE.Usu_Registro);

                cnx.Open();
                cmd.ExecuteNonQuery(); // Ejecutar el procedimiento almacenado sin leer un conjunto de resultados

                // No necesitas procesar resultados ya que este procedimiento no devuelve un conjunto de resultados

                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
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


        public DataTable ListarMovimiento()
        {

            try
            {

                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ListarMovimientosConStock";
                cmd.Parameters.Clear();
                DataSet dts = new DataSet();
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Producto");
                return dts.Tables["Producto"];


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }







    }
}
