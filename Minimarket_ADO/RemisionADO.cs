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



        public RemisionBE ConsultarGuiaRemision(String Id_Remision)
        {

            try
            {
                //Codifique
                RemisionBE objRemisionBE = new RemisionBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ConsultarGuiaRemision";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id_Remision", Id_Remision);


                //Abrimos y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();



                if (dtr.HasRows == true)
                {
                    dtr.Read();


                    objRemisionBE.Id_Detalle = Convert.ToInt16(dtr["Id_Detalle"]);
                    objRemisionBE.Id_Proveedor = dtr["Id_Proveedor"].ToString();
                    objRemisionBE.Nom_Proveedor = dtr["Nom_Proveedor"].ToString();
                    objRemisionBE.RUC = dtr["RUC"].ToString();
                    objRemisionBE.Direc_Proveedor = dtr["Direc_Proveedor"].ToString();
                    objRemisionBE.Telefono = dtr["Telefono"].ToString();
                    objRemisionBE.Correo = dtr["Correo"].ToString();
                    objRemisionBE.Id_Producto = dtr["Id_Producto"].ToString();
                    objRemisionBE.Nom_Producto = dtr["Nom_Producto"].ToString();
                    objRemisionBE.Marca = dtr["Marca"].ToString();
                    objRemisionBE.Id_Cat = Convert.ToInt16(dtr["Id_Cat"]);
                    objRemisionBE.Des_Cat = dtr["Des_cat"].ToString();
                    objRemisionBE.Peso_Carga= Convert.ToInt16(dtr["Peso_Carga"]);
                    objRemisionBE.Punto_Llegada = dtr["Punto_Llegada"].ToString();
                    objRemisionBE.Punto_Partida = dtr["Punto_Partida"].ToString();
                    objRemisionBE.Des_UM_Producto = dtr["Des_UM_Producto"].ToString();
                    objRemisionBE.Des_UM_Remision = dtr["Des_UM_Remision"].ToString();
                    objRemisionBE.Observaciones = dtr["Observaciones"].ToString();
                    objRemisionBE.FechaIni = Convert.ToDateTime(dtr["FechaIni"]);
                    objRemisionBE.FechaFin = Convert.ToDateTime(dtr["FechaFin"]);
                    objRemisionBE.Num_Guia = dtr["Num_Guia"].ToString();
                    objRemisionBE.Cantidad = Convert.ToInt16(dtr["Cantidad"]);
                    objRemisionBE.Estado = dtr["Estado"].ToString();
                    objRemisionBE.Id_Transporte = dtr["Id_Transporte"].ToString();
                    objRemisionBE.Empresa_Transporte = dtr["Empresa_Transporte"].ToString();
                    objRemisionBE.Direccion_Empresa = dtr["Direccion_Empresa"].ToString();
                    objRemisionBE.Marca_Trasporte = dtr["Marca_Trasporte"].ToString();
                    objRemisionBE.Licencia_Transporte = dtr["Licencia_Transporte"].ToString();
                    objRemisionBE.Placa_Trasporte = dtr["Placa_Trasporte"].ToString();
                    objRemisionBE.Ruc_Transporte = dtr["Ruc_Transporte"].ToString();
        

                }
                dtr.Close();
                return objRemisionBE;


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


        public Boolean ActualizarRemision(RemisionBE objRemisionBE)
        {

            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ActualizarDetalleRemision";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id_Remision ", objRemisionBE.Id_Proveedor);
                cmd.Parameters.AddWithValue("@Id_Producto", objRemisionBE.Id_Producto);
                cmd.Parameters.AddWithValue("@Cantidad", objRemisionBE.Cantidad);
                cmd.Parameters.AddWithValue("@Observaciones", objRemisionBE.Observaciones);
                cmd.Parameters.AddWithValue("@Id_UM", objRemisionBE.Id_UM);
                cmd.Parameters.AddWithValue("@Peso_Carga", objRemisionBE.Peso_Carga);
                cmd.Parameters.AddWithValue("@Usu_Ult_Mod ", objRemisionBE.Usu_Ult_Mod);
                cmd.Parameters.AddWithValue("@FechaIni", objRemisionBE.FechaIni);
                cmd.Parameters.AddWithValue("@FechaFin", objRemisionBE.FechaFin);
                cmd.Parameters.AddWithValue("@Punto_Partida", objRemisionBE.Punto_Partida);
                cmd.Parameters.AddWithValue("@Punto_Llegada", objRemisionBE.Punto_Llegada);

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
