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

        public DataTable ListarProductoxProveedor()
        {

            try
            {

                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProductoxProveedor";
                cmd.Parameters.Clear();
                DataSet dts = new DataSet();
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Productos");
                return dts.Tables["Productos"];


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
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


                    objProductoBE.Precio_Unitario = Convert.ToDecimal(dtr["Precio_Unitario"]);

                    objProductoBE.Des_UM = dtr["Des_UM"].ToString();


                    objProductoBE.Stk_Tienda = Convert.ToInt16(dtr["Stk_Tienda"]);
                   






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















    }
}
