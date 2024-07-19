using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Minimarket_BE;

namespace Minimarket_ADO
{
    public class ProductoADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;

        public DataTable ListarProducto()
        {

            try
            {

                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProductos";
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

        public Boolean InsertarProducto(ProductoBE objProductoBE)
        {


            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarNuevoProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nom_Producto", objProductoBE.Nom_Producto);
                cmd.Parameters.AddWithValue("@Id_UM", objProductoBE.Id_UM);
                cmd.Parameters.AddWithValue("@Id_Cat", objProductoBE.Id_Cat);
                cmd.Parameters.AddWithValue("@Id_Proveedor", objProductoBE.Id_Proveedor);
                cmd.Parameters.AddWithValue("@Precio_Unitario", objProductoBE.Precio_Unitario);
                cmd.Parameters.AddWithValue("@Marca", objProductoBE.Marca);
                cmd.Parameters.AddWithValue("@Usu_Registro", objProductoBE.Usu_Registro);

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


        public ProductoBE ConsultarProducto(String strCodigo)
        {

            try
            {
                //Codifique
                ProductoBE objProductoBE = new ProductoBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id_Producto", strCodigo);


                //Abrimos y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();



                if (dtr.HasRows == true)
                {
                    dtr.Read();


                    objProductoBE.Id_Producto = dtr["Id_Producto"].ToString();
                    objProductoBE.Nom_Producto = dtr["Nom_Producto"].ToString();


                    objProductoBE.Id_UM = Convert.ToInt16(dtr["Id_UM"]);
                    objProductoBE.Marca = dtr["Marca"].ToString();

                    objProductoBE.Des_UM = dtr["Des_UM"].ToString();


                  

                }
                dtr.Close();
                return objProductoBE;


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

        public Boolean InhabilitarProducto(ProductoBE objProductoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InhabilitarProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id_Producto", objProductoBE.Id_Producto);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
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

        public Boolean HabilitarProducto(ProductoBE objProductoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_HabilitarProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id_Producto", objProductoBE.Id_Producto);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
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

