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
    public class MinimarketADO
    {

        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;



        public MinimarketBE ObtenerDatosMinimarket()
        {
            MinimarketBE minimarket = new MinimarketBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ObtenerDatosMinimarket";

            try
            {
                cmd.Parameters.Clear();
                cnx.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        minimarket.Nombre = reader["Nombre"].ToString();
                        minimarket.Direccion = reader["Direccion"].ToString();
                        minimarket.Ruc = reader["Ruc"].ToString();
                    }
                }
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

            return minimarket;
        }




        public DataTable ListarMinimarket()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ListarMinimarket";

            try
            {
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Minimarket");
                return dts.Tables["Minimarket"];

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }



        public DataTable ListarMinimarketActivos()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ListarMinimarketsActivos";

            try
            {
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Minimarket");
                return dts.Tables["Minimarket"];

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }





        public Boolean InsertarMinimarket(MinimarketBE objMinimarketBE)
        {


            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_CrearMinimarket";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", objMinimarketBE.Nombre);
                cmd.Parameters.AddWithValue("@Estado", objMinimarketBE.Estado);
                cmd.Parameters.AddWithValue("@Direccion",objMinimarketBE.Direccion);
                cmd.Parameters.AddWithValue("@Ruc", objMinimarketBE.Ruc);

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



        public MinimarketBE ConsultarMinimarket(Int16 strCodigo)
        {
            MinimarketBE objMinimarketBE = new MinimarketBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ConsultarMinimarket";

            //Agregamos el parametro
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Id_Empresa", strCodigo);

            try
            {
                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objMinimarketBE.Id_Empresa = Convert.ToInt16(dtr["Id_Empresa"].ToString());
                    objMinimarketBE.Nombre = dtr["Nombre"].ToString();
                    objMinimarketBE.Estado = Convert.ToInt16(dtr["estado"]);
                    objMinimarketBE.Ruc = dtr["Ruc"].ToString();
                    objMinimarketBE.des_estado = dtr["des_estado"].ToString();
                    objMinimarketBE.Direccion = dtr["Direccion"].ToString();
                }
                dtr.Close();
                return objMinimarketBE;

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



        public Boolean ActualizarMinimarket(MinimarketBE objMinimarketBE)
        {

            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ModificarMinimarket";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id_Empresa", objMinimarketBE.Id_Empresa);
                cmd.Parameters.AddWithValue("@Nombre", objMinimarketBE.Nombre);
                cmd.Parameters.AddWithValue("@Estado", objMinimarketBE.Estado);
                cmd.Parameters.AddWithValue("@Direccion", objMinimarketBE.Direccion);
                
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











    }
}
